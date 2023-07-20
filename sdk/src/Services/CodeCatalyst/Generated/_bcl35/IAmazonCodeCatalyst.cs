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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeCatalyst.Model;

namespace Amazon.CodeCatalyst
{
    /// <summary>
    /// Interface for accessing CodeCatalyst
    ///
    /// Welcome to the Amazon CodeCatalyst API reference. This reference provides descriptions
    /// of operations and data types for Amazon CodeCatalyst. You can use the Amazon CodeCatalyst
    /// API to work with the following objects. 
    /// 
    ///  
    /// <para>
    /// Spaces, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteSpace</a>, which deletes a space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSpace</a>, which returns information about a space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSubscription</a>, which returns information about the Amazon Web Services account
    /// used for billing purposes and the billing plan for the space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListSpaces</a>, which retrieves a list of spaces.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateSpace</a>, which hanges one or more values for a space.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Projects, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateProject</a> which creates a project in a specified space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetProject</a>, which returns information about a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListProjects</a>, which retrieves a list of projects in a space.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Users, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetUserDetails</a>, which returns information about a user in Amazon CodeCatalyst.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Source repositories, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateSourceRepository</a>, which creates an empty Git-based source repository
    /// in a specified project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateSourceRepositoryBranch</a>, which creates a branch in a specified repository
    /// where you can work on code.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteSourceRepository</a>, which deletes a source repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSourceRepository</a>, which returns information about a source repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSourceRepositoryCloneUrls</a>, which returns information about the URLs that
    /// can be used with a Git client to clone a source repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListSourceRepositories</a>, which retrieves a list of source repositories in a
    /// project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListSourceRepositoryBranches</a>, which retrieves a list of branches in a source
    /// repository.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Dev Environments and the Amazon Web Services Toolkits, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateDevEnvironment</a>, which creates a Dev Environment, where you can quickly
    /// work on the code stored in the source repositories of your project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteDevEnvironment</a>, which deletes a Dev Environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetDevEnvironment</a>, which returns information about a Dev Environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListDevEnvironments</a>, which retrieves a list of Dev Environments in a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListDevEnvironmentSessions</a>, which retrieves a list of active Dev Environment
    /// sessions in a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartDevEnvironment</a>, which starts a specified Dev Environment and puts it
    /// into an active state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartDevEnvironmentSession</a>, which starts a session to a specified Dev Environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopDevEnvironment</a>, which stops a specified Dev Environment and puts it into
    /// an stopped state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopDevEnvironmentSession</a>, which stops a session for a specified Dev Environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateDevEnvironment</a>, which changes one or more values for a Dev Environment.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Security, activity, and resource management in Amazon CodeCatalyst, by calling the
    /// following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateAccessToken</a>, which creates a personal access token (PAT) for the current
    /// user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteAccessToken</a>, which deletes a specified personal access token (PAT).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAccessTokens</a>, which lists all personal access tokens (PATs) associated
    /// with a user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListEventLogs</a>, which retrieves a list of events that occurred during a specified
    /// time period in a space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>VerifySession</a>, which verifies whether the calling user has a valid Amazon
    /// CodeCatalyst login and session.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// If you are using the Amazon CodeCatalyst APIs with an SDK or the CLI, you must configure
    /// your computer to work with Amazon CodeCatalyst and single sign-on (SSO). For more
    /// information, see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/set-up-cli.html">Setting
    /// up to use the CLI with Amazon CodeCatalyst</a> and the SSO documentation for your
    /// SDK.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonCodeCatalyst : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeCatalystPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateAccessToken


        /// <summary>
        /// Creates a personal access token (PAT) for the current user. A personal access token
        /// (PAT) is similar to a password. It is associated with your user identity for use across
        /// all spaces and projects in Amazon CodeCatalyst. You use PATs to access CodeCatalyst
        /// from resources that include integrated development environments (IDEs) and Git-based
        /// source repositories. PATs represent you in Amazon CodeCatalyst and you can manage
        /// them in your user settings.For more information, see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/ipa-tokens-keys.html">Managing
        /// personal access tokens in Amazon CodeCatalyst</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken service method.</param>
        /// 
        /// <returns>The response from the CreateAccessToken service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        CreateAccessTokenResponse CreateAccessToken(CreateAccessTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        IAsyncResult BeginCreateAccessToken(CreateAccessTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessToken.</param>
        /// 
        /// <returns>Returns a  CreateAccessTokenResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        CreateAccessTokenResponse EndCreateAccessToken(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDevEnvironment


