using System.Collections;

namespace MahmoudIbrahim_sun_wed_5pm_C_11
{
    internal class Program
    {
        public static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
        }
        public static List<int> FilterEvenNumbers(List<int> list)
        {
            List<int> evenList = new List<int>();
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    evenList.Add(item);
                }
            }
            return evenList;
        }
        static void Main(string[] args)
        {
            Rangee<int> r = new Rangee<int>(10, 30);
            int res = r.isInRange(13);
            if(res == 0)
            {
                Console.WriteLine("Value is within the Range !");
            }
            else
            {
                Console.WriteLine("Value is not within the Range !");
            }

            Console.WriteLine(r.Length());

            ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };

            ReverseArrayList(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            List<int> originalList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> evenList = FilterEvenNumbers(originalList);

            foreach (var num in evenList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
