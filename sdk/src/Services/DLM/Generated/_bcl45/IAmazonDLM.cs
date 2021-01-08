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
    public partial interface IAmazonDLM : IAmazonService, IDisposable
    {


        
        #region  CreateLifecyclePolicy


        /// <summary>
        /// Creates a policy to manage the lifecycle of the specified AWS resources. You can create
        /// up to 100 lifecycle policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLifecyclePolicy service method.</param>
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
        CreateLifecyclePolicyResponse CreateLifecyclePolicy(CreateLifecyclePolicyRequest request);



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
        Task<CreateLifecyclePolicyResponse> CreateLifecyclePolicyAsync(CreateLifecyclePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLifecyclePolicy


        /// <summary>
        /// Deletes the specified lifecycle policy and halts the automated operations that the
        /// policy specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy service method.</param>
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
        DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request);



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
        Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetLifecyclePoliciesResponse GetLifecyclePolicies(GetLifecyclePoliciesRequest request);



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
        Task<GetLifecyclePoliciesResponse> GetLifecyclePoliciesAsync(GetLifecyclePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLifecyclePolicy


        /// <summary>
        /// Gets detailed information about the specified lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy service method.</param>
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
        GetLifecyclePolicyResponse GetLifecyclePolicy(GetLifecyclePolicyRequest request);



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
        Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLifecyclePolicy


        /// <summary>
        /// Updates the specified lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLifecyclePolicy service method.</param>
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
        UpdateLifecyclePolicyResponse UpdateLifecyclePolicy(UpdateLifecyclePolicyRequest request);



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
        Task<UpdateLifecyclePolicyResponse> UpdateLifecyclePolicyAsync(UpdateLifecyclePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}