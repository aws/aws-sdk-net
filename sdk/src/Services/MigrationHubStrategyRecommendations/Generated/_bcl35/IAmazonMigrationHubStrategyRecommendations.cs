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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MigrationHubStrategyRecommendations.Model;

namespace Amazon.MigrationHubStrategyRecommendations
{
    /// <summary>
    /// Interface for accessing MigrationHubStrategyRecommendations
    ///
    /// Migration Hub Strategy Recommendations 
    /// <para>
    /// This API reference provides descriptions, syntax, and other details about each of
    /// the actions and data types for Migration Hub Strategy Recommendations (Strategy Recommendations).
    /// The topic for each action shows the API request parameters and the response. Alternatively,
    /// you can use one of the AWS SDKs to access an API that is tailored to the programming
    /// language or platform that you're using. For more information, see <a href="http://aws.amazon.com/tools/#SDKs">AWS
    /// SDKs</a>.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonMigrationHubStrategyRecommendations : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMigrationHubStrategyRecommendationsPaginatorFactory Paginators { get; }
#endif


        
        #region  GetApplicationComponentDetails


        /// <summary>
        /// Retrieves details about an application component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentDetails service method.</param>
        /// 
        /// <returns>The response from the GetApplicationComponentDetails service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentDetails">REST API Reference for GetApplicationComponentDetails Operation</seealso>
        GetApplicationComponentDetailsResponse GetApplicationComponentDetails(GetApplicationComponentDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationComponentDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentDetails operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationComponentDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentDetails">REST API Reference for GetApplicationComponentDetails Operation</seealso>
        IAsyncResult BeginGetApplicationComponentDetails(GetApplicationComponentDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationComponentDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationComponentDetails.</param>
        /// 
        /// <returns>Returns a  GetApplicationComponentDetailsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentDetails">REST API Reference for GetApplicationComponentDetails Operation</seealso>
        GetApplicationComponentDetailsResponse EndGetApplicationComponentDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplicationComponentStrategies


        /// <summary>
        /// Retrieves a list of all the recommended strategies and tools for an application component
        /// running on a server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentStrategies service method.</param>
        /// 
        /// <returns>The response from the GetApplicationComponentStrategies service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentStrategies">REST API Reference for GetApplicationComponentStrategies Operation</seealso>
        GetApplicationComponentStrategiesResponse GetApplicationComponentStrategies(GetApplicationComponentStrategiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationComponentStrategies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentStrategies operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationComponentStrategies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentStrategies">REST API Reference for GetApplicationComponentStrategies Operation</seealso>
        IAsyncResult BeginGetApplicationComponentStrategies(GetApplicationComponentStrategiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationComponentStrategies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationComponentStrategies.</param>
        /// 
        /// <returns>Returns a  GetApplicationComponentStrategiesResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetApplicationComponentStrategies">REST API Reference for GetApplicationComponentStrategies Operation</seealso>
        GetApplicationComponentStrategiesResponse EndGetApplicationComponentStrategies(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssessment


        /// <summary>
        /// Retrieves the status of an on-going assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// 
        /// <returns>The response from the GetAssessment service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        GetAssessmentResponse GetAssessment(GetAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        IAsyncResult BeginGetAssessment(GetAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessment.</param>
        /// 
        /// <returns>Returns a  GetAssessmentResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        GetAssessmentResponse EndGetAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetImportFileTask


        /// <summary>
        /// Retrieves the details about a specific import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportFileTask service method.</param>
        /// 
        /// <returns>The response from the GetImportFileTask service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetImportFileTask">REST API Reference for GetImportFileTask Operation</seealso>
        GetImportFileTaskResponse GetImportFileTask(GetImportFileTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportFileTask operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportFileTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetImportFileTask">REST API Reference for GetImportFileTask Operation</seealso>
        IAsyncResult BeginGetImportFileTask(GetImportFileTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportFileTask.</param>
        /// 
        /// <returns>Returns a  GetImportFileTaskResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetImportFileTask">REST API Reference for GetImportFileTask Operation</seealso>
        GetImportFileTaskResponse EndGetImportFileTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLatestAssessmentId


        /// <summary>
        /// Retrieve the latest ID of a specific assessment task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLatestAssessmentId service method.</param>
        /// 
        /// <returns>The response from the GetLatestAssessmentId service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.DependencyException">
        /// Dependency encountered an error.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetLatestAssessmentId">REST API Reference for GetLatestAssessmentId Operation</seealso>
        GetLatestAssessmentIdResponse GetLatestAssessmentId(GetLatestAssessmentIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLatestAssessmentId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLatestAssessmentId operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLatestAssessmentId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetLatestAssessmentId">REST API Reference for GetLatestAssessmentId Operation</seealso>
        IAsyncResult BeginGetLatestAssessmentId(GetLatestAssessmentIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLatestAssessmentId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLatestAssessmentId.</param>
        /// 
        /// <returns>Returns a  GetLatestAssessmentIdResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetLatestAssessmentId">REST API Reference for GetLatestAssessmentId Operation</seealso>
        GetLatestAssessmentIdResponse EndGetLatestAssessmentId(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPortfolioPreferences


        /// <summary>
        /// Retrieves your migration and modernization preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioPreferences service method.</param>
        /// 
        /// <returns>The response from the GetPortfolioPreferences service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioPreferences">REST API Reference for GetPortfolioPreferences Operation</seealso>
        GetPortfolioPreferencesResponse GetPortfolioPreferences(GetPortfolioPreferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortfolioPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioPreferences operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortfolioPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioPreferences">REST API Reference for GetPortfolioPreferences Operation</seealso>
        IAsyncResult BeginGetPortfolioPreferences(GetPortfolioPreferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortfolioPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortfolioPreferences.</param>
        /// 
        /// <returns>Returns a  GetPortfolioPreferencesResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioPreferences">REST API Reference for GetPortfolioPreferences Operation</seealso>
        GetPortfolioPreferencesResponse EndGetPortfolioPreferences(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPortfolioSummary


        /// <summary>
        /// Retrieves overall summary including the number of servers to rehost and the overall
        /// number of anti-patterns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioSummary service method.</param>
        /// 
        /// <returns>The response from the GetPortfolioSummary service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioSummary">REST API Reference for GetPortfolioSummary Operation</seealso>
        GetPortfolioSummaryResponse GetPortfolioSummary(GetPortfolioSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPortfolioSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioSummary operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPortfolioSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioSummary">REST API Reference for GetPortfolioSummary Operation</seealso>
        IAsyncResult BeginGetPortfolioSummary(GetPortfolioSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPortfolioSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPortfolioSummary.</param>
        /// 
        /// <returns>Returns a  GetPortfolioSummaryResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetPortfolioSummary">REST API Reference for GetPortfolioSummary Operation</seealso>
        GetPortfolioSummaryResponse EndGetPortfolioSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecommendationReportDetails


        /// <summary>
        /// Retrieves detailed information about the specified recommendation report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationReportDetails service method.</param>
        /// 
        /// <returns>The response from the GetRecommendationReportDetails service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetRecommendationReportDetails">REST API Reference for GetRecommendationReportDetails Operation</seealso>
        GetRecommendationReportDetailsResponse GetRecommendationReportDetails(GetRecommendationReportDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendationReportDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationReportDetails operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendationReportDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetRecommendationReportDetails">REST API Reference for GetRecommendationReportDetails Operation</seealso>
        IAsyncResult BeginGetRecommendationReportDetails(GetRecommendationReportDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendationReportDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendationReportDetails.</param>
        /// 
        /// <returns>Returns a  GetRecommendationReportDetailsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetRecommendationReportDetails">REST API Reference for GetRecommendationReportDetails Operation</seealso>
        GetRecommendationReportDetailsResponse EndGetRecommendationReportDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServerDetails


        /// <summary>
        /// Retrieves detailed information about a specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerDetails service method.</param>
        /// 
        /// <returns>The response from the GetServerDetails service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerDetails">REST API Reference for GetServerDetails Operation</seealso>
        GetServerDetailsResponse GetServerDetails(GetServerDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerDetails operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServerDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerDetails">REST API Reference for GetServerDetails Operation</seealso>
        IAsyncResult BeginGetServerDetails(GetServerDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServerDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerDetails.</param>
        /// 
        /// <returns>Returns a  GetServerDetailsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerDetails">REST API Reference for GetServerDetails Operation</seealso>
        GetServerDetailsResponse EndGetServerDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServerStrategies


        /// <summary>
        /// Retrieves recommended strategies and tools for the specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerStrategies service method.</param>
        /// 
        /// <returns>The response from the GetServerStrategies service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerStrategies">REST API Reference for GetServerStrategies Operation</seealso>
        GetServerStrategiesResponse GetServerStrategies(GetServerStrategiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerStrategies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerStrategies operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServerStrategies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerStrategies">REST API Reference for GetServerStrategies Operation</seealso>
        IAsyncResult BeginGetServerStrategies(GetServerStrategiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServerStrategies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerStrategies.</param>
        /// 
        /// <returns>Returns a  GetServerStrategiesResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/GetServerStrategies">REST API Reference for GetServerStrategies Operation</seealso>
        GetServerStrategiesResponse EndGetServerStrategies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationComponents


        /// <summary>
        /// Retrieves a list of all the application components (processes).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationComponents service method.</param>
        /// 
        /// <returns>The response from the ListApplicationComponents service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ServiceLinkedRoleLockClientException">
        /// Exception to indicate that the service-linked role (SLR) is locked.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListApplicationComponents">REST API Reference for ListApplicationComponents Operation</seealso>
        ListApplicationComponentsResponse ListApplicationComponents(ListApplicationComponentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationComponents operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListApplicationComponents">REST API Reference for ListApplicationComponents Operation</seealso>
        IAsyncResult BeginListApplicationComponents(ListApplicationComponentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationComponents.</param>
        /// 
        /// <returns>Returns a  ListApplicationComponentsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListApplicationComponents">REST API Reference for ListApplicationComponents Operation</seealso>
        ListApplicationComponentsResponse EndListApplicationComponents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCollectors


        /// <summary>
        /// Retrieves a list of all the installed collectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors service method.</param>
        /// 
        /// <returns>The response from the ListCollectors service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        ListCollectorsResponse ListCollectors(ListCollectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        IAsyncResult BeginListCollectors(ListCollectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollectors.</param>
        /// 
        /// <returns>Returns a  ListCollectorsResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListCollectors">REST API Reference for ListCollectors Operation</seealso>
        ListCollectorsResponse EndListCollectors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImportFileTask


        /// <summary>
        /// Retrieves a list of all the imports performed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportFileTask service method.</param>
        /// 
        /// <returns>The response from the ListImportFileTask service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListImportFileTask">REST API Reference for ListImportFileTask Operation</seealso>
        ListImportFileTaskResponse ListImportFileTask(ListImportFileTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImportFileTask operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImportFileTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListImportFileTask">REST API Reference for ListImportFileTask Operation</seealso>
        IAsyncResult BeginListImportFileTask(ListImportFileTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImportFileTask.</param>
        /// 
        /// <returns>Returns a  ListImportFileTaskResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListImportFileTask">REST API Reference for ListImportFileTask Operation</seealso>
        ListImportFileTaskResponse EndListImportFileTask(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServers


        /// <summary>
        /// Returns a list of all the servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServers service method.</param>
        /// 
        /// <returns>The response from the ListServers service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListServers">REST API Reference for ListServers Operation</seealso>
        ListServersResponse ListServers(ListServersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServers operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListServers">REST API Reference for ListServers Operation</seealso>
        IAsyncResult BeginListServers(ListServersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServers.</param>
        /// 
        /// <returns>Returns a  ListServersResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListServers">REST API Reference for ListServers Operation</seealso>
        ListServersResponse EndListServers(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPortfolioPreferences


        /// <summary>
        /// Saves the specified migration and modernization preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPortfolioPreferences service method.</param>
        /// 
        /// <returns>The response from the PutPortfolioPreferences service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ConflictException">
        /// Exception to indicate that there is an ongoing task when a new task is created. Return
        /// when once the existing tasks are complete.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/PutPortfolioPreferences">REST API Reference for PutPortfolioPreferences Operation</seealso>
        PutPortfolioPreferencesResponse PutPortfolioPreferences(PutPortfolioPreferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPortfolioPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPortfolioPreferences operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPortfolioPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/PutPortfolioPreferences">REST API Reference for PutPortfolioPreferences Operation</seealso>
        IAsyncResult BeginPutPortfolioPreferences(PutPortfolioPreferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPortfolioPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPortfolioPreferences.</param>
        /// 
        /// <returns>Returns a  PutPortfolioPreferencesResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/PutPortfolioPreferences">REST API Reference for PutPortfolioPreferences Operation</seealso>
        PutPortfolioPreferencesResponse EndPutPortfolioPreferences(IAsyncResult asyncResult);

        #endregion
        
        #region  StartAssessment


        /// <summary>
        /// Starts the assessment of an on-premises environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessment service method.</param>
        /// 
        /// <returns>The response from the StartAssessment service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ServiceQuotaExceededException">
        /// The AWS account has reached its quota of imports. Contact AWS Support to increase
        /// the quota for this account.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartAssessment">REST API Reference for StartAssessment Operation</seealso>
        StartAssessmentResponse StartAssessment(StartAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssessment operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartAssessment">REST API Reference for StartAssessment Operation</seealso>
        IAsyncResult BeginStartAssessment(StartAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAssessment.</param>
        /// 
        /// <returns>Returns a  StartAssessmentResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartAssessment">REST API Reference for StartAssessment Operation</seealso>
        StartAssessmentResponse EndStartAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  StartImportFileTask


        /// <summary>
        /// Starts a file import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportFileTask service method.</param>
        /// 
        /// <returns>The response from the StartImportFileTask service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ServiceQuotaExceededException">
        /// The AWS account has reached its quota of imports. Contact AWS Support to increase
        /// the quota for this account.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartImportFileTask">REST API Reference for StartImportFileTask Operation</seealso>
        StartImportFileTaskResponse StartImportFileTask(StartImportFileTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImportFileTask operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImportFileTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartImportFileTask">REST API Reference for StartImportFileTask Operation</seealso>
        IAsyncResult BeginStartImportFileTask(StartImportFileTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartImportFileTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImportFileTask.</param>
        /// 
        /// <returns>Returns a  StartImportFileTaskResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartImportFileTask">REST API Reference for StartImportFileTask Operation</seealso>
        StartImportFileTaskResponse EndStartImportFileTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StartRecommendationReportGeneration


        /// <summary>
        /// Starts generating a recommendation report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommendationReportGeneration service method.</param>
        /// 
        /// <returns>The response from the StartRecommendationReportGeneration service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ConflictException">
        /// Exception to indicate that there is an ongoing task when a new task is created. Return
        /// when once the existing tasks are complete.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartRecommendationReportGeneration">REST API Reference for StartRecommendationReportGeneration Operation</seealso>
        StartRecommendationReportGenerationResponse StartRecommendationReportGeneration(StartRecommendationReportGenerationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartRecommendationReportGeneration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRecommendationReportGeneration operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRecommendationReportGeneration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartRecommendationReportGeneration">REST API Reference for StartRecommendationReportGeneration Operation</seealso>
        IAsyncResult BeginStartRecommendationReportGeneration(StartRecommendationReportGenerationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartRecommendationReportGeneration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRecommendationReportGeneration.</param>
        /// 
        /// <returns>Returns a  StartRecommendationReportGenerationResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StartRecommendationReportGeneration">REST API Reference for StartRecommendationReportGeneration Operation</seealso>
        StartRecommendationReportGenerationResponse EndStartRecommendationReportGeneration(IAsyncResult asyncResult);

        #endregion
        
        #region  StopAssessment


        /// <summary>
        /// Stops the assessment of an on-premises environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAssessment service method.</param>
        /// 
        /// <returns>The response from the StopAssessment service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.AccessDeniedException">
        /// The user does not have permission to perform the action. Check the AWS Identity and
        /// Access Management (IAM) policy associated with this user.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StopAssessment">REST API Reference for StopAssessment Operation</seealso>
        StopAssessmentResponse StopAssessment(StopAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAssessment operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StopAssessment">REST API Reference for StopAssessment Operation</seealso>
        IAsyncResult BeginStopAssessment(StopAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAssessment.</param>
        /// 
        /// <returns>Returns a  StopAssessmentResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/StopAssessment">REST API Reference for StopAssessment Operation</seealso>
        StopAssessmentResponse EndStopAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplicationComponentConfig


        /// <summary>
        /// Updates the configuration of an application component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationComponentConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationComponentConfig service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateApplicationComponentConfig">REST API Reference for UpdateApplicationComponentConfig Operation</seealso>
        UpdateApplicationComponentConfigResponse UpdateApplicationComponentConfig(UpdateApplicationComponentConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationComponentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationComponentConfig operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationComponentConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateApplicationComponentConfig">REST API Reference for UpdateApplicationComponentConfig Operation</seealso>
        IAsyncResult BeginUpdateApplicationComponentConfig(UpdateApplicationComponentConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationComponentConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationComponentConfig.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationComponentConfigResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateApplicationComponentConfig">REST API Reference for UpdateApplicationComponentConfig Operation</seealso>
        UpdateApplicationComponentConfigResponse EndUpdateApplicationComponentConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServerConfig


        /// <summary>
        /// Updates the configuration of the specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateServerConfig service method, as returned by MigrationHubStrategyRecommendations.</returns>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.InternalServerException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ResourceNotFoundException">
        /// The specified ID in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubStrategyRecommendations.Model.ValidationException">
        /// The request body isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateServerConfig">REST API Reference for UpdateServerConfig Operation</seealso>
        UpdateServerConfigResponse UpdateServerConfig(UpdateServerConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerConfig operation on AmazonMigrationHubStrategyRecommendationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServerConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateServerConfig">REST API Reference for UpdateServerConfig Operation</seealso>
        IAsyncResult BeginUpdateServerConfig(UpdateServerConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServerConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServerConfig.</param>
        /// 
        /// <returns>Returns a  UpdateServerConfigResult from MigrationHubStrategyRecommendations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/UpdateServerConfig">REST API Reference for UpdateServerConfig Operation</seealso>
        UpdateServerConfigResponse EndUpdateServerConfig(IAsyncResult asyncResult);

        #endregion
        
    }
}