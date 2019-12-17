using System;
using System.Collections.Generic;
using System.Data;
using BugReport.Models;
using Dapper;

namespace BugReport.Repositories
{
    public class BugRepository
    {
        private readonly IDbConnection _db;
        public BugRepository(IDbConnection db)
        {
            _db = db;
        }

        public IEnumerable<Bug> Get()
        {
            string sql = "SELECT * FROM bugs";
            return _db.Query<Bug>(sql);
        }

        public int Create(Bug newBug)
        {
            string sql = @"
            INSERT INTO bugs
            (creator, description, title)
            VALUES
            (@Creator, @Description, @Title)
            SELECT LAST_INSERT_ID();
            ";
            return _db.ExecuteScalar<int>(sql, newBug);
        }
    }

}