namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///User entry
            Console.WriteLine("Enter");
            string input = Console.ReadLine();
            string upinput = input.ToUpper(); 


            ///Array variable
            string message = String.Empty;
            char[] carray = upinput.ToCharArray();
            int convertedchar = '\0';
            
           for (int i = 0; i < carray.Length; i++)
            {
                convertedchar = (char)(carray[i] + 32);
            }

            String convertedstring = convertedchar.ToString();


            ///Determines checksum from user input
            int checksum = 0;
            for (int i = 0; i < upinput.Length; i++)
            {
                checksum += upinput[i];
                
            }

            ///Result
            message = String.Join('-', convertedstring);
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is  " + checksum);


        }
    }
}
