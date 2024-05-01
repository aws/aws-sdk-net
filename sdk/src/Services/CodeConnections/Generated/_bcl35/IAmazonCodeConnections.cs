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
 * Do not modify this file. This file is generated from the codeconnections-2023-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeConnections.Model;

#pragma warning disable CS1570
namespace Amazon.CodeConnections
{
    /// <summary>
    /// <para>Interface for accessing CodeConnections</para>
    ///
    /// AWS CodeConnections 
    /// <para>
    /// This Amazon Web Services CodeConnections API Reference provides descriptions and usage
    /// examples of the operations and data types for the Amazon Web Services CodeConnections
    /// API. You can use the connections API to work with connections and installations.
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
    /// You can work with tags in Amazon Web Services CodeConnections by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a>, which gets information about Amazon Web Services tags
    /// for a specified Amazon Resource Name (ARN) in Amazon Web Services CodeConnections.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a>, which adds or updates tags for a resource in Amazon Web Services
    /// CodeConnections.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a>, which removes tags for a resource in Amazon Web Services CodeConnections.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about how to use Amazon Web Services CodeConnections, see the <a href="https://docs.aws.amazon.com/dtconsole/latest/userguide/welcome-connections.html">Developer
    /// Tools User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeConnections : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeConnectionsPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateConnection


