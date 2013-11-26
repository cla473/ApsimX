﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Models.Core;

namespace Models.PMF.Functions
{
    [Description("Add the values of all child functions")]
    public class AddFunction : Function
    {
        public List<Function> Children { get; set; }

        public override double Value
        {
            get
            {
                double returnValue = 0.0;

                foreach (Function F in Children)
                {
                    returnValue = returnValue + F.Value;
                }

                return returnValue;
            }
        }

    }

}