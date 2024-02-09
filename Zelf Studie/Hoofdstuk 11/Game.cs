namespace Hoofdstuk_11
{
    public class Game
    {
        public void RunApplication()
        {
            Inkling inkling = new Inkling("Berta", 5, true);
            Inkling inkling2 = new Inkling
            {
                woomy = "Jeff",
                age = 6,
                canWoomy = false
            };

            Console.WriteLine($"{inkling}\n\n{inkling2}");
        }
    }

}
