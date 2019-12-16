namespace BugReport.Models
{
    public class Bug : IBug
    {
        public int Id {get; set;}
        public string Description {get; set;}
        public string Title {get; set;}
        public bool isClosed {get; set;}
        public string Creator {get; set;}
        public string User {get; set;}
        public int closedDate {get; set;}
    }
}