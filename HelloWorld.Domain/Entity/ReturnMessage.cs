using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Domain.Entity
{
    public class ReturnMessage : IReturnMessage
    {
        public string MessageValue { get; set; }
    }
}
