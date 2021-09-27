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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppIntegrationsService.Model;

namespace Amazon.AppIntegrationsService
{
    /// <summary>
    /// Interface for accessing AppIntegrationsService
    ///
    /// The Amazon AppIntegrations service enables you to configure and reuse connections
    /// to external applications.
    /// 
    ///  
    /// <para>
    /// For information about how you can use external applications with Amazon Connect, see
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/crm.html">Set up pre-built
    /// integrations</a> and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-wisdom.html">Deliver
    /// information to agents using Amazon Connect Wisdom</a> in the <i>Amazon Connect Administrator
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAppIntegrationsService : IAmazonService, IDisposable
    {




        
        #region  CreateDataIntegration


        /// <summary>
        /// Creates and persists a DataIntegration resource.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <code>CreateDataIntegration</code> API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateDataIntegration">REST API Reference for CreateDataIntegration Operation</seealso>
        CreateDataIntegrationResponse CreateDataIntegration(CreateDataIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateDataIntegration">REST API Reference for CreateDataIntegration Operation</seealso>
        IAsyncResult BeginCreateDataIntegration(CreateDataIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataIntegration.</param>
        /// 
        /// <returns>Returns a  CreateDataIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateDataIntegration">REST API Reference for CreateDataIntegration Operation</seealso>
        CreateDataIntegrationResponse EndCreateDataIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEventIntegration


        /// <summary>
        /// Creates an EventIntegration, given a specified name, description, and a reference
        /// to an Amazon EventBridge bus in your account and a partner event source that pushes
        /// events to that bus. No objects are created in the your account, only metadata that
        /// is persisted on the EventIntegration control plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        CreateEventIntegrationResponse CreateEventIntegration(CreateEventIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        IAsyncResult BeginCreateEventIntegration(CreateEventIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventIntegration.</param>
        /// 
        /// <returns>Returns a  CreateEventIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        CreateEventIntegrationResponse EndCreateEventIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataIntegration


        /// <summary>
        /// Deletes the DataIntegration. Only DataIntegrations that don't have any DataIntegrationAssociations
        /// can be deleted. Deleting a DataIntegration also deletes the underlying Amazon AppFlow
        /// flow and service linked role. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteDataIntegration">REST API Reference for DeleteDataIntegration Operation</seealso>
        DeleteDataIntegrationResponse DeleteDataIntegration(DeleteDataIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteDataIntegration">REST API Reference for DeleteDataIntegration Operation</seealso>
        IAsyncResult BeginDeleteDataIntegration(DeleteDataIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteDataIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteDataIntegration">REST API Reference for DeleteDataIntegration Operation</seealso>
        DeleteDataIntegrationResponse EndDeleteDataIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventIntegration


        /// <summary>
        /// Deletes the specified existing event integration. If the event integration is associated
        /// with clients, the request is rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        DeleteEventIntegrationResponse DeleteEventIntegration(DeleteEventIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        IAsyncResult BeginDeleteEventIntegration(DeleteEventIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteEventIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        DeleteEventIntegrationResponse EndDeleteEventIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataIntegration


        /// <summary>
        /// Returns information about the DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegration service method.</param>
        /// 
        /// <returns>The response from the GetDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetDataIntegration">REST API Reference for GetDataIntegration Operation</seealso>
        GetDataIntegrationResponse GetDataIntegration(GetDataIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetDataIntegration">REST API Reference for GetDataIntegration Operation</seealso>
        IAsyncResult BeginGetDataIntegration(GetDataIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataIntegration.</param>
        /// 
        /// <returns>Returns a  GetDataIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetDataIntegration">REST API Reference for GetDataIntegration Operation</seealso>
        GetDataIntegrationResponse EndGetDataIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventIntegration


        /// <summary>
        /// Returns information about the event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventIntegration service method.</param>
        /// 
        /// <returns>The response from the GetEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        GetEventIntegrationResponse GetEventIntegration(GetEventIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        IAsyncResult BeginGetEventIntegration(GetEventIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventIntegration.</param>
        /// 
        /// <returns>Returns a  GetEventIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        GetEventIntegrationResponse EndGetEventIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataIntegrationAssociations


        /// <summary>
        /// Returns a paginated list of DataIntegration associations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrationAssociations">REST API Reference for ListDataIntegrationAssociations Operation</seealso>
        ListDataIntegrationAssociationsResponse ListDataIntegrationAssociations(ListDataIntegrationAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIntegrationAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationAssociations operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIntegrationAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrationAssociations">REST API Reference for ListDataIntegrationAssociations Operation</seealso>
        IAsyncResult BeginListDataIntegrationAssociations(ListDataIntegrationAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIntegrationAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIntegrationAssociations.</param>
        /// 
        /// <returns>Returns a  ListDataIntegrationAssociationsResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrationAssociations">REST API Reference for ListDataIntegrationAssociations Operation</seealso>
        ListDataIntegrationAssociationsResponse EndListDataIntegrationAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataIntegrations


        /// <summary>
        /// Returns a paginated list of DataIntegrations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrations">REST API Reference for ListDataIntegrations Operation</seealso>
        ListDataIntegrationsResponse ListDataIntegrations(ListDataIntegrationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrations operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrations">REST API Reference for ListDataIntegrations Operation</seealso>
        IAsyncResult BeginListDataIntegrations(ListDataIntegrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIntegrations.</param>
        /// 
        /// <returns>Returns a  ListDataIntegrationsResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrations">REST API Reference for ListDataIntegrations Operation</seealso>
        ListDataIntegrationsResponse EndListDataIntegrations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventIntegrationAssociations


        /// <summary>
        /// Returns a paginated list of event integration associations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListEventIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        ListEventIntegrationAssociationsResponse ListEventIntegrationAssociations(ListEventIntegrationAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventIntegrationAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrationAssociations operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventIntegrationAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        IAsyncResult BeginListEventIntegrationAssociations(ListEventIntegrationAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventIntegrationAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventIntegrationAssociations.</param>
        /// 
        /// <returns>Returns a  ListEventIntegrationAssociationsResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        ListEventIntegrationAssociationsResponse EndListEventIntegrationAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventIntegrations


        /// <summary>
        /// Returns a paginated list of event integrations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListEventIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        ListEventIntegrationsResponse ListEventIntegrations(ListEventIntegrationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrations operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        IAsyncResult BeginListEventIntegrations(ListEventIntegrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventIntegrations.</param>
        /// 
        /// <returns>Returns a  ListEventIntegrationsResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        ListEventIntegrationsResponse EndListEventIntegrations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataIntegration


        /// <summary>
        /// Updates the description of a DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateDataIntegration">REST API Reference for UpdateDataIntegration Operation</seealso>
        UpdateDataIntegrationResponse UpdateDataIntegration(UpdateDataIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateDataIntegration">REST API Reference for UpdateDataIntegration Operation</seealso>
        IAsyncResult BeginUpdateDataIntegration(UpdateDataIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateDataIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateDataIntegration">REST API Reference for UpdateDataIntegration Operation</seealso>
        UpdateDataIntegrationResponse EndUpdateDataIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEventIntegration


        /// <summary>
        /// Updates the description of an event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        UpdateEventIntegrationResponse UpdateEventIntegration(UpdateEventIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventIntegration operation on AmazonAppIntegrationsServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        IAsyncResult BeginUpdateEventIntegration(UpdateEventIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateEventIntegrationResult from AppIntegrationsService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        UpdateEventIntegrationResponse EndUpdateEventIntegration(IAsyncResult asyncResult);

        #endregion
        
    }
}