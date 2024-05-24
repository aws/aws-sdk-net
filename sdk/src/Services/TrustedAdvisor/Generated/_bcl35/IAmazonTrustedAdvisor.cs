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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.TrustedAdvisor.Model;

#pragma warning disable CS1570
namespace Amazon.TrustedAdvisor
{
    /// <summary>
    /// <para>Interface for accessing TrustedAdvisor</para>
    ///
    /// TrustedAdvisor Public API
    /// </summary>
    public partial interface IAmazonTrustedAdvisor : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITrustedAdvisorPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchUpdateRecommendationResourceExclusion


        /// <summary>
        /// Update one or more exclusion status for a list of recommendation resources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRecommendationResourceExclusion service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateRecommendationResourceExclusion service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/BatchUpdateRecommendationResourceExclusion">REST API Reference for BatchUpdateRecommendationResourceExclusion Operation</seealso>
        BatchUpdateRecommendationResourceExclusionResponse BatchUpdateRecommendationResourceExclusion(BatchUpdateRecommendationResourceExclusionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateRecommendationResourceExclusion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRecommendationResourceExclusion operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateRecommendationResourceExclusion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/BatchUpdateRecommendationResourceExclusion">REST API Reference for BatchUpdateRecommendationResourceExclusion Operation</seealso>
        IAsyncResult BeginBatchUpdateRecommendationResourceExclusion(BatchUpdateRecommendationResourceExclusionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateRecommendationResourceExclusion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateRecommendationResourceExclusion.</param>
        /// 
        /// <returns>Returns a  BatchUpdateRecommendationResourceExclusionResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/BatchUpdateRecommendationResourceExclusion">REST API Reference for BatchUpdateRecommendationResourceExclusion Operation</seealso>
        BatchUpdateRecommendationResourceExclusionResponse EndBatchUpdateRecommendationResourceExclusion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOrganizationRecommendation


        /// <summary>
        /// Get a specific recommendation within an AWS Organizations organization. This API supports
        /// only prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetOrganizationRecommendation">REST API Reference for GetOrganizationRecommendation Operation</seealso>
        GetOrganizationRecommendationResponse GetOrganizationRecommendation(GetOrganizationRecommendationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrganizationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationRecommendation operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOrganizationRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetOrganizationRecommendation">REST API Reference for GetOrganizationRecommendation Operation</seealso>
        IAsyncResult BeginGetOrganizationRecommendation(GetOrganizationRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOrganizationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOrganizationRecommendation.</param>
        /// 
        /// <returns>Returns a  GetOrganizationRecommendationResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetOrganizationRecommendation">REST API Reference for GetOrganizationRecommendation Operation</seealso>
        GetOrganizationRecommendationResponse EndGetOrganizationRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecommendation


        /// <summary>
        /// Get a specific Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        GetRecommendationResponse GetRecommendation(GetRecommendationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        IAsyncResult BeginGetRecommendation(GetRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendation.</param>
        /// 
        /// <returns>Returns a  GetRecommendationResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        GetRecommendationResponse EndGetRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChecks


        /// <summary>
        /// List a filterable set of Checks
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChecks service method.</param>
        /// 
        /// <returns>The response from the ListChecks service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListChecks">REST API Reference for ListChecks Operation</seealso>
        ListChecksResponse ListChecks(ListChecksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChecks operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChecks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListChecks">REST API Reference for ListChecks Operation</seealso>
        IAsyncResult BeginListChecks(ListChecksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChecks.</param>
        /// 
        /// <returns>Returns a  ListChecksResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListChecks">REST API Reference for ListChecks Operation</seealso>
        ListChecksResponse EndListChecks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrganizationRecommendationAccounts


        /// <summary>
        /// Lists the accounts that own the resources for an organization aggregate recommendation.
        /// This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationAccounts service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationAccounts service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationAccounts">REST API Reference for ListOrganizationRecommendationAccounts Operation</seealso>
        ListOrganizationRecommendationAccountsResponse ListOrganizationRecommendationAccounts(ListOrganizationRecommendationAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationRecommendationAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationAccounts operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationRecommendationAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationAccounts">REST API Reference for ListOrganizationRecommendationAccounts Operation</seealso>
        IAsyncResult BeginListOrganizationRecommendationAccounts(ListOrganizationRecommendationAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationRecommendationAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationRecommendationAccounts.</param>
        /// 
        /// <returns>Returns a  ListOrganizationRecommendationAccountsResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationAccounts">REST API Reference for ListOrganizationRecommendationAccounts Operation</seealso>
        ListOrganizationRecommendationAccountsResponse EndListOrganizationRecommendationAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrganizationRecommendationResources


        /// <summary>
        /// List Resources of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationResources service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationResources">REST API Reference for ListOrganizationRecommendationResources Operation</seealso>
        ListOrganizationRecommendationResourcesResponse ListOrganizationRecommendationResources(ListOrganizationRecommendationResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationRecommendationResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationResources operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationRecommendationResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationResources">REST API Reference for ListOrganizationRecommendationResources Operation</seealso>
        IAsyncResult BeginListOrganizationRecommendationResources(ListOrganizationRecommendationResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationRecommendationResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationRecommendationResources.</param>
        /// 
        /// <returns>Returns a  ListOrganizationRecommendationResourcesResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationResources">REST API Reference for ListOrganizationRecommendationResources Operation</seealso>
        ListOrganizationRecommendationResourcesResponse EndListOrganizationRecommendationResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrganizationRecommendations


        /// <summary>
        /// List a filterable set of Recommendations within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendations">REST API Reference for ListOrganizationRecommendations Operation</seealso>
        ListOrganizationRecommendationsResponse ListOrganizationRecommendations(ListOrganizationRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendations operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendations">REST API Reference for ListOrganizationRecommendations Operation</seealso>
        IAsyncResult BeginListOrganizationRecommendations(ListOrganizationRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationRecommendations.</param>
        /// 
        /// <returns>Returns a  ListOrganizationRecommendationsResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendations">REST API Reference for ListOrganizationRecommendations Operation</seealso>
        ListOrganizationRecommendationsResponse EndListOrganizationRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecommendationResources


        /// <summary>
        /// List Resources of a Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationResources service method.</param>
        /// 
        /// <returns>The response from the ListRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendationResources">REST API Reference for ListRecommendationResources Operation</seealso>
        ListRecommendationResourcesResponse ListRecommendationResources(ListRecommendationResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendationResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationResources operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendationResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendationResources">REST API Reference for ListRecommendationResources Operation</seealso>
        IAsyncResult BeginListRecommendationResources(ListRecommendationResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendationResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendationResources.</param>
        /// 
        /// <returns>Returns a  ListRecommendationResourcesResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendationResources">REST API Reference for ListRecommendationResources Operation</seealso>
        ListRecommendationResourcesResponse EndListRecommendationResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecommendations


        /// <summary>
        /// List a filterable set of Recommendations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        IAsyncResult BeginListRecommendations(ListRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendations.</param>
        /// 
        /// <returns>Returns a  ListRecommendationsResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        ListRecommendationsResponse EndListRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOrganizationRecommendationLifecycle


        /// <summary>
        /// Update the lifecycle of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationRecommendationLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateOrganizationRecommendationLifecycle">REST API Reference for UpdateOrganizationRecommendationLifecycle Operation</seealso>
        UpdateOrganizationRecommendationLifecycleResponse UpdateOrganizationRecommendationLifecycle(UpdateOrganizationRecommendationLifecycleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOrganizationRecommendationLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationRecommendationLifecycle operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOrganizationRecommendationLifecycle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateOrganizationRecommendationLifecycle">REST API Reference for UpdateOrganizationRecommendationLifecycle Operation</seealso>
        IAsyncResult BeginUpdateOrganizationRecommendationLifecycle(UpdateOrganizationRecommendationLifecycleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOrganizationRecommendationLifecycle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOrganizationRecommendationLifecycle.</param>
        /// 
        /// <returns>Returns a  UpdateOrganizationRecommendationLifecycleResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateOrganizationRecommendationLifecycle">REST API Reference for UpdateOrganizationRecommendationLifecycle Operation</seealso>
        UpdateOrganizationRecommendationLifecycleResponse EndUpdateOrganizationRecommendationLifecycle(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRecommendationLifecycle


        /// <summary>
        /// Update the lifecyle of a Recommendation. This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendationLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateRecommendationLifecycle">REST API Reference for UpdateRecommendationLifecycle Operation</seealso>
        UpdateRecommendationLifecycleResponse UpdateRecommendationLifecycle(UpdateRecommendationLifecycleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecommendationLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendationLifecycle operation on AmazonTrustedAdvisorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecommendationLifecycle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateRecommendationLifecycle">REST API Reference for UpdateRecommendationLifecycle Operation</seealso>
        IAsyncResult BeginUpdateRecommendationLifecycle(UpdateRecommendationLifecycleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecommendationLifecycle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecommendationLifecycle.</param>
        /// 
        /// <returns>Returns a  UpdateRecommendationLifecycleResult from TrustedAdvisor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateRecommendationLifecycle">REST API Reference for UpdateRecommendationLifecycle Operation</seealso>
        UpdateRecommendationLifecycleResponse EndUpdateRecommendationLifecycle(IAsyncResult asyncResult);

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