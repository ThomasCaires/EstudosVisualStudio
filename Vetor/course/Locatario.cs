namespace course
{
    class Locatario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Locatario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + "," + Email;
        }
    }
}