using Doctors_Appoinments.Data;
using Doctors_Appoinments.Models;
using Microsoft.AspNetCore.Mvc;

namespace Doctors_Appoinments.Controllers
{
    public class DoctorsController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            var doctors = context.Doctors.ToList();
            return View(doctors);
        }

        public IActionResult MakeAppoint(int id)
        {
            var doctor = context.Doctors.Find(id);  
            if(doctor != null)
                return View(doctor);
            return RedirectToAction("Index");
        } 
        public IActionResult BookAppointment(string PatientName, DateOnly AppoinmentDate, TimeOnly AppoinmentTime)
        {
            var appoint = new Appoinment()
            {
                PatientName = PatientName,
                AppoinmentDate = AppoinmentDate,
                AppoinmentTime = AppoinmentTime
            };
            context.Appoinments.Add(appoint);
            context.SaveChanges();

            return RedirectToAction("ShowAppoinments");
        }

        public IActionResult ShowAppoinments()
        {
            var appoinments = context.Appoinments.ToList();

            return View(appoinments);
        }
    }
}
