using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database2AdministratorWpf.Dto
{
    class Olympic
    {
        public string Name { get; set; }
        public string Sponsors { get; set; }
        public string Website { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Logo { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }

        public string TorchImage { get; set; }
        public double TorchCost { get; set; }
        public string TorchDescription { get; set; }
        public string TorchDesigner { get; set; }
        public string TorchCountry { get; set; }
    }
}
