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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeStarconnections.Model;
using Amazon.CodeStarconnections.Model.Internal.MarshallTransformations;
using Amazon.CodeStarconnections.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CodeStarconnections
{
    /// <summary>
    /// <para>Implementation for accessing CodeStarconnections</para>
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
    public partial class AmazonCodeStarconnectionsClient : AmazonServiceClient, IAmazonCodeStarconnections
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeStarconnectionsMetadata();
        private ICodeStarconnectionsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICodeStarconnectionsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CodeStarconnectionsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCodeStarconnectionsClient()
            : base(new AmazonCodeStarconnectionsConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarconnectionsClient(RegionEndpoint region)
            : base(new AmazonCodeStarconnectionsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCodeStarconnectionsClient Configuration Object</param>
        public AmazonCodeStarconnectionsClient(AmazonCodeStarconnectionsConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeStarconnectionsClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeStarconnectionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarconnectionsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeStarconnectionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with AWS Credentials and an
        /// AmazonCodeStarconnectionsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeStarconnectionsClient Configuration Object</param>
        public AmazonCodeStarconnectionsClient(AWSCredentials credentials, AmazonCodeStarconnectionsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeStarconnectionsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeStarconnectionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarconnectionsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeStarconnectionsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeStarconnectionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeStarconnectionsClient Configuration Object</param>
        public AmazonCodeStarconnectionsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeStarconnectionsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeStarconnectionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeStarconnectionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeStarconnectionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeStarconnectionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeStarconnectionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeStarconnectionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeStarconnectionsClient Configuration Object</param>
        public AmazonCodeStarconnectionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeStarconnectionsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeStarconnectionsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeStarconnectionsAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateConnection


        /// <summary>
        /// Creates a connection that can then be given to other Amazon Web Services services
        /// like CodePipeline so that it can access third-party code repositories. The connection
        /// is in pending status until the third-party connection handshake is completed from
        /// the console.
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
        public virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionResponse>(request, options);
        }


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
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConnectionResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateHostResponse CreateHost(CreateHostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHostResponseUnmarshaller.Instance;

            return Invoke<CreateHostResponse>(request, options);
        }


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
        public virtual Task<CreateHostResponse> CreateHostAsync(CreateHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHostResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateHostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRepositoryLink


        /// <summary>
        /// Creates a link to a specified external Git repository. A repository link allows Git
        /// sync to monitor and sync changes to files in a specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepositoryLink service method.</param>
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
        public virtual CreateRepositoryLinkResponse CreateRepositoryLink(CreateRepositoryLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRepositoryLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryLinkResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryLinkResponse>(request, options);
        }


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
        public virtual Task<CreateRepositoryLinkResponse> CreateRepositoryLinkAsync(CreateRepositoryLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRepositoryLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRepositoryLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSyncConfiguration


        /// <summary>
        /// Creates a sync configuration which allows Amazon Web Services to sync content from
        /// a Git repository to update a specified Amazon Web Services resource. Parameters for
        /// the sync configuration are determined by the sync type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSyncConfiguration service method.</param>
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
        public virtual CreateSyncConfigurationResponse CreateSyncConfiguration(CreateSyncConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSyncConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSyncConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSyncConfigurationResponse>(request, options);
        }


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
        public virtual Task<CreateSyncConfigurationResponse> CreateSyncConfigurationAsync(CreateSyncConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSyncConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSyncConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSyncConfigurationResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }


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
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteHostResponse DeleteHost(DeleteHostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHostResponseUnmarshaller.Instance;

            return Invoke<DeleteHostResponse>(request, options);
        }


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
        public virtual Task<DeleteHostResponse> DeleteHostAsync(DeleteHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHostResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteHostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepositoryLink


        /// <summary>
        /// Deletes the association between your connection and a specified external Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryLink service method.</param>
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
        public virtual DeleteRepositoryLinkResponse DeleteRepositoryLink(DeleteRepositoryLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryLinkResponse>(request, options);
        }


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
        public virtual Task<DeleteRepositoryLinkResponse> DeleteRepositoryLinkAsync(DeleteRepositoryLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRepositoryLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSyncConfiguration


        /// <summary>
        /// Deletes the sync configuration for a specified repository and connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSyncConfiguration service method.</param>
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
        public virtual DeleteSyncConfigurationResponse DeleteSyncConfiguration(DeleteSyncConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSyncConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSyncConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSyncConfigurationResponse>(request, options);
        }


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
        public virtual Task<DeleteSyncConfigurationResponse> DeleteSyncConfigurationAsync(DeleteSyncConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSyncConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSyncConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSyncConfigurationResponse>(request, options, cancellationToken);
        }

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
        public virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }


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
        public virtual Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConnectionResponse>(request, options, cancellationToken);
        }

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
        public virtual GetHostResponse GetHost(GetHostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostResponseUnmarshaller.Instance;

            return Invoke<GetHostResponse>(request, options);
        }


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
        public virtual Task<GetHostResponse> GetHostAsync(GetHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetHostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepositoryLink


        /// <summary>
        /// Returns details about a repository link. A repository link allows Git sync to monitor
        /// and sync changes from files in a specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryLink service method.</param>
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
        public virtual GetRepositoryLinkResponse GetRepositoryLink(GetRepositoryLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRepositoryLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryLinkResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryLinkResponse>(request, options);
        }


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
        public virtual Task<GetRepositoryLinkResponse> GetRepositoryLinkAsync(GetRepositoryLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRepositoryLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRepositoryLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepositorySyncStatus


        /// <summary>
        /// Returns details about the sync status for a repository. A repository sync uses Git
        /// sync to push and pull changes from your remote repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositorySyncStatus service method.</param>
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
        public virtual GetRepositorySyncStatusResponse GetRepositorySyncStatus(GetRepositorySyncStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRepositorySyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositorySyncStatusResponseUnmarshaller.Instance;

            return Invoke<GetRepositorySyncStatusResponse>(request, options);
        }


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
        public virtual Task<GetRepositorySyncStatusResponse> GetRepositorySyncStatusAsync(GetRepositorySyncStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRepositorySyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositorySyncStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRepositorySyncStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceSyncStatus


        /// <summary>
        /// Returns the status of the sync with the Git repository for a specific Amazon Web Services
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSyncStatus service method.</param>
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
        public virtual GetResourceSyncStatusResponse GetResourceSyncStatus(GetResourceSyncStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceSyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSyncStatusResponseUnmarshaller.Instance;

            return Invoke<GetResourceSyncStatusResponse>(request, options);
        }


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
        public virtual Task<GetResourceSyncStatusResponse> GetResourceSyncStatusAsync(GetResourceSyncStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceSyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSyncStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourceSyncStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSyncBlockerSummary


        /// <summary>
        /// Returns a list of the most recent sync blockers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSyncBlockerSummary service method.</param>
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
        public virtual GetSyncBlockerSummaryResponse GetSyncBlockerSummary(GetSyncBlockerSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSyncBlockerSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSyncBlockerSummaryResponseUnmarshaller.Instance;

            return Invoke<GetSyncBlockerSummaryResponse>(request, options);
        }


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
        public virtual Task<GetSyncBlockerSummaryResponse> GetSyncBlockerSummaryAsync(GetSyncBlockerSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSyncBlockerSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSyncBlockerSummaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSyncBlockerSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSyncConfiguration


        /// <summary>
        /// Returns details about a sync configuration, including the sync type and resource name.
        /// A sync configuration allows the configuration to sync (push and pull) changes from
        /// the remote repository for a specified branch in a Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSyncConfiguration service method.</param>
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
        public virtual GetSyncConfigurationResponse GetSyncConfiguration(GetSyncConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSyncConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSyncConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetSyncConfigurationResponse>(request, options);
        }


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
        public virtual Task<GetSyncConfigurationResponse> GetSyncConfigurationAsync(GetSyncConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSyncConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSyncConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSyncConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnections


        /// <summary>
        /// Lists the connections associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionsResponse>(request, options);
        }


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
        public virtual Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHosts


        /// <summary>
        /// Lists the hosts associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHosts service method.</param>
        /// 
        /// <returns>The response from the ListHosts service method, as returned by CodeStarconnections.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/ListHosts">REST API Reference for ListHosts Operation</seealso>
        public virtual ListHostsResponse ListHosts(ListHostsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostsResponseUnmarshaller.Instance;

            return Invoke<ListHostsResponse>(request, options);
        }


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
        public virtual Task<ListHostsResponse> ListHostsAsync(ListHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListHostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRepositoryLinks


        /// <summary>
        /// Lists the repository links created for connections in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoryLinks service method.</param>
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
        public virtual ListRepositoryLinksResponse ListRepositoryLinks(ListRepositoryLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRepositoryLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoryLinksResponseUnmarshaller.Instance;

            return Invoke<ListRepositoryLinksResponse>(request, options);
        }


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
        public virtual Task<ListRepositoryLinksResponse> ListRepositoryLinksAsync(ListRepositoryLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRepositoryLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoryLinksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRepositoryLinksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRepositorySyncDefinitions


        /// <summary>
        /// Lists the repository sync definitions for repository links in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositorySyncDefinitions service method.</param>
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
        public virtual ListRepositorySyncDefinitionsResponse ListRepositorySyncDefinitions(ListRepositorySyncDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRepositorySyncDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositorySyncDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListRepositorySyncDefinitionsResponse>(request, options);
        }


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
        public virtual Task<ListRepositorySyncDefinitionsResponse> ListRepositorySyncDefinitionsAsync(ListRepositorySyncDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRepositorySyncDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositorySyncDefinitionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRepositorySyncDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSyncConfigurations


        /// <summary>
        /// Returns a list of sync configurations for a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSyncConfigurations service method.</param>
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
        public virtual ListSyncConfigurationsResponse ListSyncConfigurations(ListSyncConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSyncConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSyncConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListSyncConfigurationsResponse>(request, options);
        }


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
        public virtual Task<ListSyncConfigurationsResponse> ListSyncConfigurationsAsync(ListSyncConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSyncConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSyncConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSyncConfigurationsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeStarconnections.</returns>
        /// <exception cref="Amazon.CodeStarconnections.Model.ResourceNotFoundException">
        /// Resource not found. Verify the connection resource ARN and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-connections-2019-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateHostResponse UpdateHost(UpdateHostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostResponseUnmarshaller.Instance;

            return Invoke<UpdateHostResponse>(request, options);
        }


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
        public virtual Task<UpdateHostResponse> UpdateHostAsync(UpdateHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHostResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateHostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRepositoryLink


        /// <summary>
        /// Updates the association between your connection and a specified external Git repository.
        /// A repository link allows Git sync to monitor and sync changes to files in a specified
        /// Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryLink service method.</param>
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
        public virtual UpdateRepositoryLinkResponse UpdateRepositoryLink(UpdateRepositoryLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateRepositoryLinkResponse>(request, options);
        }


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
        public virtual Task<UpdateRepositoryLinkResponse> UpdateRepositoryLinkAsync(UpdateRepositoryLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRepositoryLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSyncBlocker


        /// <summary>
        /// Allows you to update the status of a sync blocker, resolving the blocker and allowing
        /// syncing to continue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSyncBlocker service method.</param>
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
        public virtual UpdateSyncBlockerResponse UpdateSyncBlocker(UpdateSyncBlockerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSyncBlockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSyncBlockerResponseUnmarshaller.Instance;

            return Invoke<UpdateSyncBlockerResponse>(request, options);
        }


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
        public virtual Task<UpdateSyncBlockerResponse> UpdateSyncBlockerAsync(UpdateSyncBlockerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSyncBlockerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSyncBlockerResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSyncBlockerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSyncConfiguration


        /// <summary>
        /// Updates the sync configuration for your connection and a specified external Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSyncConfiguration service method.</param>
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
        public virtual UpdateSyncConfigurationResponse UpdateSyncConfiguration(UpdateSyncConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSyncConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSyncConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateSyncConfigurationResponse>(request, options);
        }


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
        public virtual Task<UpdateSyncConfigurationResponse> UpdateSyncConfigurationAsync(UpdateSyncConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSyncConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSyncConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSyncConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}