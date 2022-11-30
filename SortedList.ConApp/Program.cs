namespace SortedList.ConApp
{
    internal class Program
    {
        static Random Random = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            SortedList list = new SortedList();

            Console.WriteLine("Demo Sorted-List!");

            // Insert 10 numbers
            for (int i = 0; i < 10; i++)
            {
                list.Insert(Random.Next(1, 100));
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($" {list.GetAt(i)}");
            }
        }
    }
}