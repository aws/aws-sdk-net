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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        CheckDomainAvailabilityResponse CheckDomainAvailability(CheckDomainAvailabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDomainAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckDomainAvailability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        IAsyncResult BeginCheckDomainAvailability(CheckDomainAvailabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckDomainAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDomainAvailability.</param>
        /// 
        /// <returns>Returns a  CheckDomainAvailabilityResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        CheckDomainAvailabilityResponse EndCheckDomainAvailability(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckDomainTransferability


        /// <summary>
        /// Checks whether a domain name can be transferred to Amazon Route 53.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainTransferability service method.</param>
        /// 
        /// <returns>The response from the CheckDomainTransferability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        CheckDomainTransferabilityResponse CheckDomainTransferability(CheckDomainTransferabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDomainTransferability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainTransferability operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckDomainTransferability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        IAsyncResult BeginCheckDomainTransferability(CheckDomainTransferabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckDomainTransferability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDomainTransferability.</param>
        /// 
        /// <returns>Returns a  CheckDomainTransferabilityResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        CheckDomainTransferabilityResponse EndCheckDomainTransferability(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the DeleteTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTagsForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        IAsyncResult BeginDeleteTagsForDomain(DeleteTagsForDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTagsForDomain.</param>
        /// 
        /// <returns>Returns a  DeleteTagsForDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        DeleteTagsForDomainResponse EndDeleteTagsForDomain(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        DisableDomainAutoRenewResponse DisableDomainAutoRenew(DisableDomainAutoRenewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableDomainAutoRenew
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        IAsyncResult BeginDisableDomainAutoRenew(DisableDomainAutoRenewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDomainAutoRenew.</param>
        /// 
        /// <returns>Returns a  DisableDomainAutoRenewResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        DisableDomainAutoRenewResponse EndDisableDomainAutoRenew(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the DisableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableDomainTransferLock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        IAsyncResult BeginDisableDomainTransferLock(DisableDomainTransferLockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDomainTransferLock.</param>
        /// 
        /// <returns>Returns a  DisableDomainTransferLockResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        DisableDomainTransferLockResponse EndDisableDomainTransferLock(IAsyncResult asyncResult);

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
        /// restoration, and deletion times"</a> on the website for our registrar associate, Gandi.
        /// Amazon Route 53 requires that you renew before the end of the renewal period that
        /// is listed on the Gandi website so we can complete processing before the deadline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew service method.</param>
        /// 
        /// <returns>The response from the EnableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the EnableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableDomainAutoRenew
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainAutoRenew">REST API Reference for EnableDomainAutoRenew Operation</seealso>
        IAsyncResult BeginEnableDomainAutoRenew(EnableDomainAutoRenewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDomainAutoRenew.</param>
        /// 
        /// <returns>Returns a  EnableDomainAutoRenewResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainAutoRenew">REST API Reference for EnableDomainAutoRenew Operation</seealso>
        EnableDomainAutoRenewResponse EndEnableDomainAutoRenew(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the EnableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableDomainTransferLock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainTransferLock">REST API Reference for EnableDomainTransferLock Operation</seealso>
        IAsyncResult BeginEnableDomainTransferLock(EnableDomainTransferLockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDomainTransferLock.</param>
        /// 
        /// <returns>Returns a  EnableDomainTransferLockResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainTransferLock">REST API Reference for EnableDomainTransferLock Operation</seealso>
        EnableDomainTransferLockResponse EndEnableDomainTransferLock(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the GetContactReachabilityStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactReachabilityStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetContactReachabilityStatus">REST API Reference for GetContactReachabilityStatus Operation</seealso>
        IAsyncResult BeginGetContactReachabilityStatus(GetContactReachabilityStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactReachabilityStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactReachabilityStatus.</param>
        /// 
        /// <returns>Returns a  GetContactReachabilityStatusResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetContactReachabilityStatus">REST API Reference for GetContactReachabilityStatus Operation</seealso>
        GetContactReachabilityStatusResponse EndGetContactReachabilityStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainDetail


        /// <summary>
        /// This operation returns detailed information about a specified domain that is associated
        /// with the current AWS account. Contact information for the domain is also returned
        /// as part of the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail service method.</param>
        /// 
        /// <returns>The response from the GetDomainDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        GetDomainDetailResponse GetDomainDetail(GetDomainDetailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainDetail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        IAsyncResult BeginGetDomainDetail(GetDomainDetailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainDetail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainDetail.</param>
        /// 
        /// <returns>Returns a  GetDomainDetailResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        GetDomainDetailResponse EndGetDomainDetail(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainSuggestions


        /// <summary>
        /// The GetDomainSuggestions operation returns a list of suggested domain names given
        /// a string, which can either be a domain name or simply a word or phrase (without spaces).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions service method.</param>
        /// 
        /// <returns>The response from the GetDomainSuggestions service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        GetDomainSuggestionsResponse GetDomainSuggestions(GetDomainSuggestionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainSuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainSuggestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        IAsyncResult BeginGetDomainSuggestions(GetDomainSuggestionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainSuggestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainSuggestions.</param>
        /// 
        /// <returns>Returns a  GetDomainSuggestionsResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        GetDomainSuggestionsResponse EndGetDomainSuggestions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOperationDetail


        /// <summary>
        /// This operation returns the current status of an operation that is not completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail service method.</param>
        /// 
        /// <returns>The response from the GetOperationDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        GetOperationDetailResponse GetOperationDetail(GetOperationDetailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperationDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperationDetail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        IAsyncResult BeginGetOperationDetail(GetOperationDetailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperationDetail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperationDetail.</param>
        /// 
        /// <returns>Returns a  GetOperationDetailResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        GetOperationDetailResponse EndGetOperationDetail(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains();

        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse EndListDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse ListOperations();

        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse ListOperations(ListOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        IAsyncResult BeginListOperations(ListOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOperations.</param>
        /// 
        /// <returns>Returns a  ListOperationsResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse EndListOperations(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the ListTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        IAsyncResult BeginListTagsForDomain(ListTagsForDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForDomain.</param>
        /// 
        /// <returns>Returns a  ListTagsForDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        ListTagsForDomainResponse EndListTagsForDomain(IAsyncResult asyncResult);

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
        /// Creates a Amazon Route 53 hosted zone that has the same name as the domain. Amazon
        /// Route 53 assigns four name servers to your hosted zone and automatically updates your
        /// domain registration with the names of these name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enables autorenew, so your domain registration will renew automatically each year.
        /// We'll notify you in advance of the renewal date so you can choose whether to renew
        /// the registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optionally enables privacy protection, so WHOIS queries return contact information
        /// either for Amazon Registrar (for .com, .net, and .org domains) or for our registrar
        /// associate, Gandi (for all other TLDs). If you don't enable privacy protection, WHOIS
        /// queries return the information that you entered for the registrant, admin, and tech
        /// contacts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If registration is successful, returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant is notified by email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Charges your AWS account an amount based on the top-level domain. For more information,
        /// see <a href="http://aws.amazon.com/route53/pricing/">Amazon Route 53 Pricing</a>.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        IAsyncResult BeginRegisterDomain(RegisterDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDomain.</param>
        /// 
        /// <returns>Returns a  RegisterDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        RegisterDomainResponse EndRegisterDomain(IAsyncResult asyncResult);

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
        /// <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-renew.html">Renewing
        /// Registration for a Domain</a> in the Amazon Route 53 Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain service method.</param>
        /// 
        /// <returns>The response from the RenewDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the RenewDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenewDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RenewDomain">REST API Reference for RenewDomain Operation</seealso>
        IAsyncResult BeginRenewDomain(RenewDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RenewDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenewDomain.</param>
        /// 
        /// <returns>Returns a  RenewDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RenewDomain">REST API Reference for RenewDomain Operation</seealso>
        RenewDomainResponse EndRenewDomain(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the ResendContactReachabilityEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResendContactReachabilityEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        IAsyncResult BeginResendContactReachabilityEmail(ResendContactReachabilityEmailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResendContactReachabilityEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResendContactReachabilityEmail.</param>
        /// 
        /// <returns>Returns a  ResendContactReachabilityEmailResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        ResendContactReachabilityEmailResponse EndResendContactReachabilityEmail(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        RetrieveDomainAuthCodeResponse RetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveDomainAuthCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveDomainAuthCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        IAsyncResult BeginRetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveDomainAuthCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveDomainAuthCode.</param>
        /// 
        /// <returns>Returns a  RetrieveDomainAuthCodeResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        RetrieveDomainAuthCodeResponse EndRetrieveDomainAuthCode(IAsyncResult asyncResult);

        #endregion
        
        #region  TransferDomain


        /// <summary>
        /// This operation transfers a domain from another registrar to Amazon Route 53. When
        /// the transfer is complete, the domain is registered either with Amazon Registrar (for
        /// .com, .net, and .org domains) or with our registrar associate, Gandi (for all other
        /// TLDs).
        /// 
        ///  
        /// <para>
        /// For transfer requirements, a detailed procedure, and information about viewing the
        /// status of a domain transfer, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
        /// Registration for a Domain to Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the TransferDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTransferDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        IAsyncResult BeginTransferDomain(TransferDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TransferDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTransferDomain.</param>
        /// 
        /// <returns>Returns a  TransferDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        TransferDomainResponse EndTransferDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainContact


        /// <summary>
        /// This operation updates the contact information for a particular domain. You must specify
        /// information for at least one contact: registrant, administrator, or technical.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the UpdateDomainContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContact">REST API Reference for UpdateDomainContact Operation</seealso>
        IAsyncResult BeginUpdateDomainContact(UpdateDomainContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainContact.</param>
        /// 
        /// <returns>Returns a  UpdateDomainContactResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContact">REST API Reference for UpdateDomainContact Operation</seealso>
        UpdateDomainContactResponse EndUpdateDomainContact(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainContactPrivacy


        /// <summary>
        /// This operation updates the specified domain contact's privacy setting. When privacy
        /// protection is enabled, contact information such as email address is replaced either
        /// with contact information for Amazon Registrar (for .com, .net, and .org domains) or
        /// with contact information for our registrar associate, Gandi.
        /// 
        ///  
        /// <para>
        /// This operation affects only the contact information for the specified contact type
        /// (registrant, administrator, or tech). If the request succeeds, Amazon Route 53 returns
        /// an operation ID that you can use with <a>GetOperationDetail</a> to track the progress
        /// and completion of the action. If the request doesn't complete successfully, the domain
        /// registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContactPrivacy service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the UpdateDomainContactPrivacy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainContactPrivacy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContactPrivacy">REST API Reference for UpdateDomainContactPrivacy Operation</seealso>
        IAsyncResult BeginUpdateDomainContactPrivacy(UpdateDomainContactPrivacyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainContactPrivacy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainContactPrivacy.</param>
        /// 
        /// <returns>Returns a  UpdateDomainContactPrivacyResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContactPrivacy">REST API Reference for UpdateDomainContactPrivacy Operation</seealso>
        UpdateDomainContactPrivacyResponse EndUpdateDomainContactPrivacy(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the UpdateDomainNameservers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainNameservers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainNameservers">REST API Reference for UpdateDomainNameservers Operation</seealso>
        IAsyncResult BeginUpdateDomainNameservers(UpdateDomainNameserversRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainNameservers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainNameservers.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameserversResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainNameservers">REST API Reference for UpdateDomainNameservers Operation</seealso>
        UpdateDomainNameserversResponse EndUpdateDomainNameservers(IAsyncResult asyncResult);

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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the UpdateTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTagsForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        IAsyncResult BeginUpdateTagsForDomain(UpdateTagsForDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTagsForDomain.</param>
        /// 
        /// <returns>Returns a  UpdateTagsForDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        UpdateTagsForDomainResponse EndUpdateTagsForDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  ViewBilling


        /// <summary>
        /// Returns all the domain-related billing records for the current AWS account for a specified
        /// period
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling service method.</param>
        /// 
        /// <returns>The response from the ViewBilling service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        ViewBillingResponse ViewBilling(ViewBillingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ViewBilling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndViewBilling
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        IAsyncResult BeginViewBilling(ViewBillingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ViewBilling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginViewBilling.</param>
        /// 
        /// <returns>Returns a  ViewBillingResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        ViewBillingResponse EndViewBilling(IAsyncResult asyncResult);

        #endregion
        
    }
}