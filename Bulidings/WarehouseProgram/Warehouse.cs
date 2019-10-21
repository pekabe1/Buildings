using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.WarehouseProgram
{
   internal class Warehouse
    {
        public List<Worker> AvalibleWorkers { get; set; }
        public Warehouse(Manager manager)
        {

        }
        public Warehouse()
        {

        }
        public Warehouse(Worker worker,Manager manager)
        {
            
        }
    }
}
