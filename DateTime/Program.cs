namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime defaultDate = new DateTime(2112, 12, 21);

            DateTime tmp;

            Console.WriteLine("Write date in yyyy.mm.dd");
                
            tmp = DateTime.Parse(Console.ReadLine());

            GetDate getDate = new GetDate(defaultDate, tmp);
            GetDate gerDateIndex = new GetDate(tmp);

            bool dateOnly = true;

            getDate.ShowDate();

            Console.WriteLine("\nOverloaded User date: " + getDate.ToString(dateOnly));

            Console.WriteLine("\nUserDate + index = " + gerDateIndex[-2]);
           
        }
    }
}