namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.Write("Enter a score (integer): ");
                int input = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException exception)
            {
                Console.WriteLine("Error: Invalid data type supplied");
            } catch (OverflowException exception)
            {
                Console.WriteLine("Error: Input supplied is outside the valid range");
            }
        } 
    }
}