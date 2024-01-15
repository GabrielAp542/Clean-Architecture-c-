using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.Cars
{
    public class ModelEntity
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int ManufacturerId { get; set; }
    }
}
