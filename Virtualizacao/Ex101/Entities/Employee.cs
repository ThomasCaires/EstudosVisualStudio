
namespace Ex101.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValluePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valluePerHour)
        {
            Name = name;
            Hours = hours;
            ValluePerHour = valluePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValluePerHour;
        }
    }
}
