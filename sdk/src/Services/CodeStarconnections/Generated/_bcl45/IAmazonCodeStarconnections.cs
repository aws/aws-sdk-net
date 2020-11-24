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

namespace Amazon.CodeStarconnections
{
    /// <summary>
    /// Interface for accessing CodeStarconnections
    ///
    /// AWS CodeStar Connections 
    /// <para>
    /// This AWS CodeStar Connections API Reference provides descriptions and usage examples
    /// of the operations and data types for the AWS CodeStar Connections API. You can use
    /// the connections API to work with connections and installations.
    /// </para>
    ///  
    /// <para>
    ///  <i>Connections</i> are configurations that you use to connect AWS resources to external
    /// code repositories. Each connection is a resource that can be given to services such
    /// as CodePipeline to connect to a third-party repository such as Bitbucket. For example,
    /// you can add the connection in CodePipeline so that it triggers your pipeline when
    /// a code change is made to your third-party code repository. Each connection is named
    /// and associated with a unique ARN that is used to reference the connection.
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
    /// You can work with tags in AWS CodeStar Connections by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a>, which gets information about AWS tags for a specified
    /// Amazon Resource Name (ARN) in AWS CodeStar Connections.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a>, which adds or updates tags for a resource in AWS CodeStar Connections.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a>, which removes tags for a resource in AWS CodeStar Connections.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about how to use AWS CodeStar Connections, see the <a href="https://docs.aws.amazon.com/dtconsole/latest/userguide/welcome-connections.html">Developer
    /// Tools User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeStarconnections : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeStarconnectionsPaginatorFactory Paginators { get; }

        
        #region  CreateConnection


        /// <summary>
        /// Creates a connection that can then be given to other AWS services like CodePipeline
        /// so that it can access third-party code repositories. The connection is in pending
        /// status until the third-party connection handshake is completed from the console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
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
        CreateConnectionResponse CreateConnection(CreateConnectionRequest request);



        /// <summary>
        /// Creates a connection that can then be given to other AWS services like CodePipeline
        /// so that it can access third-party code repositories. The connection is in pending
        /// status until the third-party connection handshake is completed from the console.
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
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the CreateHost service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/CreateHost">REST API Reference for CreateHost Operation</seealso>
        CreateHostResponse CreateHost(CreateHostRequest request);



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
        Task<CreateHostResponse> CreateHostAsync(CreateHostRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// The connection to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);



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
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the DeleteHost service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/DeleteHost">REST API Reference for DeleteHost Operation</seealso>
        DeleteHostResponse DeleteHost(DeleteHostRequest request);



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
        Task<DeleteHostResponse> DeleteHostAsync(DeleteHostRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConnection


        /// <summary>
        /// Returns the connection ARN and details such as status, owner, and provider type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetConnection">REST API Reference for GetConnection Operation</seealso>
        GetConnectionResponse GetConnection(GetConnectionRequest request);



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
        Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHost


        /// <summary>
        /// Returns the host ARN and details such as status, provider type, endpoint, and, if
        /// applicable, the VPC configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHost service method.</param>
        /// 
        /// <returns>The response from the GetHost service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetHost">REST API Reference for GetHost Operation</seealso>
        GetHostResponse GetHost(GetHostRequest request);



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
        Task<GetHostResponse> GetHostAsync(GetHostRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConnections


        /// <summary>
        /// Lists the connections associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by CodeStarconnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListConnections">REST API Reference for ListConnections Operation</seealso>
        ListConnectionsResponse ListConnections(ListConnectionsRequest request);



        /// <summary>
        /// Lists the connections associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by CodeStarconnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListConnections">REST API Reference for ListConnections Operation</seealso>
        Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListHosts


        /// <summary>
        /// Lists the hosts associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHosts service method.</param>
        /// 
        /// <returns>The response from the ListHosts service method, as returned by CodeStarconnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListHosts">REST API Reference for ListHosts Operation</seealso>
        ListHostsResponse ListHosts(ListHostsRequest request);



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
        Task<ListHostsResponse> ListHostsAsync(ListHostsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets the set of key-value pairs (metadata) that are used to manage the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an AWS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from an AWS resource.
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateHost


        /// <summary>
        /// Updates a specified host with the provided configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHost service method.</param>
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
        UpdateHostResponse UpdateHost(UpdateHostRequest request);



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
        Task<UpdateHostResponse> UpdateHostAsync(UpdateHostRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}