        /// <summary>
        /// Creates a connection that can then be given to other Amazon Web Services services
        /// like CodePipeline so that it can access third-party code repositories. The connection
        /// is in pending status until the third-party connection handshake is completed from
        /// the console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse CreateConnection(CreateConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        IAsyncResult BeginCreateConnection(CreateConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a  CreateConnectionResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult);

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
        /// <returns>The response from the CreateHost service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateHost">REST API Reference for CreateHost Operation</seealso>
        CreateHostResponse CreateHost(CreateHostRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHost operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateHost">REST API Reference for CreateHost Operation</seealso>
        IAsyncResult BeginCreateHost(CreateHostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHost.</param>
        /// 
        /// <returns>Returns a  CreateHostResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateHost">REST API Reference for CreateHost Operation</seealso>
        CreateHostResponse EndCreateHost(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRepositoryLink


        /// <summary>
        /// Creates a link to a specified external Git repository. A repository link allows Git
        /// sync to monitor and sync changes to files in a specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepositoryLink service method.</param>
        /// 
        /// <returns>The response from the CreateRepositoryLink service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceAlreadyExistsException">
        /// Unable to create resource. Resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateRepositoryLink">REST API Reference for CreateRepositoryLink Operation</seealso>
        CreateRepositoryLinkResponse CreateRepositoryLink(CreateRepositoryLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepositoryLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepositoryLink operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRepositoryLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateRepositoryLink">REST API Reference for CreateRepositoryLink Operation</seealso>
        IAsyncResult BeginCreateRepositoryLink(CreateRepositoryLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRepositoryLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRepositoryLink.</param>
        /// 
        /// <returns>Returns a  CreateRepositoryLinkResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateRepositoryLink">REST API Reference for CreateRepositoryLink Operation</seealso>
        CreateRepositoryLinkResponse EndCreateRepositoryLink(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSyncConfiguration


        /// <summary>
        /// Creates a sync configuration which allows Amazon Web Services to sync content from
        /// a Git repository to update a specified Amazon Web Services resource. Parameters for
        /// the sync configuration are determined by the sync type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSyncConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSyncConfiguration service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceAlreadyExistsException">
        /// Unable to create resource. Resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateSyncConfiguration">REST API Reference for CreateSyncConfiguration Operation</seealso>
        CreateSyncConfigurationResponse CreateSyncConfiguration(CreateSyncConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSyncConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSyncConfiguration operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSyncConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateSyncConfiguration">REST API Reference for CreateSyncConfiguration Operation</seealso>
        IAsyncResult BeginCreateSyncConfiguration(CreateSyncConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSyncConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSyncConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateSyncConfigurationResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/CreateSyncConfiguration">REST API Reference for CreateSyncConfiguration Operation</seealso>
        CreateSyncConfigurationResponse EndCreateSyncConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// The connection to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult);

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
        /// <returns>The response from the DeleteHost service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteHost">REST API Reference for DeleteHost Operation</seealso>
        DeleteHostResponse DeleteHost(DeleteHostRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHost operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteHost">REST API Reference for DeleteHost Operation</seealso>
        IAsyncResult BeginDeleteHost(DeleteHostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHost.</param>
        /// 
        /// <returns>Returns a  DeleteHostResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteHost">REST API Reference for DeleteHost Operation</seealso>
        DeleteHostResponse EndDeleteHost(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRepositoryLink


        /// <summary>
        /// Deletes the association between your connection and a specified external Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryLink service method.</param>
        /// 
        /// <returns>The response from the DeleteRepositoryLink service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.SyncConfigurationStillExistsException">
        /// Unable to continue. The sync blocker still exists.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.UnsupportedProviderTypeException">
        /// The specified provider type is not supported for connections.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteRepositoryLink">REST API Reference for DeleteRepositoryLink Operation</seealso>
        DeleteRepositoryLinkResponse DeleteRepositoryLink(DeleteRepositoryLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepositoryLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryLink operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRepositoryLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteRepositoryLink">REST API Reference for DeleteRepositoryLink Operation</seealso>
        IAsyncResult BeginDeleteRepositoryLink(DeleteRepositoryLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRepositoryLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRepositoryLink.</param>
        /// 
        /// <returns>Returns a  DeleteRepositoryLinkResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteRepositoryLink">REST API Reference for DeleteRepositoryLink Operation</seealso>
        DeleteRepositoryLinkResponse EndDeleteRepositoryLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSyncConfiguration


        /// <summary>
        /// Deletes the sync configuration for a specified repository and connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSyncConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSyncConfiguration service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteSyncConfiguration">REST API Reference for DeleteSyncConfiguration Operation</seealso>
        DeleteSyncConfigurationResponse DeleteSyncConfiguration(DeleteSyncConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSyncConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSyncConfiguration operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSyncConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteSyncConfiguration">REST API Reference for DeleteSyncConfiguration Operation</seealso>
        IAsyncResult BeginDeleteSyncConfiguration(DeleteSyncConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSyncConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSyncConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteSyncConfigurationResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/DeleteSyncConfiguration">REST API Reference for DeleteSyncConfiguration Operation</seealso>
        DeleteSyncConfigurationResponse EndDeleteSyncConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnection


        /// <summary>
        /// Returns the connection ARN and details such as status, owner, and provider type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetConnection">REST API Reference for GetConnection Operation</seealso>
        GetConnectionResponse GetConnection(GetConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetConnection">REST API Reference for GetConnection Operation</seealso>
        IAsyncResult BeginGetConnection(GetConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnection.</param>
        /// 
        /// <returns>Returns a  GetConnectionResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetConnection">REST API Reference for GetConnection Operation</seealso>
        GetConnectionResponse EndGetConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHost


        /// <summary>
        /// Returns the host ARN and details such as status, provider type, endpoint, and, if
        /// applicable, the VPC configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHost service method.</param>
        /// 
        /// <returns>The response from the GetHost service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetHost">REST API Reference for GetHost Operation</seealso>
        GetHostResponse GetHost(GetHostRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHost operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetHost">REST API Reference for GetHost Operation</seealso>
        IAsyncResult BeginGetHost(GetHostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHost.</param>
        /// 
        /// <returns>Returns a  GetHostResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetHost">REST API Reference for GetHost Operation</seealso>
        GetHostResponse EndGetHost(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRepositoryLink


        /// <summary>
        /// Returns details about a repository link. A repository link allows Git sync to monitor
        /// and sync changes from files in a specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryLink service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryLink service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetRepositoryLink">REST API Reference for GetRepositoryLink Operation</seealso>
        GetRepositoryLinkResponse GetRepositoryLink(GetRepositoryLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryLink operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepositoryLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetRepositoryLink">REST API Reference for GetRepositoryLink Operation</seealso>
        IAsyncResult BeginGetRepositoryLink(GetRepositoryLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepositoryLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepositoryLink.</param>
        /// 
        /// <returns>Returns a  GetRepositoryLinkResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetRepositoryLink">REST API Reference for GetRepositoryLink Operation</seealso>
        GetRepositoryLinkResponse EndGetRepositoryLink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRepositorySyncStatus


        /// <summary>
        /// Returns details about the sync status for a repository. A repository sync uses Git
        /// sync to push and pull changes from your remote repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositorySyncStatus service method.</param>
        /// 
        /// <returns>The response from the GetRepositorySyncStatus service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetRepositorySyncStatus">REST API Reference for GetRepositorySyncStatus Operation</seealso>
        GetRepositorySyncStatusResponse GetRepositorySyncStatus(GetRepositorySyncStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositorySyncStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositorySyncStatus operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepositorySyncStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetRepositorySyncStatus">REST API Reference for GetRepositorySyncStatus Operation</seealso>
        IAsyncResult BeginGetRepositorySyncStatus(GetRepositorySyncStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepositorySyncStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepositorySyncStatus.</param>
        /// 
        /// <returns>Returns a  GetRepositorySyncStatusResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetRepositorySyncStatus">REST API Reference for GetRepositorySyncStatus Operation</seealso>
        GetRepositorySyncStatusResponse EndGetRepositorySyncStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceSyncStatus


        /// <summary>
        /// Returns the status of the sync with the Git repository for a specific Amazon Web Services
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSyncStatus service method.</param>
        /// 
        /// <returns>The response from the GetResourceSyncStatus service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetResourceSyncStatus">REST API Reference for GetResourceSyncStatus Operation</seealso>
        GetResourceSyncStatusResponse GetResourceSyncStatus(GetResourceSyncStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceSyncStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSyncStatus operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceSyncStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetResourceSyncStatus">REST API Reference for GetResourceSyncStatus Operation</seealso>
        IAsyncResult BeginGetResourceSyncStatus(GetResourceSyncStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceSyncStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceSyncStatus.</param>
        /// 
        /// <returns>Returns a  GetResourceSyncStatusResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetResourceSyncStatus">REST API Reference for GetResourceSyncStatus Operation</seealso>
        GetResourceSyncStatusResponse EndGetResourceSyncStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSyncBlockerSummary


        /// <summary>
        /// Returns a list of the most recent sync blockers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSyncBlockerSummary service method.</param>
        /// 
        /// <returns>The response from the GetSyncBlockerSummary service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetSyncBlockerSummary">REST API Reference for GetSyncBlockerSummary Operation</seealso>
        GetSyncBlockerSummaryResponse GetSyncBlockerSummary(GetSyncBlockerSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSyncBlockerSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSyncBlockerSummary operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSyncBlockerSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetSyncBlockerSummary">REST API Reference for GetSyncBlockerSummary Operation</seealso>
        IAsyncResult BeginGetSyncBlockerSummary(GetSyncBlockerSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSyncBlockerSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSyncBlockerSummary.</param>
        /// 
        /// <returns>Returns a  GetSyncBlockerSummaryResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetSyncBlockerSummary">REST API Reference for GetSyncBlockerSummary Operation</seealso>
        GetSyncBlockerSummaryResponse EndGetSyncBlockerSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSyncConfiguration


        /// <summary>
        /// Returns details about a sync configuration, including the sync type and resource name.
        /// A sync configuration allows the configuration to sync (push and pull) changes from
        /// the remote repository for a specified branch in a Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSyncConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetSyncConfiguration service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetSyncConfiguration">REST API Reference for GetSyncConfiguration Operation</seealso>
        GetSyncConfigurationResponse GetSyncConfiguration(GetSyncConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSyncConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSyncConfiguration operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSyncConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetSyncConfiguration">REST API Reference for GetSyncConfiguration Operation</seealso>
        IAsyncResult BeginGetSyncConfiguration(GetSyncConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSyncConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSyncConfiguration.</param>
        /// 
        /// <returns>Returns a  GetSyncConfigurationResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/GetSyncConfiguration">REST API Reference for GetSyncConfiguration Operation</seealso>
        GetSyncConfigurationResponse EndGetSyncConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConnections


        /// <summary>
        /// Lists the connections associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListConnections">REST API Reference for ListConnections Operation</seealso>
        ListConnectionsResponse ListConnections(ListConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnections operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListConnections">REST API Reference for ListConnections Operation</seealso>
        IAsyncResult BeginListConnections(ListConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnections.</param>
        /// 
        /// <returns>Returns a  ListConnectionsResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListConnections">REST API Reference for ListConnections Operation</seealso>
        ListConnectionsResponse EndListConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHosts


        /// <summary>
        /// Lists the hosts associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHosts service method.</param>
        /// 
        /// <returns>The response from the ListHosts service method, as returned by CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListHosts">REST API Reference for ListHosts Operation</seealso>
        ListHostsResponse ListHosts(ListHostsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHosts operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHosts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListHosts">REST API Reference for ListHosts Operation</seealso>
        IAsyncResult BeginListHosts(ListHostsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHosts.</param>
        /// 
        /// <returns>Returns a  ListHostsResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListHosts">REST API Reference for ListHosts Operation</seealso>
        ListHostsResponse EndListHosts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRepositoryLinks


        /// <summary>
        /// Lists the repository links created for connections in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoryLinks service method.</param>
        /// 
        /// <returns>The response from the ListRepositoryLinks service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListRepositoryLinks">REST API Reference for ListRepositoryLinks Operation</seealso>
        ListRepositoryLinksResponse ListRepositoryLinks(ListRepositoryLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositoryLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoryLinks operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositoryLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListRepositoryLinks">REST API Reference for ListRepositoryLinks Operation</seealso>
        IAsyncResult BeginListRepositoryLinks(ListRepositoryLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositoryLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositoryLinks.</param>
        /// 
        /// <returns>Returns a  ListRepositoryLinksResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListRepositoryLinks">REST API Reference for ListRepositoryLinks Operation</seealso>
        ListRepositoryLinksResponse EndListRepositoryLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRepositorySyncDefinitions


        /// <summary>
        /// Lists the repository sync definitions for repository links in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositorySyncDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListRepositorySyncDefinitions service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListRepositorySyncDefinitions">REST API Reference for ListRepositorySyncDefinitions Operation</seealso>
        ListRepositorySyncDefinitionsResponse ListRepositorySyncDefinitions(ListRepositorySyncDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositorySyncDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositorySyncDefinitions operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositorySyncDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListRepositorySyncDefinitions">REST API Reference for ListRepositorySyncDefinitions Operation</seealso>
        IAsyncResult BeginListRepositorySyncDefinitions(ListRepositorySyncDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositorySyncDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositorySyncDefinitions.</param>
        /// 
        /// <returns>Returns a  ListRepositorySyncDefinitionsResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListRepositorySyncDefinitions">REST API Reference for ListRepositorySyncDefinitions Operation</seealso>
        ListRepositorySyncDefinitionsResponse EndListRepositorySyncDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSyncConfigurations


        /// <summary>
        /// Returns a list of sync configurations for a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSyncConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListSyncConfigurations service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListSyncConfigurations">REST API Reference for ListSyncConfigurations Operation</seealso>
        ListSyncConfigurationsResponse ListSyncConfigurations(ListSyncConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSyncConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSyncConfigurations operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSyncConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListSyncConfigurations">REST API Reference for ListSyncConfigurations Operation</seealso>
        IAsyncResult BeginListSyncConfigurations(ListSyncConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSyncConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSyncConfigurations.</param>
        /// 
        /// <returns>Returns a  ListSyncConfigurationsResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListSyncConfigurations">REST API Reference for ListSyncConfigurations Operation</seealso>
        ListSyncConfigurationsResponse EndListSyncConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets the set of key-value pairs (metadata) that are used to manage the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.LimitExceededException">
        /// Exceeded the maximum limit for connections.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateHost


        /// <summary>
        /// Updates a specified host with the provided configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHost service method.</param>
        /// 
        /// <returns>The response from the UpdateHost service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.ConflictException">
        /// Two conflicting operations have been made on the same resource.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceUnavailableException">
        /// Resource not found. Verify the ARN for the host resource and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.UnsupportedOperationException">
        /// The operation is not supported. Check the connection status and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateHost">REST API Reference for UpdateHost Operation</seealso>
        UpdateHostResponse UpdateHost(UpdateHostRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHost operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateHost">REST API Reference for UpdateHost Operation</seealso>
        IAsyncResult BeginUpdateHost(UpdateHostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHost.</param>
        /// 
        /// <returns>Returns a  UpdateHostResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateHost">REST API Reference for UpdateHost Operation</seealso>
        UpdateHostResponse EndUpdateHost(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRepositoryLink


        /// <summary>
        /// Updates the association between your connection and a specified external Git repository.
        /// A repository link allows Git sync to monitor and sync changes to files in a specified
        /// Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryLink service method.</param>
        /// 
        /// <returns>The response from the UpdateRepositoryLink service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ConditionalCheckFailedException">
        /// The conditional check failed. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.UpdateOutOfSyncException">
        /// The update is out of sync. Try syncing again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateRepositoryLink">REST API Reference for UpdateRepositoryLink Operation</seealso>
        UpdateRepositoryLinkResponse UpdateRepositoryLink(UpdateRepositoryLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepositoryLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryLink operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRepositoryLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateRepositoryLink">REST API Reference for UpdateRepositoryLink Operation</seealso>
        IAsyncResult BeginUpdateRepositoryLink(UpdateRepositoryLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRepositoryLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRepositoryLink.</param>
        /// 
        /// <returns>Returns a  UpdateRepositoryLinkResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateRepositoryLink">REST API Reference for UpdateRepositoryLink Operation</seealso>
        UpdateRepositoryLinkResponse EndUpdateRepositoryLink(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSyncBlocker


        /// <summary>
        /// Allows you to update the status of a sync blocker, resolving the blocker and allowing
        /// syncing to continue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSyncBlocker service method.</param>
        /// 
        /// <returns>The response from the UpdateSyncBlocker service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.RetryLatestCommitFailedException">
        /// Retrying the latest commit failed. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.SyncBlockerDoesNotExistException">
        /// Unable to continue. The sync blocker does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateSyncBlocker">REST API Reference for UpdateSyncBlocker Operation</seealso>
        UpdateSyncBlockerResponse UpdateSyncBlocker(UpdateSyncBlockerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSyncBlocker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSyncBlocker operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSyncBlocker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateSyncBlocker">REST API Reference for UpdateSyncBlocker Operation</seealso>
        IAsyncResult BeginUpdateSyncBlocker(UpdateSyncBlockerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSyncBlocker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSyncBlocker.</param>
        /// 
        /// <returns>Returns a  UpdateSyncBlockerResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateSyncBlocker">REST API Reference for UpdateSyncBlocker Operation</seealso>
        UpdateSyncBlockerResponse EndUpdateSyncBlocker(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSyncConfiguration


        /// <summary>
        /// Updates the sync configuration for your connection and a specified external Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSyncConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSyncConfiguration service method, as returned by CodeConnections.</returns>
        /// <exception cref="Amazon.CodeConnections.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InternalServerException">
        /// Received an internal server exception. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.InvalidInputException">
        /// The input is not valid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeConnections.Model.UpdateOutOfSyncException">
        /// The update is out of sync. Try syncing again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateSyncConfiguration">REST API Reference for UpdateSyncConfiguration Operation</seealso>
        UpdateSyncConfigurationResponse UpdateSyncConfiguration(UpdateSyncConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSyncConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSyncConfiguration operation on AmazonCodeConnectionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSyncConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateSyncConfiguration">REST API Reference for UpdateSyncConfiguration Operation</seealso>
        IAsyncResult BeginUpdateSyncConfiguration(UpdateSyncConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSyncConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSyncConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateSyncConfigurationResult from CodeConnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeconnections-2023-12-01/UpdateSyncConfiguration">REST API Reference for UpdateSyncConfiguration Operation</seealso>
        UpdateSyncConfigurationResponse EndUpdateSyncConfiguration(IAsyncResult asyncResult);

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