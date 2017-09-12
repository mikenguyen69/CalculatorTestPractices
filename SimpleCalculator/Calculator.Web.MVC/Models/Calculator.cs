using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public enum Operator
    {
        Plus, Divide, Multiply
    };

    public class Calculator
    {
        public double Input1 { get; set; }
        public double Input2 { get; set; }
        public Operator OPT { get; set; }
        public double Result { get; set; }

    }
}