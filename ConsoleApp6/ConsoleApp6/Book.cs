﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Book : Product
    {

        public string Genre;


        public Book(int no, string name, double price, string genre)
        {
            No = no;
            Name = name;
            Price = price;
            Genre = genre;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Book No: {No}, Name: {Name}, Price: {Price}, Genre: {Genre}");
        }
    }
}
