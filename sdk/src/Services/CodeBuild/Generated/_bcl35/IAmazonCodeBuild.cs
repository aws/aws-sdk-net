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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        /// 
        /// <returns>The response from the BatchDeleteBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        BatchDeleteBuildsResponse BatchDeleteBuilds(BatchDeleteBuildsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBuilds operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteBuilds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        IAsyncResult BeginBatchDeleteBuilds(BatchDeleteBuildsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteBuilds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteBuilds.</param>
        /// 
        /// <returns>Returns a  BatchDeleteBuildsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        BatchDeleteBuildsResponse EndBatchDeleteBuilds(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetBuildBatches


        /// <summary>
        /// Retrieves information about one or more batch builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuildBatches service method.</param>
        /// 
        /// <returns>The response from the BatchGetBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuildBatches">REST API Reference for BatchGetBuildBatches Operation</seealso>
        BatchGetBuildBatchesResponse BatchGetBuildBatches(BatchGetBuildBatchesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetBuildBatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuildBatches operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetBuildBatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuildBatches">REST API Reference for BatchGetBuildBatches Operation</seealso>
        IAsyncResult BeginBatchGetBuildBatches(BatchGetBuildBatchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetBuildBatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetBuildBatches.</param>
        /// 
        /// <returns>Returns a  BatchGetBuildBatchesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuildBatches">REST API Reference for BatchGetBuildBatches Operation</seealso>
        BatchGetBuildBatchesResponse EndBatchGetBuildBatches(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetBuilds


        /// <summary>
        /// Gets information about one or more builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuilds service method.</param>
        /// 
        /// <returns>The response from the BatchGetBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        BatchGetBuildsResponse BatchGetBuilds(BatchGetBuildsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuilds operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetBuilds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        IAsyncResult BeginBatchGetBuilds(BatchGetBuildsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetBuilds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetBuilds.</param>
        /// 
        /// <returns>Returns a  BatchGetBuildsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        BatchGetBuildsResponse EndBatchGetBuilds(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetCommandExecutions


        /// <summary>
        /// Gets information about the command executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCommandExecutions service method.</param>
        /// 
        /// <returns>The response from the BatchGetCommandExecutions service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetCommandExecutions">REST API Reference for BatchGetCommandExecutions Operation</seealso>
        BatchGetCommandExecutionsResponse BatchGetCommandExecutions(BatchGetCommandExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetCommandExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCommandExecutions operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetCommandExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetCommandExecutions">REST API Reference for BatchGetCommandExecutions Operation</seealso>
        IAsyncResult BeginBatchGetCommandExecutions(BatchGetCommandExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetCommandExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetCommandExecutions.</param>
        /// 
        /// <returns>Returns a  BatchGetCommandExecutionsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetCommandExecutions">REST API Reference for BatchGetCommandExecutions Operation</seealso>
        BatchGetCommandExecutionsResponse EndBatchGetCommandExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetFleets


        /// <summary>
        /// Gets information about one or more compute fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFleets service method.</param>
        /// 
        /// <returns>The response from the BatchGetFleets service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetFleets">REST API Reference for BatchGetFleets Operation</seealso>
        BatchGetFleetsResponse BatchGetFleets(BatchGetFleetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFleets operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetFleets">REST API Reference for BatchGetFleets Operation</seealso>
        IAsyncResult BeginBatchGetFleets(BatchGetFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetFleets.</param>
        /// 
        /// <returns>Returns a  BatchGetFleetsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetFleets">REST API Reference for BatchGetFleets Operation</seealso>
        BatchGetFleetsResponse EndBatchGetFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetProjects


        /// <summary>
        /// Gets information about one or more build projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProjects service method.</param>
        /// 
        /// <returns>The response from the BatchGetProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        BatchGetProjectsResponse BatchGetProjects(BatchGetProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProjects operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        IAsyncResult BeginBatchGetProjects(BatchGetProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetProjects.</param>
        /// 
        /// <returns>Returns a  BatchGetProjectsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        BatchGetProjectsResponse EndBatchGetProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetReportGroups


        /// <summary>
        /// Returns an array of report groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReportGroups service method.</param>
        /// 
        /// <returns>The response from the BatchGetReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReportGroups">REST API Reference for BatchGetReportGroups Operation</seealso>
        BatchGetReportGroupsResponse BatchGetReportGroups(BatchGetReportGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetReportGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReportGroups operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetReportGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReportGroups">REST API Reference for BatchGetReportGroups Operation</seealso>
        IAsyncResult BeginBatchGetReportGroups(BatchGetReportGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetReportGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetReportGroups.</param>
        /// 
        /// <returns>Returns a  BatchGetReportGroupsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReportGroups">REST API Reference for BatchGetReportGroups Operation</seealso>
        BatchGetReportGroupsResponse EndBatchGetReportGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetReports


        /// <summary>
        /// Returns an array of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReports service method.</param>
        /// 
        /// <returns>The response from the BatchGetReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReports">REST API Reference for BatchGetReports Operation</seealso>
        BatchGetReportsResponse BatchGetReports(BatchGetReportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReports operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReports">REST API Reference for BatchGetReports Operation</seealso>
        IAsyncResult BeginBatchGetReports(BatchGetReportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetReports.</param>
        /// 
        /// <returns>Returns a  BatchGetReportsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReports">REST API Reference for BatchGetReports Operation</seealso>
        BatchGetReportsResponse EndBatchGetReports(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetSandboxes


        /// <summary>
        /// Gets information about the sandbox status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSandboxes service method.</param>
        /// 
        /// <returns>The response from the BatchGetSandboxes service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetSandboxes">REST API Reference for BatchGetSandboxes Operation</seealso>
        BatchGetSandboxesResponse BatchGetSandboxes(BatchGetSandboxesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetSandboxes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSandboxes operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetSandboxes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetSandboxes">REST API Reference for BatchGetSandboxes Operation</seealso>
        IAsyncResult BeginBatchGetSandboxes(BatchGetSandboxesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetSandboxes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetSandboxes.</param>
        /// 
        /// <returns>Returns a  BatchGetSandboxesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetSandboxes">REST API Reference for BatchGetSandboxes Operation</seealso>
        BatchGetSandboxesResponse EndBatchGetSandboxes(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a compute fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
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
        CreateFleetResponse CreateFleet(CreateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
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
        CreateProjectResponse CreateProject(CreateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
        IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse EndCreateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReportGroup


        /// <summary>
        /// Creates a report group. A report group contains a collection of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReportGroup service method.</param>
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
        CreateReportGroupResponse CreateReportGroup(CreateReportGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReportGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReportGroup operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReportGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateReportGroup">REST API Reference for CreateReportGroup Operation</seealso>
        IAsyncResult BeginCreateReportGroup(CreateReportGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReportGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReportGroup.</param>
        /// 
        /// <returns>Returns a  CreateReportGroupResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateReportGroup">REST API Reference for CreateReportGroup Operation</seealso>
        CreateReportGroupResponse EndCreateReportGroup(IAsyncResult asyncResult);

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
        CreateWebhookResponse CreateWebhook(CreateWebhookRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWebhook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        IAsyncResult BeginCreateWebhook(CreateWebhookRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWebhook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWebhook.</param>
        /// 
        /// <returns>Returns a  CreateWebhookResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        CreateWebhookResponse EndCreateWebhook(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBuildBatch


        /// <summary>
        /// Deletes a batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuildBatch service method.</param>
        /// 
        /// <returns>The response from the DeleteBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteBuildBatch">REST API Reference for DeleteBuildBatch Operation</seealso>
        DeleteBuildBatchResponse DeleteBuildBatch(DeleteBuildBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuildBatch operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBuildBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteBuildBatch">REST API Reference for DeleteBuildBatch Operation</seealso>
        IAsyncResult BeginDeleteBuildBatch(DeleteBuildBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBuildBatch.</param>
        /// 
        /// <returns>Returns a  DeleteBuildBatchResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteBuildBatch">REST API Reference for DeleteBuildBatch Operation</seealso>
        DeleteBuildBatchResponse EndDeleteBuildBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes a compute fleet. When you delete a compute fleet, its builds are not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse DeleteFleet(DeleteFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes a build project. When you delete a project, its builds are not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse DeleteProject(DeleteProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReport


        /// <summary>
        /// Deletes a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReport service method.</param>
        /// 
        /// <returns>The response from the DeleteReport service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReport">REST API Reference for DeleteReport Operation</seealso>
        DeleteReportResponse DeleteReport(DeleteReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReport operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReport">REST API Reference for DeleteReport Operation</seealso>
        IAsyncResult BeginDeleteReport(DeleteReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReport.</param>
        /// 
        /// <returns>Returns a  DeleteReportResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReport">REST API Reference for DeleteReport Operation</seealso>
        DeleteReportResponse EndDeleteReport(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReportGroup


        /// <summary>
        /// Deletes a report group. Before you delete a report group, you must delete its reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReportGroup">REST API Reference for DeleteReportGroup Operation</seealso>
        DeleteReportGroupResponse DeleteReportGroup(DeleteReportGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReportGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportGroup operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReportGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReportGroup">REST API Reference for DeleteReportGroup Operation</seealso>
        IAsyncResult BeginDeleteReportGroup(DeleteReportGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReportGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReportGroup.</param>
        /// 
        /// <returns>Returns a  DeleteReportGroupResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReportGroup">REST API Reference for DeleteReportGroup Operation</seealso>
        DeleteReportGroupResponse EndDeleteReportGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSourceCredentials


        /// <summary>
        /// Deletes a set of GitHub, GitHub Enterprise, or Bitbucket source credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceCredentials service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        DeleteSourceCredentialsResponse DeleteSourceCredentials(DeleteSourceCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceCredentials operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSourceCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        IAsyncResult BeginDeleteSourceCredentials(DeleteSourceCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSourceCredentials.</param>
        /// 
        /// <returns>Returns a  DeleteSourceCredentialsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        DeleteSourceCredentialsResponse EndDeleteSourceCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWebhook


        /// <summary>
        /// For an existing CodeBuild build project that has its source code stored in a GitHub
        /// or Bitbucket repository, stops CodeBuild from rebuilding the source code every time
        /// a code change is pushed to the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
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
        DeleteWebhookResponse DeleteWebhook(DeleteWebhookRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWebhook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        IAsyncResult BeginDeleteWebhook(DeleteWebhookRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWebhook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWebhook.</param>
        /// 
        /// <returns>Returns a  DeleteWebhookResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        DeleteWebhookResponse EndDeleteWebhook(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCodeCoverages


        /// <summary>
        /// Retrieves one or more code coverage reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeCoverages service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeCoverages service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeCodeCoverages">REST API Reference for DescribeCodeCoverages Operation</seealso>
        DescribeCodeCoveragesResponse DescribeCodeCoverages(DescribeCodeCoveragesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeCoverages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeCoverages operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCodeCoverages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeCodeCoverages">REST API Reference for DescribeCodeCoverages Operation</seealso>
        IAsyncResult BeginDescribeCodeCoverages(DescribeCodeCoveragesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCodeCoverages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCodeCoverages.</param>
        /// 
        /// <returns>Returns a  DescribeCodeCoveragesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeCodeCoverages">REST API Reference for DescribeCodeCoverages Operation</seealso>
        DescribeCodeCoveragesResponse EndDescribeCodeCoverages(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTestCases


        /// <summary>
        /// Returns a list of details about test cases for a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTestCases service method.</param>
        /// 
        /// <returns>The response from the DescribeTestCases service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeTestCases">REST API Reference for DescribeTestCases Operation</seealso>
        DescribeTestCasesResponse DescribeTestCases(DescribeTestCasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTestCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTestCases operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTestCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeTestCases">REST API Reference for DescribeTestCases Operation</seealso>
        IAsyncResult BeginDescribeTestCases(DescribeTestCasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTestCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTestCases.</param>
        /// 
        /// <returns>Returns a  DescribeTestCasesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeTestCases">REST API Reference for DescribeTestCases Operation</seealso>
        DescribeTestCasesResponse EndDescribeTestCases(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReportGroupTrend


        /// <summary>
        /// Analyzes and accumulates test report values for the specified test reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportGroupTrend service method.</param>
        /// 
        /// <returns>The response from the GetReportGroupTrend service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetReportGroupTrend">REST API Reference for GetReportGroupTrend Operation</seealso>
        GetReportGroupTrendResponse GetReportGroupTrend(GetReportGroupTrendRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReportGroupTrend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReportGroupTrend operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReportGroupTrend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetReportGroupTrend">REST API Reference for GetReportGroupTrend Operation</seealso>
        IAsyncResult BeginGetReportGroupTrend(GetReportGroupTrendRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReportGroupTrend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReportGroupTrend.</param>
        /// 
        /// <returns>Returns a  GetReportGroupTrendResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetReportGroupTrend">REST API Reference for GetReportGroupTrend Operation</seealso>
        GetReportGroupTrendResponse EndGetReportGroupTrend(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Gets a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportSourceCredentials


        /// <summary>
        /// Imports the source repository credentials for an CodeBuild project that has its source
        /// code stored in a GitHub, GitHub Enterprise, GitLab, GitLab Self Managed, or Bitbucket
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSourceCredentials service method.</param>
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
        ImportSourceCredentialsResponse ImportSourceCredentials(ImportSourceCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportSourceCredentials operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportSourceCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ImportSourceCredentials">REST API Reference for ImportSourceCredentials Operation</seealso>
        IAsyncResult BeginImportSourceCredentials(ImportSourceCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportSourceCredentials.</param>
        /// 
        /// <returns>Returns a  ImportSourceCredentialsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ImportSourceCredentials">REST API Reference for ImportSourceCredentials Operation</seealso>
        ImportSourceCredentialsResponse EndImportSourceCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  InvalidateProjectCache


        /// <summary>
        /// Resets the cache for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvalidateProjectCache service method.</param>
        /// 
        /// <returns>The response from the InvalidateProjectCache service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        InvalidateProjectCacheResponse InvalidateProjectCache(InvalidateProjectCacheRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvalidateProjectCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvalidateProjectCache operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvalidateProjectCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        IAsyncResult BeginInvalidateProjectCache(InvalidateProjectCacheRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvalidateProjectCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvalidateProjectCache.</param>
        /// 
        /// <returns>Returns a  InvalidateProjectCacheResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        InvalidateProjectCacheResponse EndInvalidateProjectCache(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBuildBatches


        /// <summary>
        /// Retrieves the identifiers of your build batches in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatches service method.</param>
        /// 
        /// <returns>The response from the ListBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatches">REST API Reference for ListBuildBatches Operation</seealso>
        ListBuildBatchesResponse ListBuildBatches(ListBuildBatchesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuildBatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatches operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuildBatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatches">REST API Reference for ListBuildBatches Operation</seealso>
        IAsyncResult BeginListBuildBatches(ListBuildBatchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuildBatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuildBatches.</param>
        /// 
        /// <returns>Returns a  ListBuildBatchesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatches">REST API Reference for ListBuildBatches Operation</seealso>
        ListBuildBatchesResponse EndListBuildBatches(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBuildBatchesForProject


        /// <summary>
        /// Retrieves the identifiers of the build batches for a specific project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatchesForProject service method.</param>
        /// 
        /// <returns>The response from the ListBuildBatchesForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatchesForProject">REST API Reference for ListBuildBatchesForProject Operation</seealso>
        ListBuildBatchesForProjectResponse ListBuildBatchesForProject(ListBuildBatchesForProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuildBatchesForProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatchesForProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuildBatchesForProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatchesForProject">REST API Reference for ListBuildBatchesForProject Operation</seealso>
        IAsyncResult BeginListBuildBatchesForProject(ListBuildBatchesForProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuildBatchesForProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuildBatchesForProject.</param>
        /// 
        /// <returns>Returns a  ListBuildBatchesForProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatchesForProject">REST API Reference for ListBuildBatchesForProject Operation</seealso>
        ListBuildBatchesForProjectResponse EndListBuildBatchesForProject(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBuilds


        /// <summary>
        /// Gets a list of build IDs, with each build ID representing a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        ListBuildsResponse ListBuilds(ListBuildsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuilds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        IAsyncResult BeginListBuilds(ListBuildsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuilds.</param>
        /// 
        /// <returns>Returns a  ListBuildsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        ListBuildsResponse EndListBuilds(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBuildsForProject


        /// <summary>
        /// Gets a list of build identifiers for the specified build project, with each build
        /// identifier representing a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildsForProject service method.</param>
        /// 
        /// <returns>The response from the ListBuildsForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        ListBuildsForProjectResponse ListBuildsForProject(ListBuildsForProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuildsForProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuildsForProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuildsForProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        IAsyncResult BeginListBuildsForProject(ListBuildsForProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuildsForProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuildsForProject.</param>
        /// 
        /// <returns>Returns a  ListBuildsForProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        ListBuildsForProjectResponse EndListBuildsForProject(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCommandExecutionsForSandbox


        /// <summary>
        /// Gets a list of command executions for a sandbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommandExecutionsForSandbox service method.</param>
        /// 
        /// <returns>The response from the ListCommandExecutionsForSandbox service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCommandExecutionsForSandbox">REST API Reference for ListCommandExecutionsForSandbox Operation</seealso>
        ListCommandExecutionsForSandboxResponse ListCommandExecutionsForSandbox(ListCommandExecutionsForSandboxRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCommandExecutionsForSandbox operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCommandExecutionsForSandbox operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCommandExecutionsForSandbox
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCommandExecutionsForSandbox">REST API Reference for ListCommandExecutionsForSandbox Operation</seealso>
        IAsyncResult BeginListCommandExecutionsForSandbox(ListCommandExecutionsForSandboxRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCommandExecutionsForSandbox operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCommandExecutionsForSandbox.</param>
        /// 
        /// <returns>Returns a  ListCommandExecutionsForSandboxResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCommandExecutionsForSandbox">REST API Reference for ListCommandExecutionsForSandbox Operation</seealso>
        ListCommandExecutionsForSandboxResponse EndListCommandExecutionsForSandbox(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCuratedEnvironmentImages


        /// <summary>
        /// Gets information about Docker images that are managed by CodeBuild.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCuratedEnvironmentImages service method.</param>
        /// 
        /// <returns>The response from the ListCuratedEnvironmentImages service method, as returned by CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        ListCuratedEnvironmentImagesResponse ListCuratedEnvironmentImages(ListCuratedEnvironmentImagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCuratedEnvironmentImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCuratedEnvironmentImages operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCuratedEnvironmentImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        IAsyncResult BeginListCuratedEnvironmentImages(ListCuratedEnvironmentImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCuratedEnvironmentImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCuratedEnvironmentImages.</param>
        /// 
        /// <returns>Returns a  ListCuratedEnvironmentImagesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        ListCuratedEnvironmentImagesResponse EndListCuratedEnvironmentImages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// Gets a list of compute fleet names with each compute fleet name representing a single
        /// compute fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListFleets">REST API Reference for ListFleets Operation</seealso>
        IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse EndListFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Gets a list of build project names, with each build project name representing a single
        /// build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
        IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse EndListProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReportGroups


        /// <summary>
        /// Gets a list ARNs for the report groups in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportGroups service method.</param>
        /// 
        /// <returns>The response from the ListReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportGroups">REST API Reference for ListReportGroups Operation</seealso>
        ListReportGroupsResponse ListReportGroups(ListReportGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReportGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReportGroups operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReportGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportGroups">REST API Reference for ListReportGroups Operation</seealso>
        IAsyncResult BeginListReportGroups(ListReportGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReportGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReportGroups.</param>
        /// 
        /// <returns>Returns a  ListReportGroupsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportGroups">REST API Reference for ListReportGroups Operation</seealso>
        ListReportGroupsResponse EndListReportGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReports


        /// <summary>
        /// Returns a list of ARNs for the reports in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReports">REST API Reference for ListReports Operation</seealso>
        ListReportsResponse ListReports(ListReportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReports operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReports">REST API Reference for ListReports Operation</seealso>
        IAsyncResult BeginListReports(ListReportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReports.</param>
        /// 
        /// <returns>Returns a  ListReportsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReports">REST API Reference for ListReports Operation</seealso>
        ListReportsResponse EndListReports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReportsForReportGroup


        /// <summary>
        /// Returns a list of ARNs for the reports that belong to a <c>ReportGroup</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportsForReportGroup service method.</param>
        /// 
        /// <returns>The response from the ListReportsForReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportsForReportGroup">REST API Reference for ListReportsForReportGroup Operation</seealso>
        ListReportsForReportGroupResponse ListReportsForReportGroup(ListReportsForReportGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReportsForReportGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReportsForReportGroup operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReportsForReportGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportsForReportGroup">REST API Reference for ListReportsForReportGroup Operation</seealso>
        IAsyncResult BeginListReportsForReportGroup(ListReportsForReportGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReportsForReportGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReportsForReportGroup.</param>
        /// 
        /// <returns>Returns a  ListReportsForReportGroupResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportsForReportGroup">REST API Reference for ListReportsForReportGroup Operation</seealso>
        ListReportsForReportGroupResponse EndListReportsForReportGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSandboxes


        /// <summary>
        /// Gets a list of sandboxes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSandboxes service method.</param>
        /// 
        /// <returns>The response from the ListSandboxes service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSandboxes">REST API Reference for ListSandboxes Operation</seealso>
        ListSandboxesResponse ListSandboxes(ListSandboxesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSandboxes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSandboxes operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSandboxes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSandboxes">REST API Reference for ListSandboxes Operation</seealso>
        IAsyncResult BeginListSandboxes(ListSandboxesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSandboxes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSandboxes.</param>
        /// 
        /// <returns>Returns a  ListSandboxesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSandboxes">REST API Reference for ListSandboxes Operation</seealso>
        ListSandboxesResponse EndListSandboxes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSandboxesForProject


        /// <summary>
        /// Gets a list of sandboxes for a given project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSandboxesForProject service method.</param>
        /// 
        /// <returns>The response from the ListSandboxesForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSandboxesForProject">REST API Reference for ListSandboxesForProject Operation</seealso>
        ListSandboxesForProjectResponse ListSandboxesForProject(ListSandboxesForProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSandboxesForProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSandboxesForProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSandboxesForProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSandboxesForProject">REST API Reference for ListSandboxesForProject Operation</seealso>
        IAsyncResult BeginListSandboxesForProject(ListSandboxesForProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSandboxesForProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSandboxesForProject.</param>
        /// 
        /// <returns>Returns a  ListSandboxesForProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSandboxesForProject">REST API Reference for ListSandboxesForProject Operation</seealso>
        ListSandboxesForProjectResponse EndListSandboxesForProject(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSharedProjects


        /// <summary>
        /// Gets a list of projects that are shared with other Amazon Web Services accounts or
        /// users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedProjects service method.</param>
        /// 
        /// <returns>The response from the ListSharedProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedProjects">REST API Reference for ListSharedProjects Operation</seealso>
        ListSharedProjectsResponse ListSharedProjects(ListSharedProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSharedProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSharedProjects operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSharedProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedProjects">REST API Reference for ListSharedProjects Operation</seealso>
        IAsyncResult BeginListSharedProjects(ListSharedProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSharedProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSharedProjects.</param>
        /// 
        /// <returns>Returns a  ListSharedProjectsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedProjects">REST API Reference for ListSharedProjects Operation</seealso>
        ListSharedProjectsResponse EndListSharedProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSharedReportGroups


        /// <summary>
        /// Gets a list of report groups that are shared with other Amazon Web Services accounts
        /// or users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedReportGroups service method.</param>
        /// 
        /// <returns>The response from the ListSharedReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedReportGroups">REST API Reference for ListSharedReportGroups Operation</seealso>
        ListSharedReportGroupsResponse ListSharedReportGroups(ListSharedReportGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSharedReportGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSharedReportGroups operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSharedReportGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedReportGroups">REST API Reference for ListSharedReportGroups Operation</seealso>
        IAsyncResult BeginListSharedReportGroups(ListSharedReportGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSharedReportGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSharedReportGroups.</param>
        /// 
        /// <returns>Returns a  ListSharedReportGroupsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedReportGroups">REST API Reference for ListSharedReportGroups Operation</seealso>
        ListSharedReportGroupsResponse EndListSharedReportGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSourceCredentials


        /// <summary>
        /// Returns a list of <c>SourceCredentialsInfo</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceCredentials service method.</param>
        /// 
        /// <returns>The response from the ListSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        ListSourceCredentialsResponse ListSourceCredentials(ListSourceCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceCredentials operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        IAsyncResult BeginListSourceCredentials(ListSourceCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceCredentials.</param>
        /// 
        /// <returns>Returns a  ListSourceCredentialsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        ListSourceCredentialsResponse EndListSourceCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Stores a resource policy for the ARN of a <c>Project</c> or <c>ReportGroup</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RetryBuild


        /// <summary>
        /// Restarts a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuild service method.</param>
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
        RetryBuildResponse RetryBuild(RetryBuildRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetryBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryBuild operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuild">REST API Reference for RetryBuild Operation</seealso>
        IAsyncResult BeginRetryBuild(RetryBuildRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetryBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryBuild.</param>
        /// 
        /// <returns>Returns a  RetryBuildResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuild">REST API Reference for RetryBuild Operation</seealso>
        RetryBuildResponse EndRetryBuild(IAsyncResult asyncResult);

        #endregion
        
        #region  RetryBuildBatch


        /// <summary>
        /// Restarts a failed batch build. Only batch builds that have failed can be retried.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuildBatch service method.</param>
        /// 
        /// <returns>The response from the RetryBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuildBatch">REST API Reference for RetryBuildBatch Operation</seealso>
        RetryBuildBatchResponse RetryBuildBatch(RetryBuildBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetryBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryBuildBatch operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryBuildBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuildBatch">REST API Reference for RetryBuildBatch Operation</seealso>
        IAsyncResult BeginRetryBuildBatch(RetryBuildBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetryBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryBuildBatch.</param>
        /// 
        /// <returns>Returns a  RetryBuildBatchResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuildBatch">REST API Reference for RetryBuildBatch Operation</seealso>
        RetryBuildBatchResponse EndRetryBuildBatch(IAsyncResult asyncResult);

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
        StartBuildResponse StartBuild(StartBuildRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBuild operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        IAsyncResult BeginStartBuild(StartBuildRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBuild.</param>
        /// 
        /// <returns>Returns a  StartBuildResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        StartBuildResponse EndStartBuild(IAsyncResult asyncResult);

        #endregion
        
        #region  StartBuildBatch


        /// <summary>
        /// Starts a batch build for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBuildBatch service method.</param>
        /// 
        /// <returns>The response from the StartBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuildBatch">REST API Reference for StartBuildBatch Operation</seealso>
        StartBuildBatchResponse StartBuildBatch(StartBuildBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBuildBatch operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBuildBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuildBatch">REST API Reference for StartBuildBatch Operation</seealso>
        IAsyncResult BeginStartBuildBatch(StartBuildBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBuildBatch.</param>
        /// 
        /// <returns>Returns a  StartBuildBatchResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuildBatch">REST API Reference for StartBuildBatch Operation</seealso>
        StartBuildBatchResponse EndStartBuildBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  StartCommandExecution


        /// <summary>
        /// Starts a command execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCommandExecution service method.</param>
        /// 
        /// <returns>The response from the StartCommandExecution service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartCommandExecution">REST API Reference for StartCommandExecution Operation</seealso>
        StartCommandExecutionResponse StartCommandExecution(StartCommandExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartCommandExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCommandExecution operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCommandExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartCommandExecution">REST API Reference for StartCommandExecution Operation</seealso>
        IAsyncResult BeginStartCommandExecution(StartCommandExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartCommandExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCommandExecution.</param>
        /// 
        /// <returns>Returns a  StartCommandExecutionResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartCommandExecution">REST API Reference for StartCommandExecution Operation</seealso>
        StartCommandExecutionResponse EndStartCommandExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSandbox


        /// <summary>
        /// Starts a sandbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSandbox service method.</param>
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
        StartSandboxResponse StartSandbox(StartSandboxRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSandbox operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSandbox operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSandbox
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartSandbox">REST API Reference for StartSandbox Operation</seealso>
        IAsyncResult BeginStartSandbox(StartSandboxRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSandbox operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSandbox.</param>
        /// 
        /// <returns>Returns a  StartSandboxResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartSandbox">REST API Reference for StartSandbox Operation</seealso>
        StartSandboxResponse EndStartSandbox(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSandboxConnection


        /// <summary>
        /// Starts a sandbox connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSandboxConnection service method.</param>
        /// 
        /// <returns>The response from the StartSandboxConnection service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartSandboxConnection">REST API Reference for StartSandboxConnection Operation</seealso>
        StartSandboxConnectionResponse StartSandboxConnection(StartSandboxConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSandboxConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSandboxConnection operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSandboxConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartSandboxConnection">REST API Reference for StartSandboxConnection Operation</seealso>
        IAsyncResult BeginStartSandboxConnection(StartSandboxConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSandboxConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSandboxConnection.</param>
        /// 
        /// <returns>Returns a  StartSandboxConnectionResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartSandboxConnection">REST API Reference for StartSandboxConnection Operation</seealso>
        StartSandboxConnectionResponse EndStartSandboxConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  StopBuild


        /// <summary>
        /// Attempts to stop running a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuild service method.</param>
        /// 
        /// <returns>The response from the StopBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        StopBuildResponse StopBuild(StopBuildRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBuild operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        IAsyncResult BeginStopBuild(StopBuildRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopBuild.</param>
        /// 
        /// <returns>Returns a  StopBuildResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        StopBuildResponse EndStopBuild(IAsyncResult asyncResult);

        #endregion
        
        #region  StopBuildBatch


        /// <summary>
        /// Stops a running batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuildBatch service method.</param>
        /// 
        /// <returns>The response from the StopBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuildBatch">REST API Reference for StopBuildBatch Operation</seealso>
        StopBuildBatchResponse StopBuildBatch(StopBuildBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBuildBatch operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopBuildBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuildBatch">REST API Reference for StopBuildBatch Operation</seealso>
        IAsyncResult BeginStopBuildBatch(StopBuildBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopBuildBatch.</param>
        /// 
        /// <returns>Returns a  StopBuildBatchResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuildBatch">REST API Reference for StopBuildBatch Operation</seealso>
        StopBuildBatchResponse EndStopBuildBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  StopSandbox


        /// <summary>
        /// Stops a sandbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSandbox service method.</param>
        /// 
        /// <returns>The response from the StopSandbox service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopSandbox">REST API Reference for StopSandbox Operation</seealso>
        StopSandboxResponse StopSandbox(StopSandboxRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopSandbox operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSandbox operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSandbox
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopSandbox">REST API Reference for StopSandbox Operation</seealso>
        IAsyncResult BeginStopSandbox(StopSandboxRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopSandbox operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSandbox.</param>
        /// 
        /// <returns>Returns a  StopSandboxResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopSandbox">REST API Reference for StopSandbox Operation</seealso>
        StopSandboxResponse EndStopSandbox(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFleet


        /// <summary>
        /// Updates a compute fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
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
        UpdateFleetResponse UpdateFleet(UpdateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        IAsyncResult BeginUpdateFleet(UpdateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleet.</param>
        /// 
        /// <returns>Returns a  UpdateFleetResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        UpdateFleetResponse EndUpdateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Changes the settings of a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse UpdateProject(UpdateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult);

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
        /// 
        /// <returns>The response from the UpdateProjectVisibility service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProjectVisibility">REST API Reference for UpdateProjectVisibility Operation</seealso>
        UpdateProjectVisibilityResponse UpdateProjectVisibility(UpdateProjectVisibilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProjectVisibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProjectVisibility operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProjectVisibility
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProjectVisibility">REST API Reference for UpdateProjectVisibility Operation</seealso>
        IAsyncResult BeginUpdateProjectVisibility(UpdateProjectVisibilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProjectVisibility operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProjectVisibility.</param>
        /// 
        /// <returns>Returns a  UpdateProjectVisibilityResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProjectVisibility">REST API Reference for UpdateProjectVisibility Operation</seealso>
        UpdateProjectVisibilityResponse EndUpdateProjectVisibility(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReportGroup


        /// <summary>
        /// Updates a report group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified Amazon Web Services resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateReportGroup">REST API Reference for UpdateReportGroup Operation</seealso>
        UpdateReportGroupResponse UpdateReportGroup(UpdateReportGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReportGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportGroup operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReportGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateReportGroup">REST API Reference for UpdateReportGroup Operation</seealso>
        IAsyncResult BeginUpdateReportGroup(UpdateReportGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReportGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReportGroup.</param>
        /// 
        /// <returns>Returns a  UpdateReportGroupResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateReportGroup">REST API Reference for UpdateReportGroup Operation</seealso>
        UpdateReportGroupResponse EndUpdateReportGroup(IAsyncResult asyncResult);

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
        UpdateWebhookResponse UpdateWebhook(UpdateWebhookRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWebhook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        IAsyncResult BeginUpdateWebhook(UpdateWebhookRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWebhook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWebhook.</param>
        /// 
        /// <returns>Returns a  UpdateWebhookResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        UpdateWebhookResponse EndUpdateWebhook(IAsyncResult asyncResult);

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