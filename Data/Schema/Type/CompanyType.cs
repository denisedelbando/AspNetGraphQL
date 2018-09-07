using GraphQL.Types;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Schema
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType()
        {
            Field(xx => xx.ID);
            Field(xx => xx.CompanyName);
            Field(xx => xx.isActive);
        }
    }
}
