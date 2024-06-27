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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeStarconnections.Model;

#pragma warning disable CS1570
namespace Amazon.CodeStarconnections
{
    /// <summary>
    /// <para>Interface for accessing CodeStarconnections</para>
    ///
    /// AWS CodeStar Connections 
    /// <para>
    /// This Amazon Web Services CodeStar Connections API Reference provides descriptions
    /// and usage examples of the operations and data types for the Amazon Web Services CodeStar
    /// Connections API. You can use the connections API to work with connections and installations.
    /// </para>
    ///  
    /// <para>
    ///  <i>Connections</i> are configurations that you use to connect Amazon Web Services
    /// resources to external code repositories. Each connection is a resource that can be
    /// given to services such as CodePipeline to connect to a third-party repository such
    /// as Bitbucket. For example, you can add the connection in CodePipeline so that it triggers
    /// your pipeline when a code change is made to your third-party code repository. Each
    /// connection is named and associated with a unique ARN that is used to reference the
    /// connection.
    /// </para>
    ///  
    /// <para>
    /// When you create a connection, the console initiates a third-party connection handshake.
    /// <i>Installations</i> are the apps that are used to conduct this handshake. For example,
    /// the installation for the Bitbucket provider type is the Bitbucket app. When you create
    /// a connection, you can choose an existing installation or create one.
    /// </para>
    ///  
    /// <para>
    /// When you want to create a connection to an installed provider type such as GitHub
    /// Enterprise Server, you create a <i>host</i> for your connections.
    /// </para>
    ///  
    /// <para>
    /// You can work with connections by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateConnection</a>, which creates a uniquely named connection that can be referenced
    /// by services such as CodePipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteConnection</a>, which deletes the specified connection.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetConnection</a>, which returns information about the connection, including the
    /// connection status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListConnections</a>, which lists the connections associated with your account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can work with hosts by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateHost</a>, which creates a host that represents the infrastructure where
    /// your provider is installed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteHost</a>, which deletes the specified host.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetHost</a>, which returns information about the host, including the setup status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListHosts</a>, which lists the hosts associated with your account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can work with tags in Amazon Web Services CodeStar Connections by calling the
    /// following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a>, which gets information about Amazon Web Services tags
    /// for a specified Amazon Resource Name (ARN) in Amazon Web Services CodeStar Connections.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a>, which adds or updates tags for a resource in Amazon Web Services
    /// CodeStar Connections.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a>, which removes tags for a resource in Amazon Web Services CodeStar
    /// Connections.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about how to use Amazon Web Services CodeStar Connections, see the
    /// <a href="https://docs.aws.amazon.com/dtconsole/latest/userguide/welcome-connections.html">Developer
    /// Tools User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeStarconnections : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeStarconnectionsPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateConnection



        /// <summary>
        /// Creates a connection that can then be given to other Amazon Web Services services
        /// like CodePipeline so that it can access third-party code repositories. The connection
        /// is in pending status until the third-party connection handshake is completed from
        /// the console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHost



