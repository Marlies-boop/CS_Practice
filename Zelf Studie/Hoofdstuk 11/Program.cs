namespace Hoofdstuk_11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game game = new Game();
            game.RunApplication();
        }
    }

    /*
     * ===== 2/9/2024 =====
     * === BASIS
     * 1. Maak een aparte klasse bestand aan genaamd Game. Game is verantwoordelijk om de game te runnen.
     * 2. Maak in de Game klasse een methode aan met access modifier public, deze zal verantwoordelijk zijn om de game te runnen in de Program klas.
     *
     * === the "Fun"
     * 1) Maak een aparte klasse bestand genaamd: Inkling.
     * 2) In dit programma, stop je een paar auto-properties van het type string, int & boolean.
     * 3) Maak ten eerste een default constructor aan, initialiseer je properties hierin. Dus string(name) = "Bob", int(age) = 3, bool(canWoomy) = true.
     * 4) Maak nu een overloaded constructor aan met de parameter naam van het type string. Initialiseer de naam met: this.name = name
     * 5) Doe nu hetzelfde met age & canWoomy. Initialiseer beide in aparte overloaded constructors.
     * 6) Roep deze constructors aan in de RunApplication methode in the Game klasse.
     *
     * === BONUS
     * 1) Maak een overloaded constructor aan met alle properties als parameters.
     * 2) Initialiseer deze dingen met Object Initialization. HINT:
        Student Bob = new { naam = "Bob"; }
     */
}