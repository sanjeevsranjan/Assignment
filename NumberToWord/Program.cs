using System;

namespace NumberToWord
{
	class Program
	{
		static void Main(string[] args)
		{	

		}
	}

	public static class Converter
	{	
		public static string ConvertNumberToString(int n)
		{
			if (n < 0)
				throw new NotSupportedException("negative numbers not supported");
			if (n == 0)
				return "zero";
			if (n < 10)
				return ConvertDigitToString(n);
			if (n < 20)
				return ConvertTeensToString(n);
			if (n < 100)
				return ConvertHighTensToString(n);
			if (n < 1000)
				return ConvertBigNumberToString(n, (int)1e2, "hundred");
			if (n < 1e6)
				return ConvertBigNumberToString(n, (int)1e3, "thousand");
			if (n < 1e9)
				return ConvertBigNumberToString(n, (int)1e6, "million");
			
			return ConvertBigNumberToString(n, (int)1e9, "billion");
		}

		private static string ConvertDigitToString(int i)
		{
			switch (i)
			{
				case 0: return "";
				case 1: return "one";
				case 2: return "two";
				case 3: return "three";
				case 4: return "four";
				case 5: return "five";
				case 6: return "six";
				case 7: return "seven";
				case 8: return "eight";
				case 9: return "nine";
				default:
					throw new IndexOutOfRangeException(String.Format("{0} not a digit", i));
			}
		}

		
		private static string ConvertTeensToString(int n)
		{
			switch (n)
			{
				case 10: return "ten";
				case 11: return "eleven";
				case 12: return "twelve";
				case 13: return "thirteen";
				case 14: return "fourteen";
				case 15: return "fiveteen";
				case 16: return "sixteen";
				case 17: return "seventeen";
				case 18: return "eighteen";
				case 19: return "nineteen";
				default:
					throw new IndexOutOfRangeException(String.Format("{0} not a teen", n));
			}
		}

		
		private static string ConvertHighTensToString(int n)
		{
			int tensDigit = (int)(Math.Floor((double)n / 10.0));

			string tensStr;
			switch (tensDigit)
			{
				case 2: tensStr = "twenty"; break;
				case 3: tensStr = "thirty"; break;
				case 4: tensStr = "forty"; break;
				case 5: tensStr = "fifty"; break;
				case 6: tensStr = "sixty"; break;
				case 7: tensStr = "seventy"; break;
				case 8: tensStr = "eighty"; break;
				case 9: tensStr = "ninety"; break;
				default:
					throw new IndexOutOfRangeException(String.Format("{0} not in range 20-99", n));
			}
			if (n % 10 == 0) return tensStr;
			string onesStr = ConvertDigitToString(n - tensDigit * 10);
			return tensStr + "-" + onesStr;
		}

		
		private static string ConvertBigNumberToString(int n, int baseNum, string baseNumStr)
		{
			
			string separator = (baseNumStr != "hundred") ? ", " : " ";
			int bigPart = (int)(Math.Floor((double)n / baseNum));
			string bigPartStr = ConvertNumberToString(bigPart) + " " + baseNumStr;
			if (n % baseNum == 0) return bigPartStr;
			
			int restOfNumber = n - bigPart * baseNum;
			return bigPartStr + separator + ConvertNumberToString(restOfNumber);
		}
	}
}








