namespace NupatLinq_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //  Arithmetic arithmetic = new Arithmetic();
            // Console.WriteLine(arithmetic.Add(20,29));

            // arithmetic.TodaysDate();
            //Console.WriteLine(arithmetic.Subtraction(40, 30));
            //Arithmetic.HelloWorld();
            //Greetings("Dipo", "Deji");

            //Linq 
            //int[] arrayNum = { 267, 2720, 30, 3094, 23, 45, 34, 24, 22 };

            //var orderAsc = from queryTo in arrayNum
            //               orderby queryTo ascending
            //               select queryTo;

            //var orderDecs = from holdsDesc in arrayNum
            //              orderby holdsDesc descending
            //              select holdsDesc;


            //foreach (var item in orderDecs)
            //{
            //    Console.WriteLine(item);
            //}


            string[] arrayStrings =
            {
                "Tomi Liys", "Sh ola", "Salako", "Shomolu",
                "Abuja", "Lag os", "Nupat", "NIT"
            };

            var filter = from selectA in arrayStrings
                         where selectA.Contains(" ")
                         select selectA;

            foreach (var array in filter)
            {
                Console.WriteLine(array);
            }

            



            //Console.ReadLine(); 

        }


        static int Greetings(string firstName, string lastName)
        {
            Console.WriteLine($"Firstname {firstName}, lastname {lastName}");
            return 0;
        }

       
    }
}