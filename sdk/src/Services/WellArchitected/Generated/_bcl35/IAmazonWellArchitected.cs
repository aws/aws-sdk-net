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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WellArchitected.Model;

namespace Amazon.WellArchitected
{
    /// <summary>
    /// Interface for accessing WellArchitected
    ///
    /// AWS Well-Architected Tool 
    /// <para>
    /// This is the <i>AWS Well-Architected Tool API Reference</i>. The AWS Well-Architected
    /// Tool API provides programmatic access to the <a href="http://aws.amazon.com/well-architected-tool">AWS
    /// Well-Architected Tool</a> in the <a href="https://console.aws.amazon.com/wellarchitected">AWS
    /// Management Console</a>. For information about the AWS Well-Architected Tool, see the
    /// <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/intro.html">AWS
    /// Well-Architected Tool User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonWellArchitected : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWellArchitectedPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateLenses


        /// <summary>
        /// Associate a lens to a workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLenses service method.</param>
        /// 
        /// <returns>The response from the AssociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/AssociateLenses">REST API Reference for AssociateLenses Operation</seealso>
        AssociateLensesResponse AssociateLenses(AssociateLensesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateLenses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateLenses operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateLenses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/AssociateLenses">REST API Reference for AssociateLenses Operation</seealso>
        IAsyncResult BeginAssociateLenses(AssociateLensesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateLenses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateLenses.</param>
        /// 
        /// <returns>Returns a  AssociateLensesResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/AssociateLenses">REST API Reference for AssociateLenses Operation</seealso>
        AssociateLensesResponse EndAssociateLenses(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMilestone


        /// <summary>
        /// Create a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMilestone service method.</param>
        /// 
        /// <returns>The response from the CreateMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateMilestone">REST API Reference for CreateMilestone Operation</seealso>
        CreateMilestoneResponse CreateMilestone(CreateMilestoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMilestone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMilestone operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMilestone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateMilestone">REST API Reference for CreateMilestone Operation</seealso>
        IAsyncResult BeginCreateMilestone(CreateMilestoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMilestone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMilestone.</param>
        /// 
        /// <returns>Returns a  CreateMilestoneResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateMilestone">REST API Reference for CreateMilestone Operation</seealso>
        CreateMilestoneResponse EndCreateMilestone(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkload


        /// <summary>
        /// Create a new workload.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share the workload with other AWS accounts and IAM users
        /// in the same AWS Region. Only the owner of a workload can delete it.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/define-workload.html">Defining
        /// a Workload</a> in the <i>AWS Well-Architected Tool User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkload service method.</param>
        /// 
        /// <returns>The response from the CreateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkload">REST API Reference for CreateWorkload Operation</seealso>
        CreateWorkloadResponse CreateWorkload(CreateWorkloadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkload operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkload">REST API Reference for CreateWorkload Operation</seealso>
        IAsyncResult BeginCreateWorkload(CreateWorkloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkload.</param>
        /// 
        /// <returns>Returns a  CreateWorkloadResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkload">REST API Reference for CreateWorkload Operation</seealso>
        CreateWorkloadResponse EndCreateWorkload(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkloadShare


        /// <summary>
        /// Create a workload share.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share it with other AWS accounts and IAM users in the
        /// same AWS Region. Shared access to a workload is not removed until the workload invitation
        /// is deleted.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/workloads-sharing.html">Sharing
        /// a Workload</a> in the <i>AWS Well-Architected Tool User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadShare service method.</param>
        /// 
        /// <returns>The response from the CreateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkloadShare">REST API Reference for CreateWorkloadShare Operation</seealso>
        CreateWorkloadShareResponse CreateWorkloadShare(CreateWorkloadShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkloadShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadShare operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkloadShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkloadShare">REST API Reference for CreateWorkloadShare Operation</seealso>
        IAsyncResult BeginCreateWorkloadShare(CreateWorkloadShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkloadShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkloadShare.</param>
        /// 
        /// <returns>Returns a  CreateWorkloadShareResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkloadShare">REST API Reference for CreateWorkloadShare Operation</seealso>
        CreateWorkloadShareResponse EndCreateWorkloadShare(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkload


        /// <summary>
        /// Delete an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkload service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkload">REST API Reference for DeleteWorkload Operation</seealso>
        DeleteWorkloadResponse DeleteWorkload(DeleteWorkloadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkload operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkload">REST API Reference for DeleteWorkload Operation</seealso>
        IAsyncResult BeginDeleteWorkload(DeleteWorkloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkload.</param>
        /// 
        /// <returns>Returns a  DeleteWorkloadResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkload">REST API Reference for DeleteWorkload Operation</seealso>
        DeleteWorkloadResponse EndDeleteWorkload(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkloadShare


        /// <summary>
        /// Delete a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadShare service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkloadShare">REST API Reference for DeleteWorkloadShare Operation</seealso>
        DeleteWorkloadShareResponse DeleteWorkloadShare(DeleteWorkloadShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkloadShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadShare operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkloadShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkloadShare">REST API Reference for DeleteWorkloadShare Operation</seealso>
        IAsyncResult BeginDeleteWorkloadShare(DeleteWorkloadShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkloadShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkloadShare.</param>
        /// 
        /// <returns>Returns a  DeleteWorkloadShareResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkloadShare">REST API Reference for DeleteWorkloadShare Operation</seealso>
        DeleteWorkloadShareResponse EndDeleteWorkloadShare(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateLenses


        /// <summary>
        /// Disassociate a lens from a workload.
        /// 
        ///  <note> 
        /// <para>
        /// The AWS Well-Architected Framework lens (<code>wellarchitected</code>) cannot be removed
        /// from a workload.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLenses service method.</param>
        /// 
        /// <returns>The response from the DisassociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DisassociateLenses">REST API Reference for DisassociateLenses Operation</seealso>
        DisassociateLensesResponse DisassociateLenses(DisassociateLensesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateLenses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLenses operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateLenses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DisassociateLenses">REST API Reference for DisassociateLenses Operation</seealso>
        IAsyncResult BeginDisassociateLenses(DisassociateLensesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateLenses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateLenses.</param>
        /// 
        /// <returns>Returns a  DisassociateLensesResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DisassociateLenses">REST API Reference for DisassociateLenses Operation</seealso>
        DisassociateLensesResponse EndDisassociateLenses(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAnswer


        /// <summary>
        /// Get the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnswer service method.</param>
        /// 
        /// <returns>The response from the GetAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAnswer">REST API Reference for GetAnswer Operation</seealso>
        GetAnswerResponse GetAnswer(GetAnswerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnswer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnswer operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnswer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAnswer">REST API Reference for GetAnswer Operation</seealso>
        IAsyncResult BeginGetAnswer(GetAnswerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnswer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnswer.</param>
        /// 
        /// <returns>Returns a  GetAnswerResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAnswer">REST API Reference for GetAnswer Operation</seealso>
        GetAnswerResponse EndGetAnswer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLensReview


        /// <summary>
        /// Get lens review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReview service method.</param>
        /// 
        /// <returns>The response from the GetLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReview">REST API Reference for GetLensReview Operation</seealso>
        GetLensReviewResponse GetLensReview(GetLensReviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLensReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLensReview operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLensReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReview">REST API Reference for GetLensReview Operation</seealso>
        IAsyncResult BeginGetLensReview(GetLensReviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLensReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLensReview.</param>
        /// 
        /// <returns>Returns a  GetLensReviewResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReview">REST API Reference for GetLensReview Operation</seealso>
        GetLensReviewResponse EndGetLensReview(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLensReviewReport


        /// <summary>
        /// Get lens review report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReviewReport service method.</param>
        /// 
        /// <returns>The response from the GetLensReviewReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReviewReport">REST API Reference for GetLensReviewReport Operation</seealso>
        GetLensReviewReportResponse GetLensReviewReport(GetLensReviewReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLensReviewReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLensReviewReport operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLensReviewReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReviewReport">REST API Reference for GetLensReviewReport Operation</seealso>
        IAsyncResult BeginGetLensReviewReport(GetLensReviewReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLensReviewReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLensReviewReport.</param>
        /// 
        /// <returns>Returns a  GetLensReviewReportResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReviewReport">REST API Reference for GetLensReviewReport Operation</seealso>
        GetLensReviewReportResponse EndGetLensReviewReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLensVersionDifference


        /// <summary>
        /// Get lens version differences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensVersionDifference service method.</param>
        /// 
        /// <returns>The response from the GetLensVersionDifference service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensVersionDifference">REST API Reference for GetLensVersionDifference Operation</seealso>
        GetLensVersionDifferenceResponse GetLensVersionDifference(GetLensVersionDifferenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLensVersionDifference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLensVersionDifference operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLensVersionDifference
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensVersionDifference">REST API Reference for GetLensVersionDifference Operation</seealso>
        IAsyncResult BeginGetLensVersionDifference(GetLensVersionDifferenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLensVersionDifference operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLensVersionDifference.</param>
        /// 
        /// <returns>Returns a  GetLensVersionDifferenceResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensVersionDifference">REST API Reference for GetLensVersionDifference Operation</seealso>
        GetLensVersionDifferenceResponse EndGetLensVersionDifference(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMilestone


        /// <summary>
        /// Get a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMilestone service method.</param>
        /// 
        /// <returns>The response from the GetMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetMilestone">REST API Reference for GetMilestone Operation</seealso>
        GetMilestoneResponse GetMilestone(GetMilestoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMilestone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMilestone operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMilestone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetMilestone">REST API Reference for GetMilestone Operation</seealso>
        IAsyncResult BeginGetMilestone(GetMilestoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMilestone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMilestone.</param>
        /// 
        /// <returns>Returns a  GetMilestoneResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetMilestone">REST API Reference for GetMilestone Operation</seealso>
        GetMilestoneResponse EndGetMilestone(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkload


        /// <summary>
        /// Get an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload service method.</param>
        /// 
        /// <returns>The response from the GetWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        GetWorkloadResponse GetWorkload(GetWorkloadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        IAsyncResult BeginGetWorkload(GetWorkloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkload.</param>
        /// 
        /// <returns>Returns a  GetWorkloadResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        GetWorkloadResponse EndGetWorkload(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnswers


        /// <summary>
        /// List of answers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnswers service method.</param>
        /// 
        /// <returns>The response from the ListAnswers service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAnswers">REST API Reference for ListAnswers Operation</seealso>
        ListAnswersResponse ListAnswers(ListAnswersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnswers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnswers operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnswers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAnswers">REST API Reference for ListAnswers Operation</seealso>
        IAsyncResult BeginListAnswers(ListAnswersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnswers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnswers.</param>
        /// 
        /// <returns>Returns a  ListAnswersResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAnswers">REST API Reference for ListAnswers Operation</seealso>
        ListAnswersResponse EndListAnswers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLenses


        /// <summary>
        /// List the available lenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLenses service method.</param>
        /// 
        /// <returns>The response from the ListLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLenses">REST API Reference for ListLenses Operation</seealso>
        ListLensesResponse ListLenses(ListLensesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLenses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLenses operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLenses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLenses">REST API Reference for ListLenses Operation</seealso>
        IAsyncResult BeginListLenses(ListLensesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLenses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLenses.</param>
        /// 
        /// <returns>Returns a  ListLensesResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLenses">REST API Reference for ListLenses Operation</seealso>
        ListLensesResponse EndListLenses(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLensReviewImprovements


        /// <summary>
        /// List lens review improvements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviewImprovements service method.</param>
        /// 
        /// <returns>The response from the ListLensReviewImprovements service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviewImprovements">REST API Reference for ListLensReviewImprovements Operation</seealso>
        ListLensReviewImprovementsResponse ListLensReviewImprovements(ListLensReviewImprovementsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLensReviewImprovements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviewImprovements operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLensReviewImprovements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviewImprovements">REST API Reference for ListLensReviewImprovements Operation</seealso>
        IAsyncResult BeginListLensReviewImprovements(ListLensReviewImprovementsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLensReviewImprovements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLensReviewImprovements.</param>
        /// 
        /// <returns>Returns a  ListLensReviewImprovementsResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviewImprovements">REST API Reference for ListLensReviewImprovements Operation</seealso>
        ListLensReviewImprovementsResponse EndListLensReviewImprovements(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLensReviews


        /// <summary>
        /// List lens reviews.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviews service method.</param>
        /// 
        /// <returns>The response from the ListLensReviews service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviews">REST API Reference for ListLensReviews Operation</seealso>
        ListLensReviewsResponse ListLensReviews(ListLensReviewsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLensReviews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviews operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLensReviews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviews">REST API Reference for ListLensReviews Operation</seealso>
        IAsyncResult BeginListLensReviews(ListLensReviewsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLensReviews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLensReviews.</param>
        /// 
        /// <returns>Returns a  ListLensReviewsResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviews">REST API Reference for ListLensReviews Operation</seealso>
        ListLensReviewsResponse EndListLensReviews(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMilestones


        /// <summary>
        /// List all milestones for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMilestones service method.</param>
        /// 
        /// <returns>The response from the ListMilestones service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListMilestones">REST API Reference for ListMilestones Operation</seealso>
        ListMilestonesResponse ListMilestones(ListMilestonesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMilestones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMilestones operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMilestones
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListMilestones">REST API Reference for ListMilestones Operation</seealso>
        IAsyncResult BeginListMilestones(ListMilestonesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMilestones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMilestones.</param>
        /// 
        /// <returns>Returns a  ListMilestonesResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListMilestones">REST API Reference for ListMilestones Operation</seealso>
        ListMilestonesResponse EndListMilestones(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNotifications


        /// <summary>
        /// List lens notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        ListNotificationsResponse ListNotifications(ListNotificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        IAsyncResult BeginListNotifications(ListNotificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotifications.</param>
        /// 
        /// <returns>Returns a  ListNotificationsResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        ListNotificationsResponse EndListNotifications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListShareInvitations


        /// <summary>
        /// List the workload invitations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListShareInvitations service method.</param>
        /// 
        /// <returns>The response from the ListShareInvitations service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListShareInvitations">REST API Reference for ListShareInvitations Operation</seealso>
        ListShareInvitationsResponse ListShareInvitations(ListShareInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListShareInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListShareInvitations operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListShareInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListShareInvitations">REST API Reference for ListShareInvitations Operation</seealso>
        IAsyncResult BeginListShareInvitations(ListShareInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListShareInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListShareInvitations.</param>
        /// 
        /// <returns>Returns a  ListShareInvitationsResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListShareInvitations">REST API Reference for ListShareInvitations Operation</seealso>
        ListShareInvitationsResponse EndListShareInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkloads


        /// <summary>
        /// List workloads. Paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// 
        /// <returns>The response from the ListWorkloads service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        ListWorkloadsResponse ListWorkloads(ListWorkloadsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloads
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        IAsyncResult BeginListWorkloads(ListWorkloadsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloads operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloads.</param>
        /// 
        /// <returns>Returns a  ListWorkloadsResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        ListWorkloadsResponse EndListWorkloads(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkloadShares


        /// <summary>
        /// List the workload shares associated with the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadShares service method.</param>
        /// 
        /// <returns>The response from the ListWorkloadShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloadShares">REST API Reference for ListWorkloadShares Operation</seealso>
        ListWorkloadSharesResponse ListWorkloadShares(ListWorkloadSharesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloadShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadShares operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloadShares
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloadShares">REST API Reference for ListWorkloadShares Operation</seealso>
        IAsyncResult BeginListWorkloadShares(ListWorkloadSharesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloadShares operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloadShares.</param>
        /// 
        /// <returns>Returns a  ListWorkloadSharesResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloadShares">REST API Reference for ListWorkloadShares Operation</seealso>
        ListWorkloadSharesResponse EndListWorkloadShares(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from a resource.
        /// 
        ///  
        /// <para>
        /// To specify multiple tags, use separate <b>tagKeys</b> parameters, for example:
        /// </para>
        ///  
        /// <para>
        ///  <code>DELETE /tags/WorkloadArn?tagKeys=key1&amp;tagKeys=key2</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAnswer


        /// <summary>
        /// Update the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnswer service method.</param>
        /// 
        /// <returns>The response from the UpdateAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAnswer">REST API Reference for UpdateAnswer Operation</seealso>
        UpdateAnswerResponse UpdateAnswer(UpdateAnswerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnswer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnswer operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnswer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAnswer">REST API Reference for UpdateAnswer Operation</seealso>
        IAsyncResult BeginUpdateAnswer(UpdateAnswerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnswer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnswer.</param>
        /// 
        /// <returns>Returns a  UpdateAnswerResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAnswer">REST API Reference for UpdateAnswer Operation</seealso>
        UpdateAnswerResponse EndUpdateAnswer(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLensReview


        /// <summary>
        /// Update lens review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLensReview service method.</param>
        /// 
        /// <returns>The response from the UpdateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateLensReview">REST API Reference for UpdateLensReview Operation</seealso>
        UpdateLensReviewResponse UpdateLensReview(UpdateLensReviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLensReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLensReview operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLensReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateLensReview">REST API Reference for UpdateLensReview Operation</seealso>
        IAsyncResult BeginUpdateLensReview(UpdateLensReviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLensReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLensReview.</param>
        /// 
        /// <returns>Returns a  UpdateLensReviewResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateLensReview">REST API Reference for UpdateLensReview Operation</seealso>
        UpdateLensReviewResponse EndUpdateLensReview(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateShareInvitation


        /// <summary>
        /// Update a workload invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateShareInvitation service method.</param>
        /// 
        /// <returns>The response from the UpdateShareInvitation service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateShareInvitation">REST API Reference for UpdateShareInvitation Operation</seealso>
        UpdateShareInvitationResponse UpdateShareInvitation(UpdateShareInvitationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateShareInvitation operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateShareInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateShareInvitation">REST API Reference for UpdateShareInvitation Operation</seealso>
        IAsyncResult BeginUpdateShareInvitation(UpdateShareInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateShareInvitation.</param>
        /// 
        /// <returns>Returns a  UpdateShareInvitationResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateShareInvitation">REST API Reference for UpdateShareInvitation Operation</seealso>
        UpdateShareInvitationResponse EndUpdateShareInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkload


        /// <summary>
        /// Update an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkload service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        UpdateWorkloadResponse UpdateWorkload(UpdateWorkloadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkload operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        IAsyncResult BeginUpdateWorkload(UpdateWorkloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkload.</param>
        /// 
        /// <returns>Returns a  UpdateWorkloadResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        UpdateWorkloadResponse EndUpdateWorkload(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkloadShare


        /// <summary>
        /// Update a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadShare service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkloadShare">REST API Reference for UpdateWorkloadShare Operation</seealso>
        UpdateWorkloadShareResponse UpdateWorkloadShare(UpdateWorkloadShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkloadShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadShare operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkloadShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkloadShare">REST API Reference for UpdateWorkloadShare Operation</seealso>
        IAsyncResult BeginUpdateWorkloadShare(UpdateWorkloadShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkloadShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkloadShare.</param>
        /// 
        /// <returns>Returns a  UpdateWorkloadShareResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkloadShare">REST API Reference for UpdateWorkloadShare Operation</seealso>
        UpdateWorkloadShareResponse EndUpdateWorkloadShare(IAsyncResult asyncResult);

        #endregion
        
        #region  UpgradeLensReview


        /// <summary>
        /// Upgrade lens review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeLensReview service method.</param>
        /// 
        /// <returns>The response from the UpgradeLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the AWS Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeLensReview">REST API Reference for UpgradeLensReview Operation</seealso>
        UpgradeLensReviewResponse UpgradeLensReview(UpgradeLensReviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpgradeLensReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradeLensReview operation on AmazonWellArchitectedClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpgradeLensReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeLensReview">REST API Reference for UpgradeLensReview Operation</seealso>
        IAsyncResult BeginUpgradeLensReview(UpgradeLensReviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpgradeLensReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpgradeLensReview.</param>
        /// 
        /// <returns>Returns a  UpgradeLensReviewResult from WellArchitected.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeLensReview">REST API Reference for UpgradeLensReview Operation</seealso>
        UpgradeLensReviewResponse EndUpgradeLensReview(IAsyncResult asyncResult);

        #endregion
        
    }
}