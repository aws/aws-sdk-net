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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KendraRanking.Model;

namespace Amazon.KendraRanking
{
    /// <summary>
    /// Interface for accessing KendraRanking
    ///
    /// Amazon Kendra Intelligent Ranking uses Amazon Kendra semantic search capabilities
    /// to intelligently re-rank a search service's results.
    /// </summary>
    public partial interface IAmazonKendraRanking : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKendraRankingPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateRescoreExecutionPlan


        /// <summary>
        /// Creates a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <code>Rescore</code> API. You set the number
        /// of capacity units that you require for Amazon Kendra Intelligent Ranking to rescore
        /// or re-rank a search service's results.
        /// 
        ///  
        /// <para>
        /// For an example of using the <code>CreateRescoreExecutionPlan</code> API, including
        /// using the Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/search-service-rerank.html">Semantically
        /// ranking a search service's results</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRescoreExecutionPlan service method.</param>
        /// 
        /// <returns>The response from the CreateRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra Intelligent Ranking service.
        /// Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/CreateRescoreExecutionPlan">REST API Reference for CreateRescoreExecutionPlan Operation</seealso>
        CreateRescoreExecutionPlanResponse CreateRescoreExecutionPlan(CreateRescoreExecutionPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRescoreExecutionPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRescoreExecutionPlan operation on AmazonKendraRankingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRescoreExecutionPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/CreateRescoreExecutionPlan">REST API Reference for CreateRescoreExecutionPlan Operation</seealso>
        IAsyncResult BeginCreateRescoreExecutionPlan(CreateRescoreExecutionPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRescoreExecutionPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRescoreExecutionPlan.</param>
        /// 
        /// <returns>Returns a  CreateRescoreExecutionPlanResult from KendraRanking.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/CreateRescoreExecutionPlan">REST API Reference for CreateRescoreExecutionPlan Operation</seealso>
        CreateRescoreExecutionPlanResponse EndCreateRescoreExecutionPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRescoreExecutionPlan


        /// <summary>
        /// Deletes a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <code>Rescore</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRescoreExecutionPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DeleteRescoreExecutionPlan">REST API Reference for DeleteRescoreExecutionPlan Operation</seealso>
        DeleteRescoreExecutionPlanResponse DeleteRescoreExecutionPlan(DeleteRescoreExecutionPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRescoreExecutionPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRescoreExecutionPlan operation on AmazonKendraRankingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRescoreExecutionPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DeleteRescoreExecutionPlan">REST API Reference for DeleteRescoreExecutionPlan Operation</seealso>
        IAsyncResult BeginDeleteRescoreExecutionPlan(DeleteRescoreExecutionPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRescoreExecutionPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRescoreExecutionPlan.</param>
        /// 
        /// <returns>Returns a  DeleteRescoreExecutionPlanResult from KendraRanking.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DeleteRescoreExecutionPlan">REST API Reference for DeleteRescoreExecutionPlan Operation</seealso>
        DeleteRescoreExecutionPlanResponse EndDeleteRescoreExecutionPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRescoreExecutionPlan


        /// <summary>
        /// Gets information about a rescore execution plan. A rescore execution plan is an Amazon
        /// Kendra Intelligent Ranking resource used for provisioning the <code>Rescore</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRescoreExecutionPlan service method.</param>
        /// 
        /// <returns>The response from the DescribeRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DescribeRescoreExecutionPlan">REST API Reference for DescribeRescoreExecutionPlan Operation</seealso>
        DescribeRescoreExecutionPlanResponse DescribeRescoreExecutionPlan(DescribeRescoreExecutionPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRescoreExecutionPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRescoreExecutionPlan operation on AmazonKendraRankingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRescoreExecutionPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DescribeRescoreExecutionPlan">REST API Reference for DescribeRescoreExecutionPlan Operation</seealso>
        IAsyncResult BeginDescribeRescoreExecutionPlan(DescribeRescoreExecutionPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRescoreExecutionPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRescoreExecutionPlan.</param>
        /// 
        /// <returns>Returns a  DescribeRescoreExecutionPlanResult from KendraRanking.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DescribeRescoreExecutionPlan">REST API Reference for DescribeRescoreExecutionPlan Operation</seealso>
        DescribeRescoreExecutionPlanResponse EndDescribeRescoreExecutionPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRescoreExecutionPlans


        /// <summary>
        /// Lists your rescore execution plans. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <code>Rescore</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRescoreExecutionPlans service method.</param>
        /// 
        /// <returns>The response from the ListRescoreExecutionPlans service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListRescoreExecutionPlans">REST API Reference for ListRescoreExecutionPlans Operation</seealso>
        ListRescoreExecutionPlansResponse ListRescoreExecutionPlans(ListRescoreExecutionPlansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRescoreExecutionPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRescoreExecutionPlans operation on AmazonKendraRankingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRescoreExecutionPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListRescoreExecutionPlans">REST API Reference for ListRescoreExecutionPlans Operation</seealso>
        IAsyncResult BeginListRescoreExecutionPlans(ListRescoreExecutionPlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRescoreExecutionPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRescoreExecutionPlans.</param>
        /// 
        /// <returns>Returns a  ListRescoreExecutionPlansResult from KendraRanking.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListRescoreExecutionPlans">REST API Reference for ListRescoreExecutionPlans Operation</seealso>
        ListRescoreExecutionPlansResponse EndListRescoreExecutionPlans(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets a list of tags associated with a specified resource. A rescore execution plan
        /// is an example of a resource that can have tags associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceUnavailableException">
        /// The resource you want to use is unavailable. Please check you have provided the correct
        /// resource information and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonKendraRankingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from KendraRanking.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  Rescore


        /// <summary>
        /// Rescores or re-ranks search results from a search service such as OpenSearch (self
        /// managed). You use the semantic search capabilities of Amazon Kendra Intelligent Ranking
        /// to improve the search service's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Rescore service method.</param>
        /// 
        /// <returns>The response from the Rescore service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/Rescore">REST API Reference for Rescore Operation</seealso>
        RescoreResponse Rescore(RescoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Rescore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Rescore operation on AmazonKendraRankingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRescore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/Rescore">REST API Reference for Rescore Operation</seealso>
        IAsyncResult BeginRescore(RescoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Rescore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRescore.</param>
        /// 
        /// <returns>Returns a  RescoreResult from KendraRanking.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/Rescore">REST API Reference for Rescore Operation</seealso>
        RescoreResponse EndRescore(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a specified tag to a specified rescore execution plan. A rescore execution plan
        /// is an Amazon Kendra Intelligent Ranking resource used for provisioning the <code>Rescore</code>
        /// API. If the tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceUnavailableException">
        /// The resource you want to use is unavailable. Please check you have provided the correct
        /// resource information and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonKendraRankingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from KendraRanking.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a rescore execution plan. A rescore execution plan is an Amazon
        /// Kendra Intelligent Ranking resource used for provisioning the <code>Rescore</code>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceUnavailableException">
        /// The resource you want to use is unavailable. Please check you have provided the correct
        /// resource information and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonKendraRankingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from KendraRanking.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRescoreExecutionPlan


        /// <summary>
        /// Updates a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <code>Rescore</code> API. You can update
        /// the number of capacity units you require for Amazon Kendra Intelligent Ranking to
        /// rescore or re-rank a search service's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRescoreExecutionPlan service method.</param>
        /// 
        /// <returns>The response from the UpdateRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra Intelligent Ranking service.
        /// Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UpdateRescoreExecutionPlan">REST API Reference for UpdateRescoreExecutionPlan Operation</seealso>
        UpdateRescoreExecutionPlanResponse UpdateRescoreExecutionPlan(UpdateRescoreExecutionPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRescoreExecutionPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRescoreExecutionPlan operation on AmazonKendraRankingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRescoreExecutionPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UpdateRescoreExecutionPlan">REST API Reference for UpdateRescoreExecutionPlan Operation</seealso>
        IAsyncResult BeginUpdateRescoreExecutionPlan(UpdateRescoreExecutionPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRescoreExecutionPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRescoreExecutionPlan.</param>
        /// 
        /// <returns>Returns a  UpdateRescoreExecutionPlanResult from KendraRanking.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UpdateRescoreExecutionPlan">REST API Reference for UpdateRescoreExecutionPlan Operation</seealso>
        UpdateRescoreExecutionPlanResponse EndUpdateRescoreExecutionPlan(IAsyncResult asyncResult);

        #endregion
        
    }
}