﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//assembly reference:
[assembly: log4net.Config.XmlConfigurator(Watch=true)]

namespace ConsoleUI
{
    class Program
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        //reflection making the program slow, use it only once per method.
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World !");

            //log.Error("This is my error message");
            

            log.Debug("Developer: tutorial was run");
            log.Info("Maintenance: water pump turned on");
            log.Warn("Maintenance: the water pump is getting hot");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {

                log.Error("Developer: we tried to divide by zero again");/*, ex*/
            }

            Counter j = new Counter();
            //assign the property once:
            log4net.GlobalContext.Properties["Counter"] = j;

            for (j.LoopCounter = 0; j.LoopCounter < 5; j.LoopCounter++)
            {                
                log.Fatal("This is a fatal error in the process ");
            }
            //log.Fatal("Maintenance: water pump exploded");

            Console.ReadLine();
        }
    }
}
