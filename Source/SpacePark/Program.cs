﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;



namespace SpacePark
{
    public class Program
    {
        public static void Main(string[] args)
        {

            CultureInfo.CurrentCulture = new CultureInfo("en-US", true);
            //Make sure there are parkingspaces in the database
            ParkingEngine.WriteParkingSpaceToDataBase();
            // Menu
            while (true)
            {
                Menu.MenuHeader();
                Menu.MenuSwitch(Menu.MenuOptions("Check in", "Check out", "Pay"));
                Console.Clear();
            }
        }


    }
}