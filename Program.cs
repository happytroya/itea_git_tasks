namespace ITEA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charCount = 0;

            string text = "Click Open Zoom Meetings on the dialog shown by your browser\r\nIf you don’t see a dialog, click Launch Meeting below";

            char charToFind;

            while (true)
            {
                Console.WriteLine("Enter char");

                charToFind = char.Parse(Console.ReadLine());

                foreach (char c in text)
                {
                    if (c == charToFind)
                    {
                        charCount++;
                    }
                }
                Console.WriteLine($"There is {charCount} chars {charToFind} in text");

                charCount = 0;
            }
        }
    }
}