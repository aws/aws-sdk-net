/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.AWSSupport.Model;

namespace Amazon.AWSSupport
{
    /// <summary>
    /// Interface for accessing AmazonAWSSupport.
    /// 
    /// AWS Support <para>The AWS Support API reference is intended for programmers who need detailed information about the AWS Support actions and
    /// data types. This service enables you to manage your AWS Support cases programmatically. It uses HTTP methods that return results in JSON
    /// format.</para> <para>The AWS Support service also exposes a set of <a href="https://aws.amazon.com/support/trustedadvisor">Trusted
    /// Advisor</a> features. You can retrieve a list of checks you can run on your resources, specify checks to run and refresh, and check the
    /// status of checks you have submitted. </para> <para>The following list describes the AWS Support case management actions: </para>
    /// <ul>
    /// <li> <b>Service names, issue categories, and available severity levels. </b> The actions <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html">DescribeServices</a> and <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeSeverityLevels.html">DescribeSeverityLevels</a> enable you to
    /// obtain AWS service names, service codes, service categories, and problem severity levels. You use these values when you call the <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html">CreateCase</a> action. </li>
    /// <li> <b>Case Creation, case details, and case resolution</b> . The actions <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html">CreateCase</a> ,
    /// <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeCases.html">DescribeCases</a> , and <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_ResolveCase.html">ResolveCase</a> enable you to create AWS Support
    /// cases, retrieve them, and resolve them.</li>
    /// <li> <b>Case communication</b> . The actions <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeCommunications.html">DescribeCommunications</a> and <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_AddCommunicationToCase.html">AddCommunicationToCase</a> enable you to
    /// retrieve and add communication to AWS Support cases. </li>
    /// 
    /// </ul>
    /// <para>The following list describes the actions available from the AWS Support service for Trusted Advisor:</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorChecks.html">DescribeTrustedAdvisorChecks</a> returns the list of checks that you can run against your AWS resources.</li>
    /// <li>Using the CheckId for a specific check returned by DescribeTrustedAdvisorChecks, you can call <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckResult.html">DescribeTrustedAdvisorCheckResult</a> </li>
    /// and obtain a new result for the check you specified. <li> Using <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckSummaries.html">DescribeTrustedAdvisorCheckSummaries</a> , you can get summaries for a set of Trusted Advisor checks.</li>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_RefreshTrustedAdvisorCheck.html">RefreshTrustedAdvisorCheck</a> enables you to request that Trusted Advisor run the check again. </li>
    /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckRefreshStatuses.html">DescribeTrustedAdvisorCheckRefreshStatuses</a> gets statuses on the checks you are running. </li>
    /// 
    /// </ul>
    /// <para>For authentication of requests, the AWS Support uses <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature Version 4 Signing Process</a> .</para> <para>See the AWS Support <a href="http://docs.aws.amazon.com/awssupport/latest/developerguide/Welcome.html">Developer Guide</a> for information about how to use this
    /// service to manage create and manage your support cases, and how to call Trusted Advisor for results of checks on your resources. </para>
    /// </summary>
	public partial interface IAmazonAWSSupport : IDisposable
    {
 

