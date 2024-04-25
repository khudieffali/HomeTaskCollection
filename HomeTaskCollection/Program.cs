
using HomeTaskCollection;

internal class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new()
        {
            "salam",
            5,
            6,
            "Ali",
            15,
            14,
            8,
            12,
            3
        };
        Console.WriteLine(list._arr.Length);
        list.Remove("salam");
        list.Remove(5);

        //list.TrimToSize();

        //Console.WriteLine(list.Count);


        //int[] arr = { 5, 8, 9, 10, 12, 13 };
        //list.AddRange(arr);
        //list.Remove(5);
        //list.Remove(8);
        //list.Remove(9);


        //Console.WriteLine(list.Capacity + " " + list.Count);

        //foreach (var item in list)
        //{
        //    Console.WriteLine(item);
        //}
    }
}