﻿using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cielo.Converters
{
    internal class DateConverter : IsoDateTimeConverter
    {
        public DateConverter()
        {
            this.DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
