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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GuardDuty.Model;

#pragma warning disable CS1570
namespace Amazon.GuardDuty
{
    /// <summary>
    /// <para>Interface for accessing GuardDuty</para>
    ///
    /// Amazon GuardDuty is a continuous security monitoring service that analyzes and processes
    /// the following foundational data sources - VPC flow logs, Amazon Web Services CloudTrail
    /// management event logs, CloudTrail S3 data event logs, EKS audit logs, DNS logs, Amazon
    /// EBS volume data, runtime activity belonging to container workloads, such as Amazon
    /// EKS, Amazon ECS (including Amazon Web Services Fargate), and Amazon EC2 instances.
    /// It uses threat intelligence feeds, such as lists of malicious IPs and domains, and
    /// machine learning to identify unexpected, potentially unauthorized, and malicious activity
    /// within your Amazon Web Services environment. This can include issues like escalations
    /// of privileges, uses of exposed credentials, or communication with malicious IPs, domains,
    /// or presence of malware on your Amazon EC2 instances and container workloads. For example,
    /// GuardDuty can detect compromised EC2 instances and container workloads serving malware,
    /// or mining bitcoin. 
    /// 
    ///  
    /// <para>
    /// GuardDuty also monitors Amazon Web Services account access behavior for signs of compromise,
    /// such as unauthorized infrastructure deployments like EC2 instances deployed in a Region
    /// that has never been used, or unusual API calls like a password policy change to reduce
    /// password strength. 
    /// </para>
    ///  
    /// <para>
    /// GuardDuty informs you about the status of your Amazon Web Services environment by
    /// producing security findings that you can view in the GuardDuty console or through
    /// Amazon EventBridge. For more information, see the <i> <a href="https://docs.aws.amazon.com/guardduty/latest/ug/what-is-guardduty.html">Amazon
    /// GuardDuty User Guide</a> </i>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonGuardDuty : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGuardDutyPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptAdministratorInvitation


