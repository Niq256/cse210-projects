public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    // Access `studentName` through a public method
    public string GetStudentName()
    {
        return base.GetSummary().Split(" - ")[0]; // Extract student name from summary
    }
}