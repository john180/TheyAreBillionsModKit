﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZXCheckGenerator
{
    class Program
    {
        // Called when the program is launched
        static void Main(string[] args)
        {
            // Grab the save file
            string pathToSaveFile = ZXCheckLib.ZXCheckLib.getSavFileFromArgs(args);

            Console.WriteLine("Save file signer was started!");

            // Prepare billions
            ZXCheckLib.ZXCheckLib.prepareBillions();

            Console.WriteLine("Attempting to sign: ");
            Console.WriteLine(pathToSaveFile);

            // Spin up a thread
            // We need to let the game start to load, then we can call methods from it
            new Thread(() => {
                // Sleep so the game can load
                Thread.Sleep(1000);

                // Generate ZXCheck
                ZXCheckLib.ZXCheckLib.generateZXCheck(pathToSaveFile);

                // Attempt to extract the password
                ZXCheckLib.ZXCheckLib.extractPassword(pathToSaveFile, true);
                
                ZXCheckLib.ZXCheckLib.quitAfterDelay();
            }).Start();

            // Do the injection
            ZXCheckLib.ZXCheckLib.injectBillions(args);
        }
    }
}
