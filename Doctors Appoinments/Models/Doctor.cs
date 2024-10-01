using ContactDoctor.Models;

namespace ContactDoctor.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Specialization { get; set; } = null!;
        public string Img { get; set; }
    }
}
