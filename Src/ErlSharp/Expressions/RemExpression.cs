﻿namespace ErlSharp.Expressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RemExpression : BinaryExpression
    {
        public RemExpression(IExpression left, IExpression right)
            : base(left, right)
        {
        }

        public override object Apply(object leftvalue, object rightvalue)
        {
            return (int)leftvalue % (int)rightvalue;
        }
    }
}
