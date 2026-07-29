namespace RestaurantHR.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // طباخ، كاشير، ويتر
        public string Shift { get; set; } = string.Empty; // صباحي، مسائي
        public decimal BaseSalary { get; set; }
        public int AttendanceDays { get; set; }
        public string Status { get; set; } = "على رأس العمل";
    }
}
