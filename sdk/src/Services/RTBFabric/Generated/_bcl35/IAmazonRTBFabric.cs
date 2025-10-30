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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RTBFabric.Model;

#pragma warning disable CS1570
namespace Amazon.RTBFabric
{
    /// <summary>
    /// <para>Interface for accessing RTBFabric</para>
    ///
    /// Amazon Web Services RTB Fabric provides secure, low-latency infrastructure for connecting
    /// real-time bidding (RTB) applications. Rather than hosting applications directly, RTB
    /// Fabric acts as the connecting fabric that enables your applications to communicate
    /// efficiently over private networks instead of the public internet. You maintain complete
    /// control over your applications, data, and bidding decisions, while RTB Fabric provides
    /// the underlying infrastructure for secure, reliable connectivity.
    /// 
    ///  
    /// <para>
    /// You can use these APIs to complete RTB Fabric tasks, such as setting up audit log
    /// ingestions or viewing user access. For more information about RTB Fabric, including
    /// the required permissions to use the service, see the <a href="https://docs.aws.amazon.com/rtb-fabric/latest/userguide/">Amazon
    /// Web Services RTB Fabric User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonRTBFabric : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRTBFabricPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptLink


        /// <summary>
        /// Accepts a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to accept the link request and establish the connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptLink service method.</param>
        /// 
        /// <returns>The response from the AcceptLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AcceptLink">REST API Reference for AcceptLink Operation</seealso>
        AcceptLinkResponse AcceptLink(AcceptLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AcceptLink">REST API Reference for AcceptLink Operation</seealso>
        IAsyncResult BeginAcceptLink(AcceptLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptLink.</param>
        /// 
        /// <returns>Returns a  AcceptLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AcceptLink">REST API Reference for AcceptLink Operation</seealso>
        AcceptLinkResponse EndAcceptLink(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInboundExternalLink


        /// <summary>
        /// Creates an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the CreateInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateInboundExternalLink">REST API Reference for CreateInboundExternalLink Operation</seealso>
        CreateInboundExternalLinkResponse CreateInboundExternalLink(CreateInboundExternalLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateInboundExternalLink">REST API Reference for CreateInboundExternalLink Operation</seealso>
        IAsyncResult BeginCreateInboundExternalLink(CreateInboundExternalLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInboundExternalLink.</param>
        /// 
        /// <returns>Returns a  CreateInboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateInboundExternalLink">REST API Reference for CreateInboundExternalLink Operation</seealso>
        CreateInboundExternalLinkResponse EndCreateInboundExternalLink(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLink


        /// <summary>
        /// Creates a new link between gateways.
        /// 
        ///  
        /// <para>
        /// Establishes a connection that allows gateways to communicate and exchange bid requests
        /// and responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// 
        /// <returns>The response from the CreateLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLink">REST API Reference for CreateLink Operation</seealso>
        CreateLinkResponse CreateLink(CreateLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLink">REST API Reference for CreateLink Operation</seealso>
        IAsyncResult BeginCreateLink(CreateLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLink.</param>
        /// 
        /// <returns>Returns a  CreateLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLink">REST API Reference for CreateLink Operation</seealso>
        CreateLinkResponse EndCreateLink(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOutboundExternalLink


        /// <summary>
        /// Creates an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the CreateOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        CreateOutboundExternalLinkResponse CreateOutboundExternalLink(CreateOutboundExternalLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOutboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        IAsyncResult BeginCreateOutboundExternalLink(CreateOutboundExternalLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOutboundExternalLink.</param>
        /// 
        /// <returns>Returns a  CreateOutboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        CreateOutboundExternalLinkResponse EndCreateOutboundExternalLink(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRequesterGateway


        /// <summary>
        /// Creates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the CreateRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateRequesterGateway">REST API Reference for CreateRequesterGateway Operation</seealso>
        CreateRequesterGatewayResponse CreateRequesterGateway(CreateRequesterGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRequesterGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRequesterGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateRequesterGateway">REST API Reference for CreateRequesterGateway Operation</seealso>
        IAsyncResult BeginCreateRequesterGateway(CreateRequesterGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRequesterGateway.</param>
        /// 
        /// <returns>Returns a  CreateRequesterGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateRequesterGateway">REST API Reference for CreateRequesterGateway Operation</seealso>
        CreateRequesterGatewayResponse EndCreateRequesterGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResponderGateway


        /// <summary>
        /// Creates a responder gateway.
        /// 
        ///  <important> 
        /// <para>
        /// A domain name or managed endpoint is required.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponderGateway service method.</param>
        /// 
        /// <returns>The response from the CreateResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateResponderGateway">REST API Reference for CreateResponderGateway Operation</seealso>
        CreateResponderGatewayResponse CreateResponderGateway(CreateResponderGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResponderGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResponderGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateResponderGateway">REST API Reference for CreateResponderGateway Operation</seealso>
        IAsyncResult BeginCreateResponderGateway(CreateResponderGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResponderGateway.</param>
        /// 
        /// <returns>Returns a  CreateResponderGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateResponderGateway">REST API Reference for CreateResponderGateway Operation</seealso>
        CreateResponderGatewayResponse EndCreateResponderGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInboundExternalLink


        /// <summary>
        /// Deletes an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the DeleteInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteInboundExternalLink">REST API Reference for DeleteInboundExternalLink Operation</seealso>
        DeleteInboundExternalLinkResponse DeleteInboundExternalLink(DeleteInboundExternalLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteInboundExternalLink">REST API Reference for DeleteInboundExternalLink Operation</seealso>
        IAsyncResult BeginDeleteInboundExternalLink(DeleteInboundExternalLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInboundExternalLink.</param>
        /// 
        /// <returns>Returns a  DeleteInboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteInboundExternalLink">REST API Reference for DeleteInboundExternalLink Operation</seealso>
        DeleteInboundExternalLinkResponse EndDeleteInboundExternalLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLink


        /// <summary>
        /// Deletes a link between gateways.
        /// 
        ///  
        /// <para>
        /// Permanently removes the connection between gateways. This action cannot be undone.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// 
        /// <returns>The response from the DeleteLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        DeleteLinkResponse DeleteLink(DeleteLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        IAsyncResult BeginDeleteLink(DeleteLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLink.</param>
        /// 
        /// <returns>Returns a  DeleteLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        DeleteLinkResponse EndDeleteLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOutboundExternalLink


        /// <summary>
        /// Deletes an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the DeleteOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteOutboundExternalLink">REST API Reference for DeleteOutboundExternalLink Operation</seealso>
        DeleteOutboundExternalLinkResponse DeleteOutboundExternalLink(DeleteOutboundExternalLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOutboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteOutboundExternalLink">REST API Reference for DeleteOutboundExternalLink Operation</seealso>
        IAsyncResult BeginDeleteOutboundExternalLink(DeleteOutboundExternalLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOutboundExternalLink.</param>
        /// 
        /// <returns>Returns a  DeleteOutboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteOutboundExternalLink">REST API Reference for DeleteOutboundExternalLink Operation</seealso>
        DeleteOutboundExternalLinkResponse EndDeleteOutboundExternalLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRequesterGateway


        /// <summary>
        /// Deletes a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        DeleteRequesterGatewayResponse DeleteRequesterGateway(DeleteRequesterGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequesterGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRequesterGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        IAsyncResult BeginDeleteRequesterGateway(DeleteRequesterGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRequesterGateway.</param>
        /// 
        /// <returns>Returns a  DeleteRequesterGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        DeleteRequesterGatewayResponse EndDeleteRequesterGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResponderGateway


        /// <summary>
        /// Deletes a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponderGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        DeleteResponderGatewayResponse DeleteResponderGateway(DeleteResponderGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponderGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResponderGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        IAsyncResult BeginDeleteResponderGateway(DeleteResponderGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResponderGateway.</param>
        /// 
        /// <returns>Returns a  DeleteResponderGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        DeleteResponderGatewayResponse EndDeleteResponderGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInboundExternalLink


        /// <summary>
        /// Retrieves information about an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the GetInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetInboundExternalLink">REST API Reference for GetInboundExternalLink Operation</seealso>
        GetInboundExternalLinkResponse GetInboundExternalLink(GetInboundExternalLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetInboundExternalLink">REST API Reference for GetInboundExternalLink Operation</seealso>
        IAsyncResult BeginGetInboundExternalLink(GetInboundExternalLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInboundExternalLink.</param>
        /// 
        /// <returns>Returns a  GetInboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetInboundExternalLink">REST API Reference for GetInboundExternalLink Operation</seealso>
        GetInboundExternalLinkResponse EndGetInboundExternalLink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLink


        /// <summary>
        /// Retrieves information about a link between gateways.
        /// 
        ///  
        /// <para>
        /// Returns detailed information about the link configuration, status, and associated
        /// gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLink service method.</param>
        /// 
        /// <returns>The response from the GetLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLink">REST API Reference for GetLink Operation</seealso>
        GetLinkResponse GetLink(GetLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLink">REST API Reference for GetLink Operation</seealso>
        IAsyncResult BeginGetLink(GetLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLink.</param>
        /// 
        /// <returns>Returns a  GetLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLink">REST API Reference for GetLink Operation</seealso>
        GetLinkResponse EndGetLink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOutboundExternalLink


        /// <summary>
        /// Retrieves information about an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the GetOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetOutboundExternalLink">REST API Reference for GetOutboundExternalLink Operation</seealso>
        GetOutboundExternalLinkResponse GetOutboundExternalLink(GetOutboundExternalLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetOutboundExternalLink">REST API Reference for GetOutboundExternalLink Operation</seealso>
        IAsyncResult BeginGetOutboundExternalLink(GetOutboundExternalLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutboundExternalLink.</param>
        /// 
        /// <returns>Returns a  GetOutboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetOutboundExternalLink">REST API Reference for GetOutboundExternalLink Operation</seealso>
        GetOutboundExternalLinkResponse EndGetOutboundExternalLink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRequesterGateway


        /// <summary>
        /// Retrieves information about a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the GetRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetRequesterGateway">REST API Reference for GetRequesterGateway Operation</seealso>
        GetRequesterGatewayResponse GetRequesterGateway(GetRequesterGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRequesterGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRequesterGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetRequesterGateway">REST API Reference for GetRequesterGateway Operation</seealso>
        IAsyncResult BeginGetRequesterGateway(GetRequesterGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRequesterGateway.</param>
        /// 
        /// <returns>Returns a  GetRequesterGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetRequesterGateway">REST API Reference for GetRequesterGateway Operation</seealso>
        GetRequesterGatewayResponse EndGetRequesterGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResponderGateway


        /// <summary>
        /// Retrieves information about a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponderGateway service method.</param>
        /// 
        /// <returns>The response from the GetResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetResponderGateway">REST API Reference for GetResponderGateway Operation</seealso>
        GetResponderGatewayResponse GetResponderGateway(GetResponderGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResponderGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResponderGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetResponderGateway">REST API Reference for GetResponderGateway Operation</seealso>
        IAsyncResult BeginGetResponderGateway(GetResponderGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResponderGateway.</param>
        /// 
        /// <returns>Returns a  GetResponderGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetResponderGateway">REST API Reference for GetResponderGateway Operation</seealso>
        GetResponderGatewayResponse EndGetResponderGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLinks


        /// <summary>
        /// Lists links associated with gateways.
        /// 
        ///  
        /// <para>
        /// Returns a list of all links for the specified gateways, including their status and
        /// configuration details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinks service method.</param>
        /// 
        /// <returns>The response from the ListLinks service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinks">REST API Reference for ListLinks Operation</seealso>
        ListLinksResponse ListLinks(ListLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLinks operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinks">REST API Reference for ListLinks Operation</seealso>
        IAsyncResult BeginListLinks(ListLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLinks.</param>
        /// 
        /// <returns>Returns a  ListLinksResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinks">REST API Reference for ListLinks Operation</seealso>
        ListLinksResponse EndListLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRequesterGateways


        /// <summary>
        /// Lists requester gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequesterGateways service method.</param>
        /// 
        /// <returns>The response from the ListRequesterGateways service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListRequesterGateways">REST API Reference for ListRequesterGateways Operation</seealso>
        ListRequesterGatewaysResponse ListRequesterGateways(ListRequesterGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRequesterGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRequesterGateways operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRequesterGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListRequesterGateways">REST API Reference for ListRequesterGateways Operation</seealso>
        IAsyncResult BeginListRequesterGateways(ListRequesterGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRequesterGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRequesterGateways.</param>
        /// 
        /// <returns>Returns a  ListRequesterGatewaysResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListRequesterGateways">REST API Reference for ListRequesterGateways Operation</seealso>
        ListRequesterGatewaysResponse EndListRequesterGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResponderGateways


        /// <summary>
        /// Lists reponder gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponderGateways service method.</param>
        /// 
        /// <returns>The response from the ListResponderGateways service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListResponderGateways">REST API Reference for ListResponderGateways Operation</seealso>
        ListResponderGatewaysResponse ListResponderGateways(ListResponderGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResponderGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResponderGateways operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResponderGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListResponderGateways">REST API Reference for ListResponderGateways Operation</seealso>
        IAsyncResult BeginListResponderGateways(ListResponderGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResponderGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResponderGateways.</param>
        /// 
        /// <returns>Returns a  ListResponderGatewaysResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListResponderGateways">REST API Reference for ListResponderGateways Operation</seealso>
        ListResponderGatewaysResponse EndListResponderGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectLink


        /// <summary>
        /// Rejects a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to decline the link request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectLink service method.</param>
        /// 
        /// <returns>The response from the RejectLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/RejectLink">REST API Reference for RejectLink Operation</seealso>
        RejectLinkResponse RejectLink(RejectLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/RejectLink">REST API Reference for RejectLink Operation</seealso>
        IAsyncResult BeginRejectLink(RejectLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectLink.</param>
        /// 
        /// <returns>Returns a  RejectLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/RejectLink">REST API Reference for RejectLink Operation</seealso>
        RejectLinkResponse EndRejectLink(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLink


        /// <summary>
        /// Updates the configuration of a link between gateways.
        /// 
        ///  
        /// <para>
        /// Allows you to modify settings and parameters for an existing link.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
        /// 
        /// <returns>The response from the UpdateLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        UpdateLinkResponse UpdateLink(UpdateLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        IAsyncResult BeginUpdateLink(UpdateLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLink.</param>
        /// 
        /// <returns>Returns a  UpdateLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        UpdateLinkResponse EndUpdateLink(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLinkModuleFlow


        /// <summary>
        /// Updates a link module flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkModuleFlow service method.</param>
        /// 
        /// <returns>The response from the UpdateLinkModuleFlow service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkModuleFlow">REST API Reference for UpdateLinkModuleFlow Operation</seealso>
        UpdateLinkModuleFlowResponse UpdateLinkModuleFlow(UpdateLinkModuleFlowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLinkModuleFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkModuleFlow operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLinkModuleFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkModuleFlow">REST API Reference for UpdateLinkModuleFlow Operation</seealso>
        IAsyncResult BeginUpdateLinkModuleFlow(UpdateLinkModuleFlowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLinkModuleFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLinkModuleFlow.</param>
        /// 
        /// <returns>Returns a  UpdateLinkModuleFlowResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkModuleFlow">REST API Reference for UpdateLinkModuleFlow Operation</seealso>
        UpdateLinkModuleFlowResponse EndUpdateLinkModuleFlow(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRequesterGateway


        /// <summary>
        /// Updates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateRequesterGateway">REST API Reference for UpdateRequesterGateway Operation</seealso>
        UpdateRequesterGatewayResponse UpdateRequesterGateway(UpdateRequesterGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequesterGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRequesterGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateRequesterGateway">REST API Reference for UpdateRequesterGateway Operation</seealso>
        IAsyncResult BeginUpdateRequesterGateway(UpdateRequesterGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRequesterGateway.</param>
        /// 
        /// <returns>Returns a  UpdateRequesterGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateRequesterGateway">REST API Reference for UpdateRequesterGateway Operation</seealso>
        UpdateRequesterGatewayResponse EndUpdateRequesterGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResponderGateway


        /// <summary>
        /// Updates a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponderGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateResponderGateway">REST API Reference for UpdateResponderGateway Operation</seealso>
        UpdateResponderGatewayResponse UpdateResponderGateway(UpdateResponderGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponderGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResponderGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateResponderGateway">REST API Reference for UpdateResponderGateway Operation</seealso>
        IAsyncResult BeginUpdateResponderGateway(UpdateResponderGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResponderGateway.</param>
        /// 
        /// <returns>Returns a  UpdateResponderGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateResponderGateway">REST API Reference for UpdateResponderGateway Operation</seealso>
        UpdateResponderGatewayResponse EndUpdateResponderGateway(IAsyncResult asyncResult);

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