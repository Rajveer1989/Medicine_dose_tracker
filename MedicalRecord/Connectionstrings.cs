﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalRecord
{
   public static class Connectionstrings
    {
        static string _conString = "data source=BASLAB;database=Medical;uid=sa;pwd=master;";

        public static string ConString
        {
            get { return _conString; }           
        }
    }
}