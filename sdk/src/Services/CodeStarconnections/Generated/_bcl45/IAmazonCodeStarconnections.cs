/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// This AWS CodeStar Connections API Reference provides descriptions and usage examples
    /// of the operations and data types for the AWS CodeStar Connections API. You can use
    /// the Connections API to work with connections and installations.
    /// 
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
    /// the installation for the Bitbucket provider type is the Bitbucket Cloud app. When
    /// you create a connection, you can choose an existing installation or create one.
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
    /// For information about how to use AWS CodeStar Connections, see the <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/welcome.html">AWS
    /// CodePipeline User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeStarconnections : IAmazonService, IDisposable
    {

        
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/GetConnection">REST API Reference for GetConnection Operation</seealso>
        Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        
    }
}