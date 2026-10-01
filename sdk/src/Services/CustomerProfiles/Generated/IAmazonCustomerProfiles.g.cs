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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Connect Customer Customer Profiles <ul> <li> 
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
    /// Connect Customer Customer Profiles is a unified customer profile for your contact
    /// center that has pre-built connectors powered by AppFlow that make it easy to combine
    /// customer information from third party applications, such as Salesforce (CRM), ServiceNow
    /// (ITSM), and your enterprise resource planning (ERP), with contact history from your
    /// Connect Customer contact center. 
    /// </para>
    ///  
    /// <para>
    /// For more information about the Connect Customer Customer Profiles feature, see <a
    /// href="https://docs.aws.amazon.com/connect/latest/adminguide/customer-profiles.html">Use
    /// Customer Profiles</a> in the <i>Connect Customer Administrator's Guide</i>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonCustomerProfiles : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICustomerProfilesPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Associates an Amazon Kinesis data stream to receive segment membership events for
        /// a given domain. This is a domain-level configuration that applies to all segment subscriptions
        /// within the domain. A domain can have only one associated stream at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateStreamForSegments service method.</param>
        /// <returns>The response from the AssociateStreamForSegments service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/AssociateStreamForSegments">REST API Reference for AssociateStreamForSegments Operation</seealso>
        AssociateStreamForSegmentsResponse AssociateStreamForSegments(AssociateStreamForSegmentsRequest request);
