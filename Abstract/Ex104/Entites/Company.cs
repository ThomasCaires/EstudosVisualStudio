
namespace Ex104.Entites
{
    internal class Company : TaxPayer
    {
        public int EmployessN { get; set; }

        public Company(string name, double anualIncome, int employessN)
            : base(name, anualIncome)
        {
            EmployessN = employessN;
        }

        public override double Tax()
        {
            if (EmployessN > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }

}
