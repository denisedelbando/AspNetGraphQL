using Data.Services;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Schema
{
    public class CompanyQuery : ObjectGraphType<object>
    {
        public CompanyQuery(ICompanyService companyService)
        {
            Name = "Query";
            Field<ListGraphType<CompanyType>>(
                "company",
                resolve: context => companyService.GetCompanysAsync()
            );
        }
    }
}
