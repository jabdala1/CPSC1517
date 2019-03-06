using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class DDLClass
    {
        public int ValueField { get; set; }
        public string DisplayField { get; set; }

        public DDLClass()
        {
            //Default constructor

        }
        public DDLClass(int valuefield, string displayfield)
        {
            //Greedy constructor
            ValueField = valuefield;
            DisplayField = displayfield;
        }
    }
}