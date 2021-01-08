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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DirectoryService.Model;
using Amazon.DirectoryService.Model.Internal.MarshallTransformations;
using Amazon.DirectoryService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DirectoryService
{
    /// <summary>
    /// Implementation for accessing DirectoryService
    ///
    /// AWS Directory Service 
    /// <para>
    /// AWS Directory Service is a web service that makes it easy for you to setup and run
    /// directories in the AWS cloud, or connect your AWS resources with an existing on-premises
    /// Microsoft Active Directory. This guide provides detailed information about AWS Directory
    /// Service operations, data types, parameters, and errors. For information about AWS
    /// Directory Services features, see <a href="https://aws.amazon.com/directoryservice/">AWS
    /// Directory Service</a> and the <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/what_is.html">AWS
    /// Directory Service Administration Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to AWS Directory Service and other AWS
    /// services. For more information about the AWS SDKs, including how to download and install
    /// them, see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonDirectoryServiceClient : AmazonServiceClient, IAmazonDirectoryService
    {
        private static IServiceMetadata serviceMetadata = new AmazonDirectoryServiceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with the credentials loaded from the application's
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
        public AmazonDirectoryServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectoryServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with the credentials loaded from the application's
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
        public AmazonDirectoryServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectoryServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(AmazonDirectoryServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDirectoryServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonDirectoryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDirectoryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Credentials and an
        /// AmazonDirectoryServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(AWSCredentials credentials, AmazonDirectoryServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectoryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectoryServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectoryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDirectoryServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectoryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectoryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectoryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDirectoryServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IDirectoryServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDirectoryServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DirectoryServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        #region  AcceptSharedDirectory

        internal virtual AcceptSharedDirectoryResponse AcceptSharedDirectory(AcceptSharedDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSharedDirectoryResponseUnmarshaller.Instance;

            return Invoke<AcceptSharedDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Accepts a directory sharing request that was sent from the directory owner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptSharedDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptSharedDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryAlreadySharedException">
        /// The specified directory has already been shared with this AWS account.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AcceptSharedDirectory">REST API Reference for AcceptSharedDirectory Operation</seealso>
        public virtual Task<AcceptSharedDirectoryResponse> AcceptSharedDirectoryAsync(AcceptSharedDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSharedDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptSharedDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddIpRoutes

        internal virtual AddIpRoutesResponse AddIpRoutes(AddIpRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return Invoke<AddIpRoutesResponse>(request, options);
        }



        /// <summary>
        /// If the DNS server for your on-premises domain uses a publicly addressable IP address,
        /// you must add a CIDR address block to correctly route traffic to and from your Microsoft
        /// AD on Amazon Web Services. <i>AddIpRoutes</i> adds this address block. You can also
        /// use <i>AddIpRoutes</i> to facilitate routing traffic that uses public IP ranges from
        /// your Microsoft AD on AWS to a peer VPC. 
        /// 
        ///  
        /// <para>
        /// Before you call <i>AddIpRoutes</i>, ensure that all of the required permissions have
        /// been explicitly granted through a policy. For details about what permissions are required
        /// to run the <i>AddIpRoutes</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddIpRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddIpRoutes service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.IpRouteLimitExceededException">
        /// The maximum allowed number of IP addresses was exceeded. The default limit is 100
        /// IP address blocks.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddIpRoutes">REST API Reference for AddIpRoutes Operation</seealso>
        public virtual Task<AddIpRoutesResponse> AddIpRoutesAsync(AddIpRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<AddIpRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddRegion

        internal virtual AddRegionResponse AddRegion(AddRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRegionResponseUnmarshaller.Instance;

            return Invoke<AddRegionResponse>(request, options);
        }



        /// <summary>
        /// Adds two domain controllers in the specified Region for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddRegion service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// Client authentication is not available in this region at this time.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryAlreadyInRegionException">
        /// The Region you specified is the same Region where the AWS Managed Microsoft AD directory
        /// was created. Specify a different Region and try again.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.RegionLimitExceededException">
        /// You have reached the limit for maximum number of simultaneous Region replications
        /// per directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddRegion">REST API Reference for AddRegion Operation</seealso>
        public virtual Task<AddRegionResponse> AddRegionAsync(AddRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRegionResponseUnmarshaller.Instance;

            return InvokeAsync<AddRegionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or overwrites one or more tags for the specified directory. Each directory can
        /// have a maximum of 50 tags. Each tag consists of a key and optional value. Tag keys
        /// must be unique to each resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.TagLimitExceededException">
        /// The maximum allowed number of tags was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelSchemaExtension

        internal virtual CancelSchemaExtensionResponse CancelSchemaExtension(CancelSchemaExtensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<CancelSchemaExtensionResponse>(request, options);
        }



        /// <summary>
        /// Cancels an in-progress schema extension to a Microsoft AD directory. Once a schema
        /// extension has started replicating to all domain controllers, the task can no longer
        /// be canceled. A schema extension can be canceled during any of the following states;
        /// <code>Initializing</code>, <code>CreatingSnapshot</code>, and <code>UpdatingSchema</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSchemaExtension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSchemaExtension service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CancelSchemaExtension">REST API Reference for CancelSchemaExtension Operation</seealso>
        public virtual Task<CancelSchemaExtensionResponse> CancelSchemaExtensionAsync(CancelSchemaExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSchemaExtensionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConnectDirectory

        internal virtual ConnectDirectoryResponse ConnectDirectory(ConnectDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return Invoke<ConnectDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Creates an AD Connector to connect to an on-premises directory.
        /// 
        ///  
        /// <para>
        /// Before you call <code>ConnectDirectory</code>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <code>ConnectDirectory</code> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConnectDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryLimitExceededException">
        /// The maximum number of directories in the region has been reached. You can use the
        /// <a>GetDirectoryLimits</a> operation to determine your directory limits in the region.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ConnectDirectory">REST API Reference for ConnectDirectory Operation</seealso>
        public virtual Task<ConnectDirectoryResponse> ConnectDirectoryAsync(ConnectDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<ConnectDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }



        /// <summary>
        /// Creates an alias for a directory and assigns the alias to the directory. The alias
        /// is used to construct the access URL for the directory, such as <code>http://&lt;alias&gt;.awsapps.com</code>.
        /// 
        ///  <important> 
        /// <para>
        /// After an alias has been created, it cannot be deleted or reused, so this operation
        /// should only be used when absolutely necessary.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateComputer

        internal virtual CreateComputerResponse CreateComputer(CreateComputerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return Invoke<CreateComputerResponse>(request, options);
        }



        /// <summary>
        /// Creates an Active Directory computer object in the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComputer service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AuthenticationFailedException">
        /// An authentication error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateComputer">REST API Reference for CreateComputer Operation</seealso>
        public virtual Task<CreateComputerResponse> CreateComputerAsync(CreateComputerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComputerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConditionalForwarder

        internal virtual CreateConditionalForwarderResponse CreateConditionalForwarder(CreateConditionalForwarderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<CreateConditionalForwarderResponse>(request, options);
        }



        /// <summary>
        /// Creates a conditional forwarder associated with your AWS directory. Conditional forwarders
        /// are required in order to set up a trust relationship with another domain. The conditional
        /// forwarder points to the trusted domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConditionalForwarder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConditionalForwarder service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateConditionalForwarder">REST API Reference for CreateConditionalForwarder Operation</seealso>
        public virtual Task<CreateConditionalForwarderResponse> CreateConditionalForwarderAsync(CreateConditionalForwarderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConditionalForwarderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectory

        internal virtual CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Creates a Simple AD directory. For more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_simple_ad.html">Simple
        /// Active Directory</a> in the <i>AWS Directory Service Admin Guide</i>.
        /// 
        ///  
        /// <para>
        /// Before you call <code>CreateDirectory</code>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <code>CreateDirectory</code> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryLimitExceededException">
        /// The maximum number of directories in the region has been reached. You can use the
        /// <a>GetDirectoryLimits</a> operation to determine your directory limits in the region.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLogSubscription

        internal virtual CreateLogSubscriptionResponse CreateLogSubscription(CreateLogSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateLogSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Creates a subscription to forward real-time Directory Service domain controller security
        /// logs to the specified Amazon CloudWatch log group in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLogSubscription service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InsufficientPermissionsException">
        /// The account does not have sufficient permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateLogSubscription">REST API Reference for CreateLogSubscription Operation</seealso>
        public virtual Task<CreateLogSubscriptionResponse> CreateLogSubscriptionAsync(CreateLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLogSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMicrosoftAD

        internal virtual CreateMicrosoftADResponse CreateMicrosoftAD(CreateMicrosoftADRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMicrosoftADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return Invoke<CreateMicrosoftADResponse>(request, options);
        }



        /// <summary>
        /// Creates a Microsoft AD directory in the AWS Cloud. For more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_microsoft_ad.html">AWS
        /// Managed Microsoft AD</a> in the <i>AWS Directory Service Admin Guide</i>.
        /// 
        ///  
        /// <para>
        /// Before you call <i>CreateMicrosoftAD</i>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <i>CreateMicrosoftAD</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftAD service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMicrosoftAD service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryLimitExceededException">
        /// The maximum number of directories in the region has been reached. You can use the
        /// <a>GetDirectoryLimits</a> operation to determine your directory limits in the region.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateMicrosoftAD">REST API Reference for CreateMicrosoftAD Operation</seealso>
        public virtual Task<CreateMicrosoftADResponse> CreateMicrosoftADAsync(CreateMicrosoftADRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMicrosoftADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMicrosoftADResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of a Simple AD or Microsoft AD directory in the AWS cloud.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot take snapshots of AD Connector directories.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.SnapshotLimitExceededException">
        /// The maximum number of manual snapshots for the directory has been reached. You can
        /// use the <a>GetSnapshotLimits</a> operation to determine the snapshot limits for a
        /// directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrust

        internal virtual CreateTrustResponse CreateTrust(CreateTrustRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return Invoke<CreateTrustResponse>(request, options);
        }



        /// <summary>
        /// AWS Directory Service for Microsoft Active Directory allows you to configure trust
        /// relationships. For example, you can establish a trust between your AWS Managed Microsoft
        /// AD directory, and your existing on-premises Microsoft Active Directory. This would
        /// allow you to provide users and groups access to resources in either domain, with a
        /// single set of credentials.
        /// 
        ///  
        /// <para>
        /// This action initiates the creation of the AWS side of a trust relationship between
        /// an AWS Managed Microsoft AD directory and an external domain. You can create either
        /// a forest trust or an external trust.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrust service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrust service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateTrust">REST API Reference for CreateTrust Operation</seealso>
        public virtual Task<CreateTrustResponse> CreateTrustAsync(CreateTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrustResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConditionalForwarder

        internal virtual DeleteConditionalForwarderResponse DeleteConditionalForwarder(DeleteConditionalForwarderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<DeleteConditionalForwarderResponse>(request, options);
        }



        /// <summary>
        /// Deletes a conditional forwarder that has been set up for your AWS directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConditionalForwarder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConditionalForwarder service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteConditionalForwarder">REST API Reference for DeleteConditionalForwarder Operation</seealso>
        public virtual Task<DeleteConditionalForwarderResponse> DeleteConditionalForwarderAsync(DeleteConditionalForwarderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConditionalForwarderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectory

        internal virtual DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Deletes an AWS Directory Service directory.
        /// 
        ///  
        /// <para>
        /// Before you call <code>DeleteDirectory</code>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <code>DeleteDirectory</code> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLogSubscription

        internal virtual DeleteLogSubscriptionResponse DeleteLogSubscription(DeleteLogSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteLogSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLogSubscription service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteLogSubscription">REST API Reference for DeleteLogSubscription Operation</seealso>
        public virtual Task<DeleteLogSubscriptionResponse> DeleteLogSubscriptionAsync(DeleteLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLogSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes a directory snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrust

        internal virtual DeleteTrustResponse DeleteTrust(DeleteTrustRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing trust relationship between your AWS Managed Microsoft AD directory
        /// and an external domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrust service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrust service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteTrust">REST API Reference for DeleteTrust Operation</seealso>
        public virtual Task<DeleteTrustResponse> DeleteTrustAsync(DeleteTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrustResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterCertificate

        internal virtual DeregisterCertificateResponse DeregisterCertificate(DeregisterCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterCertificateResponseUnmarshaller.Instance;

            return Invoke<DeregisterCertificateResponse>(request, options);
        }



        /// <summary>
        /// Deletes from the system the certificate that was registered for secure LDAP or client
        /// certificate authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterCertificate service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateDoesNotExistException">
        /// The certificate is not present in the system for describe or deregister activities.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateInUseException">
        /// The certificate is being used for the LDAP security connection and cannot be removed
        /// without disabling LDAP security.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterCertificate">REST API Reference for DeregisterCertificate Operation</seealso>
        public virtual Task<DeregisterCertificateResponse> DeregisterCertificateAsync(DeregisterCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterEventTopic

        internal virtual DeregisterEventTopicResponse DeregisterEventTopic(DeregisterEventTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<DeregisterEventTopicResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified directory as a publisher to the specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterEventTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterEventTopic service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterEventTopic">REST API Reference for DeregisterEventTopic Operation</seealso>
        public virtual Task<DeregisterEventTopicResponse> DeregisterEventTopicAsync(DeregisterEventTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterEventTopicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificate

        internal virtual DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateResponse>(request, options);
        }



        /// <summary>
        /// Displays information about the certificate registered for secure LDAP or client certificate
        /// authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateDoesNotExistException">
        /// The certificate is not present in the system for describe or deregister activities.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConditionalForwarders

        internal virtual DescribeConditionalForwardersResponse DescribeConditionalForwarders(DescribeConditionalForwardersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return Invoke<DescribeConditionalForwardersResponse>(request, options);
        }



        /// <summary>
        /// Obtains information about the conditional forwarders for this account.
        /// 
        ///  
        /// <para>
        /// If no input parameters are provided for RemoteDomainNames, this request describes
        /// all conditional forwarders for the specified directory ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConditionalForwarders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConditionalForwarders service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeConditionalForwarders">REST API Reference for DescribeConditionalForwarders Operation</seealso>
        public virtual Task<DescribeConditionalForwardersResponse> DescribeConditionalForwardersAsync(DescribeConditionalForwardersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConditionalForwardersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectories

        internal virtual DescribeDirectoriesResponse DescribeDirectories()
        {
            return DescribeDirectories(new DescribeDirectoriesRequest());
        }
        internal virtual DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoriesResponse>(request, options);
        }


        /// <summary>
        /// Obtains information about the directories that belong to this account.
        /// 
        ///  
        /// <para>
        /// You can retrieve information about specific directories by passing the directory identifiers
        /// in the <code>DirectoryIds</code> parameter. Otherwise, all directories that belong
        /// to the current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> request
        /// and response parameters. If more results are available, the <code>DescribeDirectoriesResult.NextToken</code>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <code>Limit</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectories service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectories">REST API Reference for DescribeDirectories Operation</seealso>
        public virtual Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDirectoriesAsync(new DescribeDirectoriesRequest(), cancellationToken);
        }



        /// <summary>
        /// Obtains information about the directories that belong to this account.
        /// 
        ///  
        /// <para>
        /// You can retrieve information about specific directories by passing the directory identifiers
        /// in the <code>DirectoryIds</code> parameter. Otherwise, all directories that belong
        /// to the current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> request
        /// and response parameters. If more results are available, the <code>DescribeDirectoriesResult.NextToken</code>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <code>Limit</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectories service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectories">REST API Reference for DescribeDirectories Operation</seealso>
        public virtual Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(DescribeDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomainControllers

        internal virtual DescribeDomainControllersResponse DescribeDomainControllers(DescribeDomainControllersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainControllersResponse>(request, options);
        }



        /// <summary>
        /// Provides information about any domain controllers in your directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainControllers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainControllers service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDomainControllers">REST API Reference for DescribeDomainControllers Operation</seealso>
        public virtual Task<DescribeDomainControllersResponse> DescribeDomainControllersAsync(DescribeDomainControllersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainControllersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventTopics

        internal virtual DescribeEventTopicsResponse DescribeEventTopics(DescribeEventTopicsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventTopicsResponse>(request, options);
        }



        /// <summary>
        /// Obtains information about which SNS topics receive status messages from the specified
        /// directory.
        /// 
        ///  
        /// <para>
        /// If no input parameters are provided, such as DirectoryId or TopicName, this request
        /// describes all of the associations in the account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTopics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventTopics service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeEventTopics">REST API Reference for DescribeEventTopics Operation</seealso>
        public virtual Task<DescribeEventTopicsResponse> DescribeEventTopicsAsync(DescribeEventTopicsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventTopicsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLDAPSSettings

        internal virtual DescribeLDAPSSettingsResponse DescribeLDAPSSettings(DescribeLDAPSSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLDAPSSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLDAPSSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeLDAPSSettingsResponse>(request, options);
        }



        /// <summary>
        /// Describes the status of LDAP security for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLDAPSSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLDAPSSettings service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeLDAPSSettings">REST API Reference for DescribeLDAPSSettings Operation</seealso>
        public virtual Task<DescribeLDAPSSettingsResponse> DescribeLDAPSSettingsAsync(DescribeLDAPSSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLDAPSSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLDAPSSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLDAPSSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRegions

        internal virtual DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionsResponse>(request, options);
        }



        /// <summary>
        /// Provides information about the Regions that are configured for multi-Region replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// Client authentication is not available in this region at this time.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSharedDirectories

        internal virtual DescribeSharedDirectoriesResponse DescribeSharedDirectories(DescribeSharedDirectoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSharedDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSharedDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeSharedDirectoriesResponse>(request, options);
        }



        /// <summary>
        /// Returns the shared directories in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSharedDirectories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSharedDirectories service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSharedDirectories">REST API Reference for DescribeSharedDirectories Operation</seealso>
        public virtual Task<DescribeSharedDirectoriesResponse> DescribeSharedDirectoriesAsync(DescribeSharedDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSharedDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSharedDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSharedDirectoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Obtains information about the directory snapshots that belong to this account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> request and
        /// response parameters. If more results are available, the <i>DescribeSnapshots.NextToken</i>
        /// member contains a token that you pass in the next call to <a>DescribeSnapshots</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <i>Limit</i> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrusts

        internal virtual DescribeTrustsResponse DescribeTrusts(DescribeTrustsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrustsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustsResponse>(request, options);
        }



        /// <summary>
        /// Obtains information about the trust relationships for this account.
        /// 
        ///  
        /// <para>
        /// If no input parameters are provided, such as DirectoryId or TrustIds, this request
        /// describes all the trust relationships belonging to the account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrusts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrusts service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeTrusts">REST API Reference for DescribeTrusts Operation</seealso>
        public virtual Task<DescribeTrustsResponse> DescribeTrustsAsync(DescribeTrustsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrustsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrustsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableClientAuthentication

        internal virtual DisableClientAuthenticationResponse DisableClientAuthentication(DisableClientAuthenticationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableClientAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableClientAuthenticationResponseUnmarshaller.Instance;

            return Invoke<DisableClientAuthenticationResponse>(request, options);
        }



        /// <summary>
        /// Disables alternative client authentication methods for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableClientAuthentication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableClientAuthentication service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// Client authentication is not available in this region at this time.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidClientAuthStatusException">
        /// Client authentication is already enabled.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableClientAuthentication">REST API Reference for DisableClientAuthentication Operation</seealso>
        public virtual Task<DisableClientAuthenticationResponse> DisableClientAuthenticationAsync(DisableClientAuthenticationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableClientAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableClientAuthenticationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableClientAuthenticationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableLDAPS

        internal virtual DisableLDAPSResponse DisableLDAPS(DisableLDAPSRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableLDAPSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLDAPSResponseUnmarshaller.Instance;

            return Invoke<DisableLDAPSResponse>(request, options);
        }



        /// <summary>
        /// Deactivates LDAP secure calls for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableLDAPS service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableLDAPS service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidLDAPSStatusException">
        /// The LDAP activities could not be performed because they are limited by the LDAPS status.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableLDAPS">REST API Reference for DisableLDAPS Operation</seealso>
        public virtual Task<DisableLDAPSResponse> DisableLDAPSAsync(DisableLDAPSRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableLDAPSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLDAPSResponseUnmarshaller.Instance;

            return InvokeAsync<DisableLDAPSResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableRadius

        internal virtual DisableRadiusResponse DisableRadius(DisableRadiusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return Invoke<DisableRadiusResponse>(request, options);
        }



        /// <summary>
        /// Disables multi-factor authentication (MFA) with the Remote Authentication Dial In
        /// User Service (RADIUS) server for an AD Connector or Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRadius service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableRadius service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableRadius">REST API Reference for DisableRadius Operation</seealso>
        public virtual Task<DisableRadiusResponse> DisableRadiusAsync(DisableRadiusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<DisableRadiusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableSso

        internal virtual DisableSsoResponse DisableSso(DisableSsoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return Invoke<DisableSsoResponse>(request, options);
        }



        /// <summary>
        /// Disables single-sign on for a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSso service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableSso service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AuthenticationFailedException">
        /// An authentication error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InsufficientPermissionsException">
        /// The account does not have sufficient permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableSso">REST API Reference for DisableSso Operation</seealso>
        public virtual Task<DisableSsoResponse> DisableSsoAsync(DisableSsoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSsoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableClientAuthentication

        internal virtual EnableClientAuthenticationResponse EnableClientAuthentication(EnableClientAuthenticationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableClientAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableClientAuthenticationResponseUnmarshaller.Instance;

            return Invoke<EnableClientAuthenticationResponse>(request, options);
        }



        /// <summary>
        /// Enables alternative client authentication methods for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableClientAuthentication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableClientAuthentication service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// Client authentication is not available in this region at this time.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidClientAuthStatusException">
        /// Client authentication is already enabled.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.NoAvailableCertificateException">
        /// Client authentication setup could not be completed because at least one valid certificate
        /// must be registered in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableClientAuthentication">REST API Reference for EnableClientAuthentication Operation</seealso>
        public virtual Task<EnableClientAuthenticationResponse> EnableClientAuthenticationAsync(EnableClientAuthenticationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableClientAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableClientAuthenticationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableClientAuthenticationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableLDAPS

        internal virtual EnableLDAPSResponse EnableLDAPS(EnableLDAPSRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableLDAPSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLDAPSResponseUnmarshaller.Instance;

            return Invoke<EnableLDAPSResponse>(request, options);
        }



        /// <summary>
        /// Activates the switch for the specific directory to always use LDAP secure calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableLDAPS service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableLDAPS service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidLDAPSStatusException">
        /// The LDAP activities could not be performed because they are limited by the LDAPS status.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.NoAvailableCertificateException">
        /// Client authentication setup could not be completed because at least one valid certificate
        /// must be registered in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableLDAPS">REST API Reference for EnableLDAPS Operation</seealso>
        public virtual Task<EnableLDAPSResponse> EnableLDAPSAsync(EnableLDAPSRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableLDAPSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLDAPSResponseUnmarshaller.Instance;

            return InvokeAsync<EnableLDAPSResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableRadius

        internal virtual EnableRadiusResponse EnableRadius(EnableRadiusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return Invoke<EnableRadiusResponse>(request, options);
        }



        /// <summary>
        /// Enables multi-factor authentication (MFA) with the Remote Authentication Dial In User
        /// Service (RADIUS) server for an AD Connector or Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRadius service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableRadius service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableRadius">REST API Reference for EnableRadius Operation</seealso>
        public virtual Task<EnableRadiusResponse> EnableRadiusAsync(EnableRadiusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<EnableRadiusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableSso

        internal virtual EnableSsoResponse EnableSso(EnableSsoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return Invoke<EnableSsoResponse>(request, options);
        }



        /// <summary>
        /// Enables single sign-on for a directory. Single sign-on allows users in your directory
        /// to access certain AWS services from a computer joined to the directory without having
        /// to enter their credentials separately.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSso service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableSso service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AuthenticationFailedException">
        /// An authentication error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InsufficientPermissionsException">
        /// The account does not have sufficient permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableSso">REST API Reference for EnableSso Operation</seealso>
        public virtual Task<EnableSsoResponse> EnableSsoAsync(EnableSsoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSsoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDirectoryLimits

        internal virtual GetDirectoryLimitsResponse GetDirectoryLimits()
        {
            return GetDirectoryLimits(new GetDirectoryLimitsRequest());
        }
        internal virtual GetDirectoryLimitsResponse GetDirectoryLimits(GetDirectoryLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryLimitsResponse>(request, options);
        }


        /// <summary>
        /// Obtains directory limit information for the current Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDirectoryLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual Task<GetDirectoryLimitsResponse> GetDirectoryLimitsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetDirectoryLimitsAsync(new GetDirectoryLimitsRequest(), cancellationToken);
        }



        /// <summary>
        /// Obtains directory limit information for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDirectoryLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual Task<GetDirectoryLimitsResponse> GetDirectoryLimitsAsync(GetDirectoryLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDirectoryLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSnapshotLimits

        internal virtual GetSnapshotLimitsResponse GetSnapshotLimits(GetSnapshotLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotLimitsResponse>(request, options);
        }



        /// <summary>
        /// Obtains the manual snapshot limits for a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnapshotLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetSnapshotLimits">REST API Reference for GetSnapshotLimits Operation</seealso>
        public virtual Task<GetSnapshotLimitsResponse> GetSnapshotLimitsAsync(GetSnapshotLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSnapshotLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCertificates

        internal virtual ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesResponse>(request, options);
        }



        /// <summary>
        /// For the specified directory, lists all the certificates registered for a secure LDAP
        /// or client certificate authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIpRoutes

        internal virtual ListIpRoutesResponse ListIpRoutes(ListIpRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return Invoke<ListIpRoutesResponse>(request, options);
        }



        /// <summary>
        /// Lists the address blocks that you have added to a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIpRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIpRoutes service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListIpRoutes">REST API Reference for ListIpRoutes Operation</seealso>
        public virtual Task<ListIpRoutesResponse> ListIpRoutesAsync(ListIpRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIpRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLogSubscriptions

        internal virtual ListLogSubscriptionsResponse ListLogSubscriptions(ListLogSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLogSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListLogSubscriptionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the active log subscriptions for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLogSubscriptions service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListLogSubscriptions">REST API Reference for ListLogSubscriptions Operation</seealso>
        public virtual Task<ListLogSubscriptionsResponse> ListLogSubscriptionsAsync(ListLogSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLogSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLogSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSchemaExtensions

        internal virtual ListSchemaExtensionsResponse ListSchemaExtensions(ListSchemaExtensionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaExtensionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all schema extensions applied to a Microsoft AD Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaExtensions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemaExtensions service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListSchemaExtensions">REST API Reference for ListSchemaExtensions Operation</seealso>
        public virtual Task<ListSchemaExtensionsResponse> ListSchemaExtensionsAsync(ListSchemaExtensionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemaExtensionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags on a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterCertificate

        internal virtual RegisterCertificateResponse RegisterCertificate(RegisterCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateResponseUnmarshaller.Instance;

            return Invoke<RegisterCertificateResponse>(request, options);
        }



        /// <summary>
        /// Registers a certificate for a secure LDAP or client certificate authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterCertificate service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateAlreadyExistsException">
        /// The certificate has already been registered into the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateLimitExceededException">
        /// The certificate could not be added because the certificate limit has been reached.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidCertificateException">
        /// The certificate PEM that was provided has incorrect encoding.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        public virtual Task<RegisterCertificateResponse> RegisterCertificateAsync(RegisterCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterEventTopic

        internal virtual RegisterEventTopicResponse RegisterEventTopic(RegisterEventTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<RegisterEventTopicResponse>(request, options);
        }



        /// <summary>
        /// Associates a directory with an SNS topic. This establishes the directory as a publisher
        /// to the specified SNS topic. You can then receive email or text (SMS) messages when
        /// the status of your directory changes. You get notified if your directory goes from
        /// an Active status to an Impaired or Inoperable status. You also receive a notification
        /// when the directory returns to an Active status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterEventTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterEventTopic service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterEventTopic">REST API Reference for RegisterEventTopic Operation</seealso>
        public virtual Task<RegisterEventTopicResponse> RegisterEventTopicAsync(RegisterEventTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterEventTopicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectSharedDirectory

        internal virtual RejectSharedDirectoryResponse RejectSharedDirectory(RejectSharedDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSharedDirectoryResponseUnmarshaller.Instance;

            return Invoke<RejectSharedDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Rejects a directory sharing request that was sent from the directory owner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSharedDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectSharedDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryAlreadySharedException">
        /// The specified directory has already been shared with this AWS account.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RejectSharedDirectory">REST API Reference for RejectSharedDirectory Operation</seealso>
        public virtual Task<RejectSharedDirectoryResponse> RejectSharedDirectoryAsync(RejectSharedDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSharedDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<RejectSharedDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveIpRoutes

        internal virtual RemoveIpRoutesResponse RemoveIpRoutes(RemoveIpRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return Invoke<RemoveIpRoutesResponse>(request, options);
        }



        /// <summary>
        /// Removes IP address blocks from a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveIpRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveIpRoutes service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveIpRoutes">REST API Reference for RemoveIpRoutes Operation</seealso>
        public virtual Task<RemoveIpRoutesResponse> RemoveIpRoutesAsync(RemoveIpRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveIpRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveRegion

        internal virtual RemoveRegionResponse RemoveRegion(RemoveRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRegionResponseUnmarshaller.Instance;

            return Invoke<RemoveRegionResponse>(request, options);
        }



        /// <summary>
        /// Stops all replication and removes the domain controllers from the specified Region.
        /// You cannot remove the primary Region with this operation. Instead, use the <code>DeleteDirectory</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveRegion service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// Client authentication is not available in this region at this time.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveRegion">REST API Reference for RemoveRegion Operation</seealso>
        public virtual Task<RemoveRegionResponse> RemoveRegionAsync(RemoveRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRegionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveRegionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetUserPassword

        internal virtual ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<ResetUserPasswordResponse>(request, options);
        }



        /// <summary>
        /// Resets the password for any user in your AWS Managed Microsoft AD or Simple AD directory.
        /// 
        ///  
        /// <para>
        /// You can reset the password for any user in your directory with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Simple AD, you cannot reset the password for any user that is a member of either
        /// the <b>Domain Admins</b> or <b>Enterprise Admins</b> group except for the administrator
        /// user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For AWS Managed Microsoft AD, you can only reset the password for a user that is in
        /// an OU based off of the NetBIOS name that you typed when you created your directory.
        /// For example, you cannot reset the password for a user in the <b>AWS Reserved</b> OU.
        /// For more information about the OU structure for an AWS Managed Microsoft AD directory,
        /// see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ms_ad_getting_started_what_gets_created.html">What
        /// Gets Created</a> in the <i>AWS Directory Service Administration Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetUserPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetUserPassword service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidPasswordException">
        /// The new password provided by the user does not meet the password complexity requirements
        /// defined in your directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UserDoesNotExistException">
        /// The user provided a username that does not exist in your directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ResetUserPassword">REST API Reference for ResetUserPassword Operation</seealso>
        public virtual Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ResetUserPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreFromSnapshot

        internal virtual RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Restores a directory using an existing directory snapshot.
        /// 
        ///  
        /// <para>
        /// When you restore a directory from a snapshot, any changes made to the directory after
        /// the snapshot date are overwritten.
        /// </para>
        ///  
        /// <para>
        /// This action returns as soon as the restore operation is initiated. You can monitor
        /// the progress of the restore operation by calling the <a>DescribeDirectories</a> operation
        /// with the directory identifier. When the <b>DirectoryDescription.Stage</b> value changes
        /// to <code>Active</code>, the restore operation is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreFromSnapshot service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual Task<RestoreFromSnapshotResponse> RestoreFromSnapshotAsync(RestoreFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ShareDirectory

        internal virtual ShareDirectoryResponse ShareDirectory(ShareDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ShareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShareDirectoryResponseUnmarshaller.Instance;

            return Invoke<ShareDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Shares a specified directory (<code>DirectoryId</code>) in your AWS account (directory
        /// owner) with another AWS account (directory consumer). With this operation you can
        /// use your directory from any AWS account and from any Amazon VPC within an AWS Region.
        /// 
        ///  
        /// <para>
        /// When you share your AWS Managed Microsoft AD directory, AWS Directory Service creates
        /// a shared directory in the directory consumer account. This shared directory contains
        /// the metadata to provide access to the directory within the directory owner account.
        /// The shared directory is visible in all VPCs in the directory consumer account.
        /// </para>
        ///  
        /// <para>
        /// The <code>ShareMethod</code> parameter determines whether the specified directory
        /// can be shared between AWS accounts inside the same AWS organization (<code>ORGANIZATIONS</code>).
        /// It also determines whether you can share the directory with any other AWS account
        /// either inside or outside of the organization (<code>HANDSHAKE</code>).
        /// </para>
        ///  
        /// <para>
        /// The <code>ShareNotes</code> parameter is only used when <code>HANDSHAKE</code> is
        /// called, which sends a directory sharing request to the directory consumer. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShareDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ShareDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// Client authentication is not available in this region at this time.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryAlreadySharedException">
        /// The specified directory has already been shared with this AWS account.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidTargetException">
        /// The specified shared target is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.OrganizationsException">
        /// Exception encountered while trying to access your AWS organization.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ShareLimitExceededException">
        /// The maximum number of AWS accounts that you can share with this directory has been
        /// reached.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ShareDirectory">REST API Reference for ShareDirectory Operation</seealso>
        public virtual Task<ShareDirectoryResponse> ShareDirectoryAsync(ShareDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ShareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShareDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<ShareDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSchemaExtension

        internal virtual StartSchemaExtensionResponse StartSchemaExtension(StartSchemaExtensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<StartSchemaExtensionResponse>(request, options);
        }



        /// <summary>
        /// Applies a schema extension to a Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaExtension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSchemaExtension service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.SnapshotLimitExceededException">
        /// The maximum number of manual snapshots for the directory has been reached. You can
        /// use the <a>GetSnapshotLimits</a> operation to determine the snapshot limits for a
        /// directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/StartSchemaExtension">REST API Reference for StartSchemaExtension Operation</seealso>
        public virtual Task<StartSchemaExtensionResponse> StartSchemaExtensionAsync(StartSchemaExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<StartSchemaExtensionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnshareDirectory

        internal virtual UnshareDirectoryResponse UnshareDirectory(UnshareDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnshareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnshareDirectoryResponseUnmarshaller.Instance;

            return Invoke<UnshareDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Stops the directory sharing between the directory owner and consumer accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnshareDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnshareDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryNotSharedException">
        /// The specified directory has not been shared with this AWS account.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidTargetException">
        /// The specified shared target is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UnshareDirectory">REST API Reference for UnshareDirectory Operation</seealso>
        public virtual Task<UnshareDirectoryResponse> UnshareDirectoryAsync(UnshareDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnshareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnshareDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<UnshareDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConditionalForwarder

        internal virtual UpdateConditionalForwarderResponse UpdateConditionalForwarder(UpdateConditionalForwarderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<UpdateConditionalForwarderResponse>(request, options);
        }



        /// <summary>
        /// Updates a conditional forwarder that has been set up for your AWS directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConditionalForwarder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConditionalForwarder service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateConditionalForwarder">REST API Reference for UpdateConditionalForwarder Operation</seealso>
        public virtual Task<UpdateConditionalForwarderResponse> UpdateConditionalForwarderAsync(UpdateConditionalForwarderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConditionalForwarderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNumberOfDomainControllers

        internal virtual UpdateNumberOfDomainControllersResponse UpdateNumberOfDomainControllers(UpdateNumberOfDomainControllersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return Invoke<UpdateNumberOfDomainControllersResponse>(request, options);
        }



        /// <summary>
        /// Adds or removes domain controllers to or from the directory. Based on the difference
        /// between current value and new value (provided through this API call), domain controllers
        /// will be added or removed. It may take up to 45 minutes for any new domain controllers
        /// to become fully active once the requested number of domain controllers is updated.
        /// During this time, you cannot make another update request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNumberOfDomainControllers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNumberOfDomainControllers service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DomainControllerLimitExceededException">
        /// The maximum allowed number of domain controllers per directory was exceeded. The default
        /// limit per directory is 20 domain controllers.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateNumberOfDomainControllers">REST API Reference for UpdateNumberOfDomainControllers Operation</seealso>
        public virtual Task<UpdateNumberOfDomainControllersResponse> UpdateNumberOfDomainControllersAsync(UpdateNumberOfDomainControllersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNumberOfDomainControllersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRadius

        internal virtual UpdateRadiusResponse UpdateRadius(UpdateRadiusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return Invoke<UpdateRadiusResponse>(request, options);
        }



        /// <summary>
        /// Updates the Remote Authentication Dial In User Service (RADIUS) server information
        /// for an AD Connector or Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRadius service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRadius service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateRadius">REST API Reference for UpdateRadius Operation</seealso>
        public virtual Task<UpdateRadiusResponse> UpdateRadiusAsync(UpdateRadiusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRadiusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrust

        internal virtual UpdateTrustResponse UpdateTrust(UpdateTrustRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustResponseUnmarshaller.Instance;

            return Invoke<UpdateTrustResponse>(request, options);
        }



        /// <summary>
        /// Updates the trust that has been set up between your AWS Managed Microsoft AD directory
        /// and an on-premises Active Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrust service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrust service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateTrust">REST API Reference for UpdateTrust Operation</seealso>
        public virtual Task<UpdateTrustResponse> UpdateTrustAsync(UpdateTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrustResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifyTrust

        internal virtual VerifyTrustResponse VerifyTrust(VerifyTrustRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return Invoke<VerifyTrustResponse>(request, options);
        }



        /// <summary>
        /// AWS Directory Service for Microsoft Active Directory allows you to configure and verify
        /// trust relationships.
        /// 
        ///  
        /// <para>
        /// This action verifies a trust relationship between your AWS Managed Microsoft AD directory
        /// and an external domain.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyTrust service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyTrust service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/VerifyTrust">REST API Reference for VerifyTrust Operation</seealso>
        public virtual Task<VerifyTrustResponse> VerifyTrustAsync(VerifyTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyTrustResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}