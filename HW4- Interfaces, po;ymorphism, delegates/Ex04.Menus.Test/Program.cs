﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            Start();
        }
        public static void Start()
        {
            SetMenu setMenu = new SetMenu();
            setMenu.start();
        }
    }
}
