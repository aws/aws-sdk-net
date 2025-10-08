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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Outposts.Model;

#pragma warning disable CS1570
namespace Amazon.Outposts
{
    /// <summary>
    /// <para>Interface for accessing Outposts</para>
    ///
    /// Amazon Web Services Outposts is a fully managed service that extends Amazon Web Services
    /// infrastructure, APIs, and tools to customer premises. By providing local access to
    /// Amazon Web Services managed infrastructure, Amazon Web Services Outposts enables customers
    /// to build and run applications on premises using the same programming interfaces as
    /// in Amazon Web Services Regions, while using local compute and storage resources for
    /// lower latency and local data processing needs.
    /// </summary>
    public partial interface IAmazonOutposts : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOutpostsPaginatorFactory Paginators { get; }
#endif


        
        #region  CancelCapacityTask


        /// <summary>
        /// Cancels the capacity task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCapacityTask service method.</param>
        /// 
        /// <returns>The response from the CancelCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelCapacityTask">REST API Reference for CancelCapacityTask Operation</seealso>
        CancelCapacityTaskResponse CancelCapacityTask(CancelCapacityTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelCapacityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCapacityTask operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelCapacityTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelCapacityTask">REST API Reference for CancelCapacityTask Operation</seealso>
        IAsyncResult BeginCancelCapacityTask(CancelCapacityTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelCapacityTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelCapacityTask.</param>
        /// 
        /// <returns>Returns a  CancelCapacityTaskResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelCapacityTask">REST API Reference for CancelCapacityTask Operation</seealso>
        CancelCapacityTaskResponse EndCancelCapacityTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelOrder


        /// <summary>
        /// Cancels the specified order for an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelOrder service method.</param>
        /// 
        /// <returns>The response from the CancelOrder service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelOrder">REST API Reference for CancelOrder Operation</seealso>
        CancelOrderResponse CancelOrder(CancelOrderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelOrder operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelOrder">REST API Reference for CancelOrder Operation</seealso>
        IAsyncResult BeginCancelOrder(CancelOrderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelOrder.</param>
        /// 
        /// <returns>Returns a  CancelOrderResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CancelOrder">REST API Reference for CancelOrder Operation</seealso>
        CancelOrderResponse EndCancelOrder(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOrder


        /// <summary>
        /// Creates an order for an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrder service method.</param>
        /// 
        /// <returns>The response from the CreateOrder service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOrder">REST API Reference for CreateOrder Operation</seealso>
        CreateOrderResponse CreateOrder(CreateOrderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrder operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOrder">REST API Reference for CreateOrder Operation</seealso>
        IAsyncResult BeginCreateOrder(CreateOrderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOrder.</param>
        /// 
        /// <returns>Returns a  CreateOrderResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOrder">REST API Reference for CreateOrder Operation</seealso>
        CreateOrderResponse EndCreateOrder(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOutpost


        /// <summary>
        /// Creates an Outpost.
        /// 
        ///  
        /// <para>
        /// You can specify either an Availability one or an AZ ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutpost service method.</param>
        /// 
        /// <returns>The response from the CreateOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOutpost">REST API Reference for CreateOutpost Operation</seealso>
        CreateOutpostResponse CreateOutpost(CreateOutpostRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOutpost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOutpost operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOutpost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOutpost">REST API Reference for CreateOutpost Operation</seealso>
        IAsyncResult BeginCreateOutpost(CreateOutpostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOutpost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOutpost.</param>
        /// 
        /// <returns>Returns a  CreateOutpostResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOutpost">REST API Reference for CreateOutpost Operation</seealso>
        CreateOutpostResponse EndCreateOutpost(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSite


        /// <summary>
        /// Creates a site for an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
        /// 
        /// <returns>The response from the CreateSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateSite">REST API Reference for CreateSite Operation</seealso>
        CreateSiteResponse CreateSite(CreateSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSite operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateSite">REST API Reference for CreateSite Operation</seealso>
        IAsyncResult BeginCreateSite(CreateSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSite.</param>
        /// 
        /// <returns>Returns a  CreateSiteResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateSite">REST API Reference for CreateSite Operation</seealso>
        CreateSiteResponse EndCreateSite(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOutpost


        /// <summary>
        /// Deletes the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutpost service method.</param>
        /// 
        /// <returns>The response from the DeleteOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteOutpost">REST API Reference for DeleteOutpost Operation</seealso>
        DeleteOutpostResponse DeleteOutpost(DeleteOutpostRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOutpost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutpost operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOutpost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteOutpost">REST API Reference for DeleteOutpost Operation</seealso>
        IAsyncResult BeginDeleteOutpost(DeleteOutpostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOutpost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOutpost.</param>
        /// 
        /// <returns>Returns a  DeleteOutpostResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteOutpost">REST API Reference for DeleteOutpost Operation</seealso>
        DeleteOutpostResponse EndDeleteOutpost(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSite


        /// <summary>
        /// Deletes the specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
        /// 
        /// <returns>The response from the DeleteSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        DeleteSiteResponse DeleteSite(DeleteSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        IAsyncResult BeginDeleteSite(DeleteSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSite.</param>
        /// 
        /// <returns>Returns a  DeleteSiteResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        DeleteSiteResponse EndDeleteSite(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCapacityTask


        /// <summary>
        /// Gets details of the specified capacity task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCapacityTask service method.</param>
        /// 
        /// <returns>The response from the GetCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCapacityTask">REST API Reference for GetCapacityTask Operation</seealso>
        GetCapacityTaskResponse GetCapacityTask(GetCapacityTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCapacityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCapacityTask operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCapacityTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCapacityTask">REST API Reference for GetCapacityTask Operation</seealso>
        IAsyncResult BeginGetCapacityTask(GetCapacityTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCapacityTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCapacityTask.</param>
        /// 
        /// <returns>Returns a  GetCapacityTaskResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCapacityTask">REST API Reference for GetCapacityTask Operation</seealso>
        GetCapacityTaskResponse EndGetCapacityTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCatalogItem


        /// <summary>
        /// Gets information about the specified catalog item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogItem service method.</param>
        /// 
        /// <returns>The response from the GetCatalogItem service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCatalogItem">REST API Reference for GetCatalogItem Operation</seealso>
        GetCatalogItemResponse GetCatalogItem(GetCatalogItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCatalogItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogItem operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCatalogItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCatalogItem">REST API Reference for GetCatalogItem Operation</seealso>
        IAsyncResult BeginGetCatalogItem(GetCatalogItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCatalogItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCatalogItem.</param>
        /// 
        /// <returns>Returns a  GetCatalogItemResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetCatalogItem">REST API Reference for GetCatalogItem Operation</seealso>
        GetCatalogItemResponse EndGetCatalogItem(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnection


        /// <summary>
        /// <note> 
        /// <para>
        ///  Amazon Web Services uses this action to install Outpost servers.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Gets information about the specified connection. 
        /// </para>
        ///  
        /// <para>
        ///  Use CloudTrail to monitor this action or Amazon Web Services managed policy for Amazon
        /// Web Services Outposts to secure it. For more information, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/security-iam-awsmanpol.html">
        /// Amazon Web Services managed policies for Amazon Web Services Outposts</a> and <a href="https://docs.aws.amazon.com/outposts/latest/userguide/logging-using-cloudtrail.html">
        /// Logging Amazon Web Services Outposts API calls with Amazon Web Services CloudTrail</a>
        /// in the <i>Amazon Web Services Outposts User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetConnection">REST API Reference for GetConnection Operation</seealso>
        GetConnectionResponse GetConnection(GetConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetConnection">REST API Reference for GetConnection Operation</seealso>
        IAsyncResult BeginGetConnection(GetConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnection.</param>
        /// 
        /// <returns>Returns a  GetConnectionResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetConnection">REST API Reference for GetConnection Operation</seealso>
        GetConnectionResponse EndGetConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOrder


        /// <summary>
        /// Gets information about the specified order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrder service method.</param>
        /// 
        /// <returns>The response from the GetOrder service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        GetOrderResponse GetOrder(GetOrderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrder operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        IAsyncResult BeginGetOrder(GetOrderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOrder.</param>
        /// 
        /// <returns>Returns a  GetOrderResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        GetOrderResponse EndGetOrder(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOutpost


        /// <summary>
        /// Gets information about the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpost service method.</param>
        /// 
        /// <returns>The response from the GetOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpost">REST API Reference for GetOutpost Operation</seealso>
        GetOutpostResponse GetOutpost(GetOutpostRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutpost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutpost operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutpost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpost">REST API Reference for GetOutpost Operation</seealso>
        IAsyncResult BeginGetOutpost(GetOutpostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutpost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutpost.</param>
        /// 
        /// <returns>Returns a  GetOutpostResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpost">REST API Reference for GetOutpost Operation</seealso>
        GetOutpostResponse EndGetOutpost(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOutpostBillingInformation


        /// <summary>
        /// Gets current and historical billing information about the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostBillingInformation service method.</param>
        /// 
        /// <returns>The response from the GetOutpostBillingInformation service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostBillingInformation">REST API Reference for GetOutpostBillingInformation Operation</seealso>
        GetOutpostBillingInformationResponse GetOutpostBillingInformation(GetOutpostBillingInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutpostBillingInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostBillingInformation operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutpostBillingInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostBillingInformation">REST API Reference for GetOutpostBillingInformation Operation</seealso>
        IAsyncResult BeginGetOutpostBillingInformation(GetOutpostBillingInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutpostBillingInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutpostBillingInformation.</param>
        /// 
        /// <returns>Returns a  GetOutpostBillingInformationResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostBillingInformation">REST API Reference for GetOutpostBillingInformation Operation</seealso>
        GetOutpostBillingInformationResponse EndGetOutpostBillingInformation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOutpostInstanceTypes


        /// <summary>
        /// Gets the instance types for the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the GetOutpostInstanceTypes service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostInstanceTypes">REST API Reference for GetOutpostInstanceTypes Operation</seealso>
        GetOutpostInstanceTypesResponse GetOutpostInstanceTypes(GetOutpostInstanceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutpostInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostInstanceTypes operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutpostInstanceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostInstanceTypes">REST API Reference for GetOutpostInstanceTypes Operation</seealso>
        IAsyncResult BeginGetOutpostInstanceTypes(GetOutpostInstanceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutpostInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutpostInstanceTypes.</param>
        /// 
        /// <returns>Returns a  GetOutpostInstanceTypesResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostInstanceTypes">REST API Reference for GetOutpostInstanceTypes Operation</seealso>
        GetOutpostInstanceTypesResponse EndGetOutpostInstanceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOutpostSupportedInstanceTypes


        /// <summary>
        /// Gets the instance types that an Outpost can support in <c>InstanceTypeCapacity</c>.
        /// This will generally include instance types that are not currently configured and therefore
        /// cannot be launched with the current Outpost capacity configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostSupportedInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the GetOutpostSupportedInstanceTypes service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostSupportedInstanceTypes">REST API Reference for GetOutpostSupportedInstanceTypes Operation</seealso>
        GetOutpostSupportedInstanceTypesResponse GetOutpostSupportedInstanceTypes(GetOutpostSupportedInstanceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutpostSupportedInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostSupportedInstanceTypes operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutpostSupportedInstanceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostSupportedInstanceTypes">REST API Reference for GetOutpostSupportedInstanceTypes Operation</seealso>
        IAsyncResult BeginGetOutpostSupportedInstanceTypes(GetOutpostSupportedInstanceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutpostSupportedInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutpostSupportedInstanceTypes.</param>
        /// 
        /// <returns>Returns a  GetOutpostSupportedInstanceTypesResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostSupportedInstanceTypes">REST API Reference for GetOutpostSupportedInstanceTypes Operation</seealso>
        GetOutpostSupportedInstanceTypesResponse EndGetOutpostSupportedInstanceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSite


        /// <summary>
        /// Gets information about the specified Outpost site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSite service method.</param>
        /// 
        /// <returns>The response from the GetSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSite">REST API Reference for GetSite Operation</seealso>
        GetSiteResponse GetSite(GetSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSite operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSite">REST API Reference for GetSite Operation</seealso>
        IAsyncResult BeginGetSite(GetSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSite.</param>
        /// 
        /// <returns>Returns a  GetSiteResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSite">REST API Reference for GetSite Operation</seealso>
        GetSiteResponse EndGetSite(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSiteAddress


        /// <summary>
        /// Gets the site address of the specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSiteAddress service method.</param>
        /// 
        /// <returns>The response from the GetSiteAddress service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSiteAddress">REST API Reference for GetSiteAddress Operation</seealso>
        GetSiteAddressResponse GetSiteAddress(GetSiteAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSiteAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSiteAddress operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSiteAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSiteAddress">REST API Reference for GetSiteAddress Operation</seealso>
        IAsyncResult BeginGetSiteAddress(GetSiteAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSiteAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSiteAddress.</param>
        /// 
        /// <returns>Returns a  GetSiteAddressResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetSiteAddress">REST API Reference for GetSiteAddress Operation</seealso>
        GetSiteAddressResponse EndGetSiteAddress(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssetInstances


        /// <summary>
        /// A list of Amazon EC2 instances, belonging to all accounts, running on the specified
        /// Outpost. Does not include Amazon EBS or Amazon S3 instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetInstances service method.</param>
        /// 
        /// <returns>The response from the ListAssetInstances service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssetInstances">REST API Reference for ListAssetInstances Operation</seealso>
        ListAssetInstancesResponse ListAssetInstances(ListAssetInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetInstances operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssetInstances">REST API Reference for ListAssetInstances Operation</seealso>
        IAsyncResult BeginListAssetInstances(ListAssetInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetInstances.</param>
        /// 
        /// <returns>Returns a  ListAssetInstancesResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssetInstances">REST API Reference for ListAssetInstances Operation</seealso>
        ListAssetInstancesResponse EndListAssetInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssets


        /// <summary>
        /// Lists the hardware assets for the specified Outpost.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssets service method.</param>
        /// 
        /// <returns>The response from the ListAssets service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssets">REST API Reference for ListAssets Operation</seealso>
        ListAssetsResponse ListAssets(ListAssetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssets operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssets">REST API Reference for ListAssets Operation</seealso>
        IAsyncResult BeginListAssets(ListAssetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssets.</param>
        /// 
        /// <returns>Returns a  ListAssetsResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListAssets">REST API Reference for ListAssets Operation</seealso>
        ListAssetsResponse EndListAssets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBlockingInstancesForCapacityTask


        /// <summary>
        /// A list of Amazon EC2 instances running on the Outpost and belonging to the account
        /// that initiated the capacity task. Use this list to specify the instances you cannot
        /// stop to free up capacity to run the capacity task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlockingInstancesForCapacityTask service method.</param>
        /// 
        /// <returns>The response from the ListBlockingInstancesForCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListBlockingInstancesForCapacityTask">REST API Reference for ListBlockingInstancesForCapacityTask Operation</seealso>
        ListBlockingInstancesForCapacityTaskResponse ListBlockingInstancesForCapacityTask(ListBlockingInstancesForCapacityTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBlockingInstancesForCapacityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBlockingInstancesForCapacityTask operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBlockingInstancesForCapacityTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListBlockingInstancesForCapacityTask">REST API Reference for ListBlockingInstancesForCapacityTask Operation</seealso>
        IAsyncResult BeginListBlockingInstancesForCapacityTask(ListBlockingInstancesForCapacityTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBlockingInstancesForCapacityTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBlockingInstancesForCapacityTask.</param>
        /// 
        /// <returns>Returns a  ListBlockingInstancesForCapacityTaskResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListBlockingInstancesForCapacityTask">REST API Reference for ListBlockingInstancesForCapacityTask Operation</seealso>
        ListBlockingInstancesForCapacityTaskResponse EndListBlockingInstancesForCapacityTask(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCapacityTasks


        /// <summary>
        /// Lists the capacity tasks for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCapacityTasks service method.</param>
        /// 
        /// <returns>The response from the ListCapacityTasks service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCapacityTasks">REST API Reference for ListCapacityTasks Operation</seealso>
        ListCapacityTasksResponse ListCapacityTasks(ListCapacityTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCapacityTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCapacityTasks operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCapacityTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCapacityTasks">REST API Reference for ListCapacityTasks Operation</seealso>
        IAsyncResult BeginListCapacityTasks(ListCapacityTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCapacityTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCapacityTasks.</param>
        /// 
        /// <returns>Returns a  ListCapacityTasksResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCapacityTasks">REST API Reference for ListCapacityTasks Operation</seealso>
        ListCapacityTasksResponse EndListCapacityTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCatalogItems


        /// <summary>
        /// Lists the items in the catalog.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCatalogItems service method.</param>
        /// 
        /// <returns>The response from the ListCatalogItems service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCatalogItems">REST API Reference for ListCatalogItems Operation</seealso>
        ListCatalogItemsResponse ListCatalogItems(ListCatalogItemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCatalogItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCatalogItems operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCatalogItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCatalogItems">REST API Reference for ListCatalogItems Operation</seealso>
        IAsyncResult BeginListCatalogItems(ListCatalogItemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCatalogItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCatalogItems.</param>
        /// 
        /// <returns>Returns a  ListCatalogItemsResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListCatalogItems">REST API Reference for ListCatalogItems Operation</seealso>
        ListCatalogItemsResponse EndListCatalogItems(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrders


        /// <summary>
        /// Lists the Outpost orders for your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrders service method.</param>
        /// 
        /// <returns>The response from the ListOrders service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        ListOrdersResponse ListOrders(ListOrdersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrders operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        IAsyncResult BeginListOrders(ListOrdersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrders.</param>
        /// 
        /// <returns>Returns a  ListOrdersResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        ListOrdersResponse EndListOrders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOutposts


        /// <summary>
        /// Lists the Outposts for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutposts service method.</param>
        /// 
        /// <returns>The response from the ListOutposts service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOutposts">REST API Reference for ListOutposts Operation</seealso>
        ListOutpostsResponse ListOutposts(ListOutpostsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOutposts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOutposts operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOutposts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOutposts">REST API Reference for ListOutposts Operation</seealso>
        IAsyncResult BeginListOutposts(ListOutpostsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOutposts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOutposts.</param>
        /// 
        /// <returns>Returns a  ListOutpostsResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOutposts">REST API Reference for ListOutposts Operation</seealso>
        ListOutpostsResponse EndListOutposts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSites


        /// <summary>
        /// Lists the Outpost sites for your Amazon Web Services account. Use filters to return
        /// specific results.
        /// 
        ///  
        /// <para>
        /// Use filters to return specific results. If you specify multiple filters, the results
        /// include only the resources that match all of the specified filters. For a filter where
        /// you can specify multiple values, the results include items that match any of the values
        /// that you specify for the filter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSites service method.</param>
        /// 
        /// <returns>The response from the ListSites service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListSites">REST API Reference for ListSites Operation</seealso>
        ListSitesResponse ListSites(ListSitesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSites operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListSites">REST API Reference for ListSites Operation</seealso>
        IAsyncResult BeginListSites(ListSitesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSites.</param>
        /// 
        /// <returns>Returns a  ListSitesResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListSites">REST API Reference for ListSites Operation</seealso>
        ListSitesResponse EndListSites(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartCapacityTask


        /// <summary>
        /// Starts the specified capacity task. You can have one active capacity task for each
        /// order and each Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCapacityTask service method.</param>
        /// 
        /// <returns>The response from the StartCapacityTask service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartCapacityTask">REST API Reference for StartCapacityTask Operation</seealso>
        StartCapacityTaskResponse StartCapacityTask(StartCapacityTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartCapacityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCapacityTask operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCapacityTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartCapacityTask">REST API Reference for StartCapacityTask Operation</seealso>
        IAsyncResult BeginStartCapacityTask(StartCapacityTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartCapacityTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCapacityTask.</param>
        /// 
        /// <returns>Returns a  StartCapacityTaskResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartCapacityTask">REST API Reference for StartCapacityTask Operation</seealso>
        StartCapacityTaskResponse EndStartCapacityTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StartConnection


        /// <summary>
        /// <note> 
        /// <para>
        ///  Amazon Web Services uses this action to install Outpost servers.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Starts the connection required for Outpost server installation. 
        /// </para>
        ///  
        /// <para>
        ///  Use CloudTrail to monitor this action or Amazon Web Services managed policy for Amazon
        /// Web Services Outposts to secure it. For more information, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/security-iam-awsmanpol.html">
        /// Amazon Web Services managed policies for Amazon Web Services Outposts</a> and <a href="https://docs.aws.amazon.com/outposts/latest/userguide/logging-using-cloudtrail.html">
        /// Logging Amazon Web Services Outposts API calls with Amazon Web Services CloudTrail</a>
        /// in the <i>Amazon Web Services Outposts User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConnection service method.</param>
        /// 
        /// <returns>The response from the StartConnection service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartConnection">REST API Reference for StartConnection Operation</seealso>
        StartConnectionResponse StartConnection(StartConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConnection operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartConnection">REST API Reference for StartConnection Operation</seealso>
        IAsyncResult BeginStartConnection(StartConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartConnection.</param>
        /// 
        /// <returns>Returns a  StartConnectionResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartConnection">REST API Reference for StartConnection Operation</seealso>
        StartConnectionResponse EndStartConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  StartOutpostDecommission


        /// <summary>
        /// Starts the decommission process to return the Outposts racks or servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOutpostDecommission service method.</param>
        /// 
        /// <returns>The response from the StartOutpostDecommission service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartOutpostDecommission">REST API Reference for StartOutpostDecommission Operation</seealso>
        StartOutpostDecommissionResponse StartOutpostDecommission(StartOutpostDecommissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartOutpostDecommission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOutpostDecommission operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartOutpostDecommission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartOutpostDecommission">REST API Reference for StartOutpostDecommission Operation</seealso>
        IAsyncResult BeginStartOutpostDecommission(StartOutpostDecommissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartOutpostDecommission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartOutpostDecommission.</param>
        /// 
        /// <returns>Returns a  StartOutpostDecommissionResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/StartOutpostDecommission">REST API Reference for StartOutpostDecommission Operation</seealso>
        StartOutpostDecommissionResponse EndStartOutpostDecommission(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOutpost


        /// <summary>
        /// Updates an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOutpost service method.</param>
        /// 
        /// <returns>The response from the UpdateOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateOutpost">REST API Reference for UpdateOutpost Operation</seealso>
        UpdateOutpostResponse UpdateOutpost(UpdateOutpostRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOutpost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOutpost operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOutpost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateOutpost">REST API Reference for UpdateOutpost Operation</seealso>
        IAsyncResult BeginUpdateOutpost(UpdateOutpostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOutpost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOutpost.</param>
        /// 
        /// <returns>Returns a  UpdateOutpostResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateOutpost">REST API Reference for UpdateOutpost Operation</seealso>
        UpdateOutpostResponse EndUpdateOutpost(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSite


        /// <summary>
        /// Updates the specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
        /// 
        /// <returns>The response from the UpdateSite service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        UpdateSiteResponse UpdateSite(UpdateSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        IAsyncResult BeginUpdateSite(UpdateSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSite.</param>
        /// 
        /// <returns>Returns a  UpdateSiteResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        UpdateSiteResponse EndUpdateSite(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSiteAddress


        /// <summary>
        /// Updates the address of the specified site.
        /// 
        ///  
        /// <para>
        /// You can't update a site address if there is an order in progress. You must wait for
        /// the order to complete or cancel the order.
        /// </para>
        ///  
        /// <para>
        /// You can update the operating address before you place an order at the site, or after
        /// all Outposts that belong to the site have been deactivated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSiteAddress service method.</param>
        /// 
        /// <returns>The response from the UpdateSiteAddress service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteAddress">REST API Reference for UpdateSiteAddress Operation</seealso>
        UpdateSiteAddressResponse UpdateSiteAddress(UpdateSiteAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSiteAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSiteAddress operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSiteAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteAddress">REST API Reference for UpdateSiteAddress Operation</seealso>
        IAsyncResult BeginUpdateSiteAddress(UpdateSiteAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSiteAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSiteAddress.</param>
        /// 
        /// <returns>Returns a  UpdateSiteAddressResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteAddress">REST API Reference for UpdateSiteAddress Operation</seealso>
        UpdateSiteAddressResponse EndUpdateSiteAddress(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSiteRackPhysicalProperties


        /// <summary>
        /// Update the physical and logistical details for a rack at a site. For more information
        /// about hardware requirements for racks, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-requirements.html#checklist">Network
        /// readiness checklist</a> in the Amazon Web Services Outposts User Guide. 
        /// 
        ///  
        /// <para>
        /// To update a rack at a site with an order of <c>IN_PROGRESS</c>, you must wait for
        /// the order to complete or cancel the order.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSiteRackPhysicalProperties service method.</param>
        /// 
        /// <returns>The response from the UpdateSiteRackPhysicalProperties service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteRackPhysicalProperties">REST API Reference for UpdateSiteRackPhysicalProperties Operation</seealso>
        UpdateSiteRackPhysicalPropertiesResponse UpdateSiteRackPhysicalProperties(UpdateSiteRackPhysicalPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSiteRackPhysicalProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSiteRackPhysicalProperties operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSiteRackPhysicalProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteRackPhysicalProperties">REST API Reference for UpdateSiteRackPhysicalProperties Operation</seealso>
        IAsyncResult BeginUpdateSiteRackPhysicalProperties(UpdateSiteRackPhysicalPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSiteRackPhysicalProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSiteRackPhysicalProperties.</param>
        /// 
        /// <returns>Returns a  UpdateSiteRackPhysicalPropertiesResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/UpdateSiteRackPhysicalProperties">REST API Reference for UpdateSiteRackPhysicalProperties Operation</seealso>
        UpdateSiteRackPhysicalPropertiesResponse EndUpdateSiteRackPhysicalProperties(IAsyncResult asyncResult);

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