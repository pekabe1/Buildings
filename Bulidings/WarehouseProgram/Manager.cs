using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.WarehouseProgram
{
   internal class Manager:Warehouse
    {
       

        internal string GiveCommand(int command,Warehouse warehouse, Worker worker)
        {
            switch (command)
            {
                case 1:
                    Console.WriteLine("command 1");
                    worker.WorkerTask.Add("command 1");
                    return "command 1";
                
                case 2:
                    Console.WriteLine("command 2");
                    worker.WorkerTask.Add("command 2");
                    return "command 1";
                   
                case 3:
                    Console.WriteLine("command 3");
                    worker.WorkerTask.Add("command 3");
                    return "command 3";
                   
            }
            return "";
        }
    }
}
