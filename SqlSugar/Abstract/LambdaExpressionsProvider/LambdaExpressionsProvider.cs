﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SqlSugar
{
    public partial class LambdaExpressionsProvider : ILambdaExpressions
    {
        public SqlSugarClient Context { get; set; }
    }
}