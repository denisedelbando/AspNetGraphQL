using GraphQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Schema
{
    public class CompanySchema : GraphQL.Types.Schema
    {
        public CompanySchema(IDependencyResolver resolver)
            : base(resolver)

        {
            Query = resolver.Resolve<CompanyQuery>();
        }
    }
}
