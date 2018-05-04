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
using System.Threading;
using System.Threading.Tasks;
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
        /// Initiates the asynchronous execution of the AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ArchiveFindings


        /// <summary>
        /// Initiates the asynchronous execution of the ArchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ArchiveFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        Task<ArchiveFindingsResponse> ArchiveFindingsAsync(ArchiveFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDetector


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        Task<CreateDetectorResponse> CreateDetectorAsync(CreateDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFilter


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        Task<CreateFilterResponse> CreateFilterAsync(CreateFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIPSet


        /// <summary>
        /// Initiates the asynchronous execution of the CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        Task<CreateIPSetResponse> CreateIPSetAsync(CreateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMembers


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        Task<CreateMembersResponse> CreateMembersAsync(CreateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSampleFindings


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSampleFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        Task<CreateSampleFindingsResponse> CreateSampleFindingsAsync(CreateSampleFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateThreatIntelSet


        /// <summary>
        /// Initiates the asynchronous execution of the CreateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatIntelSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        Task<CreateThreatIntelSetResponse> CreateThreatIntelSetAsync(CreateThreatIntelSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeclineInvitations


        /// <summary>
        /// Initiates the asynchronous execution of the DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        Task<DeclineInvitationsResponse> DeclineInvitationsAsync(DeclineInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDetector


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        Task<DeleteDetectorResponse> DeleteDetectorAsync(DeleteDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFilter


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        Task<DeleteFilterResponse> DeleteFilterAsync(DeleteFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInvitations


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        Task<DeleteInvitationsResponse> DeleteInvitationsAsync(DeleteInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIPSet


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        Task<DeleteIPSetResponse> DeleteIPSetAsync(DeleteIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMembers


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        Task<DeleteMembersResponse> DeleteMembersAsync(DeleteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteThreatIntelSet


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThreatIntelSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        Task<DeleteThreatIntelSetResponse> DeleteThreatIntelSetAsync(DeleteThreatIntelSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateFromMasterAccount


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        Task<DisassociateFromMasterAccountResponse> DisassociateFromMasterAccountAsync(DisassociateFromMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateMembers


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        Task<DisassociateMembersResponse> DisassociateMembersAsync(DisassociateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDetector


        /// <summary>
        /// Initiates the asynchronous execution of the GetDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        Task<GetDetectorResponse> GetDetectorAsync(GetDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFilter


        /// <summary>
        /// Initiates the asynchronous execution of the GetFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        Task<GetFilterResponse> GetFilterAsync(GetFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFindings


        /// <summary>
        /// Initiates the asynchronous execution of the GetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        Task<GetFindingsResponse> GetFindingsAsync(GetFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFindingsStatistics


        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingsStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        Task<GetFindingsStatisticsResponse> GetFindingsStatisticsAsync(GetFindingsStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInvitationsCount


        /// <summary>
        /// Initiates the asynchronous execution of the GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        Task<GetInvitationsCountResponse> GetInvitationsCountAsync(GetInvitationsCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIPSet


        /// <summary>
        /// Initiates the asynchronous execution of the GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        Task<GetIPSetResponse> GetIPSetAsync(GetIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMasterAccount


        /// <summary>
        /// Initiates the asynchronous execution of the GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        Task<GetMasterAccountResponse> GetMasterAccountAsync(GetMasterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMembers


        /// <summary>
        /// Initiates the asynchronous execution of the GetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        Task<GetMembersResponse> GetMembersAsync(GetMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetThreatIntelSet


        /// <summary>
        /// Initiates the asynchronous execution of the GetThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThreatIntelSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        Task<GetThreatIntelSetResponse> GetThreatIntelSetAsync(GetThreatIntelSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InviteMembers


        /// <summary>
        /// Initiates the asynchronous execution of the InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        Task<InviteMembersResponse> InviteMembersAsync(InviteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDetectors


        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        Task<ListDetectorsResponse> ListDetectorsAsync(ListDetectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFilters


        /// <summary>
        /// Initiates the asynchronous execution of the ListFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFilters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        Task<ListFiltersResponse> ListFiltersAsync(ListFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFindings


        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInvitations


        /// <summary>
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIPSets


        /// <summary>
        /// Initiates the asynchronous execution of the ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        Task<ListIPSetsResponse> ListIPSetsAsync(ListIPSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMembers


        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThreatIntelSets


        /// <summary>
        /// Initiates the asynchronous execution of the ListThreatIntelSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThreatIntelSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        Task<ListThreatIntelSetsResponse> ListThreatIntelSetsAsync(ListThreatIntelSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMonitoringMembers


        /// <summary>
        /// Initiates the asynchronous execution of the StartMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        Task<StartMonitoringMembersResponse> StartMonitoringMembersAsync(StartMonitoringMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopMonitoringMembers


        /// <summary>
        /// Initiates the asynchronous execution of the StopMonitoringMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        Task<StopMonitoringMembersResponse> StopMonitoringMembersAsync(StopMonitoringMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnarchiveFindings


        /// <summary>
        /// Initiates the asynchronous execution of the UnarchiveFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        Task<UnarchiveFindingsResponse> UnarchiveFindingsAsync(UnarchiveFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDetector


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        Task<UpdateDetectorResponse> UpdateDetectorAsync(UpdateDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFilter


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        Task<UpdateFilterResponse> UpdateFilterAsync(UpdateFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFindingsFeedback


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFindingsFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFeedback operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        Task<UpdateFindingsFeedbackResponse> UpdateFindingsFeedbackAsync(UpdateFindingsFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIPSet


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        Task<UpdateIPSetResponse> UpdateIPSetAsync(UpdateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateThreatIntelSet


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThreatIntelSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatIntelSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        Task<UpdateThreatIntelSetResponse> UpdateThreatIntelSetAsync(UpdateThreatIntelSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}