#endif

        /// <summary>
        /// Associates an Amazon Kinesis data stream to receive segment membership events for
        /// a given domain. This is a domain-level configuration that applies to all segment subscriptions
        /// within the domain. A domain can have only one associated stream at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateStreamForSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateStreamForSegments service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/AssociateStreamForSegments">REST API Reference for AssociateStreamForSegments Operation</seealso>
        Task<AssociateStreamForSegmentsResponse> AssociateStreamForSegmentsAsync(AssociateStreamForSegmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCalculatedAttributeForProfile service method.</param>
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
#endif

        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCalculatedAttributeForProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Get a batch of profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProfile service method.</param>
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
#endif

        /// <summary>
        /// Get a batch of profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Adds multiple profile objects to a domain of a given ObjectType in a single API call.
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
        /// BatchPutProfileObject needs an ObjectType, which can be created using PutProfileObjectType.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutProfileObject service method.</param>
        /// <returns>The response from the BatchPutProfileObject service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchPutProfileObject">REST API Reference for BatchPutProfileObject Operation</seealso>
        BatchPutProfileObjectResponse BatchPutProfileObject(BatchPutProfileObjectRequest request);
#endif

        /// <summary>
        /// Adds multiple profile objects to a domain of a given ObjectType in a single API call.
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
        /// BatchPutProfileObject needs an ObjectType, which can be created using PutProfileObjectType.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutProfileObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the BatchPutProfileObject service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/BatchPutProfileObject">REST API Reference for BatchPutProfileObject Operation</seealso>
        Task<BatchPutProfileObjectResponse> BatchPutProfileObjectAsync(BatchPutProfileObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new calculated attribute definition. After creation, new object data ingested
        /// into Customer Profiles will be included in the calculated attribute, which can be
        /// retrieved for a profile using the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetCalculatedAttributeForProfile.html">GetCalculatedAttributeForProfile</a>
        /// API. Defining a calculated attribute makes it available for all profiles within a
        /// domain. Each calculated attribute can only reference one <c>ObjectType</c> and at
        /// most, two fields from that <c>ObjectType</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCalculatedAttributeDefinition service method.</param>
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Creates a domain, which is a container for all customer data, such as customer profile
        /// attributes, object types, profile keys, and encryption keys. You can create multiple
        /// domains, and each domain can have multiple third-party integrations.
        /// 
        ///  
        /// <para>
        /// Each Connect Customer instance can be associated with only one domain. Multiple Connect
        /// Customer instances can be associated with one domain.
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
#endif

        /// <summary>
        /// Creates a domain, which is a container for all customer data, such as customer profile
        /// attributes, object types, profile keys, and encryption keys. You can create multiple
        /// domains, and each domain can have multiple third-party integrations.
        /// 
        ///  
        /// <para>
        /// Each Connect Customer instance can be associated with only one domain. Multiple Connect
        /// Customer instances can be associated with one domain.
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

#if NETFRAMEWORK
        /// <summary>
        /// Creates the layout to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainLayout service method.</param>
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
#endif

        /// <summary>
        /// Creates the layout to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Creates an event stream, which is a subscription to real-time events, such as when
        /// profiles are created and updated through Connect Customer Customer Profiles.
        /// 
        ///  
        /// <para>
        /// Each event stream can be associated with only one Kinesis Data Stream destination
        /// in the same region and Amazon Web Services account as the customer profiles domain
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventStream service method.</param>
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
#endif

        /// <summary>
        /// Creates an event stream, which is a subscription to real-time events, such as when
        /// profiles are created and updated through Connect Customer Customer Profiles.
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Creates an integration workflow. An integration workflow is an async process which
        /// ingests historic data and sets up an integration for ongoing updates. The supported
        /// Amazon AppFlow sources are Salesforce, ServiceNow, and Marketo.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationWorkflow service method.</param>
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
#endif

        /// <summary>
        /// Creates an integration workflow. An integration workflow is an async process which
        /// ingests historic data and sets up an integration for ongoing updates. The supported
        /// Amazon AppFlow sources are Salesforce, ServiceNow, and Marketo.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Creates a recommender
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommender service method.</param>
        /// <returns>The response from the CreateRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateRecommender">REST API Reference for CreateRecommender Operation</seealso>
        CreateRecommenderResponse CreateRecommender(CreateRecommenderRequest request);
#endif

        /// <summary>
        /// Creates a recommender
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateRecommender">REST API Reference for CreateRecommender Operation</seealso>
        Task<CreateRecommenderResponse> CreateRecommenderAsync(CreateRecommenderRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a recommender filter. A recommender filter specifies which items to include
        /// or exclude from recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommenderFilter service method.</param>
        /// <returns>The response from the CreateRecommenderFilter service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateRecommenderFilter">REST API Reference for CreateRecommenderFilter Operation</seealso>
        CreateRecommenderFilterResponse CreateRecommenderFilter(CreateRecommenderFilterRequest request);
#endif

        /// <summary>
        /// Creates a recommender filter. A recommender filter specifies which items to include
        /// or exclude from recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommenderFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRecommenderFilter service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateRecommenderFilter">REST API Reference for CreateRecommenderFilter Operation</seealso>
        Task<CreateRecommenderFilterResponse> CreateRecommenderFilterAsync(CreateRecommenderFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a recommender schema. A recommender schema defines the set of data columns
        /// available for training recommenders and filters under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommenderSchema service method.</param>
        /// <returns>The response from the CreateRecommenderSchema service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateRecommenderSchema">REST API Reference for CreateRecommenderSchema Operation</seealso>
        CreateRecommenderSchemaResponse CreateRecommenderSchema(CreateRecommenderSchemaRequest request);
#endif

        /// <summary>
        /// Creates a recommender schema. A recommender schema defines the set of data columns
        /// available for training recommenders and filters under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommenderSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRecommenderSchema service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/CreateRecommenderSchema">REST API Reference for CreateRecommenderSchema Operation</seealso>
        Task<CreateRecommenderSchemaResponse> CreateRecommenderSchemaAsync(CreateRecommenderSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a segment definition associated to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentDefinition service method.</param>
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
#endif

        /// <summary>
        /// Creates a segment definition associated to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Creates a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentEstimate service method.</param>
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
#endif

        /// <summary>
        /// Creates a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Triggers a job to export a segment to a specified destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentSnapshot service method.</param>
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
#endif

        /// <summary>
        /// Triggers a job to export a segment to a specified destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegmentSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Upload job to ingest data for segment imports. The metadata is created
        /// for the job with the provided field mapping and unique key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadJob service method.</param>
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
#endif

        /// <summary>
        /// Creates an Upload job to ingest data for segment imports. The metadata is created
        /// for the job with the provided field mapping and unique key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an existing calculated attribute definition. Note that deleting a default
        /// calculated attribute is possible, however once deleted, you will be unable to undo
        /// that action and will need to recreate it on your own using the CreateCalculatedAttributeDefinition
        /// API if you want it back.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCalculatedAttributeDefinition service method.</param>
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a specific domain and all of its customer data, such as customer profile attributes
        /// and their related objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
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
#endif

        /// <summary>
        /// Deletes a specific domain and all of its customer data, such as customer profile attributes
        /// and their related objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainLayout service method.</param>
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
#endif

        /// <summary>
        /// Deletes the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Delete a DomainObjectType for the given Domain and ObjectType name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainObjectType service method.</param>
        /// <returns>The response from the DeleteDomainObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomainObjectType">REST API Reference for DeleteDomainObjectType Operation</seealso>
        DeleteDomainObjectTypeResponse DeleteDomainObjectType(DeleteDomainObjectTypeRequest request);
#endif

        /// <summary>
        /// Delete a DomainObjectType for the given Domain and ObjectType name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDomainObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteDomainObjectType">REST API Reference for DeleteDomainObjectType Operation</seealso>
        Task<DeleteDomainObjectTypeResponse> DeleteDomainObjectTypeAsync(DeleteDomainObjectTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disables and deletes the specified event stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
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
#endif

        /// <summary>
        /// Disables and deletes the specified event stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Removes an integration from a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
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
#endif

        /// <summary>
        /// Removes an integration from a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the standard customer profile and all data pertaining to the profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
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
#endif

        /// <summary>
        /// Deletes the standard customer profile and all data pertaining to the profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Removes a searchable key from a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileKey service method.</param>
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
#endif

        /// <summary>
        /// Removes a searchable key from a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Removes an object associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObject service method.</param>
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
#endif

        /// <summary>
        /// Removes an object associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Removes a ProfileObjectType from a specific domain as well as removes all the ProfileObjects
        /// of that type. It also disables integrations from this specific ProfileObjectType.
        /// In addition, it scrubs all of the fields of the standard profile that were populated
        /// from this ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileObjectType service method.</param>
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a recommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommender service method.</param>
        /// <returns>The response from the DeleteRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteRecommender">REST API Reference for DeleteRecommender Operation</seealso>
        DeleteRecommenderResponse DeleteRecommender(DeleteRecommenderRequest request);
#endif

        /// <summary>
        /// Deletes a recommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteRecommender">REST API Reference for DeleteRecommender Operation</seealso>
        Task<DeleteRecommenderResponse> DeleteRecommenderAsync(DeleteRecommenderRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a recommender filter from a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommenderFilter service method.</param>
        /// <returns>The response from the DeleteRecommenderFilter service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteRecommenderFilter">REST API Reference for DeleteRecommenderFilter Operation</seealso>
        DeleteRecommenderFilterResponse DeleteRecommenderFilter(DeleteRecommenderFilterRequest request);
#endif

        /// <summary>
        /// Deletes a recommender filter from a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommenderFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRecommenderFilter service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteRecommenderFilter">REST API Reference for DeleteRecommenderFilter Operation</seealso>
        Task<DeleteRecommenderFilterResponse> DeleteRecommenderFilterAsync(DeleteRecommenderFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a recommender schema from a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommenderSchema service method.</param>
        /// <returns>The response from the DeleteRecommenderSchema service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteRecommenderSchema">REST API Reference for DeleteRecommenderSchema Operation</seealso>
        DeleteRecommenderSchemaResponse DeleteRecommenderSchema(DeleteRecommenderSchemaRequest request);
#endif

        /// <summary>
        /// Deletes a recommender schema from a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommenderSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRecommenderSchema service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteRecommenderSchema">REST API Reference for DeleteRecommenderSchema Operation</seealso>
        Task<DeleteRecommenderSchemaResponse> DeleteRecommenderSchemaAsync(DeleteRecommenderSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegmentDefinition service method.</param>
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
#endif

        /// <summary>
        /// Deletes a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegmentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a segment subscription for membership events. All active event notifications
        /// for this segment are stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegmentSubscription service method.</param>
        /// <returns>The response from the DeleteSegmentSubscription service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteSegmentSubscription">REST API Reference for DeleteSegmentSubscription Operation</seealso>
        DeleteSegmentSubscriptionResponse DeleteSegmentSubscription(DeleteSegmentSubscriptionRequest request);
#endif

        /// <summary>
        /// Deletes a segment subscription for membership events. All active event notifications
        /// for this segment are stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegmentSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteSegmentSubscription service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DeleteSegmentSubscription">REST API Reference for DeleteSegmentSubscription Operation</seealso>
        Task<DeleteSegmentSubscriptionResponse> DeleteSegmentSubscriptionAsync(DeleteSegmentSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified workflow and all its corresponding resources. This is an async
        /// process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
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
#endif

        /// <summary>
        /// Deletes the specified workflow and all its corresponding resources. This is an async
        /// process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// The process of detecting profile object type mapping by using given objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectProfileObjectType service method.</param>
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
#endif

        /// <summary>
        /// The process of detecting profile object type mapping by using given objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Disassociates the Amazon Kinesis data stream configured for segment membership events.
        /// All active segment subscriptions delivering events to this stream are eventually stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateStreamForSegments service method.</param>
        /// <returns>The response from the DisassociateStreamForSegments service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DisassociateStreamForSegments">REST API Reference for DisassociateStreamForSegments Operation</seealso>
        DisassociateStreamForSegmentsResponse DisassociateStreamForSegments(DisassociateStreamForSegmentsRequest request);
#endif

        /// <summary>
        /// Disassociates the Amazon Kinesis data stream configured for segment membership events.
        /// All active segment subscriptions delivering events to this stream are eventually stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateStreamForSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateStreamForSegments service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/DisassociateStreamForSegments">REST API Reference for DisassociateStreamForSegments Operation</seealso>
        Task<DisassociateStreamForSegmentsResponse> DisassociateStreamForSegmentsAsync(DisassociateStreamForSegmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Provides more information on a calculated attribute definition for Customer Profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeDefinition service method.</param>
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
#endif

        /// <summary>
        /// Provides more information on a calculated attribute definition for Customer Profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Retrieve a calculated attribute for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeForProfile service method.</param>
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
#endif

        /// <summary>
        /// Retrieve a calculated attribute for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculatedAttributeForProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
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
#endif

        /// <summary>
        /// Returns information about a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Gets the layout to view data for a specific domain. This API can only be invoked from
        /// the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainLayout service method.</param>
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
#endif

        /// <summary>
        /// Gets the layout to view data for a specific domain. This API can only be invoked from
        /// the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Return a DomainObjectType for the input Domain and ObjectType names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainObjectType service method.</param>
        /// <returns>The response from the GetDomainObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomainObjectType">REST API Reference for GetDomainObjectType Operation</seealso>
        GetDomainObjectTypeResponse GetDomainObjectType(GetDomainObjectTypeRequest request);
#endif

        /// <summary>
        /// Return a DomainObjectType for the input Domain and ObjectType names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDomainObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetDomainObjectType">REST API Reference for GetDomainObjectType Operation</seealso>
        Task<GetDomainObjectTypeResponse> GetDomainObjectTypeAsync(GetDomainObjectTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the specified event stream in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
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
#endif

        /// <summary>
        /// Returns information about the specified event stream in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Get a specific Event Trigger from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventTrigger service method.</param>
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
#endif

        /// <summary>
        /// Get a specific Event Trigger from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Returns an integration for a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
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
#endif

        /// <summary>
        /// Returns an integration for a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// The GetObjectTypeAttributeValues API delivers statistical insights about attributes
        /// within a specific object type, but is exclusively available for domains with data
        /// store enabled. This API performs daily calculations to provide statistical information
        /// about your attribute values, helping you understand patterns and trends in your data.
        /// The statistical calculations are performed once per day, providing a consistent snapshot
        /// of your attribute data characteristics.
        /// 
        ///  <note> 
        /// <para>
        /// You'll receive null values in two scenarios: 
        /// </para>
        ///  
        /// <para>
        /// During the first period after enabling data vault (unless a calculation cycle occurs,
        /// which happens once daily).
        /// </para>
        ///  
        /// <para>
        /// For attributes that don't contain numeric values. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTypeAttributeStatistics service method.</param>
        /// <returns>The response from the GetObjectTypeAttributeStatistics service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetObjectTypeAttributeStatistics">REST API Reference for GetObjectTypeAttributeStatistics Operation</seealso>
        GetObjectTypeAttributeStatisticsResponse GetObjectTypeAttributeStatistics(GetObjectTypeAttributeStatisticsRequest request);
#endif

        /// <summary>
        /// The GetObjectTypeAttributeValues API delivers statistical insights about attributes
        /// within a specific object type, but is exclusively available for domains with data
        /// store enabled. This API performs daily calculations to provide statistical information
        /// about your attribute values, helping you understand patterns and trends in your data.
        /// The statistical calculations are performed once per day, providing a consistent snapshot
        /// of your attribute data characteristics.
        /// 
        ///  <note> 
        /// <para>
        /// You'll receive null values in two scenarios: 
        /// </para>
        ///  
        /// <para>
        /// During the first period after enabling data vault (unless a calculation cycle occurs,
        /// which happens once daily).
        /// </para>
        ///  
        /// <para>
        /// For attributes that don't contain numeric values. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTypeAttributeStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetObjectTypeAttributeStatistics service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetObjectTypeAttributeStatistics">REST API Reference for GetObjectTypeAttributeStatistics Operation</seealso>
        Task<GetObjectTypeAttributeStatisticsResponse> GetObjectTypeAttributeStatisticsAsync(GetObjectTypeAttributeStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a history record for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileHistoryRecord service method.</param>
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
#endif

        /// <summary>
        /// Returns a history record for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileHistoryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Returns the object types for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileObjectType service method.</param>
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
#endif

        /// <summary>
        /// Returns the object types for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Fetches the recommendations for a profile in the input Customer Profiles domain. Fetches
        /// all the profile recommendations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileRecommendations service method.</param>
        /// <returns>The response from the GetProfileRecommendations service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileRecommendations">REST API Reference for GetProfileRecommendations Operation</seealso>
        GetProfileRecommendationsResponse GetProfileRecommendations(GetProfileRecommendationsRequest request);
#endif

        /// <summary>
        /// Fetches the recommendations for a profile in the input Customer Profiles domain. Fetches
        /// all the profile recommendations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProfileRecommendations service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetProfileRecommendations">REST API Reference for GetProfileRecommendations Operation</seealso>
        Task<GetProfileRecommendationsResponse> GetProfileRecommendationsAsync(GetProfileRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a recommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommender service method.</param>
        /// <returns>The response from the GetRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetRecommender">REST API Reference for GetRecommender Operation</seealso>
        GetRecommenderResponse GetRecommender(GetRecommenderRequest request);
#endif

        /// <summary>
        /// Retrieves a recommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetRecommender">REST API Reference for GetRecommender Operation</seealso>
        Task<GetRecommenderResponse> GetRecommenderAsync(GetRecommenderRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a specific recommender filter in a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderFilter service method.</param>
        /// <returns>The response from the GetRecommenderFilter service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetRecommenderFilter">REST API Reference for GetRecommenderFilter Operation</seealso>
        GetRecommenderFilterResponse GetRecommenderFilter(GetRecommenderFilterRequest request);
#endif

        /// <summary>
        /// Retrieves information about a specific recommender filter in a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRecommenderFilter service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetRecommenderFilter">REST API Reference for GetRecommenderFilter Operation</seealso>
        Task<GetRecommenderFilterResponse> GetRecommenderFilterAsync(GetRecommenderFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a specific recommender schema in a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderSchema service method.</param>
        /// <returns>The response from the GetRecommenderSchema service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetRecommenderSchema">REST API Reference for GetRecommenderSchema Operation</seealso>
        GetRecommenderSchemaResponse GetRecommenderSchema(GetRecommenderSchemaRequest request);
#endif

        /// <summary>
        /// Retrieves information about a specific recommender schema in a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRecommenderSchema service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetRecommenderSchema">REST API Reference for GetRecommenderSchema Operation</seealso>
        Task<GetRecommenderSchemaResponse> GetRecommenderSchemaAsync(GetRecommenderSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentDefinition service method.</param>
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
#endif

        /// <summary>
        /// Gets a segment definition from the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Gets the result of a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentEstimate service method.</param>
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
#endif

        /// <summary>
        /// Gets the result of a segment estimate query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Determines if the given profiles are within a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentMembership service method.</param>
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
#endif

        /// <summary>
        /// Determines if the given profiles are within a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Retrieve the latest status of a segment snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentSnapshot service method.</param>
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
#endif

        /// <summary>
        /// Retrieve the latest status of a segment snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Returns the current subscription configuration, execution schedule, and status for
        /// segment membership events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentSubscription service method.</param>
        /// <returns>The response from the GetSegmentSubscription service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentSubscription">REST API Reference for GetSegmentSubscription Operation</seealso>
        GetSegmentSubscriptionResponse GetSegmentSubscription(GetSegmentSubscriptionRequest request);
#endif

        /// <summary>
        /// Returns the current subscription configuration, execution schedule, and status for
        /// segment membership events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetSegmentSubscription service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetSegmentSubscription">REST API Reference for GetSegmentSubscription Operation</seealso>
        Task<GetSegmentSubscriptionResponse> GetSegmentSubscriptionAsync(GetSegmentSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a set of profiles that belong to the same matching group using the <c>matchId</c>
        /// or <c>profileId</c>. You can also specify the type of matching that you want for finding
        /// similar profiles using either <c>RULE_BASED_MATCHING</c> or <c>ML_BASED_MATCHING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSimilarProfiles service method.</param>
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
#endif

        /// <summary>
        /// Returns a set of profiles that belong to the same matching group using the <c>matchId</c>
        /// or <c>profileId</c>. You can also specify the type of matching that you want for finding
        /// similar profiles using either <c>RULE_BASED_MATCHING</c> or <c>ML_BASED_MATCHING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSimilarProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about the segment membership event stream configured for a specific
        /// domain, including the stream state and associated segments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamForSegments service method.</param>
        /// <returns>The response from the GetStreamForSegments service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetStreamForSegments">REST API Reference for GetStreamForSegments Operation</seealso>
        GetStreamForSegmentsResponse GetStreamForSegments(GetStreamForSegmentsRequest request);
#endif

        /// <summary>
        /// Returns information about the segment membership event stream configured for a specific
        /// domain, including the stream state and associated segments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamForSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetStreamForSegments service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/GetStreamForSegments">REST API Reference for GetStreamForSegments Operation</seealso>
        Task<GetStreamForSegmentsResponse> GetStreamForSegmentsAsync(GetStreamForSegmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This API retrieves the details of a specific upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJob service method.</param>
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
#endif

        /// <summary>
        /// This API retrieves the details of a specific upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// This API retrieves the pre-signed URL and client token for uploading the file associated
        /// with the upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJobPath service method.</param>
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
#endif

        /// <summary>
        /// This API retrieves the pre-signed URL and client token for uploading the file associated
        /// with the upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadJobPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Get details of specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
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
#endif

        /// <summary>
        /// Get details of specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Get granular list of steps in workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowSteps service method.</param>
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
#endif

        /// <summary>
        /// Get granular list of steps in workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists all of the integrations associated to a specific URI in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountIntegrations service method.</param>
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
#endif

        /// <summary>
        /// Lists all of the integrations associated to a specific URI in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists calculated attribute definitions for Customer Profiles
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributeDefinitions service method.</param>
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
#endif

        /// <summary>
        /// Lists calculated attribute definitions for Customer Profiles
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributeDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Retrieve a list of calculated attributes for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributesForProfile service method.</param>
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
#endif

        /// <summary>
        /// Retrieve a list of calculated attributes for a customer profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculatedAttributesForProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists the existing layouts that can be used to view data for a specific domain. This
        /// API can only be invoked from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainLayouts service method.</param>
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
#endif

        /// <summary>
        /// Lists the existing layouts that can be used to view data for a specific domain. This
        /// API can only be invoked from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainLayouts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// List all DomainObjectType(s) in a Customer Profiles domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainObjectTypes service method.</param>
        /// <returns>The response from the ListDomainObjectTypes service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomainObjectTypes">REST API Reference for ListDomainObjectTypes Operation</seealso>
        ListDomainObjectTypesResponse ListDomainObjectTypes(ListDomainObjectTypesRequest request);
#endif

        /// <summary>
        /// List all DomainObjectType(s) in a Customer Profiles domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainObjectTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDomainObjectTypes service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListDomainObjectTypes">REST API Reference for ListDomainObjectTypes Operation</seealso>
        Task<ListDomainObjectTypesResponse> ListDomainObjectTypesAsync(ListDomainObjectTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of all the domains for an AWS account that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
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
#endif

        /// <summary>
        /// Returns a list of all the domains for an AWS account that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of all the event streams in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventStreams service method.</param>
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
#endif

        /// <summary>
        /// Returns a list of all the event streams in a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// List all Event Triggers under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTriggers service method.</param>
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
#endif

        /// <summary>
        /// List all Event Triggers under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTriggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists all of the Identity Resolution Jobs in your domain. The response sorts the list
        /// by <c>JobStartTime</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityResolutionJobs service method.</param>
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
#endif

        /// <summary>
        /// Lists all of the Identity Resolution Jobs in your domain. The response sorts the list
        /// by <c>JobStartTime</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityResolutionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists all of the integrations in your domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
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
#endif

        /// <summary>
        /// Lists all of the integrations in your domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// The ListObjectTypeAttributeValues API provides access to the most recent distinct
        /// values for any specified attribute, making it valuable for real-time data validation
        /// and consistency checks within your object types. This API works across domain, supporting
        /// both custom and standard object types. The API accepts the object type name, attribute
        /// name, and domain name as input parameters and returns values up to the storage limit
        /// of approximately 350KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectTypeAttributeValues service method.</param>
        /// <returns>The response from the ListObjectTypeAttributeValues service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListObjectTypeAttributeValues">REST API Reference for ListObjectTypeAttributeValues Operation</seealso>
        ListObjectTypeAttributeValuesResponse ListObjectTypeAttributeValues(ListObjectTypeAttributeValuesRequest request);
#endif

        /// <summary>
        /// The ListObjectTypeAttributeValues API provides access to the most recent distinct
        /// values for any specified attribute, making it valuable for real-time data validation
        /// and consistency checks within your object types. This API works across domain, supporting
        /// both custom and standard object types. The API accepts the object type name, attribute
        /// name, and domain name as input parameters and returns values up to the storage limit
        /// of approximately 350KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectTypeAttributeValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListObjectTypeAttributeValues service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListObjectTypeAttributeValues">REST API Reference for ListObjectTypeAttributeValues Operation</seealso>
        Task<ListObjectTypeAttributeValuesResponse> ListObjectTypeAttributeValuesAsync(ListObjectTypeAttributeValuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectTypeAttributes service method.</param>
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
#endif

        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectTypeAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAttributeValues service method.</param>
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
#endif

        /// <summary>
        /// Fetch the possible attribute values given the attribute name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAttributeValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of history records for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileHistoryRecords service method.</param>
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
#endif

        /// <summary>
        /// Returns a list of history records for a specific profile, for a specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileHistoryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists all of the template information for object types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypeTemplates service method.</param>
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
#endif

        /// <summary>
        /// Lists all of the template information for object types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypeTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists all of the templates available within the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypes service method.</param>
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
#endif

        /// <summary>
        /// Lists all of the templates available within the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjectTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of objects associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjects service method.</param>
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
#endif

        /// <summary>
        /// Returns a list of objects associated with a profile of a given ProfileObjectType.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of recommender filters in the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenderFilters service method.</param>
        /// <returns>The response from the ListRecommenderFilters service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRecommenderFilters">REST API Reference for ListRecommenderFilters Operation</seealso>
        ListRecommenderFiltersResponse ListRecommenderFilters(ListRecommenderFiltersRequest request);
#endif

        /// <summary>
        /// Returns a list of recommender filters in the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenderFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRecommenderFilters service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRecommenderFilters">REST API Reference for ListRecommenderFilters Operation</seealso>
        Task<ListRecommenderFiltersResponse> ListRecommenderFiltersAsync(ListRecommenderFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of available recommender recipes that can be used to create recommenders.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenderRecipes service method.</param>
        /// <returns>The response from the ListRecommenderRecipes service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRecommenderRecipes">REST API Reference for ListRecommenderRecipes Operation</seealso>
        ListRecommenderRecipesResponse ListRecommenderRecipes(ListRecommenderRecipesRequest request);
#endif

        /// <summary>
        /// Returns a list of available recommender recipes that can be used to create recommenders.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenderRecipes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRecommenderRecipes service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRecommenderRecipes">REST API Reference for ListRecommenderRecipes Operation</seealso>
        Task<ListRecommenderRecipesResponse> ListRecommenderRecipesAsync(ListRecommenderRecipesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of recommender schemas in the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenderSchemas service method.</param>
        /// <returns>The response from the ListRecommenderSchemas service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRecommenderSchemas">REST API Reference for ListRecommenderSchemas Operation</seealso>
        ListRecommenderSchemasResponse ListRecommenderSchemas(ListRecommenderSchemasRequest request);
#endif

        /// <summary>
        /// Returns a list of recommender schemas in the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenderSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRecommenderSchemas service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRecommenderSchemas">REST API Reference for ListRecommenderSchemas Operation</seealso>
        Task<ListRecommenderSchemasResponse> ListRecommenderSchemasAsync(ListRecommenderSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of recommenders in the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenders service method.</param>
        /// <returns>The response from the ListRecommenders service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRecommenders">REST API Reference for ListRecommenders Operation</seealso>
        ListRecommendersResponse ListRecommenders(ListRecommendersRequest request);
#endif

        /// <summary>
        /// Returns a list of recommenders in the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommenders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRecommenders service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListRecommenders">REST API Reference for ListRecommenders Operation</seealso>
        Task<ListRecommendersResponse> ListRecommendersAsync(ListRecommendersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a set of <c>MatchIds</c> that belong to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleBasedMatches service method.</param>
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
#endif

        /// <summary>
        /// Returns a set of <c>MatchIds</c> that belong to the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleBasedMatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Lists all segment definitions under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentDefinitions service method.</param>
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
#endif

        /// <summary>
        /// Lists all segment definitions under a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Returns the most recent membership events for a segment. Each event represents a profile
        /// that entered or exited the segment. 
        /// 
        ///  
        /// <para>
        /// This operation is paginated. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentSubscriptionEvents service method.</param>
        /// <returns>The response from the ListSegmentSubscriptionEvents service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListSegmentSubscriptionEvents">REST API Reference for ListSegmentSubscriptionEvents Operation</seealso>
        ListSegmentSubscriptionEventsResponse ListSegmentSubscriptionEvents(ListSegmentSubscriptionEventsRequest request);
#endif

        /// <summary>
        /// Returns the most recent membership events for a segment. Each event represents a profile
        /// that entered or exited the segment. 
        /// 
        ///  
        /// <para>
        /// This operation is paginated. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentSubscriptionEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSegmentSubscriptionEvents service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/ListSegmentSubscriptionEvents">REST API Reference for ListSegmentSubscriptionEvents Operation</seealso>
        Task<ListSegmentSubscriptionEventsResponse> ListSegmentSubscriptionEventsAsync(ListSegmentSubscriptionEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Displays the tags associated with an Amazon Connect Customer Profiles resource. In
        /// Connect Customer Profiles, domains, profile object types, and integrations can be
        /// tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
#endif

        /// <summary>
        /// Displays the tags associated with an Amazon Connect Customer Profiles resource. In
        /// Connect Customer Profiles, domains, profile object types, and integrations can be
        /// tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// This API retrieves a list of upload jobs for the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUploadJobs service method.</param>
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
#endif

        /// <summary>
        /// This API retrieves a list of upload jobs for the specified domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUploadJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Query to list all workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
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
#endif

        /// <summary>
        /// Query to list all workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Create/Update a DomainObjectType in a Customer Profiles domain. To create a new DomainObjectType,
        /// Data Store needs to be enabled on the Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDomainObjectType service method.</param>
        /// <returns>The response from the PutDomainObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutDomainObjectType">REST API Reference for PutDomainObjectType Operation</seealso>
        PutDomainObjectTypeResponse PutDomainObjectType(PutDomainObjectTypeRequest request);
#endif

        /// <summary>
        /// Create/Update a DomainObjectType in a Customer Profiles domain. To create a new DomainObjectType,
        /// Data Store needs to be enabled on the Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDomainObjectType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutDomainObjectType service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutDomainObjectType">REST API Reference for PutDomainObjectType Operation</seealso>
        Task<PutDomainObjectTypeResponse> PutDomainObjectTypeAsync(PutDomainObjectTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Creates or updates a segment subscription for membership events. When a subscription
        /// is created, an initial snapshot is taken and the system begins monitoring for membership
        /// changes. 
        /// 
        ///  
        /// <para>
        /// You can optionally set a schedule configuration interval to control how often membership
        /// snapshots are run. The interval can be from 1 to 24 hours. If not set, the interval
        /// defaults to 24 hours. Scheduled snapshots run on a best-effort basis. If a scheduled
        /// snapshot takes longer than the configured interval, the next scheduled run does not
        /// start until the in-progress snapshot completes, so a run might be delayed or skipped
        /// and is not guaranteed to occur at exactly the requested time. 
        /// </para>
        ///  
        /// <para>
        /// For Classic segments, membership events are generated from these scheduled snapshots
        /// and also in near real-time as profile attribute changes occur. For SQL segments, membership
        /// events are generated only from the scheduled snapshots. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSegmentSubscription service method.</param>
        /// <returns>The response from the PutSegmentSubscription service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutSegmentSubscription">REST API Reference for PutSegmentSubscription Operation</seealso>
        PutSegmentSubscriptionResponse PutSegmentSubscription(PutSegmentSubscriptionRequest request);
#endif

        /// <summary>
        /// Creates or updates a segment subscription for membership events. When a subscription
        /// is created, an initial snapshot is taken and the system begins monitoring for membership
        /// changes. 
        /// 
        ///  
        /// <para>
        /// You can optionally set a schedule configuration interval to control how often membership
        /// snapshots are run. The interval can be from 1 to 24 hours. If not set, the interval
        /// defaults to 24 hours. Scheduled snapshots run on a best-effort basis. If a scheduled
        /// snapshot takes longer than the configured interval, the next scheduled run does not
        /// start until the in-progress snapshot completes, so a run might be delayed or skipped
        /// and is not guaranteed to occur at exactly the requested time. 
        /// </para>
        ///  
        /// <para>
        /// For Classic segments, membership events are generated from these scheduled snapshots
        /// and also in near real-time as profile attribute changes occur. For SQL segments, membership
        /// events are generated only from the scheduled snapshots. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSegmentSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutSegmentSubscription service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/PutSegmentSubscription">REST API Reference for PutSegmentSubscription Operation</seealso>
        Task<PutSegmentSubscriptionResponse> PutSegmentSubscriptionAsync(PutSegmentSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves recommendations for a profile in a specific domain. The profile is identified
        /// using a search key, which consists of a <c>KeyName</c> and a <c>KeyValues</c> list.
        /// The <c>KeyName</c> can be a predefined key (for example, <c>_profileId</c>, <c>_phone</c>,
        /// <c>_email</c>) or a custom-defined key.
        /// 
        ///  
        /// <para>
        /// The search key must match exactly one profile. If no profile matches the search key,
        /// the operation returns a <c>ResourceNotFoundException</c>. If more than one profile
        /// matches the search key, the operation returns a <c>BadRequestException</c>. You can
        /// use the SearchProfiles API to review the matching profiles.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRecommendations service method.</param>
        /// <returns>The response from the SearchRecommendations service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/SearchRecommendations">REST API Reference for SearchRecommendations Operation</seealso>
        SearchRecommendationsResponse SearchRecommendations(SearchRecommendationsRequest request);
#endif

        /// <summary>
        /// Retrieves recommendations for a profile in a specific domain. The profile is identified
        /// using a search key, which consists of a <c>KeyName</c> and a <c>KeyValues</c> list.
        /// The <c>KeyName</c> can be a predefined key (for example, <c>_profileId</c>, <c>_phone</c>,
        /// <c>_email</c>) or a custom-defined key.
        /// 
        ///  
        /// <para>
        /// The search key must match exactly one profile. If no profile matches the search key,
        /// the operation returns a <c>ResourceNotFoundException</c>. If more than one profile
        /// matches the search key, the operation returns a <c>BadRequestException</c>. You can
        /// use the SearchProfiles API to review the matching profiles.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SearchRecommendations service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/SearchRecommendations">REST API Reference for SearchRecommendations Operation</seealso>
        Task<SearchRecommendationsResponse> SearchRecommendationsAsync(SearchRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts a recommender that was previously stopped. Starting a recommender resumes its
        /// ability to generate recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommender service method.</param>
        /// <returns>The response from the StartRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StartRecommender">REST API Reference for StartRecommender Operation</seealso>
        StartRecommenderResponse StartRecommender(StartRecommenderRequest request);
#endif

        /// <summary>
        /// Starts a recommender that was previously stopped. Starting a recommender resumes its
        /// ability to generate recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StartRecommender">REST API Reference for StartRecommender Operation</seealso>
        Task<StartRecommenderResponse> StartRecommenderAsync(StartRecommenderRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This API starts the processing of an upload job to ingest profile data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUploadJob service method.</param>
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
#endif

        /// <summary>
        /// This API starts the processing of an upload job to ingest profile data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Stops a recommender, suspending its ability to generate recommendations. The recommender
        /// can be restarted later using StartRecommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRecommender service method.</param>
        /// <returns>The response from the StopRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StopRecommender">REST API Reference for StopRecommender Operation</seealso>
        StopRecommenderResponse StopRecommender(StopRecommenderRequest request);
#endif

        /// <summary>
        /// Stops a recommender, suspending its ability to generate recommendations. The recommender
        /// can be restarted later using StartRecommender.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/StopRecommender">REST API Reference for StopRecommender Operation</seealso>
        Task<StopRecommenderResponse> StopRecommenderAsync(StopRecommenderRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This API stops the processing of an upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopUploadJob service method.</param>
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
#endif

        /// <summary>
        /// This API stops the processing of an upload job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopUploadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Removes one or more tags from the specified Amazon Connect Customer Profiles resource.
        /// In Connect Customer Profiles, domains, profile object types, and integrations can
        /// be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
#endif

        /// <summary>
        /// Removes one or more tags from the specified Amazon Connect Customer Profiles resource.
        /// In Connect Customer Profiles, domains, profile object types, and integrations can
        /// be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing calculated attribute definition. When updating the Conditions,
        /// note that increasing the date range of a calculated attribute will not trigger inclusion
        /// of historical data greater than the current date range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCalculatedAttributeDefinition service method.</param>
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
#endif

        /// <summary>
        /// Updates an existing calculated attribute definition. When updating the Conditions,
        /// note that increasing the date range of a calculated attribute will not trigger inclusion
        /// of historical data greater than the current date range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCalculatedAttributeDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Updates the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainLayout service method.</param>
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
#endif

        /// <summary>
        /// Updates the layout used to view data for a specific domain. This API can only be invoked
        /// from the Amazon Connect admin website.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
        /// <summary>
        /// Update the properties of an Event Trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventTrigger service method.</param>
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
#endif

        /// <summary>
        /// Update the properties of an Event Trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventTrigger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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

#if NETFRAMEWORK
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
#endif

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

#if NETFRAMEWORK
        /// <summary>
        /// Updates the properties of an existing recommender, allowing you to modify its configuration
        /// and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommender service method.</param>
        /// <returns>The response from the UpdateRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateRecommender">REST API Reference for UpdateRecommender Operation</seealso>
        UpdateRecommenderResponse UpdateRecommender(UpdateRecommenderRequest request);
#endif

        /// <summary>
        /// Updates the properties of an existing recommender, allowing you to modify its configuration
        /// and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommender service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRecommender service method, as returned by CustomerProfiles.</returns>
        /// <exception cref="Amazon.CustomerProfiles.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.InternalServerException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.CustomerProfiles.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/customer-profiles-2020-08-15/UpdateRecommender">REST API Reference for UpdateRecommender Operation</seealso>
        Task<UpdateRecommenderResponse> UpdateRecommenderAsync(UpdateRecommenderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonCustomerProfilesConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonCustomerProfilesConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonCustomerProfilesConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonCustomerProfilesConfig to create AmazonCustomerProfilesClient");
            }

            return awsCredentials == null ?
                    new AmazonCustomerProfilesClient(serviceClientConfig) :
                    new AmazonCustomerProfilesClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
