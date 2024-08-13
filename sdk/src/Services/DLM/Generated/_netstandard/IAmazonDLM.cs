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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DLM.Model;

#pragma warning disable CS1570
namespace Amazon.DLM
{
    /// <summary>
    /// <para>Interface for accessing DLM</para>
    ///
    /// Amazon Data Lifecycle Manager 
    /// <para>
    /// With Amazon Data Lifecycle Manager, you can manage the lifecycle of your Amazon Web
    /// Services resources. You create lifecycle policies, which are used to automate operations
    /// on the specified resources.
    /// </para>
    ///  
    /// <para>
    /// Amazon Data Lifecycle Manager supports Amazon EBS volumes and snapshots. For information
    /// about using Amazon Data Lifecycle Manager with Amazon EBS, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshot-lifecycle.html">
    /// Amazon Data Lifecycle Manager</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonDLM : IAmazonService, IDisposable
    {
                
        #region  CreateLifecyclePolicy



        /// <summary>
        /// Creates an Amazon Data Lifecycle Manager lifecycle policy. Amazon Data Lifecycle Manager
        /// supports the following policy types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Custom EBS snapshot policy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Custom EBS-backed AMI policy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cross-account copy event policy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default policy for EBS snapshots
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default policy for EBS-backed AMIs
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/policy-differences.html">
        /// Default policies vs custom policies</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you create a default policy, you can specify the request parameters either in the
        /// request body, or in the PolicyDetails request structure, but not both.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLifecyclePolicy service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.InvalidRequestException">
        /// Bad request. The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/CreateLifecyclePolicy">REST API Reference for CreateLifecyclePolicy Operation</seealso>
        Task<CreateLifecyclePolicyResponse> CreateLifecyclePolicyAsync(CreateLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLifecyclePolicy



        /// <summary>
        /// Deletes the specified lifecycle policy and halts the automated operations that the
        /// policy specified.
        /// 
        ///  
        /// <para>
        /// For more information about deleting a policy, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/view-modify-delete.html#delete">Delete
        /// lifecycle policies</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecyclePolicy service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLifecyclePolicies



        /// <summary>
        /// Gets summary information about all or the specified data lifecycle policies.
        /// 
        ///  
        /// <para>
        /// To get complete information about a policy, use <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_GetLifecyclePolicy.html">GetLifecyclePolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLifecyclePolicies service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.InvalidRequestException">
        /// Bad request. The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicies">REST API Reference for GetLifecyclePolicies Operation</seealso>
        Task<GetLifecyclePoliciesResponse> GetLifecyclePoliciesAsync(GetLifecyclePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLifecyclePolicy



        /// <summary>
        /// Gets detailed information about the specified lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLifecyclePolicy service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.InvalidRequestException">
        /// Bad request. The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.InvalidRequestException">
        /// Bad request. The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.InvalidRequestException">
        /// Bad request. The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLifecyclePolicy



        /// <summary>
        /// Updates the specified lifecycle policy.
        /// 
        ///  
        /// <para>
        /// For more information about updating a policy, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/view-modify-delete.html#modify">Modify
        /// lifecycle policies</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLifecyclePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLifecyclePolicy service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.InvalidRequestException">
        /// Bad request. The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/UpdateLifecyclePolicy">REST API Reference for UpdateLifecyclePolicy Operation</seealso>
        Task<UpdateLifecyclePolicyResponse> UpdateLifecyclePolicyAsync(UpdateLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonDLMConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonDLMConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonDLMConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonDLMConfig to create AmazonDLMClient");
            }

            return awsCredentials == null ? 
                    new AmazonDLMClient(serviceClientConfig) :
                    new AmazonDLMClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}