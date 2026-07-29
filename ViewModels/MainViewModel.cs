using System.Collections.ObjectModel;
using RestaurantHR.Models;

namespace RestaurantHR.ViewModels
{
    public class MainViewModel
    {
        // قائمة الموظفين التي ستظهر في الجدول
        public ObservableCollection<Employee> Employees { get; set; }

        public MainViewModel()
        {
            // بيانات تجريبية لمطعم
            Employees = new ObservableCollection<Employee>
            {
                new Employee { Id = 1, Name = "أحمد محمود", Role = "مدير صالة", Shift = "صباحي", BaseSalary = 5000, AttendanceDays = 22 },
                new Employee { Id = 2, Name = "سعيد علي", Role = "شيف رئيسي", Shift = "مسائي", BaseSalary = 7000, AttendanceDays = 24 },
                new Employee { Id = 3, Name = "ياسر كمال", Role = "مقدم طعام (ويتر)", Shift = "مرن", BaseSalary = 3000, AttendanceDays = 20, Status = "إجازة" },
                new Employee { Id = 4, Name = "نور الهدى", Role = "كاشير", Shift = "مسائي", BaseSalary = 3500, AttendanceDays = 26 }
            };
        }
    }
}
