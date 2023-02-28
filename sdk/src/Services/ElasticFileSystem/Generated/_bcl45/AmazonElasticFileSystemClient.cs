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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticFileSystem.Model;
using Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations;
using Amazon.ElasticFileSystem.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticFileSystem
{
    /// <summary>
    /// Implementation for accessing ElasticFileSystem
    ///
    /// Amazon Elastic File System 
    /// <para>
    /// Amazon Elastic File System (Amazon EFS) provides simple, scalable file storage for
    /// use with Amazon EC2 Linux and Mac instances in the Amazon Web Services Cloud. With
    /// Amazon EFS, storage capacity is elastic, growing and shrinking automatically as you
    /// add and remove files, so that your applications have the storage they need, when they
    /// need it. For more information, see the <a href="https://docs.aws.amazon.com/efs/latest/ug/api-reference.html">Amazon
    /// Elastic File System API Reference</a> and the <a href="https://docs.aws.amazon.com/efs/latest/ug/whatisefs.html">Amazon
    /// Elastic File System User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonElasticFileSystemClient : AmazonServiceClient, IAmazonElasticFileSystem
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticFileSystemMetadata();
        private IElasticFileSystemPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElasticFileSystemPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElasticFileSystemPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with the credentials loaded from the application's
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
        public AmazonElasticFileSystemClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticFileSystemConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with the credentials loaded from the application's
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
        public AmazonElasticFileSystemClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticFileSystemConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticFileSystemClient Configuration Object</param>
        public AmazonElasticFileSystemClient(AmazonElasticFileSystemConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticFileSystemClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticFileSystemConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticFileSystemClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticFileSystemConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with AWS Credentials and an
        /// AmazonElasticFileSystemClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticFileSystemClient Configuration Object</param>
        public AmazonElasticFileSystemClient(AWSCredentials credentials, AmazonElasticFileSystemConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticFileSystemClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticFileSystemConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticFileSystemClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticFileSystemConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticFileSystemClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticFileSystemClient Configuration Object</param>
        public AmazonElasticFileSystemClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticFileSystemConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticFileSystemClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticFileSystemConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticFileSystemClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticFileSystemConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticFileSystemClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticFileSystemClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticFileSystemClient Configuration Object</param>
        public AmazonElasticFileSystemClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticFileSystemConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.ElasticFileSystem.Internal.IdempotencyHandler());
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticFileSystemEndpointResolver());
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


        #region  CreateAccessPoint


        /// <summary>
        /// Creates an EFS access point. An access point is an application-specific view into
        /// an EFS file system that applies an operating system user and group, and a file system
        /// path, to any file system request made through the access point. The operating system
        /// user and group override any identity information provided by the NFS client. The file
        /// system path is exposed as the access point's root directory. Applications using the
        /// access point can only access data in the application's own directory and any subdirectories.
        /// To learn more, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-access-points.html">Mounting
        /// a file system using EFS access points</a>.
        /// 
        ///  <note> 
        /// <para>
        /// If multiple requests to create access points on the same file system are sent in quick
        /// succession, and the file system is near the limit of 1000 access points, you may experience
        /// a throttling response for these requests. This is to ensure that the file system does
        /// not exceed the stated access point limit.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:CreateAccessPoint</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPoint service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointAlreadyExistsException">
        /// Returned if the access point that you are trying to create already exists, with the
        /// creation token you provided in the request.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointLimitExceededException">
        /// Returned if the Amazon Web Services account has already created the maximum number
        /// of access points allowed per file system. For more informaton, see <a href="https://docs.aws.amazon.com/efs/latest/ug/limits.html#limits-efs-resources-per-account-per-region">https://docs.aws.amazon.com/efs/latest/ug/limits.html#limits-efs-resources-per-account-per-region</a>.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThrottlingException">
        /// Returned when the <code>CreateAccessPoint</code> API action is called too quickly
        /// and the number of Access Points on the file system is nearing the <a href="https://docs.aws.amazon.com/efs/latest/ug/limits.html#limits-efs-resources-per-account-per-region">limit
        /// of 120</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        public virtual CreateAccessPointResponse CreateAccessPoint(CreateAccessPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPointResponseUnmarshaller.Instance;

            return Invoke<CreateAccessPointResponse>(request, options);
        }


        /// <summary>
        /// Creates an EFS access point. An access point is an application-specific view into
        /// an EFS file system that applies an operating system user and group, and a file system
        /// path, to any file system request made through the access point. The operating system
        /// user and group override any identity information provided by the NFS client. The file
        /// system path is exposed as the access point's root directory. Applications using the
        /// access point can only access data in the application's own directory and any subdirectories.
        /// To learn more, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-access-points.html">Mounting
        /// a file system using EFS access points</a>.
        /// 
        ///  <note> 
        /// <para>
        /// If multiple requests to create access points on the same file system are sent in quick
        /// succession, and the file system is near the limit of 1000 access points, you may experience
        /// a throttling response for these requests. This is to ensure that the file system does
        /// not exceed the stated access point limit.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:CreateAccessPoint</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPoint service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointAlreadyExistsException">
        /// Returned if the access point that you are trying to create already exists, with the
        /// creation token you provided in the request.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointLimitExceededException">
        /// Returned if the Amazon Web Services account has already created the maximum number
        /// of access points allowed per file system. For more informaton, see <a href="https://docs.aws.amazon.com/efs/latest/ug/limits.html#limits-efs-resources-per-account-per-region">https://docs.aws.amazon.com/efs/latest/ug/limits.html#limits-efs-resources-per-account-per-region</a>.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThrottlingException">
        /// Returned when the <code>CreateAccessPoint</code> API action is called too quickly
        /// and the number of Access Points on the file system is nearing the <a href="https://docs.aws.amazon.com/efs/latest/ug/limits.html#limits-efs-resources-per-account-per-region">limit
        /// of 120</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        public virtual Task<CreateAccessPointResponse> CreateAccessPointAsync(CreateAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFileSystem


        /// <summary>
        /// Creates a new, empty file system. The operation requires a creation token in the request
        /// that Amazon EFS uses to ensure idempotent creation (calling the operation with same
        /// creation token has no effect). If a file system does not currently exist that is owned
        /// by the caller's Amazon Web Services account with the specified creation token, this
        /// operation does the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty file system. The file system will have an Amazon EFS assigned
        /// ID, and an initial lifecycle state <code>creating</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns with the description of the created file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Otherwise, this operation returns a <code>FileSystemAlreadyExists</code> error with
        /// the ID of the existing file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// For basic use cases, you can use a randomly generated UUID for the creation token.
        /// </para>
        ///  </note> 
        /// <para>
        ///  The idempotent operation allows you to retry a <code>CreateFileSystem</code> call
        /// without risk of creating an extra file system. This can happen when an initial call
        /// fails in a way that leaves it uncertain whether or not a file system was actually
        /// created. An example might be that a transport level timeout occurred or your connection
        /// was reset. As long as you use the same creation token, if the initial call had succeeded
        /// in creating a file system, the client can learn of its existence from the <code>FileSystemAlreadyExists</code>
        /// error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/creating-using-create-fs.html#creating-using-create-fs-part1">Creating
        /// a file system</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
        /// is still <code>creating</code>. You can check the file system creation status by calling
        /// the <a>DescribeFileSystems</a> operation, which among other things returns the file
        /// system state.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation accepts an optional <code>PerformanceMode</code> parameter that you
        /// choose for your file system. We recommend <code>generalPurpose</code> performance
        /// mode for most file systems. File systems using the <code>maxIO</code> performance
        /// mode can scale to higher levels of aggregate throughput and operations per second
        /// with a tradeoff of slightly higher latencies for most file operations. The performance
        /// mode can't be changed after the file system has been created. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/performance.html#performancemodes.html">Amazon
        /// EFS performance modes</a>.
        /// </para>
        ///  
        /// <para>
        /// You can set the throughput mode for the file system using the <code>ThroughputMode</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// After the file system is fully created, Amazon EFS sets its lifecycle state to <code>available</code>,
        /// at which point you can create one or more mount targets for the file system in your
        /// VPC. For more information, see <a>CreateMountTarget</a>. You mount your Amazon EFS
        /// file system on an EC2 instances in your VPC by using the mount target. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon EFS:
        /// How it Works</a>. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:CreateFileSystem</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="creationToken">A string of up to 64 ASCII characters. Amazon EFS uses this to ensure idempotent creation.</param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemAlreadyExistsException">
        /// Returned if the file system you are trying to create already exists, with the creation
        /// token you provided.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemLimitExceededException">
        /// Returned if the Amazon Web Services account has already created the maximum number
        /// of file systems allowed per account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InsufficientThroughputCapacityException">
        /// Returned if there's not enough capacity to provision additional throughput. This value
        /// might be returned when you try to create a file system in provisioned throughput mode,
        /// when you attempt to increase the provisioned throughput of an existing file system,
        /// or when you attempt to change an existing file system from Bursting Throughput to
        /// Provisioned Throughput mode. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThroughputLimitExceededException">
        /// Returned if the throughput mode or amount of provisioned throughput can't be changed
        /// because the throughput limit of 1024 MiB/s has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.UnsupportedAvailabilityZoneException">
        /// Returned if the requested Amazon EFS functionality is not available in the specified
        /// Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        public virtual CreateFileSystemResponse CreateFileSystem(string creationToken)
        {
            var request = new CreateFileSystemRequest();
            request.CreationToken = creationToken;
            return CreateFileSystem(request);
        }


        /// <summary>
        /// Creates a new, empty file system. The operation requires a creation token in the request
        /// that Amazon EFS uses to ensure idempotent creation (calling the operation with same
        /// creation token has no effect). If a file system does not currently exist that is owned
        /// by the caller's Amazon Web Services account with the specified creation token, this
        /// operation does the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty file system. The file system will have an Amazon EFS assigned
        /// ID, and an initial lifecycle state <code>creating</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns with the description of the created file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Otherwise, this operation returns a <code>FileSystemAlreadyExists</code> error with
        /// the ID of the existing file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// For basic use cases, you can use a randomly generated UUID for the creation token.
        /// </para>
        ///  </note> 
        /// <para>
        ///  The idempotent operation allows you to retry a <code>CreateFileSystem</code> call
        /// without risk of creating an extra file system. This can happen when an initial call
        /// fails in a way that leaves it uncertain whether or not a file system was actually
        /// created. An example might be that a transport level timeout occurred or your connection
        /// was reset. As long as you use the same creation token, if the initial call had succeeded
        /// in creating a file system, the client can learn of its existence from the <code>FileSystemAlreadyExists</code>
        /// error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/creating-using-create-fs.html#creating-using-create-fs-part1">Creating
        /// a file system</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
        /// is still <code>creating</code>. You can check the file system creation status by calling
        /// the <a>DescribeFileSystems</a> operation, which among other things returns the file
        /// system state.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation accepts an optional <code>PerformanceMode</code> parameter that you
        /// choose for your file system. We recommend <code>generalPurpose</code> performance
        /// mode for most file systems. File systems using the <code>maxIO</code> performance
        /// mode can scale to higher levels of aggregate throughput and operations per second
        /// with a tradeoff of slightly higher latencies for most file operations. The performance
        /// mode can't be changed after the file system has been created. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/performance.html#performancemodes.html">Amazon
        /// EFS performance modes</a>.
        /// </para>
        ///  
        /// <para>
        /// You can set the throughput mode for the file system using the <code>ThroughputMode</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// After the file system is fully created, Amazon EFS sets its lifecycle state to <code>available</code>,
        /// at which point you can create one or more mount targets for the file system in your
        /// VPC. For more information, see <a>CreateMountTarget</a>. You mount your Amazon EFS
        /// file system on an EC2 instances in your VPC by using the mount target. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon EFS:
        /// How it Works</a>. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:CreateFileSystem</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem service method.</param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemAlreadyExistsException">
        /// Returned if the file system you are trying to create already exists, with the creation
        /// token you provided.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemLimitExceededException">
        /// Returned if the Amazon Web Services account has already created the maximum number
        /// of file systems allowed per account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InsufficientThroughputCapacityException">
        /// Returned if there's not enough capacity to provision additional throughput. This value
        /// might be returned when you try to create a file system in provisioned throughput mode,
        /// when you attempt to increase the provisioned throughput of an existing file system,
        /// or when you attempt to change an existing file system from Bursting Throughput to
        /// Provisioned Throughput mode. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThroughputLimitExceededException">
        /// Returned if the throughput mode or amount of provisioned throughput can't be changed
        /// because the throughput limit of 1024 MiB/s has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.UnsupportedAvailabilityZoneException">
        /// Returned if the requested Amazon EFS functionality is not available in the specified
        /// Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        public virtual CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileSystemResponseUnmarshaller.Instance;

            return Invoke<CreateFileSystemResponse>(request, options);
        }


        /// <summary>
        /// Creates a new, empty file system. The operation requires a creation token in the request
        /// that Amazon EFS uses to ensure idempotent creation (calling the operation with same
        /// creation token has no effect). If a file system does not currently exist that is owned
        /// by the caller's Amazon Web Services account with the specified creation token, this
        /// operation does the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty file system. The file system will have an Amazon EFS assigned
        /// ID, and an initial lifecycle state <code>creating</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns with the description of the created file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Otherwise, this operation returns a <code>FileSystemAlreadyExists</code> error with
        /// the ID of the existing file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// For basic use cases, you can use a randomly generated UUID for the creation token.
        /// </para>
        ///  </note> 
        /// <para>
        ///  The idempotent operation allows you to retry a <code>CreateFileSystem</code> call
        /// without risk of creating an extra file system. This can happen when an initial call
        /// fails in a way that leaves it uncertain whether or not a file system was actually
        /// created. An example might be that a transport level timeout occurred or your connection
        /// was reset. As long as you use the same creation token, if the initial call had succeeded
        /// in creating a file system, the client can learn of its existence from the <code>FileSystemAlreadyExists</code>
        /// error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/creating-using-create-fs.html#creating-using-create-fs-part1">Creating
        /// a file system</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
        /// is still <code>creating</code>. You can check the file system creation status by calling
        /// the <a>DescribeFileSystems</a> operation, which among other things returns the file
        /// system state.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation accepts an optional <code>PerformanceMode</code> parameter that you
        /// choose for your file system. We recommend <code>generalPurpose</code> performance
        /// mode for most file systems. File systems using the <code>maxIO</code> performance
        /// mode can scale to higher levels of aggregate throughput and operations per second
        /// with a tradeoff of slightly higher latencies for most file operations. The performance
        /// mode can't be changed after the file system has been created. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/performance.html#performancemodes.html">Amazon
        /// EFS performance modes</a>.
        /// </para>
        ///  
        /// <para>
        /// You can set the throughput mode for the file system using the <code>ThroughputMode</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// After the file system is fully created, Amazon EFS sets its lifecycle state to <code>available</code>,
        /// at which point you can create one or more mount targets for the file system in your
        /// VPC. For more information, see <a>CreateMountTarget</a>. You mount your Amazon EFS
        /// file system on an EC2 instances in your VPC by using the mount target. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon EFS:
        /// How it Works</a>. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:CreateFileSystem</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="creationToken">A string of up to 64 ASCII characters. Amazon EFS uses this to ensure idempotent creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemAlreadyExistsException">
        /// Returned if the file system you are trying to create already exists, with the creation
        /// token you provided.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemLimitExceededException">
        /// Returned if the Amazon Web Services account has already created the maximum number
        /// of file systems allowed per account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InsufficientThroughputCapacityException">
        /// Returned if there's not enough capacity to provision additional throughput. This value
        /// might be returned when you try to create a file system in provisioned throughput mode,
        /// when you attempt to increase the provisioned throughput of an existing file system,
        /// or when you attempt to change an existing file system from Bursting Throughput to
        /// Provisioned Throughput mode. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThroughputLimitExceededException">
        /// Returned if the throughput mode or amount of provisioned throughput can't be changed
        /// because the throughput limit of 1024 MiB/s has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.UnsupportedAvailabilityZoneException">
        /// Returned if the requested Amazon EFS functionality is not available in the specified
        /// Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        public virtual Task<CreateFileSystemResponse> CreateFileSystemAsync(string creationToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateFileSystemRequest();
            request.CreationToken = creationToken;
            return CreateFileSystemAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates a new, empty file system. The operation requires a creation token in the request
        /// that Amazon EFS uses to ensure idempotent creation (calling the operation with same
        /// creation token has no effect). If a file system does not currently exist that is owned
        /// by the caller's Amazon Web Services account with the specified creation token, this
        /// operation does the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty file system. The file system will have an Amazon EFS assigned
        /// ID, and an initial lifecycle state <code>creating</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns with the description of the created file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Otherwise, this operation returns a <code>FileSystemAlreadyExists</code> error with
        /// the ID of the existing file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// For basic use cases, you can use a randomly generated UUID for the creation token.
        /// </para>
        ///  </note> 
        /// <para>
        ///  The idempotent operation allows you to retry a <code>CreateFileSystem</code> call
        /// without risk of creating an extra file system. This can happen when an initial call
        /// fails in a way that leaves it uncertain whether or not a file system was actually
        /// created. An example might be that a transport level timeout occurred or your connection
        /// was reset. As long as you use the same creation token, if the initial call had succeeded
        /// in creating a file system, the client can learn of its existence from the <code>FileSystemAlreadyExists</code>
        /// error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/creating-using-create-fs.html#creating-using-create-fs-part1">Creating
        /// a file system</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
        /// is still <code>creating</code>. You can check the file system creation status by calling
        /// the <a>DescribeFileSystems</a> operation, which among other things returns the file
        /// system state.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation accepts an optional <code>PerformanceMode</code> parameter that you
        /// choose for your file system. We recommend <code>generalPurpose</code> performance
        /// mode for most file systems. File systems using the <code>maxIO</code> performance
        /// mode can scale to higher levels of aggregate throughput and operations per second
        /// with a tradeoff of slightly higher latencies for most file operations. The performance
        /// mode can't be changed after the file system has been created. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/performance.html#performancemodes.html">Amazon
        /// EFS performance modes</a>.
        /// </para>
        ///  
        /// <para>
        /// You can set the throughput mode for the file system using the <code>ThroughputMode</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// After the file system is fully created, Amazon EFS sets its lifecycle state to <code>available</code>,
        /// at which point you can create one or more mount targets for the file system in your
        /// VPC. For more information, see <a>CreateMountTarget</a>. You mount your Amazon EFS
        /// file system on an EC2 instances in your VPC by using the mount target. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon EFS:
        /// How it Works</a>. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:CreateFileSystem</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemAlreadyExistsException">
        /// Returned if the file system you are trying to create already exists, with the creation
        /// token you provided.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemLimitExceededException">
        /// Returned if the Amazon Web Services account has already created the maximum number
        /// of file systems allowed per account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InsufficientThroughputCapacityException">
        /// Returned if there's not enough capacity to provision additional throughput. This value
        /// might be returned when you try to create a file system in provisioned throughput mode,
        /// when you attempt to increase the provisioned throughput of an existing file system,
        /// or when you attempt to change an existing file system from Bursting Throughput to
        /// Provisioned Throughput mode. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThroughputLimitExceededException">
        /// Returned if the throughput mode or amount of provisioned throughput can't be changed
        /// because the throughput limit of 1024 MiB/s has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.UnsupportedAvailabilityZoneException">
        /// Returned if the requested Amazon EFS functionality is not available in the specified
        /// Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        public virtual Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileSystemResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFileSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMountTarget


        /// <summary>
        /// Creates a mount target for a file system. You can then mount the file system on EC2
        /// instances by using the mount target.
        /// 
        ///  
        /// <para>
        /// You can create one mount target in each Availability Zone in your VPC. All EC2 instances
        /// in a VPC within a given Availability Zone share a single mount target for a given
        /// file system. If you have multiple subnets in an Availability Zone, you create a mount
        /// target in one of the subnets. EC2 instances do not need to be in the same subnet as
        /// the mount target in order to access their file system.
        /// </para>
        ///  
        /// <para>
        /// You can create only one mount target for an EFS file system using One Zone storage
        /// classes. You must create that mount target in the same Availability Zone in which
        /// the file system is located. Use the <code>AvailabilityZoneName</code> and <code>AvailabiltyZoneId</code>
        /// properties in the <a>DescribeFileSystems</a> response object to get this information.
        /// Use the <code>subnetId</code> associated with the file system's Availability Zone
        /// when creating the mount target.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon
        /// EFS: How it Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// To create a mount target for a file system, the file system's lifecycle state must
        /// be <code>available</code>. For more information, see <a>DescribeFileSystems</a>.
        /// </para>
        ///  
        /// <para>
        /// In the request, provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The file system ID for which you are creating the mount target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A subnet ID, which determines the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The VPC in which Amazon EFS creates the mount target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Availability Zone in which Amazon EFS creates the mount target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address range from which Amazon EFS selects the IP address of the mount target
        /// (if you don't specify an IP address in the request)
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// After creating the mount target, Amazon EFS returns a response that includes, a <code>MountTargetId</code>
        /// and an <code>IpAddress</code>. You use this IP address when mounting the file system
        /// in an EC2 instance. You can also use the mount target's DNS name when mounting the
        /// file system. The EC2 instance on which you mount the file system by using the mount
        /// target can resolve the mount target's DNS name to its IP address. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html#how-it-works-implementation">How
        /// it Works: Implementation Overview</a>. 
        /// </para>
        ///  
        /// <para>
        /// Note that you can create mount targets for a file system in only one VPC, and there
        /// can be only one mount target per Availability Zone. That is, if the file system already
        /// has one or more mount targets created for it, the subnet specified in the request
        /// to add another mount target must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must belong to the same VPC as the subnets of the existing mount targets
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not be in the same Availability Zone as any of the subnets of the existing mount
        /// targets
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the request satisfies the requirements, Amazon EFS does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new mount target in the specified subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Also creates a new network interface in the subnet as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the request provides an <code>IpAddress</code>, Amazon EFS assigns that IP address
        /// to the network interface. Otherwise, Amazon EFS assigns a free address in the subnet
        /// (in the same way that the Amazon EC2 <code>CreateNetworkInterface</code> call does
        /// when a request does not specify a primary private IP address).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the request provides <code>SecurityGroups</code>, this network interface is associated
        /// with those security groups. Otherwise, it belongs to the default security group for
        /// the subnet's VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assigns the description <code>Mount target <i>fsmt-id</i> for file system <i>fs-id</i>
        /// </code> where <code> <i>fsmt-id</i> </code> is the mount target ID, and <code> <i>fs-id</i>
        /// </code> is the <code>FileSystemId</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sets the <code>requesterManaged</code> property of the network interface to <code>true</code>,
        /// and the <code>requesterId</code> value to <code>EFS</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each Amazon EFS mount target has one corresponding requester-managed EC2 network interface.
        /// After the network interface is created, Amazon EFS sets the <code>NetworkInterfaceId</code>
        /// field in the mount target's description to the network interface ID, and the <code>IpAddress</code>
        /// field to its address. If network interface creation fails, the entire <code>CreateMountTarget</code>
        /// operation fails.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>CreateMountTarget</code> call returns only after creating the network interface,
        /// but while the mount target state is still <code>creating</code>, you can check the
        /// mount target creation status by calling the <a>DescribeMountTargets</a> operation,
        /// which among other things returns the mount target state.
        /// </para>
        ///  </note> 
        /// <para>
        /// We recommend that you create a mount target in each of the Availability Zones. There
        /// are cost considerations for using a file system in an Availability Zone through a
        /// mount target created in another Availability Zone. For more information, see <a href="http://aws.amazon.com/efs/">Amazon
        /// EFS</a>. In addition, by always using a mount target local to the instance's Availability
        /// Zone, you eliminate a partial failure scenario. If the Availability Zone in which
        /// your mount target is created goes down, then you can't access your file system through
        /// that mount target. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the following action on the file system:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:CreateMountTarget</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation also requires permissions for the following Amazon EC2 actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DescribeSubnets</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeNetworkInterfaces</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:CreateNetworkInterface</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMountTarget service method.</param>
        /// 
        /// <returns>The response from the CreateMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AvailabilityZonesMismatchException">
        /// Returned if the Availability Zone that was specified for a mount target is different
        /// from the Availability Zone that was specified for One Zone storage. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/availability-durability.html">Regional
        /// and One Zone storage redundancy</a>.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IpAddressInUseException">
        /// Returned if the request specified an <code>IpAddress</code> that is already in use
        /// in the subnet.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetConflictException">
        /// Returned if the mount target would violate one of the specified restrictions based
        /// on the file system's existing mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.NetworkInterfaceLimitExceededException">
        /// The calling account has reached the limit for elastic network interfaces for the specific
        /// Amazon Web Services Region. Either delete some network interfaces or request that
        /// the account quota be raised. For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Appendix_Limits.html">Amazon
        /// VPC Quotas</a> in the <i>Amazon VPC User Guide</i> (see the <b>Network interfaces
        /// per Region</b> entry in the <b>Network interfaces</b> table).
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.NoFreeAddressesInSubnetException">
        /// Returned if <code>IpAddress</code> was not specified in the request and there are
        /// no free IP addresses in the subnet.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupLimitExceededException">
        /// Returned if the size of <code>SecurityGroups</code> specified in the request is greater
        /// than five.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupNotFoundException">
        /// Returned if one of the specified security groups doesn't exist in the subnet's virtual
        /// private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SubnetNotFoundException">
        /// Returned if there is no subnet with ID <code>SubnetId</code> provided in the request.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.UnsupportedAvailabilityZoneException">
        /// Returned if the requested Amazon EFS functionality is not available in the specified
        /// Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateMountTarget">REST API Reference for CreateMountTarget Operation</seealso>
        public virtual CreateMountTargetResponse CreateMountTarget(CreateMountTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMountTargetResponseUnmarshaller.Instance;

            return Invoke<CreateMountTargetResponse>(request, options);
        }


        /// <summary>
        /// Creates a mount target for a file system. You can then mount the file system on EC2
        /// instances by using the mount target.
        /// 
        ///  
        /// <para>
        /// You can create one mount target in each Availability Zone in your VPC. All EC2 instances
        /// in a VPC within a given Availability Zone share a single mount target for a given
        /// file system. If you have multiple subnets in an Availability Zone, you create a mount
        /// target in one of the subnets. EC2 instances do not need to be in the same subnet as
        /// the mount target in order to access their file system.
        /// </para>
        ///  
        /// <para>
        /// You can create only one mount target for an EFS file system using One Zone storage
        /// classes. You must create that mount target in the same Availability Zone in which
        /// the file system is located. Use the <code>AvailabilityZoneName</code> and <code>AvailabiltyZoneId</code>
        /// properties in the <a>DescribeFileSystems</a> response object to get this information.
        /// Use the <code>subnetId</code> associated with the file system's Availability Zone
        /// when creating the mount target.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html">Amazon
        /// EFS: How it Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// To create a mount target for a file system, the file system's lifecycle state must
        /// be <code>available</code>. For more information, see <a>DescribeFileSystems</a>.
        /// </para>
        ///  
        /// <para>
        /// In the request, provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The file system ID for which you are creating the mount target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A subnet ID, which determines the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The VPC in which Amazon EFS creates the mount target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Availability Zone in which Amazon EFS creates the mount target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address range from which Amazon EFS selects the IP address of the mount target
        /// (if you don't specify an IP address in the request)
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// After creating the mount target, Amazon EFS returns a response that includes, a <code>MountTargetId</code>
        /// and an <code>IpAddress</code>. You use this IP address when mounting the file system
        /// in an EC2 instance. You can also use the mount target's DNS name when mounting the
        /// file system. The EC2 instance on which you mount the file system by using the mount
        /// target can resolve the mount target's DNS name to its IP address. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/how-it-works.html#how-it-works-implementation">How
        /// it Works: Implementation Overview</a>. 
        /// </para>
        ///  
        /// <para>
        /// Note that you can create mount targets for a file system in only one VPC, and there
        /// can be only one mount target per Availability Zone. That is, if the file system already
        /// has one or more mount targets created for it, the subnet specified in the request
        /// to add another mount target must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must belong to the same VPC as the subnets of the existing mount targets
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not be in the same Availability Zone as any of the subnets of the existing mount
        /// targets
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the request satisfies the requirements, Amazon EFS does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new mount target in the specified subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Also creates a new network interface in the subnet as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the request provides an <code>IpAddress</code>, Amazon EFS assigns that IP address
        /// to the network interface. Otherwise, Amazon EFS assigns a free address in the subnet
        /// (in the same way that the Amazon EC2 <code>CreateNetworkInterface</code> call does
        /// when a request does not specify a primary private IP address).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the request provides <code>SecurityGroups</code>, this network interface is associated
        /// with those security groups. Otherwise, it belongs to the default security group for
        /// the subnet's VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assigns the description <code>Mount target <i>fsmt-id</i> for file system <i>fs-id</i>
        /// </code> where <code> <i>fsmt-id</i> </code> is the mount target ID, and <code> <i>fs-id</i>
        /// </code> is the <code>FileSystemId</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sets the <code>requesterManaged</code> property of the network interface to <code>true</code>,
        /// and the <code>requesterId</code> value to <code>EFS</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each Amazon EFS mount target has one corresponding requester-managed EC2 network interface.
        /// After the network interface is created, Amazon EFS sets the <code>NetworkInterfaceId</code>
        /// field in the mount target's description to the network interface ID, and the <code>IpAddress</code>
        /// field to its address. If network interface creation fails, the entire <code>CreateMountTarget</code>
        /// operation fails.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>CreateMountTarget</code> call returns only after creating the network interface,
        /// but while the mount target state is still <code>creating</code>, you can check the
        /// mount target creation status by calling the <a>DescribeMountTargets</a> operation,
        /// which among other things returns the mount target state.
        /// </para>
        ///  </note> 
        /// <para>
        /// We recommend that you create a mount target in each of the Availability Zones. There
        /// are cost considerations for using a file system in an Availability Zone through a
        /// mount target created in another Availability Zone. For more information, see <a href="http://aws.amazon.com/efs/">Amazon
        /// EFS</a>. In addition, by always using a mount target local to the instance's Availability
        /// Zone, you eliminate a partial failure scenario. If the Availability Zone in which
        /// your mount target is created goes down, then you can't access your file system through
        /// that mount target. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the following action on the file system:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:CreateMountTarget</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation also requires permissions for the following Amazon EC2 actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DescribeSubnets</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeNetworkInterfaces</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:CreateNetworkInterface</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AvailabilityZonesMismatchException">
        /// Returned if the Availability Zone that was specified for a mount target is different
        /// from the Availability Zone that was specified for One Zone storage. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/availability-durability.html">Regional
        /// and One Zone storage redundancy</a>.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IpAddressInUseException">
        /// Returned if the request specified an <code>IpAddress</code> that is already in use
        /// in the subnet.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetConflictException">
        /// Returned if the mount target would violate one of the specified restrictions based
        /// on the file system's existing mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.NetworkInterfaceLimitExceededException">
        /// The calling account has reached the limit for elastic network interfaces for the specific
        /// Amazon Web Services Region. Either delete some network interfaces or request that
        /// the account quota be raised. For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Appendix_Limits.html">Amazon
        /// VPC Quotas</a> in the <i>Amazon VPC User Guide</i> (see the <b>Network interfaces
        /// per Region</b> entry in the <b>Network interfaces</b> table).
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.NoFreeAddressesInSubnetException">
        /// Returned if <code>IpAddress</code> was not specified in the request and there are
        /// no free IP addresses in the subnet.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupLimitExceededException">
        /// Returned if the size of <code>SecurityGroups</code> specified in the request is greater
        /// than five.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupNotFoundException">
        /// Returned if one of the specified security groups doesn't exist in the subnet's virtual
        /// private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SubnetNotFoundException">
        /// Returned if there is no subnet with ID <code>SubnetId</code> provided in the request.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.UnsupportedAvailabilityZoneException">
        /// Returned if the requested Amazon EFS functionality is not available in the specified
        /// Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateMountTarget">REST API Reference for CreateMountTarget Operation</seealso>
        public virtual Task<CreateMountTargetResponse> CreateMountTargetAsync(CreateMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMountTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMountTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationConfiguration


        /// <summary>
        /// Creates a replication configuration that replicates an existing EFS file system to
        /// a new, read-only file system. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-replication.html">Amazon
        /// EFS replication</a> in the <i>Amazon EFS User Guide</i>. The replication configuration
        /// specifies the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Source file system</b> - An existing EFS file system that you want replicated.
        /// The source file system cannot be a destination file system in an existing replication
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Destination file system configuration</b> - The configuration of the destination
        /// file system to which the source file system will be replicated. There can only be
        /// one destination file system in a replication configuration. The destination file system
        /// configuration consists of the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Web Services Region</b> - The Amazon Web Services Region in which the destination
        /// file system is created. Amazon EFS replication is available in all Amazon Web Services
        /// Regions that Amazon EFS is available in, except Africa (Cape Town), Asia Pacific (Hong
        /// Kong), Asia Pacific (Jakarta), Europe (Milan), and Middle East (Bahrain).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Availability Zone</b> - If you want the destination file system to use EFS One
        /// Zone availability and durability, you must specify the Availability Zone to create
        /// the file system in. For more information about EFS storage classes, see <a href="https://docs.aws.amazon.com/efs/latest/ug/storage-classes.html">
        /// Amazon EFS storage classes</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Encryption</b> - All destination file systems are created with encryption at rest
        /// enabled. You can specify the Key Management Service (KMS) key that is used to encrypt
        /// the destination file system. If you don't specify a KMS key, your service-managed
        /// KMS key for Amazon EFS is used. 
        /// </para>
        ///  <note> 
        /// <para>
        /// After the file system is created, you cannot change the KMS key.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> 
        /// <para>
        /// The following properties are set by default:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Performance mode</b> - The destination file system's performance mode matches
        /// that of the source file system, unless the destination file system uses EFS One Zone
        /// storage. In that case, the General Purpose performance mode is used. The performance
        /// mode cannot be changed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Throughput mode</b> - The destination file system's throughput mode matches that
        /// of the source file system. After the file system is created, you can modify the throughput
        /// mode.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following properties are turned off by default:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Lifecycle management</b> - EFS lifecycle management and EFS Intelligent-Tiering
        /// are not enabled on the destination file system. After the destination file system
        /// is created, you can enable EFS lifecycle management and EFS Intelligent-Tiering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Automatic backups</b> - Automatic daily backups not enabled on the destination
        /// file system. After the file system is created, you can change this setting.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-replication.html">Amazon
        /// EFS replication</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationConfiguration service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemLimitExceededException">
        /// Returned if the Amazon Web Services account has already created the maximum number
        /// of file systems allowed per account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InsufficientThroughputCapacityException">
        /// Returned if there's not enough capacity to provision additional throughput. This value
        /// might be returned when you try to create a file system in provisioned throughput mode,
        /// when you attempt to increase the provisioned throughput of an existing file system,
        /// or when you attempt to change an existing file system from Bursting Throughput to
        /// Provisioned Throughput mode. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ReplicationNotFoundException">
        /// Returned if the specified file system does not have a replication configuration.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThroughputLimitExceededException">
        /// Returned if the throughput mode or amount of provisioned throughput can't be changed
        /// because the throughput limit of 1024 MiB/s has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.UnsupportedAvailabilityZoneException">
        /// Returned if the requested Amazon EFS functionality is not available in the specified
        /// Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ValidationException">
        /// Returned if the Backup service is not available in the Amazon Web Services Region
        /// in which the request was made.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateReplicationConfiguration">REST API Reference for CreateReplicationConfiguration Operation</seealso>
        public virtual CreateReplicationConfigurationResponse CreateReplicationConfiguration(CreateReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a replication configuration that replicates an existing EFS file system to
        /// a new, read-only file system. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-replication.html">Amazon
        /// EFS replication</a> in the <i>Amazon EFS User Guide</i>. The replication configuration
        /// specifies the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Source file system</b> - An existing EFS file system that you want replicated.
        /// The source file system cannot be a destination file system in an existing replication
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Destination file system configuration</b> - The configuration of the destination
        /// file system to which the source file system will be replicated. There can only be
        /// one destination file system in a replication configuration. The destination file system
        /// configuration consists of the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Web Services Region</b> - The Amazon Web Services Region in which the destination
        /// file system is created. Amazon EFS replication is available in all Amazon Web Services
        /// Regions that Amazon EFS is available in, except Africa (Cape Town), Asia Pacific (Hong
        /// Kong), Asia Pacific (Jakarta), Europe (Milan), and Middle East (Bahrain).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Availability Zone</b> - If you want the destination file system to use EFS One
        /// Zone availability and durability, you must specify the Availability Zone to create
        /// the file system in. For more information about EFS storage classes, see <a href="https://docs.aws.amazon.com/efs/latest/ug/storage-classes.html">
        /// Amazon EFS storage classes</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Encryption</b> - All destination file systems are created with encryption at rest
        /// enabled. You can specify the Key Management Service (KMS) key that is used to encrypt
        /// the destination file system. If you don't specify a KMS key, your service-managed
        /// KMS key for Amazon EFS is used. 
        /// </para>
        ///  <note> 
        /// <para>
        /// After the file system is created, you cannot change the KMS key.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> 
        /// <para>
        /// The following properties are set by default:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Performance mode</b> - The destination file system's performance mode matches
        /// that of the source file system, unless the destination file system uses EFS One Zone
        /// storage. In that case, the General Purpose performance mode is used. The performance
        /// mode cannot be changed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Throughput mode</b> - The destination file system's throughput mode matches that
        /// of the source file system. After the file system is created, you can modify the throughput
        /// mode.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following properties are turned off by default:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Lifecycle management</b> - EFS lifecycle management and EFS Intelligent-Tiering
        /// are not enabled on the destination file system. After the destination file system
        /// is created, you can enable EFS lifecycle management and EFS Intelligent-Tiering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Automatic backups</b> - Automatic daily backups not enabled on the destination
        /// file system. After the file system is created, you can change this setting.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-replication.html">Amazon
        /// EFS replication</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReplicationConfiguration service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemLimitExceededException">
        /// Returned if the Amazon Web Services account has already created the maximum number
        /// of file systems allowed per account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InsufficientThroughputCapacityException">
        /// Returned if there's not enough capacity to provision additional throughput. This value
        /// might be returned when you try to create a file system in provisioned throughput mode,
        /// when you attempt to increase the provisioned throughput of an existing file system,
        /// or when you attempt to change an existing file system from Bursting Throughput to
        /// Provisioned Throughput mode. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ReplicationNotFoundException">
        /// Returned if the specified file system does not have a replication configuration.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThroughputLimitExceededException">
        /// Returned if the throughput mode or amount of provisioned throughput can't be changed
        /// because the throughput limit of 1024 MiB/s has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.UnsupportedAvailabilityZoneException">
        /// Returned if the requested Amazon EFS functionality is not available in the specified
        /// Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ValidationException">
        /// Returned if the Backup service is not available in the Amazon Web Services Region
        /// in which the request was made.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateReplicationConfiguration">REST API Reference for CreateReplicationConfiguration Operation</seealso>
        public virtual Task<CreateReplicationConfigurationResponse> CreateReplicationConfigurationAsync(CreateReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReplicationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// <note> 
        /// <para>
        /// DEPRECATED - <code>CreateTags</code> is deprecated and not maintained. To create tags
        /// for EFS resources, use the API action.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates or overwrites tags associated with a file system. Each tag is a key-value
        /// pair. If a tag key specified in the request already exists on the file system, this
        /// operation overwrites its value with the value provided in the request. If you add
        /// the <code>Name</code> tag to your file system, Amazon EFS returns it in the response
        /// to the <a>DescribeFileSystems</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:CreateTags</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        [Obsolete("Use TagResource.")]
        public virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// DEPRECATED - <code>CreateTags</code> is deprecated and not maintained. To create tags
        /// for EFS resources, use the API action.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates or overwrites tags associated with a file system. Each tag is a key-value
        /// pair. If a tag key specified in the request already exists on the file system, this
        /// operation overwrites its value with the value provided in the request. If you add
        /// the <code>Name</code> tag to your file system, Amazon EFS returns it in the response
        /// to the <a>DescribeFileSystems</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>elasticfilesystem:CreateTags</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        [Obsolete("Use TagResource.")]
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessPoint


        /// <summary>
        /// Deletes the specified access point. After deletion is complete, new clients can no
        /// longer connect to the access points. Clients connected to the access point at the
        /// time of deletion will continue to function until they terminate their connection.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteAccessPoint</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPoint service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        public virtual DeleteAccessPointResponse DeleteAccessPoint(DeleteAccessPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPointResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified access point. After deletion is complete, new clients can no
        /// longer connect to the access points. Clients connected to the access point at the
        /// time of deletion will continue to function until they terminate their connection.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteAccessPoint</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPoint service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        public virtual Task<DeleteAccessPointResponse> DeleteAccessPointAsync(DeleteAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFileSystem


        /// <summary>
        /// Deletes a file system, permanently severing access to its contents. Upon return, the
        /// file system no longer exists and you can't access any contents of the deleted file
        /// system.
        /// 
        ///  
        /// <para>
        /// You need to manually delete mount targets attached to a file system before you can
        /// delete an EFS file system. This step is performed for you when you use the Amazon
        /// Web Services console to delete a file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot delete a file system that is part of an EFS Replication configuration.
        /// You need to delete the replication configuration first.
        /// </para>
        ///  </note> 
        /// <para>
        ///  You can't delete a file system that is in use. That is, if the file system has any
        /// mount targets, you must first delete them. For more information, see <a>DescribeMountTargets</a>
        /// and <a>DeleteMountTarget</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>DeleteFileSystem</code> call returns while the file system state is still
        /// <code>deleting</code>. You can check the file system deletion status by calling the
        /// <a>DescribeFileSystems</a> operation, which returns a list of file systems in your
        /// account. If you pass file system ID or creation token for the deleted file system,
        /// the <a>DescribeFileSystems</a> returns a <code>404 FileSystemNotFound</code> error.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteFileSystem</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">The ID of the file system you want to delete.</param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemInUseException">
        /// Returned if a file system has mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        public virtual DeleteFileSystemResponse DeleteFileSystem(string fileSystemId)
        {
            var request = new DeleteFileSystemRequest();
            request.FileSystemId = fileSystemId;
            return DeleteFileSystem(request);
        }


        /// <summary>
        /// Deletes a file system, permanently severing access to its contents. Upon return, the
        /// file system no longer exists and you can't access any contents of the deleted file
        /// system.
        /// 
        ///  
        /// <para>
        /// You need to manually delete mount targets attached to a file system before you can
        /// delete an EFS file system. This step is performed for you when you use the Amazon
        /// Web Services console to delete a file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot delete a file system that is part of an EFS Replication configuration.
        /// You need to delete the replication configuration first.
        /// </para>
        ///  </note> 
        /// <para>
        ///  You can't delete a file system that is in use. That is, if the file system has any
        /// mount targets, you must first delete them. For more information, see <a>DescribeMountTargets</a>
        /// and <a>DeleteMountTarget</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>DeleteFileSystem</code> call returns while the file system state is still
        /// <code>deleting</code>. You can check the file system deletion status by calling the
        /// <a>DescribeFileSystems</a> operation, which returns a list of file systems in your
        /// account. If you pass file system ID or creation token for the deleted file system,
        /// the <a>DescribeFileSystems</a> returns a <code>404 FileSystemNotFound</code> error.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteFileSystem</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem service method.</param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemInUseException">
        /// Returned if a file system has mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        public virtual DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemResponseUnmarshaller.Instance;

            return Invoke<DeleteFileSystemResponse>(request, options);
        }


        /// <summary>
        /// Deletes a file system, permanently severing access to its contents. Upon return, the
        /// file system no longer exists and you can't access any contents of the deleted file
        /// system.
        /// 
        ///  
        /// <para>
        /// You need to manually delete mount targets attached to a file system before you can
        /// delete an EFS file system. This step is performed for you when you use the Amazon
        /// Web Services console to delete a file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot delete a file system that is part of an EFS Replication configuration.
        /// You need to delete the replication configuration first.
        /// </para>
        ///  </note> 
        /// <para>
        ///  You can't delete a file system that is in use. That is, if the file system has any
        /// mount targets, you must first delete them. For more information, see <a>DescribeMountTargets</a>
        /// and <a>DeleteMountTarget</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>DeleteFileSystem</code> call returns while the file system state is still
        /// <code>deleting</code>. You can check the file system deletion status by calling the
        /// <a>DescribeFileSystems</a> operation, which returns a list of file systems in your
        /// account. If you pass file system ID or creation token for the deleted file system,
        /// the <a>DescribeFileSystems</a> returns a <code>404 FileSystemNotFound</code> error.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteFileSystem</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">The ID of the file system you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemInUseException">
        /// Returned if a file system has mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        public virtual Task<DeleteFileSystemResponse> DeleteFileSystemAsync(string fileSystemId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteFileSystemRequest();
            request.FileSystemId = fileSystemId;
            return DeleteFileSystemAsync(request, cancellationToken);
        }


        /// <summary>
        /// Deletes a file system, permanently severing access to its contents. Upon return, the
        /// file system no longer exists and you can't access any contents of the deleted file
        /// system.
        /// 
        ///  
        /// <para>
        /// You need to manually delete mount targets attached to a file system before you can
        /// delete an EFS file system. This step is performed for you when you use the Amazon
        /// Web Services console to delete a file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot delete a file system that is part of an EFS Replication configuration.
        /// You need to delete the replication configuration first.
        /// </para>
        ///  </note> 
        /// <para>
        ///  You can't delete a file system that is in use. That is, if the file system has any
        /// mount targets, you must first delete them. For more information, see <a>DescribeMountTargets</a>
        /// and <a>DeleteMountTarget</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>DeleteFileSystem</code> call returns while the file system state is still
        /// <code>deleting</code>. You can check the file system deletion status by calling the
        /// <a>DescribeFileSystems</a> operation, which returns a list of file systems in your
        /// account. If you pass file system ID or creation token for the deleted file system,
        /// the <a>DescribeFileSystems</a> returns a <code>404 FileSystemNotFound</code> error.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteFileSystem</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemInUseException">
        /// Returned if a file system has mount targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        public virtual Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFileSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFileSystemPolicy


        /// <summary>
        /// Deletes the <code>FileSystemPolicy</code> for the specified file system. The default
        /// <code>FileSystemPolicy</code> goes into effect once the existing policy is deleted.
        /// For more information about the default file system policy, see <a href="https://docs.aws.amazon.com/efs/latest/ug/res-based-policies-efs.html">Using
        /// Resource-based Policies with EFS</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteFileSystemPolicy</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystemPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteFileSystemPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteFileSystemPolicy">REST API Reference for DeleteFileSystemPolicy Operation</seealso>
        public virtual DeleteFileSystemPolicyResponse DeleteFileSystemPolicy(DeleteFileSystemPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteFileSystemPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the <code>FileSystemPolicy</code> for the specified file system. The default
        /// <code>FileSystemPolicy</code> goes into effect once the existing policy is deleted.
        /// For more information about the default file system policy, see <a href="https://docs.aws.amazon.com/efs/latest/ug/res-based-policies-efs.html">Using
        /// Resource-based Policies with EFS</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteFileSystemPolicy</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystemPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystemPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteFileSystemPolicy">REST API Reference for DeleteFileSystemPolicy Operation</seealso>
        public virtual Task<DeleteFileSystemPolicyResponse> DeleteFileSystemPolicyAsync(DeleteFileSystemPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFileSystemPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMountTarget


        /// <summary>
        /// Deletes the specified mount target.
        /// 
        ///  
        /// <para>
        /// This operation forcibly breaks any mounts of the file system by using the mount target
        /// that is being deleted, which might disrupt instances or applications using those mounts.
        /// To avoid applications getting cut off abruptly, you might consider unmounting any
        /// mounts of the mount target, if feasible. The operation also deletes the associated
        /// network interface. Uncommitted writes might be lost, but breaking a mount target using
        /// this operation does not corrupt the file system itself. The file system you created
        /// remains. You can mount an EC2 instance in your VPC by using another mount target.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the following action on the file system:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DeleteMountTarget</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>DeleteMountTarget</code> call returns while the mount target state is still
        /// <code>deleting</code>. You can check the mount target deletion by calling the <a>DescribeMountTargets</a>
        /// operation, which returns a list of mount target descriptions for the given file system.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// The operation also requires permissions for the following Amazon EC2 action on the
        /// mount target's network interface:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DeleteNetworkInterface</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">The ID of the mount target to delete (String).</param>
        /// 
        /// <returns>The response from the DeleteMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.DependencyTimeoutException">
        /// The service timed out trying to fulfill the request, and the client should try the
        /// call again.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteMountTarget">REST API Reference for DeleteMountTarget Operation</seealso>
        public virtual DeleteMountTargetResponse DeleteMountTarget(string mountTargetId)
        {
            var request = new DeleteMountTargetRequest();
            request.MountTargetId = mountTargetId;
            return DeleteMountTarget(request);
        }


        /// <summary>
        /// Deletes the specified mount target.
        /// 
        ///  
        /// <para>
        /// This operation forcibly breaks any mounts of the file system by using the mount target
        /// that is being deleted, which might disrupt instances or applications using those mounts.
        /// To avoid applications getting cut off abruptly, you might consider unmounting any
        /// mounts of the mount target, if feasible. The operation also deletes the associated
        /// network interface. Uncommitted writes might be lost, but breaking a mount target using
        /// this operation does not corrupt the file system itself. The file system you created
        /// remains. You can mount an EC2 instance in your VPC by using another mount target.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the following action on the file system:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DeleteMountTarget</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>DeleteMountTarget</code> call returns while the mount target state is still
        /// <code>deleting</code>. You can check the mount target deletion by calling the <a>DescribeMountTargets</a>
        /// operation, which returns a list of mount target descriptions for the given file system.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// The operation also requires permissions for the following Amazon EC2 action on the
        /// mount target's network interface:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DeleteNetworkInterface</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMountTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.DependencyTimeoutException">
        /// The service timed out trying to fulfill the request, and the client should try the
        /// call again.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteMountTarget">REST API Reference for DeleteMountTarget Operation</seealso>
        public virtual DeleteMountTargetResponse DeleteMountTarget(DeleteMountTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMountTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteMountTargetResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified mount target.
        /// 
        ///  
        /// <para>
        /// This operation forcibly breaks any mounts of the file system by using the mount target
        /// that is being deleted, which might disrupt instances or applications using those mounts.
        /// To avoid applications getting cut off abruptly, you might consider unmounting any
        /// mounts of the mount target, if feasible. The operation also deletes the associated
        /// network interface. Uncommitted writes might be lost, but breaking a mount target using
        /// this operation does not corrupt the file system itself. The file system you created
        /// remains. You can mount an EC2 instance in your VPC by using another mount target.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the following action on the file system:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DeleteMountTarget</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>DeleteMountTarget</code> call returns while the mount target state is still
        /// <code>deleting</code>. You can check the mount target deletion by calling the <a>DescribeMountTargets</a>
        /// operation, which returns a list of mount target descriptions for the given file system.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// The operation also requires permissions for the following Amazon EC2 action on the
        /// mount target's network interface:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DeleteNetworkInterface</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">The ID of the mount target to delete (String).</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.DependencyTimeoutException">
        /// The service timed out trying to fulfill the request, and the client should try the
        /// call again.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteMountTarget">REST API Reference for DeleteMountTarget Operation</seealso>
        public virtual Task<DeleteMountTargetResponse> DeleteMountTargetAsync(string mountTargetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteMountTargetRequest();
            request.MountTargetId = mountTargetId;
            return DeleteMountTargetAsync(request, cancellationToken);
        }


        /// <summary>
        /// Deletes the specified mount target.
        /// 
        ///  
        /// <para>
        /// This operation forcibly breaks any mounts of the file system by using the mount target
        /// that is being deleted, which might disrupt instances or applications using those mounts.
        /// To avoid applications getting cut off abruptly, you might consider unmounting any
        /// mounts of the mount target, if feasible. The operation also deletes the associated
        /// network interface. Uncommitted writes might be lost, but breaking a mount target using
        /// this operation does not corrupt the file system itself. The file system you created
        /// remains. You can mount an EC2 instance in your VPC by using another mount target.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the following action on the file system:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DeleteMountTarget</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>DeleteMountTarget</code> call returns while the mount target state is still
        /// <code>deleting</code>. You can check the mount target deletion by calling the <a>DescribeMountTargets</a>
        /// operation, which returns a list of mount target descriptions for the given file system.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// The operation also requires permissions for the following Amazon EC2 action on the
        /// mount target's network interface:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DeleteNetworkInterface</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMountTarget service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.DependencyTimeoutException">
        /// The service timed out trying to fulfill the request, and the client should try the
        /// call again.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteMountTarget">REST API Reference for DeleteMountTarget Operation</seealso>
        public virtual Task<DeleteMountTargetResponse> DeleteMountTargetAsync(DeleteMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMountTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMountTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationConfiguration


        /// <summary>
        /// Deletes an existing replication configuration. To delete a replication configuration,
        /// you must make the request from the Amazon Web Services Region in which the destination
        /// file system is located. Deleting a replication configuration ends the replication
        /// process. After a replication configuration is deleted, the destination file system
        /// is no longer read-only. You can write to the destination file system after its status
        /// becomes <code>Writeable</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationConfiguration service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ReplicationNotFoundException">
        /// Returned if the specified file system does not have a replication configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteReplicationConfiguration">REST API Reference for DeleteReplicationConfiguration Operation</seealso>
        public virtual DeleteReplicationConfigurationResponse DeleteReplicationConfiguration(DeleteReplicationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes an existing replication configuration. To delete a replication configuration,
        /// you must make the request from the Amazon Web Services Region in which the destination
        /// file system is located. Deleting a replication configuration ends the replication
        /// process. After a replication configuration is deleted, the destination file system
        /// is no longer read-only. You can write to the destination file system after its status
        /// becomes <code>Writeable</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReplicationConfiguration service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ReplicationNotFoundException">
        /// Returned if the specified file system does not have a replication configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteReplicationConfiguration">REST API Reference for DeleteReplicationConfiguration Operation</seealso>
        public virtual Task<DeleteReplicationConfigurationResponse> DeleteReplicationConfigurationAsync(DeleteReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// <note> 
        /// <para>
        /// DEPRECATED - <code>DeleteTags</code> is deprecated and not maintained. To remove tags
        /// from EFS resources, use the API action.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified tags from a file system. If the <code>DeleteTags</code> request
        /// includes a tag key that doesn't exist, Amazon EFS ignores it and doesn't cause an
        /// error. For more information about tags and related restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Tag
        /// restrictions</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteTags</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        [Obsolete("Use UntagResource.")]
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// DEPRECATED - <code>DeleteTags</code> is deprecated and not maintained. To remove tags
        /// from EFS resources, use the API action.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified tags from a file system. If the <code>DeleteTags</code> request
        /// includes a tag key that doesn't exist, Amazon EFS ignores it and doesn't cause an
        /// error. For more information about tags and related restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Tag
        /// restrictions</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DeleteTags</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        [Obsolete("Use UntagResource.")]
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccessPoints


        /// <summary>
        /// Returns the description of a specific Amazon EFS access point if the <code>AccessPointId</code>
        /// is provided. If you provide an EFS <code>FileSystemId</code>, it returns descriptions
        /// of all access points for that file system. You can provide either an <code>AccessPointId</code>
        /// or a <code>FileSystemId</code> in the request, but not both. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeAccessPoints</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessPoints service method.</param>
        /// 
        /// <returns>The response from the DescribeAccessPoints service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeAccessPoints">REST API Reference for DescribeAccessPoints Operation</seealso>
        public virtual DescribeAccessPointsResponse DescribeAccessPoints(DescribeAccessPointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessPointsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccessPointsResponse>(request, options);
        }


        /// <summary>
        /// Returns the description of a specific Amazon EFS access point if the <code>AccessPointId</code>
        /// is provided. If you provide an EFS <code>FileSystemId</code>, it returns descriptions
        /// of all access points for that file system. You can provide either an <code>AccessPointId</code>
        /// or a <code>FileSystemId</code> in the request, but not both. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeAccessPoints</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccessPoints service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeAccessPoints">REST API Reference for DescribeAccessPoints Operation</seealso>
        public virtual Task<DescribeAccessPointsResponse> DescribeAccessPointsAsync(DescribeAccessPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccessPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessPointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccessPointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountPreferences


        /// <summary>
        /// Returns the account preferences settings for the Amazon Web Services account associated
        /// with the user making the request, in the current Amazon Web Services Region. For more
        /// information, see <a href="efs/latest/ug/manage-efs-resource-ids.html">Managing Amazon
        /// EFS resource IDs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountPreferences service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeAccountPreferences">REST API Reference for DescribeAccountPreferences Operation</seealso>
        public virtual DescribeAccountPreferencesResponse DescribeAccountPreferences(DescribeAccountPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountPreferencesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountPreferencesResponse>(request, options);
        }


        /// <summary>
        /// Returns the account preferences settings for the Amazon Web Services account associated
        /// with the user making the request, in the current Amazon Web Services Region. For more
        /// information, see <a href="efs/latest/ug/manage-efs-resource-ids.html">Managing Amazon
        /// EFS resource IDs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountPreferences service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeAccountPreferences">REST API Reference for DescribeAccountPreferences Operation</seealso>
        public virtual Task<DescribeAccountPreferencesResponse> DescribeAccountPreferencesAsync(DescribeAccountPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountPreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBackupPolicy


        /// <summary>
        /// Returns the backup policy for the specified EFS file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeBackupPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.PolicyNotFoundException">
        /// Returned if the default file system policy is in effect for the EFS file system specified.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ValidationException">
        /// Returned if the Backup service is not available in the Amazon Web Services Region
        /// in which the request was made.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeBackupPolicy">REST API Reference for DescribeBackupPolicy Operation</seealso>
        public virtual DescribeBackupPolicyResponse DescribeBackupPolicy(DescribeBackupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the backup policy for the specified EFS file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBackupPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.PolicyNotFoundException">
        /// Returned if the default file system policy is in effect for the EFS file system specified.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ValidationException">
        /// Returned if the Backup service is not available in the Amazon Web Services Region
        /// in which the request was made.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeBackupPolicy">REST API Reference for DescribeBackupPolicy Operation</seealso>
        public virtual Task<DescribeBackupPolicyResponse> DescribeBackupPolicyAsync(DescribeBackupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBackupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFileSystemPolicy


        /// <summary>
        /// Returns the <code>FileSystemPolicy</code> for the specified EFS file system.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeFileSystemPolicy</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystemPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeFileSystemPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.PolicyNotFoundException">
        /// Returned if the default file system policy is in effect for the EFS file system specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeFileSystemPolicy">REST API Reference for DescribeFileSystemPolicy Operation</seealso>
        public virtual DescribeFileSystemPolicyResponse DescribeFileSystemPolicy(DescribeFileSystemPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeFileSystemPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the <code>FileSystemPolicy</code> for the specified EFS file system.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeFileSystemPolicy</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystemPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFileSystemPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.PolicyNotFoundException">
        /// Returned if the default file system policy is in effect for the EFS file system specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeFileSystemPolicy">REST API Reference for DescribeFileSystemPolicy Operation</seealso>
        public virtual Task<DescribeFileSystemPolicyResponse> DescribeFileSystemPolicyAsync(DescribeFileSystemPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFileSystemPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFileSystems


        /// <summary>
        /// Returns the description of a specific Amazon EFS file system if either the file system
        /// <code>CreationToken</code> or the <code>FileSystemId</code> is provided. Otherwise,
        /// it returns descriptions of all file systems owned by the caller's Amazon Web Services
        /// account in the Amazon Web Services Region of the endpoint that you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all file system descriptions, you can optionally specify the <code>MaxItems</code>
        /// parameter to limit the number of descriptions in a response. This number is automatically
        /// set to 100. If more file system descriptions remain, Amazon EFS returns a <code>NextMarker</code>,
        /// an opaque token, in the response. In this case, you should send a subsequent request
        /// with the <code>Marker</code> request parameter set to the value of <code>NextMarker</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To retrieve a list of your file system descriptions, this operation is used in an
        /// iterative process, where <code>DescribeFileSystems</code> is called first without
        /// the <code>Marker</code> and then the operation continues to call it with the <code>Marker</code>
        /// parameter set to the value of the <code>NextMarker</code> from the previous response
        /// until the response has no <code>NextMarker</code>. 
        /// </para>
        ///  
        /// <para>
        ///  The order of file systems returned in the response of one <code>DescribeFileSystems</code>
        /// call and the order of file systems returned across the responses of a multi-call iteration
        /// is unspecified. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:DescribeFileSystems</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems service method.</param>
        /// 
        /// <returns>The response from the DescribeFileSystems service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        public virtual DescribeFileSystemsResponse DescribeFileSystems(DescribeFileSystemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemsResponseUnmarshaller.Instance;

            return Invoke<DescribeFileSystemsResponse>(request, options);
        }


        /// <summary>
        /// Returns the description of a specific Amazon EFS file system if either the file system
        /// <code>CreationToken</code> or the <code>FileSystemId</code> is provided. Otherwise,
        /// it returns descriptions of all file systems owned by the caller's Amazon Web Services
        /// account in the Amazon Web Services Region of the endpoint that you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all file system descriptions, you can optionally specify the <code>MaxItems</code>
        /// parameter to limit the number of descriptions in a response. This number is automatically
        /// set to 100. If more file system descriptions remain, Amazon EFS returns a <code>NextMarker</code>,
        /// an opaque token, in the response. In this case, you should send a subsequent request
        /// with the <code>Marker</code> request parameter set to the value of <code>NextMarker</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To retrieve a list of your file system descriptions, this operation is used in an
        /// iterative process, where <code>DescribeFileSystems</code> is called first without
        /// the <code>Marker</code> and then the operation continues to call it with the <code>Marker</code>
        /// parameter set to the value of the <code>NextMarker</code> from the previous response
        /// until the response has no <code>NextMarker</code>. 
        /// </para>
        ///  
        /// <para>
        ///  The order of file systems returned in the response of one <code>DescribeFileSystems</code>
        /// call and the order of file systems returned across the responses of a multi-call iteration
        /// is unspecified. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:DescribeFileSystems</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFileSystems service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        public virtual Task<DescribeFileSystemsResponse> DescribeFileSystemsAsync(DescribeFileSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFileSystemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLifecycleConfiguration


        /// <summary>
        /// Returns the current <code>LifecycleConfiguration</code> object for the specified Amazon
        /// EFS file system. EFS lifecycle management uses the <code>LifecycleConfiguration</code>
        /// object to identify which files to move to the EFS Infrequent Access (IA) storage class.
        /// For a file system without a <code>LifecycleConfiguration</code> object, the call returns
        /// an empty array in the response.
        /// 
        ///  
        /// <para>
        /// When EFS Intelligent-Tiering is enabled, <code>TransitionToPrimaryStorageClass</code>
        /// has a value of <code>AFTER_1_ACCESS</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeLifecycleConfiguration</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleConfiguration service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeLifecycleConfiguration">REST API Reference for DescribeLifecycleConfiguration Operation</seealso>
        public virtual DescribeLifecycleConfigurationResponse DescribeLifecycleConfiguration(DescribeLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns the current <code>LifecycleConfiguration</code> object for the specified Amazon
        /// EFS file system. EFS lifecycle management uses the <code>LifecycleConfiguration</code>
        /// object to identify which files to move to the EFS Infrequent Access (IA) storage class.
        /// For a file system without a <code>LifecycleConfiguration</code> object, the call returns
        /// an empty array in the response.
        /// 
        ///  
        /// <para>
        /// When EFS Intelligent-Tiering is enabled, <code>TransitionToPrimaryStorageClass</code>
        /// has a value of <code>AFTER_1_ACCESS</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeLifecycleConfiguration</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLifecycleConfiguration service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeLifecycleConfiguration">REST API Reference for DescribeLifecycleConfiguration Operation</seealso>
        public virtual Task<DescribeLifecycleConfigurationResponse> DescribeLifecycleConfigurationAsync(DescribeLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMountTargets


        /// <summary>
        /// Returns the descriptions of all the current mount targets, or a specific mount target,
        /// for a file system. When requesting all of the current mount targets, the order of
        /// mount targets returned in the response is unspecified.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeMountTargets</code>
        /// action, on either the file system ID that you specify in <code>FileSystemId</code>,
        /// or on the file system of the mount target that you specify in <code>MountTargetId</code>.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">(Optional) ID of the file system whose mount targets you want to list (String). It must be included in your request if an <code>AccessPointId</code> or <code>MountTargetId</code> is not included. Accepts either a file system ID or ARN as input.</param>
        /// 
        /// <returns>The response from the DescribeMountTargets service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeMountTargets">REST API Reference for DescribeMountTargets Operation</seealso>
        public virtual DescribeMountTargetsResponse DescribeMountTargets(string fileSystemId)
        {
            var request = new DescribeMountTargetsRequest();
            request.FileSystemId = fileSystemId;
            return DescribeMountTargets(request);
        }


        /// <summary>
        /// Returns the descriptions of all the current mount targets, or a specific mount target,
        /// for a file system. When requesting all of the current mount targets, the order of
        /// mount targets returned in the response is unspecified.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeMountTargets</code>
        /// action, on either the file system ID that you specify in <code>FileSystemId</code>,
        /// or on the file system of the mount target that you specify in <code>MountTargetId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMountTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeMountTargets service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeMountTargets">REST API Reference for DescribeMountTargets Operation</seealso>
        public virtual DescribeMountTargetsResponse DescribeMountTargets(DescribeMountTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMountTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMountTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeMountTargetsResponse>(request, options);
        }


        /// <summary>
        /// Returns the descriptions of all the current mount targets, or a specific mount target,
        /// for a file system. When requesting all of the current mount targets, the order of
        /// mount targets returned in the response is unspecified.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeMountTargets</code>
        /// action, on either the file system ID that you specify in <code>FileSystemId</code>,
        /// or on the file system of the mount target that you specify in <code>MountTargetId</code>.
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">(Optional) ID of the file system whose mount targets you want to list (String). It must be included in your request if an <code>AccessPointId</code> or <code>MountTargetId</code> is not included. Accepts either a file system ID or ARN as input.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMountTargets service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeMountTargets">REST API Reference for DescribeMountTargets Operation</seealso>
        public virtual Task<DescribeMountTargetsResponse> DescribeMountTargetsAsync(string fileSystemId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeMountTargetsRequest();
            request.FileSystemId = fileSystemId;
            return DescribeMountTargetsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns the descriptions of all the current mount targets, or a specific mount target,
        /// for a file system. When requesting all of the current mount targets, the order of
        /// mount targets returned in the response is unspecified.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeMountTargets</code>
        /// action, on either the file system ID that you specify in <code>FileSystemId</code>,
        /// or on the file system of the mount target that you specify in <code>MountTargetId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMountTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMountTargets service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeMountTargets">REST API Reference for DescribeMountTargets Operation</seealso>
        public virtual Task<DescribeMountTargetsResponse> DescribeMountTargetsAsync(DescribeMountTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMountTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMountTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMountTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMountTargetSecurityGroups


        /// <summary>
        /// Returns the security groups currently in effect for a mount target. This operation
        /// requires that the network interface of the mount target has been created and the lifecycle
        /// state of the mount target is not <code>deleted</code>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DescribeMountTargetSecurityGroups</code> action on the mount
        /// target's file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeNetworkInterfaceAttribute</code> action on the mount target's network
        /// interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">The ID of the mount target whose security groups you want to retrieve.</param>
        /// 
        /// <returns>The response from the DescribeMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeMountTargetSecurityGroups">REST API Reference for DescribeMountTargetSecurityGroups Operation</seealso>
        public virtual DescribeMountTargetSecurityGroupsResponse DescribeMountTargetSecurityGroups(string mountTargetId)
        {
            var request = new DescribeMountTargetSecurityGroupsRequest();
            request.MountTargetId = mountTargetId;
            return DescribeMountTargetSecurityGroups(request);
        }


        /// <summary>
        /// Returns the security groups currently in effect for a mount target. This operation
        /// requires that the network interface of the mount target has been created and the lifecycle
        /// state of the mount target is not <code>deleted</code>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DescribeMountTargetSecurityGroups</code> action on the mount
        /// target's file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeNetworkInterfaceAttribute</code> action on the mount target's network
        /// interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMountTargetSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeMountTargetSecurityGroups">REST API Reference for DescribeMountTargetSecurityGroups Operation</seealso>
        public virtual DescribeMountTargetSecurityGroupsResponse DescribeMountTargetSecurityGroups(DescribeMountTargetSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMountTargetSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMountTargetSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeMountTargetSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns the security groups currently in effect for a mount target. This operation
        /// requires that the network interface of the mount target has been created and the lifecycle
        /// state of the mount target is not <code>deleted</code>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DescribeMountTargetSecurityGroups</code> action on the mount
        /// target's file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeNetworkInterfaceAttribute</code> action on the mount target's network
        /// interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="mountTargetId">The ID of the mount target whose security groups you want to retrieve.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeMountTargetSecurityGroups">REST API Reference for DescribeMountTargetSecurityGroups Operation</seealso>
        public virtual Task<DescribeMountTargetSecurityGroupsResponse> DescribeMountTargetSecurityGroupsAsync(string mountTargetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeMountTargetSecurityGroupsRequest();
            request.MountTargetId = mountTargetId;
            return DescribeMountTargetSecurityGroupsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns the security groups currently in effect for a mount target. This operation
        /// requires that the network interface of the mount target has been created and the lifecycle
        /// state of the mount target is not <code>deleted</code>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:DescribeMountTargetSecurityGroups</code> action on the mount
        /// target's file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeNetworkInterfaceAttribute</code> action on the mount target's network
        /// interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMountTargetSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeMountTargetSecurityGroups">REST API Reference for DescribeMountTargetSecurityGroups Operation</seealso>
        public virtual Task<DescribeMountTargetSecurityGroupsResponse> DescribeMountTargetSecurityGroupsAsync(DescribeMountTargetSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMountTargetSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMountTargetSecurityGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMountTargetSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationConfigurations


        /// <summary>
        /// Retrieves the replication configuration for a specific file system. If a file system
        /// is not specified, all of the replication configurations for the Amazon Web Services
        /// account in an Amazon Web Services Region are retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigurations service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ReplicationNotFoundException">
        /// Returned if the specified file system does not have a replication configuration.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ValidationException">
        /// Returned if the Backup service is not available in the Amazon Web Services Region
        /// in which the request was made.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeReplicationConfigurations">REST API Reference for DescribeReplicationConfigurations Operation</seealso>
        public virtual DescribeReplicationConfigurationsResponse DescribeReplicationConfigurations(DescribeReplicationConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the replication configuration for a specific file system. If a file system
        /// is not specified, all of the replication configurations for the Amazon Web Services
        /// account in an Amazon Web Services Region are retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigurations service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ReplicationNotFoundException">
        /// Returned if the specified file system does not have a replication configuration.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ValidationException">
        /// Returned if the Backup service is not available in the Amazon Web Services Region
        /// in which the request was made.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeReplicationConfigurations">REST API Reference for DescribeReplicationConfigurations Operation</seealso>
        public virtual Task<DescribeReplicationConfigurationsResponse> DescribeReplicationConfigurationsAsync(DescribeReplicationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// <note> 
        /// <para>
        /// DEPRECATED - The <code>DescribeTags</code> action is deprecated and not maintained.
        /// To view tags associated with EFS resources, use the <code>ListTagsForResource</code>
        /// API action.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the tags associated with a file system. The order of tags returned in the
        /// response of one <code>DescribeTags</code> call and the order of tags returned across
        /// the responses of a multiple-call iteration (when using pagination) is unspecified.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:DescribeTags</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">The ID of the file system whose tag set you want to retrieve.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        [Obsolete("Use ListTagsForResource.")]
        public virtual DescribeTagsResponse DescribeTags(string fileSystemId)
        {
            var request = new DescribeTagsRequest();
            request.FileSystemId = fileSystemId;
            return DescribeTags(request);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// DEPRECATED - The <code>DescribeTags</code> action is deprecated and not maintained.
        /// To view tags associated with EFS resources, use the <code>ListTagsForResource</code>
        /// API action.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the tags associated with a file system. The order of tags returned in the
        /// response of one <code>DescribeTags</code> call and the order of tags returned across
        /// the responses of a multiple-call iteration (when using pagination) is unspecified.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:DescribeTags</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        [Obsolete("Use ListTagsForResource.")]
        public virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// DEPRECATED - The <code>DescribeTags</code> action is deprecated and not maintained.
        /// To view tags associated with EFS resources, use the <code>ListTagsForResource</code>
        /// API action.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the tags associated with a file system. The order of tags returned in the
        /// response of one <code>DescribeTags</code> call and the order of tags returned across
        /// the responses of a multiple-call iteration (when using pagination) is unspecified.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:DescribeTags</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="fileSystemId">The ID of the file system whose tag set you want to retrieve.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        [Obsolete("Use ListTagsForResource.")]
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(string fileSystemId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeTagsRequest();
            request.FileSystemId = fileSystemId;
            return DescribeTagsAsync(request, cancellationToken);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// DEPRECATED - The <code>DescribeTags</code> action is deprecated and not maintained.
        /// To view tags associated with EFS resources, use the <code>ListTagsForResource</code>
        /// API action.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the tags associated with a file system. The order of tags returned in the
        /// response of one <code>DescribeTags</code> call and the order of tags returned across
        /// the responses of a multiple-call iteration (when using pagination) is unspecified.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions for the <code>elasticfilesystem:DescribeTags</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        [Obsolete("Use ListTagsForResource.")]
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags for a top-level EFS resource. You must provide the ID of the resource
        /// that you want to retrieve the tags for.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeAccessPoints</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all tags for a top-level EFS resource. You must provide the ID of the resource
        /// that you want to retrieve the tags for.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:DescribeAccessPoints</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyMountTargetSecurityGroups


        /// <summary>
        /// Modifies the set of security groups in effect for a mount target.
        /// 
        ///  
        /// <para>
        /// When you create a mount target, Amazon EFS also creates a new network interface. For
        /// more information, see <a>CreateMountTarget</a>. This operation replaces the security
        /// groups in effect for the network interface associated with a mount target, with the
        /// <code>SecurityGroups</code> provided in the request. This operation requires that
        /// the network interface of the mount target has been created and the lifecycle state
        /// of the mount target is not <code>deleted</code>. 
        /// </para>
        ///  
        /// <para>
        /// The operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:ModifyMountTargetSecurityGroups</code> action on the mount
        /// target's file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:ModifyNetworkInterfaceAttribute</code> action on the mount target's network
        /// interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyMountTargetSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the ModifyMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupLimitExceededException">
        /// Returned if the size of <code>SecurityGroups</code> specified in the request is greater
        /// than five.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupNotFoundException">
        /// Returned if one of the specified security groups doesn't exist in the subnet's virtual
        /// private cloud (VPC).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/ModifyMountTargetSecurityGroups">REST API Reference for ModifyMountTargetSecurityGroups Operation</seealso>
        public virtual ModifyMountTargetSecurityGroupsResponse ModifyMountTargetSecurityGroups(ModifyMountTargetSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyMountTargetSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyMountTargetSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<ModifyMountTargetSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Modifies the set of security groups in effect for a mount target.
        /// 
        ///  
        /// <para>
        /// When you create a mount target, Amazon EFS also creates a new network interface. For
        /// more information, see <a>CreateMountTarget</a>. This operation replaces the security
        /// groups in effect for the network interface associated with a mount target, with the
        /// <code>SecurityGroups</code> provided in the request. This operation requires that
        /// the network interface of the mount target has been created and the lifecycle state
        /// of the mount target is not <code>deleted</code>. 
        /// </para>
        ///  
        /// <para>
        /// The operation requires permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>elasticfilesystem:ModifyMountTargetSecurityGroups</code> action on the mount
        /// target's file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:ModifyNetworkInterfaceAttribute</code> action on the mount target's network
        /// interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyMountTargetSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyMountTargetSecurityGroups service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectMountTargetStateException">
        /// Returned if the mount target is not in the correct state for the operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.MountTargetNotFoundException">
        /// Returned if there is no mount target with the specified ID found in the caller's Amazon
        /// Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupLimitExceededException">
        /// Returned if the size of <code>SecurityGroups</code> specified in the request is greater
        /// than five.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.SecurityGroupNotFoundException">
        /// Returned if one of the specified security groups doesn't exist in the subnet's virtual
        /// private cloud (VPC).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/ModifyMountTargetSecurityGroups">REST API Reference for ModifyMountTargetSecurityGroups Operation</seealso>
        public virtual Task<ModifyMountTargetSecurityGroupsResponse> ModifyMountTargetSecurityGroupsAsync(ModifyMountTargetSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyMountTargetSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyMountTargetSecurityGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyMountTargetSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccountPreferences


        /// <summary>
        /// Use this operation to set the account preference in the current Amazon Web Services
        /// Region to use long 17 character (63 bit) or short 8 character (32 bit) resource IDs
        /// for new EFS file system and mount target resources. All existing resource IDs are
        /// not affected by any changes you make. You can set the ID preference during the opt-in
        /// period as EFS transitions to long resource IDs. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/manage-efs-resource-ids.html">Managing
        /// Amazon EFS resource IDs</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Starting in October, 2021, you will receive an error if you try to set the account
        /// preference to use the short 8 character format resource ID. Contact Amazon Web Services
        /// support if you receive an error and must use short IDs for file system and mount target
        /// resources.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the PutAccountPreferences service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/PutAccountPreferences">REST API Reference for PutAccountPreferences Operation</seealso>
        public virtual PutAccountPreferencesResponse PutAccountPreferences(PutAccountPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountPreferencesResponseUnmarshaller.Instance;

            return Invoke<PutAccountPreferencesResponse>(request, options);
        }


        /// <summary>
        /// Use this operation to set the account preference in the current Amazon Web Services
        /// Region to use long 17 character (63 bit) or short 8 character (32 bit) resource IDs
        /// for new EFS file system and mount target resources. All existing resource IDs are
        /// not affected by any changes you make. You can set the ID preference during the opt-in
        /// period as EFS transitions to long resource IDs. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/manage-efs-resource-ids.html">Managing
        /// Amazon EFS resource IDs</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Starting in October, 2021, you will receive an error if you try to set the account
        /// preference to use the short 8 character format resource ID. Contact Amazon Web Services
        /// support if you receive an error and must use short IDs for file system and mount target
        /// resources.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountPreferences service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/PutAccountPreferences">REST API Reference for PutAccountPreferences Operation</seealso>
        public virtual Task<PutAccountPreferencesResponse> PutAccountPreferencesAsync(PutAccountPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountPreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAccountPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBackupPolicy


        /// <summary>
        /// Updates the file system's backup policy. Use this action to start or stop automatic
        /// backups of the file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupPolicy service method.</param>
        /// 
        /// <returns>The response from the PutBackupPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ValidationException">
        /// Returned if the Backup service is not available in the Amazon Web Services Region
        /// in which the request was made.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/PutBackupPolicy">REST API Reference for PutBackupPolicy Operation</seealso>
        public virtual PutBackupPolicyResponse PutBackupPolicy(PutBackupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBackupPolicyResponse>(request, options);
        }


        /// <summary>
        /// Updates the file system's backup policy. Use this action to start or stop automatic
        /// backups of the file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBackupPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ValidationException">
        /// Returned if the Backup service is not available in the Amazon Web Services Region
        /// in which the request was made.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/PutBackupPolicy">REST API Reference for PutBackupPolicy Operation</seealso>
        public virtual Task<PutBackupPolicyResponse> PutBackupPolicyAsync(PutBackupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutBackupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutFileSystemPolicy


        /// <summary>
        /// Applies an Amazon EFS <code>FileSystemPolicy</code> to an Amazon EFS file system.
        /// A file system policy is an IAM resource-based policy and can contain multiple policy
        /// statements. A file system always has exactly one file system policy, which can be
        /// the default policy or an explicit policy set or updated using this API operation.
        /// EFS file system policies have a 20,000 character limit. When an explicit policy is
        /// set, it overrides the default policy. For more information about the default file
        /// system policy, see <a href="https://docs.aws.amazon.com/efs/latest/ug/iam-access-control-nfs-efs.html#default-filesystempolicy">Default
        /// EFS File System Policy</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// EFS file system policies have a 20,000 character limit.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:PutFileSystemPolicy</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFileSystemPolicy service method.</param>
        /// 
        /// <returns>The response from the PutFileSystemPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InvalidPolicyException">
        /// Returned if the <code>FileSystemPolicy</code> is malformed or contains an error such
        /// as a parameter value that is not valid or a missing required parameter. Returned in
        /// the case of a policy lockout safety check error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/PutFileSystemPolicy">REST API Reference for PutFileSystemPolicy Operation</seealso>
        public virtual PutFileSystemPolicyResponse PutFileSystemPolicy(PutFileSystemPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFileSystemPolicyResponseUnmarshaller.Instance;

            return Invoke<PutFileSystemPolicyResponse>(request, options);
        }


        /// <summary>
        /// Applies an Amazon EFS <code>FileSystemPolicy</code> to an Amazon EFS file system.
        /// A file system policy is an IAM resource-based policy and can contain multiple policy
        /// statements. A file system always has exactly one file system policy, which can be
        /// the default policy or an explicit policy set or updated using this API operation.
        /// EFS file system policies have a 20,000 character limit. When an explicit policy is
        /// set, it overrides the default policy. For more information about the default file
        /// system policy, see <a href="https://docs.aws.amazon.com/efs/latest/ug/iam-access-control-nfs-efs.html#default-filesystempolicy">Default
        /// EFS File System Policy</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// EFS file system policies have a 20,000 character limit.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:PutFileSystemPolicy</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFileSystemPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFileSystemPolicy service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InvalidPolicyException">
        /// Returned if the <code>FileSystemPolicy</code> is malformed or contains an error such
        /// as a parameter value that is not valid or a missing required parameter. Returned in
        /// the case of a policy lockout safety check error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/PutFileSystemPolicy">REST API Reference for PutFileSystemPolicy Operation</seealso>
        public virtual Task<PutFileSystemPolicyResponse> PutFileSystemPolicyAsync(PutFileSystemPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFileSystemPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutFileSystemPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleConfiguration


        /// <summary>
        /// Use this action to manage EFS lifecycle management and EFS Intelligent-Tiering. A
        /// <code>LifecycleConfiguration</code> consists of one or more <code>LifecyclePolicy</code>
        /// objects that define the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>EFS Lifecycle management</b> - When Amazon EFS automatically transitions files
        /// in a file system into the lower-cost EFS Infrequent Access (IA) storage class.
        /// </para>
        ///  
        /// <para>
        /// To enable EFS Lifecycle management, set the value of <code>TransitionToIA</code> to
        /// one of the available options.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EFS Intelligent-Tiering</b> - When Amazon EFS automatically transitions files
        /// from IA back into the file system's primary storage class (EFS Standard or EFS One
        /// Zone Standard).
        /// </para>
        ///  
        /// <para>
        /// To enable EFS Intelligent-Tiering, set the value of <code>TransitionToPrimaryStorageClass</code>
        /// to <code>AFTER_1_ACCESS</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/lifecycle-management-efs.html">EFS
        /// Lifecycle Management</a>.
        /// </para>
        ///  
        /// <para>
        /// Each Amazon EFS file system supports one lifecycle configuration, which applies to
        /// all files in the file system. If a <code>LifecycleConfiguration</code> object already
        /// exists for the specified file system, a <code>PutLifecycleConfiguration</code> call
        /// modifies the existing configuration. A <code>PutLifecycleConfiguration</code> call
        /// with an empty <code>LifecyclePolicies</code> array in the request body deletes any
        /// existing <code>LifecycleConfiguration</code> and turns off lifecycle management and
        /// EFS Intelligent-Tiering for the file system.
        /// </para>
        ///  
        /// <para>
        /// In the request, specify the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The ID for the file system for which you are enabling, disabling, or modifying lifecycle
        /// management and EFS Intelligent-Tiering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>LifecyclePolicies</code> array of <code>LifecyclePolicy</code> objects that
        /// define when files are moved into IA storage, and when they are moved back to Standard
        /// storage.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon EFS requires that each <code>LifecyclePolicy</code> object have only have a
        /// single transition, so the <code>LifecyclePolicies</code> array needs to be structured
        /// with separate <code>LifecyclePolicy</code> objects. See the example requests in the
        /// following section for more information.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:PutLifecycleConfiguration</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// To apply a <code>LifecycleConfiguration</code> object to an encrypted file system,
        /// you need the same Key Management Service permissions as when you created the encrypted
        /// file system.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/PutLifecycleConfiguration">REST API Reference for PutLifecycleConfiguration Operation</seealso>
        public virtual PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Use this action to manage EFS lifecycle management and EFS Intelligent-Tiering. A
        /// <code>LifecycleConfiguration</code> consists of one or more <code>LifecyclePolicy</code>
        /// objects that define the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>EFS Lifecycle management</b> - When Amazon EFS automatically transitions files
        /// in a file system into the lower-cost EFS Infrequent Access (IA) storage class.
        /// </para>
        ///  
        /// <para>
        /// To enable EFS Lifecycle management, set the value of <code>TransitionToIA</code> to
        /// one of the available options.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EFS Intelligent-Tiering</b> - When Amazon EFS automatically transitions files
        /// from IA back into the file system's primary storage class (EFS Standard or EFS One
        /// Zone Standard).
        /// </para>
        ///  
        /// <para>
        /// To enable EFS Intelligent-Tiering, set the value of <code>TransitionToPrimaryStorageClass</code>
        /// to <code>AFTER_1_ACCESS</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/lifecycle-management-efs.html">EFS
        /// Lifecycle Management</a>.
        /// </para>
        ///  
        /// <para>
        /// Each Amazon EFS file system supports one lifecycle configuration, which applies to
        /// all files in the file system. If a <code>LifecycleConfiguration</code> object already
        /// exists for the specified file system, a <code>PutLifecycleConfiguration</code> call
        /// modifies the existing configuration. A <code>PutLifecycleConfiguration</code> call
        /// with an empty <code>LifecyclePolicies</code> array in the request body deletes any
        /// existing <code>LifecycleConfiguration</code> and turns off lifecycle management and
        /// EFS Intelligent-Tiering for the file system.
        /// </para>
        ///  
        /// <para>
        /// In the request, specify the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The ID for the file system for which you are enabling, disabling, or modifying lifecycle
        /// management and EFS Intelligent-Tiering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>LifecyclePolicies</code> array of <code>LifecyclePolicy</code> objects that
        /// define when files are moved into IA storage, and when they are moved back to Standard
        /// storage.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon EFS requires that each <code>LifecyclePolicy</code> object have only have a
        /// single transition, so the <code>LifecyclePolicies</code> array needs to be structured
        /// with separate <code>LifecyclePolicy</code> objects. See the example requests in the
        /// following section for more information.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:PutLifecycleConfiguration</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// To apply a <code>LifecycleConfiguration</code> object to an encrypted file system,
        /// you need the same Key Management Service permissions as when you created the encrypted
        /// file system.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/PutLifecycleConfiguration">REST API Reference for PutLifecycleConfiguration Operation</seealso>
        public virtual Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Creates a tag for an EFS resource. You can create tags for EFS file systems and access
        /// points using this API operation.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:TagResource</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Creates a tag for an EFS resource. You can create tags for EFS file systems and access
        /// points using this API operation.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:TagResource</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an EFS resource. You can remove tags from EFS file systems and access
        /// points using this API operation.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:UntagResource</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from an EFS resource. You can remove tags from EFS file systems and access
        /// points using this API operation.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions for the <code>elasticfilesystem:UntagResource</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.AccessPointNotFoundException">
        /// Returned if the specified <code>AccessPointId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFileSystem


        /// <summary>
        /// Updates the throughput mode or the amount of provisioned throughput of an existing
        /// file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileSystem service method.</param>
        /// 
        /// <returns>The response from the UpdateFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InsufficientThroughputCapacityException">
        /// Returned if there's not enough capacity to provision additional throughput. This value
        /// might be returned when you try to create a file system in provisioned throughput mode,
        /// when you attempt to increase the provisioned throughput of an existing file system,
        /// or when you attempt to change an existing file system from Bursting Throughput to
        /// Provisioned Throughput mode. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThroughputLimitExceededException">
        /// Returned if the throughput mode or amount of provisioned throughput can't be changed
        /// because the throughput limit of 1024 MiB/s has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.TooManyRequestsException">
        /// Returned if you don’t wait at least 24 hours before either changing the throughput
        /// mode, or decreasing the Provisioned Throughput value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        public virtual UpdateFileSystemResponse UpdateFileSystem(UpdateFileSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFileSystemResponseUnmarshaller.Instance;

            return Invoke<UpdateFileSystemResponse>(request, options);
        }


        /// <summary>
        /// Updates the throughput mode or the amount of provisioned throughput of an existing
        /// file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFileSystem service method, as returned by ElasticFileSystem.</returns>
        /// <exception cref="Amazon.ElasticFileSystem.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.FileSystemNotFoundException">
        /// Returned if the specified <code>FileSystemId</code> value doesn't exist in the requester's
        /// Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.IncorrectFileSystemLifeCycleStateException">
        /// Returned if the file system's lifecycle state is not "available".
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InsufficientThroughputCapacityException">
        /// Returned if there's not enough capacity to provision additional throughput. This value
        /// might be returned when you try to create a file system in provisioned throughput mode,
        /// when you attempt to increase the provisioned throughput of an existing file system,
        /// or when you attempt to change an existing file system from Bursting Throughput to
        /// Provisioned Throughput mode. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.InternalServerErrorException">
        /// Returned if an error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.ThroughputLimitExceededException">
        /// Returned if the throughput mode or amount of provisioned throughput can't be changed
        /// because the throughput limit of 1024 MiB/s has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticFileSystem.Model.TooManyRequestsException">
        /// Returned if you don’t wait at least 24 hours before either changing the throughput
        /// mode, or decreasing the Provisioned Throughput value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticfilesystem-2015-02-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        public virtual Task<UpdateFileSystemResponse> UpdateFileSystemAsync(UpdateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFileSystemResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFileSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}