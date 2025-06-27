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

/*
 * Do not modify this file. This file is generated from the query-compatible-json-rpc-10-2020-07-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QueryCompatibleJSONRPC10.Model;

#pragma warning disable CS1570
namespace Amazon.QueryCompatibleJSONRPC10
{
    /// <summary>
    /// <para>Interface for accessing QueryCompatibleJSONRPC10</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonQueryCompatibleJSONRPC10 : IAmazonService, IDisposable
    {
                
        #region  QueryCompatibleOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryCompatibleOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryCompatibleOperation service method, as returned by QueryCompatibleJSONRPC10.</returns>
        /// <exception cref="Amazon.QueryCompatibleJSONRPC10.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatibleJSONRPC10.Model.NoCustomCodeErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-json-rpc-10-2020-07-14/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        Task<QueryCompatibleOperationResponse> QueryCompatibleOperationAsync(QueryCompatibleOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonQueryCompatibleJSONRPC10Config))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonQueryCompatibleJSONRPC10Config();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonQueryCompatibleJSONRPC10Config;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonQueryCompatibleJSONRPC10Config to create AmazonQueryCompatibleJSONRPC10Client");
            }

            return awsCredentials == null ? 
                    new AmazonQueryCompatibleJSONRPC10Client(serviceClientConfig) :
                    new AmazonQueryCompatibleJSONRPC10Client(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}