        /// <summary>
        /// <para>This action adds additional customer communication to an AWS Support case. You use the <i>CaseId</i> value to identify the case to
        /// which you want to add communication. You can list a set of email addresses to copy on the communication using the <i>CcEmailAddresses</i>
        /// value. The <i>CommunicationBody</i> value contains the text of the communication.</para> <para>This action's response indicates the success
        /// or failure of the request.</para> <para>This action implements a subset of the behavior on the AWS Support <a href="https://aws.amazon.com/support">Your Support Cases</a> web form.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCommunicationToCase service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the AddCommunicationToCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
		AddCommunicationToCaseResponse AddCommunicationToCase(AddCommunicationToCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddCommunicationToCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.AddCommunicationToCase"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCommunicationToCase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddCommunicationToCaseResponse> AddCommunicationToCaseAsync(AddCommunicationToCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new case in the AWS Support Center. This action is modeled on the behavior of the AWS Support Center <a href="https://aws.amazon.com/support/createCase">Open a new case</a> page. Its parameters require you to specify the following information:
        /// </para> <ol> <li> <b>ServiceCode.</b> Represents a code for an AWS service. You obtain the <i>ServiceCode</i> by calling <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html">DescribeServices</a> . </li>
        /// <li> <b>CategoryCode</b> . Represents a category for the service defined for the ServiceCode value. You also obtain the cateogory code for
        /// a service by calling <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html">DescribeServices</a> .
        /// Each AWS service defines its own set of category codes. </li>
        /// <li> <b>SeverityCode</b> . Represents a value that specifies the urgency of the case, and the time interval in which your service level
        /// agreement specifies a response from AWS Support. You obtain the SeverityCode by calling <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeSeverityLevels.html">DescribeSeverityLevels</a> .</li>
        /// <li> <b>Subject</b> . Represents the <b>Subject</b> field on the AWS Support Center <a href="https://aws.amazon.com/support/createCase">Open a new case</a> page.</li>
        /// <li> <b>CommunicationBody</b> . Represents the <b>Description</b> field on the AWS Support Center <a href="https://aws.amazon.com/support/createCase">Open a new case</a> page.</li>
        /// <li> <b>Language</b> . Specifies the human language in which AWS Support handles the case. The API currently supports English and
        /// Japanese.</li>
        /// <li> <b>CcEmailAddresses</b> . Represents the AWS Support Center <b>CC</b> field on the <a href="https://aws.amazon.com/support/createCase">Open a new case</a> page. You can list email addresses to be copied on any correspondence
        /// about the case. The account that opens the case is already identified by passing the AWS Credentials in the HTTP POST method or in a method
        /// or function call from one of the programming languages supported by an <a href="http://aws.amazon.com/tools/">AWS SDK</a> . </li>
        /// <li> <b>IssueType</b> . Indicates the type of issue for the case. You can specify either "customer-service" or "technical." If you do not
        /// indicate a value, this parameter defaults to "technical." </li>
        /// </ol> <para><b>NOTE:</b>The AWS Support API does not currently support the ability to add attachments to cases. You can, however, call
        /// AddCommunicationToCase to add information to an open case. </para> <para>A successful <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html">CreateCase</a> request returns an AWS Support case
        /// number. Case numbers are used by <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeCases.html">DescribeCases</a> request to retrieve existing AWS Support support cases. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseCreationLimitExceededException" />
		CreateCaseResponse CreateCase(CreateCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.CreateCase"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This action returns a list of cases that you specify by passing one or more CaseIds. In addition, you can filter the cases by date by
        /// setting values for the AfterTime and BeforeTime request parameters. </para> <para> The response returns the following in JSON format:
        /// </para> <ol> <li>One or more <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html">CaseDetails</a> data
        /// types. </li>
        /// <li>One or more <i>NextToken</i> objects, strings that specifies where to paginate the returned records represented by <i>CaseDetails</i>
        /// .</li>
        /// </ol>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCases service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeCases service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
		DescribeCasesResponse DescribeCases(DescribeCasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCases operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeCases"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCasesResponse> DescribeCasesAsync(DescribeCasesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This action returns a list of cases that you specify by passing one or more CaseIds. In addition, you can filter the cases by date by
        /// setting values for the AfterTime and BeforeTime request parameters. </para> <para> The response returns the following in JSON format:
        /// </para> <ol> <li>One or more <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html">CaseDetails</a> data
        /// types. </li>
        /// <li>One or more <i>NextToken</i> objects, strings that specifies where to paginate the returned records represented by <i>CaseDetails</i>
        /// .</li>
        /// </ol>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeCases service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
		DescribeCasesResponse DescribeCases();
 

        /// <summary>
        /// <para>This action returns communications regarding the support case. You can use the <i>AfterTime</i> and <i>BeforeTime</i> parameters to
        /// filter by date. The <i>CaseId</i> parameter enables you to identify a specific case by its <i>CaseId</i> number.</para> <para>The
        /// <i>MaxResults</i> and <i>NextToken</i> parameters enable you to control the pagination of the result set. Set <i>MaxResults</i> to the
        /// number of cases you want displayed on each page, and use <i>NextToken</i> to specify the resumption of pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommunications service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeCommunications service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
		DescribeCommunicationsResponse DescribeCommunications(DescribeCommunicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommunications operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeCommunications"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommunications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCommunicationsResponse> DescribeCommunicationsAsync(DescribeCommunicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the current list of AWS services and a list of service categories that applies to each one. You then use service names and
        /// categories in your <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html">CreateCase</a> requests. Each
        /// AWS service has its own set of categories.</para> <para>The service codes and category codes correspond to the values that are displayed in
        /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a href="https://aws.amazon.com/support/createCase">Open a
        /// new case</a> page. The values in those fields, however, do not necessarily match the service codes and categories returned by the
        /// <c>DescribeServices</c> request. Always use the service codes and categories obtained programmatically. This practice ensures that you
        /// always have the most recent set of service and category codes.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
		DescribeServicesResponse DescribeServices(DescribeServicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeServices"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the current list of AWS services and a list of service categories that applies to each one. You then use service names and
        /// categories in your <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html">CreateCase</a> requests. Each
        /// AWS service has its own set of categories.</para> <para>The service codes and category codes correspond to the values that are displayed in
        /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a href="https://aws.amazon.com/support/createCase">Open a
        /// new case</a> page. The values in those fields, however, do not necessarily match the service codes and categories returned by the
        /// <c>DescribeServices</c> request. Always use the service codes and categories obtained programmatically. This practice ensures that you
        /// always have the most recent set of service and category codes.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
		DescribeServicesResponse DescribeServices();
 

        /// <summary>
        /// <para>This action returns the list of severity levels that you can assign to an AWS Support case. The severity level for a case is also a
        /// field in the <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html">CaseDetails</a> data type included in
        /// any <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html">CreateCase</a> request. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSeverityLevels service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
		DescribeSeverityLevelsResponse DescribeSeverityLevels(DescribeSeverityLevelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSeverityLevels operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeSeverityLevels"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSeverityLevels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSeverityLevelsResponse> DescribeSeverityLevelsAsync(DescribeSeverityLevelsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This action returns the list of severity levels that you can assign to an AWS Support case. The severity level for a case is also a
        /// field in the <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html">CaseDetails</a> data type included in
        /// any <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html">CreateCase</a> request. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
		DescribeSeverityLevelsResponse DescribeSeverityLevels();
 

        /// <summary>
        /// <para>Returns the status of all refresh requests Trusted Advisor checks called using <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_RefreshTrustedAdvisorCheck.html">RefreshTrustedAdvisorCheck</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeTrustedAdvisorCheckRefreshStatuses service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckRefreshStatuses service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
		DescribeTrustedAdvisorCheckRefreshStatusesResponse DescribeTrustedAdvisorCheckRefreshStatuses(DescribeTrustedAdvisorCheckRefreshStatusesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckRefreshStatuses operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorCheckRefreshStatuses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckRefreshStatuses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTrustedAdvisorCheckRefreshStatusesResponse> DescribeTrustedAdvisorCheckRefreshStatusesAsync(DescribeTrustedAdvisorCheckRefreshStatusesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This action responds with the results of a Trusted Advisor check. Once you have obtained the list of available Trusted Advisor checks
        /// by calling <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorChecks.html">DescribeTrustedAdvisorChecks</a> , you specify the <i>CheckId</i> for the check you want to retrieve from AWS Support.</para> <para>The
        /// response for this action contains a JSON-formatted <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorCheckResultResult.html">TrustedAdvisorCheckResult</a> object</para> <para>, which is a container for the following three objects:</para> <ol> <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorCategorySpecificSummary.html">TrustedAdvisorCategorySpecificSummary</a> </li>
        /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorResourceDetail.html">TrustedAdvisorResourceDetail</a> </li>
        /// <li> <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorResourcesSummary.html">TrustedAdvisorResourcesSummary</a> </li>
        /// </ol> <para>In addition, the response contains the following fields:</para> <ol> <li> <b>Status</b> . Overall status of the check.</li>
        /// <li> <b>Timestamp</b> . Time at which Trusted Advisor last ran the check. </li>
        /// <li> <b>CheckId</b> . Unique identifier for the specific check returned by the request.</li>
        /// </ol>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeTrustedAdvisorCheckResult service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckResult service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
		DescribeTrustedAdvisorCheckResultResponse DescribeTrustedAdvisorCheckResult(DescribeTrustedAdvisorCheckResultRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckResult operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorCheckResult"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTrustedAdvisorCheckResultResponse> DescribeTrustedAdvisorCheckResultAsync(DescribeTrustedAdvisorCheckResultRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This action enables you to get a list of the available Trusted Advisor checks. You must specify a language code. English ("en") and
        /// Japanese ("jp") are currently supported. The response contains a list of <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorCheckDescription.html">TrustedAdvisorCheckDescription</a>
        /// objects. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks service
        /// method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorChecks service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
		DescribeTrustedAdvisorChecksResponse DescribeTrustedAdvisorChecks(DescribeTrustedAdvisorChecksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorChecks operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorChecks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTrustedAdvisorChecksResponse> DescribeTrustedAdvisorChecksAsync(DescribeTrustedAdvisorChecksRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This action enables you to get the latest summaries for Trusted Advisor checks that you specify in your request. You submit the list
        /// of Trusted Advisor checks for which you want summaries. You obtain these <i>CheckIds</i> by submitting a <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeTrustedAdvisorChecks.html">DescribeTrustedAdvisorChecks</a>
        /// request. </para> <para>The response body contains an array of <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_TrustedAdvisorCheckSummary.html">TrustedAdvisorCheckSummary</a>
        /// objects. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeTrustedAdvisorCheckSummaries service method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckSummaries service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
		DescribeTrustedAdvisorCheckSummariesResponse DescribeTrustedAdvisorCheckSummaries(DescribeTrustedAdvisorCheckSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckSummaries operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.DescribeTrustedAdvisorCheckSummaries"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckSummaries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTrustedAdvisorCheckSummariesResponse> DescribeTrustedAdvisorCheckSummariesAsync(DescribeTrustedAdvisorCheckSummariesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This action enables you to query the service to request a refresh for a specific Trusted Advisor check. Your request body contains a
        /// <i>CheckId</i> for which you are querying. The response body contains a <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_RefreshTrustedAdvisorCheckResult.html">RefreshTrustedAdvisorCheckResult</a> object containing <i>Status</i> and <i>TimeUntilNextRefresh</i> fields.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck service
        /// method on AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the RefreshTrustedAdvisorCheck service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
		RefreshTrustedAdvisorCheckResponse RefreshTrustedAdvisorCheck(RefreshTrustedAdvisorCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RefreshTrustedAdvisorCheck operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.RefreshTrustedAdvisorCheck"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RefreshTrustedAdvisorCheckResponse> RefreshTrustedAdvisorCheckAsync(RefreshTrustedAdvisorCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Takes a <i>CaseId</i> and returns the initial state of the case along with the state of the case after the call to <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_ResolveCase.html">ResolveCase</a> completed.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveCase service method on
        /// AmazonAWSSupport.</param>
        /// 
        /// <returns>The response from the ResolveCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
		ResolveCaseResponse ResolveCase(ResolveCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport.ResolveCase"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveCase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ResolveCaseResponse> ResolveCaseAsync(ResolveCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Takes a <i>CaseId</i> and returns the initial state of the case along with the state of the case after the call to <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_ResolveCase.html">ResolveCase</a> completed.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ResolveCase service method, as returned by AmazonAWSSupport.</returns>
        /// 
        /// <exception cref="T:Amazon.AWSSupport.Model.InternalServerErrorException" />
        /// <exception cref="T:Amazon.AWSSupport.Model.CaseIdNotFoundException" />
		ResolveCaseResponse ResolveCase();
    }
}
