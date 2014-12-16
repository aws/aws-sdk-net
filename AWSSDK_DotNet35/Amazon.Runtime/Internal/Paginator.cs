using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Internal
{
    public interface IPageableResponse<T,TRequest> where TRequest : AmazonWebServiceRequest
    {
        bool MoreResultsAvailable();

        void SetPaginationTokens(TRequest request);

        IEnumerable<T> SelectResult();
    }

    public static class Paginator
    {
        public static IEnumerable<T> Paginate<T,TRequest,TResponse>(TRequest request,Func<TRequest,TResponse> func)
            where TRequest : AmazonWebServiceRequest
            where TResponse : IPageableResponse<T, TRequest>
        {
            var response = default(TResponse);
            do
            {
                response = func(request);
                foreach (var item in response.SelectResult())
                {
                    yield return item;
                }
                response.SetPaginationTokens(request);                
            } while (response.MoreResultsAvailable());            
        }
    }

}
