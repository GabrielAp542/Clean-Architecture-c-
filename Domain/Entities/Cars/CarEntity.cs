using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.Cars
{
    //clase CarEntity. This are the car entities that external layers will use to the buisness logic
    public class CarEntity
    {
        public int Id { get; set; }
        public int ModelId { get; set; } 
        public string Year { get; set; }
        public int ColorId { get; set; }
        public bool IsAvailable { get; set; }
    }
}