        /// <summary>
        /// Creates a Dev Environment in Amazon CodeCatalyst, a cloud-based development environment
        /// that you can use to quickly work on the code stored in the source repositories of
        /// your project. 
        /// 
        ///  <note> 
        /// <para>
        /// When created in the Amazon CodeCatalyst console, by default a Dev Environment is configured
        /// to have a 2 core processor, 4GB of RAM, and 16GB of persistent storage. None of these
        /// defaults apply to a Dev Environment created programmatically.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateDevEnvironment">REST API Reference for CreateDevEnvironment Operation</seealso>
        CreateDevEnvironmentResponse CreateDevEnvironment(CreateDevEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateDevEnvironment">REST API Reference for CreateDevEnvironment Operation</seealso>
        IAsyncResult BeginCreateDevEnvironment(CreateDevEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDevEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateDevEnvironment">REST API Reference for CreateDevEnvironment Operation</seealso>
        CreateDevEnvironmentResponse EndCreateDevEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates a project in a specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse CreateProject(CreateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateProject">REST API Reference for CreateProject Operation</seealso>
        IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse EndCreateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSourceRepository


        /// <summary>
        /// Creates an empty Git-based source repository in a specified project. The repository
        /// is created with an initial empty commit with a default branch named <code>main</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceRepository service method.</param>
        /// 
        /// <returns>The response from the CreateSourceRepository service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepository">REST API Reference for CreateSourceRepository Operation</seealso>
        CreateSourceRepositoryResponse CreateSourceRepository(CreateSourceRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSourceRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceRepository operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSourceRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepository">REST API Reference for CreateSourceRepository Operation</seealso>
        IAsyncResult BeginCreateSourceRepository(CreateSourceRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSourceRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSourceRepository.</param>
        /// 
        /// <returns>Returns a  CreateSourceRepositoryResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepository">REST API Reference for CreateSourceRepository Operation</seealso>
        CreateSourceRepositoryResponse EndCreateSourceRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSourceRepositoryBranch


        /// <summary>
        /// Creates a branch in a specified source repository in Amazon CodeCatalyst. 
        /// 
        ///  <note> 
        /// <para>
        /// This API only creates a branch in a source repository hosted in Amazon CodeCatalyst.
        /// You cannot use this API to create a branch in a linked repository.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceRepositoryBranch service method.</param>
        /// 
        /// <returns>The response from the CreateSourceRepositoryBranch service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepositoryBranch">REST API Reference for CreateSourceRepositoryBranch Operation</seealso>
        CreateSourceRepositoryBranchResponse CreateSourceRepositoryBranch(CreateSourceRepositoryBranchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSourceRepositoryBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceRepositoryBranch operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSourceRepositoryBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepositoryBranch">REST API Reference for CreateSourceRepositoryBranch Operation</seealso>
        IAsyncResult BeginCreateSourceRepositoryBranch(CreateSourceRepositoryBranchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSourceRepositoryBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSourceRepositoryBranch.</param>
        /// 
        /// <returns>Returns a  CreateSourceRepositoryBranchResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepositoryBranch">REST API Reference for CreateSourceRepositoryBranch Operation</seealso>
        CreateSourceRepositoryBranchResponse EndCreateSourceRepositoryBranch(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessToken


        /// <summary>
        /// Deletes a specified personal access token (PAT). A personal access token can only
        /// be deleted by the user who created it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessToken service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        DeleteAccessTokenResponse DeleteAccessToken(DeleteAccessTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        IAsyncResult BeginDeleteAccessToken(DeleteAccessTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessToken.</param>
        /// 
        /// <returns>Returns a  DeleteAccessTokenResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        DeleteAccessTokenResponse EndDeleteAccessToken(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDevEnvironment


        /// <summary>
        /// Deletes a Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteDevEnvironment">REST API Reference for DeleteDevEnvironment Operation</seealso>
        DeleteDevEnvironmentResponse DeleteDevEnvironment(DeleteDevEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteDevEnvironment">REST API Reference for DeleteDevEnvironment Operation</seealso>
        IAsyncResult BeginDeleteDevEnvironment(DeleteDevEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteDevEnvironment">REST API Reference for DeleteDevEnvironment Operation</seealso>
        DeleteDevEnvironmentResponse EndDeleteDevEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes a project in a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse DeleteProject(DeleteProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSourceRepository


        /// <summary>
        /// Deletes a source repository in Amazon CodeCatalyst. You cannot use this API to delete
        /// a linked repository. It can only be used to delete a Amazon CodeCatalyst source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceRepository service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSourceRepository">REST API Reference for DeleteSourceRepository Operation</seealso>
        DeleteSourceRepositoryResponse DeleteSourceRepository(DeleteSourceRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSourceRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceRepository operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSourceRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSourceRepository">REST API Reference for DeleteSourceRepository Operation</seealso>
        IAsyncResult BeginDeleteSourceRepository(DeleteSourceRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSourceRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSourceRepository.</param>
        /// 
        /// <returns>Returns a  DeleteSourceRepositoryResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSourceRepository">REST API Reference for DeleteSourceRepository Operation</seealso>
        DeleteSourceRepositoryResponse EndDeleteSourceRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSpace


        /// <summary>
        /// Deletes a space.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a space cannot be undone. Additionally, since space names must be unique
        /// across Amazon CodeCatalyst, you cannot reuse names of deleted spaces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        IAsyncResult BeginDeleteSpace(DeleteSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpace.</param>
        /// 
        /// <returns>Returns a  DeleteSpaceResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        DeleteSpaceResponse EndDeleteSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDevEnvironment


        /// <summary>
        /// Returns information about a Dev Environment for a source repository in a project.
        /// Dev Environments are specific to the user who creates them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetDevEnvironment">REST API Reference for GetDevEnvironment Operation</seealso>
        GetDevEnvironmentResponse GetDevEnvironment(GetDevEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetDevEnvironment">REST API Reference for GetDevEnvironment Operation</seealso>
        IAsyncResult BeginGetDevEnvironment(GetDevEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevEnvironment.</param>
        /// 
        /// <returns>Returns a  GetDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetDevEnvironment">REST API Reference for GetDevEnvironment Operation</seealso>
        GetDevEnvironmentResponse EndGetDevEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProject


        /// <summary>
        /// Returns information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetProject">REST API Reference for GetProject Operation</seealso>
        GetProjectResponse GetProject(GetProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProject operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetProject">REST API Reference for GetProject Operation</seealso>
        IAsyncResult BeginGetProject(GetProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProject.</param>
        /// 
        /// <returns>Returns a  GetProjectResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetProject">REST API Reference for GetProject Operation</seealso>
        GetProjectResponse EndGetProject(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSourceRepository


        /// <summary>
        /// Returns information about a source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepository service method.</param>
        /// 
        /// <returns>The response from the GetSourceRepository service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepository">REST API Reference for GetSourceRepository Operation</seealso>
        GetSourceRepositoryResponse GetSourceRepository(GetSourceRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSourceRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepository operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSourceRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepository">REST API Reference for GetSourceRepository Operation</seealso>
        IAsyncResult BeginGetSourceRepository(GetSourceRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSourceRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSourceRepository.</param>
        /// 
        /// <returns>Returns a  GetSourceRepositoryResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepository">REST API Reference for GetSourceRepository Operation</seealso>
        GetSourceRepositoryResponse EndGetSourceRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSourceRepositoryCloneUrls


        /// <summary>
        /// Returns information about the URLs that can be used with a Git client to clone a source
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepositoryCloneUrls service method.</param>
        /// 
        /// <returns>The response from the GetSourceRepositoryCloneUrls service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepositoryCloneUrls">REST API Reference for GetSourceRepositoryCloneUrls Operation</seealso>
        GetSourceRepositoryCloneUrlsResponse GetSourceRepositoryCloneUrls(GetSourceRepositoryCloneUrlsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSourceRepositoryCloneUrls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepositoryCloneUrls operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSourceRepositoryCloneUrls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepositoryCloneUrls">REST API Reference for GetSourceRepositoryCloneUrls Operation</seealso>
        IAsyncResult BeginGetSourceRepositoryCloneUrls(GetSourceRepositoryCloneUrlsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSourceRepositoryCloneUrls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSourceRepositoryCloneUrls.</param>
        /// 
        /// <returns>Returns a  GetSourceRepositoryCloneUrlsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepositoryCloneUrls">REST API Reference for GetSourceRepositoryCloneUrls Operation</seealso>
        GetSourceRepositoryCloneUrlsResponse EndGetSourceRepositoryCloneUrls(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSpace


        /// <summary>
        /// Returns information about an space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// 
        /// <returns>The response from the GetSpace service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSpace">REST API Reference for GetSpace Operation</seealso>
        GetSpaceResponse GetSpace(GetSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSpace operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSpace">REST API Reference for GetSpace Operation</seealso>
        IAsyncResult BeginGetSpace(GetSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSpace.</param>
        /// 
        /// <returns>Returns a  GetSpaceResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSpace">REST API Reference for GetSpace Operation</seealso>
        GetSpaceResponse EndGetSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSubscription


        /// <summary>
        /// Returns information about the Amazon Web Services account used for billing purposes
        /// and the billing plan for the space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        IAsyncResult BeginGetSubscription(GetSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscription.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        GetSubscriptionResponse EndGetSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUserDetails


        /// <summary>
        /// Returns information about a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDetails service method.</param>
        /// 
        /// <returns>The response from the GetUserDetails service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetUserDetails">REST API Reference for GetUserDetails Operation</seealso>
        GetUserDetailsResponse GetUserDetails(GetUserDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDetails operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetUserDetails">REST API Reference for GetUserDetails Operation</seealso>
        IAsyncResult BeginGetUserDetails(GetUserDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserDetails.</param>
        /// 
        /// <returns>Returns a  GetUserDetailsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetUserDetails">REST API Reference for GetUserDetails Operation</seealso>
        GetUserDetailsResponse EndGetUserDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessTokens


        /// <summary>
        /// Lists all personal access tokens (PATs) associated with the user who calls the API.
        /// You can only list PATs associated with your Amazon Web Services Builder ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens service method.</param>
        /// 
        /// <returns>The response from the ListAccessTokens service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        ListAccessTokensResponse ListAccessTokens(ListAccessTokensRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessTokens operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessTokens
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        IAsyncResult BeginListAccessTokens(ListAccessTokensRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessTokens operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessTokens.</param>
        /// 
        /// <returns>Returns a  ListAccessTokensResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        ListAccessTokensResponse EndListAccessTokens(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevEnvironments


        /// <summary>
        /// Retrieves a list of Dev Environments in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListDevEnvironments service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironments">REST API Reference for ListDevEnvironments Operation</seealso>
        ListDevEnvironmentsResponse ListDevEnvironments(ListDevEnvironmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironments operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironments">REST API Reference for ListDevEnvironments Operation</seealso>
        IAsyncResult BeginListDevEnvironments(ListDevEnvironmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevEnvironments.</param>
        /// 
        /// <returns>Returns a  ListDevEnvironmentsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironments">REST API Reference for ListDevEnvironments Operation</seealso>
        ListDevEnvironmentsResponse EndListDevEnvironments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevEnvironmentSessions


        /// <summary>
        /// Retrieves a list of active sessions for a Dev Environment in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironmentSessions service method.</param>
        /// 
        /// <returns>The response from the ListDevEnvironmentSessions service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironmentSessions">REST API Reference for ListDevEnvironmentSessions Operation</seealso>
        ListDevEnvironmentSessionsResponse ListDevEnvironmentSessions(ListDevEnvironmentSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevEnvironmentSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironmentSessions operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevEnvironmentSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironmentSessions">REST API Reference for ListDevEnvironmentSessions Operation</seealso>
        IAsyncResult BeginListDevEnvironmentSessions(ListDevEnvironmentSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevEnvironmentSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevEnvironmentSessions.</param>
        /// 
        /// <returns>Returns a  ListDevEnvironmentSessionsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironmentSessions">REST API Reference for ListDevEnvironmentSessions Operation</seealso>
        ListDevEnvironmentSessionsResponse EndListDevEnvironmentSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventLogs


        /// <summary>
        /// Retrieves a list of events that occurred during a specified time period in a space.
        /// You can use these events to audit user and system activity in a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventLogs service method.</param>
        /// 
        /// <returns>The response from the ListEventLogs service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListEventLogs">REST API Reference for ListEventLogs Operation</seealso>
        ListEventLogsResponse ListEventLogs(ListEventLogsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventLogs operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventLogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListEventLogs">REST API Reference for ListEventLogs Operation</seealso>
        IAsyncResult BeginListEventLogs(ListEventLogsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventLogs.</param>
        /// 
        /// <returns>Returns a  ListEventLogsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListEventLogs">REST API Reference for ListEventLogs Operation</seealso>
        ListEventLogsResponse EndListEventLogs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Retrieves a list of projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListProjects">REST API Reference for ListProjects Operation</seealso>
        IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse EndListProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSourceRepositories


        /// <summary>
        /// Retrieves a list of source repositories in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositories service method.</param>
        /// 
        /// <returns>The response from the ListSourceRepositories service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositories">REST API Reference for ListSourceRepositories Operation</seealso>
        ListSourceRepositoriesResponse ListSourceRepositories(ListSourceRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositories operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositories">REST API Reference for ListSourceRepositories Operation</seealso>
        IAsyncResult BeginListSourceRepositories(ListSourceRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceRepositories.</param>
        /// 
        /// <returns>Returns a  ListSourceRepositoriesResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositories">REST API Reference for ListSourceRepositories Operation</seealso>
        ListSourceRepositoriesResponse EndListSourceRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSourceRepositoryBranches


        /// <summary>
        /// Retrieves a list of branches in a specified source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositoryBranches service method.</param>
        /// 
        /// <returns>The response from the ListSourceRepositoryBranches service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositoryBranches">REST API Reference for ListSourceRepositoryBranches Operation</seealso>
        ListSourceRepositoryBranchesResponse ListSourceRepositoryBranches(ListSourceRepositoryBranchesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceRepositoryBranches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositoryBranches operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceRepositoryBranches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositoryBranches">REST API Reference for ListSourceRepositoryBranches Operation</seealso>
        IAsyncResult BeginListSourceRepositoryBranches(ListSourceRepositoryBranchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceRepositoryBranches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceRepositoryBranches.</param>
        /// 
        /// <returns>Returns a  ListSourceRepositoryBranchesResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositoryBranches">REST API Reference for ListSourceRepositoryBranches Operation</seealso>
        ListSourceRepositoryBranchesResponse EndListSourceRepositoryBranches(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSpaces


        /// <summary>
        /// Retrieves a list of spaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        ListSpacesResponse ListSpaces(ListSpacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSpaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        IAsyncResult BeginListSpaces(ListSpacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSpaces.</param>
        /// 
        /// <returns>Returns a  ListSpacesResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        ListSpacesResponse EndListSpaces(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDevEnvironment


        /// <summary>
        /// Starts a specified Dev Environment and puts it into an active state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the StartDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironment">REST API Reference for StartDevEnvironment Operation</seealso>
        StartDevEnvironmentResponse StartDevEnvironment(StartDevEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironment">REST API Reference for StartDevEnvironment Operation</seealso>
        IAsyncResult BeginStartDevEnvironment(StartDevEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDevEnvironment.</param>
        /// 
        /// <returns>Returns a  StartDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironment">REST API Reference for StartDevEnvironment Operation</seealso>
        StartDevEnvironmentResponse EndStartDevEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDevEnvironmentSession


        /// <summary>
        /// Starts a session for a specified Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironmentSession service method.</param>
        /// 
        /// <returns>The response from the StartDevEnvironmentSession service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironmentSession">REST API Reference for StartDevEnvironmentSession Operation</seealso>
        StartDevEnvironmentSessionResponse StartDevEnvironmentSession(StartDevEnvironmentSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDevEnvironmentSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironmentSession operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDevEnvironmentSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironmentSession">REST API Reference for StartDevEnvironmentSession Operation</seealso>
        IAsyncResult BeginStartDevEnvironmentSession(StartDevEnvironmentSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDevEnvironmentSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDevEnvironmentSession.</param>
        /// 
        /// <returns>Returns a  StartDevEnvironmentSessionResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironmentSession">REST API Reference for StartDevEnvironmentSession Operation</seealso>
        StartDevEnvironmentSessionResponse EndStartDevEnvironmentSession(IAsyncResult asyncResult);

        #endregion
        
        #region  StopDevEnvironment


        /// <summary>
        /// Pauses a specified Dev Environment and places it in a non-running state. Stopped Dev
        /// Environments do not consume compute minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the StopDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironment">REST API Reference for StopDevEnvironment Operation</seealso>
        StopDevEnvironmentResponse StopDevEnvironment(StopDevEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironment">REST API Reference for StopDevEnvironment Operation</seealso>
        IAsyncResult BeginStopDevEnvironment(StopDevEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDevEnvironment.</param>
        /// 
        /// <returns>Returns a  StopDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironment">REST API Reference for StopDevEnvironment Operation</seealso>
        StopDevEnvironmentResponse EndStopDevEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  StopDevEnvironmentSession


        /// <summary>
        /// Stops a session for a specified Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironmentSession service method.</param>
        /// 
        /// <returns>The response from the StopDevEnvironmentSession service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironmentSession">REST API Reference for StopDevEnvironmentSession Operation</seealso>
        StopDevEnvironmentSessionResponse StopDevEnvironmentSession(StopDevEnvironmentSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopDevEnvironmentSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironmentSession operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDevEnvironmentSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironmentSession">REST API Reference for StopDevEnvironmentSession Operation</seealso>
        IAsyncResult BeginStopDevEnvironmentSession(StopDevEnvironmentSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopDevEnvironmentSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDevEnvironmentSession.</param>
        /// 
        /// <returns>Returns a  StopDevEnvironmentSessionResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironmentSession">REST API Reference for StopDevEnvironmentSession Operation</seealso>
        StopDevEnvironmentSessionResponse EndStopDevEnvironmentSession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDevEnvironment


        /// <summary>
        /// Changes one or more values for a Dev Environment. Updating certain values of the Dev
        /// Environment will cause a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateDevEnvironment">REST API Reference for UpdateDevEnvironment Operation</seealso>
        UpdateDevEnvironmentResponse UpdateDevEnvironment(UpdateDevEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateDevEnvironment">REST API Reference for UpdateDevEnvironment Operation</seealso>
        IAsyncResult BeginUpdateDevEnvironment(UpdateDevEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateDevEnvironment">REST API Reference for UpdateDevEnvironment Operation</seealso>
        UpdateDevEnvironmentResponse EndUpdateDevEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Changes one or more values for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse UpdateProject(UpdateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSpace


        /// <summary>
        /// Changes one or more values for a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// 
        /// <returns>The response from the UpdateSpace service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        IAsyncResult BeginUpdateSpace(UpdateSpaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSpace.</param>
        /// 
        /// <returns>Returns a  UpdateSpaceResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        UpdateSpaceResponse EndUpdateSpace(IAsyncResult asyncResult);

        #endregion
        
        #region  VerifySession


        /// <summary>
        /// Verifies whether the calling user has a valid Amazon CodeCatalyst login and session.
        /// If successful, this returns the ID of the user in Amazon CodeCatalyst.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySession service method.</param>
        /// 
        /// <returns>The response from the VerifySession service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/VerifySession">REST API Reference for VerifySession Operation</seealso>
        VerifySessionResponse VerifySession(VerifySessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifySession operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/VerifySession">REST API Reference for VerifySession Operation</seealso>
        IAsyncResult BeginVerifySession(VerifySessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  VerifySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifySession.</param>
        /// 
        /// <returns>Returns a  VerifySessionResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/VerifySession">REST API Reference for VerifySession Operation</seealso>
        VerifySessionResponse EndVerifySession(IAsyncResult asyncResult);

        #endregion
        
    }
}