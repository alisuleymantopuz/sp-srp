using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Better
{
    public abstract class SqlVisitor<T>
    {
        internal abstract void Visit(T item);

        public abstract string Query { get; }
    }
}
