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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.S3Files.Model;
using Amazon.S3Files.Model.Internal.MarshallTransformations;
using Amazon.S3Files.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.S3Files
{
    /// <summary>
    /// <para>Implementation for accessing S3Files</para>
    ///
    /// S3 Files makes S3 buckets accessible as high-performance file systems powered by EFS.
    /// This service enables file system interface access to S3 data with sub-millisecond
    /// latencies through mount targets, supporting AI/ML workloads, media processing, and
    /// hybrid storage workflows that require both file system and object storage access to
    /// the same data.
    /// </summary>
    public partial class AmazonS3FilesClient : AmazonServiceClient, IAmazonS3Files
    {
        private static IServiceMetadata serviceMetadata = new AmazonS3FilesMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3FilesClient with the credentials loaded from the application's
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
        public AmazonS3FilesClient()
            : base(new AmazonS3FilesConfig()) { }

        /// <summary>
        /// Constructs AmazonS3FilesClient with the credentials loaded from the application's
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
        public AmazonS3FilesClient(RegionEndpoint region)
            : base(new AmazonS3FilesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonS3FilesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonS3FilesClient Configuration Object</param>
        public AmazonS3FilesClient(AmazonS3FilesConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonS3FilesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3FilesClient(AWSCredentials credentials)
            : this(credentials, new AmazonS3FilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3FilesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3FilesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3FilesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3FilesClient with AWS Credentials and an
        /// AmazonS3FilesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3FilesClient Configuration Object</param>
        public AmazonS3FilesClient(AWSCredentials credentials, AmazonS3FilesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3FilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3FilesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3FilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3FilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3FilesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3FilesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3FilesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3FilesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3FilesClient Configuration Object</param>
        public AmazonS3FilesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3FilesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3FilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3FilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3FilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3FilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3FilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3FilesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3FilesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3FilesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3FilesClient Configuration Object</param>
        public AmazonS3FilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3FilesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IS3FilesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IS3FilesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new S3FilesPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonS3FilesEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonS3FilesAuthSchemeHandler());
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

        internal virtual CreateAccessPointResponse CreateAccessPoint(CreateAccessPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPointResponseUnmarshaller.Instance;

            return Invoke<CreateAccessPointResponse>(request, options);
        }



        /// <summary>
        /// Creates an S3 File System Access Point for application-specific access with POSIX
        /// user identity and root directory enforcement. Access points provide a way to manage
        /// access to shared datasets in multi-tenant scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPoint service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your service quotas and either delete
        /// resources or request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        public virtual Task<CreateAccessPointResponse> CreateAccessPointAsync(CreateAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccessPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFileSystem

        internal virtual CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileSystemResponseUnmarshaller.Instance;

            return Invoke<CreateFileSystemResponse>(request, options);
        }



        /// <summary>
        /// Creates an S3 File System resource scoped to a bucket or prefix within a bucket, enabling
        /// file system access to S3 data. To create a file system, you need an S3 bucket and
        /// an IAM role that grants the service permission to access the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your service quotas and either delete
        /// resources or request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        public virtual Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileSystemResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFileSystemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMountTarget

        internal virtual CreateMountTargetResponse CreateMountTarget(CreateMountTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMountTargetResponseUnmarshaller.Instance;

            return Invoke<CreateMountTargetResponse>(request, options);
        }



        /// <summary>
        /// Creates a mount target resource as an endpoint for mounting the S3 File System from
        /// compute resources in a specific Availability Zone and VPC. Mount targets provide network
        /// access to the file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMountTarget service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review your service quotas and either delete
        /// resources or request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/CreateMountTarget">REST API Reference for CreateMountTarget Operation</seealso>
        public virtual Task<CreateMountTargetResponse> CreateMountTargetAsync(CreateMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMountTargetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMountTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAccessPoint

        internal virtual DeleteAccessPointResponse DeleteAccessPoint(DeleteAccessPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPointResponse>(request, options);
        }



        /// <summary>
        /// Deletes an S3 File System Access Point. This operation is irreversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPoint service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        public virtual Task<DeleteAccessPointResponse> DeleteAccessPointAsync(DeleteAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccessPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFileSystem

        internal virtual DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemResponseUnmarshaller.Instance;

            return Invoke<DeleteFileSystemResponse>(request, options);
        }



        /// <summary>
        /// Deletes an S3 File System. You can optionally force deletion of a file system that
        /// has pending export data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        public virtual Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFileSystemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFileSystemPolicy

        internal virtual DeleteFileSystemPolicyResponse DeleteFileSystemPolicy(DeleteFileSystemPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteFileSystemPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the IAM resource policy of an S3 File System.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystemPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystemPolicy service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/DeleteFileSystemPolicy">REST API Reference for DeleteFileSystemPolicy Operation</seealso>
        public virtual Task<DeleteFileSystemPolicyResponse> DeleteFileSystemPolicyAsync(DeleteFileSystemPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFileSystemPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMountTarget

        internal virtual DeleteMountTargetResponse DeleteMountTarget(DeleteMountTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMountTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteMountTargetResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified mount target. This operation is irreversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMountTarget service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/DeleteMountTarget">REST API Reference for DeleteMountTarget Operation</seealso>
        public virtual Task<DeleteMountTargetResponse> DeleteMountTargetAsync(DeleteMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMountTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMountTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAccessPoint

        internal virtual GetAccessPointResponse GetAccessPoint(GetAccessPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointResponseUnmarshaller.Instance;

            return Invoke<GetAccessPointResponse>(request, options);
        }



        /// <summary>
        /// Returns resource information for an S3 File System Access Point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPoint service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetAccessPoint">REST API Reference for GetAccessPoint Operation</seealso>
        public virtual Task<GetAccessPointResponse> GetAccessPointAsync(GetAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccessPointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFileSystem

        internal virtual GetFileSystemResponse GetFileSystem(GetFileSystemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileSystemResponseUnmarshaller.Instance;

            return Invoke<GetFileSystemResponse>(request, options);
        }



        /// <summary>
        /// Returns resource information for the specified S3 File System including status, configuration,
        /// and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFileSystem service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetFileSystem">REST API Reference for GetFileSystem Operation</seealso>
        public virtual Task<GetFileSystemResponse> GetFileSystemAsync(GetFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileSystemResponseUnmarshaller.Instance;

            return InvokeAsync<GetFileSystemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFileSystemPolicy

        internal virtual GetFileSystemPolicyResponse GetFileSystemPolicy(GetFileSystemPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileSystemPolicyResponseUnmarshaller.Instance;

            return Invoke<GetFileSystemPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the IAM resource policy of an S3 File System.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFileSystemPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFileSystemPolicy service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetFileSystemPolicy">REST API Reference for GetFileSystemPolicy Operation</seealso>
        public virtual Task<GetFileSystemPolicyResponse> GetFileSystemPolicyAsync(GetFileSystemPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileSystemPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetFileSystemPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMountTarget

        internal virtual GetMountTargetResponse GetMountTarget(GetMountTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMountTargetResponseUnmarshaller.Instance;

            return Invoke<GetMountTargetResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed resource information for the specified mount target including network
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMountTarget service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetMountTarget">REST API Reference for GetMountTarget Operation</seealso>
        public virtual Task<GetMountTargetResponse> GetMountTargetAsync(GetMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMountTargetResponseUnmarshaller.Instance;

            return InvokeAsync<GetMountTargetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSynchronizationConfiguration

        internal virtual GetSynchronizationConfigurationResponse GetSynchronizationConfiguration(GetSynchronizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSynchronizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSynchronizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetSynchronizationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the synchronization configuration for the specified S3 File System, including
        /// import data rules and expiration data rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSynchronizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSynchronizationConfiguration service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/GetSynchronizationConfiguration">REST API Reference for GetSynchronizationConfiguration Operation</seealso>
        public virtual Task<GetSynchronizationConfigurationResponse> GetSynchronizationConfigurationAsync(GetSynchronizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSynchronizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSynchronizationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSynchronizationConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAccessPoints

        internal virtual ListAccessPointsResponse ListAccessPoints(ListAccessPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPointsResponseUnmarshaller.Instance;

            return Invoke<ListAccessPointsResponse>(request, options);
        }



        /// <summary>
        /// Returns resource information for all S3 File System Access Points associated with
        /// the specified S3 File System.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPoints service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/ListAccessPoints">REST API Reference for ListAccessPoints Operation</seealso>
        public virtual Task<ListAccessPointsResponse> ListAccessPointsAsync(ListAccessPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccessPointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFileSystems

        internal virtual ListFileSystemsResponse ListFileSystems(ListFileSystemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFileSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileSystemsResponseUnmarshaller.Instance;

            return Invoke<ListFileSystemsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all S3 File Systems owned by the account with optional filtering
        /// by bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileSystems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFileSystems service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/ListFileSystems">REST API Reference for ListFileSystems Operation</seealso>
        public virtual Task<ListFileSystemsResponse> ListFileSystemsAsync(ListFileSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFileSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileSystemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFileSystemsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMountTargets

        internal virtual ListMountTargetsResponse ListMountTargets(ListMountTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMountTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMountTargetsResponseUnmarshaller.Instance;

            return Invoke<ListMountTargetsResponse>(request, options);
        }



        /// <summary>
        /// Returns resource information for all mount targets with optional filtering by file
        /// system, access point, and VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMountTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMountTargets service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/ListMountTargets">REST API Reference for ListMountTargets Operation</seealso>
        public virtual Task<ListMountTargetsResponse> ListMountTargetsAsync(ListMountTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMountTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMountTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMountTargetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags for S3 Files resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutFileSystemPolicy

        internal virtual PutFileSystemPolicyResponse PutFileSystemPolicy(PutFileSystemPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFileSystemPolicyResponseUnmarshaller.Instance;

            return Invoke<PutFileSystemPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or replaces the IAM resource policy for an S3 File System to control access
        /// permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFileSystemPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFileSystemPolicy service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/PutFileSystemPolicy">REST API Reference for PutFileSystemPolicy Operation</seealso>
        public virtual Task<PutFileSystemPolicyResponse> PutFileSystemPolicyAsync(PutFileSystemPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFileSystemPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFileSystemPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutFileSystemPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutSynchronizationConfiguration

        internal virtual PutSynchronizationConfigurationResponse PutSynchronizationConfiguration(PutSynchronizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSynchronizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSynchronizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutSynchronizationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates the synchronization configuration for the specified S3 File System,
        /// including import data rules and expiration data rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSynchronizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSynchronizationConfiguration service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to create a resource that already exists or delete a resource that is in use.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/PutSynchronizationConfiguration">REST API Reference for PutSynchronizationConfiguration Operation</seealso>
        public virtual Task<PutSynchronizationConfigurationResponse> PutSynchronizationConfigurationAsync(PutSynchronizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSynchronizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSynchronizationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutSynchronizationConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Creates tags for S3 Files resources using standard Amazon Web Services tagging APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from S3 Files resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMountTarget

        internal virtual UpdateMountTargetResponse UpdateMountTarget(UpdateMountTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMountTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateMountTargetResponse>(request, options);
        }



        /// <summary>
        /// Updates the mount target resource, specifically security group configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMountTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMountTarget service method, as returned by S3Files.</returns>
        /// <exception cref="Amazon.S3Files.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource exists and that you
        /// have permission to access it.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ThrottlingException">
        /// The request was throttled. Retry your request using exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.S3Files.Model.ValidationException">
        /// The input parameters are not valid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3files-2025-05-05/UpdateMountTarget">REST API Reference for UpdateMountTarget Operation</seealso>
        public virtual Task<UpdateMountTargetResponse> UpdateMountTargetAsync(UpdateMountTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMountTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMountTargetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMountTargetResponse>(request, options, cancellationToken);
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