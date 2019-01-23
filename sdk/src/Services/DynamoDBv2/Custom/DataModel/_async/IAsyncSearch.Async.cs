using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.DynamoDBv2.CoreCLR.Custom.DataModel
{
    /// <summary>
    /// A strongly-typed object for retrieving search results (Query or Scan)
    /// from DynamoDB.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial interface IAsyncSearch<T>
    {

        /// <summary>
        /// Initiates the asynchronous execution to get the next set of results from DynamoDB.
        /// 
        /// If there are more items in the Scan/Query, PaginationToken will be
        /// set and can be consumed in a new Scan/Query operation to resume
        /// retrieving items from this point.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>
        /// A Task that can be used to poll or wait for results, or both.
        /// Results will include the next set of result items from DynamoDB.
        /// </returns>
        Task<List<T>> GetNextSetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution to get all the remaining results from DynamoDB.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>
        /// A Task that can be used to poll or wait for results, or both.
        /// Results will include the remaining result items from DynamoDB.
        /// </returns>
        Task<List<T>> GetRemainingAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}