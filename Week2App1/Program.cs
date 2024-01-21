namespace Week2App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float secondnumber;
            float firstnumber;


            Console.WriteLine("Please enter first number");
            firstnumber= float.Parse(Console.ReadLine());

          

            Console.WriteLine("Please enter second Number");
            secondnumber = float.Parse(Console.ReadLine());

            float resultsun = firstnumber + secondnumber;
            Console.WriteLine("addition result: "+resultsun);
            float resultminus = firstnumber - secondnumber;
            Console.WriteLine("minus result: " + resultminus);
            float resultmultipl = firstnumber * secondnumber;
            Console.WriteLine("Multipl result: " + resultmultipl);
            float resultDivide = firstnumber / secondnumber;
            Console.WriteLine("Divide result: " + resultDivide);





        }
    }
}