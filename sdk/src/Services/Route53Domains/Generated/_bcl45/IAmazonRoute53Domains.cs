/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Route53Domains.Model;

namespace Amazon.Route53Domains
{
    /// <summary>
    /// Interface for accessing Route53Domains
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRoute53Domains : IDisposable
    {

        
        #region  CheckDomainAvailability


        /// <summary>
        /// This operation checks the availability of one domain name. Note that if the availability
        /// status of a domain is pending, you must submit another request to determine the availability
        /// of the domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDomainAvailability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        CheckDomainAvailabilityResponse CheckDomainAvailability(CheckDomainAvailabilityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CheckDomainAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CheckDomainAvailabilityResponse> CheckDomainAvailabilityAsync(CheckDomainAvailabilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTagsForDomain


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to delete one or more tags. The name of a domain. Type: String Default: None Constraints: The domain name can contain only the letters a through z, the numbers 0 through 9, and hyphen (-). Hyphens are allowed only when they&apos;re surrounded by letters, numbers, or other hyphens. You can&apos;t specify a hyphen at the beginning or end of a label. To specify an Internationalized Domain Name, you must convert the name to Punycode. Required: Yes</param>
        /// <param name="tagsToDelete">A list of tag keys to delete. Type: A list that contains the keys of the tags that you want to delete. Default: None Required: No'></param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        DeleteTagsForDomainResponse DeleteTagsForDomain(string domainName, List<string> tagsToDelete);

        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        DeleteTagsForDomainResponse DeleteTagsForDomain(DeleteTagsForDomainRequest request);


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to delete one or more tags. The name of a domain. Type: String Default: None Constraints: The domain name can contain only the letters a through z, the numbers 0 through 9, and hyphen (-). Hyphens are allowed only when they&apos;re surrounded by letters, numbers, or other hyphens. You can&apos;t specify a hyphen at the beginning or end of a label. To specify an Internationalized Domain Name, you must convert the name to Punycode. Required: Yes</param>
        /// <param name="tagsToDelete">A list of tag keys to delete. Type: A list that contains the keys of the tags that you want to delete. Default: None Required: No'></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        Task<DeleteTagsForDomainResponse> DeleteTagsForDomainAsync(string domainName, List<string> tagsToDelete, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTagsForDomainResponse> DeleteTagsForDomainAsync(DeleteTagsForDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableDomainAutoRenew


        /// <summary>
        /// This operation disables automatic renewal of domain registration for the specified
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew service method.</param>
        /// 
        /// <returns>The response from the DisableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        DisableDomainAutoRenewResponse DisableDomainAutoRenew(DisableDomainAutoRenewRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableDomainAutoRenewResponse> DisableDomainAutoRenewAsync(DisableDomainAutoRenewRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableDomainTransferLock


        /// <summary>
        /// This operation removes the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to allow domain transfers. We recommend you refrain from performing this action
        /// unless you intend to transfer the domain to a different registrar. Successful submission
        /// returns an operation ID that you can use to track the progress and completion of the
        /// action. If the request is not completed successfully, the domain registrant will be
        /// notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock service method.</param>
        /// 
        /// <returns>The response from the DisableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        DisableDomainTransferLockResponse DisableDomainTransferLock(DisableDomainTransferLockRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableDomainTransferLockResponse> DisableDomainTransferLockAsync(DisableDomainTransferLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableDomainAutoRenew


        /// <summary>
        /// This operation configures Amazon Route 53 to automatically renew the specified domain
        /// before the domain registration expires. The cost of renewing your domain registration
        /// is billed to your AWS account.
        /// 
        ///  
        /// <para>
        /// The period during which you can renew a domain name varies by TLD. For a list of TLDs
        /// and their renewal policies, see <a href="http://wiki.gandi.net/en/domains/renew#renewal_restoration_and_deletion_times">"Renewal,
        /// restoration, and deletion times"</a> on the website for our registrar partner, Gandi.
        /// Route 53 requires that you renew before the end of the renewal period that is listed
        /// on the Gandi website so we can complete processing before the deadline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew service method.</param>
        /// 
        /// <returns>The response from the EnableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        EnableDomainAutoRenewResponse EnableDomainAutoRenew(EnableDomainAutoRenewRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the EnableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableDomainAutoRenewResponse> EnableDomainAutoRenewAsync(EnableDomainAutoRenewRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableDomainTransferLock


        /// <summary>
        /// This operation sets the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to prevent domain transfers. Successful submission returns an operation ID
        /// that you can use to track the progress and completion of the action. If the request
        /// is not completed successfully, the domain registrant will be notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock service method.</param>
        /// 
        /// <returns>The response from the EnableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        EnableDomainTransferLockResponse EnableDomainTransferLock(EnableDomainTransferLockRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the EnableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableDomainTransferLockResponse> EnableDomainTransferLockAsync(EnableDomainTransferLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContactReachabilityStatus


        /// <summary>
        /// For operations that require confirmation that the email address for the registrant
        /// contact is valid, such as registering a new domain, this operation returns information
        /// about whether the registrant contact has responded.
        /// 
        ///  
        /// <para>
        /// If you want us to resend the email, use the <code>ResendContactReachabilityEmail</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus service method.</param>
        /// 
        /// <returns>The response from the GetContactReachabilityStatus service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        GetContactReachabilityStatusResponse GetContactReachabilityStatus(GetContactReachabilityStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetContactReachabilityStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetContactReachabilityStatusResponse> GetContactReachabilityStatusAsync(GetContactReachabilityStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomainDetail


        /// <summary>
        /// This operation returns detailed information about the domain. The domain's contact
        /// information is also returned as part of the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail service method.</param>
        /// 
        /// <returns>The response from the GetDomainDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        GetDomainDetailResponse GetDomainDetail(GetDomainDetailRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDomainDetailResponse> GetDomainDetailAsync(GetDomainDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomainSuggestions


        /// <summary>
        /// The GetDomainSuggestions operation returns a list of suggested domain names given
        /// a string, which can either be a domain name or simply a word or phrase (without spaces).
        /// 
        ///  
        /// <para>
        ///  Parameters: <ul><li>DomainName (string): The basis for your domain suggestion search,
        /// a string with (or without) top-level domain specified.</li> <li>SuggestionCount (int):
        /// The number of domain suggestions to be returned, maximum 50, minimum 1.</li> <li>OnlyAvailable
        /// (bool): If true, availability check will be performed on suggestion results, and only
        /// available domains will be returned. If false, suggestions will be returned without
        /// checking whether the domain is actually available, and caller will have to call checkDomainAvailability
        /// for each suggestion to determine availability for registration.</li> </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions service method.</param>
        /// 
        /// <returns>The response from the GetDomainSuggestions service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        GetDomainSuggestionsResponse GetDomainSuggestions(GetDomainSuggestionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainSuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDomainSuggestionsResponse> GetDomainSuggestionsAsync(GetDomainSuggestionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperationDetail


        /// <summary>
        /// This operation returns the current status of an operation that is not completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail service method.</param>
        /// 
        /// <returns>The response from the GetOperationDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        GetOperationDetailResponse GetOperationDetail(GetOperationDetailRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetOperationDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetOperationDetailResponse> GetOperationDetailAsync(GetOperationDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        ListDomainsResponse ListDomains();


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        ListDomainsResponse ListDomains(ListDomainsRequest request);


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        Task<ListDomainsResponse> ListDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        ListOperationsResponse ListOperations();


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        ListOperationsResponse ListOperations(ListOperationsRequest request);


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        Task<ListOperationsResponse> ListOperationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForDomain


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to get a list of tags.</param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        ListTagsForDomainResponse ListTagsForDomain(string domainName);

        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        ListTagsForDomainResponse ListTagsForDomain(ListTagsForDomainRequest request);


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to get a list of tags.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        Task<ListTagsForDomainResponse> ListTagsForDomainAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForDomainResponse> ListTagsForDomainAsync(ListTagsForDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterDomain


        /// <summary>
        /// This operation registers a domain. Domains are registered by the AWS registrar partner,
        /// Gandi. For some top-level domains (TLDs), this operation requires extra parameters.
        /// 
        ///  
        /// <para>
        /// When you register a domain, Amazon Route 53 does the following:
        /// </para>
        ///  <ul> <li>Creates a Amazon Route 53 hosted zone that has the same name as the domain.
        /// Amazon Route 53 assigns four name servers to your hosted zone and automatically updates
        /// your domain registration with the names of these name servers.</li> <li>Enables autorenew,
        /// so your domain registration will renew automatically each year. We'll notify you in
        /// advance of the renewal date so you can choose whether to renew the registration.</li>
        /// <li>Optionally enables privacy protection, so WHOIS queries return contact information
        /// for our registrar partner, Gandi, instead of the information you entered for registrant,
        /// admin, and tech contacts.</li> <li>If registration is successful, returns an operation
        /// ID that you can use to track the progress and completion of the action. If the request
        /// is not completed successfully, the domain registrant is notified by email.</li> <li>Charges
        /// your AWS account an amount based on the top-level domain. For more information, see
        /// <a href="http://aws.amazon.com/route53/pricing/">Amazon Route 53 Pricing</a>.</li>
        /// </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        RegisterDomainResponse RegisterDomain(RegisterDomainRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RenewDomain


        /// <summary>
        /// This operation renews a domain for the specified number of years. The cost of renewing
        /// your domain is billed to your AWS account.
        /// 
        ///  
        /// <para>
        /// We recommend that you renew your domain several weeks before the expiration date.
        /// Some TLD registries delete domains before the expiration date if you haven't renewed
        /// far enough in advance. For more information about renewing domain registration, see
        /// <a href="http://docs.aws.amazon.com/console/route53/domain-renew">Renewing Registration
        /// for a Domain</a> in the Amazon Route 53 documentation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain service method.</param>
        /// 
        /// <returns>The response from the RenewDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        RenewDomainResponse RenewDomain(RenewDomainRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RenewDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RenewDomainResponse> RenewDomainAsync(RenewDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResendContactReachabilityEmail


        /// <summary>
        /// For operations that require confirmation that the email address for the registrant
        /// contact is valid, such as registering a new domain, this operation resends the confirmation
        /// email to the current email address for the registrant contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail service method.</param>
        /// 
        /// <returns>The response from the ResendContactReachabilityEmail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        ResendContactReachabilityEmailResponse ResendContactReachabilityEmail(ResendContactReachabilityEmailRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ResendContactReachabilityEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResendContactReachabilityEmailResponse> ResendContactReachabilityEmailAsync(ResendContactReachabilityEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetrieveDomainAuthCode


        /// <summary>
        /// This operation returns the AuthCode for the domain. To transfer a domain to another
        /// registrar, you provide this value to the new registrar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode service method.</param>
        /// 
        /// <returns>The response from the RetrieveDomainAuthCode service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        RetrieveDomainAuthCodeResponse RetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveDomainAuthCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RetrieveDomainAuthCodeResponse> RetrieveDomainAuthCodeAsync(RetrieveDomainAuthCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TransferDomain


        /// <summary>
        /// This operation transfers a domain from another registrar to Amazon Route 53. When
        /// the transfer is complete, the domain is registered with the AWS registrar partner,
        /// Gandi.
        /// 
        ///  
        /// <para>
        /// For transfer requirements, a detailed procedure, and information about viewing the
        /// status of a domain transfer, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
        /// Registration for a Domain to Amazon Route 53</a> in the Amazon Route 53 Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain,
        /// we highly recommend that you consider transferring your DNS service to Amazon Route
        /// 53 or to another DNS service provider before you transfer your registration. Some
        /// registrars provide free DNS service when you purchase a domain registration. When
        /// you transfer the registration, the previous registrar will not renew your domain registration
        /// and could end your DNS service at any time.
        /// </para>
        ///  <note>Caution! If the registrar for your domain is also the DNS service provider
        /// for the domain and you don't transfer DNS service to another provider, your website,
        /// email, and the web applications associated with the domain might become unavailable.</note>
        /// 
        /// <para>
        /// If the transfer is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the action. If the transfer doesn't complete
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain service method.</param>
        /// 
        /// <returns>The response from the TransferDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        TransferDomainResponse TransferDomain(TransferDomainRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TransferDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainContact


        /// <summary>
        /// This operation updates the contact information for a particular domain. Information
        /// for at least one contact (registrant, administrator, or technical) must be supplied
        /// for update.
        /// 
        ///  
        /// <para>
        /// If the update is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the action. If the request is not completed
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContact service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        UpdateDomainContactResponse UpdateDomainContact(UpdateDomainContactRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainContactResponse> UpdateDomainContactAsync(UpdateDomainContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainContactPrivacy


        /// <summary>
        /// This operation updates the specified domain contact's privacy setting. When the privacy
        /// option is enabled, personal information such as postal or email address is hidden
        /// from the results of a public WHOIS query. The privacy services are provided by the
        /// AWS registrar, Gandi. For more information, see the <a href="http://www.gandi.net/domain/whois/?currency=USD&amp;amp;lang=en">Gandi
        /// privacy features</a>.
        /// 
        ///  
        /// <para>
        /// This operation only affects the privacy of the specified contact type (registrant,
        /// administrator, or tech). Successful acceptance returns an operation ID that you can
        /// use with GetOperationDetail to track the progress and completion of the action. If
        /// the request is not completed successfully, the domain registrant will be notified
        /// by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContactPrivacy service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        UpdateDomainContactPrivacyResponse UpdateDomainContactPrivacy(UpdateDomainContactPrivacyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContactPrivacy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainContactPrivacyResponse> UpdateDomainContactPrivacyAsync(UpdateDomainContactPrivacyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainNameservers


        /// <summary>
        /// This operation replaces the current set of name servers for the domain with the specified
        /// set of name servers. If you use Amazon Route 53 as your DNS service, specify the four
        /// name servers in the delegation set for the hosted zone for the domain. 
        /// 
        ///  
        /// <para>
        /// If successful, this operation returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainNameservers service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        UpdateDomainNameserversResponse UpdateDomainNameservers(UpdateDomainNameserversRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainNameservers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainNameserversResponse> UpdateDomainNameserversAsync(UpdateDomainNameserversRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTagsForDomain


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to add or update tags. The name of a domain. Type: String Default: None Constraints: The domain name can contain only the letters a through z, the numbers 0 through 9, and hyphen (-). Hyphens are allowed only when they&apos;re surrounded by letters, numbers, or other hyphens. You can&apos;t specify a hyphen at the beginning or end of a label. To specify an Internationalized Domain Name, you must convert the name to Punycode. Required: Yes</param>
        /// <param name="tagsToUpdate">A list of the tag keys and values that you want to add or update. If you specify a key that already exists, the corresponding value will be replaced. Type: A complex type containing a list of tags Default: None Required: No'> Each tag includes the following elements: <ul> <li>Key The key (name) of a tag. Type: String Default: None Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-@" Constraints: Each key can be 1-128 characters long. Required: Yes </li> <li>Value The value of a tag. Type: String Default: None Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-@" Constraints: Each value can be 0-256 characters long. Required: Yes </li> </ul></param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        UpdateTagsForDomainResponse UpdateTagsForDomain(string domainName, List<Tag> tagsToUpdate);

        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        UpdateTagsForDomainResponse UpdateTagsForDomain(UpdateTagsForDomainRequest request);


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations may not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to add or update tags. The name of a domain. Type: String Default: None Constraints: The domain name can contain only the letters a through z, the numbers 0 through 9, and hyphen (-). Hyphens are allowed only when they&apos;re surrounded by letters, numbers, or other hyphens. You can&apos;t specify a hyphen at the beginning or end of a label. To specify an Internationalized Domain Name, you must convert the name to Punycode. Required: Yes</param>
        /// <param name="tagsToUpdate">A list of the tag keys and values that you want to add or update. If you specify a key that already exists, the corresponding value will be replaced. Type: A complex type containing a list of tags Default: None Required: No'> Each tag includes the following elements: <ul> <li>Key The key (name) of a tag. Type: String Default: None Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-@" Constraints: Each key can be 1-128 characters long. Required: Yes </li> <li>Value The value of a tag. Type: String Default: None Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-@" Constraints: Each value can be 0-256 characters long. Required: Yes </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        Task<UpdateTagsForDomainResponse> UpdateTagsForDomainAsync(string domainName, List<Tag> tagsToUpdate, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateTagsForDomainResponse> UpdateTagsForDomainAsync(UpdateTagsForDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ViewBilling


        /// <summary>
        /// This operation returns all the domain-related billing records for the current AWS
        /// account for a specified period
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling service method.</param>
        /// 
        /// <returns>The response from the ViewBilling service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        ViewBillingResponse ViewBilling(ViewBillingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ViewBilling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ViewBillingResponse> ViewBillingAsync(ViewBillingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}