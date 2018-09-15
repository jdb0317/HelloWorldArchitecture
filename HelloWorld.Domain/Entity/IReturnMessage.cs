using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Domain.Entity
{
    /// <summary>
    /// Message retrieved from Datasource
    /// </summary>
    public interface IReturnMessage
    {
        /// <summary>
        /// String response for user
        /// </summary>
        string MessageValue { get; set; }
    }
}
