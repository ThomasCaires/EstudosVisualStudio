
namespace Ex101.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(double additionalCharge, string name, int hours, double valluePerHour)
            :base(name, hours, valluePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
