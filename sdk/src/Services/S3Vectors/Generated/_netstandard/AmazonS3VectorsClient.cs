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
 * Do not modify this file. This file is generated from the s3vectors-2025-07-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.S3Vectors.Model;
using Amazon.S3Vectors.Model.Internal.MarshallTransformations;
using Amazon.S3Vectors.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.S3Vectors
{
    /// <summary>
    /// <para>Implementation for accessing S3Vectors</para>
    ///
    /// Amazon S3 vector buckets are a bucket type to store and search vectors with sub-second
    /// search times. They are designed to provide dedicated API operations for you to interact
    /// with vectors to do similarity search. Within a vector bucket, you use a vector index
    /// to organize and logically group your vector data. When you make a write or read request,
    /// you direct it to a single vector index. You store your vector data as vectors. A vector
    /// contains a key (a name that you assign), a multi-dimensional vector, and, optionally,
    /// metadata that describes a vector. The key uniquely identifies the vector in a vector
    /// index.
    /// </summary>
    public partial class AmazonS3VectorsClient : AmazonServiceClient, IAmazonS3Vectors
    {
        private static IServiceMetadata serviceMetadata = new AmazonS3VectorsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3VectorsClient with the credentials loaded from the application's
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
        public AmazonS3VectorsClient()
            : base(new AmazonS3VectorsConfig()) { }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with the credentials loaded from the application's
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
        public AmazonS3VectorsClient(RegionEndpoint region)
            : base(new AmazonS3VectorsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonS3VectorsClient Configuration Object</param>
        public AmazonS3VectorsClient(AmazonS3VectorsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonS3VectorsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3VectorsClient(AWSCredentials credentials)
            : this(credentials, new AmazonS3VectorsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3VectorsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3VectorsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with AWS Credentials and an
        /// AmazonS3VectorsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3VectorsClient Configuration Object</param>
        public AmazonS3VectorsClient(AWSCredentials credentials, AmazonS3VectorsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3VectorsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3VectorsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3VectorsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3VectorsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3VectorsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3VectorsClient Configuration Object</param>
        public AmazonS3VectorsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3VectorsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3VectorsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3VectorsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3VectorsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3VectorsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3VectorsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3VectorsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3VectorsClient Configuration Object</param>
        public AmazonS3VectorsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3VectorsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IS3VectorsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IS3VectorsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new S3VectorsPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonS3VectorsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonS3VectorsAuthSchemeHandler());
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


        #region  CreateIndex

        internal virtual CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return Invoke<CreateIndexResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Creates a vector index within a vector bucket. To specify the vector bucket, you must
        /// use either the vector bucket name or the vector bucket Amazon Resource Name (ARN).
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:CreateIndex</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ConflictException">
        /// The request failed because a vector bucket name or a vector index name already exists.
        /// Vector bucket names must be unique within your Amazon Web Services account for each
        /// Amazon Web Services Region. Vector index names must be unique within your vector bucket.
        /// Choose a different vector bucket name or vector index name, and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIndexResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateVectorBucket

        internal virtual CreateVectorBucketResponse CreateVectorBucket(CreateVectorBucketRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVectorBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVectorBucketResponseUnmarshaller.Instance;

            return Invoke<CreateVectorBucketResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Creates a vector bucket in the Amazon Web Services Region that you want your bucket
        /// to be in. 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:CreateVectorBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVectorBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVectorBucket service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ConflictException">
        /// The request failed because a vector bucket name or a vector index name already exists.
        /// Vector bucket names must be unique within your Amazon Web Services account for each
        /// Amazon Web Services Region. Vector index names must be unique within your vector bucket.
        /// Choose a different vector bucket name or vector index name, and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/CreateVectorBucket">REST API Reference for CreateVectorBucket Operation</seealso>
        public virtual Task<CreateVectorBucketResponse> CreateVectorBucketAsync(CreateVectorBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVectorBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVectorBucketResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVectorBucketResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIndex

        internal virtual DeleteIndexResponse DeleteIndex(DeleteIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Deletes a vector index. To specify the vector index, you can either use both the vector
        /// bucket name and vector index name, or use the vector index Amazon Resource Name (ARN).
        /// 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:DeleteIndex</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual Task<DeleteIndexResponse> DeleteIndexAsync(DeleteIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIndexResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVectorBucket

        internal virtual DeleteVectorBucketResponse DeleteVectorBucket(DeleteVectorBucketRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVectorBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteVectorBucketResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Deletes a vector bucket. All vector indexes in the vector bucket must be deleted before
        /// the vector bucket can be deleted. To perform this operation, you must use either the
        /// vector bucket name or the vector bucket Amazon Resource Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:DeleteVectorBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVectorBucket service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ConflictException">
        /// The request failed because a vector bucket name or a vector index name already exists.
        /// Vector bucket names must be unique within your Amazon Web Services account for each
        /// Amazon Web Services Region. Vector index names must be unique within your vector bucket.
        /// Choose a different vector bucket name or vector index name, and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectorBucket">REST API Reference for DeleteVectorBucket Operation</seealso>
        public virtual Task<DeleteVectorBucketResponse> DeleteVectorBucketAsync(DeleteVectorBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVectorBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorBucketResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVectorBucketResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVectorBucketPolicy

        internal virtual DeleteVectorBucketPolicyResponse DeleteVectorBucketPolicy(DeleteVectorBucketPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVectorBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteVectorBucketPolicyResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Deletes a vector bucket policy. To specify the bucket, you must use either the vector
        /// bucket name or the vector bucket Amazon Resource Name (ARN).
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:DeleteVectorBucketPolicy</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVectorBucketPolicy service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectorBucketPolicy">REST API Reference for DeleteVectorBucketPolicy Operation</seealso>
        public virtual Task<DeleteVectorBucketPolicyResponse> DeleteVectorBucketPolicyAsync(DeleteVectorBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVectorBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVectorBucketPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVectors

        internal virtual DeleteVectorsResponse DeleteVectors(DeleteVectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorsResponseUnmarshaller.Instance;

            return Invoke<DeleteVectorsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Deletes one or more vectors in a vector index. To specify the vector index, you can
        /// either use both the vector bucket name and vector index name, or use the vector index
        /// Amazon Resource Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:DeleteVectors</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsDisabledException">
        /// The specified Amazon Web Services KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (<c>KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">InvalidKeyUsageException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidStateException">
        /// The key state of the KMS key isn't compatible with the operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">KMSInvalidStateException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsNotFoundException">
        /// The KMS key can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectors">REST API Reference for DeleteVectors Operation</seealso>
        public virtual Task<DeleteVectorsResponse> DeleteVectorsAsync(DeleteVectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVectorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIndex

        internal virtual GetIndexResponse GetIndex(GetIndexRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexResponseUnmarshaller.Instance;

            return Invoke<GetIndexResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Returns vector index attributes. To specify the vector index, you can either use both
        /// the vector bucket name and the vector index name, or use the vector index Amazon Resource
        /// Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:GetIndex</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIndex service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetIndex">REST API Reference for GetIndex Operation</seealso>
        public virtual Task<GetIndexResponse> GetIndexAsync(GetIndexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexResponseUnmarshaller.Instance;

            return InvokeAsync<GetIndexResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetVectorBucket

        internal virtual GetVectorBucketResponse GetVectorBucket(GetVectorBucketRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVectorBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorBucketResponseUnmarshaller.Instance;

            return Invoke<GetVectorBucketResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Returns vector bucket attributes. To specify the bucket, you must use either the vector
        /// bucket name or the vector bucket Amazon Resource Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:GetVectorBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectorBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVectorBucket service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectorBucket">REST API Reference for GetVectorBucket Operation</seealso>
        public virtual Task<GetVectorBucketResponse> GetVectorBucketAsync(GetVectorBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVectorBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorBucketResponseUnmarshaller.Instance;

            return InvokeAsync<GetVectorBucketResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetVectorBucketPolicy

        internal virtual GetVectorBucketPolicyResponse GetVectorBucketPolicy(GetVectorBucketPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVectorBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetVectorBucketPolicyResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Gets details about a vector bucket policy. To specify the bucket, you must use either
        /// the vector bucket name or the vector bucket Amazon Resource Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:GetVectorBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectorBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVectorBucketPolicy service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectorBucketPolicy">REST API Reference for GetVectorBucketPolicy Operation</seealso>
        public virtual Task<GetVectorBucketPolicyResponse> GetVectorBucketPolicyAsync(GetVectorBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVectorBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetVectorBucketPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetVectors

        internal virtual GetVectorsResponse GetVectors(GetVectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorsResponseUnmarshaller.Instance;

            return Invoke<GetVectorsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Returns vector attributes. To specify the vector index, you can either use both the
        /// vector bucket name and the vector index name, or use the vector index Amazon Resource
        /// Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:GetVectors</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsDisabledException">
        /// The specified Amazon Web Services KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (<c>KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">InvalidKeyUsageException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidStateException">
        /// The key state of the KMS key isn't compatible with the operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">KMSInvalidStateException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsNotFoundException">
        /// The KMS key can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectors">REST API Reference for GetVectors Operation</seealso>
        public virtual Task<GetVectorsResponse> GetVectorsAsync(GetVectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetVectorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIndexes

        internal virtual ListIndexesResponse ListIndexes(ListIndexesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexesResponseUnmarshaller.Instance;

            return Invoke<ListIndexesResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Returns a list of all the vector indexes within the specified vector bucket. To specify
        /// the bucket, you must use either the vector bucket name or the vector bucket Amazon
        /// Resource Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:ListIndexes</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndexes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIndexes service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListIndexes">REST API Reference for ListIndexes Operation</seealso>
        public virtual Task<ListIndexesResponse> ListIndexesAsync(ListIndexesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIndexesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVectorBuckets

        internal virtual ListVectorBucketsResponse ListVectorBuckets(ListVectorBucketsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVectorBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVectorBucketsResponseUnmarshaller.Instance;

            return Invoke<ListVectorBucketsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Returns a list of all the vector buckets that are owned by the authenticated sender
        /// of the request.
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:ListVectorBuckets</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVectorBuckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVectorBuckets service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListVectorBuckets">REST API Reference for ListVectorBuckets Operation</seealso>
        public virtual Task<ListVectorBucketsResponse> ListVectorBucketsAsync(ListVectorBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVectorBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVectorBucketsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVectorBucketsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVectors

        internal virtual ListVectorsResponse ListVectors(ListVectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVectorsResponseUnmarshaller.Instance;

            return Invoke<ListVectorsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// List vectors in the specified vector index. To specify the vector index, you can either
        /// use both the vector bucket name and the vector index name, or use the vector index
        /// Amazon Resource Name (ARN). 
        /// </para>
        ///  
        /// <para>
        ///  <c>ListVectors</c> operations proceed sequentially; however, for faster performance
        /// on a large number of vectors in a vector index, applications can request a parallel
        /// <c>ListVectors</c> operation by providing the <c>segmentCount</c> and <c>segmentIndex</c>
        /// parameters.
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:ListVectors</c> permission to use this operation. Additional
        /// permissions are required based on the request parameters you specify:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With only <c>s3vectors:ListVectors</c> permission, you can list vector keys when <c>returnData</c>
        /// and <c>returnMetadata</c> are both set to false or not specified..
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set <c>returnData</c> or <c>returnMetadata</c> to true, you must have both
        /// <c>s3vectors:ListVectors</c> and <c>s3vectors:GetVectors</c> permissions. The request
        /// fails with a <c>403 Forbidden</c> error if you request vector data or metadata without
        /// the <c>s3vectors:GetVectors</c> permission.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListVectors">REST API Reference for ListVectors Operation</seealso>
        public virtual Task<ListVectorsResponse> ListVectorsAsync(ListVectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVectorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVectorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutVectorBucketPolicy

        internal virtual PutVectorBucketPolicyResponse PutVectorBucketPolicy(PutVectorBucketPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutVectorBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVectorBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutVectorBucketPolicyResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Creates a bucket policy for a vector bucket. To specify the bucket, you must use either
        /// the vector bucket name or the vector bucket Amazon Resource Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:PutVectorBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVectorBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVectorBucketPolicy service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/PutVectorBucketPolicy">REST API Reference for PutVectorBucketPolicy Operation</seealso>
        public virtual Task<PutVectorBucketPolicyResponse> PutVectorBucketPolicyAsync(PutVectorBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutVectorBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVectorBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutVectorBucketPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutVectors

        internal virtual PutVectorsResponse PutVectors(PutVectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVectorsResponseUnmarshaller.Instance;

            return Invoke<PutVectorsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Adds one or more vectors to a vector index. To specify the vector index, you can either
        /// use both the vector bucket name and the vector index name, or use the vector index
        /// Amazon Resource Name (ARN). 
        /// </para>
        ///  
        /// <para>
        /// For more information about limits, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-vectors-limitations.html">Limitations
        /// and restrictions</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When inserting vector data into your vector index, you must provide the vector data
        /// as <c>float32</c> (32-bit floating point) values. If you pass higher-precision values
        /// to an Amazon Web Services SDK, S3 Vectors converts the values to 32-bit floating point
        /// before storing them, and <c>GetVectors</c>, <c>ListVectors</c>, and <c>QueryVectors</c>
        /// operations return the float32 values. Different Amazon Web Services SDKs may have
        /// different default numeric types, so ensure your vectors are properly formatted as
        /// <c>float32</c> values regardless of which SDK you're using. For example, in Python,
        /// use <c>numpy.float32</c> or explicitly cast your values.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:PutVectors</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsDisabledException">
        /// The specified Amazon Web Services KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (<c>KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">InvalidKeyUsageException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidStateException">
        /// The key state of the KMS key isn't compatible with the operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">KMSInvalidStateException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsNotFoundException">
        /// The KMS key can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/PutVectors">REST API Reference for PutVectors Operation</seealso>
        public virtual Task<PutVectorsResponse> PutVectorsAsync(PutVectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVectorsResponseUnmarshaller.Instance;

            return InvokeAsync<PutVectorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryVectors

        internal virtual QueryVectorsResponse QueryVectors(QueryVectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryVectorsResponseUnmarshaller.Instance;

            return Invoke<QueryVectorsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
        /// 
        ///  </note> 
        /// <para>
        /// Performs an approximate nearest neighbor search query in a vector index using a query
        /// vector. By default, it returns the keys of approximate nearest neighbors. You can
        /// optionally include the computed distance (between the query vector and each vector
        /// in the response), the vector data, and metadata of each vector in the response. 
        /// </para>
        ///  
        /// <para>
        /// To specify the vector index, you can either use both the vector bucket name and the
        /// vector index name, or use the vector index Amazon Resource Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:QueryVectors</c> permission to use this operation.
        /// Additional permissions are required based on the request parameters you specify:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With only <c>s3vectors:QueryVectors</c> permission, you can retrieve vector keys of
        /// approximate nearest neighbors and computed distances between these vectors. This permission
        /// is sufficient only when you don't set any metadata filters and don't request vector
        /// data or metadata (by keeping the <c>returnMetadata</c> parameter set to <c>false</c>
        /// or not specified).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a metadata filter or set <c>returnMetadata</c> to true, you must have
        /// both <c>s3vectors:QueryVectors</c> and <c>s3vectors:GetVectors</c> permissions. The
        /// request fails with a <c>403 Forbidden error</c> if you request metadata filtering,
        /// vector data, or metadata without the <c>s3vectors:GetVectors</c> permission.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryVectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsDisabledException">
        /// The specified Amazon Web Services KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (<c>KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">InvalidKeyUsageException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidStateException">
        /// The key state of the KMS key isn't compatible with the operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">KMSInvalidStateException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsNotFoundException">
        /// The KMS key can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/QueryVectors">REST API Reference for QueryVectors Operation</seealso>
        public virtual Task<QueryVectorsResponse> QueryVectorsAsync(QueryVectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryVectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryVectorsResponseUnmarshaller.Instance;

            return InvokeAsync<QueryVectorsResponse>(request, options, cancellationToken);
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