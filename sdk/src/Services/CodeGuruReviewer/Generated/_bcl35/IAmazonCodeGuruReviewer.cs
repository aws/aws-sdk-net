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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeGuruReviewer.Model;

namespace Amazon.CodeGuruReviewer
{
    /// <summary>
    /// Interface for accessing CodeGuruReviewer
    ///
    /// This section provides documentation for the Amazon CodeGuru Reviewer API operations.
    /// Amazon CodeGuru Reviewer is a service that uses program analysis and machine learning
    /// to detect potential defects that are difficult for developers to find and recommends
    /// fixes in your Java code.
    /// 
    ///  
    /// <para>
    /// By proactively detecting and providing recommendations for addressing code defects
    /// and implementing best practices, CodeGuru Reviewer improves the overall quality and
    /// maintainability of your code base during the code review stage. For more information
    /// about CodeGuru Reviewer, see the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/welcome.html">Amazon
    /// CodeGuru Reviewer User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeGuruReviewer : IAmazonService, IDisposable
    {

        
        #region  AssociateRepository


        /// <summary>
        /// Associates an AWS CodeCommit repository with Amazon CodeGuru Reviewer. When you associate
        /// an AWS CodeCommit repository with Amazon CodeGuru Reviewer, Amazon CodeGuru Reviewer
        /// will provide recommendations for each pull request raised within the repository. You
        /// can view recommendations in the AWS CodeCommit repository.
        /// 
        ///  
        /// <para>
        /// You can associate a GitHub repository using the Amazon CodeGuru Reviewer console.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRepository service method.</param>
        /// 
        /// <returns>The response from the AssociateRepository service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/AssociateRepository">REST API Reference for AssociateRepository Operation</seealso>
        AssociateRepositoryResponse AssociateRepository(AssociateRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRepository operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/AssociateRepository">REST API Reference for AssociateRepository Operation</seealso>
        IAsyncResult BeginAssociateRepository(AssociateRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRepository.</param>
        /// 
        /// <returns>Returns a  AssociateRepositoryResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/AssociateRepository">REST API Reference for AssociateRepository Operation</seealso>
        AssociateRepositoryResponse EndAssociateRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCodeReview


        /// <summary>
        /// Returns the metadaata associated with the code review along with its status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeReview service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeReview service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeCodeReview">REST API Reference for DescribeCodeReview Operation</seealso>
        DescribeCodeReviewResponse DescribeCodeReview(DescribeCodeReviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeReview operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCodeReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeCodeReview">REST API Reference for DescribeCodeReview Operation</seealso>
        IAsyncResult BeginDescribeCodeReview(DescribeCodeReviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCodeReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCodeReview.</param>
        /// 
        /// <returns>Returns a  DescribeCodeReviewResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeCodeReview">REST API Reference for DescribeCodeReview Operation</seealso>
        DescribeCodeReviewResponse EndDescribeCodeReview(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRecommendationFeedback


        /// <summary>
        /// Describes the customer feedback for a CodeGuru Reviewer recommendation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationFeedback service method.</param>
        /// 
        /// <returns>The response from the DescribeRecommendationFeedback service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRecommendationFeedback">REST API Reference for DescribeRecommendationFeedback Operation</seealso>
        DescribeRecommendationFeedbackResponse DescribeRecommendationFeedback(DescribeRecommendationFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationFeedback operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecommendationFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRecommendationFeedback">REST API Reference for DescribeRecommendationFeedback Operation</seealso>
        IAsyncResult BeginDescribeRecommendationFeedback(DescribeRecommendationFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecommendationFeedback.</param>
        /// 
        /// <returns>Returns a  DescribeRecommendationFeedbackResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRecommendationFeedback">REST API Reference for DescribeRecommendationFeedback Operation</seealso>
        DescribeRecommendationFeedbackResponse EndDescribeRecommendationFeedback(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRepositoryAssociation


        /// <summary>
        /// Describes a repository association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositoryAssociation service method.</param>
        /// 
        /// <returns>The response from the DescribeRepositoryAssociation service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.NotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRepositoryAssociation">REST API Reference for DescribeRepositoryAssociation Operation</seealso>
        DescribeRepositoryAssociationResponse DescribeRepositoryAssociation(DescribeRepositoryAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositoryAssociation operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRepositoryAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRepositoryAssociation">REST API Reference for DescribeRepositoryAssociation Operation</seealso>
        IAsyncResult BeginDescribeRepositoryAssociation(DescribeRepositoryAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRepositoryAssociation.</param>
        /// 
        /// <returns>Returns a  DescribeRepositoryAssociationResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRepositoryAssociation">REST API Reference for DescribeRepositoryAssociation Operation</seealso>
        DescribeRepositoryAssociationResponse EndDescribeRepositoryAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateRepository


        /// <summary>
        /// Removes the association between Amazon CodeGuru Reviewer and a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRepository service method.</param>
        /// 
        /// <returns>The response from the DisassociateRepository service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.NotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DisassociateRepository">REST API Reference for DisassociateRepository Operation</seealso>
        DisassociateRepositoryResponse DisassociateRepository(DisassociateRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRepository operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DisassociateRepository">REST API Reference for DisassociateRepository Operation</seealso>
        IAsyncResult BeginDisassociateRepository(DisassociateRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRepository.</param>
        /// 
        /// <returns>Returns a  DisassociateRepositoryResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DisassociateRepository">REST API Reference for DisassociateRepository Operation</seealso>
        DisassociateRepositoryResponse EndDisassociateRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCodeReviews


        /// <summary>
        /// Lists all the code reviews that the customer has created in the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviews service method.</param>
        /// 
        /// <returns>The response from the ListCodeReviews service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListCodeReviews">REST API Reference for ListCodeReviews Operation</seealso>
        ListCodeReviewsResponse ListCodeReviews(ListCodeReviewsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeReviews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviews operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeReviews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListCodeReviews">REST API Reference for ListCodeReviews Operation</seealso>
        IAsyncResult BeginListCodeReviews(ListCodeReviewsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeReviews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeReviews.</param>
        /// 
        /// <returns>Returns a  ListCodeReviewsResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListCodeReviews">REST API Reference for ListCodeReviews Operation</seealso>
        ListCodeReviewsResponse EndListCodeReviews(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecommendationFeedback


        /// <summary>
        /// Lists the customer feedback for a CodeGuru Reviewer recommendation for all users.
        /// This API will be used from the console to extract the previously given feedback by
        /// the user to pre-populate the feedback emojis for all recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationFeedback service method.</param>
        /// 
        /// <returns>The response from the ListRecommendationFeedback service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendationFeedback">REST API Reference for ListRecommendationFeedback Operation</seealso>
        ListRecommendationFeedbackResponse ListRecommendationFeedback(ListRecommendationFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationFeedback operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendationFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendationFeedback">REST API Reference for ListRecommendationFeedback Operation</seealso>
        IAsyncResult BeginListRecommendationFeedback(ListRecommendationFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendationFeedback.</param>
        /// 
        /// <returns>Returns a  ListRecommendationFeedbackResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendationFeedback">REST API Reference for ListRecommendationFeedback Operation</seealso>
        ListRecommendationFeedbackResponse EndListRecommendationFeedback(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecommendations


        /// <summary>
        /// Returns the list of all recommendations for a completed code review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        IAsyncResult BeginListRecommendations(ListRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendations.</param>
        /// 
        /// <returns>Returns a  ListRecommendationsResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        ListRecommendationsResponse EndListRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRepositoryAssociations


        /// <summary>
        /// Lists repository associations. You can optionally filter on one or more of the following
        /// recommendation properties: provider types, states, names, and owners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoryAssociations service method.</param>
        /// 
        /// <returns>The response from the ListRepositoryAssociations service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRepositoryAssociations">REST API Reference for ListRepositoryAssociations Operation</seealso>
        ListRepositoryAssociationsResponse ListRepositoryAssociations(ListRepositoryAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositoryAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoryAssociations operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositoryAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRepositoryAssociations">REST API Reference for ListRepositoryAssociations Operation</seealso>
        IAsyncResult BeginListRepositoryAssociations(ListRepositoryAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositoryAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositoryAssociations.</param>
        /// 
        /// <returns>Returns a  ListRepositoryAssociationsResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRepositoryAssociations">REST API Reference for ListRepositoryAssociations Operation</seealso>
        ListRepositoryAssociationsResponse EndListRepositoryAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRecommendationFeedback


        /// <summary>
        /// Stores customer feedback for a CodeGuru-Reviewer recommendation. When this API is
        /// called again with different reactions the previous feedback is overwritten.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecommendationFeedback service method.</param>
        /// 
        /// <returns>The response from the PutRecommendationFeedback service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/PutRecommendationFeedback">REST API Reference for PutRecommendationFeedback Operation</seealso>
        PutRecommendationFeedbackResponse PutRecommendationFeedback(PutRecommendationFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecommendationFeedback operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecommendationFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/PutRecommendationFeedback">REST API Reference for PutRecommendationFeedback Operation</seealso>
        IAsyncResult BeginPutRecommendationFeedback(PutRecommendationFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecommendationFeedback.</param>
        /// 
        /// <returns>Returns a  PutRecommendationFeedbackResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/PutRecommendationFeedback">REST API Reference for PutRecommendationFeedback Operation</seealso>
        PutRecommendationFeedbackResponse EndPutRecommendationFeedback(IAsyncResult asyncResult);

        #endregion
        
    }
}