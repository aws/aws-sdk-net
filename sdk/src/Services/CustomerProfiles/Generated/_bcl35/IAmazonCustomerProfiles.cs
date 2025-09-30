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

#pragma warning disable CS1570
namespace Amazon.CustomerProfiles
{
    /// <summary>
    /// <para>Interface for accessing CustomerProfiles</para>
    ///
    /// Amazon Connect Customer Profiles <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Operations_Amazon_Connect_Customer_Profiles.html">Customer
    /// Profiles actions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Types_Amazon_Connect_Customer_Profiles.html">Customer
    /// Profiles data types</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon Connect Customer Profiles is a unified customer profile for your contact center
    /// that has pre-built connectors powered by AppFlow that make it easy to combine customer
    /// information from third party applications, such as Salesforce (CRM), ServiceNow (ITSM),
    /// and your enterprise resource planning (ERP), with contact history from your Amazon
    /// Connect contact center. 
    /// </para>
    ///  
    /// <para>
    /// For more information about the Amazon Connect Customer Profiles feature, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/customer-profiles.html">Use
    /// Customer Profiles</a> in the <i>Amazon Connect Administrator's Guide</i>. 
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
        
        #region  BatchGetCalculatedAttributeForProfile


        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCalculatedAttributeForProfile service method.</param>
        /// 
        /// <returns>The response from the BatchGetCalculatedAttributeForProfile service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchGetCalculatedAttributeForProfile">REST API Reference for BatchGetCalculatedAttributeForProfile Operation</seealso>
        BatchGetCalculatedAttributeForProfileResponse BatchGetCalculatedAttributeForProfile(BatchGetCalculatedAttributeForProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetCalculatedAttributeForProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCalculatedAttributeForProfile operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetCalculatedAttributeForProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchGetCalculatedAttributeForProfile">REST API Reference for BatchGetCalculatedAttributeForProfile Operation</seealso>
        IAsyncResult BeginBatchGetCalculatedAttributeForProfile(BatchGetCalculatedAttributeForProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetCalculatedAttributeForProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetCalculatedAttributeForProfile.</param>
        /// 
        /// <returns>Returns a  BatchGetCalculatedAttributeForProfileResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchGetCalculatedAttributeForProfile">REST API Reference for BatchGetCalculatedAttributeForProfile Operation</seealso>
        BatchGetCalculatedAttributeForProfileResponse EndBatchGetCalculatedAttributeForProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetProfile


        /// <summary>
        /// Get a batch of profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProfile service method.</param>
        /// 
        /// <returns>The response from the BatchGetProfile service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchGetProfile">REST API Reference for BatchGetProfile Operation</seealso>
        BatchGetProfileResponse BatchGetProfile(BatchGetProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProfile operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchGetProfile">REST API Reference for BatchGetProfile Operation</seealso>
        IAsyncResult BeginBatchGetProfile(BatchGetProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetProfile.</param>
        /// 
        /// <returns>Returns a  BatchGetProfileResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchGetProfile">REST API Reference for BatchGetProfile Operation</seealso>
        BatchGetProfileResponse EndBatchGetProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCalculatedAttributeDefinition


        /// <summary>
        /// Creates a new calculated attribute definition. After creation, new object data ingested
        /// into Customer Profiles will be included in the calculated attribute, which can be
        /// retrieved for a profile using the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetCalculatedAttributeForProfile.html">GetCalculatedAttributeForProfile</a>
        /// API. Defining a calculated attribute makes it available for all profiles within a
        /// domain. Each calculated attribute can only reference one <c>ObjectType</c> and at
        /// most, two fields from that <c>ObjectType</c>.
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
        /// resolution</a>: set <c>Matching</c> to true.
        /// </para>
        ///  
        /// <para>
        /// To prevent cross-service impersonation when you call this API, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cross-service-confused-deputy-prevention.html">Cross-service
        /// confused deputy prevention</a> for sample policies that you should apply. 
        /// </para>
        ///  <note> 
        /// <para>
        /// It is not possible to associate a Customer Profiles domain with an Amazon Connect
        /// Instance directly from the API. If you would like to create a domain and associate
        /// a Customer Profiles domain, use the Amazon Connect admin website. For more information,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-customer-profiles.html#enable-customer-profiles-step1">Enable
        /// Customer Profiles</a>.
        /// </para>
        ///  
        /// <para>
        /// Each Amazon Connect instance can be associated with only one domain. Multiple Amazon
        /// Connect instances can be associated with one domain.
        /// </para>
        ///  </note>
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
        
        #region  CreateDomainLayout


        /// <summary>
        /// Creates the layout to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainLayout service method.</param>
        /// 
        /// <returns>The response from the CreateDomainLayout service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateDomainLayout">REST API Reference for CreateDomainLayout Operation</seealso>
        CreateDomainLayoutResponse CreateDomainLayout(CreateDomainLayoutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainLayout operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainLayout operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainLayout
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateDomainLayout">REST API Reference for CreateDomainLayout Operation</seealso>
        IAsyncResult BeginCreateDomainLayout(CreateDomainLayoutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainLayout operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainLayout.</param>
        /// 
        /// <returns>Returns a  CreateDomainLayoutResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateDomainLayout">REST API Reference for CreateDomainLayout Operation</seealso>
        CreateDomainLayoutResponse EndCreateDomainLayout(IAsyncResult asyncResult);

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
        
        #region  CreateEventTrigger


        /// <summary>
        /// Creates an event trigger, which specifies the rules when to perform action based on
        /// customer's ingested data.
        /// 
        ///  
        /// <para>
        /// Each event stream can be associated with only one integration in the same region and
        /// AWS account as the event stream. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventTrigger service method.</param>
        /// 
        /// <returns>The response from the CreateEventTrigger service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateEventTrigger">REST API Reference for CreateEventTrigger Operation</seealso>
        CreateEventTriggerResponse CreateEventTrigger(CreateEventTriggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventTrigger operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateEventTrigger">REST API Reference for CreateEventTrigger Operation</seealso>
        IAsyncResult BeginCreateEventTrigger(CreateEventTriggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventTrigger.</param>
        /// 
        /// <returns>Returns a  CreateEventTriggerResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateEventTrigger">REST API Reference for CreateEventTrigger Operation</seealso>
        CreateEventTriggerResponse EndCreateEventTrigger(IAsyncResult asyncResult);

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
        
        #region  CreateSegmentDefinition


        /// <summary>
        /// Creates a segment definition associated to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateSegmentDefinition service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentDefinition">REST API Reference for CreateSegmentDefinition Operation</seealso>
        CreateSegmentDefinitionResponse CreateSegmentDefinition(CreateSegmentDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegmentDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentDefinition operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSegmentDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentDefinition">REST API Reference for CreateSegmentDefinition Operation</seealso>
        IAsyncResult BeginCreateSegmentDefinition(CreateSegmentDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSegmentDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSegmentDefinition.</param>
        /// 
        /// <returns>Returns a  CreateSegmentDefinitionResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentDefinition">REST API Reference for CreateSegmentDefinition Operation</seealso>
        CreateSegmentDefinitionResponse EndCreateSegmentDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSegmentEstimate


        /// <summary>
        /// Creates a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentEstimate service method.</param>
        /// 
        /// <returns>The response from the CreateSegmentEstimate service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentEstimate">REST API Reference for CreateSegmentEstimate Operation</seealso>
        CreateSegmentEstimateResponse CreateSegmentEstimate(CreateSegmentEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegmentEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentEstimate operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSegmentEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentEstimate">REST API Reference for CreateSegmentEstimate Operation</seealso>
        IAsyncResult BeginCreateSegmentEstimate(CreateSegmentEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSegmentEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSegmentEstimate.</param>
        /// 
        /// <returns>Returns a  CreateSegmentEstimateResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentEstimate">REST API Reference for CreateSegmentEstimate Operation</seealso>
        CreateSegmentEstimateResponse EndCreateSegmentEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSegmentSnapshot


        /// <summary>
        /// Triggers a job to export a segment to a specified destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSegmentSnapshot service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentSnapshot">REST API Reference for CreateSegmentSnapshot Operation</seealso>
        CreateSegmentSnapshotResponse CreateSegmentSnapshot(CreateSegmentSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegmentSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentSnapshot operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSegmentSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentSnapshot">REST API Reference for CreateSegmentSnapshot Operation</seealso>
        IAsyncResult BeginCreateSegmentSnapshot(CreateSegmentSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSegmentSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSegmentSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSegmentSnapshotResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateSegmentSnapshot">REST API Reference for CreateSegmentSnapshot Operation</seealso>
        CreateSegmentSnapshotResponse EndCreateSegmentSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUploadJob


        /// <summary>
        /// Creates an Upload job to ingest data for segment imports. The metadata is created
        /// for the job with the provided field mapping and unique key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadJob service method.</param>
        /// 
        /// <returns>The response from the CreateUploadJob service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateUploadJob">REST API Reference for CreateUploadJob Operation</seealso>
        CreateUploadJobResponse CreateUploadJob(CreateUploadJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUploadJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadJob operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUploadJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateUploadJob">REST API Reference for CreateUploadJob Operation</seealso>
        IAsyncResult BeginCreateUploadJob(CreateUploadJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUploadJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUploadJob.</param>
        /// 
        /// <returns>Returns a  CreateUploadJobResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateUploadJob">REST API Reference for CreateUploadJob Operation</seealso>
        CreateUploadJobResponse EndCreateUploadJob(IAsyncResult asyncResult);

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
        
        #region  DeleteDomainLayout


        /// <summary>
        /// Deletes the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainLayout service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainLayout service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomainLayout">REST API Reference for DeleteDomainLayout Operation</seealso>
        DeleteDomainLayoutResponse DeleteDomainLayout(DeleteDomainLayoutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainLayout operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainLayout operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainLayout
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomainLayout">REST API Reference for DeleteDomainLayout Operation</seealso>
        IAsyncResult BeginDeleteDomainLayout(DeleteDomainLayoutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainLayout operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainLayout.</param>
        /// 
        /// <returns>Returns a  DeleteDomainLayoutResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomainLayout">REST API Reference for DeleteDomainLayout Operation</seealso>
        DeleteDomainLayoutResponse EndDeleteDomainLayout(IAsyncResult asyncResult);

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
        
        #region  DeleteEventTrigger


        /// <summary>
        /// Disable and deletes the Event Trigger.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an Event Trigger with an active Integration associated.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventTrigger service method.</param>
        /// 
        /// <returns>The response from the DeleteEventTrigger service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteEventTrigger">REST API Reference for DeleteEventTrigger Operation</seealso>
        DeleteEventTriggerResponse DeleteEventTrigger(DeleteEventTriggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventTrigger operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteEventTrigger">REST API Reference for DeleteEventTrigger Operation</seealso>
        IAsyncResult BeginDeleteEventTrigger(DeleteEventTriggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventTrigger.</param>
        /// 
        /// <returns>Returns a  DeleteEventTriggerResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteEventTrigger">REST API Reference for DeleteEventTrigger Operation</seealso>
        DeleteEventTriggerResponse EndDeleteEventTrigger(IAsyncResult asyncResult);

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
        
        #region  DeleteSegmentDefinition


        /// <summary>
        /// Deletes a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegmentDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteSegmentDefinition service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteSegmentDefinition">REST API Reference for DeleteSegmentDefinition Operation</seealso>
        DeleteSegmentDefinitionResponse DeleteSegmentDefinition(DeleteSegmentDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSegmentDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegmentDefinition operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSegmentDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteSegmentDefinition">REST API Reference for DeleteSegmentDefinition Operation</seealso>
        IAsyncResult BeginDeleteSegmentDefinition(DeleteSegmentDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSegmentDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSegmentDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteSegmentDefinitionResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteSegmentDefinition">REST API Reference for DeleteSegmentDefinition Operation</seealso>
        DeleteSegmentDefinitionResponse EndDeleteSegmentDefinition(IAsyncResult asyncResult);

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
        
        #region  DetectProfileObjectType


        /// <summary>
        /// The process of detecting profile object type mapping by using given objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectProfileObjectType service method.</param>
        /// 
        /// <returns>The response from the DetectProfileObjectType service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DetectProfileObjectType">REST API Reference for DetectProfileObjectType Operation</seealso>
        DetectProfileObjectTypeResponse DetectProfileObjectType(DetectProfileObjectTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetectProfileObjectType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectProfileObjectType operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectProfileObjectType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DetectProfileObjectType">REST API Reference for DetectProfileObjectType Operation</seealso>
        IAsyncResult BeginDetectProfileObjectType(DetectProfileObjectTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectProfileObjectType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectProfileObjectType.</param>
        /// 
        /// <returns>Returns a  DetectProfileObjectTypeResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DetectProfileObjectType">REST API Reference for DetectProfileObjectType Operation</seealso>
        DetectProfileObjectTypeResponse EndDetectProfileObjectType(IAsyncResult asyncResult);

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
        /// If your matching list includes too few attributes (such as only <c>FirstName</c> or
        /// only <c>LastName</c>), there may be a large number of matches. This increases the
        /// chances of erroneous merges.
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
        
        #region  GetDomainLayout


        /// <summary>
        /// Gets the layout to view data for a specific domain. This API can only be invoked from
        /// the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainLayout service method.</param>
        /// 
        /// <returns>The response from the GetDomainLayout service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomainLayout">REST API Reference for GetDomainLayout Operation</seealso>
        GetDomainLayoutResponse GetDomainLayout(GetDomainLayoutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainLayout operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainLayout operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainLayout
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomainLayout">REST API Reference for GetDomainLayout Operation</seealso>
        IAsyncResult BeginGetDomainLayout(GetDomainLayoutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainLayout operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainLayout.</param>
        /// 
        /// <returns>Returns a  GetDomainLayoutResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomainLayout">REST API Reference for GetDomainLayout Operation</seealso>
        GetDomainLayoutResponse EndGetDomainLayout(IAsyncResult asyncResult);

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
        
        #region  GetEventTrigger


        /// <summary>
        /// Get a specific Event Trigger from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventTrigger service method.</param>
        /// 
        /// <returns>The response from the GetEventTrigger service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetEventTrigger">REST API Reference for GetEventTrigger Operation</seealso>
        GetEventTriggerResponse GetEventTrigger(GetEventTriggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventTrigger operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetEventTrigger">REST API Reference for GetEventTrigger Operation</seealso>
        IAsyncResult BeginGetEventTrigger(GetEventTriggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventTrigger.</param>
        /// 
        /// <returns>Returns a  GetEventTriggerResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetEventTrigger">REST API Reference for GetEventTrigger Operation</seealso>
        GetEventTriggerResponse EndGetEventTrigger(IAsyncResult asyncResult);

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
        /// to enable identity resolution: set <c>Matching</c> to true.
        /// 
        ///  
        /// <para>
        /// GetMatches returns potentially matching profiles, based on the results of the latest
        /// run of a machine learning process. 
        /// </para>
        ///  <important> 
        /// <para>
        /// The process of matching duplicate profiles. If <c>Matching</c> = <c>true</c>, Amazon
        /// Connect Customer Profiles starts a weekly batch process called Identity Resolution
        /// Job. If you do not specify a date and time for Identity Resolution Job to run, by
        /// default it runs every Saturday at 12AM UTC to detect duplicate profiles in your domains.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After the Identity Resolution Job completes, use the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">GetMatches</a>
        /// API to return and review the results. Or, if you have configured <c>ExportingConfig</c>
        /// in the <c>MatchingRequest</c>, you can download the results from S3.
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
        
        #region  GetProfileHistoryRecord


        /// <summary>
        /// Returns a history record for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileHistoryRecord service method.</param>
        /// 
        /// <returns>The response from the GetProfileHistoryRecord service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileHistoryRecord">REST API Reference for GetProfileHistoryRecord Operation</seealso>
        GetProfileHistoryRecordResponse GetProfileHistoryRecord(GetProfileHistoryRecordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfileHistoryRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfileHistoryRecord operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfileHistoryRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileHistoryRecord">REST API Reference for GetProfileHistoryRecord Operation</seealso>
        IAsyncResult BeginGetProfileHistoryRecord(GetProfileHistoryRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfileHistoryRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfileHistoryRecord.</param>
        /// 
        /// <returns>Returns a  GetProfileHistoryRecordResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileHistoryRecord">REST API Reference for GetProfileHistoryRecord Operation</seealso>
        GetProfileHistoryRecordResponse EndGetProfileHistoryRecord(IAsyncResult asyncResult);

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
        
        #region  GetSegmentDefinition


        /// <summary>
        /// Gets a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentDefinition service method.</param>
        /// 
        /// <returns>The response from the GetSegmentDefinition service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentDefinition">REST API Reference for GetSegmentDefinition Operation</seealso>
        GetSegmentDefinitionResponse GetSegmentDefinition(GetSegmentDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentDefinition operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentDefinition">REST API Reference for GetSegmentDefinition Operation</seealso>
        IAsyncResult BeginGetSegmentDefinition(GetSegmentDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentDefinition.</param>
        /// 
        /// <returns>Returns a  GetSegmentDefinitionResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentDefinition">REST API Reference for GetSegmentDefinition Operation</seealso>
        GetSegmentDefinitionResponse EndGetSegmentDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentEstimate


        /// <summary>
        /// Gets the result of a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentEstimate service method.</param>
        /// 
        /// <returns>The response from the GetSegmentEstimate service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentEstimate">REST API Reference for GetSegmentEstimate Operation</seealso>
        GetSegmentEstimateResponse GetSegmentEstimate(GetSegmentEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentEstimate operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentEstimate">REST API Reference for GetSegmentEstimate Operation</seealso>
        IAsyncResult BeginGetSegmentEstimate(GetSegmentEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentEstimate.</param>
        /// 
        /// <returns>Returns a  GetSegmentEstimateResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentEstimate">REST API Reference for GetSegmentEstimate Operation</seealso>
        GetSegmentEstimateResponse EndGetSegmentEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentMembership


        /// <summary>
        /// Determines if the given profiles are within a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentMembership service method.</param>
        /// 
        /// <returns>The response from the GetSegmentMembership service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentMembership">REST API Reference for GetSegmentMembership Operation</seealso>
        GetSegmentMembershipResponse GetSegmentMembership(GetSegmentMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentMembership operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentMembership">REST API Reference for GetSegmentMembership Operation</seealso>
        IAsyncResult BeginGetSegmentMembership(GetSegmentMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentMembership.</param>
        /// 
        /// <returns>Returns a  GetSegmentMembershipResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentMembership">REST API Reference for GetSegmentMembership Operation</seealso>
        GetSegmentMembershipResponse EndGetSegmentMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentSnapshot


        /// <summary>
        /// Retrieve the latest status of a segment snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetSegmentSnapshot service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentSnapshot">REST API Reference for GetSegmentSnapshot Operation</seealso>
        GetSegmentSnapshotResponse GetSegmentSnapshot(GetSegmentSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentSnapshot operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentSnapshot">REST API Reference for GetSegmentSnapshot Operation</seealso>
        IAsyncResult BeginGetSegmentSnapshot(GetSegmentSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentSnapshot.</param>
        /// 
        /// <returns>Returns a  GetSegmentSnapshotResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentSnapshot">REST API Reference for GetSegmentSnapshot Operation</seealso>
        GetSegmentSnapshotResponse EndGetSegmentSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSimilarProfiles


        /// <summary>
        /// Returns a set of profiles that belong to the same matching group using the <c>matchId</c>
        /// or <c>profileId</c>. You can also specify the type of matching that you want for finding
        /// similar profiles using either <c>RULE_BASED_MATCHING</c> or <c>ML_BASED_MATCHING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSimilarProfiles service method.</param>
        /// 
        /// <returns>The response from the GetSimilarProfiles service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSimilarProfiles">REST API Reference for GetSimilarProfiles Operation</seealso>
        GetSimilarProfilesResponse GetSimilarProfiles(GetSimilarProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSimilarProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSimilarProfiles operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSimilarProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSimilarProfiles">REST API Reference for GetSimilarProfiles Operation</seealso>
        IAsyncResult BeginGetSimilarProfiles(GetSimilarProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSimilarProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSimilarProfiles.</param>
        /// 
        /// <returns>Returns a  GetSimilarProfilesResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSimilarProfiles">REST API Reference for GetSimilarProfiles Operation</seealso>
        GetSimilarProfilesResponse EndGetSimilarProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUploadJob


        /// <summary>
        /// This API retrieves the details of a specific upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJob service method.</param>
        /// 
        /// <returns>The response from the GetUploadJob service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetUploadJob">REST API Reference for GetUploadJob Operation</seealso>
        GetUploadJobResponse GetUploadJob(GetUploadJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUploadJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJob operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUploadJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetUploadJob">REST API Reference for GetUploadJob Operation</seealso>
        IAsyncResult BeginGetUploadJob(GetUploadJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUploadJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUploadJob.</param>
        /// 
        /// <returns>Returns a  GetUploadJobResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetUploadJob">REST API Reference for GetUploadJob Operation</seealso>
        GetUploadJobResponse EndGetUploadJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUploadJobPath


        /// <summary>
        /// This API retrieves the pre-signed URL and client token for uploading the file associated
        /// with the upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJobPath service method.</param>
        /// 
        /// <returns>The response from the GetUploadJobPath service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetUploadJobPath">REST API Reference for GetUploadJobPath Operation</seealso>
        GetUploadJobPathResponse GetUploadJobPath(GetUploadJobPathRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUploadJobPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJobPath operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUploadJobPath
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetUploadJobPath">REST API Reference for GetUploadJobPath Operation</seealso>
        IAsyncResult BeginGetUploadJobPath(GetUploadJobPathRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUploadJobPath operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUploadJobPath.</param>
        /// 
        /// <returns>Returns a  GetUploadJobPathResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetUploadJobPath">REST API Reference for GetUploadJobPath Operation</seealso>
        GetUploadJobPathResponse EndGetUploadJobPath(IAsyncResult asyncResult);

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
        
        #region  ListDomainLayouts


        /// <summary>
        /// Lists the existing layouts that can be used to view data for a specific domain. This
        /// API can only be invoked from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainLayouts service method.</param>
        /// 
        /// <returns>The response from the ListDomainLayouts service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomainLayouts">REST API Reference for ListDomainLayouts Operation</seealso>
        ListDomainLayoutsResponse ListDomainLayouts(ListDomainLayoutsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainLayouts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainLayouts operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainLayouts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomainLayouts">REST API Reference for ListDomainLayouts Operation</seealso>
        IAsyncResult BeginListDomainLayouts(ListDomainLayoutsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainLayouts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainLayouts.</param>
        /// 
        /// <returns>Returns a  ListDomainLayoutsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomainLayouts">REST API Reference for ListDomainLayouts Operation</seealso>
        ListDomainLayoutsResponse EndListDomainLayouts(IAsyncResult asyncResult);

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
        
        #region  ListEventTriggers


        /// <summary>
        /// List all Event Triggers under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTriggers service method.</param>
        /// 
        /// <returns>The response from the ListEventTriggers service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListEventTriggers">REST API Reference for ListEventTriggers Operation</seealso>
        ListEventTriggersResponse ListEventTriggers(ListEventTriggersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventTriggers operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventTriggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListEventTriggers">REST API Reference for ListEventTriggers Operation</seealso>
        IAsyncResult BeginListEventTriggers(ListEventTriggersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventTriggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventTriggers.</param>
        /// 
        /// <returns>Returns a  ListEventTriggersResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListEventTriggers">REST API Reference for ListEventTriggers Operation</seealso>
        ListEventTriggersResponse EndListEventTriggers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdentityResolutionJobs


        /// <summary>
        /// Lists all of the Identity Resolution Jobs in your domain. The response sorts the list
        /// by <c>JobStartTime</c>.
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
        
        #region  ListObjectTypeAttributes


        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectTypeAttributes service method.</param>
        /// 
        /// <returns>The response from the ListObjectTypeAttributes service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListObjectTypeAttributes">REST API Reference for ListObjectTypeAttributes Operation</seealso>
        ListObjectTypeAttributesResponse ListObjectTypeAttributes(ListObjectTypeAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectTypeAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectTypeAttributes operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectTypeAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListObjectTypeAttributes">REST API Reference for ListObjectTypeAttributes Operation</seealso>
        IAsyncResult BeginListObjectTypeAttributes(ListObjectTypeAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectTypeAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectTypeAttributes.</param>
        /// 
        /// <returns>Returns a  ListObjectTypeAttributesResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListObjectTypeAttributes">REST API Reference for ListObjectTypeAttributes Operation</seealso>
        ListObjectTypeAttributesResponse EndListObjectTypeAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProfileAttributeValues


        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAttributeValues service method.</param>
        /// 
        /// <returns>The response from the ListProfileAttributeValues service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileAttributeValues">REST API Reference for ListProfileAttributeValues Operation</seealso>
        ListProfileAttributeValuesResponse ListProfileAttributeValues(ListProfileAttributeValuesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfileAttributeValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAttributeValues operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfileAttributeValues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileAttributeValues">REST API Reference for ListProfileAttributeValues Operation</seealso>
        IAsyncResult BeginListProfileAttributeValues(ListProfileAttributeValuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfileAttributeValues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfileAttributeValues.</param>
        /// 
        /// <returns>Returns a  ListProfileAttributeValuesResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileAttributeValues">REST API Reference for ListProfileAttributeValues Operation</seealso>
        ListProfileAttributeValuesResponse EndListProfileAttributeValues(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProfileHistoryRecords


        /// <summary>
        /// Returns a list of history records for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileHistoryRecords service method.</param>
        /// 
        /// <returns>The response from the ListProfileHistoryRecords service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileHistoryRecords">REST API Reference for ListProfileHistoryRecords Operation</seealso>
        ListProfileHistoryRecordsResponse ListProfileHistoryRecords(ListProfileHistoryRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfileHistoryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfileHistoryRecords operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfileHistoryRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileHistoryRecords">REST API Reference for ListProfileHistoryRecords Operation</seealso>
        IAsyncResult BeginListProfileHistoryRecords(ListProfileHistoryRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfileHistoryRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfileHistoryRecords.</param>
        /// 
        /// <returns>Returns a  ListProfileHistoryRecordsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListProfileHistoryRecords">REST API Reference for ListProfileHistoryRecords Operation</seealso>
        ListProfileHistoryRecordsResponse EndListProfileHistoryRecords(IAsyncResult asyncResult);

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
        
        #region  ListRuleBasedMatches


        /// <summary>
        /// Returns a set of <c>MatchIds</c> that belong to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleBasedMatches service method.</param>
        /// 
        /// <returns>The response from the ListRuleBasedMatches service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRuleBasedMatches">REST API Reference for ListRuleBasedMatches Operation</seealso>
        ListRuleBasedMatchesResponse ListRuleBasedMatches(ListRuleBasedMatchesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleBasedMatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleBasedMatches operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleBasedMatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRuleBasedMatches">REST API Reference for ListRuleBasedMatches Operation</seealso>
        IAsyncResult BeginListRuleBasedMatches(ListRuleBasedMatchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleBasedMatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleBasedMatches.</param>
        /// 
        /// <returns>Returns a  ListRuleBasedMatchesResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRuleBasedMatches">REST API Reference for ListRuleBasedMatches Operation</seealso>
        ListRuleBasedMatchesResponse EndListRuleBasedMatches(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSegmentDefinitions


        /// <summary>
        /// Lists all segment definitions under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListSegmentDefinitions service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListSegmentDefinitions">REST API Reference for ListSegmentDefinitions Operation</seealso>
        ListSegmentDefinitionsResponse ListSegmentDefinitions(ListSegmentDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSegmentDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentDefinitions operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSegmentDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListSegmentDefinitions">REST API Reference for ListSegmentDefinitions Operation</seealso>
        IAsyncResult BeginListSegmentDefinitions(ListSegmentDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSegmentDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSegmentDefinitions.</param>
        /// 
        /// <returns>Returns a  ListSegmentDefinitionsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListSegmentDefinitions">REST API Reference for ListSegmentDefinitions Operation</seealso>
        ListSegmentDefinitionsResponse EndListSegmentDefinitions(IAsyncResult asyncResult);

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
        
        #region  ListUploadJobs


        /// <summary>
        /// This API retrieves a list of upload jobs for the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUploadJobs service method.</param>
        /// 
        /// <returns>The response from the ListUploadJobs service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListUploadJobs">REST API Reference for ListUploadJobs Operation</seealso>
        ListUploadJobsResponse ListUploadJobs(ListUploadJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUploadJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUploadJobs operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUploadJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListUploadJobs">REST API Reference for ListUploadJobs Operation</seealso>
        IAsyncResult BeginListUploadJobs(ListUploadJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUploadJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUploadJobs.</param>
        /// 
        /// <returns>Returns a  ListUploadJobsResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListUploadJobs">REST API Reference for ListUploadJobs Operation</seealso>
        ListUploadJobsResponse EndListUploadJobs(IAsyncResult asyncResult);

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
        /// All the profileKeys in the <c>ProfileToBeMerged</c> will be moved to the main profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All the objects in the <c>ProfileToBeMerged</c> will be moved to the main profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All the <c>ProfileToBeMerged</c> will be deleted at the end.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All the profileKeys in the <c>ProfileIdsToBeMerged</c> will be moved to the main profile.
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
        /// If no <c>SourceProfileIds</c> entry is specified, the main Profile value is always
        /// taken. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a <c>SourceProfileIds</c> entry is specified, the specified profileId is always
        /// taken, even if it is a NULL value.
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
        /// keys. A search key is a data type pair that consists of a <c>KeyName</c> and <c>Values</c>
        /// list.
        /// 
        ///  
        /// <para>
        /// This operation supports searching for profiles with a minimum of 1 key-value(s) pair
        /// and up to 5 key-value(s) pairs using either <c>AND</c> or <c>OR</c> logic.
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
        
        #region  StartUploadJob


        /// <summary>
        /// This API starts the processing of an upload job to ingest profile data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUploadJob service method.</param>
        /// 
        /// <returns>The response from the StartUploadJob service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StartUploadJob">REST API Reference for StartUploadJob Operation</seealso>
        StartUploadJobResponse StartUploadJob(StartUploadJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartUploadJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartUploadJob operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartUploadJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StartUploadJob">REST API Reference for StartUploadJob Operation</seealso>
        IAsyncResult BeginStartUploadJob(StartUploadJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartUploadJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartUploadJob.</param>
        /// 
        /// <returns>Returns a  StartUploadJobResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StartUploadJob">REST API Reference for StartUploadJob Operation</seealso>
        StartUploadJobResponse EndStartUploadJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopUploadJob


        /// <summary>
        /// This API stops the processing of an upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopUploadJob service method.</param>
        /// 
        /// <returns>The response from the StopUploadJob service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StopUploadJob">REST API Reference for StopUploadJob Operation</seealso>
        StopUploadJobResponse StopUploadJob(StopUploadJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopUploadJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopUploadJob operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopUploadJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StopUploadJob">REST API Reference for StopUploadJob Operation</seealso>
        IAsyncResult BeginStopUploadJob(StopUploadJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopUploadJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopUploadJob.</param>
        /// 
        /// <returns>Returns a  StopUploadJobResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StopUploadJob">REST API Reference for StopUploadJob Operation</seealso>
        StopUploadJobResponse EndStopUploadJob(IAsyncResult asyncResult);

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
        /// resolution</a>: set <c>Matching</c> to true.
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
        
        #region  UpdateDomainLayout


        /// <summary>
        /// Updates the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainLayout service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainLayout service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateDomainLayout">REST API Reference for UpdateDomainLayout Operation</seealso>
        UpdateDomainLayoutResponse UpdateDomainLayout(UpdateDomainLayoutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainLayout operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainLayout operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainLayout
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateDomainLayout">REST API Reference for UpdateDomainLayout Operation</seealso>
        IAsyncResult BeginUpdateDomainLayout(UpdateDomainLayoutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainLayout operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainLayout.</param>
        /// 
        /// <returns>Returns a  UpdateDomainLayoutResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateDomainLayout">REST API Reference for UpdateDomainLayout Operation</seealso>
        UpdateDomainLayoutResponse EndUpdateDomainLayout(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEventTrigger


        /// <summary>
        /// Update the properties of an Event Trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventTrigger service method.</param>
        /// 
        /// <returns>The response from the UpdateEventTrigger service method, as returned by CustomerProfiles.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateEventTrigger">REST API Reference for UpdateEventTrigger Operation</seealso>
        UpdateEventTriggerResponse UpdateEventTrigger(UpdateEventTriggerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventTrigger operation on AmazonCustomerProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateEventTrigger">REST API Reference for UpdateEventTrigger Operation</seealso>
        IAsyncResult BeginUpdateEventTrigger(UpdateEventTriggerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventTrigger.</param>
        /// 
        /// <returns>Returns a  UpdateEventTriggerResult from CustomerProfiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateEventTrigger">REST API Reference for UpdateEventTrigger Operation</seealso>
        UpdateEventTriggerResponse EndUpdateEventTrigger(IAsyncResult asyncResult);

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