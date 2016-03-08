using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CognitoIdentity
{
    /// <summary>
    /// Cognito Identity response delegate
    /// </summary>
    /// <typeparam name="TResponse">Typed response object</typeparam>
    /// <param name="result"><see cref="AmazonCognitoIdentityResult{TResponse}"/></param>
    public delegate void AmazonCognitoIdentityCallback<TResponse>(AmazonCognitoIdentityResult<TResponse> result);

    /// <summary>
    /// Typed cognito Identity result object returned as a response
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public class AmazonCognitoIdentityResult<TResponse>
    {
        /// <summary>
        /// The typed response
        /// </summary>
        public TResponse Response { get; internal set; }

        /// <summary>
        /// Exception object returned in case of error
        /// </summary>
        public Exception Exception { get; internal set; }

        /// <summary>
        /// An optional state object returned back
        /// </summary>
        public object State { get; internal set; }

        /// <summary>
        /// Constructor for <see cref="AmazonCognitoIdentityResult{TResponse}"/>
        /// </summary>
        /// <param name="state">an optional state object</param>
        public AmazonCognitoIdentityResult(object state)
        {
            this.State = state;
        }

        /// <summary>
        /// Constructor for <see cref="AmazonCognitoIdentityResult{TResponse}"/>
        /// </summary>
        /// <param name="state">an optional state object</param>
        /// <param name="response">Typed response</param>
        /// <param name="exception">Exception object incase of error</param>
        public AmazonCognitoIdentityResult(TResponse response, Exception exception, object state)
        {
            this.Response = response;
            this.Exception = exception;
            this.State = state;
        }
    }
}
