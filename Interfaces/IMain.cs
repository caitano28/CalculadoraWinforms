using Calculadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interfaces
{
    public interface IMain
    {
        public string Visor { get; set; }
        public string Subtotal { get; set; }
        public string ValueA { get; set; }
        public string ValueB { get; set; }
        public int Index { get; set; }
        public int CountOp { get; set; }
        public OperationType Operation { get; set; }
        public bool CleanVisor { get; set; }
        public bool CleanSubtotal { get; set; }
        
    }
}
