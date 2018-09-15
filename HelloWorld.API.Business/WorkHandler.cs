using HelloWorld.Domain.Entity;
using HelloWorld.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API.Business
{
    /// <summary>
    /// Handles the functional logic of the API
    /// </summary>
    public class WorkHandler
    {
        IDataRepository Repository { get; set; }
        public WorkHandler(IDataRepository _repository) => Repository = _repository;

        /// <summary>
        /// Simple method that calls on the Access layer to retrieve information
        /// </summary>
        /// <returns></returns>
        public IReturnMessage GetMessage() => Repository.GetMessage();
    }
}
