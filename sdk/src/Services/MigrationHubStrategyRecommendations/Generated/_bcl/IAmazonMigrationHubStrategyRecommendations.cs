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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MigrationHubStrategyRecommendations.Model;

#pragma warning disable CS1570
namespace Amazon.MigrationHubStrategyRecommendations
{
    /// <summary>
    /// <para>Interface for accessing MigrationHubStrategyRecommendations</para>
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMigrationHubStrategyRecommendationsPaginatorFactory Paginators { get; }

        
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
        /// Retrieves details about an application component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetApplicationComponentDetailsResponse> GetApplicationComponentDetailsAsync(GetApplicationComponentDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of all the recommended strategies and tools for an application component
        /// running on a server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationComponentStrategies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetApplicationComponentStrategiesResponse> GetApplicationComponentStrategiesAsync(GetApplicationComponentStrategiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves the status of an on-going assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAssessmentResponse> GetAssessmentAsync(GetAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves the details about a specific import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportFileTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetImportFileTaskResponse> GetImportFileTaskAsync(GetImportFileTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieve the latest ID of a specific assessment task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLatestAssessmentId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetLatestAssessmentIdResponse> GetLatestAssessmentIdAsync(GetLatestAssessmentIdRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves your migration and modernization preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetPortfolioPreferencesResponse> GetPortfolioPreferencesAsync(GetPortfolioPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves overall summary including the number of servers to rehost and the overall
        /// number of anti-patterns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortfolioSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetPortfolioSummaryResponse> GetPortfolioSummaryAsync(GetPortfolioSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves detailed information about the specified recommendation report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationReportDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRecommendationReportDetailsResponse> GetRecommendationReportDetailsAsync(GetRecommendationReportDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves detailed information about a specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetServerDetailsResponse> GetServerDetailsAsync(GetServerDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves recommended strategies and tools for the specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerStrategies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetServerStrategiesResponse> GetServerStrategiesAsync(GetServerStrategiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAnalyzableServers


        /// <summary>
        /// Retrieves a list of all the servers fetched from customer vCenter using Strategy Recommendation
        /// Collector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzableServers service method.</param>
        /// 
        /// <returns>The response from the ListAnalyzableServers service method, as returned by MigrationHubStrategyRecommendations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListAnalyzableServers">REST API Reference for ListAnalyzableServers Operation</seealso>
        ListAnalyzableServersResponse ListAnalyzableServers(ListAnalyzableServersRequest request);



        /// <summary>
        /// Retrieves a list of all the servers fetched from customer vCenter using Strategy Recommendation
        /// Collector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzableServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnalyzableServers service method, as returned by MigrationHubStrategyRecommendations.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhubstrategy-2020-02-19/ListAnalyzableServers">REST API Reference for ListAnalyzableServers Operation</seealso>
        Task<ListAnalyzableServersResponse> ListAnalyzableServersAsync(ListAnalyzableServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of all the application components (processes).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListApplicationComponentsResponse> ListApplicationComponentsAsync(ListApplicationComponentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of all the installed collectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCollectorsResponse> ListCollectorsAsync(ListCollectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of all the imports performed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportFileTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListImportFileTaskResponse> ListImportFileTaskAsync(ListImportFileTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of all the servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListServersResponse> ListServersAsync(ListServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Saves the specified migration and modernization preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPortfolioPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutPortfolioPreferencesResponse> PutPortfolioPreferencesAsync(PutPortfolioPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts the assessment of an on-premises environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartAssessmentResponse> StartAssessmentAsync(StartAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts a file import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportFileTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartImportFileTaskResponse> StartImportFileTaskAsync(StartImportFileTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts generating a recommendation report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommendationReportGeneration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartRecommendationReportGenerationResponse> StartRecommendationReportGenerationAsync(StartRecommendationReportGenerationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Stops the assessment of an on-premises environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopAssessmentResponse> StopAssessmentAsync(StopAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the configuration of an application component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationComponentConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateApplicationComponentConfigResponse> UpdateApplicationComponentConfigAsync(UpdateApplicationComponentConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the configuration of the specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateServerConfigResponse> UpdateServerConfigAsync(UpdateServerConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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