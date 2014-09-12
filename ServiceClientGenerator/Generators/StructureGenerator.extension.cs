using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator.Generators
{
    public partial class StructureGenerator
    {
        public string BaseClassString
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.BaseClass))
                {
                    return " : " + this.BaseClass;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
