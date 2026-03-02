namespace _01___Ausnahmebehandlung___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person erlaubt = new Person();
            erlaubt.Alter = 30;

            Person verboten = new Person();
            verboten.Alter = -1;
        }
    }
}
