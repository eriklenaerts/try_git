using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KVV.Services
{
    public class SampleModule : Nancy.NancyModule
    {
        public SampleModule()
        {
            Get["/"] = _ => "Hello World!";
        }
    }
}