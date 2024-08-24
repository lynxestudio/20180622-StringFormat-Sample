using System;
using System.Globalization;

public class TestStringFormat
{
	public static void Main(string[] args)
	{
		Console.Clear();
		Console.WriteLine("Testing how to format a string to money.");
		Console.WriteLine();
		//string to convert
		string strVal = "645000000";
		Console.WriteLine("Original string: {0}",strVal);
		//variable for storing the amount
		decimal amount = 0.0M;
		//variable for storing the output value for TryParse
		decimal temp = 0.0M;
		//safer than Convert.ToDecimal(x)
		if(Decimal.TryParse(strVal,out temp))
			amount = temp;
		//C Formats the string as currency.
		//C2 = two decimal digits, C3 = three decimal digits... and so on.
		string labelAmount = String.Format("{0:C2}",amount / 100);
		Console.WriteLine("Transformed string: {0}",labelAmount);
		Console.ReadLine();
	}
}
