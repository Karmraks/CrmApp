using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Test.Models;

namespace CrmBl.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<CrmContext>
    {
        protected override void Seed(CrmContext context)
        {
            context.Positions.Add(new Position() { PositionName = "Без Позиции"});

            base.Seed(context);
        }
    }
}