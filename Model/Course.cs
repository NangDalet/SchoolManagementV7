namespace SchoolManagementAPI.Model
{
    public class Course
    {
        public Guid Uuid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public bool Active { get; set; }
    }
}
