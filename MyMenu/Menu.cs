using System;
using System.Collections.Generic;
using System.Text;

namespace MyMenu
{
    class Handler
    {
        public void Message(string msg = "Error")
        {
            Console.WriteLine(msg);
        }
    }
    class Menu
    {
        public delegate void MyDel(string s);
        public event MyDel OnEnter;
        private List<string> list = new List<string>()
        { "a", "b", "c", "d", "e", "f", "g" };
        public Menu() { }
        public Menu(string[] arrs)
        {
            list.Clear();
            for (int i = 0; i < arrs.Length; i++)
                list.Add(list[i]);
        }
        public void Show()
        {
            Console.WriteLine("Select number of your choice:");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine((i + 1) + "." + list[i]);
            Chose();
        }
        private void Chose()
        {
            List<int> res = new List<int>();
            int result;
            do
            {
                string answer = Console.ReadLine();
                bool isInt = Int32.TryParse(answer, out result);
                if (result > -1 && result <= list.Count)
                    res.Add(result);
                else
                    OnEnter("Wrong enter!");
            }
            while (result != 0);
            res.Remove(0);
            Console.WriteLine("Your choice:");
            foreach (int var in res)
                OnEnter(list[var - 1]);
        }
    }
}
