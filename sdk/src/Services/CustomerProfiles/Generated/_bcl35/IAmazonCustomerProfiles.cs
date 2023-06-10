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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CustomerProfiles.Model;

namespace Amazon.CustomerProfiles
{
    /// <summary>
    /// Interface for accessing CustomerProfiles
    ///
    /// Amazon Connect Customer Profiles 
    /// <para>
    /// Amazon Connect Customer Profiles is a unified customer profile for your contact center
    /// that has pre-built connectors powered by AppFlow that make it easy to combine customer
    /// information from third party applications, such as Salesforce (CRM), ServiceNow (ITSM),
    /// and your enterprise resource planning (ERP), with contact history from your Amazon
    /// Connect contact center. If you're new to Amazon Connect, you might find it helpful
    /// to review the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/">Amazon
    /// Connect Administrator Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCustomerProfiles : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICustomerProfilesPaginatorFactory Paginators { get; }
#endif


        
        #region  AddProfileKey


        /// <summary>
        /// Associates a new key value with a specific profile, such as a Contact Record ContactId.
        /// 
        ///  
        /// <para>
        /// A profile object can have a single unique key and any number of additional keys that
        /// can be used to identify the profile that it belongs to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddProfileKey service method.</param>
        /// 
        /// <returns>The response from the AddProfileKey service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/AddProfileKey">REST API Reference for AddProfileKey Operation</seealso>
        AddProfileKeyResponse AddProfileKey(AddProfileKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddProfileKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddProfileKey operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddProfileKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/AddProfileKey">REST API Reference for AddProfileKey Operation</seealso>
        IAsyncResult BeginAddProfileKey(AddProfileKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddProfileKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddProfileKey.</param>
        /// 
        /// <returns>Returns a  AddProfileKeyResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/AddProfileKey">REST API Reference for AddProfileKey Operation</seealso>
        AddProfileKeyResponse EndAddProfileKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCalculatedAttributeDefinition


        /// <summary>
        /// Creates a new calculated attribute definition. After creation, new object data ingested
        /// into Customer Profiles will be included in the calculated attribute, which can be
        /// retrieved for a profile using the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetCalculatedAttributeForProfile.html">GetCalculatedAttributeForProfile</a>
        /// API. Defining a calculated attribute makes it available for all profiles within a
        /// domain. Each calculated attribute can only reference one <code>ObjectType</code> and
        /// at most, two fields from that <code>ObjectType</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCalculatedAttributeDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateCalculatedAttributeDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateCalculatedAttributeDefinition">REST API Reference for CreateCalculatedAttributeDefinition Operation</seealso>
        CreateCalculatedAttributeDefinitionResponse CreateCalculatedAttributeDefinition(CreateCalculatedAttributeDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCalculatedAttributeDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCalculatedAttributeDefinition operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCalculatedAttributeDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateCalculatedAttributeDefinition">REST API Reference for CreateCalculatedAttributeDefinition Operation</seealso>
        IAsyncResult BeginCreateCalculatedAttributeDefinition(CreateCalculatedAttributeDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCalculatedAttributeDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCalculatedAttributeDefinition.</param>
        /// 
        /// <returns>Returns a  CreateCalculatedAttributeDefinitionResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateCalculatedAttributeDefinition">REST API Reference for CreateCalculatedAttributeDefinition Operation</seealso>
        CreateCalculatedAttributeDefinitionResponse EndCreateCalculatedAttributeDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a domain, which is a container for all customer data, such as customer profile
        /// attributes, object types, profile keys, and encryption keys. You can create multiple
        /// domains, and each domain can have multiple third-party integrations.
        /// 
        ///  
        /// <para>
        /// Each Amazon Connect instance can be associated with only one domain. Multiple Amazon
        /// Connect instances can be associated with one domain.
        /// </para>
        ///  
        /// <para>
        /// Use this API or <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UpdateDomain.html">UpdateDomain</a>
        /// to enable <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">identity
        /// resolution</a>: set <code>Matching</code> to true. 
        /// </para>
        ///  
        /// <para>
        /// To prevent cross-service impersonation when you call this API, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cross-service-confused-deputy-prevention.html">Cross-service
        /// confused deputy prevention</a> for sample policies that you should apply. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEventStream


        /// <summary>
        /// Creates an event stream, which is a subscription to real-time events, such as when
        /// profiles are created and updated through Amazon Connect Customer Profiles.
        /// 
        ///  
        /// <para>
        /// Each event stream can be associated with only one Kinesis Data Stream destination
        /// in the same region and Amazon Web Services account as the customer profiles domain
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventStream service method.</param>
        /// 
        /// <returns>The response from the CreateEventStream service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateEventStream">REST API Reference for CreateEventStream Operation</seealso>
        CreateEventStreamResponse CreateEventStream(CreateEventStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventStream operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateEventStream">REST API Reference for CreateEventStream Operation</seealso>
        IAsyncResult BeginCreateEventStream(CreateEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventStream.</param>
        /// 
        /// <returns>Returns a  CreateEventStreamResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateEventStream">REST API Reference for CreateEventStream Operation</seealso>
        CreateEventStreamResponse EndCreateEventStream(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIntegrationWorkflow


        /// <summary>
        /// Creates an integration workflow. An integration workflow is an async process which
        /// ingests historic data and sets up an integration for ongoing updates. The supported
        /// Amazon AppFlow sources are Salesforce, ServiceNow, and Marketo.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateIntegrationWorkflow service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateIntegrationWorkflow">REST API Reference for CreateIntegrationWorkflow Operation</seealso>
        CreateIntegrationWorkflowResponse CreateIntegrationWorkflow(CreateIntegrationWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntegrationWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationWorkflow operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIntegrationWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateIntegrationWorkflow">REST API Reference for CreateIntegrationWorkflow Operation</seealso>
        IAsyncResult BeginCreateIntegrationWorkflow(CreateIntegrationWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIntegrationWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIntegrationWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateIntegrationWorkflowResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateIntegrationWorkflow">REST API Reference for CreateIntegrationWorkflow Operation</seealso>
        CreateIntegrationWorkflowResponse EndCreateIntegrationWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProfile


        /// <summary>
        /// Creates a standard profile.
        /// 
        ///  
        /// <para>
        /// A standard profile represents the following attributes for a customer profile in a
        /// domain.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        CreateProfileResponse CreateProfile(CreateProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        IAsyncResult BeginCreateProfile(CreateProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfile.</param>
        /// 
        /// <returns>Returns a  CreateProfileResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        CreateProfileResponse EndCreateProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCalculatedAttributeDefinition


        /// <summary>
        /// Deletes an existing calculated attribute definition. Note that deleting a default
        /// calculated attribute is possible, however once deleted, you will be unable to undo
        /// that action and will need to recreate it on your own using the CreateCalculatedAttributeDefinition
        /// API if you want it back.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCalculatedAttributeDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteCalculatedAttributeDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteCalculatedAttributeDefinition">REST API Reference for DeleteCalculatedAttributeDefinition Operation</seealso>
        DeleteCalculatedAttributeDefinitionResponse DeleteCalculatedAttributeDefinition(DeleteCalculatedAttributeDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCalculatedAttributeDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCalculatedAttributeDefinition operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCalculatedAttributeDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteCalculatedAttributeDefinition">REST API Reference for DeleteCalculatedAttributeDefinition Operation</seealso>
        IAsyncResult BeginDeleteCalculatedAttributeDefinition(DeleteCalculatedAttributeDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCalculatedAttributeDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCalculatedAttributeDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteCalculatedAttributeDefinitionResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteCalculatedAttributeDefinition">REST API Reference for DeleteCalculatedAttributeDefinition Operation</seealso>
        DeleteCalculatedAttributeDefinitionResponse EndDeleteCalculatedAttributeDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Deletes a specific domain and all of its customer data, such as customer profile attributes
        /// and their related objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventStream


        /// <summary>
        /// Disables and deletes the specified event stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
        /// 
        /// <returns>The response from the DeleteEventStream service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
        DeleteEventStreamResponse DeleteEventStream(DeleteEventStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
        IAsyncResult BeginDeleteEventStream(DeleteEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventStream.</param>
        /// 
        /// <returns>Returns a  DeleteEventStreamResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
        DeleteEventStreamResponse EndDeleteEventStream(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Removes an integration from a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        IAsyncResult BeginDeleteIntegration(DeleteIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        DeleteIntegrationResponse EndDeleteIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProfile


        /// <summary>
        /// Deletes the standard customer profile and all data pertaining to the profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        DeleteProfileResponse DeleteProfile(DeleteProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        IAsyncResult BeginDeleteProfile(DeleteProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProfileResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        DeleteProfileResponse EndDeleteProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProfileKey


        /// <summary>
        /// Removes a searchable key from a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileKey service method.</param>
        /// 
        /// <returns>The response from the DeleteProfileKey service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileKey">REST API Reference for DeleteProfileKey Operation</seealso>
        DeleteProfileKeyResponse DeleteProfileKey(DeleteProfileKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfileKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileKey operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfileKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileKey">REST API Reference for DeleteProfileKey Operation</seealso>
        IAsyncResult BeginDeleteProfileKey(DeleteProfileKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfileKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfileKey.</param>
        /// 
        /// <returns>Returns a  DeleteProfileKeyResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileKey">REST API Reference for DeleteProfileKey Operation</seealso>
        DeleteProfileKeyResponse EndDeleteProfileKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProfileObject


        /// <summary>
        /// Removes an object associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObject service method.</param>
        /// 
        /// <returns>The response from the DeleteProfileObject service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileObject">REST API Reference for DeleteProfileObject Operation</seealso>
        DeleteProfileObjectResponse DeleteProfileObject(DeleteProfileObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfileObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObject operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfileObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileObject">REST API Reference for DeleteProfileObject Operation</seealso>
        IAsyncResult BeginDeleteProfileObject(DeleteProfileObjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfileObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfileObject.</param>
        /// 
        /// <returns>Returns a  DeleteProfileObjectResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileObject">REST API Reference for DeleteProfileObject Operation</seealso>
        DeleteProfileObjectResponse EndDeleteProfileObject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProfileObjectType


        /// <summary>
        /// Removes a ProfileObjectType from a specific domain as well as removes all the ProfileObjects
        /// of that type. It also disables integrations from this specific ProfileObjectType.
        /// In addition, it scrubs all of the fields of the standard profile that were populated
        /// from this ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObjectType service method.</param>
        /// 
        /// <returns>The response from the DeleteProfileObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileObjectType">REST API Reference for DeleteProfileObjectType Operation</seealso>
        DeleteProfileObjectTypeResponse DeleteProfileObjectType(DeleteProfileObjectTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfileObjectType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObjectType operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfileObjectType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileObjectType">REST API Reference for DeleteProfileObjectType Operation</seealso>
        IAsyncResult BeginDeleteProfileObjectType(DeleteProfileObjectTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfileObjectType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfileObjectType.</param>
        /// 
        /// <returns>Returns a  DeleteProfileObjectTypeResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteProfileObjectType">REST API Reference for DeleteProfileObjectType Operation</seealso>
        DeleteProfileObjectTypeResponse EndDeleteProfileObjectType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkflow


        /// <summary>
        /// Deletes the specified workflow and all its corresponding resources. This is an async
        /// process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        IAsyncResult BeginDeleteWorkflow(DeleteWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        DeleteWorkflowResponse EndDeleteWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAutoMergingPreview


        /// <summary>
        /// Tests the auto-merging settings of your Identity Resolution Job without merging your
        /// data. It randomly selects a sample of matching groups from the existing matching results,
        /// and applies the automerging settings that you provided. You can then view the number
        /// of profiles in the sample, the number of matches, and the number of profiles identified
        /// to be merged. This enables you to evaluate the accuracy of the attributes in your
        /// matching list. 
        /// 
        ///  
        /// <para>
        /// You can't view which profiles are matched and would be merged.
        /// </para>
        ///  <important> 
        /// <para>
        /// We strongly recommend you use this API to do a dry run of the automerging process
        /// before running the Identity Resolution Job. Include <b>at least</b> two matching attributes.
        /// If your matching list includes too few attributes (such as only <code>FirstName</code>
        /// or only <code>LastName</code>), there may be a large number of matches. This increases
        /// the chances of erroneous merges.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoMergingPreview service method.</param>
        /// 
        /// <returns>The response from the GetAutoMergingPreview service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetAutoMergingPreview">REST API Reference for GetAutoMergingPreview Operation</seealso>
        GetAutoMergingPreviewResponse GetAutoMergingPreview(GetAutoMergingPreviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutoMergingPreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutoMergingPreview operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutoMergingPreview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetAutoMergingPreview">REST API Reference for GetAutoMergingPreview Operation</seealso>
        IAsyncResult BeginGetAutoMergingPreview(GetAutoMergingPreviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutoMergingPreview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutoMergingPreview.</param>
        /// 
        /// <returns>Returns a  GetAutoMergingPreviewResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetAutoMergingPreview">REST API Reference for GetAutoMergingPreview Operation</seealso>
        GetAutoMergingPreviewResponse EndGetAutoMergingPreview(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCalculatedAttributeDefinition


        /// <summary>
        /// Provides more information on a calculated attribute definition for Customer Profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeDefinition service method.</param>
        /// 
        /// <returns>The response from the GetCalculatedAttributeDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetCalculatedAttributeDefinition">REST API Reference for GetCalculatedAttributeDefinition Operation</seealso>
        GetCalculatedAttributeDefinitionResponse GetCalculatedAttributeDefinition(GetCalculatedAttributeDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCalculatedAttributeDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeDefinition operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCalculatedAttributeDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetCalculatedAttributeDefinition">REST API Reference for GetCalculatedAttributeDefinition Operation</seealso>
        IAsyncResult BeginGetCalculatedAttributeDefinition(GetCalculatedAttributeDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCalculatedAttributeDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCalculatedAttributeDefinition.</param>
        /// 
        /// <returns>Returns a  GetCalculatedAttributeDefinitionResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetCalculatedAttributeDefinition">REST API Reference for GetCalculatedAttributeDefinition Operation</seealso>
        GetCalculatedAttributeDefinitionResponse EndGetCalculatedAttributeDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCalculatedAttributeForProfile


        /// <summary>
        /// Retrieve a calculated attribute for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeForProfile service method.</param>
        /// 
        /// <returns>The response from the GetCalculatedAttributeForProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetCalculatedAttributeForProfile">REST API Reference for GetCalculatedAttributeForProfile Operation</seealso>
        GetCalculatedAttributeForProfileResponse GetCalculatedAttributeForProfile(GetCalculatedAttributeForProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCalculatedAttributeForProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeForProfile operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCalculatedAttributeForProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetCalculatedAttributeForProfile">REST API Reference for GetCalculatedAttributeForProfile Operation</seealso>
        IAsyncResult BeginGetCalculatedAttributeForProfile(GetCalculatedAttributeForProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCalculatedAttributeForProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCalculatedAttributeForProfile.</param>
        /// 
        /// <returns>Returns a  GetCalculatedAttributeForProfileResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetCalculatedAttributeForProfile">REST API Reference for GetCalculatedAttributeForProfile Operation</seealso>
        GetCalculatedAttributeForProfileResponse EndGetCalculatedAttributeForProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomain


        /// <summary>
        /// Returns information about a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomain">REST API Reference for GetDomain Operation</seealso>
        GetDomainResponse GetDomain(GetDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomain operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomain">REST API Reference for GetDomain Operation</seealso>
        IAsyncResult BeginGetDomain(GetDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomain.</param>
        /// 
        /// <returns>Returns a  GetDomainResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomain">REST API Reference for GetDomain Operation</seealso>
        GetDomainResponse EndGetDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventStream


        /// <summary>
        /// Returns information about the specified event stream in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
        /// 
        /// <returns>The response from the GetEventStream service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
        GetEventStreamResponse GetEventStream(GetEventStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
        IAsyncResult BeginGetEventStream(GetEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventStream.</param>
        /// 
        /// <returns>Returns a  GetEventStreamResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
        GetEventStreamResponse EndGetEventStream(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIdentityResolutionJob


        /// <summary>
        /// Returns information about an Identity Resolution Job in a specific domain. 
        /// 
        ///  
        /// <para>
        /// Identity Resolution Jobs are set up using the Amazon Connect admin console. For more
        /// information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/use-identity-resolution.html">Use
        /// Identity Resolution to consolidate similar profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityResolutionJob service method.</param>
        /// 
        /// <returns>The response from the GetIdentityResolutionJob service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetIdentityResolutionJob">REST API Reference for GetIdentityResolutionJob Operation</seealso>
        GetIdentityResolutionJobResponse GetIdentityResolutionJob(GetIdentityResolutionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityResolutionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityResolutionJob operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityResolutionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetIdentityResolutionJob">REST API Reference for GetIdentityResolutionJob Operation</seealso>
        IAsyncResult BeginGetIdentityResolutionJob(GetIdentityResolutionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityResolutionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityResolutionJob.</param>
        /// 
        /// <returns>Returns a  GetIdentityResolutionJobResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetIdentityResolutionJob">REST API Reference for GetIdentityResolutionJob Operation</seealso>
        GetIdentityResolutionJobResponse EndGetIdentityResolutionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIntegration


        /// <summary>
        /// Returns an integration for a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        GetIntegrationResponse GetIntegration(GetIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        IAsyncResult BeginGetIntegration(GetIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegration.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        GetIntegrationResponse EndGetIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMatches


        /// <summary>
        /// Before calling this API, use <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_CreateDomain.html">CreateDomain</a>
        /// or <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UpdateDomain.html">UpdateDomain</a>
        /// to enable identity resolution: set <code>Matching</code> to true.
        /// 
        ///  
        /// <para>
        /// GetMatches returns potentially matching profiles, based on the results of the latest
        /// run of a machine learning process. 
        /// </para>
        ///  <important> 
        /// <para>
        /// The process of matching duplicate profiles. If <code>Matching</code> = <code>true</code>,
        /// Amazon Connect Customer Profiles starts a weekly batch process called Identity Resolution
        /// Job. If you do not specify a date and time for Identity Resolution Job to run, by
        /// default it runs every Saturday at 12AM UTC to detect duplicate profiles in your domains.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After the Identity Resolution Job completes, use the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">GetMatches</a>
        /// API to return and review the results. Or, if you have configured <code>ExportingConfig</code>
        /// in the <code>MatchingRequest</code>, you can download the results from S3.
        /// </para>
        ///  </important> 
        /// <para>
        /// Amazon Connect uses the following profile attributes to identify matches:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PhoneNumber
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HomePhoneNumber
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BusinessPhoneNumber
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MobilePhoneNumber
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EmailAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PersonalEmailAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BusinessEmailAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FullName
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, two or more profiles—with spelling mistakes such as <b>John Doe</b> and
        /// <b>Jhn Doe</b>, or different casing email addresses such as <b>JOHN_DOE@ANYCOMPANY.COM</b>
        /// and <b>johndoe@anycompany.com</b>, or different phone number formats such as <b>555-010-0000</b>
        /// and <b>+1-555-010-0000</b>—can be detected as belonging to the same customer <b>John
        /// Doe</b> and merged into a unified profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatches service method.</param>
        /// 
        /// <returns>The response from the GetMatches service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetMatches">REST API Reference for GetMatches Operation</seealso>
        GetMatchesResponse GetMatches(GetMatchesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMatches operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetMatches">REST API Reference for GetMatches Operation</seealso>
        IAsyncResult BeginGetMatches(GetMatchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMatches.</param>
        /// 
        /// <returns>Returns a  GetMatchesResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetMatches">REST API Reference for GetMatches Operation</seealso>
        GetMatchesResponse EndGetMatches(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProfileObjectType


        /// <summary>
        /// Returns the object types for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileObjectType service method.</param>
        /// 
        /// <returns>The response from the GetProfileObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileObjectType">REST API Reference for GetProfileObjectType Operation</seealso>
        GetProfileObjectTypeResponse GetProfileObjectType(GetProfileObjectTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfileObjectType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfileObjectType operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfileObjectType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileObjectType">REST API Reference for GetProfileObjectType Operation</seealso>
        IAsyncResult BeginGetProfileObjectType(GetProfileObjectTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfileObjectType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfileObjectType.</param>
        /// 
        /// <returns>Returns a  GetProfileObjectTypeResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileObjectType">REST API Reference for GetProfileObjectType Operation</seealso>
        GetProfileObjectTypeResponse EndGetProfileObjectType(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProfileObjectTypeTemplate


        /// <summary>
        /// Returns the template information for a specific object type.
        /// 
        ///  
        /// <para>
        /// A template is a predefined ProfileObjectType, such as “Salesforce-Account” or “Salesforce-Contact.”
        /// When a user sends a ProfileObject, using the PutProfileObject API, with an ObjectTypeName
        /// that matches one of the TemplateIds, it uses the mappings from the template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileObjectTypeTemplate service method.</param>
        /// 
        /// <returns>The response from the GetProfileObjectTypeTemplate service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileObjectTypeTemplate">REST API Reference for GetProfileObjectTypeTemplate Operation</seealso>
        GetProfileObjectTypeTemplateResponse GetProfileObjectTypeTemplate(GetProfileObjectTypeTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfileObjectTypeTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfileObjectTypeTemplate operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfileObjectTypeTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileObjectTypeTemplate">REST API Reference for GetProfileObjectTypeTemplate Operation</seealso>
        IAsyncResult BeginGetProfileObjectTypeTemplate(GetProfileObjectTypeTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfileObjectTypeTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfileObjectTypeTemplate.</param>
        /// 
        /// <returns>Returns a  GetProfileObjectTypeTemplateResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileObjectTypeTemplate">REST API Reference for GetProfileObjectTypeTemplate Operation</seealso>
        GetProfileObjectTypeTemplateResponse EndGetProfileObjectTypeTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkflow


        /// <summary>
        /// Get details of specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        GetWorkflowResponse GetWorkflow(GetWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        IAsyncResult BeginGetWorkflow(GetWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflow.</param>
        /// 
        /// <returns>Returns a  GetWorkflowResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        GetWorkflowResponse EndGetWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkflowSteps


        /// <summary>
        /// Get granular list of steps in workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowSteps service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowSteps service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetWorkflowSteps">REST API Reference for GetWorkflowSteps Operation</seealso>
        GetWorkflowStepsResponse GetWorkflowSteps(GetWorkflowStepsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowSteps operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetWorkflowSteps">REST API Reference for GetWorkflowSteps Operation</seealso>
        IAsyncResult BeginGetWorkflowSteps(GetWorkflowStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowSteps.</param>
        /// 
        /// <returns>Returns a  GetWorkflowStepsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetWorkflowSteps">REST API Reference for GetWorkflowSteps Operation</seealso>
        GetWorkflowStepsResponse EndGetWorkflowSteps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountIntegrations


        /// <summary>
        /// Lists all of the integrations associated to a specific URI in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListAccountIntegrations service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListAccountIntegrations">REST API Reference for ListAccountIntegrations Operation</seealso>
        ListAccountIntegrationsResponse ListAccountIntegrations(ListAccountIntegrationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountIntegrations operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListAccountIntegrations">REST API Reference for ListAccountIntegrations Operation</seealso>
        IAsyncResult BeginListAccountIntegrations(ListAccountIntegrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountIntegrations.</param>
        /// 
        /// <returns>Returns a  ListAccountIntegrationsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListAccountIntegrations">REST API Reference for ListAccountIntegrations Operation</seealso>
        ListAccountIntegrationsResponse EndListAccountIntegrations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCalculatedAttributeDefinitions


        /// <summary>
        /// Lists calculated attribute definitions for Customer Profiles
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributeDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListCalculatedAttributeDefinitions service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListCalculatedAttributeDefinitions">REST API Reference for ListCalculatedAttributeDefinitions Operation</seealso>
        ListCalculatedAttributeDefinitionsResponse ListCalculatedAttributeDefinitions(ListCalculatedAttributeDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCalculatedAttributeDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributeDefinitions operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCalculatedAttributeDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListCalculatedAttributeDefinitions">REST API Reference for ListCalculatedAttributeDefinitions Operation</seealso>
        IAsyncResult BeginListCalculatedAttributeDefinitions(ListCalculatedAttributeDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCalculatedAttributeDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCalculatedAttributeDefinitions.</param>
        /// 
        /// <returns>Returns a  ListCalculatedAttributeDefinitionsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListCalculatedAttributeDefinitions">REST API Reference for ListCalculatedAttributeDefinitions Operation</seealso>
        ListCalculatedAttributeDefinitionsResponse EndListCalculatedAttributeDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCalculatedAttributesForProfile


        /// <summary>
        /// Retrieve a list of calculated attributes for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributesForProfile service method.</param>
        /// 
        /// <returns>The response from the ListCalculatedAttributesForProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListCalculatedAttributesForProfile">REST API Reference for ListCalculatedAttributesForProfile Operation</seealso>
        ListCalculatedAttributesForProfileResponse ListCalculatedAttributesForProfile(ListCalculatedAttributesForProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCalculatedAttributesForProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributesForProfile operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCalculatedAttributesForProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListCalculatedAttributesForProfile">REST API Reference for ListCalculatedAttributesForProfile Operation</seealso>
        IAsyncResult BeginListCalculatedAttributesForProfile(ListCalculatedAttributesForProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCalculatedAttributesForProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCalculatedAttributesForProfile.</param>
        /// 
        /// <returns>Returns a  ListCalculatedAttributesForProfileResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListCalculatedAttributesForProfile">REST API Reference for ListCalculatedAttributesForProfile Operation</seealso>
        ListCalculatedAttributesForProfileResponse EndListCalculatedAttributesForProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Returns a list of all the domains for an AWS account that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse EndListDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventStreams


        /// <summary>
        /// Returns a list of all the event streams in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventStreams service method.</param>
        /// 
        /// <returns>The response from the ListEventStreams service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListEventStreams">REST API Reference for ListEventStreams Operation</seealso>
        ListEventStreamsResponse ListEventStreams(ListEventStreamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventStreams operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListEventStreams">REST API Reference for ListEventStreams Operation</seealso>
        IAsyncResult BeginListEventStreams(ListEventStreamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventStreams.</param>
        /// 
        /// <returns>Returns a  ListEventStreamsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListEventStreams">REST API Reference for ListEventStreams Operation</seealso>
        ListEventStreamsResponse EndListEventStreams(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdentityResolutionJobs


        /// <summary>
        /// Lists all of the Identity Resolution Jobs in your domain. The response sorts the list
        /// by <code>JobStartTime</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityResolutionJobs service method.</param>
        /// 
        /// <returns>The response from the ListIdentityResolutionJobs service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListIdentityResolutionJobs">REST API Reference for ListIdentityResolutionJobs Operation</seealso>
        ListIdentityResolutionJobsResponse ListIdentityResolutionJobs(ListIdentityResolutionJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityResolutionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityResolutionJobs operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityResolutionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListIdentityResolutionJobs">REST API Reference for ListIdentityResolutionJobs Operation</seealso>
        IAsyncResult BeginListIdentityResolutionJobs(ListIdentityResolutionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityResolutionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityResolutionJobs.</param>
        /// 
        /// <returns>Returns a  ListIdentityResolutionJobsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListIdentityResolutionJobs">REST API Reference for ListIdentityResolutionJobs Operation</seealso>
        ListIdentityResolutionJobsResponse EndListIdentityResolutionJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIntegrations


        /// <summary>
        /// Lists all of the integrations in your domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        IAsyncResult BeginListIntegrations(ListIntegrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIntegrations.</param>
        /// 
        /// <returns>Returns a  ListIntegrationsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        ListIntegrationsResponse EndListIntegrations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProfileObjects


        /// <summary>
        /// Returns a list of objects associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjects service method.</param>
        /// 
        /// <returns>The response from the ListProfileObjects service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjects">REST API Reference for ListProfileObjects Operation</seealso>
        ListProfileObjectsResponse ListProfileObjects(ListProfileObjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfileObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjects operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfileObjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjects">REST API Reference for ListProfileObjects Operation</seealso>
        IAsyncResult BeginListProfileObjects(ListProfileObjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfileObjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfileObjects.</param>
        /// 
        /// <returns>Returns a  ListProfileObjectsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjects">REST API Reference for ListProfileObjects Operation</seealso>
        ListProfileObjectsResponse EndListProfileObjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProfileObjectTypes


        /// <summary>
        /// Lists all of the templates available within the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypes service method.</param>
        /// 
        /// <returns>The response from the ListProfileObjectTypes service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjectTypes">REST API Reference for ListProfileObjectTypes Operation</seealso>
        ListProfileObjectTypesResponse ListProfileObjectTypes(ListProfileObjectTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfileObjectTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypes operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfileObjectTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjectTypes">REST API Reference for ListProfileObjectTypes Operation</seealso>
        IAsyncResult BeginListProfileObjectTypes(ListProfileObjectTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfileObjectTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfileObjectTypes.</param>
        /// 
        /// <returns>Returns a  ListProfileObjectTypesResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjectTypes">REST API Reference for ListProfileObjectTypes Operation</seealso>
        ListProfileObjectTypesResponse EndListProfileObjectTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProfileObjectTypeTemplates


        /// <summary>
        /// Lists all of the template information for object types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypeTemplates service method.</param>
        /// 
        /// <returns>The response from the ListProfileObjectTypeTemplates service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjectTypeTemplates">REST API Reference for ListProfileObjectTypeTemplates Operation</seealso>
        ListProfileObjectTypeTemplatesResponse ListProfileObjectTypeTemplates(ListProfileObjectTypeTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfileObjectTypeTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypeTemplates operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfileObjectTypeTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjectTypeTemplates">REST API Reference for ListProfileObjectTypeTemplates Operation</seealso>
        IAsyncResult BeginListProfileObjectTypeTemplates(ListProfileObjectTypeTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfileObjectTypeTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfileObjectTypeTemplates.</param>
        /// 
        /// <returns>Returns a  ListProfileObjectTypeTemplatesResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileObjectTypeTemplates">REST API Reference for ListProfileObjectTypeTemplates Operation</seealso>
        ListProfileObjectTypeTemplatesResponse EndListProfileObjectTypeTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with an Amazon Connect Customer Profiles resource. In
        /// Connect Customer Profiles, domains, profile object types, and integrations can be
        /// tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkflows


        /// <summary>
        /// Query to list all workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        IAsyncResult BeginListWorkflows(ListWorkflowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflows.</param>
        /// 
        /// <returns>Returns a  ListWorkflowsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        ListWorkflowsResponse EndListWorkflows(IAsyncResult asyncResult);

        #endregion
        
        #region  MergeProfiles


        /// <summary>
        /// Runs an AWS Lambda job that does the following:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// All the profileKeys in the <code>ProfileToBeMerged</code> will be moved to the main
        /// profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All the objects in the <code>ProfileToBeMerged</code> will be moved to the main profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All the <code>ProfileToBeMerged</code> will be deleted at the end.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All the profileKeys in the <code>ProfileIdsToBeMerged</code> will be moved to the
        /// main profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Standard fields are merged as follows:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Fields are always "union"-ed if there are no conflicts in standard fields or attributeKeys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When there are conflicting fields:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// If no <code>SourceProfileIds</code> entry is specified, the main Profile value is
        /// always taken. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a <code>SourceProfileIds</code> entry is specified, the specified profileId is
        /// always taken, even if it is a NULL value.
        /// </para>
        ///  </li> </ol> </li> </ol> </li> </ol> 
        /// <para>
        /// You can use MergeProfiles together with <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">GetMatches</a>,
        /// which returns potentially matching profiles, or use it with the results of another
        /// matching system. After profiles have been merged, they cannot be separated (unmerged).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeProfiles service method.</param>
        /// 
        /// <returns>The response from the MergeProfiles service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/MergeProfiles">REST API Reference for MergeProfiles Operation</seealso>
        MergeProfilesResponse MergeProfiles(MergeProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MergeProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeProfiles operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergeProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/MergeProfiles">REST API Reference for MergeProfiles Operation</seealso>
        IAsyncResult BeginMergeProfiles(MergeProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MergeProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergeProfiles.</param>
        /// 
        /// <returns>Returns a  MergeProfilesResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/MergeProfiles">REST API Reference for MergeProfiles Operation</seealso>
        MergeProfilesResponse EndMergeProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  PutIntegration


        /// <summary>
        /// Adds an integration between the service and a third-party service, which includes
        /// Amazon AppFlow and Amazon Connect.
        /// 
        ///  
        /// <para>
        /// An integration can belong to only one domain.
        /// </para>
        ///  
        /// <para>
        /// To add or remove tags on an existing Integration, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">
        /// TagResource </a>/<a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">
        /// UntagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        PutIntegrationResponse PutIntegration(PutIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        IAsyncResult BeginPutIntegration(PutIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntegration.</param>
        /// 
        /// <returns>Returns a  PutIntegrationResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        PutIntegrationResponse EndPutIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutProfileObject


        /// <summary>
        /// Adds additional objects to customer profiles of a given ObjectType.
        /// 
        ///  
        /// <para>
        /// When adding a specific profile object, like a Contact Record, an inferred profile
        /// can get created if it is not mapped to an existing profile. The resulting profile
        /// will only have a phone number populated in the standard ProfileObject. Any additional
        /// Contact Records with the same phone number will be mapped to the same inferred profile.
        /// </para>
        ///  
        /// <para>
        /// When a ProfileObject is created and if a ProfileObjectType already exists for the
        /// ProfileObject, it will provide data to a standard profile depending on the ProfileObjectType
        /// definition.
        /// </para>
        ///  
        /// <para>
        /// PutProfileObject needs an ObjectType, which can be created using PutProfileObjectType.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileObject service method.</param>
        /// 
        /// <returns>The response from the PutProfileObject service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutProfileObject">REST API Reference for PutProfileObject Operation</seealso>
        PutProfileObjectResponse PutProfileObject(PutProfileObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutProfileObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutProfileObject operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutProfileObject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutProfileObject">REST API Reference for PutProfileObject Operation</seealso>
        IAsyncResult BeginPutProfileObject(PutProfileObjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutProfileObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutProfileObject.</param>
        /// 
        /// <returns>Returns a  PutProfileObjectResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutProfileObject">REST API Reference for PutProfileObject Operation</seealso>
        PutProfileObjectResponse EndPutProfileObject(IAsyncResult asyncResult);

        #endregion
        
        #region  PutProfileObjectType


        /// <summary>
        /// Defines a ProfileObjectType.
        /// 
        ///  
        /// <para>
        /// To add or remove tags on an existing ObjectType, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">
        /// TagResource</a>/<a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileObjectType service method.</param>
        /// 
        /// <returns>The response from the PutProfileObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutProfileObjectType">REST API Reference for PutProfileObjectType Operation</seealso>
        PutProfileObjectTypeResponse PutProfileObjectType(PutProfileObjectTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutProfileObjectType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutProfileObjectType operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutProfileObjectType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutProfileObjectType">REST API Reference for PutProfileObjectType Operation</seealso>
        IAsyncResult BeginPutProfileObjectType(PutProfileObjectTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutProfileObjectType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutProfileObjectType.</param>
        /// 
        /// <returns>Returns a  PutProfileObjectTypeResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutProfileObjectType">REST API Reference for PutProfileObjectType Operation</seealso>
        PutProfileObjectTypeResponse EndPutProfileObjectType(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchProfiles


        /// <summary>
        /// Searches for profiles within a specific domain using one or more predefined search
        /// keys (e.g., _fullName, _phone, _email, _account, etc.) and/or custom-defined search
        /// keys. A search key is a data type pair that consists of a <code>KeyName</code> and
        /// <code>Values</code> list.
        /// 
        ///  
        /// <para>
        /// This operation supports searching for profiles with a minimum of 1 key-value(s) pair
        /// and up to 5 key-value(s) pairs using either <code>AND</code> or <code>OR</code> logic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProfiles service method.</param>
        /// 
        /// <returns>The response from the SearchProfiles service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        SearchProfilesResponse SearchProfiles(SearchProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProfiles operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        IAsyncResult BeginSearchProfiles(SearchProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProfiles.</param>
        /// 
        /// <returns>Returns a  SearchProfilesResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        SearchProfilesResponse EndSearchProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Amazon Connect Customer
        /// Profiles resource. Tags can help you organize and categorize your resources. You can
        /// also use them to scope user permissions by granting a user permission to access or
        /// change only resources with certain tag values. In Connect Customer Profiles, domains,
        /// profile object types, and integrations can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to AWS and are interpreted strictly as strings
        /// of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the TagResource action with a resource that already has tags. If you specify
        /// a new tag key, this tag is appended to the list of tags associated with the resource.
        /// If you specify a tag key that is already associated with the resource, the new tag
        /// value that you specify replaces the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified Amazon Connect Customer Profiles resource.
        /// In Connect Customer Profiles, domains, profile object types, and integrations can
        /// be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCalculatedAttributeDefinition


        /// <summary>
        /// Updates an existing calculated attribute definition. When updating the Conditions,
        /// note that increasing the date range of a calculated attribute will not trigger inclusion
        /// of historical data greater than the current date range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCalculatedAttributeDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateCalculatedAttributeDefinition service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateCalculatedAttributeDefinition">REST API Reference for UpdateCalculatedAttributeDefinition Operation</seealso>
        UpdateCalculatedAttributeDefinitionResponse UpdateCalculatedAttributeDefinition(UpdateCalculatedAttributeDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCalculatedAttributeDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCalculatedAttributeDefinition operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCalculatedAttributeDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateCalculatedAttributeDefinition">REST API Reference for UpdateCalculatedAttributeDefinition Operation</seealso>
        IAsyncResult BeginUpdateCalculatedAttributeDefinition(UpdateCalculatedAttributeDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCalculatedAttributeDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCalculatedAttributeDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateCalculatedAttributeDefinitionResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateCalculatedAttributeDefinition">REST API Reference for UpdateCalculatedAttributeDefinition Operation</seealso>
        UpdateCalculatedAttributeDefinitionResponse EndUpdateCalculatedAttributeDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomain


        /// <summary>
        /// Updates the properties of a domain, including creating or selecting a dead letter
        /// queue or an encryption key.
        /// 
        ///  
        /// <para>
        /// After a domain is created, the name can’t be changed.
        /// </para>
        ///  
        /// <para>
        /// Use this API or <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_CreateDomain.html">CreateDomain</a>
        /// to enable <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">identity
        /// resolution</a>: set <code>Matching</code> to true. 
        /// </para>
        ///  
        /// <para>
        /// To prevent cross-service impersonation when you call this API, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cross-service-confused-deputy-prevention.html">Cross-service
        /// confused deputy prevention</a> for sample policies that you should apply. 
        /// </para>
        ///  
        /// <para>
        /// To add or remove tags on an existing Domain, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">TagResource</a>/<a
        /// href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        UpdateDomainResponse UpdateDomain(UpdateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        IAsyncResult BeginUpdateDomain(UpdateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomain.</param>
        /// 
        /// <returns>Returns a  UpdateDomainResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        UpdateDomainResponse EndUpdateDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProfile


        /// <summary>
        /// Updates the properties of a profile. The ProfileId is required for updating a customer
        /// profile.
        /// 
        ///  
        /// <para>
        /// When calling the UpdateProfile API, specifying an empty string value means that any
        /// existing value will be removed. Not specifying a string value means that any value
        /// already there will be kept.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        UpdateProfileResponse UpdateProfile(UpdateProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        IAsyncResult BeginUpdateProfile(UpdateProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfile.</param>
        /// 
        /// <returns>Returns a  UpdateProfileResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        UpdateProfileResponse EndUpdateProfile(IAsyncResult asyncResult);

        #endregion
        
    }
}