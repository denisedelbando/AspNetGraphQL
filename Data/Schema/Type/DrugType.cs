using Data.Services;
using GraphQL.Types;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Schema
{
    public class DrugType : ObjectGraphType<Drug>
    {
        public DrugType(ICompanyService companyService)
        {
            
            Field(xx => xx.id);
            Field(xx => xx.GenericName);
            Field(xx => xx.CreateDate);
            Field<CompanyType>("company",
                    resolve: context => companyService.GetCompanyByIdAsync(context.Source.CompanyID));
        }
    }
}
