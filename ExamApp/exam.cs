using System;
using System.Linq;
using System.Collections.Generic;

namespace OpenExam
{
	public class OpenBook
	{


		int count, total = 2;


		//string answer2;
		//string answer3;






		public void ScienceQ()
		{
			//LOCAL VARIABLES
			string answer1;
			string answer2;
			
			


			Console.WriteLine("\t\t1.\tWhat is the unit of power?");
			Console.WriteLine("\t\tA.\tdecibel");
			Console.WriteLine("\t\tB.\tpower");
			Console.WriteLine("\t\tC.\twatt");
			Console.WriteLine("\t\tD.\tamps");

			try
			{
				Console.Write("\t\t");
				answer1 = Convert.ToString(Console.ReadLine());
				
			}
			catch (Exception)
			{
				Console.Beep();
				Console.WriteLine("	Error retry");
				Console.Write("\t\t");
				answer1 = Convert.ToString(Console.ReadLine());


			}



			Console.WriteLine("\n");

			Console.WriteLine("\t\t2.\tWhat is the capital city of Kuwait?");
			Console.WriteLine("\t\tA.\tIstambul");
			Console.WriteLine("\t\tB.\tTripoli");
			Console.WriteLine("\t\tC.\tKuwait City");
			Console.WriteLine("\t\tD.\tCairo");
			Console.Write("\t\t");

			try
			{
				Console.Write("\t\t");
				answer2 = Convert.ToString(Console.ReadLine());
				

			}
			catch (Exception)
			{
				Console.Beep();
				Console.WriteLine("	Error retry");
				Console.Write("\t\t");
				answer2 = Convert.ToString(Console.ReadLine());

			}

			//char answer2 = Convert.ToChar(Console.ReadLine());

			//Console.WriteLine("\n");



			if (answer1 == "c" || answer1 == "C")
			{
				//Console.WriteLine("!\t\tNumber 1 your answer {0} is correct", answer1);
				count += 1;
			}
			else
			{
				Console.WriteLine("\t\tNumber 1 your answer {0} is wrong", answer1);
			}

			if (answer2 == "c" || answer2 == "C")
			{
				//Console.WriteLine("\t\tNumber 2 your answer {0} is correct", answer2);
				count += 1;
			}
			else
			{
				Console.WriteLine("\t\tNumber 2 your answer {0} is wrong", answer2);
			}
			Console.WriteLine("\n");

			Console.Beep();
			Console.WriteLine("\t\tYou got {0} out of {1}", count, total);


			if (count == total)
			{
				Console.WriteLine("\t\tExcellent Work!!");
			}
			else if (count == 0)
			{
				Console.WriteLine("\t\tFail");
			}
			else
			{
				Console.WriteLine("!\t\tFair");
			}
		}
	}

	class Exam
	{
		static void Main(string[] args)
		{

			OpenBook o = new OpenBook();

			o.ScienceQ();



			Console.ReadLine();
		}
	}
}

