namespace _5_5ZorOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 2001, FirstName = "KAAN", LastName = "SERT", IdentityNumber = 12345 });
        }
    }
}

