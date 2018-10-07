using System;
using System.Collections.Generic;

namespace MyMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu lists = new Menu();
            Handler handler = new Handler();
            lists.OnEnter += handler.Message;
            lists.Show();
            Console.ReadLine();
        }
    }
}
