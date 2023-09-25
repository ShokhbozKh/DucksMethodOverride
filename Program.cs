namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rasmda berilgan struktura asosida klasslarni yarating.
            //display() methodini overriding usulida amalga oshiring.

            Duck duck = new Duck();
            duck.Display();
            Duck duck1 = new MallardDuck();
            duck1.Display();
            Duck duck2 = new RedheadDuck();
            duck2.Display();
        }
    }
}
class Duck
{
    public void Quack()
    {
        Console.WriteLine("Duck is quacking");
    }
    public void Swim()
    {
        Console.WriteLine("Duck is swimming");
    }
    public virtual void Display()
    {
        Console.WriteLine("Ikkita panjasi bor\nRangi oq\nOddiy Urdak");

    }
}
class MallardDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("Looks like a Mallard ");
    }

}
class RedheadDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("Looks like a Redhead");
    }
}