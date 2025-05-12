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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeBuild.Model;

#pragma warning disable CS1570
namespace Amazon.CodeBuild
{
    /// <summary>
    /// <para>Interface for accessing CodeBuild</para>
    ///
    /// CodeBuild 
    /// <para>
    /// CodeBuild is a fully managed build service in the cloud. CodeBuild compiles your source
    /// code, runs unit tests, and produces artifacts that are ready to deploy. CodeBuild
    /// eliminates the need to provision, manage, and scale your own build servers. It provides
    /// prepackaged build environments for the most popular programming languages and build
    /// tools, such as Apache Maven, Gradle, and more. You can also fully customize build
    /// environments in CodeBuild to use your own build tools. CodeBuild scales automatically
    /// to meet peak build requests. You pay only for the build time you consume. For more
    /// information about CodeBuild, see the <i> <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/welcome.html">CodeBuild
    /// User Guide</a>.</i> 
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeBuild : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeBuildPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchDeleteBuilds



        /// <summary>
        /// Deletes one or more builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBuilds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        Task<BatchDeleteBuildsResponse> BatchDeleteBuildsAsync(BatchDeleteBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetBuildBatches



        /// <summary>
        /// Retrieves information about one or more batch builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuildBatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuildBatches">REST API Reference for BatchGetBuildBatches Operation</seealso>
        Task<BatchGetBuildBatchesResponse> BatchGetBuildBatchesAsync(BatchGetBuildBatchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetBuilds



        /// <summary>
        /// Gets information about one or more builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuilds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        Task<BatchGetBuildsResponse> BatchGetBuildsAsync(BatchGetBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetCommandExecutions



        /// <summary>
        /// Gets information about the command executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCommandExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCommandExecutions service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetCommandExecutions">REST API Reference for BatchGetCommandExecutions Operation</seealso>
        Task<BatchGetCommandExecutionsResponse> BatchGetCommandExecutionsAsync(BatchGetCommandExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetFleets



        /// <summary>
        /// Gets information about one or more compute fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetFleets service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetFleets">REST API Reference for BatchGetFleets Operation</seealso>
        Task<BatchGetFleetsResponse> BatchGetFleetsAsync(BatchGetFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetProjects



        /// <summary>
        /// Gets information about one or more build projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        Task<BatchGetProjectsResponse> BatchGetProjectsAsync(BatchGetProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetReportGroups



        /// <summary>
        /// Returns an array of report groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReportGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReportGroups">REST API Reference for BatchGetReportGroups Operation</seealso>
        Task<BatchGetReportGroupsResponse> BatchGetReportGroupsAsync(BatchGetReportGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetReports



        /// <summary>
        /// Returns an array of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReports">REST API Reference for BatchGetReports Operation</seealso>
        Task<BatchGetReportsResponse> BatchGetReportsAsync(BatchGetReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetSandboxes



        /// <summary>
        /// Gets information about the sandbox status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSandboxes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetSandboxes service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetSandboxes">REST API Reference for BatchGetSandboxes Operation</seealso>
        Task<BatchGetSandboxesResponse> BatchGetSandboxesAsync(BatchGetSandboxesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFleet



        /// <summary>
        /// Creates a compute fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An Amazon Web Services service limit was exceeded for the calling Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified Amazon Web Services resource cannot be created, because an Amazon Web
        /// Services resource with the same settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProject



        /// <summary>
        /// Creates a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An Amazon Web Services service limit was exceeded for the calling Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified Amazon Web Services resource cannot be created, because an Amazon Web
        /// Services resource with the same settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReportGroup



        /// <summary>
        /// Creates a report group. A report group contains a collection of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReportGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An Amazon Web Services service limit was exceeded for the calling Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified Amazon Web Services resource cannot be created, because an Amazon Web
        /// Services resource with the same settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateReportGroup">REST API Reference for CreateReportGroup Operation</seealso>
        Task<CreateReportGroupResponse> CreateReportGroupAsync(CreateReportGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWebhook



        /// <summary>
        /// For an existing CodeBuild build project that has its source code stored in a GitHub
        /// or Bitbucket repository, enables CodeBuild to start rebuilding the source code every
        /// time a code change is pushed to the repository.
        /// 
        ///  <important> 
        /// <para>
        /// If you enable webhooks for an CodeBuild project, and the project is used as a build
        /// step in CodePipeline, then two identical builds are created for each commit. One build
        /// is triggered through webhooks, and one through CodePipeline. Because billing is on
        /// a per-build basis, you are billed for both builds. Therefore, if you are using CodePipeline,
        /// we recommend that you disable webhooks in CodeBuild. In the CodeBuild console, clear
        /// the Webhook box. For more information, see step 5 in <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/change-project.html#change-project-console">Change
        /// a Build Project's Settings</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified Amazon Web Services resource cannot be created, because an Amazon Web
        /// Services resource with the same settings already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        Task<CreateWebhookResponse> CreateWebhookAsync(CreateWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBuildBatch



        /// <summary>
        /// Deletes a batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuildBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteBuildBatch">REST API Reference for DeleteBuildBatch Operation</seealso>
        Task<DeleteBuildBatchResponse> DeleteBuildBatchAsync(DeleteBuildBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFleet



        /// <summary>
        /// Deletes a compute fleet. When you delete a compute fleet, its builds are not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProject



        /// <summary>
        /// Deletes a build project. When you delete a project, its builds are not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReport



        /// <summary>
        /// Deletes a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReport service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReport">REST API Reference for DeleteReport Operation</seealso>
        Task<DeleteReportResponse> DeleteReportAsync(DeleteReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReportGroup



        /// <summary>
        /// Deletes a report group. Before you delete a report group, you must delete its reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReportGroup">REST API Reference for DeleteReportGroup Operation</seealso>
        Task<DeleteReportGroupResponse> DeleteReportGroupAsync(DeleteReportGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResourcePolicy



        /// <summary>
        /// Deletes a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSourceCredentials



        /// <summary>
        /// Deletes a set of GitHub, GitHub Enterprise, or Bitbucket source credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        Task<DeleteSourceCredentialsResponse> DeleteSourceCredentialsAsync(DeleteSourceCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWebhook



        /// <summary>
        /// For an existing CodeBuild build project that has its source code stored in a GitHub
        /// or Bitbucket repository, stops CodeBuild from rebuilding the source code every time
        /// a code change is pushed to the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        Task<DeleteWebhookResponse> DeleteWebhookAsync(DeleteWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCodeCoverages



        /// <summary>
        /// Retrieves one or more code coverage reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeCoverages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCodeCoverages service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeCodeCoverages">REST API Reference for DescribeCodeCoverages Operation</seealso>
        Task<DescribeCodeCoveragesResponse> DescribeCodeCoveragesAsync(DescribeCodeCoveragesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTestCases



        /// <summary>
        /// Returns a list of details about test cases for a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTestCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTestCases service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeTestCases">REST API Reference for DescribeTestCases Operation</seealso>
        Task<DescribeTestCasesResponse> DescribeTestCasesAsync(DescribeTestCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReportGroupTrend



        /// <summary>
        /// Analyzes and accumulates test report values for the specified test reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportGroupTrend service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReportGroupTrend service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetReportGroupTrend">REST API Reference for GetReportGroupTrend Operation</seealso>
        Task<GetReportGroupTrendResponse> GetReportGroupTrendAsync(GetReportGroupTrendRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourcePolicy



        /// <summary>
        /// Gets a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportSourceCredentials



        /// <summary>
        /// Imports the source repository credentials for an CodeBuild project that has its source
        /// code stored in a GitHub, GitHub Enterprise, GitLab, GitLab Self Managed, or Bitbucket
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSourceCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An Amazon Web Services service limit was exceeded for the calling Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified Amazon Web Services resource cannot be created, because an Amazon Web
        /// Services resource with the same settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ImportSourceCredentials">REST API Reference for ImportSourceCredentials Operation</seealso>
        Task<ImportSourceCredentialsResponse> ImportSourceCredentialsAsync(ImportSourceCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InvalidateProjectCache



        /// <summary>
        /// Resets the cache for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvalidateProjectCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvalidateProjectCache service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        Task<InvalidateProjectCacheResponse> InvalidateProjectCacheAsync(InvalidateProjectCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBuildBatches



        /// <summary>
        /// Retrieves the identifiers of your build batches in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatches">REST API Reference for ListBuildBatches Operation</seealso>
        Task<ListBuildBatchesResponse> ListBuildBatchesAsync(ListBuildBatchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBuildBatchesForProject



        /// <summary>
        /// Retrieves the identifiers of the build batches for a specific project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatchesForProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuildBatchesForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatchesForProject">REST API Reference for ListBuildBatchesForProject Operation</seealso>
        Task<ListBuildBatchesForProjectResponse> ListBuildBatchesForProjectAsync(ListBuildBatchesForProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBuilds



        /// <summary>
        /// Gets a list of build IDs, with each build ID representing a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBuildsForProject



        /// <summary>
        /// Gets a list of build identifiers for the specified build project, with each build
        /// identifier representing a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildsForProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuildsForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        Task<ListBuildsForProjectResponse> ListBuildsForProjectAsync(ListBuildsForProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCommandExecutionsForSandbox



        /// <summary>
        /// Gets a list of command executions for a sandbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommandExecutionsForSandbox service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommandExecutionsForSandbox service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCommandExecutionsForSandbox">REST API Reference for ListCommandExecutionsForSandbox Operation</seealso>
        Task<ListCommandExecutionsForSandboxResponse> ListCommandExecutionsForSandboxAsync(ListCommandExecutionsForSandboxRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCuratedEnvironmentImages



        /// <summary>
        /// Gets information about Docker images that are managed by CodeBuild.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCuratedEnvironmentImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCuratedEnvironmentImages service method, as returned by CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        Task<ListCuratedEnvironmentImagesResponse> ListCuratedEnvironmentImagesAsync(ListCuratedEnvironmentImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFleets



        /// <summary>
        /// Gets a list of compute fleet names with each compute fleet name representing a single
        /// compute fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListFleets">REST API Reference for ListFleets Operation</seealso>
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects



        /// <summary>
        /// Gets a list of build project names, with each build project name representing a single
        /// build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReportGroups



        /// <summary>
        /// Gets a list ARNs for the report groups in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportGroups">REST API Reference for ListReportGroups Operation</seealso>
        Task<ListReportGroupsResponse> ListReportGroupsAsync(ListReportGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReports



        /// <summary>
        /// Returns a list of ARNs for the reports in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReports">REST API Reference for ListReports Operation</seealso>
        Task<ListReportsResponse> ListReportsAsync(ListReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReportsForReportGroup



        /// <summary>
        /// Returns a list of ARNs for the reports that belong to a <c>ReportGroup</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportsForReportGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReportsForReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportsForReportGroup">REST API Reference for ListReportsForReportGroup Operation</seealso>
        Task<ListReportsForReportGroupResponse> ListReportsForReportGroupAsync(ListReportsForReportGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSandboxes



        /// <summary>
        /// Gets a list of sandboxes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSandboxes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSandboxes service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSandboxes">REST API Reference for ListSandboxes Operation</seealso>
        Task<ListSandboxesResponse> ListSandboxesAsync(ListSandboxesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSandboxesForProject



        /// <summary>
        /// Gets a list of sandboxes for a given project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSandboxesForProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSandboxesForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSandboxesForProject">REST API Reference for ListSandboxesForProject Operation</seealso>
        Task<ListSandboxesForProjectResponse> ListSandboxesForProjectAsync(ListSandboxesForProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSharedProjects



        /// <summary>
        /// Gets a list of projects that are shared with other Amazon Web Services accounts or
        /// users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSharedProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedProjects">REST API Reference for ListSharedProjects Operation</seealso>
        Task<ListSharedProjectsResponse> ListSharedProjectsAsync(ListSharedProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSharedReportGroups



        /// <summary>
        /// Gets a list of report groups that are shared with other Amazon Web Services accounts
        /// or users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedReportGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSharedReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedReportGroups">REST API Reference for ListSharedReportGroups Operation</seealso>
        Task<ListSharedReportGroupsResponse> ListSharedReportGroupsAsync(ListSharedReportGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSourceCredentials



        /// <summary>
        /// Returns a list of <c>SourceCredentialsInfo</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        Task<ListSourceCredentialsResponse> ListSourceCredentialsAsync(ListSourceCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutResourcePolicy



        /// <summary>
        /// Stores a resource policy for the ARN of a <c>Project</c> or <c>ReportGroup</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetryBuild



        /// <summary>
        /// Restarts a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An Amazon Web Services service limit was exceeded for the calling Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuild">REST API Reference for RetryBuild Operation</seealso>
        Task<RetryBuildResponse> RetryBuildAsync(RetryBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetryBuildBatch



        /// <summary>
        /// Restarts a failed batch build. Only batch builds that have failed can be retried.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuildBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuildBatch">REST API Reference for RetryBuildBatch Operation</seealso>
        Task<RetryBuildBatchResponse> RetryBuildBatchAsync(RetryBuildBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartBuild



        /// <summary>
        /// Starts running a build with the settings defined in the project. These setting include:
        /// how to run a build, where to get the source code, which build environment to use,
        /// which build commands to run, and where to store the build output.
        /// 
        ///  
        /// <para>
        /// You can also start a build run by overriding some of the build settings in the project.
        /// The overrides only apply for that specific start build request. The settings in the
        /// project are unaltered.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An Amazon Web Services service limit was exceeded for the calling Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        Task<StartBuildResponse> StartBuildAsync(StartBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartBuildBatch



        /// <summary>
        /// Starts a batch build for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBuildBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuildBatch">REST API Reference for StartBuildBatch Operation</seealso>
        Task<StartBuildBatchResponse> StartBuildBatchAsync(StartBuildBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartCommandExecution



        /// <summary>
        /// Starts a command execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCommandExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCommandExecution service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartCommandExecution">REST API Reference for StartCommandExecution Operation</seealso>
        Task<StartCommandExecutionResponse> StartCommandExecutionAsync(StartCommandExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSandbox



        /// <summary>
        /// Starts a sandbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSandbox service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSandbox service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountSuspendedException">
        /// The CodeBuild access has been suspended for the calling Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartSandbox">REST API Reference for StartSandbox Operation</seealso>
        Task<StartSandboxResponse> StartSandboxAsync(StartSandboxRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSandboxConnection



        /// <summary>
        /// Starts a sandbox connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSandboxConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSandboxConnection service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartSandboxConnection">REST API Reference for StartSandboxConnection Operation</seealso>
        Task<StartSandboxConnectionResponse> StartSandboxConnectionAsync(StartSandboxConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopBuild



        /// <summary>
        /// Attempts to stop running a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        Task<StopBuildResponse> StopBuildAsync(StopBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopBuildBatch



        /// <summary>
        /// Stops a running batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuildBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuildBatch">REST API Reference for StopBuildBatch Operation</seealso>
        Task<StopBuildBatchResponse> StopBuildBatchAsync(StopBuildBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopSandbox



        /// <summary>
        /// Stops a sandbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSandbox service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopSandbox service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopSandbox">REST API Reference for StopSandbox Operation</seealso>
        Task<StopSandboxResponse> StopSandboxAsync(StopSandboxRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFleet



        /// <summary>
        /// Updates a compute fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An Amazon Web Services service limit was exceeded for the calling Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        Task<UpdateFleetResponse> UpdateFleetAsync(UpdateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProject



        /// <summary>
        /// Changes the settings of a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProjectVisibility



        /// <summary>
        /// Changes the public visibility for a project. The project's build results, logs, and
        /// artifacts are available to the general public. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/public-builds.html">Public
        /// build projects</a> in the <i>CodeBuild User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// The following should be kept in mind when making your projects public:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All of a project's build results, logs, and artifacts, including builds that were
        /// run when the project was private, are available to the general public.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All build logs and artifacts are available to the public. Environment variables, source
        /// code, and other sensitive information may have been output to the build logs and artifacts.
        /// You must be careful about what information is output to the build logs. Some best
        /// practice are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Do not store sensitive values in environment variables. We recommend that you use
        /// an Amazon EC2 Systems Manager Parameter Store or Secrets Manager to store sensitive
        /// values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Follow <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/webhooks.html#webhook-best-practices">Best
        /// practices for using webhooks</a> in the <i>CodeBuild User Guide</i> to limit which
        /// entities can trigger a build, and do not store the buildspec in the project itself,
        /// to ensure that your webhooks are as secure as possible.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// A malicious user can use public builds to distribute malicious artifacts. We recommend
        /// that you review all pull requests to verify that the pull request is a legitimate
        /// change. We also recommend that you validate any artifacts with their checksums to
        /// make sure that the correct artifacts are being downloaded.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProjectVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProjectVisibility service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProjectVisibility">REST API Reference for UpdateProjectVisibility Operation</seealso>
        Task<UpdateProjectVisibilityResponse> UpdateProjectVisibilityAsync(UpdateProjectVisibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateReportGroup



        /// <summary>
        /// Updates a report group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateReportGroup">REST API Reference for UpdateReportGroup Operation</seealso>
        Task<UpdateReportGroupResponse> UpdateReportGroupAsync(UpdateReportGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWebhook



        /// <summary>
        /// Updates the webhook associated with an CodeBuild build project. 
        /// 
        ///  <note> 
        /// <para>
        ///  If you use Bitbucket for your repository, <c>rotateSecret</c> is ignored. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        Task<UpdateWebhookResponse> UpdateWebhookAsync(UpdateWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonCodeBuildConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonCodeBuildConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonCodeBuildConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonCodeBuildConfig to create AmazonCodeBuildClient");
            }

            return awsCredentials == null ? 
                    new AmazonCodeBuildClient(serviceClientConfig) :
                    new AmazonCodeBuildClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}