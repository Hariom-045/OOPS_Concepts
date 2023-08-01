using OppsWorld.Class___Interfaces;

namespace OppsWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(45);list.Add(-23);list.Add(31);list.Add(-2);list.Add(95);
            list.Add(-85);list.Add(49);
            SortingUtility.sort(list, new AscendingComparator());
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            SortingUtility.sort(list, new DecendingComparator());
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            
            Console.WriteLine();
            

        }
    }
}