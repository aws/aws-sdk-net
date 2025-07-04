/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
    /// <summary>
    /// An implementation of the <see cref="DefaultRetryPolicy"/> that retries certain additional
    /// STS errors when doing AssumeRoleWithWebIdentity requests.
    /// </summary>
    public class SecurityTokenServiceRetryPolicy : DefaultRetryPolicy
    {
        /// <summary>
        /// Constructor for SecurityTokenServiceRetryPolicy.
        /// </summary>
        public SecurityTokenServiceRetryPolicy(IClientConfig config) : base(config)
        {
        }

        /// <summary>
        /// Returns true if the request should be retried.
        /// </summary>
        public override bool RetryForException(IExecutionContext executionContext, Exception exception)
        {
            if (executionContext.RequestContext.OriginalRequest is AssumeRoleWithWebIdentityRequest && (exception is IDPCommunicationErrorException || exception is InvalidIdentityTokenException))
            {
                return true;
            }

            return base.RetryForException(executionContext, exception);
        }

        /// <summary>
        /// Returns true if the request should be retried.
        /// </summary>
        public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
        {
            if (executionContext.RequestContext.OriginalRequest is AssumeRoleWithWebIdentityRequest && (exception is IDPCommunicationErrorException || exception is InvalidIdentityTokenException))
            {
                return Task.FromResult(true);
            }

            return base.RetryForExceptionAsync(executionContext, exception);
        }
    }


    /// <summary>
    /// An implementation of the <see cref="StandardRetryPolicy"/> that retries certain additional
    /// STS errors when doing AssumeRoleWithWebIdentity requests.
    /// </summary>
    public class SecurityTokenServiceStandardRetryPolicy : StandardRetryPolicy
    {
        /// <summary>
        /// Constructor for SecurityTokenServiceStandardRetryPolicy.
        /// </summary>
        public SecurityTokenServiceStandardRetryPolicy(IClientConfig config) : base(config)
        {
        }

        /// <summary>
        /// Returns true if the request should be retried.
        /// </summary>
        public override bool RetryForException(IExecutionContext executionContext, Exception exception)
        {
            if (executionContext.RequestContext.OriginalRequest is AssumeRoleWithWebIdentityRequest && (exception is IDPCommunicationErrorException || exception is InvalidIdentityTokenException))
            {
                return true;
            }

            return base.RetryForException(executionContext, exception);
        }

        /// <summary>
        /// Returns true if the request should be retried.
        /// </summary>
        public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
        {
            if (executionContext.RequestContext.OriginalRequest is AssumeRoleWithWebIdentityRequest && (exception is IDPCommunicationErrorException || exception is InvalidIdentityTokenException))
            {
                return Task.FromResult(true);
            }

            return base.RetryForExceptionAsync(executionContext, exception);
        }
    }


    /// <summary>
    /// An implementation of the <see cref="AdaptiveRetryPolicy"/> that retries certain additional
    /// STS errors when doing AssumeRoleWithWebIdentity requests.
    /// </summary>
    public class SecurityTokenServiceAdaptiveRetryPolicy : AdaptiveRetryPolicy
    {
        /// <summary>
        /// Constructor for SecurityTokenServiceAdaptiveRetryPolicy.
        /// </summary>
        public SecurityTokenServiceAdaptiveRetryPolicy(IClientConfig config) : base(config)
        {
        }

        /// <summary>
        /// Returns true if the request should be retried.
        /// </summary>
        public override bool RetryForException(IExecutionContext executionContext, Exception exception)
        {
            if (executionContext.RequestContext.OriginalRequest is AssumeRoleWithWebIdentityRequest && (exception is IDPCommunicationErrorException || exception is InvalidIdentityTokenException))
            {
                return true;
            }

            return base.RetryForException(executionContext, exception);
        }

        /// <summary>
        /// Returns true if the request should be retried.
        /// </summary>
        public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
        {
            if (executionContext.RequestContext.OriginalRequest is AssumeRoleWithWebIdentityRequest && (exception is IDPCommunicationErrorException || exception is InvalidIdentityTokenException))
            {
                return Task.FromResult(true);
            }

            return base.RetryForExceptionAsync(executionContext, exception);
        }
    }
}
