using HelloWorld.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Domain.Interface
{
    /// <summary>
    /// Repository interface
    /// </summary>
    public interface IDataRepository
    {
        /// <summary>
        /// Returns a message object
        /// </summary>
        /// <returns></returns>
        IReturnMessage GetMessage(); 
    }
}
