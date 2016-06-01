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

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new Amazon.S3.Internal.S3Signer();
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PreMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PostMarshallHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.EndpointResolver>(new Amazon.S3.Internal.AmazonS3HttpDeleteHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.EndpointResolver>(new Amazon.S3.Internal.AmazonS3KmsHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3ResponseHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.S3.Internal.AmazonS3ExceptionHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3RedirectHandler());
            pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.S3.Internal.AmazonS3RetryPolicy(this.Config.MaxErrorRetry)));
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

        
        #region  AbortMultipartUpload

        /// <summary>
        /// Aborts a multipart upload.
        /// 
        /// 
        /// <para>
        /// To verify that all parts have been removed, so you don't get charged for the part
        /// storage, you should call the List Parts operation and ensure the parts list is empty.
        /// </para>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="key">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="uploadId">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        public void AbortMultipartUploadAsync(string bucketName, string key, string uploadId,  AmazonServiceCallback<AbortMultipartUploadRequest, AbortMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            var request = new AbortMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            AbortMultipartUploadAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void AbortMultipartUploadAsync(AbortMultipartUploadRequest request, AmazonServiceCallback<AbortMultipartUploadRequest, AbortMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("AbortMultipartUpload is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AbortMultipartUploadRequest,AbortMultipartUploadResponse> responseObject 
                            = new AmazonServiceResult<AbortMultipartUploadRequest,AbortMultipartUploadResponse>((AbortMultipartUploadRequest)req, (AbortMultipartUploadResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<AbortMultipartUploadRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CompleteMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, AmazonServiceCallback<CompleteMultipartUploadRequest, CompleteMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("CompleteMultipartUpload is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse> responseObject 
                            = new AmazonServiceResult<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>((CompleteMultipartUploadRequest)req, (CompleteMultipartUploadResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CompleteMultipartUploadRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CopyObject

        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public void CopyObjectAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey,  AmazonServiceCallback<CopyObjectRequest, CopyObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            CopyObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceVersionId">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public void CopyObjectAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey,  AmazonServiceCallback<CopyObjectRequest, CopyObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            CopyObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void CopyObjectAsync(CopyObjectRequest request, AmazonServiceCallback<CopyObjectRequest, CopyObjectResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("CopyObject is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new CopyObjectRequestMarshaller();
            var unmarshaller = CopyObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CopyObjectRequest,CopyObjectResponse> responseObject 
                            = new AmazonServiceResult<CopyObjectRequest,CopyObjectResponse>((CopyObjectRequest)req, (CopyObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CopyObjectRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  CopyPart

        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public void CopyPartAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId,  AmazonServiceCallback<CopyPartRequest, CopyPartResponse> callback, AsyncOptions options = null)
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            CopyPartAsync(request, callback, options);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceVersionId">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public void CopyPartAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId,  AmazonServiceCallback<CopyPartRequest, CopyPartResponse> callback, AsyncOptions options = null)
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            CopyPartAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPart operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void CopyPartAsync(CopyPartRequest request, AmazonServiceCallback<CopyPartRequest, CopyPartResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("CopyPart is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new CopyPartRequestMarshaller();
            var unmarshaller = CopyPartResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CopyPartRequest,CopyPartResponse> responseObject 
                            = new AmazonServiceResult<CopyPartRequest,CopyPartResponse>((CopyPartRequest)req, (CopyPartResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CopyPartRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucket

        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and Delete Markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketRequest used to execute the DeleteBucket service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        public void DeleteBucketAsync(string bucketName,  AmazonServiceCallback<DeleteBucketRequest, DeleteBucketResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteBucketRequest();
            request.BucketName = bucketName;
            DeleteBucketAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteBucketAsync(DeleteBucketRequest request, AmazonServiceCallback<DeleteBucketRequest, DeleteBucketResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucket is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteBucketRequestMarshaller();
            var unmarshaller = DeleteBucketResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketRequest,DeleteBucketResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketRequest,DeleteBucketResponse>((DeleteBucketRequest)req, (DeleteBucketResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteBucketRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketPolicy

        /// <summary>
        /// Deletes the policy from the bucket.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketPolicyRequest used to execute the DeleteBucketPolicy service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        public void DeleteBucketPolicyAsync(string bucketName,  AmazonServiceCallback<DeleteBucketPolicyRequest, DeleteBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteBucketPolicyRequest();
            request.BucketName = bucketName;
            DeleteBucketPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, AmazonServiceCallback<DeleteBucketPolicyRequest, DeleteBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketPolicy is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteBucketPolicyRequestMarshaller();
            var unmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketPolicyRequest,DeleteBucketPolicyResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketPolicyRequest,DeleteBucketPolicyResponse>((DeleteBucketPolicyRequest)req, (DeleteBucketPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteBucketPolicyRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketReplication

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketReplication operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteBucketReplicationAsync(DeleteBucketReplicationRequest request, AmazonServiceCallback<DeleteBucketReplicationRequest, DeleteBucketReplicationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketReplication is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteBucketReplicationRequestMarshaller();
            var unmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketReplicationRequest,DeleteBucketReplicationResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketReplicationRequest,DeleteBucketReplicationResponse>((DeleteBucketReplicationRequest)req, (DeleteBucketReplicationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteBucketReplicationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketTagging

        /// <summary>
        /// Deletes the tags from the bucket.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketTaggingRequest used to execute the DeleteBucketTagging service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        public void DeleteBucketTaggingAsync(string bucketName,  AmazonServiceCallback<DeleteBucketTaggingRequest, DeleteBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteBucketTaggingRequest();
            request.BucketName = bucketName;
            DeleteBucketTaggingAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, AmazonServiceCallback<DeleteBucketTaggingRequest, DeleteBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketTagging is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteBucketTaggingRequestMarshaller();
            var unmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketTaggingRequest,DeleteBucketTaggingResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketTaggingRequest,DeleteBucketTaggingResponse>((DeleteBucketTaggingRequest)req, (DeleteBucketTaggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteBucketTaggingRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketWebsite

        /// <summary>
        /// This operation removes the website configuration from the bucket.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketWebsiteRequest used to execute the DeleteBucketWebsite service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        public void DeleteBucketWebsiteAsync(string bucketName,  AmazonServiceCallback<DeleteBucketWebsiteRequest, DeleteBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteBucketWebsiteRequest();
            request.BucketName = bucketName;
            DeleteBucketWebsiteAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, AmazonServiceCallback<DeleteBucketWebsiteRequest, DeleteBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketWebsite is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteBucketWebsiteRequestMarshaller();
            var unmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketWebsiteRequest,DeleteBucketWebsiteResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketWebsiteRequest,DeleteBucketWebsiteResponse>((DeleteBucketWebsiteRequest)req, (DeleteBucketWebsiteResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteBucketWebsiteRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteCORSConfiguration

        /// <summary>
        /// Deletes the cors configuration information set for the bucket.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of DeleteCORSConfigurationRequest used to execute the DeleteCORSConfiguration service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public void DeleteCORSConfigurationAsync(string bucketName,  AmazonServiceCallback<DeleteCORSConfigurationRequest, DeleteCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteCORSConfigurationRequest();
            request.BucketName = bucketName;
            DeleteCORSConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest request, AmazonServiceCallback<DeleteCORSConfigurationRequest, DeleteCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteCORSConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteCORSConfigurationRequestMarshaller();
            var unmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteCORSConfigurationRequest,DeleteCORSConfigurationResponse> responseObject 
                            = new AmazonServiceResult<DeleteCORSConfigurationRequest,DeleteCORSConfigurationResponse>((DeleteCORSConfigurationRequest)req, (DeleteCORSConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteCORSConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteLifecycleConfiguration

        /// <summary>
        /// Deletes the lifecycle configuration from the bucket.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of DeleteLifecycleConfigurationRequest used to execute the DeleteLifecycleConfiguration service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        public void DeleteLifecycleConfigurationAsync(string bucketName,  AmazonServiceCallback<DeleteLifecycleConfigurationRequest, DeleteLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            DeleteLifecycleConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest request, AmazonServiceCallback<DeleteLifecycleConfigurationRequest, DeleteLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteLifecycleConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteLifecycleConfigurationRequestMarshaller();
            var unmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteLifecycleConfigurationRequest,DeleteLifecycleConfigurationResponse> responseObject 
                            = new AmazonServiceResult<DeleteLifecycleConfigurationRequest,DeleteLifecycleConfigurationResponse>((DeleteLifecycleConfigurationRequest)req, (DeleteLifecycleConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteLifecycleConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteObject

        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public void DeleteObjectAsync(string bucketName, string key,  AmazonServiceCallback<DeleteObjectRequest, DeleteObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            DeleteObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public void DeleteObjectAsync(string bucketName, string key, string versionId,  AmazonServiceCallback<DeleteObjectRequest, DeleteObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            DeleteObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteObjectAsync(DeleteObjectRequest request, AmazonServiceCallback<DeleteObjectRequest, DeleteObjectResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteObject is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteObjectRequest,DeleteObjectResponse> responseObject 
                            = new AmazonServiceResult<DeleteObjectRequest,DeleteObjectResponse>((DeleteObjectRequest)req, (DeleteObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteObjectRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteObjects

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void DeleteObjectsAsync(DeleteObjectsRequest request, AmazonServiceCallback<DeleteObjectsRequest, DeleteObjectsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new DeleteObjectsRequestMarshaller();
            var unmarshaller = DeleteObjectsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteObjectsRequest,DeleteObjectsResponse> responseObject 
                            = new AmazonServiceResult<DeleteObjectsRequest,DeleteObjectsResponse>((DeleteObjectsRequest)req, (DeleteObjectsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteObjectsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetACL

        /// <summary>
        /// Gets the access control policy for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetACLRequest used to execute the GetACL service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        public void GetACLAsync(string bucketName,  AmazonServiceCallback<GetACLRequest, GetACLResponse> callback, AsyncOptions options = null)
        {
            var request = new GetACLRequest();
            request.BucketName = bucketName;
            GetACLAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetACL operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetACLAsync(GetACLRequest request, AmazonServiceCallback<GetACLRequest, GetACLResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetACLRequestMarshaller();
            var unmarshaller = GetACLResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetACLRequest,GetACLResponse> responseObject 
                            = new AmazonServiceResult<GetACLRequest,GetACLResponse>((GetACLRequest)req, (GetACLResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetACLRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketAccelerateConfiguration

        /// <summary>
        /// Returns the accelerate configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket for which the accelerate configuration is retrieved.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public void GetBucketAccelerateConfigurationAsync(string bucketName,  AmazonServiceCallback<GetBucketAccelerateConfigurationRequest, GetBucketAccelerateConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketAccelerateConfigurationRequest();
            request.BucketName = bucketName;
            GetBucketAccelerateConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccelerateConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketAccelerateConfigurationAsync(GetBucketAccelerateConfigurationRequest request, AmazonServiceCallback<GetBucketAccelerateConfigurationRequest, GetBucketAccelerateConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketAccelerateConfigurationRequest,GetBucketAccelerateConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketAccelerateConfigurationRequest,GetBucketAccelerateConfigurationResponse>((GetBucketAccelerateConfigurationRequest)req, (GetBucketAccelerateConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketAccelerateConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketLocation

        /// <summary>
        /// Returns the region the bucket resides in.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLocationRequest used to execute the GetBucketLocation service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        public void GetBucketLocationAsync(string bucketName,  AmazonServiceCallback<GetBucketLocationRequest, GetBucketLocationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketLocationRequest();
            request.BucketName = bucketName;
            GetBucketLocationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketLocationAsync(GetBucketLocationRequest request, AmazonServiceCallback<GetBucketLocationRequest, GetBucketLocationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketLocationRequestMarshaller();
            var unmarshaller = GetBucketLocationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketLocationRequest,GetBucketLocationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketLocationRequest,GetBucketLocationResponse>((GetBucketLocationRequest)req, (GetBucketLocationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketLocationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketLogging

        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLoggingRequest used to execute the GetBucketLogging service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        public void GetBucketLoggingAsync(string bucketName,  AmazonServiceCallback<GetBucketLoggingRequest, GetBucketLoggingResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketLoggingRequest();
            request.BucketName = bucketName;
            GetBucketLoggingAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketLoggingAsync(GetBucketLoggingRequest request, AmazonServiceCallback<GetBucketLoggingRequest, GetBucketLoggingResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketLoggingRequestMarshaller();
            var unmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketLoggingRequest,GetBucketLoggingResponse> responseObject 
                            = new AmazonServiceResult<GetBucketLoggingRequest,GetBucketLoggingResponse>((GetBucketLoggingRequest)req, (GetBucketLoggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketLoggingRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketNotification

        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket to get the notification configuration for.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        public void GetBucketNotificationAsync(string bucketName,  AmazonServiceCallback<GetBucketNotificationRequest, GetBucketNotificationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketNotificationRequest();
            request.BucketName = bucketName;
            GetBucketNotificationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketNotificationAsync(GetBucketNotificationRequest request, AmazonServiceCallback<GetBucketNotificationRequest, GetBucketNotificationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketNotificationRequestMarshaller();
            var unmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketNotificationRequest,GetBucketNotificationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketNotificationRequest,GetBucketNotificationResponse>((GetBucketNotificationRequest)req, (GetBucketNotificationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketNotificationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketPolicy

        /// <summary>
        /// Returns the policy of a specified bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketPolicyRequest used to execute the GetBucketPolicy service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        public void GetBucketPolicyAsync(string bucketName,  AmazonServiceCallback<GetBucketPolicyRequest, GetBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketPolicyRequest();
            request.BucketName = bucketName;
            GetBucketPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketPolicyAsync(GetBucketPolicyRequest request, AmazonServiceCallback<GetBucketPolicyRequest, GetBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketPolicyRequestMarshaller();
            var unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketPolicyRequest,GetBucketPolicyResponse> responseObject 
                            = new AmazonServiceResult<GetBucketPolicyRequest,GetBucketPolicyResponse>((GetBucketPolicyRequest)req, (GetBucketPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketPolicyRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketReplication

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketReplication operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketReplicationAsync(GetBucketReplicationRequest request, AmazonServiceCallback<GetBucketReplicationRequest, GetBucketReplicationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("GetBucketReplication is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketReplicationRequestMarshaller();
            var unmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketReplicationRequest,GetBucketReplicationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketReplicationRequest,GetBucketReplicationResponse>((GetBucketReplicationRequest)req, (GetBucketReplicationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketReplicationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketRequestPayment

        /// <summary>
        /// Returns the request payment configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketRequestPaymentRequest used to execute the GetBucketRequestPayment service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        public void GetBucketRequestPaymentAsync(string bucketName,  AmazonServiceCallback<GetBucketRequestPaymentRequest, GetBucketRequestPaymentResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            GetBucketRequestPaymentAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, AmazonServiceCallback<GetBucketRequestPaymentRequest, GetBucketRequestPaymentResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketRequestPaymentRequestMarshaller();
            var unmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketRequestPaymentRequest,GetBucketRequestPaymentResponse> responseObject 
                            = new AmazonServiceResult<GetBucketRequestPaymentRequest,GetBucketRequestPaymentResponse>((GetBucketRequestPaymentRequest)req, (GetBucketRequestPaymentResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketRequestPaymentRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketTaggingAsync(GetBucketTaggingRequest request, AmazonServiceCallback<GetBucketTaggingRequest, GetBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketTaggingRequestMarshaller();
            var unmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketTaggingRequest,GetBucketTaggingResponse> responseObject 
                            = new AmazonServiceResult<GetBucketTaggingRequest,GetBucketTaggingResponse>((GetBucketTaggingRequest)req, (GetBucketTaggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketTaggingRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketVersioning

        /// <summary>
        /// Returns the versioning state of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketVersioningRequest used to execute the GetBucketVersioning service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        public void GetBucketVersioningAsync(string bucketName,  AmazonServiceCallback<GetBucketVersioningRequest, GetBucketVersioningResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketVersioningRequest();
            request.BucketName = bucketName;
            GetBucketVersioningAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketVersioningAsync(GetBucketVersioningRequest request, AmazonServiceCallback<GetBucketVersioningRequest, GetBucketVersioningResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketVersioningRequestMarshaller();
            var unmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketVersioningRequest,GetBucketVersioningResponse> responseObject 
                            = new AmazonServiceResult<GetBucketVersioningRequest,GetBucketVersioningResponse>((GetBucketVersioningRequest)req, (GetBucketVersioningResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketVersioningRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketWebsite

        /// <summary>
        /// Returns the website configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketWebsiteRequest used to execute the GetBucketWebsite service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        public void GetBucketWebsiteAsync(string bucketName,  AmazonServiceCallback<GetBucketWebsiteRequest, GetBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketWebsiteRequest();
            request.BucketName = bucketName;
            GetBucketWebsiteAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetBucketWebsiteAsync(GetBucketWebsiteRequest request, AmazonServiceCallback<GetBucketWebsiteRequest, GetBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetBucketWebsiteRequestMarshaller();
            var unmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketWebsiteRequest,GetBucketWebsiteResponse> responseObject 
                            = new AmazonServiceResult<GetBucketWebsiteRequest,GetBucketWebsiteResponse>((GetBucketWebsiteRequest)req, (GetBucketWebsiteResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetBucketWebsiteRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetCORSConfiguration

        /// <summary>
        /// Returns the cors configuration for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetCORSConfigurationRequest used to execute the GetCORSConfiguration service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public void GetCORSConfigurationAsync(string bucketName,  AmazonServiceCallback<GetCORSConfigurationRequest, GetCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetCORSConfigurationRequest();
            request.BucketName = bucketName;
            GetCORSConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetCORSConfigurationAsync(GetCORSConfigurationRequest request, AmazonServiceCallback<GetCORSConfigurationRequest, GetCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetCORSConfigurationRequestMarshaller();
            var unmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetCORSConfigurationRequest,GetCORSConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetCORSConfigurationRequest,GetCORSConfigurationResponse>((GetCORSConfigurationRequest)req, (GetCORSConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetCORSConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetLifecycleConfiguration

        /// <summary>
        /// Returns the lifecycle configuration information set on the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetLifecycleConfigurationRequest used to execute the GetLifecycleConfiguration service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        public void GetLifecycleConfigurationAsync(string bucketName,  AmazonServiceCallback<GetLifecycleConfigurationRequest, GetLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            GetLifecycleConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest request, AmazonServiceCallback<GetLifecycleConfigurationRequest, GetLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetLifecycleConfigurationRequestMarshaller();
            var unmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetLifecycleConfigurationRequest,GetLifecycleConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetLifecycleConfigurationRequest,GetLifecycleConfigurationResponse>((GetLifecycleConfigurationRequest)req, (GetLifecycleConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetLifecycleConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetObject

        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public void GetObjectAsync(string bucketName, string key,  AmazonServiceCallback<GetObjectRequest, GetObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            GetObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public void GetObjectAsync(string bucketName, string key, string versionId,  AmazonServiceCallback<GetObjectRequest, GetObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            GetObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetObjectAsync(GetObjectRequest request, AmazonServiceCallback<GetObjectRequest, GetObjectResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetObjectRequestMarshaller();
            var unmarshaller = GetObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectRequest,GetObjectResponse> responseObject 
                            = new AmazonServiceResult<GetObjectRequest,GetObjectResponse>((GetObjectRequest)req, (GetObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetObjectRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetObjectMetadata

        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public void GetObjectMetadataAsync(string bucketName, string key,  AmazonServiceCallback<GetObjectMetadataRequest, GetObjectMetadataResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            GetObjectMetadataAsync(request, callback, options);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public void GetObjectMetadataAsync(string bucketName, string key, string versionId,  AmazonServiceCallback<GetObjectMetadataRequest, GetObjectMetadataResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            GetObjectMetadataAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetObjectMetadataAsync(GetObjectMetadataRequest request, AmazonServiceCallback<GetObjectMetadataRequest, GetObjectMetadataResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("GetObjectMetadata is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetObjectMetadataRequestMarshaller();
            var unmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectMetadataRequest,GetObjectMetadataResponse> responseObject 
                            = new AmazonServiceResult<GetObjectMetadataRequest,GetObjectMetadataResponse>((GetObjectMetadataRequest)req, (GetObjectMetadataResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetObjectMetadataRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  GetObjectTorrent

        /// <summary>
        /// Return torrent files from a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// <param name="key">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        public void GetObjectTorrentAsync(string bucketName, string key,  AmazonServiceCallback<GetObjectTorrentRequest, GetObjectTorrentResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectTorrentRequest();
            request.BucketName = bucketName;
            request.Key = key;
            GetObjectTorrentAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void GetObjectTorrentAsync(GetObjectTorrentRequest request, AmazonServiceCallback<GetObjectTorrentRequest, GetObjectTorrentResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new GetObjectTorrentRequestMarshaller();
            var unmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectTorrentRequest,GetObjectTorrentResponse> responseObject 
                            = new AmazonServiceResult<GetObjectTorrentRequest,GetObjectTorrentResponse>((GetObjectTorrentRequest)req, (GetObjectTorrentResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<GetObjectTorrentRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  HeadBucket

        /// <summary>
        /// Initiates the asynchronous execution of the HeadBucket operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HeadBucket operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        internal void HeadBucketAsync(HeadBucketRequest request, AmazonServiceCallback<HeadBucketRequest, HeadBucketResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("HeadBucket is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new HeadBucketRequestMarshaller();
            var unmarshaller = HeadBucketResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<HeadBucketRequest,HeadBucketResponse> responseObject 
                            = new AmazonServiceResult<HeadBucketRequest,HeadBucketResponse>((HeadBucketRequest)req, (HeadBucketResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<HeadBucketRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  InitiateMultipartUpload

        /// <summary>
        /// Initiates a multipart upload and returns an upload ID.
        /// 
        /// 
        /// <para>
        /// <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// <param name="key">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public void InitiateMultipartUploadAsync(string bucketName, string key,  AmazonServiceCallback<InitiateMultipartUploadRequest, InitiateMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            var request = new InitiateMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            InitiateMultipartUploadAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, AmazonServiceCallback<InitiateMultipartUploadRequest, InitiateMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("InitiateMultipartUpload is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse> responseObject 
                            = new AmazonServiceResult<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>((InitiateMultipartUploadRequest)req, (InitiateMultipartUploadResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<InitiateMultipartUploadRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListBuckets

        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public void ListBucketsAsync(AmazonServiceCallback<ListBucketsRequest, ListBucketsResponse> callback, AsyncOptions options = null)
        {
            ListBucketsAsync(new ListBucketsRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListBucketsAsync(ListBucketsRequest request, AmazonServiceCallback<ListBucketsRequest, ListBucketsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListBucketsRequestMarshaller();
            var unmarshaller = ListBucketsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListBucketsRequest,ListBucketsResponse> responseObject 
                            = new AmazonServiceResult<ListBucketsRequest,ListBucketsResponse>((ListBucketsRequest)req, (ListBucketsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListBucketsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListMultipartUploads

        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public void ListMultipartUploadsAsync(string bucketName,  AmazonServiceCallback<ListMultipartUploadsRequest, ListMultipartUploadsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            ListMultipartUploadsAsync(request, callback, options);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// <param name="prefix">Lists in-progress uploads only for those keys that begin with the specified prefix.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public void ListMultipartUploadsAsync(string bucketName, string prefix,  AmazonServiceCallback<ListMultipartUploadsRequest, ListMultipartUploadsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            ListMultipartUploadsAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListMultipartUploadsAsync(ListMultipartUploadsRequest request, AmazonServiceCallback<ListMultipartUploadsRequest, ListMultipartUploadsResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("ListMultipartUploads is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListMultipartUploadsRequest,ListMultipartUploadsResponse> responseObject 
                            = new AmazonServiceResult<ListMultipartUploadsRequest,ListMultipartUploadsResponse>((ListMultipartUploadsRequest)req, (ListMultipartUploadsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListMultipartUploadsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListObjects

        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public void ListObjectsAsync(string bucketName,  AmazonServiceCallback<ListObjectsRequest, ListObjectsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            ListObjectsAsync(request, callback, options);
        }


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public void ListObjectsAsync(string bucketName, string prefix,  AmazonServiceCallback<ListObjectsRequest, ListObjectsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            ListObjectsAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjects operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListObjectsAsync(ListObjectsRequest request, AmazonServiceCallback<ListObjectsRequest, ListObjectsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListObjectsRequestMarshaller();
            var unmarshaller = ListObjectsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListObjectsRequest,ListObjectsResponse> responseObject 
                            = new AmazonServiceResult<ListObjectsRequest,ListObjectsResponse>((ListObjectsRequest)req, (ListObjectsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListObjectsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListObjectsV2

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectsV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectsV2 operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListObjectsV2Async(ListObjectsV2Request request, AmazonServiceCallback<ListObjectsV2Request, ListObjectsV2Response> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListObjectsV2RequestMarshaller();
            var unmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListObjectsV2Request,ListObjectsV2Response> responseObject 
                            = new AmazonServiceResult<ListObjectsV2Request,ListObjectsV2Response>((ListObjectsV2Request)req, (ListObjectsV2Response)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListObjectsV2Request>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListParts

        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="key">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose parts are being listed.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        public void ListPartsAsync(string bucketName, string key, string uploadId,  AmazonServiceCallback<ListPartsRequest, ListPartsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListPartsRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            ListPartsAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListPartsAsync(ListPartsRequest request, AmazonServiceCallback<ListPartsRequest, ListPartsResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("ListParts is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListPartsRequest,ListPartsResponse> responseObject 
                            = new AmazonServiceResult<ListPartsRequest,ListPartsResponse>((ListPartsRequest)req, (ListPartsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListPartsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListVersions

        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public void ListVersionsAsync(string bucketName,  AmazonServiceCallback<ListVersionsRequest, ListVersionsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            ListVersionsAsync(request, callback, options);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public void ListVersionsAsync(string bucketName, string prefix,  AmazonServiceCallback<ListVersionsRequest, ListVersionsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            ListVersionsAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void ListVersionsAsync(ListVersionsRequest request, AmazonServiceCallback<ListVersionsRequest, ListVersionsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new ListVersionsRequestMarshaller();
            var unmarshaller = ListVersionsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListVersionsRequest,ListVersionsResponse> responseObject 
                            = new AmazonServiceResult<ListVersionsRequest,ListVersionsResponse>((ListVersionsRequest)req, (ListVersionsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListVersionsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutACL

        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutACL operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutACLAsync(PutACLRequest request, AmazonServiceCallback<PutACLRequest, PutACLResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutACL is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutACLRequestMarshaller();
            var unmarshaller = PutACLResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutACLRequest,PutACLResponse> responseObject 
                            = new AmazonServiceResult<PutACLRequest,PutACLResponse>((PutACLRequest)req, (PutACLResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutACLRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucket

        /// <summary>
        /// Creates a new bucket.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequest used to execute the PutBucket service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        public void PutBucketAsync(string bucketName,  AmazonServiceCallback<PutBucketRequest, PutBucketResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketRequest();
            request.BucketName = bucketName;
            PutBucketAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucket operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketAsync(PutBucketRequest request, AmazonServiceCallback<PutBucketRequest, PutBucketResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucket is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketRequestMarshaller();
            var unmarshaller = PutBucketResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketRequest,PutBucketResponse> responseObject 
                            = new AmazonServiceResult<PutBucketRequest,PutBucketResponse>((PutBucketRequest)req, (PutBucketResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketAccelerateConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketAccelerateConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAccelerateConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketAccelerateConfigurationAsync(PutBucketAccelerateConfigurationRequest request, AmazonServiceCallback<PutBucketAccelerateConfigurationRequest, PutBucketAccelerateConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketAccelerateConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketAccelerateConfigurationRequest,PutBucketAccelerateConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutBucketAccelerateConfigurationRequest,PutBucketAccelerateConfigurationResponse>((PutBucketAccelerateConfigurationRequest)req, (PutBucketAccelerateConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketAccelerateConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketLoggingAsync(PutBucketLoggingRequest request, AmazonServiceCallback<PutBucketLoggingRequest, PutBucketLoggingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketLogging is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketLoggingRequestMarshaller();
            var unmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketLoggingRequest,PutBucketLoggingResponse> responseObject 
                            = new AmazonServiceResult<PutBucketLoggingRequest,PutBucketLoggingResponse>((PutBucketLoggingRequest)req, (PutBucketLoggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketLoggingRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketNotification

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketNotificationAsync(PutBucketNotificationRequest request, AmazonServiceCallback<PutBucketNotificationRequest, PutBucketNotificationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketNotification is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketNotificationRequestMarshaller();
            var unmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketNotificationRequest,PutBucketNotificationResponse> responseObject 
                            = new AmazonServiceResult<PutBucketNotificationRequest,PutBucketNotificationResponse>((PutBucketNotificationRequest)req, (PutBucketNotificationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketNotificationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketPolicy

        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public void PutBucketPolicyAsync(string bucketName, string policy,  AmazonServiceCallback<PutBucketPolicyRequest, PutBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            PutBucketPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="contentMD5">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public void PutBucketPolicyAsync(string bucketName, string policy, string contentMD5,  AmazonServiceCallback<PutBucketPolicyRequest, PutBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            request.ContentMD5 = contentMD5;
            PutBucketPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketPolicyAsync(PutBucketPolicyRequest request, AmazonServiceCallback<PutBucketPolicyRequest, PutBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketPolicy is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketPolicyRequestMarshaller();
            var unmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketPolicyRequest,PutBucketPolicyResponse> responseObject 
                            = new AmazonServiceResult<PutBucketPolicyRequest,PutBucketPolicyResponse>((PutBucketPolicyRequest)req, (PutBucketPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketPolicyRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketReplication

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketReplication operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketReplicationAsync(PutBucketReplicationRequest request, AmazonServiceCallback<PutBucketReplicationRequest, PutBucketReplicationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketReplication is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketReplicationRequestMarshaller();
            var unmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketReplicationRequest,PutBucketReplicationResponse> responseObject 
                            = new AmazonServiceResult<PutBucketReplicationRequest,PutBucketReplicationResponse>((PutBucketReplicationRequest)req, (PutBucketReplicationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketReplicationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketRequestPayment

        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. Documentation on requester pays buckets can be found at http://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// <param name="requestPaymentConfiguration">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        public void PutBucketRequestPaymentAsync(string bucketName, RequestPaymentConfiguration requestPaymentConfiguration,  AmazonServiceCallback<PutBucketRequestPaymentRequest, PutBucketRequestPaymentResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            request.RequestPaymentConfiguration = requestPaymentConfiguration;
            PutBucketRequestPaymentAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, AmazonServiceCallback<PutBucketRequestPaymentRequest, PutBucketRequestPaymentResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketRequestPayment is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketRequestPaymentRequestMarshaller();
            var unmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketRequestPaymentRequest,PutBucketRequestPaymentResponse> responseObject 
                            = new AmazonServiceResult<PutBucketRequestPaymentRequest,PutBucketRequestPaymentResponse>((PutBucketRequestPaymentRequest)req, (PutBucketRequestPaymentResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketRequestPaymentRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketTagging

        /// <summary>
        /// Sets the tags for a bucket.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="tagSet">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        public void PutBucketTaggingAsync(string bucketName, List<Tag> tagSet,  AmazonServiceCallback<PutBucketTaggingRequest, PutBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketTaggingRequest();
            request.BucketName = bucketName;
            request.TagSet = tagSet;
            PutBucketTaggingAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketTaggingAsync(PutBucketTaggingRequest request, AmazonServiceCallback<PutBucketTaggingRequest, PutBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketTagging is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketTaggingRequestMarshaller();
            var unmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketTaggingRequest,PutBucketTaggingResponse> responseObject 
                            = new AmazonServiceResult<PutBucketTaggingRequest,PutBucketTaggingResponse>((PutBucketTaggingRequest)req, (PutBucketTaggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketTaggingRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketVersioning

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketVersioningAsync(PutBucketVersioningRequest request, AmazonServiceCallback<PutBucketVersioningRequest, PutBucketVersioningResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketVersioning is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketVersioningRequestMarshaller();
            var unmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketVersioningRequest,PutBucketVersioningResponse> responseObject 
                            = new AmazonServiceResult<PutBucketVersioningRequest,PutBucketVersioningResponse>((PutBucketVersioningRequest)req, (PutBucketVersioningResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketVersioningRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketWebsite

        /// <summary>
        /// Set the website configuration for a bucket.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// <param name="websiteConfiguration">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        public void PutBucketWebsiteAsync(string bucketName, WebsiteConfiguration websiteConfiguration,  AmazonServiceCallback<PutBucketWebsiteRequest, PutBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketWebsiteRequest();
            request.BucketName = bucketName;
            request.WebsiteConfiguration = websiteConfiguration;
            PutBucketWebsiteAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutBucketWebsiteAsync(PutBucketWebsiteRequest request, AmazonServiceCallback<PutBucketWebsiteRequest, PutBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketWebsite is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutBucketWebsiteRequestMarshaller();
            var unmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketWebsiteRequest,PutBucketWebsiteResponse> responseObject 
                            = new AmazonServiceResult<PutBucketWebsiteRequest,PutBucketWebsiteResponse>((PutBucketWebsiteRequest)req, (PutBucketWebsiteResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutBucketWebsiteRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutCORSConfiguration

        /// <summary>
        /// Sets the cors configuration for a bucket.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// <param name="configuration">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public void PutCORSConfigurationAsync(string bucketName, CORSConfiguration configuration,  AmazonServiceCallback<PutCORSConfigurationRequest, PutCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new PutCORSConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            PutCORSConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutCORSConfigurationAsync(PutCORSConfigurationRequest request, AmazonServiceCallback<PutCORSConfigurationRequest, PutCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutCORSConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutCORSConfigurationRequestMarshaller();
            var unmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutCORSConfigurationRequest,PutCORSConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutCORSConfigurationRequest,PutCORSConfigurationResponse>((PutCORSConfigurationRequest)req, (PutCORSConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutCORSConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutLifecycleConfiguration

        /// <summary>
        /// Sets lifecycle configuration for your bucket. If a lifecycle configuration exists,
        /// it replaces it.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="configuration">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        public void PutLifecycleConfigurationAsync(string bucketName, LifecycleConfiguration configuration,  AmazonServiceCallback<PutLifecycleConfigurationRequest, PutLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new PutLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            PutLifecycleConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest request, AmazonServiceCallback<PutLifecycleConfigurationRequest, PutLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutLifecycleConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutLifecycleConfigurationRequestMarshaller();
            var unmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutLifecycleConfigurationRequest,PutLifecycleConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutLifecycleConfigurationRequest,PutLifecycleConfigurationResponse>((PutLifecycleConfigurationRequest)req, (PutLifecycleConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutLifecycleConfigurationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  PutObject

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PutObjectAsync(PutObjectRequest request, AmazonServiceCallback<PutObjectRequest, PutObjectResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutObject is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new PutObjectRequestMarshaller();
            var unmarshaller = PutObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutObjectRequest,PutObjectResponse> responseObject 
                            = new AmazonServiceResult<PutObjectRequest,PutObjectResponse>((PutObjectRequest)req, (PutObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutObjectRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  RestoreObject

        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public void RestoreObjectAsync(string bucketName, string key,  AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            RestoreObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public void RestoreObjectAsync(string bucketName, string key, int days,  AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.Days = days;
            RestoreObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public void RestoreObjectAsync(string bucketName, string key, string versionId,  AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            RestoreObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public void RestoreObjectAsync(string bucketName, string key, string versionId, int days,  AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            request.Days = days;
            RestoreObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void RestoreObjectAsync(RestoreObjectRequest request, AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = new RestoreObjectRequestMarshaller();
            var unmarshaller = RestoreObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<RestoreObjectRequest,RestoreObjectResponse> responseObject 
                            = new AmazonServiceResult<RestoreObjectRequest,RestoreObjectResponse>((RestoreObjectRequest)req, (RestoreObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<RestoreObjectRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UploadPart

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadPart operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void UploadPartAsync(UploadPartRequest request, AmazonServiceCallback<UploadPartRequest, UploadPartResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("UploadPart is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var marshaller = new UploadPartRequestMarshaller();
            var unmarshaller = UploadPartResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UploadPartRequest,UploadPartResponse> responseObject 
                            = new AmazonServiceResult<UploadPartRequest,UploadPartResponse>((UploadPartRequest)req, (UploadPartResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UploadPartRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
    }
}