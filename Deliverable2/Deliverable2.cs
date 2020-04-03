using System;
using System.Text;

public static class Extention
{
	public static byte[] ToByteArray(this string upinput, Encoding encoding)
	{
		return encoding.GetBytes(upinput);
	}
}

public class Program
{
	public static void Main()
	{

		Encoding encoding = Encoding.Unicode;

		Console.WriteLine("Enter here: ");
		//input variable
		string input = Console.ReadLine();
		string upinput = input.ToUpper();
		byte[] array = upinput.ToByteArray(encoding);
		int checksum = 0;
		for (int i = 0; i < array.Length; i++)
		{
			checksum += array[i];
		}
		string message = String.Join('-', array);


		///result
		Console.WriteLine("Your encoded message is " + message);
		Console.WriteLine("Message checksum is  " + checksum);
	}
}