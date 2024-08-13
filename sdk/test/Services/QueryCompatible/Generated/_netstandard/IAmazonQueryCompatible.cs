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
 * Do not modify this file. This file is generated from the aws-query-compatible-2012-11-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QueryCompatible.Model;

#pragma warning disable CS1570
namespace Amazon.QueryCompatible
{
    /// <summary>
    /// <para>Interface for accessing QueryCompatible</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonQueryCompatible : IAmazonService, IDisposable
    {
                
        #region  CreateQueue



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by QueryCompatible.</returns>
        /// <exception cref="Amazon.QueryCompatible.Model.QueueDeletedRecentlyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatible.Model.QueueNameExistsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MemberRefOp



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MemberRefOp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MemberRefOp service method, as returned by QueryCompatible.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        Task<MemberRefOpResponse> MemberRefOpAsync(MemberRefOpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StaticOp



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticOp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StaticOp service method, as returned by QueryCompatible.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/StaticOp">REST API Reference for StaticOp Operation</seealso>
        Task<StaticOpResponse> StaticOpAsync(StaticOpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonQueryCompatibleConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonQueryCompatibleConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonQueryCompatibleConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonQueryCompatibleConfig to create AmazonQueryCompatibleClient");
            }

            return awsCredentials == null ? 
                    new AmazonQueryCompatibleClient(serviceClientConfig) :
                    new AmazonQueryCompatibleClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}