﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor.BLL;

namespace Factorizor.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();
            workflow.Execute();
        }
    }
}
