using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNProject.Data
{
    public class Proxy : IDynamicMetaObjectProvider
    {
        private readonly object target;

        public Proxy(object target) { this.target = target; }

        // something clever goes here

        public DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
        {
            throw new NotImplementedException();
        }
    }
}
