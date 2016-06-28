using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NNProject.Data
{
    public class Config : IConfig
    {
        public IVendor getVendor()
        {
            string pvend = "NNProject.Data." + ConfigurationManager.AppSettings["Vendor"];
            AssemblyName assemblyName = AssemblyName.GetAssemblyName(HttpContext.Current.Server.MapPath("~\\Bin\\NNProject.Data.dll"));
            string typeAssemblyQualifiedName = string.Join(", ", pvend, assemblyName.FullName);
            Type ptype = Type.GetType(typeAssemblyQualifiedName);
            return (IVendor)Activator.CreateInstance(ptype);

            
        }
    }
    public class MockedConfig : IConfig
    {
        public IVendor getVendor()
        {
            string pvend = "NNProject.Data." + "Yahoo";
            AssemblyName assemblyName = AssemblyName.GetAssemblyName(HttpContext.Current.Server.MapPath("~\\Bin\\NNProject.Data.dll"));
            string typeAssemblyQualifiedName = string.Join(", ", pvend, assemblyName.FullName);
            Type ptype = Type.GetType(typeAssemblyQualifiedName);
            return (IVendor)Activator.CreateInstance(ptype);

            
        }
    }
}
