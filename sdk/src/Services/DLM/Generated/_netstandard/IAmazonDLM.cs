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

namespace Amazon.DLM
{
    /// <summary>
    /// Interface for accessing DLM
    ///
    /// Amazon Data Lifecycle Manager 
    /// <para>
    /// With Amazon Data Lifecycle Manager, you can manage the lifecycle of your AWS resources.
    /// You create lifecycle policies, which are used to automate operations on the specified
    /// resources.
    /// </para>
    ///  
    /// <para>
    /// Amazon DLM supports Amazon EBS volumes and snapshots. For information about using
    /// Amazon DLM with Amazon EBS, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshot-lifecycle.html">Automating
    /// the Amazon EBS Snapshot Lifecycle</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonDLM : IAmazonService, IDisposable
    {
                
        #region  CreateLifecyclePolicy



        /// <summary>
        /// Creates a policy to manage the lifecycle of the specified AWS resources. You can create
        /// up to 100 lifecycle policies.
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
        /// To get complete information about a policy, use <a>GetLifecyclePolicy</a>.
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
        
    }
}