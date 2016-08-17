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
    /// AWS Support 
    /// <para>
    /// The AWS Support API reference is intended for programmers who need detailed information
    /// about the AWS Support operations and data types. This service enables you to manage
    /// your AWS Support cases programmatically. It uses HTTP methods that return results
    /// in JSON format.
    /// </para>
    ///  
    /// <para>
    /// The AWS Support service also exposes a set of <a href="https://aws.amazon.com/premiumsupport/trustedadvisor/">Trusted
    /// Advisor</a> features. You can retrieve a list of checks and their descriptions, get
    /// check results, specify checks to refresh, and get the refresh status of checks. 
    /// </para>
    ///  
    /// <para>
    /// The following list describes the AWS Support case management operations: 
    /// </para>
    ///  <ul> <li> <b>Service names, issue categories, and available severity levels. </b>The
    /// <a>DescribeServices</a> and <a>DescribeSeverityLevels</a> operations return AWS service
    /// names, service codes, service categories, and problem severity levels. You use these
    /// values when you call the <a>CreateCase</a> operation. </li> <li> <b>Case creation,
    /// case details, and case resolution.</b> The <a>CreateCase</a>, <a>DescribeCases</a>,
    /// <a>DescribeAttachment</a>, and <a>ResolveCase</a> operations create AWS Support cases,
    /// retrieve information about cases, and resolve cases.</li> <li> <b>Case communication.</b>
    /// The <a>DescribeCommunications</a>, <a>AddCommunicationToCase</a>, and <a>AddAttachmentsToSet</a>
    /// operations retrieve and add communications and attachments to AWS Support cases. </li>
    /// </ul> 
    /// <para>
    /// The following list describes the operations available from the AWS Support service
    /// for Trusted Advisor:
    /// </para>
    ///  <ul> <li> <a>DescribeTrustedAdvisorChecks</a> returns the list of checks that run
    /// against your AWS resources.</li> <li>Using the <code>CheckId</code> for a specific
    /// check returned by <a>DescribeTrustedAdvisorChecks</a>, you can call <a>DescribeTrustedAdvisorCheckResult</a>
    /// to obtain the results for the check you specified.</li> <li> <a>DescribeTrustedAdvisorCheckSummaries</a>
    /// returns summarized results for one or more Trusted Advisor checks.</li> <li> <a>RefreshTrustedAdvisorCheck</a>
    /// requests that Trusted Advisor rerun a specified check. </li> <li> <a>DescribeTrustedAdvisorCheckRefreshStatuses</a>
    /// reports the refresh status of one or more checks. </li> </ul> 
    /// <para>
    /// For authentication of requests, AWS Support uses <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///  
    /// <para>
    /// See <a href="http://docs.aws.amazon.com/awssupport/latest/user/Welcome.html">About
    /// the AWS Support API</a> in the <i>AWS Support User Guide</i> for information about
    /// how to use this service to create and manage your support cases, and how to call Trusted
    /// Advisor for results of checks on your resources. 
    /// </para>
    /// </summary>
    public partial interface IAmazonAWSSupport : IAmazonService, IDisposable
    {
                
        #region  AddAttachmentsToSet


        /// <summary>
        /// Initiates the asynchronous execution of the AddAttachmentsToSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddAttachmentsToSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddAttachmentsToSetResponse> AddAttachmentsToSetAsync(AddAttachmentsToSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddCommunicationToCase


        /// <summary>
        /// Initiates the asynchronous execution of the AddCommunicationToCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCommunicationToCase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddCommunicationToCaseResponse> AddCommunicationToCaseAsync(AddCommunicationToCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCase


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAttachment


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttachment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAttachmentResponse> DescribeAttachmentAsync(DescribeAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCases


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCasesResponse> DescribeCasesAsync(DescribeCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCommunications


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommunications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommunications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCommunicationsResponse> DescribeCommunicationsAsync(DescribeCommunicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeServices


        /// <summary>
        /// Returns the current list of AWS services and a list of service categories that applies
        /// to each one. You then use service names and categories in your <a>CreateCase</a> requests.
        /// Each AWS service has its own set of categories.
        /// 
        ///  
        /// <para>
        /// The service codes and category codes correspond to the values that are displayed in
        /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a
        /// href="https://console.aws.amazon.com/support/home#/case/create">Create Case</a> page.
        /// The values in those fields, however, do not necessarily match the service codes and
        /// categories returned by the <code>DescribeServices</code> request. Always use the service
        /// codes and categories obtained programmatically. This practice ensures that you always
        /// have the most recent set of service and category codes.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        Task<DescribeServicesResponse> DescribeServicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSeverityLevels


        /// <summary>
        /// Returns the list of severity levels that you can assign to an AWS Support case. The
        /// severity level for a case is also a field in the <a>CaseDetails</a> data type included
        /// in any <a>CreateCase</a> request.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AWSSupport.</returns>
        /// <exception cref="Amazon.AWSSupport.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        Task<DescribeSeverityLevelsResponse> DescribeSeverityLevelsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSeverityLevels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSeverityLevels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSeverityLevelsResponse> DescribeSeverityLevelsAsync(DescribeSeverityLevelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrustedAdvisorCheckRefreshStatuses


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckRefreshStatuses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckRefreshStatuses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTrustedAdvisorCheckRefreshStatusesResponse> DescribeTrustedAdvisorCheckRefreshStatusesAsync(DescribeTrustedAdvisorCheckRefreshStatusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrustedAdvisorCheckResult


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTrustedAdvisorCheckResultResponse> DescribeTrustedAdvisorCheckResultAsync(DescribeTrustedAdvisorCheckResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrustedAdvisorChecks


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTrustedAdvisorChecksResponse> DescribeTrustedAdvisorChecksAsync(DescribeTrustedAdvisorChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrustedAdvisorCheckSummaries


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckSummaries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTrustedAdvisorCheckSummariesResponse> DescribeTrustedAdvisorCheckSummariesAsync(DescribeTrustedAdvisorCheckSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RefreshTrustedAdvisorCheck


        /// <summary>
        /// Initiates the asynchronous execution of the RefreshTrustedAdvisorCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RefreshTrustedAdvisorCheckResponse> RefreshTrustedAdvisorCheckAsync(RefreshTrustedAdvisorCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResolveCase


        /// <summary>
        /// Initiates the asynchronous execution of the ResolveCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveCase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResolveCaseResponse> ResolveCaseAsync(ResolveCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}