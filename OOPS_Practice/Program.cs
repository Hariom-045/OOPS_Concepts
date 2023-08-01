using OOPS_Practice.ClassFiles;

namespace OppsWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student student = new Student();
            Student st = new Student("Hariom");
            Console.WriteLine("Number of objects created till now are :" + Student.Count);

        }
    }
}