using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Better
{
    public class SqlSelectVisitor<T> : SqlVisitor<T>
    {
        private Guid _id;
        private readonly string _query;

        public SqlSelectVisitor(Guid id)
        {
            _id = id;
            _query = "select * from blah where blah = blah";
        }

        internal override void Visit(T item)
        {
            // does nothing;
        }

        public override string Query
        {
            get { return _query; }
        }
    }
}
