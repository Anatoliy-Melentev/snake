using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{


			//Console.SetBufferSize(80, 25);

			HorisontalLine line = new HorisontalLine(1,77,0,'-');
			line.Drow();
			HorisontalLine line1 = new HorisontalLine(0, 78, 24, '-');
			line1.Drow();

			VerticalLine line3 = new VerticalLine(1, 24, 0, '|');
			line3.Drow();
			VerticalLine line4 = new VerticalLine(1, 24, 78, '|');
			line4.Drow();

			Point corn1 = new Point(0, 0, '+');
			corn1.Draw();
			Point corn2 = new Point(78, 0, '+');
			corn2.Draw();
			Point corn3 = new Point(0, 24, '+');
			corn3.Draw();
			Point corn4 = new Point(78, 24, '+');
			corn4.Draw();

			Console.ReadLine();
		}
	}
}
