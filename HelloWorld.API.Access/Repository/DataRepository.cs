using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Domain;
using HelloWorld.Domain.Entity;
using HelloWorld.Domain.Interface;

namespace HelloWorld.API.Access.Repository
{
    /// <summary>
    /// Basic repository
    /// </summary>
    internal class DataRepository : IDataRepository
    {
        /// <summary>
        /// Retrieves a dummy ReturnMessage object
        /// </summary>
        /// <returns></returns>
        public IReturnMessage GetMessage()
        {
            return new ReturnMessage
            {
                MessageValue = Constants.HelloMessage
            };
        }
    }
}
