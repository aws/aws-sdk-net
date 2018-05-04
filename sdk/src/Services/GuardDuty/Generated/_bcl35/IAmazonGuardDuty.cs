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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GuardDuty.Model;

namespace Amazon.GuardDuty
{
    /// <summary>
    /// Interface for accessing GuardDuty
    ///
    /// Assess, monitor, manage, and remediate security issues across your AWS infrastructure,
    /// applications, and data.
    /// </summary>
    public partial interface IAmazonGuardDuty : IAmazonService, IDisposable
    {

        
        #region  AcceptInvitation


        /// <summary>
        /// Accepts the invitation to be monitored by a master GuardDuty account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
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
        IAsyncResult BeginAcceptInvitation(AcceptInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptInvitationResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        AcceptInvitationResponse EndAcceptInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  ArchiveFindings


        /// <summary>
        /// Archives Amazon GuardDuty findings specified by the list of finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveFindings service method.</param>
        /// 
        /// <returns>The response from the ArchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Creates a single Amazon GuardDuty detector. A detector is an object that represents
        /// the GuardDuty service. A detector must be created in order for GuardDuty to become
        /// operational.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetector service method.</param>
        /// 
        /// <returns>The response from the CreateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Creates a filter using the specified finding criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Creates a new IPSet - a list of trusted IP addresses that have been whitelisted for
        /// secure communication with AWS infrastructure and applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  CreateMembers


        /// <summary>
        /// Creates member accounts of the current AWS account by specifying a list of AWS account
        /// IDs. The current AWS account can then invite these members to manage GuardDuty in
        /// their accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  CreateSampleFindings


        /// <summary>
        /// Generates example findings of types specified by the list of finding types. If 'NULL'
        /// is specified for findingTypes, the API generates example findings of all supported
        /// finding types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// 
        /// <returns>The response from the CreateSampleFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Create a new ThreatIntelSet. ThreatIntelSets consist of known malicious IP addresses.
        /// GuardDuty generates findings based on ThreatIntelSets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the CreateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Declines invitations sent to the current member account by AWS account specified by
        /// their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Deletes a Amazon GuardDuty detector specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Deletes invitations sent to the current member account by AWS accounts specified by
        /// their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Deletes the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  DeleteMembers


        /// <summary>
        /// Deletes GuardDuty member accounts (to the current GuardDuty master account) specified
        /// by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  DeleteThreatIntelSet


        /// <summary>
        /// Deletes ThreatIntelSet specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the DeleteThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  DisassociateFromMasterAccount


        /// <summary>
        /// Disassociates the current GuardDuty member account from its master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
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
        IAsyncResult BeginDisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromMasterAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateFromMasterAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        DisassociateFromMasterAccountResponse EndDisassociateFromMasterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMembers


        /// <summary>
        /// Disassociates GuardDuty member accounts (to the current GuardDuty master account)
        /// specified by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers service method.</param>
        /// 
        /// <returns>The response from the DisassociateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  GetDetector


        /// <summary>
        /// Retrieves an Amazon GuardDuty detector specified by the detectorId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetector service method.</param>
        /// 
        /// <returns>The response from the GetDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Lists Amazon GuardDuty findings' statistics for the specified detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics service method.</param>
        /// 
        /// <returns>The response from the GetFindingsStatistics service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Retrieves the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  GetMasterAccount


        /// <summary>
        /// Provides the details for the GuardDuty master account to the current GuardDuty member
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
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
        IAsyncResult BeginGetMasterAccount(GetMasterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMasterAccount.</param>
        /// 
        /// <returns>Returns a  GetMasterAccountResult from GuardDuty.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        GetMasterAccountResponse EndGetMasterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMembers


        /// <summary>
        /// Retrieves GuardDuty member accounts (to the current GuardDuty master account) specified
        /// by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  GetThreatIntelSet


        /// <summary>
        /// Retrieves the ThreatIntelSet that is specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the GetThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  InviteMembers


        /// <summary>
        /// Invites other AWS accounts (created as members of the current AWS account by CreateMembers)
        /// to enable GuardDuty and allow the current AWS account to view and manage these accounts'
        /// GuardDuty findings on their behalf as the master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers service method.</param>
        /// 
        /// <returns>The response from the InviteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  ListDetectors


        /// <summary>
        /// Lists detectorIds of all the existing Amazon GuardDuty detector resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Lists Amazon GuardDuty findings for the specified detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Lists all GuardDuty membership invitations that were sent to the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Lists the IPSets of the GuardDuty service specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  ListMembers


        /// <summary>
        /// Lists details about all member accounts for the current GuardDuty master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  ListThreatIntelSets


        /// <summary>
        /// Lists the ThreatIntelSets of the GuardDuty service specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatIntelSets service method.</param>
        /// 
        /// <returns>The response from the ListThreatIntelSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  StartMonitoringMembers


        /// <summary>
        /// Re-enables GuardDuty to monitor findings of the member accounts specified by the account
        /// IDs. A master GuardDuty account can run this command after disabling GuardDuty from
        /// monitoring these members' findings by running StopMonitoringMembers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMembers service method.</param>
        /// 
        /// <returns>The response from the StartMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Disables GuardDuty from monitoring findings of the member accounts specified by the
        /// account IDs. After running this command, a master GuardDuty account can run StartMonitoringMembers
        /// to re-enable GuardDuty to monitor these members’ findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringMembers service method.</param>
        /// 
        /// <returns>The response from the StopMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  UnarchiveFindings


        /// <summary>
        /// Unarchives Amazon GuardDuty findings specified by the list of finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveFindings service method.</param>
        /// 
        /// <returns>The response from the UnarchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  UpdateDetector


        /// <summary>
        /// Updates an Amazon GuardDuty detector specified by the detectorId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetector service method.</param>
        /// 
        /// <returns>The response from the UpdateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Marks specified Amazon GuardDuty findings as useful or not useful.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFeedback service method.</param>
        /// 
        /// <returns>The response from the UpdateFindingsFeedback service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
        #region  UpdateThreatIntelSet


        /// <summary>
        /// Updates the ThreatIntelSet specified by ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the UpdateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Error response object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Error response object.
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
        
    }
}