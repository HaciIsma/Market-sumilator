using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Time
    {
        public void Clock()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(52, 1);
            Console.WriteLine("Time: ");
            while (true)
            {
                var time = DateTime.Now;
                Console.SetCursorPosition(58,1);
                Console.WriteLine(time.ToString("hh-mm-ss"));
            }
        }
    }
}
