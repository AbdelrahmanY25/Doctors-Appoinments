namespace Doctors_Appoinments.Models
{
    public class Appoinment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public DateOnly AppoinmentDate { get; set; } 
        public TimeOnly AppoinmentTime { get; set; }
    }
}
