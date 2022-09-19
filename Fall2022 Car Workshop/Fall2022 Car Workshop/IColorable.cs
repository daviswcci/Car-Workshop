using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Car_Workshop
{
    public interface IColorable
    {
        public string Color { get; set; }

        public void SetColor(string color);

        public bool CompareColor(IColorable other);
    }
}
