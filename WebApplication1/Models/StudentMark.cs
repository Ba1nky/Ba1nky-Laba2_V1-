namespace WebApplication1.Models
{
    public class StudentMark
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public int Mark { get; set; }
        public string Subject { get; set; } = null!;
        public DateTime Date { get; set; }

        public string GetName()
        {
            return LastName + " " + FirstName + " " + FatherName;
        }
    }
}
