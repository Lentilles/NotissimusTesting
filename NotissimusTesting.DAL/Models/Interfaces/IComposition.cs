using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Interfaces
{
    public interface IComposition
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public bool Downloadable { get; set; }
        public string Language { get; set; }
    }
}