        /// <summary>
        /// Accepts the invitation to be a member account and get monitored by a GuardDuty administrator
        /// account that sent the invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptAdministratorInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptAdministratorInvitation service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptAdministratorInvitation">REST API Reference for AcceptAdministratorInvitation Operation</seealso>
        AcceptAdministratorInvitationResponse AcceptAdministratorInvitation(AcceptAdministratorInvitationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptAdministratorInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptAdministratorInvitation operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptAdministratorInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptAdministratorInvitation">REST API Reference for AcceptAdministratorInvitation Operation</seealso>
        IAsyncResult BeginAcceptAdministratorInvitation(AcceptAdministratorInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptAdministratorInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptAdministratorInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptAdministratorInvitationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptAdministratorInvitation">REST API Reference for AcceptAdministratorInvitation Operation</seealso>
        AcceptAdministratorInvitationResponse EndAcceptAdministratorInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  AcceptInvitation


        /// <summary>
        /// Accepts the invitation to be monitored by a GuardDuty administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        [Obsolete("This operation is deprecated, use AcceptAdministratorInvitation instead")]
        AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        [Obsolete("This operation is deprecated, use AcceptAdministratorInvitation instead")]
        IAsyncResult BeginAcceptInvitation(AcceptInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptInvitationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        [Obsolete("This operation is deprecated, use AcceptAdministratorInvitation instead")]
        AcceptInvitationResponse EndAcceptInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  ArchiveFindings


        /// <summary>
        /// Archives GuardDuty findings that are specified by the list of finding IDs.
        /// 
        ///  <note> 
        /// <para>
        /// Only the administrator account can archive findings. Member accounts don't have permission
        /// to archive findings from their accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveFindings service method.</param>
        /// 
        /// <returns>The response from the ArchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        ArchiveFindingsResponse ArchiveFindings(ArchiveFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ArchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ArchiveFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndArchiveFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        IAsyncResult BeginArchiveFindings(ArchiveFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ArchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginArchiveFindings.</param>
        /// 
        /// <returns>Returns a  ArchiveFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        ArchiveFindingsResponse EndArchiveFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDetector


        /// <summary>
        /// Creates a single GuardDuty detector. A detector is a resource that represents the
        /// GuardDuty service. To start using GuardDuty, you must create a detector in each Region
        /// where you enable the service. You can have only one detector per account per Region.
        /// All data sources are enabled in a new detector by default.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// When you don't specify any <c>features</c>, with an exception to <c>RUNTIME_MONITORING</c>,
        /// all the optional features are enabled by default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you specify some of the <c>features</c>, any feature that is not specified in
        /// the API call gets enabled by default, with an exception to <c>RUNTIME_MONITORING</c>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Specifying both EKS Runtime Monitoring (<c>EKS_RUNTIME_MONITORING</c>) and Runtime
        /// Monitoring (<c>RUNTIME_MONITORING</c>) will cause an error. You can add only one of
        /// these two features because Runtime Monitoring already includes the threat detection
        /// for Amazon EKS resources. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/runtime-monitoring.html">Runtime
        /// Monitoring</a>.
        /// </para>
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetector service method.</param>
        /// 
        /// <returns>The response from the CreateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        CreateDetectorResponse CreateDetector(CreateDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDetector operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        IAsyncResult BeginCreateDetector(CreateDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDetector.</param>
        /// 
        /// <returns>Returns a  CreateDetectorResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        CreateDetectorResponse EndCreateDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFilter


        /// <summary>
        /// Creates a filter using the specified finding criteria. The maximum number of saved
        /// filters per Amazon Web Services account per Region is 100. For more information, see
        /// <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_limits.html">Quotas
        /// for GuardDuty</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        CreateFilterResponse CreateFilter(CreateFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        IAsyncResult BeginCreateFilter(CreateFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFilter.</param>
        /// 
        /// <returns>Returns a  CreateFilterResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        CreateFilterResponse EndCreateFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIPSet


        /// <summary>
        /// Creates a new IPSet, which is called a trusted IP list in the console user interface.
        /// An IPSet is a list of IP addresses that are trusted for secure communication with
        /// Amazon Web Services infrastructure and applications. GuardDuty doesn't generate findings
        /// for IP addresses that are included in IPSets. Only users from the administrator account
        /// can use this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        CreateIPSetResponse CreateIPSet(CreateIPSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        IAsyncResult BeginCreateIPSet(CreateIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIPSet.</param>
        /// 
        /// <returns>Returns a  CreateIPSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        CreateIPSetResponse EndCreateIPSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMalwareProtectionPlan


        /// <summary>
        /// Creates a new Malware Protection plan for the protected resource.
        /// 
        ///  
        /// <para>
        /// When you create a Malware Protection plan, the Amazon Web Services service terms for
        /// GuardDuty Malware Protection apply. For more information, see <a href="http://aws.amazon.com/service-terms/#87._Amazon_GuardDuty">Amazon
        /// Web Services service terms for GuardDuty Malware Protection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMalwareProtectionPlan service method.</param>
        /// 
        /// <returns>The response from the CreateMalwareProtectionPlan service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.AccessDeniedException">
        /// An access denied exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.ConflictException">
        /// A request conflict exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMalwareProtectionPlan">REST API Reference for CreateMalwareProtectionPlan Operation</seealso>
        CreateMalwareProtectionPlanResponse CreateMalwareProtectionPlan(CreateMalwareProtectionPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMalwareProtectionPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMalwareProtectionPlan operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMalwareProtectionPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMalwareProtectionPlan">REST API Reference for CreateMalwareProtectionPlan Operation</seealso>
        IAsyncResult BeginCreateMalwareProtectionPlan(CreateMalwareProtectionPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMalwareProtectionPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMalwareProtectionPlan.</param>
        /// 
        /// <returns>Returns a  CreateMalwareProtectionPlanResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMalwareProtectionPlan">REST API Reference for CreateMalwareProtectionPlan Operation</seealso>
        CreateMalwareProtectionPlanResponse EndCreateMalwareProtectionPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMembers


        /// <summary>
        /// Creates member accounts of the current Amazon Web Services account by specifying a
        /// list of Amazon Web Services account IDs. This step is a prerequisite for managing
        /// the associated member accounts either by invitation or through an organization.
        /// 
        ///  
        /// <para>
        /// As a delegated administrator, using <c>CreateMembers</c> will enable GuardDuty in
        /// the added member accounts, with the exception of the organization delegated administrator
        /// account. A delegated administrator must enable GuardDuty prior to being added as a
        /// member.
        /// </para>
        ///  
        /// <para>
        /// When you use CreateMembers as an Organizations delegated administrator, GuardDuty
        /// applies your organization's auto-enable settings to the member accounts in this request,
        /// irrespective of the accounts being new or existing members. For more information about
        /// the existing auto-enable settings for your organization, see <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DescribeOrganizationConfiguration.html">DescribeOrganizationConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        /// If you disassociate a member account that was added by invitation, the member account
        /// details obtained from this API, including the associated email addresses, will be
        /// retained. This is done so that the delegated administrator can invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>
        /// API without the need to invoke the CreateMembers API again. To remove the details
        /// associated with a member account, the delegated administrator must invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// When the member accounts added through Organizations are later disassociated, you
        /// (administrator) can't invite them by calling the InviteMembers API. You can create
        /// an association with these member accounts again only by calling the CreateMembers
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        CreateMembersResponse CreateMembers(CreateMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        IAsyncResult BeginCreateMembers(CreateMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMembers.</param>
        /// 
        /// <returns>Returns a  CreateMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        CreateMembersResponse EndCreateMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePublishingDestination


        /// <summary>
        /// Creates a publishing destination where you can export your GuardDuty findings. Before
        /// you start exporting the findings, the destination resource must exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublishingDestination service method.</param>
        /// 
        /// <returns>The response from the CreatePublishingDestination service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreatePublishingDestination">REST API Reference for CreatePublishingDestination Operation</seealso>
        CreatePublishingDestinationResponse CreatePublishingDestination(CreatePublishingDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublishingDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublishingDestination operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePublishingDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreatePublishingDestination">REST API Reference for CreatePublishingDestination Operation</seealso>
        IAsyncResult BeginCreatePublishingDestination(CreatePublishingDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePublishingDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePublishingDestination.</param>
        /// 
        /// <returns>Returns a  CreatePublishingDestinationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreatePublishingDestination">REST API Reference for CreatePublishingDestination Operation</seealso>
        CreatePublishingDestinationResponse EndCreatePublishingDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSampleFindings


        /// <summary>
        /// Generates sample findings of types specified by the list of finding types. If 'NULL'
        /// is specified for <c>findingTypes</c>, the API generates sample findings of all supported
        /// finding types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// 
        /// <returns>The response from the CreateSampleFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        CreateSampleFindingsResponse CreateSampleFindings(CreateSampleFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSampleFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSampleFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        IAsyncResult BeginCreateSampleFindings(CreateSampleFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSampleFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSampleFindings.</param>
        /// 
        /// <returns>Returns a  CreateSampleFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        CreateSampleFindingsResponse EndCreateSampleFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateThreatIntelSet


        /// <summary>
        /// Creates a new ThreatIntelSet. ThreatIntelSets consist of known malicious IP addresses.
        /// GuardDuty generates findings based on ThreatIntelSets. Only users of the administrator
        /// account can use this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the CreateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        CreateThreatIntelSetResponse CreateThreatIntelSet(CreateThreatIntelSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatIntelSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateThreatIntelSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        IAsyncResult BeginCreateThreatIntelSet(CreateThreatIntelSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateThreatIntelSet.</param>
        /// 
        /// <returns>Returns a  CreateThreatIntelSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        CreateThreatIntelSetResponse EndCreateThreatIntelSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeclineInvitations


        /// <summary>
        /// Declines invitations sent to the current member account by Amazon Web Services accounts
        /// specified by their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeclineInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        IAsyncResult BeginDeclineInvitations(DeclineInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeclineInvitations.</param>
        /// 
        /// <returns>Returns a  DeclineInvitationsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        DeclineInvitationsResponse EndDeclineInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDetector


        /// <summary>
        /// Deletes an Amazon GuardDuty detector that is specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        DeleteDetectorResponse DeleteDetector(DeleteDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        IAsyncResult BeginDeleteDetector(DeleteDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDetector.</param>
        /// 
        /// <returns>Returns a  DeleteDetectorResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        DeleteDetectorResponse EndDeleteDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFilter


        /// <summary>
        /// Deletes the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        DeleteFilterResponse DeleteFilter(DeleteFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        IAsyncResult BeginDeleteFilter(DeleteFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFilter.</param>
        /// 
        /// <returns>Returns a  DeleteFilterResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        DeleteFilterResponse EndDeleteFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInvitations


        /// <summary>
        /// Deletes invitations sent to the current member account by Amazon Web Services accounts
        /// specified by their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        IAsyncResult BeginDeleteInvitations(DeleteInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInvitations.</param>
        /// 
        /// <returns>Returns a  DeleteInvitationsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        DeleteInvitationsResponse EndDeleteInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIPSet


        /// <summary>
        /// Deletes the IPSet specified by the <c>ipSetId</c>. IPSets are called trusted IP lists
        /// in the console user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        IAsyncResult BeginDeleteIPSet(DeleteIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIPSet.</param>
        /// 
        /// <returns>Returns a  DeleteIPSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        DeleteIPSetResponse EndDeleteIPSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMalwareProtectionPlan


        /// <summary>
        /// Deletes the Malware Protection plan ID associated with the Malware Protection plan
        /// resource. Use this API only when you no longer want to protect the resource associated
        /// with this Malware Protection plan ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMalwareProtectionPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteMalwareProtectionPlan service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.AccessDeniedException">
        /// An access denied exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMalwareProtectionPlan">REST API Reference for DeleteMalwareProtectionPlan Operation</seealso>
        DeleteMalwareProtectionPlanResponse DeleteMalwareProtectionPlan(DeleteMalwareProtectionPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMalwareProtectionPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMalwareProtectionPlan operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMalwareProtectionPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMalwareProtectionPlan">REST API Reference for DeleteMalwareProtectionPlan Operation</seealso>
        IAsyncResult BeginDeleteMalwareProtectionPlan(DeleteMalwareProtectionPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMalwareProtectionPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMalwareProtectionPlan.</param>
        /// 
        /// <returns>Returns a  DeleteMalwareProtectionPlanResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMalwareProtectionPlan">REST API Reference for DeleteMalwareProtectionPlan Operation</seealso>
        DeleteMalwareProtectionPlanResponse EndDeleteMalwareProtectionPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMembers


        /// <summary>
        /// Deletes GuardDuty member accounts (to the current GuardDuty administrator account)
        /// specified by the account IDs.
        /// 
        ///  
        /// <para>
        /// With <c>autoEnableOrganizationMembers</c> configuration for your organization set
        /// to <c>ALL</c>, you'll receive an error if you attempt to disable GuardDuty for a member
        /// account in your organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        DeleteMembersResponse DeleteMembers(DeleteMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        IAsyncResult BeginDeleteMembers(DeleteMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMembers.</param>
        /// 
        /// <returns>Returns a  DeleteMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        DeleteMembersResponse EndDeleteMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePublishingDestination


        /// <summary>
        /// Deletes the publishing definition with the specified <c>destinationId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublishingDestination service method.</param>
        /// 
        /// <returns>The response from the DeletePublishingDestination service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeletePublishingDestination">REST API Reference for DeletePublishingDestination Operation</seealso>
        DeletePublishingDestinationResponse DeletePublishingDestination(DeletePublishingDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublishingDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublishingDestination operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePublishingDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeletePublishingDestination">REST API Reference for DeletePublishingDestination Operation</seealso>
        IAsyncResult BeginDeletePublishingDestination(DeletePublishingDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePublishingDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePublishingDestination.</param>
        /// 
        /// <returns>Returns a  DeletePublishingDestinationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeletePublishingDestination">REST API Reference for DeletePublishingDestination Operation</seealso>
        DeletePublishingDestinationResponse EndDeletePublishingDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteThreatIntelSet


        /// <summary>
        /// Deletes the ThreatIntelSet specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the DeleteThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        DeleteThreatIntelSetResponse DeleteThreatIntelSet(DeleteThreatIntelSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThreatIntelSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteThreatIntelSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        IAsyncResult BeginDeleteThreatIntelSet(DeleteThreatIntelSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteThreatIntelSet.</param>
        /// 
        /// <returns>Returns a  DeleteThreatIntelSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        DeleteThreatIntelSetResponse EndDeleteThreatIntelSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMalwareScans


        /// <summary>
        /// Returns a list of malware scans. Each member account can view the malware scans for
        /// their own accounts. An administrator can view the malware scans for all the member
        /// accounts.
        /// 
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMalwareScans service method.</param>
        /// 
        /// <returns>The response from the DescribeMalwareScans service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DescribeMalwareScans">REST API Reference for DescribeMalwareScans Operation</seealso>
        DescribeMalwareScansResponse DescribeMalwareScans(DescribeMalwareScansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMalwareScans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMalwareScans operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMalwareScans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DescribeMalwareScans">REST API Reference for DescribeMalwareScans Operation</seealso>
        IAsyncResult BeginDescribeMalwareScans(DescribeMalwareScansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMalwareScans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMalwareScans.</param>
        /// 
        /// <returns>Returns a  DescribeMalwareScansResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DescribeMalwareScans">REST API Reference for DescribeMalwareScans Operation</seealso>
        DescribeMalwareScansResponse EndDescribeMalwareScans(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOrganizationConfiguration


        /// <summary>
        /// Returns information about the account selected as the delegated administrator for
        /// GuardDuty.
        /// 
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        IAsyncResult BeginDescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationConfigurationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        DescribeOrganizationConfigurationResponse EndDescribeOrganizationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePublishingDestination


        /// <summary>
        /// Returns information about the publishing destination specified by the provided <c>destinationId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePublishingDestination service method.</param>
        /// 
        /// <returns>The response from the DescribePublishingDestination service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DescribePublishingDestination">REST API Reference for DescribePublishingDestination Operation</seealso>
        DescribePublishingDestinationResponse DescribePublishingDestination(DescribePublishingDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePublishingDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePublishingDestination operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePublishingDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DescribePublishingDestination">REST API Reference for DescribePublishingDestination Operation</seealso>
        IAsyncResult BeginDescribePublishingDestination(DescribePublishingDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePublishingDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePublishingDestination.</param>
        /// 
        /// <returns>Returns a  DescribePublishingDestinationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DescribePublishingDestination">REST API Reference for DescribePublishingDestination Operation</seealso>
        DescribePublishingDestinationResponse EndDescribePublishingDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableOrganizationAdminAccount


        /// <summary>
        /// Removes the existing GuardDuty delegated administrator of the organization. Only the
        /// organization's management account can run this API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisableOrganizationAdminAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        DisableOrganizationAdminAccountResponse DisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        IAsyncResult BeginDisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  DisableOrganizationAdminAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        DisableOrganizationAdminAccountResponse EndDisableOrganizationAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFromAdministratorAccount


        /// <summary>
        /// Disassociates the current GuardDuty member account from its administrator account.
        /// 
        ///  
        /// <para>
        /// When you disassociate an invited member from a GuardDuty delegated administrator,
        /// the member account details obtained from the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_CreateMembers.html">CreateMembers</a>
        /// API, including the associated email addresses, are retained. This is done so that
        /// the delegated administrator can invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>
        /// API without the need to invoke the CreateMembers API again. To remove the details
        /// associated with a member account, the delegated administrator must invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// With <c>autoEnableOrganizationMembers</c> configuration for your organization set
        /// to <c>ALL</c>, you'll receive an error if you attempt to disable GuardDuty in a member
        /// account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromAdministratorAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        DisassociateFromAdministratorAccountResponse DisassociateFromAdministratorAccount(DisassociateFromAdministratorAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFromAdministratorAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        IAsyncResult BeginDisassociateFromAdministratorAccount(DisassociateFromAdministratorAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromAdministratorAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateFromAdministratorAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        DisassociateFromAdministratorAccountResponse EndDisassociateFromAdministratorAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFromMasterAccount


        /// <summary>
        /// Disassociates the current GuardDuty member account from its administrator account.
        /// 
        ///  
        /// <para>
        /// When you disassociate an invited member from a GuardDuty delegated administrator,
        /// the member account details obtained from the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_CreateMembers.html">CreateMembers</a>
        /// API, including the associated email addresses, are retained. This is done so that
        /// the delegated administrator can invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>
        /// API without the need to invoke the CreateMembers API again. To remove the details
        /// associated with a member account, the delegated administrator must invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        [Obsolete("This operation is deprecated, use DisassociateFromAdministratorAccount instead")]
        DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFromMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        [Obsolete("This operation is deprecated, use DisassociateFromAdministratorAccount instead")]
        IAsyncResult BeginDisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromMasterAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateFromMasterAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        [Obsolete("This operation is deprecated, use DisassociateFromAdministratorAccount instead")]
        DisassociateFromMasterAccountResponse EndDisassociateFromMasterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMembers


        /// <summary>
        /// Disassociates GuardDuty member accounts (from the current administrator account) specified
        /// by the account IDs.
        /// 
        ///  
        /// <para>
        /// When you disassociate an invited member from a GuardDuty delegated administrator,
        /// the member account details obtained from the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_CreateMembers.html">CreateMembers</a>
        /// API, including the associated email addresses, are retained. This is done so that
        /// the delegated administrator can invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>
        /// API without the need to invoke the CreateMembers API again. To remove the details
        /// associated with a member account, the delegated administrator must invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// With <c>autoEnableOrganizationMembers</c> configuration for your organization set
        /// to <c>ALL</c>, you'll receive an error if you attempt to disassociate a member account
        /// before removing them from your organization.
        /// </para>
        ///  
        /// <para>
        /// If you disassociate a member account that was added by invitation, the member account
        /// details obtained from this API, including the associated email addresses, will be
        /// retained. This is done so that the delegated administrator can invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>
        /// API without the need to invoke the CreateMembers API again. To remove the details
        /// associated with a member account, the delegated administrator must invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// When the member accounts added through Organizations are later disassociated, you
        /// (administrator) can't invite them by calling the InviteMembers API. You can create
        /// an association with these member accounts again only by calling the CreateMembers
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers service method.</param>
        /// 
        /// <returns>The response from the DisassociateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        IAsyncResult BeginDisassociateMembers(DisassociateMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMembers.</param>
        /// 
        /// <returns>Returns a  DisassociateMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        DisassociateMembersResponse EndDisassociateMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableOrganizationAdminAccount


        /// <summary>
        /// Designates an Amazon Web Services account within the organization as your GuardDuty
        /// delegated administrator. Only the organization's management account can run this API
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the EnableOrganizationAdminAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        EnableOrganizationAdminAccountResponse EnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        IAsyncResult BeginEnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  EnableOrganizationAdminAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        EnableOrganizationAdminAccountResponse EndEnableOrganizationAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAdministratorAccount


        /// <summary>
        /// Provides the details of the GuardDuty administrator account associated with the current
        /// GuardDuty member account.
        /// 
        ///  <note> 
        /// <para>
        /// If the organization's management account or a delegated administrator runs this API,
        /// it will return success (<c>HTTP 200</c>) but no content.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount service method.</param>
        /// 
        /// <returns>The response from the GetAdministratorAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        GetAdministratorAccountResponse GetAdministratorAccount(GetAdministratorAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAdministratorAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        IAsyncResult BeginGetAdministratorAccount(GetAdministratorAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAdministratorAccount.</param>
        /// 
        /// <returns>Returns a  GetAdministratorAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        GetAdministratorAccountResponse EndGetAdministratorAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCoverageStatistics


        /// <summary>
        /// Retrieves aggregated statistics for your account. If you are a GuardDuty administrator,
        /// you can retrieve the statistics for all the resources associated with the active member
        /// accounts in your organization who have enabled Runtime Monitoring and have the GuardDuty
        /// security agent running on their resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoverageStatistics service method.</param>
        /// 
        /// <returns>The response from the GetCoverageStatistics service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetCoverageStatistics">REST API Reference for GetCoverageStatistics Operation</seealso>
        GetCoverageStatisticsResponse GetCoverageStatistics(GetCoverageStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoverageStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoverageStatistics operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoverageStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetCoverageStatistics">REST API Reference for GetCoverageStatistics Operation</seealso>
        IAsyncResult BeginGetCoverageStatistics(GetCoverageStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoverageStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoverageStatistics.</param>
        /// 
        /// <returns>Returns a  GetCoverageStatisticsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetCoverageStatistics">REST API Reference for GetCoverageStatistics Operation</seealso>
        GetCoverageStatisticsResponse EndGetCoverageStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDetector


        /// <summary>
        /// Retrieves a GuardDuty detector specified by the detectorId.
        /// 
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetector service method.</param>
        /// 
        /// <returns>The response from the GetDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        GetDetectorResponse GetDetector(GetDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetector operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        IAsyncResult BeginGetDetector(GetDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDetector.</param>
        /// 
        /// <returns>Returns a  GetDetectorResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        GetDetectorResponse EndGetDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFilter


        /// <summary>
        /// Returns the details of the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFilter service method.</param>
        /// 
        /// <returns>The response from the GetFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        GetFilterResponse GetFilter(GetFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFilter operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        IAsyncResult BeginGetFilter(GetFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFilter.</param>
        /// 
        /// <returns>Returns a  GetFilterResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        GetFilterResponse EndGetFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindings


        /// <summary>
        /// Describes Amazon GuardDuty findings specified by finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        GetFindingsResponse GetFindings(GetFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        IAsyncResult BeginGetFindings(GetFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindings.</param>
        /// 
        /// <returns>Returns a  GetFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        GetFindingsResponse EndGetFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindingsStatistics


        /// <summary>
        /// Lists GuardDuty findings statistics for the specified detector ID.
        /// 
        ///  
        /// <para>
        /// You must provide either <c>findingStatisticTypes</c> or <c>groupBy</c> parameter,
        /// and not both. You can use the <c>maxResults</c> and <c>orderBy</c> parameters only
        /// when using <c>groupBy</c>.
        /// </para>
        ///  
        /// <para>
        /// There might be regional differences because some flags might not be available in all
        /// the Regions where GuardDuty is currently supported. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics service method.</param>
        /// 
        /// <returns>The response from the GetFindingsStatistics service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        GetFindingsStatisticsResponse GetFindingsStatistics(GetFindingsStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingsStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingsStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        IAsyncResult BeginGetFindingsStatistics(GetFindingsStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingsStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingsStatistics.</param>
        /// 
        /// <returns>Returns a  GetFindingsStatisticsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        GetFindingsStatisticsResponse EndGetFindingsStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInvitationsCount


        /// <summary>
        /// Returns the count of all GuardDuty membership invitations that were sent to the current
        /// member account except the currently accepted invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvitationsCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        IAsyncResult BeginGetInvitationsCount(GetInvitationsCountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvitationsCount.</param>
        /// 
        /// <returns>Returns a  GetInvitationsCountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        GetInvitationsCountResponse EndGetInvitationsCount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIPSet


        /// <summary>
        /// Retrieves the IPSet specified by the <c>ipSetId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        GetIPSetResponse GetIPSet(GetIPSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        IAsyncResult BeginGetIPSet(GetIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIPSet.</param>
        /// 
        /// <returns>Returns a  GetIPSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        GetIPSetResponse EndGetIPSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMalwareProtectionPlan


        /// <summary>
        /// Retrieves the Malware Protection plan details associated with a Malware Protection
        /// plan ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMalwareProtectionPlan service method.</param>
        /// 
        /// <returns>The response from the GetMalwareProtectionPlan service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.AccessDeniedException">
        /// An access denied exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMalwareProtectionPlan">REST API Reference for GetMalwareProtectionPlan Operation</seealso>
        GetMalwareProtectionPlanResponse GetMalwareProtectionPlan(GetMalwareProtectionPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMalwareProtectionPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMalwareProtectionPlan operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMalwareProtectionPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMalwareProtectionPlan">REST API Reference for GetMalwareProtectionPlan Operation</seealso>
        IAsyncResult BeginGetMalwareProtectionPlan(GetMalwareProtectionPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMalwareProtectionPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMalwareProtectionPlan.</param>
        /// 
        /// <returns>Returns a  GetMalwareProtectionPlanResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMalwareProtectionPlan">REST API Reference for GetMalwareProtectionPlan Operation</seealso>
        GetMalwareProtectionPlanResponse EndGetMalwareProtectionPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMalwareScanSettings


        /// <summary>
        /// Returns the details of the malware scan settings.
        /// 
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMalwareScanSettings service method.</param>
        /// 
        /// <returns>The response from the GetMalwareScanSettings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMalwareScanSettings">REST API Reference for GetMalwareScanSettings Operation</seealso>
        GetMalwareScanSettingsResponse GetMalwareScanSettings(GetMalwareScanSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMalwareScanSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMalwareScanSettings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMalwareScanSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMalwareScanSettings">REST API Reference for GetMalwareScanSettings Operation</seealso>
        IAsyncResult BeginGetMalwareScanSettings(GetMalwareScanSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMalwareScanSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMalwareScanSettings.</param>
        /// 
        /// <returns>Returns a  GetMalwareScanSettingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMalwareScanSettings">REST API Reference for GetMalwareScanSettings Operation</seealso>
        GetMalwareScanSettingsResponse EndGetMalwareScanSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMasterAccount


        /// <summary>
        /// Provides the details for the GuardDuty administrator account associated with the current
        /// GuardDuty member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        [Obsolete("This operation is deprecated, use GetAdministratorAccount instead")]
        GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        [Obsolete("This operation is deprecated, use GetAdministratorAccount instead")]
        IAsyncResult BeginGetMasterAccount(GetMasterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMasterAccount.</param>
        /// 
        /// <returns>Returns a  GetMasterAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        [Obsolete("This operation is deprecated, use GetAdministratorAccount instead")]
        GetMasterAccountResponse EndGetMasterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMemberDetectors


        /// <summary>
        /// Describes which data sources are enabled for the member account's detector.
        /// 
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemberDetectors service method.</param>
        /// 
        /// <returns>The response from the GetMemberDetectors service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMemberDetectors">REST API Reference for GetMemberDetectors Operation</seealso>
        GetMemberDetectorsResponse GetMemberDetectors(GetMemberDetectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMemberDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMemberDetectors operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMemberDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMemberDetectors">REST API Reference for GetMemberDetectors Operation</seealso>
        IAsyncResult BeginGetMemberDetectors(GetMemberDetectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMemberDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMemberDetectors.</param>
        /// 
        /// <returns>Returns a  GetMemberDetectorsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMemberDetectors">REST API Reference for GetMemberDetectors Operation</seealso>
        GetMemberDetectorsResponse EndGetMemberDetectors(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMembers


        /// <summary>
        /// Retrieves GuardDuty member accounts (of the current GuardDuty administrator account)
        /// specified by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        GetMembersResponse GetMembers(GetMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        IAsyncResult BeginGetMembers(GetMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMembers.</param>
        /// 
        /// <returns>Returns a  GetMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        GetMembersResponse EndGetMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOrganizationStatistics


        /// <summary>
        /// Retrieves how many active member accounts have each feature enabled within GuardDuty.
        /// Only a delegated GuardDuty administrator of an organization can run this API.
        /// 
        ///  
        /// <para>
        /// When you create a new organization, it might take up to 24 hours to generate the statistics
        /// for the entire organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationStatistics service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationStatistics service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetOrganizationStatistics">REST API Reference for GetOrganizationStatistics Operation</seealso>
        GetOrganizationStatisticsResponse GetOrganizationStatistics(GetOrganizationStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrganizationStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationStatistics operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOrganizationStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetOrganizationStatistics">REST API Reference for GetOrganizationStatistics Operation</seealso>
        IAsyncResult BeginGetOrganizationStatistics(GetOrganizationStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOrganizationStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOrganizationStatistics.</param>
        /// 
        /// <returns>Returns a  GetOrganizationStatisticsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetOrganizationStatistics">REST API Reference for GetOrganizationStatistics Operation</seealso>
        GetOrganizationStatisticsResponse EndGetOrganizationStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRemainingFreeTrialDays


        /// <summary>
        /// Provides the number of days left for each data source used in the free trial period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRemainingFreeTrialDays service method.</param>
        /// 
        /// <returns>The response from the GetRemainingFreeTrialDays service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetRemainingFreeTrialDays">REST API Reference for GetRemainingFreeTrialDays Operation</seealso>
        GetRemainingFreeTrialDaysResponse GetRemainingFreeTrialDays(GetRemainingFreeTrialDaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRemainingFreeTrialDays operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRemainingFreeTrialDays operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRemainingFreeTrialDays
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetRemainingFreeTrialDays">REST API Reference for GetRemainingFreeTrialDays Operation</seealso>
        IAsyncResult BeginGetRemainingFreeTrialDays(GetRemainingFreeTrialDaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRemainingFreeTrialDays operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRemainingFreeTrialDays.</param>
        /// 
        /// <returns>Returns a  GetRemainingFreeTrialDaysResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetRemainingFreeTrialDays">REST API Reference for GetRemainingFreeTrialDays Operation</seealso>
        GetRemainingFreeTrialDaysResponse EndGetRemainingFreeTrialDays(IAsyncResult asyncResult);

        #endregion
        
        #region  GetThreatIntelSet


        /// <summary>
        /// Retrieves the ThreatIntelSet that is specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the GetThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        GetThreatIntelSetResponse GetThreatIntelSet(GetThreatIntelSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThreatIntelSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetThreatIntelSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        IAsyncResult BeginGetThreatIntelSet(GetThreatIntelSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetThreatIntelSet.</param>
        /// 
        /// <returns>Returns a  GetThreatIntelSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        GetThreatIntelSetResponse EndGetThreatIntelSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsageStatistics


        /// <summary>
        /// Lists Amazon GuardDuty usage statistics over the last 30 days for the specified detector
        /// ID. For newly enabled detectors or data sources, the cost returned will include only
        /// the usage so far under 30 days. This may differ from the cost metrics in the console,
        /// which project usage over 30 days to provide a monthly cost estimate. For more information,
        /// see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/monitoring_costs.html#usage-calculations">Understanding
        /// How Usage Costs are Calculated</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageStatistics service method.</param>
        /// 
        /// <returns>The response from the GetUsageStatistics service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetUsageStatistics">REST API Reference for GetUsageStatistics Operation</seealso>
        GetUsageStatisticsResponse GetUsageStatistics(GetUsageStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsageStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsageStatistics operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsageStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetUsageStatistics">REST API Reference for GetUsageStatistics Operation</seealso>
        IAsyncResult BeginGetUsageStatistics(GetUsageStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsageStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsageStatistics.</param>
        /// 
        /// <returns>Returns a  GetUsageStatisticsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetUsageStatistics">REST API Reference for GetUsageStatistics Operation</seealso>
        GetUsageStatisticsResponse EndGetUsageStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  InviteMembers


        /// <summary>
        /// Invites Amazon Web Services accounts to become members of an organization administered
        /// by the Amazon Web Services account that invokes this API. If you are using Amazon
        /// Web Services Organizations to manage your GuardDuty environment, this step is not
        /// needed. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_organizations.html">Managing
        /// accounts with organizations</a>.
        /// 
        ///  
        /// <para>
        /// To invite Amazon Web Services accounts, the first step is to ensure that GuardDuty
        /// has been enabled in the potential member accounts. You can now invoke this API to
        /// add accounts by invitation. The invited accounts can either accept or decline the
        /// invitation from their GuardDuty accounts. Each invited Amazon Web Services account
        /// can choose to accept the invitation from only one Amazon Web Services account. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_invitations.html">Managing
        /// GuardDuty accounts by invitation</a>.
        /// </para>
        ///  
        /// <para>
        /// After the invite has been accepted and you choose to disassociate a member account
        /// (by using <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DisassociateMembers.html">DisassociateMembers</a>)
        /// from your account, the details of the member account obtained by invoking <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_CreateMembers.html">CreateMembers</a>,
        /// including the associated email addresses, will be retained. This is done so that you
        /// can invoke InviteMembers without the need to invoke <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_CreateMembers.html">CreateMembers</a>
        /// again. To remove the details associated with a member account, you must also invoke
        /// <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you disassociate a member account that was added by invitation, the member account
        /// details obtained from this API, including the associated email addresses, will be
        /// retained. This is done so that the delegated administrator can invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>
        /// API without the need to invoke the CreateMembers API again. To remove the details
        /// associated with a member account, the delegated administrator must invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// When the member accounts added through Organizations are later disassociated, you
        /// (administrator) can't invite them by calling the InviteMembers API. You can create
        /// an association with these member accounts again only by calling the CreateMembers
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers service method.</param>
        /// 
        /// <returns>The response from the InviteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        InviteMembersResponse InviteMembers(InviteMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInviteMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        IAsyncResult BeginInviteMembers(InviteMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInviteMembers.</param>
        /// 
        /// <returns>Returns a  InviteMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        InviteMembersResponse EndInviteMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCoverage


        /// <summary>
        /// Lists coverage details for your GuardDuty account. If you're a GuardDuty administrator,
        /// you can retrieve all resources associated with the active member accounts in your
        /// organization.
        /// 
        ///  
        /// <para>
        /// Make sure the accounts have Runtime Monitoring enabled and GuardDuty agent running
        /// on their resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverage service method.</param>
        /// 
        /// <returns>The response from the ListCoverage service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        ListCoverageResponse ListCoverage(ListCoverageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoverage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoverage operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoverage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        IAsyncResult BeginListCoverage(ListCoverageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoverage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoverage.</param>
        /// 
        /// <returns>Returns a  ListCoverageResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        ListCoverageResponse EndListCoverage(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDetectors


        /// <summary>
        /// Lists detectorIds of all the existing Amazon GuardDuty detector resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        ListDetectorsResponse ListDetectors(ListDetectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        IAsyncResult BeginListDetectors(ListDetectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDetectors.</param>
        /// 
        /// <returns>Returns a  ListDetectorsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        ListDetectorsResponse EndListDetectors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFilters


        /// <summary>
        /// Returns a paginated list of the current filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        ListFiltersResponse ListFilters(ListFiltersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFilters operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        IAsyncResult BeginListFilters(ListFiltersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFilters.</param>
        /// 
        /// <returns>Returns a  ListFiltersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        ListFiltersResponse EndListFilters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Lists GuardDuty findings for the specified detector ID.
        /// 
        ///  
        /// <para>
        /// There might be regional differences because some flags might not be available in all
        /// the Regions where GuardDuty is currently supported. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        IAsyncResult BeginListFindings(ListFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindings.</param>
        /// 
        /// <returns>Returns a  ListFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse EndListFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInvitations


        /// <summary>
        /// Lists all GuardDuty membership invitations that were sent to the current Amazon Web
        /// Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        ListInvitationsResponse ListInvitations(ListInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        IAsyncResult BeginListInvitations(ListInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvitations.</param>
        /// 
        /// <returns>Returns a  ListInvitationsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        ListInvitationsResponse EndListInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIPSets


        /// <summary>
        /// Lists the IPSets of the GuardDuty service specified by the detector ID. If you use
        /// this operation from a member account, the IPSets returned are the IPSets from the
        /// associated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        ListIPSetsResponse ListIPSets(ListIPSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIPSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        IAsyncResult BeginListIPSets(ListIPSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIPSets.</param>
        /// 
        /// <returns>Returns a  ListIPSetsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        ListIPSetsResponse EndListIPSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMalwareProtectionPlans


        /// <summary>
        /// Lists the Malware Protection plan IDs associated with the protected resources in your
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMalwareProtectionPlans service method.</param>
        /// 
        /// <returns>The response from the ListMalwareProtectionPlans service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.AccessDeniedException">
        /// An access denied exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMalwareProtectionPlans">REST API Reference for ListMalwareProtectionPlans Operation</seealso>
        ListMalwareProtectionPlansResponse ListMalwareProtectionPlans(ListMalwareProtectionPlansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMalwareProtectionPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMalwareProtectionPlans operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMalwareProtectionPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMalwareProtectionPlans">REST API Reference for ListMalwareProtectionPlans Operation</seealso>
        IAsyncResult BeginListMalwareProtectionPlans(ListMalwareProtectionPlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMalwareProtectionPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMalwareProtectionPlans.</param>
        /// 
        /// <returns>Returns a  ListMalwareProtectionPlansResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMalwareProtectionPlans">REST API Reference for ListMalwareProtectionPlans Operation</seealso>
        ListMalwareProtectionPlansResponse EndListMalwareProtectionPlans(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// Lists details about all member accounts for the current GuardDuty administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse ListMembers(ListMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        IAsyncResult BeginListMembers(ListMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembers.</param>
        /// 
        /// <returns>Returns a  ListMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse EndListMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrganizationAdminAccounts


        /// <summary>
        /// Lists the accounts designated as GuardDuty delegated administrators. Only the organization's
        /// management account can run this API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationAdminAccounts service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        ListOrganizationAdminAccountsResponse ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationAdminAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationAdminAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        IAsyncResult BeginListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationAdminAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationAdminAccounts.</param>
        /// 
        /// <returns>Returns a  ListOrganizationAdminAccountsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        ListOrganizationAdminAccountsResponse EndListOrganizationAdminAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPublishingDestinations


        /// <summary>
        /// Returns a list of publishing destinations associated with the specified <c>detectorId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublishingDestinations service method.</param>
        /// 
        /// <returns>The response from the ListPublishingDestinations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListPublishingDestinations">REST API Reference for ListPublishingDestinations Operation</seealso>
        ListPublishingDestinationsResponse ListPublishingDestinations(ListPublishingDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPublishingDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublishingDestinations operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPublishingDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListPublishingDestinations">REST API Reference for ListPublishingDestinations Operation</seealso>
        IAsyncResult BeginListPublishingDestinations(ListPublishingDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPublishingDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPublishingDestinations.</param>
        /// 
        /// <returns>Returns a  ListPublishingDestinationsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListPublishingDestinations">REST API Reference for ListPublishingDestinations Operation</seealso>
        ListPublishingDestinationsResponse EndListPublishingDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for a resource. Tagging is currently supported for detectors, finding filters,
        /// IP sets, threat intel sets, and publishing destination, with a limit of 50 tags per
        /// resource. When invoked, this operation returns all assigned tags for a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.AccessDeniedException">
        /// An access denied exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThreatIntelSets


        /// <summary>
        /// Lists the ThreatIntelSets of the GuardDuty service specified by the detector ID. If
        /// you use this operation from a member account, the ThreatIntelSets associated with
        /// the administrator account are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatIntelSets service method.</param>
        /// 
        /// <returns>The response from the ListThreatIntelSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        ListThreatIntelSetsResponse ListThreatIntelSets(ListThreatIntelSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListThreatIntelSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThreatIntelSets operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThreatIntelSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        IAsyncResult BeginListThreatIntelSets(ListThreatIntelSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThreatIntelSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThreatIntelSets.</param>
        /// 
        /// <returns>Returns a  ListThreatIntelSetsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        ListThreatIntelSetsResponse EndListThreatIntelSets(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMalwareScan


        /// <summary>
        /// Initiates the malware scan. Invoking this API will automatically create the <a href="https://docs.aws.amazon.com/guardduty/latest/ug/slr-permissions-malware-protection.html">Service-linked
        /// role</a> in the corresponding account.
        /// 
        ///  
        /// <para>
        /// When the malware scan starts, you can use the associated scan ID to track the status
        /// of the scan. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DescribeMalwareScans.html">DescribeMalwareScans</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMalwareScan service method.</param>
        /// 
        /// <returns>The response from the StartMalwareScan service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.ConflictException">
        /// A request conflict exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMalwareScan">REST API Reference for StartMalwareScan Operation</seealso>
        StartMalwareScanResponse StartMalwareScan(StartMalwareScanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMalwareScan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMalwareScan operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMalwareScan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMalwareScan">REST API Reference for StartMalwareScan Operation</seealso>
        IAsyncResult BeginStartMalwareScan(StartMalwareScanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMalwareScan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMalwareScan.</param>
        /// 
        /// <returns>Returns a  StartMalwareScanResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMalwareScan">REST API Reference for StartMalwareScan Operation</seealso>
        StartMalwareScanResponse EndStartMalwareScan(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMonitoringMembers


        /// <summary>
        /// Turns on GuardDuty monitoring of the specified member accounts. Use this operation
        /// to restart monitoring of accounts that you stopped monitoring with the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_StopMonitoringMembers.html">StopMonitoringMembers</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMembers service method.</param>
        /// 
        /// <returns>The response from the StartMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        StartMonitoringMembersResponse StartMonitoringMembers(StartMonitoringMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMonitoringMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        IAsyncResult BeginStartMonitoringMembers(StartMonitoringMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMonitoringMembers.</param>
        /// 
        /// <returns>Returns a  StartMonitoringMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        StartMonitoringMembersResponse EndStartMonitoringMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  StopMonitoringMembers


        /// <summary>
        /// Stops GuardDuty monitoring for the specified member accounts. Use the <c>StartMonitoringMembers</c>
        /// operation to restart monitoring for those accounts.
        /// 
        ///  
        /// <para>
        /// With <c>autoEnableOrganizationMembers</c> configuration for your organization set
        /// to <c>ALL</c>, you'll receive an error if you attempt to stop monitoring the member
        /// accounts in your organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringMembers service method.</param>
        /// 
        /// <returns>The response from the StopMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        StopMonitoringMembersResponse StopMonitoringMembers(StopMonitoringMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringMembers operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMonitoringMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        IAsyncResult BeginStopMonitoringMembers(StopMonitoringMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMonitoringMembers.</param>
        /// 
        /// <returns>Returns a  StopMonitoringMembersResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        StopMonitoringMembersResponse EndStopMonitoringMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.AccessDeniedException">
        /// An access denied exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UnarchiveFindings


        /// <summary>
        /// Unarchives GuardDuty findings specified by the <c>findingIds</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveFindings service method.</param>
        /// 
        /// <returns>The response from the UnarchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        UnarchiveFindingsResponse UnarchiveFindings(UnarchiveFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnarchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveFindings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnarchiveFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        IAsyncResult BeginUnarchiveFindings(UnarchiveFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnarchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnarchiveFindings.</param>
        /// 
        /// <returns>Returns a  UnarchiveFindingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        UnarchiveFindingsResponse EndUnarchiveFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.AccessDeniedException">
        /// An access denied exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDetector


        /// <summary>
        /// Updates the GuardDuty detector specified by the detector ID.
        /// 
        ///  
        /// <para>
        /// Specifying both EKS Runtime Monitoring (<c>EKS_RUNTIME_MONITORING</c>) and Runtime
        /// Monitoring (<c>RUNTIME_MONITORING</c>) will cause an error. You can add only one of
        /// these two features because Runtime Monitoring already includes the threat detection
        /// for Amazon EKS resources. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/runtime-monitoring.html">Runtime
        /// Monitoring</a>.
        /// </para>
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetector service method.</param>
        /// 
        /// <returns>The response from the UpdateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        UpdateDetectorResponse UpdateDetector(UpdateDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetector operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        IAsyncResult BeginUpdateDetector(UpdateDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetector.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        UpdateDetectorResponse EndUpdateDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFilter


        /// <summary>
        /// Updates the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        UpdateFilterResponse UpdateFilter(UpdateFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        IAsyncResult BeginUpdateFilter(UpdateFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFilter.</param>
        /// 
        /// <returns>Returns a  UpdateFilterResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        UpdateFilterResponse EndUpdateFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFindingsFeedback


        /// <summary>
        /// Marks the specified GuardDuty findings as useful or not useful.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFeedback service method.</param>
        /// 
        /// <returns>The response from the UpdateFindingsFeedback service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        UpdateFindingsFeedbackResponse UpdateFindingsFeedback(UpdateFindingsFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFindingsFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFeedback operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFindingsFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        IAsyncResult BeginUpdateFindingsFeedback(UpdateFindingsFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFindingsFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFindingsFeedback.</param>
        /// 
        /// <returns>Returns a  UpdateFindingsFeedbackResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        UpdateFindingsFeedbackResponse EndUpdateFindingsFeedback(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIPSet


        /// <summary>
        /// Updates the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        IAsyncResult BeginUpdateIPSet(UpdateIPSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIPSet.</param>
        /// 
        /// <returns>Returns a  UpdateIPSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        UpdateIPSetResponse EndUpdateIPSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMalwareProtectionPlan


        /// <summary>
        /// Updates an existing Malware Protection plan resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMalwareProtectionPlan service method.</param>
        /// 
        /// <returns>The response from the UpdateMalwareProtectionPlan service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.AccessDeniedException">
        /// An access denied exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateMalwareProtectionPlan">REST API Reference for UpdateMalwareProtectionPlan Operation</seealso>
        UpdateMalwareProtectionPlanResponse UpdateMalwareProtectionPlan(UpdateMalwareProtectionPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMalwareProtectionPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMalwareProtectionPlan operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMalwareProtectionPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateMalwareProtectionPlan">REST API Reference for UpdateMalwareProtectionPlan Operation</seealso>
        IAsyncResult BeginUpdateMalwareProtectionPlan(UpdateMalwareProtectionPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMalwareProtectionPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMalwareProtectionPlan.</param>
        /// 
        /// <returns>Returns a  UpdateMalwareProtectionPlanResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateMalwareProtectionPlan">REST API Reference for UpdateMalwareProtectionPlan Operation</seealso>
        UpdateMalwareProtectionPlanResponse EndUpdateMalwareProtectionPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMalwareScanSettings


        /// <summary>
        /// Updates the malware scan settings.
        /// 
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMalwareScanSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateMalwareScanSettings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateMalwareScanSettings">REST API Reference for UpdateMalwareScanSettings Operation</seealso>
        UpdateMalwareScanSettingsResponse UpdateMalwareScanSettings(UpdateMalwareScanSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMalwareScanSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMalwareScanSettings operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMalwareScanSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateMalwareScanSettings">REST API Reference for UpdateMalwareScanSettings Operation</seealso>
        IAsyncResult BeginUpdateMalwareScanSettings(UpdateMalwareScanSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMalwareScanSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMalwareScanSettings.</param>
        /// 
        /// <returns>Returns a  UpdateMalwareScanSettingsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateMalwareScanSettings">REST API Reference for UpdateMalwareScanSettings Operation</seealso>
        UpdateMalwareScanSettingsResponse EndUpdateMalwareScanSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMemberDetectors


        /// <summary>
        /// Contains information on member accounts to be updated.
        /// 
        ///  
        /// <para>
        /// Specifying both EKS Runtime Monitoring (<c>EKS_RUNTIME_MONITORING</c>) and Runtime
        /// Monitoring (<c>RUNTIME_MONITORING</c>) will cause an error. You can add only one of
        /// these two features because Runtime Monitoring already includes the threat detection
        /// for Amazon EKS resources. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/runtime-monitoring.html">Runtime
        /// Monitoring</a>.
        /// </para>
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemberDetectors service method.</param>
        /// 
        /// <returns>The response from the UpdateMemberDetectors service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateMemberDetectors">REST API Reference for UpdateMemberDetectors Operation</seealso>
        UpdateMemberDetectorsResponse UpdateMemberDetectors(UpdateMemberDetectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMemberDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemberDetectors operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMemberDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateMemberDetectors">REST API Reference for UpdateMemberDetectors Operation</seealso>
        IAsyncResult BeginUpdateMemberDetectors(UpdateMemberDetectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMemberDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMemberDetectors.</param>
        /// 
        /// <returns>Returns a  UpdateMemberDetectorsResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateMemberDetectors">REST API Reference for UpdateMemberDetectors Operation</seealso>
        UpdateMemberDetectorsResponse EndUpdateMemberDetectors(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOrganizationConfiguration


        /// <summary>
        /// Configures the delegated administrator account with the provided values. You must
        /// provide a value for either <c>autoEnableOrganizationMembers</c> or <c>autoEnable</c>,
        /// but not both. 
        /// 
        ///  
        /// <para>
        /// Specifying both EKS Runtime Monitoring (<c>EKS_RUNTIME_MONITORING</c>) and Runtime
        /// Monitoring (<c>RUNTIME_MONITORING</c>) will cause an error. You can add only one of
        /// these two features because Runtime Monitoring already includes the threat detection
        /// for Amazon EKS resources. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/runtime-monitoring.html">Runtime
        /// Monitoring</a>.
        /// </para>
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        IAsyncResult BeginUpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateOrganizationConfigurationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        UpdateOrganizationConfigurationResponse EndUpdateOrganizationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePublishingDestination


        /// <summary>
        /// Updates information about the publishing destination specified by the <c>destinationId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublishingDestination service method.</param>
        /// 
        /// <returns>The response from the UpdatePublishingDestination service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdatePublishingDestination">REST API Reference for UpdatePublishingDestination Operation</seealso>
        UpdatePublishingDestinationResponse UpdatePublishingDestination(UpdatePublishingDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePublishingDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublishingDestination operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePublishingDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdatePublishingDestination">REST API Reference for UpdatePublishingDestination Operation</seealso>
        IAsyncResult BeginUpdatePublishingDestination(UpdatePublishingDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePublishingDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePublishingDestination.</param>
        /// 
        /// <returns>Returns a  UpdatePublishingDestinationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdatePublishingDestination">REST API Reference for UpdatePublishingDestination Operation</seealso>
        UpdatePublishingDestinationResponse EndUpdatePublishingDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateThreatIntelSet


        /// <summary>
        /// Updates the ThreatIntelSet specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the UpdateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// A bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// An internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        UpdateThreatIntelSetResponse UpdateThreatIntelSet(UpdateThreatIntelSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatIntelSet operation on AmazonGuardDutyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThreatIntelSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        IAsyncResult BeginUpdateThreatIntelSet(UpdateThreatIntelSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThreatIntelSet.</param>
        /// 
        /// <returns>Returns a  UpdateThreatIntelSetResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        UpdateThreatIntelSetResponse EndUpdateThreatIntelSet(IAsyncResult asyncResult);

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