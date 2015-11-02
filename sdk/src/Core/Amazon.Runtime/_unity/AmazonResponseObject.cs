using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime
{
    public delegate void AmazonServiceCallback<TRequest, TResponse>(AmazonServiceResult<TRequest, TResponse> responseObject)
        where TRequest : AmazonWebServiceRequest
        where TResponse : AmazonWebServiceResponse;

    public class AmazonServiceResult<TRequest, TResponse>
        where TRequest : AmazonWebServiceRequest
        where TResponse : AmazonWebServiceResponse
    {
        public TRequest Request { get; internal set; }
        public TResponse Response { get; internal set; }
        public Exception Exception { get; internal set; }
        public object state { get; internal set; }

	public AmazonServiceResult(TRequest request, TResponse response, Exception exception, object state)
        {
            this.Request = request;
            this.Response = response;
            this.Exception = exception;
            this.state = state;
        }
    }

}
