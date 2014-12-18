/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.IO;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler retrieved the AWS credentials to be used for the current call.
    /// </summary>
    public class CredentialsRetriever : GenericHandler
    {
        /// <summary>
        /// The constructor for CredentialsRetriever.
        /// </summary>
        /// <param name="credentials">An AWSCredentials instance.</param>
        public CredentialsRetriever(AWSCredentials credentials)
        {
            this.Credentials = credentials;
        }

        protected AWSCredentials Credentials
        {
            get;
            private set;
        }

        /// <summary>
        /// Retrieves the credentials to be used for the current call before 
        /// invoking the next handler.
        /// </summary>
        /// <param name="executionContext"></param>
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            ImmutableCredentials ic = null;
            if (Credentials != null && !(Credentials is AnonymousAWSCredentials))
            {
                using(executionContext.RequestContext.Metrics.StartEvent(Metric.CredentialsRequestTime))
                {
                    ic = Credentials.GetCredentials();
                }
            }

            executionContext.RequestContext.ImmutableCredentials = ic;
        }

#if BCL45 || WIN_RT || WINDOWS_PHONE 
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            ImmutableCredentials ic = null;
            if (Credentials != null && !(Credentials is AnonymousAWSCredentials))
            {
                using(executionContext.RequestContext.Metrics.StartEvent(Metric.CredentialsRequestTime))
                {
                    ic = await Credentials.GetCredentialsAsync().ConfigureAwait(false);
                }
            }

            executionContext.RequestContext.ImmutableCredentials = ic;

            return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
        }
#endif
    }
}
