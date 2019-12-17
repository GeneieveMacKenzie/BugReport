namespace BugReport.Interfaces
{
    public interface IBug
    {
        string Description {get; set;}
        string Title {get; set;}
        bool isClosed {get; set;}
        string Creator {get; set;}
        string User {get; set;}
        int closedDate {get; set;}
    }
}