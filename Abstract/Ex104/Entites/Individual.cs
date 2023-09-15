namespace Ex104.Entites
{
    internal class Individual : TaxPayer
    {
        public double Health { get; set; }

        public Individual(string name, double anualIncome, double health)
            :base(name, anualIncome)
        {
            Health = health;
        }

        public override double Tax()
        {
           if (AnualIncome <= 20000)
            {
                double Tax = AnualIncome * 0.15 - (Health * 0.50);//variavel health (helth*50%)
                if (Tax < 0) Tax = 0;
                return Tax;
            }
           else
            {
                double Tax = AnualIncome * 0.25 - (Health * 0.50);//variavel health (helth*50%)
                if (Tax < 0) Tax = 0;
                return Tax;
            }
        }
    }
}
