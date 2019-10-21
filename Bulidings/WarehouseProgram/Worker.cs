using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.WarehouseProgram
{
    internal class Worker
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<String> WorkerTask { get; set; }

        public Worker()
        {
            Warehouse warehouse = new Warehouse();
            warehouse.AvalibleWorkers.Add(new Worker()
            {
                ID = ID,
                Name = Name
            });
        }

        internal void ExecuteTask()
        {
            
                
            
        }
    }
}
