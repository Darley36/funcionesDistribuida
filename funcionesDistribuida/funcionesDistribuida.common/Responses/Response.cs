using System;
using System.Collections.Generic;
using System.Text;

namespace funcionesDistribuida.common.Responses
{
    public class Response
    {
        public bool isSuccess { get; set; }
        public string message { get; set; }
        public object result { get; set; }
    }
}
