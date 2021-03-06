﻿using Data.Services;
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
            Field(xx => xx.id);
            Field(xx => xx.CompanyName);
            Field(xx => xx.IsActive);
        }
    }

    public class PageInfoType : ObjectGraphType<PageInfo<Company>>
    {
        public PageInfoType()
        {
            Field<ListGraphType<CompanyType>>(
                "company",
                resolve: context => context.Source.List
            );
            Field(xx => xx.Chars);
            Field(xx => xx.PageCount);
            Field(xx => xx.Size);
            Field(xx => xx.TotalCount);
        }
    }
}
