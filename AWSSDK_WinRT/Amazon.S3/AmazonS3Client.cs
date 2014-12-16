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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3
{
    /// <summary>
    /// Implementation for accessing S3
    ///
    /// 
    /// </summary>
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3Client(AWSCredentials credentials)
            : this(credentials, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials and an
        /// AmazonS3Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AWSCredentials credentials, AmazonS3Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new S3Signer();
        } 

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PreMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PostMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.EndpointResolver>(new Amazon.S3.Internal.AmazonS3KmsHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3ResponseHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.S3.Internal.AmazonS3ExceptionHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3RedirectHandler());
            pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.S3.Internal.AmazonS3RetryPolicy(this.Config.MaxErrorRetry)));
        }

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AbortMultipartUpload

        internal AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadRequest,AbortMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortMultipartUploadRequest,AbortMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CompleteMultipartUpload

        internal CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyObject

        internal CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            var marshaller = new CopyObjectRequestMarshaller();
            var unmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return Invoke<CopyObjectRequest,CopyObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyObjectRequestMarshaller();
            var unmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return InvokeAsync<CopyObjectRequest,CopyObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyPart

        internal CopyPartResponse CopyPart(CopyPartRequest request)
        {
            var marshaller = new CopyPartRequestMarshaller();
            var unmarshaller = CopyPartResponseUnmarshaller.Instance;

            return Invoke<CopyPartRequest,CopyPartResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyPartResponse> CopyPartAsync(CopyPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyPartRequestMarshaller();
            var unmarshaller = CopyPartResponseUnmarshaller.Instance;

            return InvokeAsync<CopyPartRequest,CopyPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucket

        internal DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            var marshaller = new DeleteBucketRequestMarshaller();
            var unmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketRequest,DeleteBucketResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketRequestMarshaller();
            var unmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketRequest,DeleteBucketResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketPolicy

        internal DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            var marshaller = new DeleteBucketPolicyRequestMarshaller();
            var unmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketPolicyRequest,DeleteBucketPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketPolicyRequestMarshaller();
            var unmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketPolicyRequest,DeleteBucketPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketTagging

        internal DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            var marshaller = new DeleteBucketTaggingRequestMarshaller();
            var unmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketTaggingRequest,DeleteBucketTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketTaggingRequestMarshaller();
            var unmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketTaggingRequest,DeleteBucketTaggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketWebsite

        internal DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request)
        {
            var marshaller = new DeleteBucketWebsiteRequestMarshaller();
            var unmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketWebsiteRequest,DeleteBucketWebsiteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketWebsiteRequestMarshaller();
            var unmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketWebsiteRequest,DeleteBucketWebsiteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCORSConfiguration

        internal DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request)
        {
            var marshaller = new DeleteCORSConfigurationRequestMarshaller();
            var unmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCORSConfigurationRequest,DeleteCORSConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCORSConfigurationRequestMarshaller();
            var unmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCORSConfigurationRequest,DeleteCORSConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecycleConfiguration

        internal DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request)
        {
            var marshaller = new DeleteLifecycleConfigurationRequestMarshaller();
            var unmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleConfigurationRequest,DeleteLifecycleConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLifecycleConfigurationRequestMarshaller();
            var unmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecycleConfigurationRequest,DeleteLifecycleConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteObject

        internal DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteObjects

        internal DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request)
        {
            var marshaller = new DeleteObjectsRequestMarshaller();
            var unmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectsRequest,DeleteObjectsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteObjectsResponse> DeleteObjectsAsync(DeleteObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteObjectsRequestMarshaller();
            var unmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectsRequest,DeleteObjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetACL

        internal GetACLResponse GetACL(GetACLRequest request)
        {
            var marshaller = new GetACLRequestMarshaller();
            var unmarshaller = GetACLResponseUnmarshaller.Instance;

            return Invoke<GetACLRequest,GetACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetACLResponse> GetACLAsync(GetACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetACLRequestMarshaller();
            var unmarshaller = GetACLResponseUnmarshaller.Instance;

            return InvokeAsync<GetACLRequest,GetACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketLocation

        internal GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request)
        {
            var marshaller = new GetBucketLocationRequestMarshaller();
            var unmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return Invoke<GetBucketLocationRequest,GetBucketLocationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketLocationRequestMarshaller();
            var unmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketLocationRequest,GetBucketLocationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketLogging

        internal GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request)
        {
            var marshaller = new GetBucketLoggingRequestMarshaller();
            var unmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketLoggingRequest,GetBucketLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketLoggingRequestMarshaller();
            var unmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketLoggingRequest,GetBucketLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketNotification

        internal GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest request)
        {
            var marshaller = new GetBucketNotificationRequestMarshaller();
            var unmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<GetBucketNotificationRequest,GetBucketNotificationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBucketNotificationResponse> GetBucketNotificationAsync(GetBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketNotificationRequestMarshaller();
            var unmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketNotificationRequest,GetBucketNotificationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketPolicy

        internal GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            var marshaller = new GetBucketPolicyRequestMarshaller();
            var unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyRequest,GetBucketPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketPolicyRequestMarshaller();
            var unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketPolicyRequest,GetBucketPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketRequestPayment

        internal GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request)
        {
            var marshaller = new GetBucketRequestPaymentRequestMarshaller();
            var unmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<GetBucketRequestPaymentRequest,GetBucketRequestPaymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketRequestPaymentRequestMarshaller();
            var unmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketRequestPaymentRequest,GetBucketRequestPaymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketTagging

        internal GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request)
        {
            var marshaller = new GetBucketTaggingRequestMarshaller();
            var unmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketTaggingRequest,GetBucketTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketTaggingRequestMarshaller();
            var unmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketTaggingRequest,GetBucketTaggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketVersioning

        internal GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request)
        {
            var marshaller = new GetBucketVersioningRequestMarshaller();
            var unmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<GetBucketVersioningRequest,GetBucketVersioningResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBucketVersioningResponse> GetBucketVersioningAsync(GetBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketVersioningRequestMarshaller();
            var unmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketVersioningRequest,GetBucketVersioningResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBucketWebsite

        internal GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request)
        {
            var marshaller = new GetBucketWebsiteRequestMarshaller();
            var unmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<GetBucketWebsiteRequest,GetBucketWebsiteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketWebsiteRequestMarshaller();
            var unmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketWebsiteRequest,GetBucketWebsiteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCORSConfiguration

        internal GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request)
        {
            var marshaller = new GetCORSConfigurationRequestMarshaller();
            var unmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetCORSConfigurationRequest,GetCORSConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(GetCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCORSConfigurationRequestMarshaller();
            var unmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCORSConfigurationRequest,GetCORSConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLifecycleConfiguration

        internal GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request)
        {
            var marshaller = new GetLifecycleConfigurationRequestMarshaller();
            var unmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLifecycleConfigurationRequest,GetLifecycleConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetLifecycleConfigurationRequestMarshaller();
            var unmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecycleConfigurationRequest,GetLifecycleConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObject

        internal GetObjectResponse GetObject(GetObjectRequest request)
        {
            var marshaller = new GetObjectRequestMarshaller();
            var unmarshaller = GetObjectResponseUnmarshaller.Instance;

            return Invoke<GetObjectRequest,GetObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectRequestMarshaller();
            var unmarshaller = GetObjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectRequest,GetObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObjectMetadata

        internal GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
        {
            var marshaller = new GetObjectMetadataRequestMarshaller();
            var unmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return Invoke<GetObjectMetadataRequest,GetObjectMetadataResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectMetadataRequestMarshaller();
            var unmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectMetadataRequest,GetObjectMetadataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetObjectTorrent

        internal GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest request)
        {
            var marshaller = new GetObjectTorrentRequestMarshaller();
            var unmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return Invoke<GetObjectTorrentRequest,GetObjectTorrentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetObjectTorrentResponse> GetObjectTorrentAsync(GetObjectTorrentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectTorrentRequestMarshaller();
            var unmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectTorrentRequest,GetObjectTorrentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  HeadBucket

        internal HeadBucketResponse HeadBucket(HeadBucketRequest request)
        {
            var marshaller = new HeadBucketRequestMarshaller();
            var unmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return Invoke<HeadBucketRequest,HeadBucketResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HeadBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HeadBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        internal Task<HeadBucketResponse> HeadBucketAsync(HeadBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new HeadBucketRequestMarshaller();
            var unmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return InvokeAsync<HeadBucketRequest,HeadBucketResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateMultipartUpload

        internal InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBuckets

        internal ListBucketsResponse ListBuckets()
        {
            return ListBuckets(new ListBucketsRequest());
        }
        internal ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            var marshaller = new ListBucketsRequestMarshaller();
            var unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return Invoke<ListBucketsRequest,ListBucketsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBucketsRequestMarshaller();
            var unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketsRequest,ListBucketsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMultipartUploads

        internal ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsRequest,ListMultipartUploadsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMultipartUploadsRequest,ListMultipartUploadsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListObjects

        internal ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            var marshaller = new ListObjectsRequestMarshaller();
            var unmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return Invoke<ListObjectsRequest,ListObjectsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListObjectsRequestMarshaller();
            var unmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectsRequest,ListObjectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListParts

        internal ListPartsResponse ListParts(ListPartsRequest request)
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsRequest,ListPartsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartsRequest,ListPartsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVersions

        internal ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            var marshaller = new ListVersionsRequestMarshaller();
            var unmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return Invoke<ListVersionsRequest,ListVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVersionsRequestMarshaller();
            var unmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVersionsRequest,ListVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutACL

        internal PutACLResponse PutACL(PutACLRequest request)
        {
            var marshaller = new PutACLRequestMarshaller();
            var unmarshaller = PutACLResponseUnmarshaller.Instance;

            return Invoke<PutACLRequest,PutACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutACLResponse> PutACLAsync(PutACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutACLRequestMarshaller();
            var unmarshaller = PutACLResponseUnmarshaller.Instance;

            return InvokeAsync<PutACLRequest,PutACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucket

        internal PutBucketResponse PutBucket(PutBucketRequest request)
        {
            var marshaller = new PutBucketRequestMarshaller();
            var unmarshaller = PutBucketResponseUnmarshaller.Instance;

            return Invoke<PutBucketRequest,PutBucketResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutBucketResponse> PutBucketAsync(PutBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketRequestMarshaller();
            var unmarshaller = PutBucketResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketRequest,PutBucketResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketLogging

        internal PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request)
        {
            var marshaller = new PutBucketLoggingRequestMarshaller();
            var unmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketLoggingRequest,PutBucketLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketLoggingRequestMarshaller();
            var unmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketLoggingRequest,PutBucketLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketNotification

        internal PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest request)
        {
            var marshaller = new PutBucketNotificationRequestMarshaller();
            var unmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<PutBucketNotificationRequest,PutBucketNotificationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutBucketNotificationResponse> PutBucketNotificationAsync(PutBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketNotificationRequestMarshaller();
            var unmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketNotificationRequest,PutBucketNotificationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketPolicy

        internal PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
        {
            var marshaller = new PutBucketPolicyRequestMarshaller();
            var unmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBucketPolicyRequest,PutBucketPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketPolicyRequestMarshaller();
            var unmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketPolicyRequest,PutBucketPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketRequestPayment

        internal PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request)
        {
            var marshaller = new PutBucketRequestPaymentRequestMarshaller();
            var unmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<PutBucketRequestPaymentRequest,PutBucketRequestPaymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketRequestPaymentRequestMarshaller();
            var unmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketRequestPaymentRequest,PutBucketRequestPaymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketTagging

        internal PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request)
        {
            var marshaller = new PutBucketTaggingRequestMarshaller();
            var unmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketTaggingRequest,PutBucketTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketTaggingRequestMarshaller();
            var unmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketTaggingRequest,PutBucketTaggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketVersioning

        internal PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest request)
        {
            var marshaller = new PutBucketVersioningRequestMarshaller();
            var unmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<PutBucketVersioningRequest,PutBucketVersioningResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutBucketVersioningResponse> PutBucketVersioningAsync(PutBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketVersioningRequestMarshaller();
            var unmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketVersioningRequest,PutBucketVersioningResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutBucketWebsite

        internal PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request)
        {
            var marshaller = new PutBucketWebsiteRequestMarshaller();
            var unmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<PutBucketWebsiteRequest,PutBucketWebsiteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketWebsiteRequestMarshaller();
            var unmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketWebsiteRequest,PutBucketWebsiteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutCORSConfiguration

        internal PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request)
        {
            var marshaller = new PutCORSConfigurationRequestMarshaller();
            var unmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutCORSConfigurationRequest,PutCORSConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(PutCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutCORSConfigurationRequestMarshaller();
            var unmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutCORSConfigurationRequest,PutCORSConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleConfiguration

        internal PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            var marshaller = new PutLifecycleConfigurationRequestMarshaller();
            var unmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleConfigurationRequest,PutLifecycleConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutLifecycleConfigurationRequestMarshaller();
            var unmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecycleConfigurationRequest,PutLifecycleConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutObject

        internal PutObjectResponse PutObject(PutObjectRequest request)
        {
            var marshaller = new PutObjectRequestMarshaller();
            var unmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectRequest,PutObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutObjectRequestMarshaller();
            var unmarshaller = PutObjectResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectRequest,PutObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreObject

        internal RestoreObjectResponse RestoreObject(RestoreObjectRequest request)
        {
            var marshaller = new RestoreObjectRequestMarshaller();
            var unmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return Invoke<RestoreObjectRequest,RestoreObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreObjectRequestMarshaller();
            var unmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreObjectRequest,RestoreObjectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadPart

        internal UploadPartResponse UploadPart(UploadPartRequest request)
        {
            var marshaller = new UploadPartRequestMarshaller();
            var unmarshaller = UploadPartResponseUnmarshaller.Instance;

            return Invoke<UploadPartRequest,UploadPartResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadPartResponse> UploadPartAsync(UploadPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadPartRequestMarshaller();
            var unmarshaller = UploadPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadPartRequest,UploadPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}