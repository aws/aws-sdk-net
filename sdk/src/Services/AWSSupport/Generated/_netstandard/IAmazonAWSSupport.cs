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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AWSSupport.Model;

namespace Amazon.AWSSupport
{
    /// <summary>
    /// Interface for accessing AWSSupport
    ///
    /// Amazon Web Services Support 
    /// <para>
    /// The <i>Amazon Web Services Support API Reference</i> is intended for programmers who
    /// need detailed information about the Amazon Web Services Support operations and data
    /// types. You can use the API to manage your support cases programmatically. The Amazon
    /// Web Services Support API uses HTTP methods that return results in JSON format.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
    /// Amazon Web Services Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// You can also use the Amazon Web Services Support API to access features for <a href="http://aws.amazon.com/premiumsupport/trustedadvisor/">Trusted
    /// Advisor</a>. You can return a list of checks and their descriptions, get check results,
    /// specify checks to refresh, and get the refresh status of checks.
    /// </para>
    ///  
    /// <para>
    /// You can manage your support cases with the following Amazon Web Services Support API
    /// operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <a>CreateCase</a>, <a>DescribeCases</a>, <a>DescribeAttachment</a>, and <a>ResolveCase</a>
    /// operations create Amazon Web Services Support cases, retrieve information about cases,
    /// and resolve cases.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <a>DescribeCommunications</a>, <a>AddCommunicationToCase</a>, and <a>AddAttachmentsToSet</a>
    /// operations retrieve and add communications and attachments to Amazon Web Services
    /// Support cases.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <a>DescribeServices</a> and <a>DescribeSeverityLevels</a> operations return Amazon
    /// Web Service names, service codes, service categories, and problem severity levels.
    /// You use these values when you call the <a>CreateCase</a> operation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can also use the Amazon Web Services Support API to call the Trusted Advisor operations.
    /// For more information, see <a href="https://docs.aws.amazon.com/">Trusted Advisor</a>
    /// in the <i>Amazon Web Services Support User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For authentication of requests, Amazon Web Services Support uses <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about this service and the endpoints to use, see <a href="https://docs.aws.amazon.com/awssupport/latest/user/about-support-api.html">About
    /// the Amazon Web Services Support API</a> in the <i>Amazon Web Services Support User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAWSSupport : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAWSSupportPaginatorFactory Paginators { get; }
#endif
                
        #region  AddAttachmentsToSet



