using System;
using System.Collections.Generic;
using System.Text;

namespace Bulidings
{
    class Building
    {
        public string Name { get; set; }
        string destiny { get; set; }
        DateTime yearOfProduction { get; set; }

      internal  List<Floor> allFlors { get; set; }

        public Building(List<Floor> floors,string name,string destination)
        {
            if (floors.Count != 0)
            {
                allFlors.AddRange(floors);
                Name = name;
                destiny = destination;
                
            }
            else
            {
                Console.WriteLine("Buliding requires at least one floor");
                allFlors.Add(new Floor(this)
                {
                    Name = "First Floor"
                });
            }
            
        }
    }
}
