using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNProject.Data
{
    public interface IConfig
    {
        IVendor getVendor();
    }
}
