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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53Domains.Model;

namespace Amazon.Route53Domains
{
    /// <summary>
    /// Interface for accessing Route53Domains
    ///
    /// Amazon Route 53 API actions let you register domain names and perform related operations.
    /// </summary>
    public partial interface IAmazonRoute53Domains : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53DomainsPaginatorFactory Paginators { get; }

        
        #region  AcceptDomainTransferFromAnotherAwsAccount


        /// <summary>
        /// Accepts the transfer of a domain from another Amazon Web Services account to the currentAmazon
        /// Web Services account. You initiate a transfer between Amazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        ///  
        /// <para>
        /// If you use the CLI command at <a href="https://docs.aws.amazon.com/cli/latest/reference/route53domains/accept-domain-transfer-from-another-aws-account.html">accept-domain-transfer-from-another-aws-account</a>,
        /// use JSON format as input instead of text because otherwise CLI will throw an error
        /// from domain transfer input that includes single quotes.
        /// </para>
        ///  
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptDomainTransferFromAnotherAwsAccount service method.</param>
        /// 
        /// <returns>The response from the AcceptDomainTransferFromAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AcceptDomainTransferFromAnotherAwsAccount">REST API Reference for AcceptDomainTransferFromAnotherAwsAccount Operation</seealso>
        AcceptDomainTransferFromAnotherAwsAccountResponse AcceptDomainTransferFromAnotherAwsAccount(AcceptDomainTransferFromAnotherAwsAccountRequest request);



