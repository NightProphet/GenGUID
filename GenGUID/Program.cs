using System;

namespace GenGUID
{
    static class Program
    {
        static void Main(String[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                object getGuid = RandomGuid.GenerateGuid(Guid.NewGuid());
                string result = Convert.ToString(getGuid);
                Console.WriteLine(getGuid);
                Console.WriteLine(result.ToLower());
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    static class RandomGuid
    {
        public static object GenerateGuid(object genGuid)
        {
            string result = Convert.ToString(genGuid);
            return result.ToUpper();
        }
    }
}
