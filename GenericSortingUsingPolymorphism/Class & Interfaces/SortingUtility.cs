namespace OppsWorld.Class___Interfaces;

public class SortingUtility
{
    public static void sort(List<int> list, Comparator comparator)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int j = i;
            while (j > 0 && !comparator.compare(list[j - 1], list[j]))
            {
                int temp = list[j];
                list[j] = list[j - 1];
                list[j - 1] = temp;
                j--;

            }
        }
    }
}