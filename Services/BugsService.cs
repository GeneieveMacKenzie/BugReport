using System;
using System.Collections.Generic;
using BugReport.Models;
using BugReport.Repositories;

namespace BugReport.Services
{
    public class BugsService
    {
        private readonly BugRepository _repo;
        public BugsService(BugRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<Bug> Get()
        {
            return _repo.Get();
        }
    }
}