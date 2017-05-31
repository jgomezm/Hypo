using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypo
{
    class StartUpProgram
    {
        public string Name { get; set; }


        public string Path { get; set; }

        //show name in checkboxitem

        public override string ToString()
        {

            return Name;

        }
    }
}
