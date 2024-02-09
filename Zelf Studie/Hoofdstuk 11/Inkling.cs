namespace Hoofdstuk_11
{
    public class Inkling
    {
        public string woomy { get; set; }
        public int age { get; set; }
        public bool canWoomy { get; set; }

        public Inkling()
        {
            woomy = "Bob";
            age = 3;
            canWoomy = true;
        }

        public Inkling(string woomy)
        {
            this.woomy = woomy;
        }

        public Inkling(int age)
        {
            this.age = age;
        }

        public Inkling(bool canWoomy)
        {
            this.canWoomy = canWoomy;
        }

        public Inkling(string woomy, int age, bool canWoomy)
        {
            this.woomy = woomy;
            this.age = age;
            this.canWoomy = canWoomy;
        }

        public override string ToString()
        {
            return $"Name: {woomy}\n" +
                   $"Age: {age}\n" +
                   $"Can Woomy?: {canWoomy}";
        }
    }
}
