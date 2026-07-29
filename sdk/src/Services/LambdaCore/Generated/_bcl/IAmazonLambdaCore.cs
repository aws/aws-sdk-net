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
 * Do not modify this file. This file is generated from the lambda-core-2026-04-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LambdaCore.Model;

#pragma warning disable CS1570
namespace Amazon.LambdaCore
{
    /// <summary>
    /// <para>Interface for accessing LambdaCore</para>
    ///
    /// AWS Lambda Core is a set of APIs for managing shared infrastructure resources used
    /// by AWS Lambda. The Lambda Core API provides operations for creating and managing network
    /// connectors that enable Lambda MicroVMs to access resources in your Amazon Virtual
    /// Private Cloud (Amazon VPC).
    /// 
    ///  
    /// <para>
    /// Network connectors provision elastic network interfaces (ENIs) in your VPC subnets,
    /// providing a managed network path from Lambda compute environments to private resources
    /// such as Amazon RDS databases, Amazon ElastiCache clusters, and internal APIs. You
    /// create a network connector once and attach it to one or more Lambda MicroVMs at run
    /// time.
    /// </para>
    /// </summary>
    public partial interface IAmazonLambdaCore : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILambdaCorePaginatorFactory Paginators { get; }

        
        #region  CreateNetworkConnector


        /// <summary>
        /// Creates a network connector that enables Lambda compute resources to route outbound
        /// traffic through your Amazon VPC. The network connector provisions elastic network
        /// interfaces (ENIs) in the subnets you specify, providing a managed network path to
        /// private resources such as databases, caches, and internal APIs.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. The network connector starts in <c>PENDING</c> state
        /// while ENIs are provisioned in your VPC (provisioning typically takes up to 10 minutes).
        /// Use <c>GetNetworkConnector</c> to poll the connector state until it reaches <c>ACTIVE</c>.
        /// Once active, you can attach the connector to Lambda MicroVMs at run time using the
        /// <c>egressNetworkConnectors</c> parameter on <c>RunMicroVm</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent when you provide a <c>ClientToken</c> — if you retry
        /// a request that completed successfully using the same client token, the operation returns
        /// the existing connector without creating a duplicate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkConnector service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.NetworkConnectorLimitExceededException">
        /// The account has reached the maximum number of network connectors allowed. Delete unused
        /// connectors or request a limit increase through Service Quotas.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to update a connector that is not in <c>ACTIVE</c>
        /// state.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateNetworkConnector">REST API Reference for CreateNetworkConnector Operation</seealso>
        CreateNetworkConnectorResponse CreateNetworkConnector(CreateNetworkConnectorRequest request);



