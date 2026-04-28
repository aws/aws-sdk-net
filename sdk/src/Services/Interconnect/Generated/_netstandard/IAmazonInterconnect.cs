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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Interconnect.Model;

#pragma warning disable CS1570
namespace Amazon.Interconnect
{
    /// <summary>
    /// <para>Interface for accessing Interconnect</para>
    ///
    /// Provides managed connections between your AWS network resources and select partner
    /// network resources.
    /// </summary>
    public partial interface IAmazonInterconnect : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IInterconnectPaginatorFactory Paginators { get; }
#endif
                
        #region  AcceptConnectionProposal



        /// <summary>
        /// Accepts a connection proposal which was generated at a supported partner's portal.
        /// 
        ///  
        /// <para>
        /// The proposal contains the Environment and bandwidth that were chosen on the partner's
        /// portal and cannot be modified.
        /// </para>
        ///  
        /// <para>
        /// Upon accepting the proposal a connection will be made between the AWS network as accessed
        /// via the selected Attach Point and the network previously selected network on the partner's
        /// portal.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptConnectionProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptConnectionProposal service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/AcceptConnectionProposal">REST API Reference for AcceptConnectionProposal Operation</seealso>
        Task<AcceptConnectionProposalResponse> AcceptConnectionProposalAsync(AcceptConnectionProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConnection



        /// <summary>
        /// Initiates the process to create a Connection across the specified Environment. 
        /// 
        ///  
        /// <para>
        /// The Environment dictates the specified partner and location to which the other end
        /// of the connection should attach. You can see a list of the available Environments
        /// by calling <a>ListEnvironments</a> 
        /// </para>
        ///  
        /// <para>
        /// The Attach Point specifies where within the AWS Network your connection will logically
        /// connect.
        /// </para>
        ///  
        /// <para>
        /// After a successful call to this method, the resulting <a>Connection</a> will return
        /// an Activation Key which will need to be brought to the specific partner's portal to
        /// confirm the <a>Connection</a> on both sides. (See <a>Environment$activationPageUrl</a>
        /// for a direct link to the partner portal). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConnection



        /// <summary>
        /// Deletes an existing Connection with the supplied identifier.
        /// 
        ///  
        /// <para>
        /// This operation will also inform the remote partner of your intention to delete your
        /// connection. Note, the partner may still require you to delete to fully clean up resources,
        /// but the network connectivity provided by the <a>Connection</a> will cease to exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConnectionProposal



        /// <summary>
        /// Describes the details of a connection proposal generated at a partner's portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnectionProposal service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/DescribeConnectionProposal">REST API Reference for DescribeConnectionProposal Operation</seealso>
        Task<DescribeConnectionProposalResponse> DescribeConnectionProposalAsync(DescribeConnectionProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnection



        /// <summary>
        /// Describes the current state of a Connection resource as specified by the identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/GetConnection">REST API Reference for GetConnection Operation</seealso>
        Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnvironment



        /// <summary>
        /// Describes a specific <a>Environment</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttachPoints



        /// <summary>
        /// Lists all Attach Points the caller has access to that are valid for the specified
        /// <a>Environment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttachPoints service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/ListAttachPoints">REST API Reference for ListAttachPoints Operation</seealso>
        Task<ListAttachPointsResponse> ListAttachPointsAsync(ListAttachPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConnections



        /// <summary>
        /// Lists all connection objects to which the caller has access.
        /// 
        ///  
        /// <para>
        /// Allows for optional filtering by the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>state</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>environmentId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provider</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attach point</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only <a>Connection</a> objects matching all filters will be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/ListConnections">REST API Reference for ListConnections Operation</seealso>
        Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironments



        /// <summary>
        /// Lists all of the environments that can produce connections that will land in the called
        /// AWS region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// List all current tags on the specified resource. Currently this supports <a>Connection</a>
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Add new tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConnection



        /// <summary>
        /// Modifies an existing connection. Currently we support modifications to the connection's
        /// description and/or bandwidth.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonInterconnectConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonInterconnectConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonInterconnectConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonInterconnectConfig to create AmazonInterconnectClient");
            }

            return awsCredentials == null ? 
                    new AmazonInterconnectClient(serviceClientConfig) :
                    new AmazonInterconnectClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}