        /// <summary>
        /// Adds one or more attachments to an attachment set. 
        /// 
        ///  
        /// <para>
        /// An attachment set is a temporary container for attachments that you add to a case
        /// or case communication. The set is available for 1 hour after it's created. The <code>expiryTime</code>
        /// returned in the response is when the set expires. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttachmentsToSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddAttachmentsToSet service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentLimitExceededException">
        /// The limit for the number of attachment sets created in a short period of time has
        /// been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetExpiredException">
        /// The expiration time of the attachment set has passed. The set expires 1 hour after
        /// it is created.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetIdNotFoundException">
        /// An attachment set with the specified ID could not be found.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetSizeLimitExceededException">
        /// A limit for the size of an attachment set has been exceeded. The limits are three
        /// attachments and 5 MB per attachment.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/AddAttachmentsToSet">REST API Reference for AddAttachmentsToSet Operation</seealso>
        Task<AddAttachmentsToSetResponse> AddAttachmentsToSetAsync(AddAttachmentsToSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddCommunicationToCase



        /// <summary>
        /// Adds additional customer communication to an Amazon Web Services Support case. Use
        /// the <code>caseId</code> parameter to identify the case to which to add communication.
        /// You can list a set of email addresses to copy on the communication by using the <code>ccEmailAddresses</code>
        /// parameter. The <code>communicationBody</code> value contains the text of the communication.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCommunicationToCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddCommunicationToCase service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetExpiredException">
        /// The expiration time of the attachment set has passed. The set expires 1 hour after
        /// it is created.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetIdNotFoundException">
        /// An attachment set with the specified ID could not be found.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.CaseIdNotFoundException">
        /// The requested <code>caseId</code> couldn't be located.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/AddCommunicationToCase">REST API Reference for AddCommunicationToCase Operation</seealso>
        Task<AddCommunicationToCaseResponse> AddCommunicationToCaseAsync(AddCommunicationToCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCase



        /// <summary>
        /// Creates a case in the Amazon Web Services Support Center. This operation is similar
        /// to how you create a case in the Amazon Web Services Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
        /// Case</a> page.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Support API doesn't support requesting service limit increases.
        /// You can submit a service limit increase in the following ways: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Submit a request from the Amazon Web Services Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
        /// Case</a> page.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the Service Quotas <a href="https://docs.aws.amazon.com/servicequotas/2019-06-24/apireference/API_RequestServiceQuotaIncrease.html">RequestServiceQuotaIncrease</a>
        /// operation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A successful <code>CreateCase</code> request returns an Amazon Web Services Support
        /// case number. You can use the <a>DescribeCases</a> operation and specify the case number
        /// to get existing Amazon Web Services Support cases. After you create a case, use the
        /// <a>AddCommunicationToCase</a> operation to add additional communication or attachments
        /// to an existing case.
        /// </para>
        ///  
        /// <para>
        /// The <code>caseId</code> is separate from the <code>displayId</code> that appears in
        /// the <a href="https://console.aws.amazon.com/support">Amazon Web Services Support Center</a>.
        /// Use the <a>DescribeCases</a> operation to get the <code>displayId</code>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetExpiredException">
        /// The expiration time of the attachment set has passed. The set expires 1 hour after
        /// it is created.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentSetIdNotFoundException">
        /// An attachment set with the specified ID could not be found.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.CaseCreationLimitExceededException">
        /// The case creation limit for the account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/CreateCase">REST API Reference for CreateCase Operation</seealso>
        Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAttachment



        /// <summary>
        /// Returns the attachment that has the specified ID. Attachments can include screenshots,
        /// error logs, or other files that describe your issue. Attachment IDs are generated
        /// by the case management system when you add an attachment to a case or case communication.
        /// Attachment IDs are returned in the <a>AttachmentDetails</a> objects that are returned
        /// by the <a>DescribeCommunications</a> operation.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAttachment service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.AttachmentIdNotFoundException">
        /// An attachment with the specified ID could not be found.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.DescribeAttachmentLimitExceededException">
        /// The limit for the number of <a>DescribeAttachment</a> requests in a short period of
        /// time has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeAttachment">REST API Reference for DescribeAttachment Operation</seealso>
        Task<DescribeAttachmentResponse> DescribeAttachmentAsync(DescribeAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCases



        /// <summary>
        /// Returns a list of cases that you specify by passing one or more case IDs. You can
        /// use the <code>afterTime</code> and <code>beforeTime</code> parameters to filter the
        /// cases by date. You can set values for the <code>includeResolvedCases</code> and <code>includeCommunications</code>
        /// parameters to specify how much information to return.
        /// 
        ///  
        /// <para>
        /// The response returns the following in JSON format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more <a href="https://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html">CaseDetails</a>
        /// data types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One or more <code>nextToken</code> values, which specify where to paginate the returned
        /// records represented by the <code>CaseDetails</code> objects.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Case data is available for 12 months after creation. If a case was created more than
        /// 12 months ago, a request might return an error.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCases service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.CaseIdNotFoundException">
        /// The requested <code>caseId</code> couldn't be located.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeCases">REST API Reference for DescribeCases Operation</seealso>
        Task<DescribeCasesResponse> DescribeCasesAsync(DescribeCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCommunications



        /// <summary>
        /// Returns communications and attachments for one or more support cases. Use the <code>afterTime</code>
        /// and <code>beforeTime</code> parameters to filter by date. You can use the <code>caseId</code>
        /// parameter to restrict the results to a specific case.
        /// 
        ///  
        /// <para>
        /// Case data is available for 12 months after creation. If a case was created more than
        /// 12 months ago, a request for data might cause an error.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>maxResults</code> and <code>nextToken</code> parameters to control
        /// the pagination of the results. Set <code>maxResults</code> to the number of cases
        /// that you want to display on each page, and use <code>nextToken</code> to specify the
        /// resumption of pagination.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommunications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCommunications service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.CaseIdNotFoundException">
        /// The requested <code>caseId</code> couldn't be located.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeCommunications">REST API Reference for DescribeCommunications Operation</seealso>
        Task<DescribeCommunicationsResponse> DescribeCommunicationsAsync(DescribeCommunicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeServices


        /// <summary>
        /// Returns the current list of Amazon Web Services services and a list of service categories
        /// for each service. You then use service names and categories in your <a>CreateCase</a>
        /// requests. Each Amazon Web Services service has its own set of categories.
        /// 
        ///  
        /// <para>
        /// The service codes and category codes correspond to the values that appear in the <b>Service</b>
        /// and <b>Category</b> lists on the Amazon Web Services Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
        /// Case</a> page. The values in those fields don't necessarily match the service codes
        /// and categories returned by the <code>DescribeServices</code> operation. Always use
        /// the service codes and categories that the <code>DescribeServices</code> operation
        /// returns, so that you have the most recent set of service and category codes.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        Task<DescribeServicesResponse> DescribeServicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns the current list of Amazon Web Services services and a list of service categories
        /// for each service. You then use service names and categories in your <a>CreateCase</a>
        /// requests. Each Amazon Web Services service has its own set of categories.
        /// 
        ///  
        /// <para>
        /// The service codes and category codes correspond to the values that appear in the <b>Service</b>
        /// and <b>Category</b> lists on the Amazon Web Services Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
        /// Case</a> page. The values in those fields don't necessarily match the service codes
        /// and categories returned by the <code>DescribeServices</code> operation. Always use
        /// the service codes and categories that the <code>DescribeServices</code> operation
        /// returns, so that you have the most recent set of service and category codes.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSeverityLevels


        /// <summary>
        /// Returns the list of severity levels that you can assign to a support case. The severity
        /// level for a case is also a field in the <a>CaseDetails</a> data type that you include
        /// for a <a>CreateCase</a> request.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeSeverityLevels">REST API Reference for DescribeSeverityLevels Operation</seealso>
        Task<DescribeSeverityLevelsResponse> DescribeSeverityLevelsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns the list of severity levels that you can assign to a support case. The severity
        /// level for a case is also a field in the <a>CaseDetails</a> data type that you include
        /// for a <a>CreateCase</a> request.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSeverityLevels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeSeverityLevels">REST API Reference for DescribeSeverityLevels Operation</seealso>
        Task<DescribeSeverityLevelsResponse> DescribeSeverityLevelsAsync(DescribeSeverityLevelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrustedAdvisorCheckRefreshStatuses



        /// <summary>
        /// Returns the refresh status of the Trusted Advisor checks that have the specified check
        /// IDs. You can get the check IDs by calling the <a>DescribeTrustedAdvisorChecks</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// Some checks are refreshed automatically, and you can't return their refresh statuses
        /// by using the <code>DescribeTrustedAdvisorCheckRefreshStatuses</code> operation. If
        /// you call this operation for these checks, you might see an <code>InvalidParameterValue</code>
        /// error.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// To call the Trusted Advisor operations in the Amazon Web Services Support API, you
        /// must use the US East (N. Virginia) endpoint. Currently, the US West (Oregon) and Europe
        /// (Ireland) endpoints don't support the Trusted Advisor operations. For more information,
        /// see <a href="https://docs.aws.amazon.com/awssupport/latest/user/about-support-api.html#endpoint">About
        /// the Amazon Web Services Support API</a> in the <i>Amazon Web Services Support User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckRefreshStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckRefreshStatuses service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeTrustedAdvisorCheckRefreshStatuses">REST API Reference for DescribeTrustedAdvisorCheckRefreshStatuses Operation</seealso>
        Task<DescribeTrustedAdvisorCheckRefreshStatusesResponse> DescribeTrustedAdvisorCheckRefreshStatusesAsync(DescribeTrustedAdvisorCheckRefreshStatusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrustedAdvisorCheckResult



        /// <summary>
        /// Returns the results of the Trusted Advisor check that has the specified check ID.
        /// You can get the check IDs by calling the <a>DescribeTrustedAdvisorChecks</a> operation.
        /// 
        ///  
        /// <para>
        /// The response contains a <a>TrustedAdvisorCheckResult</a> object, which contains these
        /// three objects:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>TrustedAdvisorCategorySpecificSummary</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TrustedAdvisorResourceDetail</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TrustedAdvisorResourcesSummary</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In addition, the response contains these fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>status</b> - The alert status of the check can be <code>ok</code> (green), <code>warning</code>
        /// (yellow), <code>error</code> (red), or <code>not_available</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>timestamp</b> - The time of the last refresh of the check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>checkId</b> - The unique identifier for the check.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// To call the Trusted Advisor operations in the Amazon Web Services Support API, you
        /// must use the US East (N. Virginia) endpoint. Currently, the US West (Oregon) and Europe
        /// (Ireland) endpoints don't support the Trusted Advisor operations. For more information,
        /// see <a href="https://docs.aws.amazon.com/awssupport/latest/user/about-support-api.html#endpoint">About
        /// the Amazon Web Services Support API</a> in the <i>Amazon Web Services Support User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckResult service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeTrustedAdvisorCheckResult">REST API Reference for DescribeTrustedAdvisorCheckResult Operation</seealso>
        Task<DescribeTrustedAdvisorCheckResultResponse> DescribeTrustedAdvisorCheckResultAsync(DescribeTrustedAdvisorCheckResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrustedAdvisorChecks



        /// <summary>
        /// Returns information about all available Trusted Advisor checks, including the name,
        /// ID, category, description, and metadata. You must specify a language code.
        /// 
        ///  
        /// <para>
        /// The response contains a <a>TrustedAdvisorCheckDescription</a> object for each check.
        /// You must set the Amazon Web Services Region to us-east-1.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The names and descriptions for Trusted Advisor checks are subject to change. We recommend
        /// that you specify the check ID in your code to uniquely identify a check.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// To call the Trusted Advisor operations in the Amazon Web Services Support API, you
        /// must use the US East (N. Virginia) endpoint. Currently, the US West (Oregon) and Europe
        /// (Ireland) endpoints don't support the Trusted Advisor operations. For more information,
        /// see <a href="https://docs.aws.amazon.com/awssupport/latest/user/about-support-api.html#endpoint">About
        /// the Amazon Web Services Support API</a> in the <i>Amazon Web Services Support User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorChecks service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeTrustedAdvisorChecks">REST API Reference for DescribeTrustedAdvisorChecks Operation</seealso>
        Task<DescribeTrustedAdvisorChecksResponse> DescribeTrustedAdvisorChecksAsync(DescribeTrustedAdvisorChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrustedAdvisorCheckSummaries



        /// <summary>
        /// Returns the results for the Trusted Advisor check summaries for the check IDs that
        /// you specified. You can get the check IDs by calling the <a>DescribeTrustedAdvisorChecks</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// The response contains an array of <a>TrustedAdvisorCheckSummary</a> objects.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// To call the Trusted Advisor operations in the Amazon Web Services Support API, you
        /// must use the US East (N. Virginia) endpoint. Currently, the US West (Oregon) and Europe
        /// (Ireland) endpoints don't support the Trusted Advisor operations. For more information,
        /// see <a href="https://docs.aws.amazon.com/awssupport/latest/user/about-support-api.html#endpoint">About
        /// the Amazon Web Services Support API</a> in the <i>Amazon Web Services Support User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckSummaries service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/DescribeTrustedAdvisorCheckSummaries">REST API Reference for DescribeTrustedAdvisorCheckSummaries Operation</seealso>
        Task<DescribeTrustedAdvisorCheckSummariesResponse> DescribeTrustedAdvisorCheckSummariesAsync(DescribeTrustedAdvisorCheckSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RefreshTrustedAdvisorCheck



        /// <summary>
        /// Refreshes the Trusted Advisor check that you specify using the check ID. You can get
        /// the check IDs by calling the <a>DescribeTrustedAdvisorChecks</a> operation.
        /// 
        ///  
        /// <para>
        /// Some checks are refreshed automatically. If you call the <code>RefreshTrustedAdvisorCheck</code>
        /// operation to refresh them, you might see the <code>InvalidParameterValue</code> error.
        /// </para>
        ///  
        /// <para>
        /// The response contains a <a>TrustedAdvisorCheckRefreshStatus</a> object.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// To call the Trusted Advisor operations in the Amazon Web Services Support API, you
        /// must use the US East (N. Virginia) endpoint. Currently, the US West (Oregon) and Europe
        /// (Ireland) endpoints don't support the Trusted Advisor operations. For more information,
        /// see <a href="https://docs.aws.amazon.com/awssupport/latest/user/about-support-api.html#endpoint">About
        /// the Amazon Web Services Support API</a> in the <i>Amazon Web Services Support User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RefreshTrustedAdvisorCheck service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/RefreshTrustedAdvisorCheck">REST API Reference for RefreshTrustedAdvisorCheck Operation</seealso>
        Task<RefreshTrustedAdvisorCheckResponse> RefreshTrustedAdvisorCheckAsync(RefreshTrustedAdvisorCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResolveCase



        /// <summary>
        /// Resolves a support case. This operation takes a <code>caseId</code> and returns the
        /// initial and final state of the case.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
        /// Amazon Web Services Support API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you call the Amazon Web Services Support API from an account that doesn't have
        /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
        /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResolveCase service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.CaseIdNotFoundException">
        /// The requested <code>caseId</code> couldn't be located.
        /// </exception>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-2013-04-15/ResolveCase">REST API Reference for ResolveCase Operation</seealso>
        Task<ResolveCaseResponse> ResolveCaseAsync(ResolveCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}