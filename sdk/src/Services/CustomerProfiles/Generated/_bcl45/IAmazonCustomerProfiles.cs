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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICustomerProfilesPaginatorFactory Paginators { get; }

        
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
        /// Associates a new key value with a specific profile, such as a Contact Record ContactId.
        /// 
        ///  
        /// <para>
        /// A profile object can have a single unique key and any number of additional keys that
        /// can be used to identify the profile that it belongs to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddProfileKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AddProfileKeyResponse> AddProfileKeyAsync(AddProfileKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCalculatedAttributeForProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchGetCalculatedAttributeForProfileResponse> BatchGetCalculatedAttributeForProfileAsync(BatchGetCalculatedAttributeForProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get a batch of profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchGetProfileResponse> BatchGetProfileAsync(BatchGetProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new calculated attribute definition. After creation, new object data ingested
        /// into Customer Profiles will be included in the calculated attribute, which can be
        /// retrieved for a profile using the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetCalculatedAttributeForProfile.html">GetCalculatedAttributeForProfile</a>
        /// API. Defining a calculated attribute makes it available for all profiles within a
        /// domain. Each calculated attribute can only reference one <c>ObjectType</c> and at
        /// most, two fields from that <c>ObjectType</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateCalculatedAttributeDefinitionResponse> CreateCalculatedAttributeDefinitionAsync(CreateCalculatedAttributeDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates the layout to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDomainLayoutResponse> CreateDomainLayoutAsync(CreateDomainLayoutRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateEventStreamResponse> CreateEventStreamAsync(CreateEventStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateEventTriggerResponse> CreateEventTriggerAsync(CreateEventTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an integration workflow. An integration workflow is an async process which
        /// ingests historic data and sets up an integration for ongoing updates. The supported
        /// Amazon AppFlow sources are Salesforce, ServiceNow, and Marketo.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateIntegrationWorkflowResponse> CreateIntegrationWorkflowAsync(CreateIntegrationWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a standard profile.
        /// 
        ///  
        /// <para>
        /// A standard profile represents the following attributes for a customer profile in a
        /// domain.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a segment definition associated to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSegmentDefinitionResponse> CreateSegmentDefinitionAsync(CreateSegmentDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSegmentEstimateResponse> CreateSegmentEstimateAsync(CreateSegmentEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Triggers a job to export a segment to a specified destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSegmentSnapshotResponse> CreateSegmentSnapshotAsync(CreateSegmentSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an Upload job to ingest data for segment imports. The metadata is created
        /// for the job with the provided field mapping and unique key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateUploadJobResponse> CreateUploadJobAsync(CreateUploadJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an existing calculated attribute definition. Note that deleting a default
        /// calculated attribute is possible, however once deleted, you will be unable to undo
        /// that action and will need to recreate it on your own using the CreateCalculatedAttributeDefinition
        /// API if you want it back.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteCalculatedAttributeDefinitionResponse> DeleteCalculatedAttributeDefinitionAsync(DeleteCalculatedAttributeDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a specific domain and all of its customer data, such as customer profile attributes
        /// and their related objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDomainLayoutResponse> DeleteDomainLayoutAsync(DeleteDomainLayoutRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disables and deletes the specified event stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteEventStreamResponse> DeleteEventStreamAsync(DeleteEventStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disable and deletes the Event Trigger.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an Event Trigger with an active Integration associated.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteEventTriggerResponse> DeleteEventTriggerAsync(DeleteEventTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes an integration from a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the standard customer profile and all data pertaining to the profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a searchable key from a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteProfileKeyResponse> DeleteProfileKeyAsync(DeleteProfileKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes an object associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteProfileObjectResponse> DeleteProfileObjectAsync(DeleteProfileObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a ProfileObjectType from a specific domain as well as removes all the ProfileObjects
        /// of that type. It also disables integrations from this specific ProfileObjectType.
        /// In addition, it scrubs all of the fields of the standard profile that were populated
        /// from this ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteProfileObjectTypeResponse> DeleteProfileObjectTypeAsync(DeleteProfileObjectTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegmentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteSegmentDefinitionResponse> DeleteSegmentDefinitionAsync(DeleteSegmentDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified workflow and all its corresponding resources. This is an async
        /// process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The process of detecting profile object type mapping by using given objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DetectProfileObjectTypeResponse> DetectProfileObjectTypeAsync(DetectProfileObjectTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAutoMergingPreviewResponse> GetAutoMergingPreviewAsync(GetAutoMergingPreviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides more information on a calculated attribute definition for Customer Profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetCalculatedAttributeDefinitionResponse> GetCalculatedAttributeDefinitionAsync(GetCalculatedAttributeDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieve a calculated attribute for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeForProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetCalculatedAttributeForProfileResponse> GetCalculatedAttributeForProfileAsync(GetCalculatedAttributeForProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets the layout to view data for a specific domain. This API can only be invoked from
        /// the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDomainLayoutResponse> GetDomainLayoutAsync(GetDomainLayoutRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the specified event stream in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEventStreamResponse> GetEventStreamAsync(GetEventStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get a specific Event Trigger from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEventTriggerResponse> GetEventTriggerAsync(GetEventTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetIdentityResolutionJobResponse> GetIdentityResolutionJobAsync(GetIdentityResolutionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns an integration for a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMatchesResponse> GetMatchesAsync(GetMatchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a history record for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileHistoryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetProfileHistoryRecordResponse> GetProfileHistoryRecordAsync(GetProfileHistoryRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the object types for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetProfileObjectTypeResponse> GetProfileObjectTypeAsync(GetProfileObjectTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetProfileObjectTypeTemplateResponse> GetProfileObjectTypeTemplateAsync(GetProfileObjectTypeTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSegmentDefinitionResponse> GetSegmentDefinitionAsync(GetSegmentDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets the result of a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSegmentEstimateResponse> GetSegmentEstimateAsync(GetSegmentEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Determines if the given profiles are within a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSegmentMembershipResponse> GetSegmentMembershipAsync(GetSegmentMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieve the latest status of a segment snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSegmentSnapshotResponse> GetSegmentSnapshotAsync(GetSegmentSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a set of profiles that belong to the same matching group using the <c>matchId</c>
        /// or <c>profileId</c>. You can also specify the type of matching that you want for finding
        /// similar profiles using either <c>RULE_BASED_MATCHING</c> or <c>ML_BASED_MATCHING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSimilarProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSimilarProfilesResponse> GetSimilarProfilesAsync(GetSimilarProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This API retrieves the details of a specific upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUploadJobResponse> GetUploadJobAsync(GetUploadJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This API retrieves the pre-signed URL and client token for uploading the file associated
        /// with the upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJobPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUploadJobPathResponse> GetUploadJobPathAsync(GetUploadJobPathRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get details of specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get granular list of steps in workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetWorkflowStepsResponse> GetWorkflowStepsAsync(GetWorkflowStepsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all of the integrations associated to a specific URI in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccountIntegrationsResponse> ListAccountIntegrationsAsync(ListAccountIntegrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists calculated attribute definitions for Customer Profiles
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributeDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCalculatedAttributeDefinitionsResponse> ListCalculatedAttributeDefinitionsAsync(ListCalculatedAttributeDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieve a list of calculated attributes for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributesForProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCalculatedAttributesForProfileResponse> ListCalculatedAttributesForProfileAsync(ListCalculatedAttributesForProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the existing layouts that can be used to view data for a specific domain. This
        /// API can only be invoked from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainLayouts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDomainLayoutsResponse> ListDomainLayoutsAsync(ListDomainLayoutsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of all the domains for an AWS account that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of all the event streams in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListEventStreamsResponse> ListEventStreamsAsync(ListEventStreamsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// List all Event Triggers under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTriggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListEventTriggersResponse> ListEventTriggersAsync(ListEventTriggersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all of the Identity Resolution Jobs in your domain. The response sorts the list
        /// by <c>JobStartTime</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityResolutionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListIdentityResolutionJobsResponse> ListIdentityResolutionJobsAsync(ListIdentityResolutionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all of the integrations in your domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectTypeAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListObjectTypeAttributesResponse> ListObjectTypeAttributesAsync(ListObjectTypeAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAttributeValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListProfileAttributeValuesResponse> ListProfileAttributeValuesAsync(ListProfileAttributeValuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of history records for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileHistoryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListProfileHistoryRecordsResponse> ListProfileHistoryRecordsAsync(ListProfileHistoryRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of objects associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListProfileObjectsResponse> ListProfileObjectsAsync(ListProfileObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all of the templates available within the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListProfileObjectTypesResponse> ListProfileObjectTypesAsync(ListProfileObjectTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all of the template information for object types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypeTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListProfileObjectTypeTemplatesResponse> ListProfileObjectTypeTemplatesAsync(ListProfileObjectTypeTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a set of <c>MatchIds</c> that belong to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleBasedMatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRuleBasedMatchesResponse> ListRuleBasedMatchesAsync(ListRuleBasedMatchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all segment definitions under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSegmentDefinitionsResponse> ListSegmentDefinitionsAsync(ListSegmentDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Displays the tags associated with an Amazon Connect Customer Profiles resource. In
        /// Connect Customer Profiles, domains, profile object types, and integrations can be
        /// tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This API retrieves a list of upload jobs for the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUploadJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListUploadJobsResponse> ListUploadJobsAsync(ListUploadJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Query to list all workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<MergeProfilesResponse> MergeProfilesAsync(MergeProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutIntegrationResponse> PutIntegrationAsync(PutIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutProfileObjectResponse> PutProfileObjectAsync(PutProfileObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Defines a ProfileObjectType.
        /// 
        ///  
        /// <para>
        /// To add or remove tags on an existing ObjectType, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">
        /// TagResource</a>/<a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutProfileObjectTypeResponse> PutProfileObjectTypeAsync(PutProfileObjectTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SearchProfilesResponse> SearchProfilesAsync(SearchProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This API starts the processing of an upload job to ingest profile data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartUploadJobResponse> StartUploadJobAsync(StartUploadJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This API stops the processing of an upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopUploadJobResponse> StopUploadJobAsync(StopUploadJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes one or more tags from the specified Amazon Connect Customer Profiles resource.
        /// In Connect Customer Profiles, domains, profile object types, and integrations can
        /// be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing calculated attribute definition. When updating the Conditions,
        /// note that increasing the date range of a calculated attribute will not trigger inclusion
        /// of historical data greater than the current date range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateCalculatedAttributeDefinitionResponse> UpdateCalculatedAttributeDefinitionAsync(UpdateCalculatedAttributeDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDomainLayoutResponse> UpdateDomainLayoutAsync(UpdateDomainLayoutRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Update the properties of an Event Trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateEventTriggerResponse> UpdateEventTriggerAsync(UpdateEventTriggerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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