        /// <summary>
        /// Creates a resource that represents the infrastructure where a third-party provider
        /// is installed. The host is used when you create connections to an installed third-party
        /// provider type, such as GitHub Enterprise Server. You create one host for all connections
        /// to that provider.
        /// 
        ///  <note> 
        /// <para>
        /// A host created through the CLI or the SDK is in `PENDING` status by default. You can
        /// make its status `AVAILABLE` by setting up the host in the console.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHost service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/CreateHost">REST API Reference for CreateHost Operation</seealso>
        Task<CreateHostResponse> CreateHostAsync(CreateHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRepositoryLink



        /// <summary>
        /// Creates a link to a specified external Git repository. A repository link allows Git
        /// sync to monitor and sync changes to files in a specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepositoryLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRepositoryLink service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceAlreadyExistsException">
        /// Unable to create resource. Resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/CreateRepositoryLink">REST API Reference for CreateRepositoryLink Operation</seealso>
        Task<CreateRepositoryLinkResponse> CreateRepositoryLinkAsync(CreateRepositoryLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSyncConfiguration



        /// <summary>
        /// Creates a sync configuration which allows Amazon Web Services to sync content from
        /// a Git repository to update a specified Amazon Web Services resource. Parameters for
        /// the sync configuration are determined by the sync type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSyncConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSyncConfiguration service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceAlreadyExistsException">
        /// Unable to create resource. Resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/CreateSyncConfiguration">REST API Reference for CreateSyncConfiguration Operation</seealso>
        Task<CreateSyncConfigurationResponse> CreateSyncConfigurationAsync(CreateSyncConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConnection



        /// <summary>
        /// The connection to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHost



        /// <summary>
        /// The host to be deleted. Before you delete a host, all connections associated to the
        /// host must be deleted.
        /// 
        ///  <note> 
        /// <para>
        /// A host cannot be deleted if it is in the VPC_CONFIG_INITIALIZING or VPC_CONFIG_DELETING
        /// state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHost service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/DeleteHost">REST API Reference for DeleteHost Operation</seealso>
        Task<DeleteHostResponse> DeleteHostAsync(DeleteHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRepositoryLink



        /// <summary>
        /// Deletes the association between your connection and a specified external Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRepositoryLink service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.SyncConfigurationStillExistsException">
        /// Unable to continue. The sync blocker still exists.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.UnsupportedProviderTypeException">
        /// The specified provider type is not supported for connections.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/DeleteRepositoryLink">REST API Reference for DeleteRepositoryLink Operation</seealso>
        Task<DeleteRepositoryLinkResponse> DeleteRepositoryLinkAsync(DeleteRepositoryLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSyncConfiguration



        /// <summary>
        /// Deletes the sync configuration for a specified repository and connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSyncConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSyncConfiguration service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/DeleteSyncConfiguration">REST API Reference for DeleteSyncConfiguration Operation</seealso>
        Task<DeleteSyncConfigurationResponse> DeleteSyncConfigurationAsync(DeleteSyncConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnection



        /// <summary>
        /// Returns the connection ARN and details such as status, owner, and provider type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetConnection">REST API Reference for GetConnection Operation</seealso>
        Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHost



        /// <summary>
        /// Returns the host ARN and details such as status, provider type, endpoint, and, if
        /// applicable, the VPC configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHost service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetHost">REST API Reference for GetHost Operation</seealso>
        Task<GetHostResponse> GetHostAsync(GetHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRepositoryLink



        /// <summary>
        /// Returns details about a repository link. A repository link allows Git sync to monitor
        /// and sync changes from files in a specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRepositoryLink service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetRepositoryLink">REST API Reference for GetRepositoryLink Operation</seealso>
        Task<GetRepositoryLinkResponse> GetRepositoryLinkAsync(GetRepositoryLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRepositorySyncStatus



        /// <summary>
        /// Returns details about the sync status for a repository. A repository sync uses Git
        /// sync to push and pull changes from your remote repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositorySyncStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRepositorySyncStatus service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetRepositorySyncStatus">REST API Reference for GetRepositorySyncStatus Operation</seealso>
        Task<GetRepositorySyncStatusResponse> GetRepositorySyncStatusAsync(GetRepositorySyncStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourceSyncStatus



        /// <summary>
        /// Returns the status of the sync with the Git repository for a specific Amazon Web Services
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSyncStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceSyncStatus service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetResourceSyncStatus">REST API Reference for GetResourceSyncStatus Operation</seealso>
        Task<GetResourceSyncStatusResponse> GetResourceSyncStatusAsync(GetResourceSyncStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSyncBlockerSummary



        /// <summary>
        /// Returns a list of the most recent sync blockers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSyncBlockerSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSyncBlockerSummary service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetSyncBlockerSummary">REST API Reference for GetSyncBlockerSummary Operation</seealso>
        Task<GetSyncBlockerSummaryResponse> GetSyncBlockerSummaryAsync(GetSyncBlockerSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSyncConfiguration



        /// <summary>
        /// Returns details about a sync configuration, including the sync type and resource name.
        /// A sync configuration allows the configuration to sync (push and pull) changes from
        /// the remote repository for a specified branch in a Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSyncConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSyncConfiguration service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetSyncConfiguration">REST API Reference for GetSyncConfiguration Operation</seealso>
        Task<GetSyncConfigurationResponse> GetSyncConfigurationAsync(GetSyncConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConnections



        /// <summary>
        /// Lists the connections associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListConnections">REST API Reference for ListConnections Operation</seealso>
        Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHosts



        /// <summary>
        /// Lists the hosts associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHosts service method, as returned by CodeStarconnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListHosts">REST API Reference for ListHosts Operation</seealso>
        Task<ListHostsResponse> ListHostsAsync(ListHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRepositoryLinks



        /// <summary>
        /// Lists the repository links created for connections in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoryLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRepositoryLinks service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListRepositoryLinks">REST API Reference for ListRepositoryLinks Operation</seealso>
        Task<ListRepositoryLinksResponse> ListRepositoryLinksAsync(ListRepositoryLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRepositorySyncDefinitions



        /// <summary>
        /// Lists the repository sync definitions for repository links in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositorySyncDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRepositorySyncDefinitions service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListRepositorySyncDefinitions">REST API Reference for ListRepositorySyncDefinitions Operation</seealso>
        Task<ListRepositorySyncDefinitionsResponse> ListRepositorySyncDefinitionsAsync(ListRepositorySyncDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSyncConfigurations



        /// <summary>
        /// Returns a list of sync configurations for a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSyncConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSyncConfigurations service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListSyncConfigurations">REST API Reference for ListSyncConfigurations Operation</seealso>
        Task<ListSyncConfigurationsResponse> ListSyncConfigurationsAsync(ListSyncConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Gets the set of key-value pairs (metadata) that are used to manage the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHost



        /// <summary>
        /// Updates a specified host with the provided configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHost service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ConflictException">
        /// Two conflicting operations have been made on the same resource.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.UnsupportedOperationException">
        /// The operation is not supported. Check the connection status and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/UpdateHost">REST API Reference for UpdateHost Operation</seealso>
        Task<UpdateHostResponse> UpdateHostAsync(UpdateHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRepositoryLink



        /// <summary>
        /// Updates the association between your connection and a specified external Git repository.
        /// A repository link allows Git sync to monitor and sync changes to files in a specified
        /// Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRepositoryLink service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ConditionalCheckFailedException">
        /// The conditional check failed. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.UpdateOutOfSyncException">
        /// The update is out of sync. Try syncing again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/UpdateRepositoryLink">REST API Reference for UpdateRepositoryLink Operation</seealso>
        Task<UpdateRepositoryLinkResponse> UpdateRepositoryLinkAsync(UpdateRepositoryLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSyncBlocker



        /// <summary>
        /// Allows you to update the status of a sync blocker, resolving the blocker and allowing
        /// syncing to continue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSyncBlocker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSyncBlocker service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.RetryLatestCommitFailedException">
        /// Retrying the latest commit failed. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.SyncBlockerDoesNotExistException">
        /// Unable to continue. The sync blocker does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/UpdateSyncBlocker">REST API Reference for UpdateSyncBlocker Operation</seealso>
        Task<UpdateSyncBlockerResponse> UpdateSyncBlockerAsync(UpdateSyncBlockerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSyncConfiguration



        /// <summary>
        /// Updates the sync configuration for your connection and a specified external Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSyncConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSyncConfiguration service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.UpdateOutOfSyncException">
        /// The update is out of sync. Try syncing again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/UpdateSyncConfiguration">REST API Reference for UpdateSyncConfiguration Operation</seealso>
        Task<UpdateSyncConfigurationResponse> UpdateSyncConfigurationAsync(UpdateSyncConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonCodeStarconnectionsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonCodeStarconnectionsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonCodeStarconnectionsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonCodeStarconnectionsConfig to create AmazonCodeStarconnectionsClient");
            }

            return awsCredentials == null ? 
                    new AmazonCodeStarconnectionsClient(serviceClientConfig) :
                    new AmazonCodeStarconnectionsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}