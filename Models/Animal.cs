using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4Dima.Models
{
    class Animal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Iq { get; set; }
        public string Class { get; set; }

        public override string ToString()
        {
            return $"Это животное имеет имя {this.Name}. Живет на нашей планете уже целых {this.Age} лет. Относится к древнейшему классу {this.Class}. Интеллектуальное развитие можно определить по Iq равному {this.Iq}";
        }
    }
}
