using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CognitoIdentity
{
    public delegate void AmazonCognitoIdentityCallback<TResponse>(AmazonCognitoIdentityResult<TResponse> result);

    public class AmazonCognitoIdentityResult<TResponse>
    {
        public TResponse Response { get; internal set; }

        public Exception Exception { get; internal set; }

        public object State { get; internal set; }

        public AmazonCognitoIdentityResult(object state)
        {
            this.State = state;
        }

        public AmazonCognitoIdentityResult(TResponse response, Exception exception, object state)
        {
            this.Response = response;
            this.Exception = exception;
            this.State = state;
        }
    }
}
