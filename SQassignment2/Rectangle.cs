using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQassignment2
{
	public class Rectangle
	{
		private int length;
		private int width;

		// default constructor
		public Rectangle()
		{
			length = 1;
			width = 1;
		}

		// non-default constructor
		public Rectangle(int length, int width)
		{
			if (length < 1 || width < 1)
			{
				throw new ArgumentException("Invalid rectangle dimensions.");
			}

			this.length = length;
			this.width = width;
		}

		public int GetCurrentLength()
		{
			return length;
		}

		public int SetNewLength(int length)
		{
			if (length < 1)
			{
				throw new ArgumentException("Invalid length.");
			}

			this.length = length;
			return length;
		}

		public int GetCurrentWidth()
		{
			return width;
		}

		public int SetNewWidth(int width)
		{
			if (width < 1)
			{
				throw new ArgumentException("Invalid width.");
			}

			this.width = width;
			return width;
		}

		public int GetPerimeter()
		{
			return 2 * (length + width);
		}

		public int GetArea()
		{
			return length * width;
		}



		public static void DisplayResults(int length, int width, int area, int perimeter)
		{

			Console.WriteLine("'Dimensions' of rectangle:-\n");
			Console.WriteLine("{0, -15} {1,5:f1}", "Length of Rectangle is:", length);
			Console.WriteLine("{0, -15} {1,5:f1}", "Width of Rectangle is:", width);
			Console.WriteLine("{0, -15} {1,5:f1}", "Area of Rectangle is:", area);
			Console.WriteLine("{0, -15} {1,5:f1}", "Perimeter of Rectangle is:", perimeter);
			Console.WriteLine("\n");
			Console.WriteLine("Press Any Key To 'Exit'");
		}


	}



}