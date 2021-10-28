using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprogram
{
	class Program
	{
		public static void armStrong()
		{
			Console.WriteLine("Enter the Number:");
			int num = Convert.ToInt32(Console.ReadLine());
			int temp = num;
			int sum = 0;
			while(num>0)
			{
				int rem = num % 10;
				sum = sum + rem * rem * rem;
				num = num / 10;
			}
			if(sum == temp)
			{
				Console.WriteLine("The Given Number is Armstrong Number");
			}
			else
			{
				Console.WriteLine("The Given Number is not an Armstrong Number");
			}
			
		}
	
		static void Main(string[] args)
		{
			armStrong();

		}
	}
}
