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
    public class CompanyQuery : ObjectGraphType<object>
    {
        public CompanyQuery(ICompanyService companyService, IDrugService drugService)
        {
            Name = "Query";
            Field<PageInfoType>(
                "allCompany",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "page", Description = "page of the company" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "size", Description = "size of the company" }
                ),
                resolve: context => companyService.GetCompanysAsync(context.GetArgument<int>("page"), context.GetArgument<int>("size"))
            );
            Field<CompanyType>(
                "company",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the company" }
                ),
                resolve: context => companyService.GetCompanyByIdAsync(context.GetArgument<int>("id"))
            );
            Field<ListGraphType<DrugType>>(
                "allDrug",
                resolve: context => drugService.GetDrugsAsync()
            );
            Field<DrugType>(
                "drug",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the drug" }
                ),
                resolve: context => drugService.GetDrugByIdAsync(context.GetArgument<int>("id"))
            );
        }
    }
}
