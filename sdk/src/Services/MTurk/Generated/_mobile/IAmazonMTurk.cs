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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MTurk.Model;

namespace Amazon.MTurk
{
    /// <summary>
    /// Interface for accessing MTurk
    ///
    /// Amazon Mechanical Turk API Reference
    /// </summary>
    public partial interface IAmazonMTurk : IAmazonService, IDisposable
    {
                
        #region  AcceptQualificationRequest


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptQualificationRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptQualificationRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AcceptQualificationRequest">REST API Reference for AcceptQualificationRequest Operation</seealso>
        Task<AcceptQualificationRequestResponse> AcceptQualificationRequestAsync(AcceptQualificationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ApproveAssignment


        /// <summary>
        /// Initiates the asynchronous execution of the ApproveAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApproveAssignment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ApproveAssignment">REST API Reference for ApproveAssignment Operation</seealso>
        Task<ApproveAssignmentResponse> ApproveAssignmentAsync(ApproveAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateQualificationWithWorker


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateQualificationWithWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateQualificationWithWorker operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AssociateQualificationWithWorker">REST API Reference for AssociateQualificationWithWorker Operation</seealso>
        Task<AssociateQualificationWithWorkerResponse> AssociateQualificationWithWorkerAsync(AssociateQualificationWithWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAdditionalAssignmentsForHIT


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAdditionalAssignmentsForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAdditionalAssignmentsForHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateAdditionalAssignmentsForHIT">REST API Reference for CreateAdditionalAssignmentsForHIT Operation</seealso>
        Task<CreateAdditionalAssignmentsForHITResponse> CreateAdditionalAssignmentsForHITAsync(CreateAdditionalAssignmentsForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHIT


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHIT">REST API Reference for CreateHIT Operation</seealso>
        Task<CreateHITResponse> CreateHITAsync(CreateHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHITType


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHITType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHITType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITType">REST API Reference for CreateHITType Operation</seealso>
        Task<CreateHITTypeResponse> CreateHITTypeAsync(CreateHITTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHITWithHITType


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHITWithHITType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHITWithHITType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITWithHITType">REST API Reference for CreateHITWithHITType Operation</seealso>
        Task<CreateHITWithHITTypeResponse> CreateHITWithHITTypeAsync(CreateHITWithHITTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateQualificationType


        /// <summary>
        /// Initiates the asynchronous execution of the CreateQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateQualificationType">REST API Reference for CreateQualificationType Operation</seealso>
        Task<CreateQualificationTypeResponse> CreateQualificationTypeAsync(CreateQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkerBlock


        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkerBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateWorkerBlock">REST API Reference for CreateWorkerBlock Operation</seealso>
        Task<CreateWorkerBlockResponse> CreateWorkerBlockAsync(CreateWorkerBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHIT


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteHIT">REST API Reference for DeleteHIT Operation</seealso>
        Task<DeleteHITResponse> DeleteHITAsync(DeleteHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQualificationType


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteQualificationType">REST API Reference for DeleteQualificationType Operation</seealso>
        Task<DeleteQualificationTypeResponse> DeleteQualificationTypeAsync(DeleteQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkerBlock


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkerBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteWorkerBlock">REST API Reference for DeleteWorkerBlock Operation</seealso>
        Task<DeleteWorkerBlockResponse> DeleteWorkerBlockAsync(DeleteWorkerBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateQualificationFromWorker


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateQualificationFromWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQualificationFromWorker operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DisassociateQualificationFromWorker">REST API Reference for DisassociateQualificationFromWorker Operation</seealso>
        Task<DisassociateQualificationFromWorkerResponse> DisassociateQualificationFromWorkerAsync(DisassociateQualificationFromWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountBalance


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountBalance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountBalance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAccountBalance">REST API Reference for GetAccountBalance Operation</seealso>
        Task<GetAccountBalanceResponse> GetAccountBalanceAsync(GetAccountBalanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssignment


        /// <summary>
        /// Initiates the asynchronous execution of the GetAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssignment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAssignment">REST API Reference for GetAssignment Operation</seealso>
        Task<GetAssignmentResponse> GetAssignmentAsync(GetAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFileUploadURL


        /// <summary>
        /// Initiates the asynchronous execution of the GetFileUploadURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFileUploadURL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetFileUploadURL">REST API Reference for GetFileUploadURL Operation</seealso>
        Task<GetFileUploadURLResponse> GetFileUploadURLAsync(GetFileUploadURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHIT


        /// <summary>
        /// Initiates the asynchronous execution of the GetHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetHIT">REST API Reference for GetHIT Operation</seealso>
        Task<GetHITResponse> GetHITAsync(GetHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQualificationScore


        /// <summary>
        /// Initiates the asynchronous execution of the GetQualificationScore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationScore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationScore">REST API Reference for GetQualificationScore Operation</seealso>
        Task<GetQualificationScoreResponse> GetQualificationScoreAsync(GetQualificationScoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQualificationType


        /// <summary>
        /// Initiates the asynchronous execution of the GetQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationType">REST API Reference for GetQualificationType Operation</seealso>
        Task<GetQualificationTypeResponse> GetQualificationTypeAsync(GetQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssignmentsForHIT


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssignmentsForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssignmentsForHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListAssignmentsForHIT">REST API Reference for ListAssignmentsForHIT Operation</seealso>
        Task<ListAssignmentsForHITResponse> ListAssignmentsForHITAsync(ListAssignmentsForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBonusPayments


        /// <summary>
        /// Initiates the asynchronous execution of the ListBonusPayments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBonusPayments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListBonusPayments">REST API Reference for ListBonusPayments Operation</seealso>
        Task<ListBonusPaymentsResponse> ListBonusPaymentsAsync(ListBonusPaymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHITs


        /// <summary>
        /// Initiates the asynchronous execution of the ListHITs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHITs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITs">REST API Reference for ListHITs Operation</seealso>
        Task<ListHITsResponse> ListHITsAsync(ListHITsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHITsForQualificationType


        /// <summary>
        /// Initiates the asynchronous execution of the ListHITsForQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHITsForQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITsForQualificationType">REST API Reference for ListHITsForQualificationType Operation</seealso>
        Task<ListHITsForQualificationTypeResponse> ListHITsForQualificationTypeAsync(ListHITsForQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQualificationRequests


        /// <summary>
        /// Initiates the asynchronous execution of the ListQualificationRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationRequests">REST API Reference for ListQualificationRequests Operation</seealso>
        Task<ListQualificationRequestsResponse> ListQualificationRequestsAsync(ListQualificationRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQualificationTypes


        /// <summary>
        /// Initiates the asynchronous execution of the ListQualificationTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationTypes">REST API Reference for ListQualificationTypes Operation</seealso>
        Task<ListQualificationTypesResponse> ListQualificationTypesAsync(ListQualificationTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReviewableHITs


        /// <summary>
        /// Initiates the asynchronous execution of the ListReviewableHITs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReviewableHITs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewableHITs">REST API Reference for ListReviewableHITs Operation</seealso>
        Task<ListReviewableHITsResponse> ListReviewableHITsAsync(ListReviewableHITsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReviewPolicyResultsForHIT


        /// <summary>
        /// Initiates the asynchronous execution of the ListReviewPolicyResultsForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReviewPolicyResultsForHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewPolicyResultsForHIT">REST API Reference for ListReviewPolicyResultsForHIT Operation</seealso>
        Task<ListReviewPolicyResultsForHITResponse> ListReviewPolicyResultsForHITAsync(ListReviewPolicyResultsForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkerBlocks


        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkerBlocks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerBlocks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkerBlocks">REST API Reference for ListWorkerBlocks Operation</seealso>
        Task<ListWorkerBlocksResponse> ListWorkerBlocksAsync(ListWorkerBlocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkersWithQualificationType


        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkersWithQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkersWithQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkersWithQualificationType">REST API Reference for ListWorkersWithQualificationType Operation</seealso>
        Task<ListWorkersWithQualificationTypeResponse> ListWorkersWithQualificationTypeAsync(ListWorkersWithQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  NotifyWorkers


        /// <summary>
        /// Initiates the asynchronous execution of the NotifyWorkers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyWorkers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/NotifyWorkers">REST API Reference for NotifyWorkers Operation</seealso>
        Task<NotifyWorkersResponse> NotifyWorkersAsync(NotifyWorkersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectAssignment


        /// <summary>
        /// Initiates the asynchronous execution of the RejectAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectAssignment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectAssignment">REST API Reference for RejectAssignment Operation</seealso>
        Task<RejectAssignmentResponse> RejectAssignmentAsync(RejectAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectQualificationRequest


        /// <summary>
        /// Initiates the asynchronous execution of the RejectQualificationRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectQualificationRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectQualificationRequest">REST API Reference for RejectQualificationRequest Operation</seealso>
        Task<RejectQualificationRequestResponse> RejectQualificationRequestAsync(RejectQualificationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendBonus


        /// <summary>
        /// Initiates the asynchronous execution of the SendBonus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBonus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendBonus">REST API Reference for SendBonus Operation</seealso>
        Task<SendBonusResponse> SendBonusAsync(SendBonusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendTestEventNotification


        /// <summary>
        /// Initiates the asynchronous execution of the SendTestEventNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTestEventNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendTestEventNotification">REST API Reference for SendTestEventNotification Operation</seealso>
        Task<SendTestEventNotificationResponse> SendTestEventNotificationAsync(SendTestEventNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateExpirationForHIT


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateExpirationForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExpirationForHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateExpirationForHIT">REST API Reference for UpdateExpirationForHIT Operation</seealso>
        Task<UpdateExpirationForHITResponse> UpdateExpirationForHITAsync(UpdateExpirationForHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHITReviewStatus


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHITReviewStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITReviewStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITReviewStatus">REST API Reference for UpdateHITReviewStatus Operation</seealso>
        Task<UpdateHITReviewStatusResponse> UpdateHITReviewStatusAsync(UpdateHITReviewStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHITTypeOfHIT


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHITTypeOfHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITTypeOfHIT operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITTypeOfHIT">REST API Reference for UpdateHITTypeOfHIT Operation</seealso>
        Task<UpdateHITTypeOfHITResponse> UpdateHITTypeOfHITAsync(UpdateHITTypeOfHITRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotificationSettings


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotificationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateNotificationSettings">REST API Reference for UpdateNotificationSettings Operation</seealso>
        Task<UpdateNotificationSettingsResponse> UpdateNotificationSettingsAsync(UpdateNotificationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQualificationType


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQualificationType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateQualificationType">REST API Reference for UpdateQualificationType Operation</seealso>
        Task<UpdateQualificationTypeResponse> UpdateQualificationTypeAsync(UpdateQualificationTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}