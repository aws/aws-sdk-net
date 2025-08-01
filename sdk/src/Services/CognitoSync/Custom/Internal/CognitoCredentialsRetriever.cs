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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

using Amazon.CognitoIdentity;
using Amazon.CognitoSync.Model;
using Amazon.CognitoSync.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal;

namespace Amazon.CognitoSync.Internal
{
    /// <summary>
    /// When the service client is using the CognitoAWSCredentials credentials object it makes sure that all
    /// CognitoSync calls have the latest identity id and identity pool id.
    /// </summary>
#if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("Amazon CognitoSync has not been updated to support Native AOT compilations.")]
#endif
    public class CognitoCredentialsRetriever : PipelineHandler
    {
        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// request and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

        /// <summary>
        /// Custom pipeline handler
        /// </summary>
        /// <param name="executionContext"></param>
        protected void PreInvoke(IExecutionContext executionContext)
        {
            // Only configure IdentityPoolId and IdentityId when using CognitoAWSCredentials
            var cognitoCredentials = executionContext.RequestContext.Identity as CognitoAWSCredentials;
            if (cognitoCredentials != null)
            {
                SetIdentity(executionContext, cognitoCredentials.GetIdentityId(), cognitoCredentials.IdentityPoolId);
            }
        }

        /// <summary>
        /// Continue the request pipeline and copy over the cognito identity id.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="executionContext"></param>
        /// <returns></returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            T result = await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);

            // Only configure IdentityPoolId and IdentityId when using CognitoAWSCredentials
            var cognitoCredentials = executionContext.RequestContext.Identity as CognitoAWSCredentials;
            if (cognitoCredentials != null)
            {
                string identityId = await cognitoCredentials.GetIdentityIdAsync().ConfigureAwait(false);
                SetIdentity(executionContext, identityId, cognitoCredentials.IdentityPoolId);                
            }

            return result;
        }

        private static void SetIdentity(IExecutionContext executionContext, string identityId, string identityPoolId)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            var syncRequest = request as AmazonCognitoSyncRequest;
            if (syncRequest != null)
            {
                // Set the IdentityId and IdentityPoolId fields on the request.
                CSRequestCache.SetFields(syncRequest, identityPoolId, identityId);
            }
        }

        /// <summary>
        /// A cache of objects that store the reflection objects. This is done so that reflection is only used once in order to 
        /// set the fields on the request.
        /// </summary>
#if NET8_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("CognitoSync has not been updated to support Native AOT compilations.")]
#endif
        private static class CSRequestCache
        {
            /// <summary>
            /// This class holds on to the reflection objects to invoke the setters for IdentityId and IdentityPoolId for the given type.
            /// </summary>
#if NET8_0_OR_GREATER
            [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("CognitoSync has not been updated to support Native AOT compilations.")]
#endif
            private class CSRequest
            {
                private Type requestType;
                private PropertyInfo identityPoolIdProperty;
                private PropertyInfo identityIdProperty;
                public static Type SyncRequestType = typeof(AmazonCognitoSyncRequest);

                public CSRequest(Type requestType)
                {
                    this.requestType = requestType;

                    if (!SyncRequestType.IsAssignableFrom(this.requestType))
                        throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Unable to assign {0} from {1}",
                            SyncRequestType.FullName, requestType.FullName));


                    this.identityIdProperty = this.requestType.GetProperty("IdentityId");
                    this.identityPoolIdProperty = this.requestType.GetProperty("IdentityPoolId");
                }

                public void SetFields(AmazonCognitoSyncRequest request, string identityPoolId, string identityId)
                {
                    if (identityIdProperty != null)
                        identityIdProperty.SetValue(request, identityId, null);
                    if (identityPoolIdProperty != null)
                        identityPoolIdProperty.SetValue(request, identityPoolId, null);
                }
            }

            private static Dictionary<Type, CSRequest> requestCache = new Dictionary<Type, CSRequest>();
            static CSRequestCache()
            {
                PopulateCache();
            }

            private static void PopulateCache()
            {
                var sourceAssembly = CSRequest.SyncRequestType.Assembly;
                var allTypes = sourceAssembly.GetTypes();
                // Look up all CognitoSync request objects for caching.
                foreach (var type in allTypes)
                {
                    var typeInfo = type;
                    if (CSRequest.SyncRequestType.IsAssignableFrom(typeInfo) && !typeInfo.Equals(CSRequest.SyncRequestType))
                    {
                        var csRequest = new CSRequest(type);
                        requestCache[type] = csRequest;
                    }
                }
            }

            /// <summary>
            /// Set the IdentityId and IdentityPoolId properties on the request object
            /// </summary>
            /// <param name="request"></param>
            /// <param name="identityPoolId"></param>
            /// <param name="identityId"></param>
            public static void SetFields(AmazonCognitoSyncRequest request, string identityPoolId, string identityId)
            {
                Type requestType = request.GetType();
                CSRequest csRequest;
                if (requestCache.TryGetValue(requestType, out csRequest))
                {
                    csRequest.SetFields(request, identityPoolId, identityId);
                }
            }
        }
    }
}