        /// <summary>
        /// Creates a network connector that enables Lambda compute resources to route outbound
        /// traffic through your Amazon VPC. The network connector provisions elastic network
        /// interfaces (ENIs) in the subnets you specify, providing a managed network path to
        /// private resources such as databases, caches, and internal APIs.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. The network connector starts in <c>PENDING</c> state
        /// while ENIs are provisioned in your VPC (provisioning typically takes up to 10 minutes).
        /// Use <c>GetNetworkConnector</c> to poll the connector state until it reaches <c>ACTIVE</c>.
        /// Once active, you can attach the connector to Lambda MicroVMs at run time using the
        /// <c>egressNetworkConnectors</c> parameter on <c>RunMicroVm</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent when you provide a <c>ClientToken</c> — if you retry
        /// a request that completed successfully using the same client token, the operation returns
        /// the existing connector without creating a duplicate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.NetworkConnectorLimitExceededException">
        /// The account has reached the maximum number of network connectors allowed. Delete unused
        /// connectors or request a limit increase through Service Quotas.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to update a connector that is not in <c>ACTIVE</c>
        /// state.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/CreateNetworkConnector">REST API Reference for CreateNetworkConnector Operation</seealso>
        Task<CreateNetworkConnectorResponse> CreateNetworkConnectorAsync(CreateNetworkConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNetworkConnector


        /// <summary>
        /// Initiates deletion of a network connector. The connector transitions to <c>DELETING</c>
        /// state while elastic network interfaces are cleaned up asynchronously. After deletion
        /// completes, subsequent calls to <c>GetNetworkConnector</c> return <c>ResourceNotFoundException</c>.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent — calling delete on a connector that is already deleting
        /// or has been deleted succeeds without error. You can delete connectors in <c>ACTIVE</c>
        /// or <c>FAILED</c> states. Before deleting a connector, ensure that no Lambda MicroVMs
        /// are using it, as they will lose VPC egress connectivity immediately.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to update a connector that is not in <c>ACTIVE</c>
        /// state.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified network connector does not exist. Verify the identifier (ID, name, or
        /// ARN) and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteNetworkConnector">REST API Reference for DeleteNetworkConnector Operation</seealso>
        DeleteNetworkConnectorResponse DeleteNetworkConnector(DeleteNetworkConnectorRequest request);



        /// <summary>
        /// Initiates deletion of a network connector. The connector transitions to <c>DELETING</c>
        /// state while elastic network interfaces are cleaned up asynchronously. After deletion
        /// completes, subsequent calls to <c>GetNetworkConnector</c> return <c>ResourceNotFoundException</c>.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent — calling delete on a connector that is already deleting
        /// or has been deleted succeeds without error. You can delete connectors in <c>ACTIVE</c>
        /// or <c>FAILED</c> states. Before deleting a connector, ensure that no Lambda MicroVMs
        /// are using it, as they will lose VPC egress connectivity immediately.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to update a connector that is not in <c>ACTIVE</c>
        /// state.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified network connector does not exist. Verify the identifier (ID, name, or
        /// ARN) and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/DeleteNetworkConnector">REST API Reference for DeleteNetworkConnector Operation</seealso>
        Task<DeleteNetworkConnectorResponse> DeleteNetworkConnectorAsync(DeleteNetworkConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNetworkConnector


        /// <summary>
        /// Retrieves the current configuration, state, and metadata of a network connector. The
        /// <c>Identifier</c> parameter accepts the connector ID, name, or full ARN. Use this
        /// operation to poll connector state after creation or update, or to inspect the current
        /// VPC configuration and any failure reasons.
        /// 
        ///  
        /// <para>
        /// The response includes the full connector configuration, current state, and — if the
        /// connector has been updated — the <c>LastUpdateStatus</c> and <c>LastUpdateStatusReasonCode</c>
        /// fields that indicate whether the most recent update succeeded or failed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkConnector service method.</param>
        /// 
        /// <returns>The response from the GetNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified network connector does not exist. Verify the identifier (ID, name, or
        /// ARN) and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetNetworkConnector">REST API Reference for GetNetworkConnector Operation</seealso>
        GetNetworkConnectorResponse GetNetworkConnector(GetNetworkConnectorRequest request);



        /// <summary>
        /// Retrieves the current configuration, state, and metadata of a network connector. The
        /// <c>Identifier</c> parameter accepts the connector ID, name, or full ARN. Use this
        /// operation to poll connector state after creation or update, or to inspect the current
        /// VPC configuration and any failure reasons.
        /// 
        ///  
        /// <para>
        /// The response includes the full connector configuration, current state, and — if the
        /// connector has been updated — the <c>LastUpdateStatus</c> and <c>LastUpdateStatusReasonCode</c>
        /// fields that indicate whether the most recent update succeeded or failed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified network connector does not exist. Verify the identifier (ID, name, or
        /// ARN) and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/GetNetworkConnector">REST API Reference for GetNetworkConnector Operation</seealso>
        Task<GetNetworkConnectorResponse> GetNetworkConnectorAsync(GetNetworkConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNetworkConnectors


        /// <summary>
        /// Returns a paginated list of network connectors in your account for the current Region.
        /// You can optionally filter results by connector state. Use the <c>Marker</c> parameter
        /// from a previous response to retrieve the next page of results.
        /// 
        ///  
        /// <para>
        /// Each item in the response includes the connector ARN, name, ID, type, current state,
        /// and last modified timestamp. To retrieve full configuration details for a specific
        /// connector, use <c>GetNetworkConnector</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkConnectors service method.</param>
        /// 
        /// <returns>The response from the ListNetworkConnectors service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListNetworkConnectors">REST API Reference for ListNetworkConnectors Operation</seealso>
        ListNetworkConnectorsResponse ListNetworkConnectors(ListNetworkConnectorsRequest request);



        /// <summary>
        /// Returns a paginated list of network connectors in your account for the current Region.
        /// You can optionally filter results by connector state. Use the <c>Marker</c> parameter
        /// from a previous response to retrieve the next page of results.
        /// 
        ///  
        /// <para>
        /// Each item in the response includes the connector ARN, name, ID, type, current state,
        /// and last modified timestamp. To retrieve full configuration details for a specific
        /// connector, use <c>GetNetworkConnector</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworkConnectors service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/ListNetworkConnectors">REST API Reference for ListNetworkConnectors Operation</seealso>
        Task<ListNetworkConnectorsResponse> ListNetworkConnectorsAsync(ListNetworkConnectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNetworkConnector


        /// <summary>
        /// Updates the VPC configuration or operator role of an existing network connector. You
        /// can modify the subnet IDs, security group IDs, network protocol, or operator role.
        /// The connector must be in <c>ACTIVE</c> state to accept updates.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. The connector remains in <c>ACTIVE</c> state during
        /// the update — existing workloads that reference this connector are not disrupted. Use
        /// <c>GetNetworkConnector</c> to monitor the <c>LastUpdateStatus</c> field, which transitions
        /// through <c>InProgress</c> to <c>Successful</c> or <c>Failed</c>. If the update fails,
        /// the <c>LastUpdateStatusReasonCode</c> field provides a specific error code for troubleshooting.
        /// This operation is idempotent when you provide a <c>ClientToken</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkConnector service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to update a connector that is not in <c>ACTIVE</c>
        /// state.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified network connector does not exist. Verify the identifier (ID, name, or
        /// ARN) and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateNetworkConnector">REST API Reference for UpdateNetworkConnector Operation</seealso>
        UpdateNetworkConnectorResponse UpdateNetworkConnector(UpdateNetworkConnectorRequest request);



        /// <summary>
        /// Updates the VPC configuration or operator role of an existing network connector. You
        /// can modify the subnet IDs, security group IDs, network protocol, or operator role.
        /// The connector must be in <c>ACTIVE</c> state to accept updates.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous. The connector remains in <c>ACTIVE</c> state during
        /// the update — existing workloads that reference this connector are not disrupted. Use
        /// <c>GetNetworkConnector</c> to monitor the <c>LastUpdateStatus</c> field, which transitions
        /// through <c>InProgress</c> to <c>Successful</c> or <c>Failed</c>. If the update fails,
        /// the <c>LastUpdateStatusReasonCode</c> field provides a specific error code for troubleshooting.
        /// This operation is idempotent when you provide a <c>ClientToken</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkConnector service method, as returned by LambdaCore.</returns>
        /// <exception cref="Amazon.LambdaCore.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid. Check the error message for details
        /// about which parameter failed validation.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to update a connector that is not in <c>ACTIVE</c>
        /// state.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ResourceNotFoundException">
        /// The specified network connector does not exist. Verify the identifier (ID, name, or
        /// ARN) and Region.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.ServiceException">
        /// An internal service error occurred. Retry the request with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaCore.Model.TooManyRequestsException">
        /// The request was throttled due to exceeding the allowed request rate. Retry the request
        /// after a brief wait using exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-core-2026-04-30/UpdateNetworkConnector">REST API Reference for UpdateNetworkConnector Operation</seealso>
        Task<UpdateNetworkConnectorResponse> UpdateNetworkConnectorAsync(UpdateNetworkConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}