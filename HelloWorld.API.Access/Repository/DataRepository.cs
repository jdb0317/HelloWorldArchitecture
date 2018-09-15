using HelloWorld.Domain;
using HelloWorld.Domain.Entity;
using HelloWorld.Domain.Interface;

namespace HelloWorld.API.Access.Repository
{
    /// <summary>
    /// Basic repository
    /// </summary>
    public class DataRepository : IDataRepository
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
