using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tictactoe");
           
           UC1 tictac = new UC1();
            tictac.Board();
            Console.ReadLine();
        }
    }
}
