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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeCatalyst.Model;

namespace Amazon.CodeCatalyst
{
    /// <summary>
    /// Interface for accessing CodeCatalyst
    ///
    /// <note> 
    /// <para>
    ///  <b>Amazon CodeCatalyst is in preview release and subject to change.</b> 
    /// </para>
    ///  </note> 
    /// <para>
    /// Welcome to the Amazon CodeCatalyst API reference. This reference provides descriptions
    /// of operations and data types for Amazon CodeCatalyst. You can use the Amazon CodeCatalyst
    /// API to work with the following objects. 
    /// </para>
    ///  
    /// <para>
    /// Dev Environments and the Amazon Web Services Toolkits, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateAccessToken</a>, which creates a personal access token (PAT) for the current
    /// user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateDevEnvironment</a>, which creates a Dev Environment, where you can quickly
    /// work on the code stored in the source repositories of your project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateProject</a> which creates a project in a specified space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateSourceRepositoryBranch</a>, which creates a branch in a specified repository
    /// where you can work on code.
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
    ///  <a>GetProject</a>, which returns information about a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSourceRepositoryCloneUrls</a>, which returns information about the URLs that
    /// can be used with a Git client to clone a source repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSubscription</a>, which returns information about the Amazon Web Services account
    /// used for billing purposes and the billing plan for the space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetUserDetails</a>, which returns information about a user in Amazon CodeCatalyst.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListDevEnvironments</a>, which retrives a list of Dev Environments in a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListProjects</a>, which retrieves a list of projects in a space.
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
    ///  </li> <li> 
    /// <para>
    ///  <a>ListSpaces</a>, which retrieves a list of spaces.
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
    ///  </li> <li> 
    /// <para>
    ///  <a>VerifySession</a>, which verifies whether the calling user has a valid Amazon
    /// CodeCatalyst login and session.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Security, activity, and resource management in Amazon CodeCatalyst, by calling the
    /// following:
    /// </para>
    ///  <ul> <li> 
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
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCodeCatalyst : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeCatalystPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateAccessToken



        /// <summary>
        /// Creates a personal access token (PAT) for the current user. A personal access token
        /// (PAT) is similar to a password. It is associated with your user account. You use PATs
        /// to access Amazon CodeCatalyst resources such as source repositories from third-party
        /// applications like Git and integrated development environments (IDEs). For more information,
        /// see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/ipa-tokens-keys.html">Managing
        /// personal access tokens in Amazon CodeCatalyst</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAccessTokenResponse> CreateAccessTokenAsync(CreateAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDevEnvironment



        /// <summary>
        /// Creates a Dev Environment in Amazon CodeCatalyst, a cloud-based development Dev Environment
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDevEnvironmentResponse> CreateDevEnvironmentAsync(CreateDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProject



        /// <summary>
        /// Creates a project in a specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSourceRepositoryBranchResponse> CreateSourceRepositoryBranchAsync(CreateSourceRepositoryBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessToken



        /// <summary>
        /// Deletes a specified personal access token (PAT). A personal access token can only
        /// be deleted by the user who created it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAccessTokenResponse> DeleteAccessTokenAsync(DeleteAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDevEnvironment



        /// <summary>
        /// Deletes a Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDevEnvironmentResponse> DeleteDevEnvironmentAsync(DeleteDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDevEnvironment



        /// <summary>
        /// Returns information about a Dev Environment for a source repository in a project.
        /// Dev Environments are specific to the user who creates them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDevEnvironmentResponse> GetDevEnvironmentAsync(GetDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProject



        /// <summary>
        /// Returns information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSourceRepositoryCloneUrls



        /// <summary>
        /// Returns information about the URLs that can be used with a Git client to clone a source
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepositoryCloneUrls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSourceRepositoryCloneUrlsResponse> GetSourceRepositoryCloneUrlsAsync(GetSourceRepositoryCloneUrlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSpace



        /// <summary>
        /// Returns information about an space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSpaceResponse> GetSpaceAsync(GetSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSubscription



        /// <summary>
        /// Returns information about the Amazon Web Services account used for billing purposes
        /// and the billing plan for the space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUserDetails



        /// <summary>
        /// Returns information about a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUserDetailsResponse> GetUserDetailsAsync(GetUserDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessTokens



        /// <summary>
        /// Lists all personal access tokens (PATs) associated with the user who calls the API.
        /// You can only list PATs associated with your user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccessTokensResponse> ListAccessTokensAsync(ListAccessTokensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDevEnvironments



        /// <summary>
        /// Retrives a list of Dev Environments in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDevEnvironmentsResponse> ListDevEnvironmentsAsync(ListDevEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEventLogs



        /// <summary>
        /// Retrieves a list of events that occurred during a specified time period in a space.
        /// You can use these events to audit user and system activity in a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListEventLogsResponse> ListEventLogsAsync(ListEventLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects



        /// <summary>
        /// Retrieves a list of projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSourceRepositories



        /// <summary>
        /// Retrieves a list of source repositories in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSourceRepositoriesResponse> ListSourceRepositoriesAsync(ListSourceRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSourceRepositoryBranches



        /// <summary>
        /// Retrieves a list of branches in a specified source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositoryBranches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSourceRepositoryBranchesResponse> ListSourceRepositoryBranchesAsync(ListSourceRepositoryBranchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSpaces



        /// <summary>
        /// Retrieves a list of spaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDevEnvironment



        /// <summary>
        /// Starts a specified Dev Environment and puts it into an active state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartDevEnvironmentResponse> StartDevEnvironmentAsync(StartDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDevEnvironmentSession



        /// <summary>
        /// Starts a session for a specified Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironmentSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartDevEnvironmentSessionResponse> StartDevEnvironmentSessionAsync(StartDevEnvironmentSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopDevEnvironment



        /// <summary>
        /// Pauses a specified Dev Environment and places it in a non-running state. Stopped Dev
        /// Environments do not consume compute minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopDevEnvironmentResponse> StopDevEnvironmentAsync(StopDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopDevEnvironmentSession



        /// <summary>
        /// Stops a session for a specified Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironmentSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopDevEnvironmentSessionResponse> StopDevEnvironmentSessionAsync(StopDevEnvironmentSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDevEnvironment



        /// <summary>
        /// Changes one or more values for a Dev Environment. Updating certain values of the Dev
        /// Environment will cause a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDevEnvironmentResponse> UpdateDevEnvironmentAsync(UpdateDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  VerifySession



        /// <summary>
        /// Verifies whether the calling user has a valid Amazon CodeCatalyst login and session.
        /// If successful, this returns the ID of the user in Amazon CodeCatalyst.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<VerifySessionResponse> VerifySessionAsync(VerifySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}