        /// <summary>
        /// Accepts the transfer of a domain from another Amazon Web Services account to the currentAmazon
        /// Web Services account. You initiate a transfer between Amazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        ///  
        /// <para>
        /// If you use the CLI command at <a href="https://docs.aws.amazon.com/cli/latest/reference/route53domains/accept-domain-transfer-from-another-aws-account.html">accept-domain-transfer-from-another-aws-account</a>,
        /// use JSON format as input instead of text because otherwise CLI will throw an error
        /// from domain transfer input that includes single quotes.
        /// </para>
        ///  
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptDomainTransferFromAnotherAwsAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptDomainTransferFromAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AcceptDomainTransferFromAnotherAwsAccount">REST API Reference for AcceptDomainTransferFromAnotherAwsAccount Operation</seealso>
        Task<AcceptDomainTransferFromAnotherAwsAccountResponse> AcceptDomainTransferFromAnotherAwsAccountAsync(AcceptDomainTransferFromAnotherAwsAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateDelegationSignerToDomain


        /// <summary>
        /// Creates a delegation signer (DS) record in the registry zone for this domain name.
        /// 
        ///  
        /// <para>
        /// Note that creating DS record at the registry impacts DNSSEC validation of your DNS
        /// records. This action may render your domain name unavailable on the internet if the
        /// steps are completed in the wrong order, or with incorrect timing. For more information
        /// about DNSSEC signing, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-configuring-dnssec.html">Configuring
        /// DNSSEC signing</a> in the <i>Route 53 developer guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegationSignerToDomain service method.</param>
        /// 
        /// <returns>The response from the AssociateDelegationSignerToDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DnssecLimitExceededException">
        /// This error is returned if you call <code>AssociateDelegationSignerToDomain</code>
        /// when the specified domain has reached the maximum number of DS records. You can't
        /// add any additional DS records unless you delete an existing one first.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AssociateDelegationSignerToDomain">REST API Reference for AssociateDelegationSignerToDomain Operation</seealso>
        AssociateDelegationSignerToDomainResponse AssociateDelegationSignerToDomain(AssociateDelegationSignerToDomainRequest request);



        /// <summary>
        /// Creates a delegation signer (DS) record in the registry zone for this domain name.
        /// 
        ///  
        /// <para>
        /// Note that creating DS record at the registry impacts DNSSEC validation of your DNS
        /// records. This action may render your domain name unavailable on the internet if the
        /// steps are completed in the wrong order, or with incorrect timing. For more information
        /// about DNSSEC signing, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-configuring-dnssec.html">Configuring
        /// DNSSEC signing</a> in the <i>Route 53 developer guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegationSignerToDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDelegationSignerToDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DnssecLimitExceededException">
        /// This error is returned if you call <code>AssociateDelegationSignerToDomain</code>
        /// when the specified domain has reached the maximum number of DS records. You can't
        /// add any additional DS records unless you delete an existing one first.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AssociateDelegationSignerToDomain">REST API Reference for AssociateDelegationSignerToDomain Operation</seealso>
        Task<AssociateDelegationSignerToDomainResponse> AssociateDelegationSignerToDomainAsync(AssociateDelegationSignerToDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelDomainTransferToAnotherAwsAccount


        /// <summary>
        /// Cancels the transfer of a domain from the current Amazon Web Services account to another
        /// Amazon Web Services account. You initiate a transfer betweenAmazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// You must cancel the transfer before the other Amazon Web Services account accepts
        /// the transfer using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AcceptDomainTransferFromAnotherAwsAccount.html">AcceptDomainTransferFromAnotherAwsAccount</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDomainTransferToAnotherAwsAccount service method.</param>
        /// 
        /// <returns>The response from the CancelDomainTransferToAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CancelDomainTransferToAnotherAwsAccount">REST API Reference for CancelDomainTransferToAnotherAwsAccount Operation</seealso>
        CancelDomainTransferToAnotherAwsAccountResponse CancelDomainTransferToAnotherAwsAccount(CancelDomainTransferToAnotherAwsAccountRequest request);



        /// <summary>
        /// Cancels the transfer of a domain from the current Amazon Web Services account to another
        /// Amazon Web Services account. You initiate a transfer betweenAmazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// You must cancel the transfer before the other Amazon Web Services account accepts
        /// the transfer using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AcceptDomainTransferFromAnotherAwsAccount.html">AcceptDomainTransferFromAnotherAwsAccount</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDomainTransferToAnotherAwsAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelDomainTransferToAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CancelDomainTransferToAnotherAwsAccount">REST API Reference for CancelDomainTransferToAnotherAwsAccount Operation</seealso>
        Task<CancelDomainTransferToAnotherAwsAccountResponse> CancelDomainTransferToAnotherAwsAccountAsync(CancelDomainTransferToAnotherAwsAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        CheckDomainAvailabilityResponse CheckDomainAvailability(CheckDomainAvailabilityRequest request);



        /// <summary>
        /// This operation checks the availability of one domain name. Note that if the availability
        /// status of a domain is pending, you must submit another request to determine the availability
        /// of the domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckDomainAvailability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        Task<CheckDomainAvailabilityResponse> CheckDomainAvailabilityAsync(CheckDomainAvailabilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CheckDomainTransferability


        /// <summary>
        /// Checks whether a domain name can be transferred to Amazon Route 53.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainTransferability service method.</param>
        /// 
        /// <returns>The response from the CheckDomainTransferability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        CheckDomainTransferabilityResponse CheckDomainTransferability(CheckDomainTransferabilityRequest request);



        /// <summary>
        /// Checks whether a domain name can be transferred to Amazon Route 53.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainTransferability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckDomainTransferability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        Task<CheckDomainTransferabilityResponse> CheckDomainTransferabilityAsync(CheckDomainTransferabilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// This operation deletes the specified domain. This action is permanent. For more information,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-delete.html">Deleting
        /// a domain name registration</a>.
        /// 
        ///  
        /// <para>
        /// To transfer the domain registration to another registrar, use the transfer process
        /// that’s provided by the registrar to which you want to transfer the registration. Otherwise,
        /// the following apply:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You can’t get a refund for the cost of a deleted domain registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The registry for the top-level domain might hold the domain name for a brief time
        /// before releasing it for other users to register (varies by registry). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the registration has been deleted, we'll send you a confirmation to the registrant
        /// contact. The email will come from <code>noreply@domainnameverification.net</code>
        /// or <code>noreply@registrar.amazon.com</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);



        /// <summary>
        /// This operation deletes the specified domain. This action is permanent. For more information,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-delete.html">Deleting
        /// a domain name registration</a>.
        /// 
        ///  
        /// <para>
        /// To transfer the domain registration to another registrar, use the transfer process
        /// that’s provided by the registrar to which you want to transfer the registration. Otherwise,
        /// the following apply:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You can’t get a refund for the cost of a deleted domain registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The registry for the top-level domain might hold the domain name for a brief time
        /// before releasing it for other users to register (varies by registry). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the registration has been deleted, we'll send you a confirmation to the registrant
        /// contact. The email will come from <code>noreply@domainnameverification.net</code>
        /// or <code>noreply@registrar.amazon.com</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTagsForDomain


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to delete one or more tags.</param>
        /// <param name="tagsToDelete">A list of tag keys to delete.</param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        DeleteTagsForDomainResponse DeleteTagsForDomain(string domainName, List<string> tagsToDelete);

        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        DeleteTagsForDomainResponse DeleteTagsForDomain(DeleteTagsForDomainRequest request);


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to delete one or more tags.</param>
        /// <param name="tagsToDelete">A list of tag keys to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        Task<DeleteTagsForDomainResponse> DeleteTagsForDomainAsync(string domainName, List<string> tagsToDelete, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        DisableDomainAutoRenewResponse DisableDomainAutoRenew(DisableDomainAutoRenewRequest request);



        /// <summary>
        /// This operation disables automatic renewal of domain registration for the specified
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        DisableDomainTransferLockResponse DisableDomainTransferLock(DisableDomainTransferLockRequest request);



        /// <summary>
        /// This operation removes the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to allow domain transfers. We recommend you refrain from performing this action
        /// unless you intend to transfer the domain to a different registrar. Successful submission
        /// returns an operation ID that you can use to track the progress and completion of the
        /// action. If the request is not completed successfully, the domain registrant will be
        /// notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        Task<DisableDomainTransferLockResponse> DisableDomainTransferLockAsync(DisableDomainTransferLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateDelegationSignerFromDomain


        /// <summary>
        /// Deletes a delegation signer (DS) record in the registry zone for this domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegationSignerFromDomain service method.</param>
        /// 
        /// <returns>The response from the DisassociateDelegationSignerFromDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisassociateDelegationSignerFromDomain">REST API Reference for DisassociateDelegationSignerFromDomain Operation</seealso>
        DisassociateDelegationSignerFromDomainResponse DisassociateDelegationSignerFromDomain(DisassociateDelegationSignerFromDomainRequest request);



        /// <summary>
        /// Deletes a delegation signer (DS) record in the registry zone for this domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegationSignerFromDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDelegationSignerFromDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisassociateDelegationSignerFromDomain">REST API Reference for DisassociateDelegationSignerFromDomain Operation</seealso>
        Task<DisassociateDelegationSignerFromDomainResponse> DisassociateDelegationSignerFromDomainAsync(DisassociateDelegationSignerFromDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableDomainAutoRenew


        /// <summary>
        /// This operation configures Amazon Route 53 to automatically renew the specified domain
        /// before the domain registration expires. The cost of renewing your domain registration
        /// is billed to your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The period during which you can renew a domain name varies by TLD. For a list of TLDs
        /// and their renewal policies, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// That You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>. Route 53 requires that you renew before the end of the renewal period so
        /// we can complete processing before the deadline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew service method.</param>
        /// 
        /// <returns>The response from the EnableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainAutoRenew">REST API Reference for EnableDomainAutoRenew Operation</seealso>
        EnableDomainAutoRenewResponse EnableDomainAutoRenew(EnableDomainAutoRenewRequest request);



        /// <summary>
        /// This operation configures Amazon Route 53 to automatically renew the specified domain
        /// before the domain registration expires. The cost of renewing your domain registration
        /// is billed to your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The period during which you can renew a domain name varies by TLD. For a list of TLDs
        /// and their renewal policies, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// That You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>. Route 53 requires that you renew before the end of the renewal period so
        /// we can complete processing before the deadline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainAutoRenew">REST API Reference for EnableDomainAutoRenew Operation</seealso>
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainTransferLock">REST API Reference for EnableDomainTransferLock Operation</seealso>
        EnableDomainTransferLockResponse EnableDomainTransferLock(EnableDomainTransferLockRequest request);



        /// <summary>
        /// This operation sets the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to prevent domain transfers. Successful submission returns an operation ID
        /// that you can use to track the progress and completion of the action. If the request
        /// is not completed successfully, the domain registrant will be notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainTransferLock">REST API Reference for EnableDomainTransferLock Operation</seealso>
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetContactReachabilityStatus">REST API Reference for GetContactReachabilityStatus Operation</seealso>
        GetContactReachabilityStatusResponse GetContactReachabilityStatus(GetContactReachabilityStatusRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactReachabilityStatus service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetContactReachabilityStatus">REST API Reference for GetContactReachabilityStatus Operation</seealso>
        Task<GetContactReachabilityStatusResponse> GetContactReachabilityStatusAsync(GetContactReachabilityStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomainDetail


        /// <summary>
        /// This operation returns detailed information about a specified domain that is associated
        /// with the current Amazon Web Services account. Contact information for the domain is
        /// also returned as part of the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail service method.</param>
        /// 
        /// <returns>The response from the GetDomainDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        GetDomainDetailResponse GetDomainDetail(GetDomainDetailRequest request);



        /// <summary>
        /// This operation returns detailed information about a specified domain that is associated
        /// with the current Amazon Web Services account. Contact information for the domain is
        /// also returned as part of the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        Task<GetDomainDetailResponse> GetDomainDetailAsync(GetDomainDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomainSuggestions


        /// <summary>
        /// The GetDomainSuggestions operation returns a list of suggested domain names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions service method.</param>
        /// 
        /// <returns>The response from the GetDomainSuggestions service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        GetDomainSuggestionsResponse GetDomainSuggestions(GetDomainSuggestionsRequest request);



        /// <summary>
        /// The GetDomainSuggestions operation returns a list of suggested domain names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainSuggestions service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        GetOperationDetailResponse GetOperationDetail(GetOperationDetailRequest request);



        /// <summary>
        /// This operation returns the current status of an operation that is not completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperationDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        Task<GetOperationDetailResponse> GetOperationDetailAsync(GetOperationDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current Amazon Web Services account if no filtering conditions are used.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains();


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current Amazon Web Services account if no filtering conditions are used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current Amazon Web Services account if no filtering conditions are used.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current Amazon Web Services account if no filtering conditions are used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// Returns information about all of the operations that return an operation ID and that
        /// have ever been performed on domains that were registered by the current account. 
        /// 
        ///  
        /// <para>
        /// This command runs only in the us-east-1 Region.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse ListOperations();


        /// <summary>
        /// Returns information about all of the operations that return an operation ID and that
        /// have ever been performed on domains that were registered by the current account. 
        /// 
        ///  
        /// <para>
        /// This command runs only in the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse ListOperations(ListOperationsRequest request);


        /// <summary>
        /// Returns information about all of the operations that return an operation ID and that
        /// have ever been performed on domains that were registered by the current account. 
        /// 
        ///  
        /// <para>
        /// This command runs only in the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        Task<ListOperationsResponse> ListOperationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns information about all of the operations that return an operation ID and that
        /// have ever been performed on domains that were registered by the current account. 
        /// 
        ///  
        /// <para>
        /// This command runs only in the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPrices


        /// <summary>
        /// Lists the following prices for either all the TLDs supported by Route 53, or the specified
        /// TLD:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Registration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Transfer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owner change
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain renewal
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain restoration
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrices service method.</param>
        /// 
        /// <returns>The response from the ListPrices service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListPrices">REST API Reference for ListPrices Operation</seealso>
        ListPricesResponse ListPrices(ListPricesRequest request);



        /// <summary>
        /// Lists the following prices for either all the TLDs supported by Route 53, or the specified
        /// TLD:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Registration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Transfer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owner change
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain renewal
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain restoration
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrices service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListPrices">REST API Reference for ListPrices Operation</seealso>
        Task<ListPricesResponse> ListPricesAsync(ListPricesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForDomain


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to get a list of tags.</param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        ListTagsForDomainResponse ListTagsForDomain(string domainName);

        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        ListTagsForDomainResponse ListTagsForDomain(ListTagsForDomainRequest request);


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        Task<ListTagsForDomainResponse> ListTagsForDomainAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        Task<ListTagsForDomainResponse> ListTagsForDomainAsync(ListTagsForDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PushDomain


        /// <summary>
        /// Moves a domain from Amazon Web Services to another registrar. 
        /// 
        ///  
        /// <para>
        /// Supported actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Changes the IPS tags of a .uk domain, and pushes it to transit. Transit means that
        /// the domain is ready to be transferred to another registrar.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PushDomain service method.</param>
        /// 
        /// <returns>The response from the PushDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/PushDomain">REST API Reference for PushDomain Operation</seealso>
        PushDomainResponse PushDomain(PushDomainRequest request);



        /// <summary>
        /// Moves a domain from Amazon Web Services to another registrar. 
        /// 
        ///  
        /// <para>
        /// Supported actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Changes the IPS tags of a .uk domain, and pushes it to transit. Transit means that
        /// the domain is ready to be transferred to another registrar.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PushDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PushDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/PushDomain">REST API Reference for PushDomain Operation</seealso>
        Task<PushDomainResponse> PushDomainAsync(PushDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterDomain


        /// <summary>
        /// This operation registers a domain. Domains are registered either by Amazon Registrar
        /// (for .com, .net, and .org domains) or by our registrar associate, Gandi (for all other
        /// domains). For some top-level domains (TLDs), this operation requires extra parameters.
        /// 
        ///  
        /// <para>
        /// When you register a domain, Amazon Route 53 does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a Route 53 hosted zone that has the same name as the domain. Route 53 assigns
        /// four name servers to your hosted zone and automatically updates your domain registration
        /// with the names of these name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enables auto renew, so your domain registration will renew automatically each year.
        /// We'll notify you in advance of the renewal date so you can choose whether to renew
        /// the registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optionally enables privacy protection, so WHOIS queries return contact information
        /// either for Amazon Registrar (for .com, .net, and .org domains) or for our registrar
        /// associate, Gandi (for all other TLDs). If you don't enable privacy protection, WHOIS
        /// queries return the information that you entered for the administrative, registrant,
        /// and technical contacts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// If registration is successful, returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant is notified by email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Charges your Amazon Web Services account an amount based on the top-level domain.
        /// For more information, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
        /// Route 53 Pricing</a>.
        /// </para>
        ///  </li> </ul>
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        RegisterDomainResponse RegisterDomain(RegisterDomainRequest request);



        /// <summary>
        /// This operation registers a domain. Domains are registered either by Amazon Registrar
        /// (for .com, .net, and .org domains) or by our registrar associate, Gandi (for all other
        /// domains). For some top-level domains (TLDs), this operation requires extra parameters.
        /// 
        ///  
        /// <para>
        /// When you register a domain, Amazon Route 53 does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a Route 53 hosted zone that has the same name as the domain. Route 53 assigns
        /// four name servers to your hosted zone and automatically updates your domain registration
        /// with the names of these name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enables auto renew, so your domain registration will renew automatically each year.
        /// We'll notify you in advance of the renewal date so you can choose whether to renew
        /// the registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optionally enables privacy protection, so WHOIS queries return contact information
        /// either for Amazon Registrar (for .com, .net, and .org domains) or for our registrar
        /// associate, Gandi (for all other TLDs). If you don't enable privacy protection, WHOIS
        /// queries return the information that you entered for the administrative, registrant,
        /// and technical contacts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// If registration is successful, returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant is notified by email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Charges your Amazon Web Services account an amount based on the top-level domain.
        /// For more information, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
        /// Route 53 Pricing</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RejectDomainTransferFromAnotherAwsAccount


        /// <summary>
        /// Rejects the transfer of a domain from another Amazon Web Services account to the current
        /// Amazon Web Services account. You initiate a transfer betweenAmazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectDomainTransferFromAnotherAwsAccount service method.</param>
        /// 
        /// <returns>The response from the RejectDomainTransferFromAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RejectDomainTransferFromAnotherAwsAccount">REST API Reference for RejectDomainTransferFromAnotherAwsAccount Operation</seealso>
        RejectDomainTransferFromAnotherAwsAccountResponse RejectDomainTransferFromAnotherAwsAccount(RejectDomainTransferFromAnotherAwsAccountRequest request);



        /// <summary>
        /// Rejects the transfer of a domain from another Amazon Web Services account to the current
        /// Amazon Web Services account. You initiate a transfer betweenAmazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectDomainTransferFromAnotherAwsAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectDomainTransferFromAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RejectDomainTransferFromAnotherAwsAccount">REST API Reference for RejectDomainTransferFromAnotherAwsAccount Operation</seealso>
        Task<RejectDomainTransferFromAnotherAwsAccountResponse> RejectDomainTransferFromAnotherAwsAccountAsync(RejectDomainTransferFromAnotherAwsAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RenewDomain


        /// <summary>
        /// This operation renews a domain for the specified number of years. The cost of renewing
        /// your domain is billed to your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// We recommend that you renew your domain several weeks before the expiration date.
        /// Some TLD registries delete domains before the expiration date if you haven't renewed
        /// far enough in advance. For more information about renewing domain registration, see
        /// <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-renew.html">Renewing
        /// Registration for a Domain</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain service method.</param>
        /// 
        /// <returns>The response from the RenewDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RenewDomain">REST API Reference for RenewDomain Operation</seealso>
        RenewDomainResponse RenewDomain(RenewDomainRequest request);



        /// <summary>
        /// This operation renews a domain for the specified number of years. The cost of renewing
        /// your domain is billed to your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// We recommend that you renew your domain several weeks before the expiration date.
        /// Some TLD registries delete domains before the expiration date if you haven't renewed
        /// far enough in advance. For more information about renewing domain registration, see
        /// <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-renew.html">Renewing
        /// Registration for a Domain</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenewDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RenewDomain">REST API Reference for RenewDomain Operation</seealso>
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        ResendContactReachabilityEmailResponse ResendContactReachabilityEmail(ResendContactReachabilityEmailRequest request);



        /// <summary>
        /// For operations that require confirmation that the email address for the registrant
        /// contact is valid, such as registering a new domain, this operation resends the confirmation
        /// email to the current email address for the registrant contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResendContactReachabilityEmail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        Task<ResendContactReachabilityEmailResponse> ResendContactReachabilityEmailAsync(ResendContactReachabilityEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResendOperationAuthorization


        /// <summary>
        /// Resend the form of authorization email for this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendOperationAuthorization service method.</param>
        /// 
        /// <returns>The response from the ResendOperationAuthorization service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendOperationAuthorization">REST API Reference for ResendOperationAuthorization Operation</seealso>
        ResendOperationAuthorizationResponse ResendOperationAuthorization(ResendOperationAuthorizationRequest request);



        /// <summary>
        /// Resend the form of authorization email for this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendOperationAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResendOperationAuthorization service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendOperationAuthorization">REST API Reference for ResendOperationAuthorization Operation</seealso>
        Task<ResendOperationAuthorizationResponse> ResendOperationAuthorizationAsync(ResendOperationAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetrieveDomainAuthCode


        /// <summary>
        /// This operation returns the authorization code for the domain. To transfer a domain
        /// to another registrar, you provide this value to the new registrar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode service method.</param>
        /// 
        /// <returns>The response from the RetrieveDomainAuthCode service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        RetrieveDomainAuthCodeResponse RetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request);



        /// <summary>
        /// This operation returns the authorization code for the domain. To transfer a domain
        /// to another registrar, you provide this value to the new registrar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveDomainAuthCode service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        Task<RetrieveDomainAuthCodeResponse> RetrieveDomainAuthCodeAsync(RetrieveDomainAuthCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TransferDomain


        /// <summary>
        /// Transfers a domain from another registrar to Amazon Route 53. When the transfer is
        /// complete, the domain is registered either with Amazon Registrar (for .com, .net, and
        /// .org domains) or with our registrar associate, Gandi (for all other TLDs).
        /// 
        ///  
        /// <para>
        /// For more information about transferring domains, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For transfer requirements, a detailed procedure, and information about viewing the
        /// status of a domain that you're transferring to Route 53, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
        /// Registration for a Domain to Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to transfer a domain from one Amazon Web Services account
        /// to another, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to transfer a domain to another domain registrar, see <a
        /// href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-from-route-53.html">Transferring
        /// a Domain from Amazon Route 53 to Another Registrar</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain,
        /// we highly recommend that you transfer your DNS service to Route 53 or to another DNS
        /// service provider before you transfer your registration. Some registrars provide free
        /// DNS service when you purchase a domain registration. When you transfer the registration,
        /// the previous registrar will not renew your domain registration and could end your
        /// DNS service at any time.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain and
        /// you don't transfer DNS service to another provider, your website, email, and the web
        /// applications associated with the domain might become unavailable.
        /// </para>
        ///  </important> 
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        TransferDomainResponse TransferDomain(TransferDomainRequest request);



        /// <summary>
        /// Transfers a domain from another registrar to Amazon Route 53. When the transfer is
        /// complete, the domain is registered either with Amazon Registrar (for .com, .net, and
        /// .org domains) or with our registrar associate, Gandi (for all other TLDs).
        /// 
        ///  
        /// <para>
        /// For more information about transferring domains, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For transfer requirements, a detailed procedure, and information about viewing the
        /// status of a domain that you're transferring to Route 53, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
        /// Registration for a Domain to Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to transfer a domain from one Amazon Web Services account
        /// to another, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to transfer a domain to another domain registrar, see <a
        /// href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-from-route-53.html">Transferring
        /// a Domain from Amazon Route 53 to Another Registrar</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain,
        /// we highly recommend that you transfer your DNS service to Route 53 or to another DNS
        /// service provider before you transfer your registration. Some registrars provide free
        /// DNS service when you purchase a domain registration. When you transfer the registration,
        /// the previous registrar will not renew your domain registration and could end your
        /// DNS service at any time.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain and
        /// you don't transfer DNS service to another provider, your website, email, and the web
        /// applications associated with the domain might become unavailable.
        /// </para>
        ///  </important> 
        /// <para>
        /// If the transfer is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the action. If the transfer doesn't complete
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TransferDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TransferDomainToAnotherAwsAccount


        /// <summary>
        /// Transfers a domain from the current Amazon Web Services account to another Amazon
        /// Web Services account. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Web Services account that you're transferring the domain to must accept
        /// the transfer. If the other account doesn't accept the transfer within 3 days, we cancel
        /// the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AcceptDomainTransferFromAnotherAwsAccount.html">AcceptDomainTransferFromAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can cancel the transfer before the other account accepts it. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_CancelDomainTransferToAnotherAwsAccount.html">CancelDomainTransferToAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The other account can reject the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_RejectDomainTransferFromAnotherAwsAccount.html">RejectDomainTransferFromAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// When you transfer a domain from one Amazon Web Services account to another, Route
        /// 53 doesn't transfer the hosted zone that is associated with the domain. DNS resolution
        /// isn't affected if the domain and the hosted zone are owned by separate accounts, so
        /// transferring the hosted zone is optional. For information about transferring the hosted
        /// zone to another Amazon Web Services account, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/hosted-zones-migrating.html">Migrating
        /// a Hosted Zone to a Different Amazon Web Services Account</a> in the <i>Amazon Route
        /// 53 Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomainToAnotherAwsAccount service method.</param>
        /// 
        /// <returns>The response from the TransferDomainToAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomainToAnotherAwsAccount">REST API Reference for TransferDomainToAnotherAwsAccount Operation</seealso>
        TransferDomainToAnotherAwsAccountResponse TransferDomainToAnotherAwsAccount(TransferDomainToAnotherAwsAccountRequest request);



        /// <summary>
        /// Transfers a domain from the current Amazon Web Services account to another Amazon
        /// Web Services account. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Web Services account that you're transferring the domain to must accept
        /// the transfer. If the other account doesn't accept the transfer within 3 days, we cancel
        /// the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AcceptDomainTransferFromAnotherAwsAccount.html">AcceptDomainTransferFromAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can cancel the transfer before the other account accepts it. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_CancelDomainTransferToAnotherAwsAccount.html">CancelDomainTransferToAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The other account can reject the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_RejectDomainTransferFromAnotherAwsAccount.html">RejectDomainTransferFromAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// When you transfer a domain from one Amazon Web Services account to another, Route
        /// 53 doesn't transfer the hosted zone that is associated with the domain. DNS resolution
        /// isn't affected if the domain and the hosted zone are owned by separate accounts, so
        /// transferring the hosted zone is optional. For information about transferring the hosted
        /// zone to another Amazon Web Services account, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/hosted-zones-migrating.html">Migrating
        /// a Hosted Zone to a Different Amazon Web Services Account</a> in the <i>Amazon Route
        /// 53 Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomainToAnotherAwsAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TransferDomainToAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomainToAnotherAwsAccount">REST API Reference for TransferDomainToAnotherAwsAccount Operation</seealso>
        Task<TransferDomainToAnotherAwsAccountResponse> TransferDomainToAnotherAwsAccountAsync(TransferDomainToAnotherAwsAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainContact


        /// <summary>
        /// This operation updates the contact information for a particular domain. You must specify
        /// information for at least one contact: registrant, administrator, or technical.
        /// 
        ///  
        /// <para>
        /// If the update is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the operation. If the request is not completed
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContact">REST API Reference for UpdateDomainContact Operation</seealso>
        UpdateDomainContactResponse UpdateDomainContact(UpdateDomainContactRequest request);



        /// <summary>
        /// This operation updates the contact information for a particular domain. You must specify
        /// information for at least one contact: registrant, administrator, or technical.
        /// 
        ///  
        /// <para>
        /// If the update is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the operation. If the request is not completed
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainContact service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContact">REST API Reference for UpdateDomainContact Operation</seealso>
        Task<UpdateDomainContactResponse> UpdateDomainContactAsync(UpdateDomainContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainContactPrivacy


        /// <summary>
        /// This operation updates the specified domain contact's privacy setting. When privacy
        /// protection is enabled, contact information such as email address is replaced either
        /// with contact information for Amazon Registrar (for .com, .net, and .org domains) or
        /// with contact information for our registrar associate, Gandi.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation affects only the contact information for the specified contact type
        /// (administrative, registrant, or technical). If the request succeeds, Amazon Route
        /// 53 returns an operation ID that you can use with <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to track the progress and completion of the action. If the request doesn't complete
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        ///  <important> 
        /// <para>
        /// By disabling the privacy service via API, you consent to the publication of the contact
        /// information provided for this domain via the public WHOIS database. You certify that
        /// you are the registrant of this domain name and have the authority to make this decision.
        /// You may withdraw your consent at any time by enabling privacy protection using either
        /// <code>UpdateDomainContactPrivacy</code> or the Route 53 console. Enabling privacy
        /// protection removes the contact information provided for this domain from the WHOIS
        /// database. For more information on our privacy practices, see <a href="https://aws.amazon.com/privacy/">https://aws.amazon.com/privacy/</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContactPrivacy service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContactPrivacy">REST API Reference for UpdateDomainContactPrivacy Operation</seealso>
        UpdateDomainContactPrivacyResponse UpdateDomainContactPrivacy(UpdateDomainContactPrivacyRequest request);



        /// <summary>
        /// This operation updates the specified domain contact's privacy setting. When privacy
        /// protection is enabled, contact information such as email address is replaced either
        /// with contact information for Amazon Registrar (for .com, .net, and .org domains) or
        /// with contact information for our registrar associate, Gandi.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation affects only the contact information for the specified contact type
        /// (administrative, registrant, or technical). If the request succeeds, Amazon Route
        /// 53 returns an operation ID that you can use with <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to track the progress and completion of the action. If the request doesn't complete
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        ///  <important> 
        /// <para>
        /// By disabling the privacy service via API, you consent to the publication of the contact
        /// information provided for this domain via the public WHOIS database. You certify that
        /// you are the registrant of this domain name and have the authority to make this decision.
        /// You may withdraw your consent at any time by enabling privacy protection using either
        /// <code>UpdateDomainContactPrivacy</code> or the Route 53 console. Enabling privacy
        /// protection removes the contact information provided for this domain from the WHOIS
        /// database. For more information on our privacy practices, see <a href="https://aws.amazon.com/privacy/">https://aws.amazon.com/privacy/</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainContactPrivacy service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContactPrivacy">REST API Reference for UpdateDomainContactPrivacy Operation</seealso>
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
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainNameservers">REST API Reference for UpdateDomainNameservers Operation</seealso>
        UpdateDomainNameserversResponse UpdateDomainNameservers(UpdateDomainNameserversRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainNameservers service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainNameservers">REST API Reference for UpdateDomainNameservers Operation</seealso>
        Task<UpdateDomainNameserversResponse> UpdateDomainNameserversAsync(UpdateDomainNameserversRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTagsForDomain


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to add or update tags.</param>
        /// <param name="tagsToUpdate">A list of the tag keys and values that you want to add or update. If you specify a key that already exists, the corresponding value will be replaced.</param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        UpdateTagsForDomainResponse UpdateTagsForDomain(string domainName, List<Tag> tagsToUpdate);

        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        UpdateTagsForDomainResponse UpdateTagsForDomain(UpdateTagsForDomainRequest request);


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to add or update tags.</param>
        /// <param name="tagsToUpdate">A list of the tag keys and values that you want to add or update. If you specify a key that already exists, the corresponding value will be replaced.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        Task<UpdateTagsForDomainResponse> UpdateTagsForDomainAsync(string domainName, List<Tag> tagsToUpdate, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        Task<UpdateTagsForDomainResponse> UpdateTagsForDomainAsync(UpdateTagsForDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ViewBilling


        /// <summary>
        /// Returns all the domain-related billing records for the current Amazon Web Services
        /// account for a specified period
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling service method.</param>
        /// 
        /// <returns>The response from the ViewBilling service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        ViewBillingResponse ViewBilling(ViewBillingRequest request);



        /// <summary>
        /// Returns all the domain-related billing records for the current Amazon Web Services
        /// account for a specified period
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ViewBilling service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        Task<ViewBillingResponse> ViewBillingAsync(ViewBillingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}