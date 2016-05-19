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
        /// Constructs AmazonS3Client with the credentials loaded from the application's
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
        public AmazonS3Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config()) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
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
        public AmazonS3Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AmazonS3Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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
        /// </summary>
        /// <param name="bucketName">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="key">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="uploadId">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        public AbortMultipartUploadResponse AbortMultipartUpload(string bucketName, string key, string uploadId)
        {
            var request = new AbortMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return AbortMultipartUpload(request);
        }


        /// <summary>
        /// Aborts a multipart upload.
        /// 
        /// 
        /// <para>
        /// To verify that all parts have been removed, so you don't get charged for the part
        /// storage, you should call the List Parts operation and ensure the parts list is empty.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadRequest,AbortMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAbortMultipartUpload
        ///         operation.</returns>
        public IAsyncResult BeginAbortMultipartUpload(AbortMultipartUploadRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return BeginInvoke<AbortMultipartUploadRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortMultipartUpload.</param>
        /// 
        /// <returns>Returns a  AbortMultipartUploadResult from S3.</returns>
        public  AbortMultipartUploadResponse EndAbortMultipartUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<AbortMultipartUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  CompleteMultipartUpload

        /// <summary>
        /// Completes a multipart upload by assembling previously uploaded parts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by S3.</returns>
        public CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteMultipartUpload
        ///         operation.</returns>
        public IAsyncResult BeginCompleteMultipartUpload(CompleteMultipartUploadRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return BeginInvoke<CompleteMultipartUploadRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteMultipartUpload.</param>
        /// 
        /// <returns>Returns a  CompleteMultipartUploadResult from S3.</returns>
        public  CompleteMultipartUploadResponse EndCompleteMultipartUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<CompleteMultipartUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyObject

        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public CopyObjectResponse CopyObject(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey)
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObject(request);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceVersionId">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public CopyObjectResponse CopyObject(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey)
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObject(request);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyObject service method.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            var marshaller = new CopyObjectRequestMarshaller();
            var unmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return Invoke<CopyObjectRequest,CopyObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyObject operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyObject
        ///         operation.</returns>
        public IAsyncResult BeginCopyObject(CopyObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CopyObjectRequestMarshaller();
            var unmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return BeginInvoke<CopyObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyObject.</param>
        /// 
        /// <returns>Returns a  CopyObjectResult from S3.</returns>
        public  CopyObjectResponse EndCopyObject(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyObjectResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyPart

        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public CopyPartResponse CopyPart(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId)
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPart(request);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceVersionId">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public CopyPartResponse CopyPart(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId)
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPart(request);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyPart service method.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public CopyPartResponse CopyPart(CopyPartRequest request)
        {
            var marshaller = new CopyPartRequestMarshaller();
            var unmarshaller = CopyPartResponseUnmarshaller.Instance;

            return Invoke<CopyPartRequest,CopyPartResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPart operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyPart
        ///         operation.</returns>
        public IAsyncResult BeginCopyPart(CopyPartRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CopyPartRequestMarshaller();
            var unmarshaller = CopyPartResponseUnmarshaller.Instance;

            return BeginInvoke<CopyPartRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyPart.</param>
        /// 
        /// <returns>Returns a  CopyPartResult from S3.</returns>
        public  CopyPartResponse EndCopyPart(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyPartResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucket

        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and Delete Markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketRequest used to execute the DeleteBucket service method.</param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        public DeleteBucketResponse DeleteBucket(string bucketName)
        {
            var request = new DeleteBucketRequest();
            request.BucketName = bucketName;
            return DeleteBucket(request);
        }


        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and Delete Markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket service method.</param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            var marshaller = new DeleteBucketRequestMarshaller();
            var unmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketRequest,DeleteBucketResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucket
        ///         operation.</returns>
        public IAsyncResult BeginDeleteBucket(DeleteBucketRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBucketRequestMarshaller();
            var unmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBucketRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucket.</param>
        /// 
        /// <returns>Returns a  DeleteBucketResult from S3.</returns>
        public  DeleteBucketResponse EndDeleteBucket(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketPolicy

        /// <summary>
        /// Deletes the policy from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketPolicyRequest used to execute the DeleteBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        public DeleteBucketPolicyResponse DeleteBucketPolicy(string bucketName)
        {
            var request = new DeleteBucketPolicyRequest();
            request.BucketName = bucketName;
            return DeleteBucketPolicy(request);
        }


        /// <summary>
        /// Deletes the policy from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        public DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            var marshaller = new DeleteBucketPolicyRequestMarshaller();
            var unmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketPolicyRequest,DeleteBucketPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketPolicy
        ///         operation.</returns>
        public IAsyncResult BeginDeleteBucketPolicy(DeleteBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBucketPolicyRequestMarshaller();
            var unmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBucketPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteBucketPolicyResult from S3.</returns>
        public  DeleteBucketPolicyResponse EndDeleteBucketPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketReplication

        /// <summary>
        /// Deletes the replication configuration from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketReplication service method, as returned by S3.</returns>
        public DeleteBucketReplicationResponse DeleteBucketReplication(DeleteBucketReplicationRequest request)
        {
            var marshaller = new DeleteBucketReplicationRequestMarshaller();
            var unmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketReplicationRequest,DeleteBucketReplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketReplication
        ///         operation.</returns>
        public IAsyncResult BeginDeleteBucketReplication(DeleteBucketReplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBucketReplicationRequestMarshaller();
            var unmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBucketReplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketReplication.</param>
        /// 
        /// <returns>Returns a  DeleteBucketReplicationResult from S3.</returns>
        public  DeleteBucketReplicationResponse EndDeleteBucketReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketTagging

        /// <summary>
        /// Deletes the tags from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketTaggingRequest used to execute the DeleteBucketTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        public DeleteBucketTaggingResponse DeleteBucketTagging(string bucketName)
        {
            var request = new DeleteBucketTaggingRequest();
            request.BucketName = bucketName;
            return DeleteBucketTagging(request);
        }


        /// <summary>
        /// Deletes the tags from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        public DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            var marshaller = new DeleteBucketTaggingRequestMarshaller();
            var unmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketTaggingRequest,DeleteBucketTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketTagging
        ///         operation.</returns>
        public IAsyncResult BeginDeleteBucketTagging(DeleteBucketTaggingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBucketTaggingRequestMarshaller();
            var unmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBucketTaggingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketTagging.</param>
        /// 
        /// <returns>Returns a  DeleteBucketTaggingResult from S3.</returns>
        public  DeleteBucketTaggingResponse EndDeleteBucketTagging(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketTaggingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketWebsite

        /// <summary>
        /// This operation removes the website configuration from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketWebsiteRequest used to execute the DeleteBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        public DeleteBucketWebsiteResponse DeleteBucketWebsite(string bucketName)
        {
            var request = new DeleteBucketWebsiteRequest();
            request.BucketName = bucketName;
            return DeleteBucketWebsite(request);
        }


        /// <summary>
        /// This operation removes the website configuration from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        public DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request)
        {
            var marshaller = new DeleteBucketWebsiteRequestMarshaller();
            var unmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketWebsiteRequest,DeleteBucketWebsiteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketWebsite
        ///         operation.</returns>
        public IAsyncResult BeginDeleteBucketWebsite(DeleteBucketWebsiteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBucketWebsiteRequestMarshaller();
            var unmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBucketWebsiteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketWebsite.</param>
        /// 
        /// <returns>Returns a  DeleteBucketWebsiteResult from S3.</returns>
        public  DeleteBucketWebsiteResponse EndDeleteBucketWebsite(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketWebsiteResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCORSConfiguration

        /// <summary>
        /// Deletes the cors configuration information set for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteCORSConfigurationRequest used to execute the DeleteCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public DeleteCORSConfigurationResponse DeleteCORSConfiguration(string bucketName)
        {
            var request = new DeleteCORSConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteCORSConfiguration(request);
        }


        /// <summary>
        /// Deletes the cors configuration information set for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request)
        {
            var marshaller = new DeleteCORSConfigurationRequestMarshaller();
            var unmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCORSConfigurationRequest,DeleteCORSConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCORSConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCORSConfiguration(DeleteCORSConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteCORSConfigurationRequestMarshaller();
            var unmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCORSConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCORSConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteCORSConfigurationResult from S3.</returns>
        public  DeleteCORSConfigurationResponse EndDeleteCORSConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCORSConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLifecycleConfiguration

        /// <summary>
        /// Deletes the lifecycle configuration from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteLifecycleConfigurationRequest used to execute the DeleteLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        public DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(string bucketName)
        {
            var request = new DeleteLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteLifecycleConfiguration(request);
        }


        /// <summary>
        /// Deletes the lifecycle configuration from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        public DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request)
        {
            var marshaller = new DeleteLifecycleConfigurationRequestMarshaller();
            var unmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleConfigurationRequest,DeleteLifecycleConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLifecycleConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginDeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteLifecycleConfigurationRequestMarshaller();
            var unmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteLifecycleConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLifecycleConfigurationResult from S3.</returns>
        public  DeleteLifecycleConfigurationResponse EndDeleteLifecycleConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLifecycleConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteObject

        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public DeleteObjectResponse DeleteObject(string bucketName, string key)
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return DeleteObject(request);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public DeleteObjectResponse DeleteObject(string bucketName, string key, string versionId)
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return DeleteObject(request);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectRequest,DeleteObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObject
        ///         operation.</returns>
        public IAsyncResult BeginDeleteObject(DeleteObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObject.</param>
        /// 
        /// <returns>Returns a  DeleteObjectResult from S3.</returns>
        public  DeleteObjectResponse EndDeleteObject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteObjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteObjects

        /// <summary>
        /// This operation enables you to delete multiple objects from a bucket using a single
        /// HTTP request. You may specify up to 1000 keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects service method.</param>
        /// 
        /// <returns>The response from the DeleteObjects service method, as returned by S3.</returns>
        public DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request)
        {
            var marshaller = new DeleteObjectsRequestMarshaller();
            var unmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectsRequest,DeleteObjectsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObjects
        ///         operation.</returns>
        public IAsyncResult BeginDeleteObjects(DeleteObjectsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteObjectsRequestMarshaller();
            var unmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteObjectsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObjects.</param>
        /// 
        /// <returns>Returns a  DeleteObjectsResult from S3.</returns>
        public  DeleteObjectsResponse EndDeleteObjects(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteObjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetACL

        /// <summary>
        /// Gets the access control policy for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetACLRequest used to execute the GetACL service method.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        public GetACLResponse GetACL(string bucketName)
        {
            var request = new GetACLRequest();
            request.BucketName = bucketName;
            return GetACL(request);
        }


        /// <summary>
        /// Gets the access control policy for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetACL service method.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        public GetACLResponse GetACL(GetACLRequest request)
        {
            var marshaller = new GetACLRequestMarshaller();
            var unmarshaller = GetACLResponseUnmarshaller.Instance;

            return Invoke<GetACLRequest,GetACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetACL operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetACL
        ///         operation.</returns>
        public IAsyncResult BeginGetACL(GetACLRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetACLRequestMarshaller();
            var unmarshaller = GetACLResponseUnmarshaller.Instance;

            return BeginInvoke<GetACLRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetACL.</param>
        /// 
        /// <returns>Returns a  GetACLResult from S3.</returns>
        public  GetACLResponse EndGetACL(IAsyncResult asyncResult)
        {
            return EndInvoke<GetACLResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketAccelerateConfiguration

        /// <summary>
        /// Returns the accelerate configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket for which the accelerate configuration is retrieved.</param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public GetBucketAccelerateConfigurationResponse GetBucketAccelerateConfiguration(string bucketName)
        {
            var request = new GetBucketAccelerateConfigurationRequest();
            request.BucketName = bucketName;
            return GetBucketAccelerateConfiguration(request);
        }


        /// <summary>
        /// Returns the accelerate configuration of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccelerateConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public GetBucketAccelerateConfigurationResponse GetBucketAccelerateConfiguration(GetBucketAccelerateConfigurationRequest request)
        {
            var marshaller = new GetBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketAccelerateConfigurationRequest,GetBucketAccelerateConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccelerateConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketAccelerateConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketAccelerateConfiguration(GetBucketAccelerateConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketAccelerateConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketAccelerateConfiguration.</param>
        /// 
        /// <returns>Returns a  GetBucketAccelerateConfigurationResult from S3.</returns>
        public  GetBucketAccelerateConfigurationResponse EndGetBucketAccelerateConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketAccelerateConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketLocation

        /// <summary>
        /// Returns the region the bucket resides in.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLocationRequest used to execute the GetBucketLocation service method.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        public GetBucketLocationResponse GetBucketLocation(string bucketName)
        {
            var request = new GetBucketLocationRequest();
            request.BucketName = bucketName;
            return GetBucketLocation(request);
        }


        /// <summary>
        /// Returns the region the bucket resides in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation service method.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        public GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request)
        {
            var marshaller = new GetBucketLocationRequestMarshaller();
            var unmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return Invoke<GetBucketLocationRequest,GetBucketLocationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketLocation
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketLocation(GetBucketLocationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketLocationRequestMarshaller();
            var unmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketLocationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLocation.</param>
        /// 
        /// <returns>Returns a  GetBucketLocationResult from S3.</returns>
        public  GetBucketLocationResponse EndGetBucketLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketLocationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketLogging

        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLoggingRequest used to execute the GetBucketLogging service method.</param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        public GetBucketLoggingResponse GetBucketLogging(string bucketName)
        {
            var request = new GetBucketLoggingRequest();
            request.BucketName = bucketName;
            return GetBucketLogging(request);
        }


        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging service method.</param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        public GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request)
        {
            var marshaller = new GetBucketLoggingRequestMarshaller();
            var unmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketLoggingRequest,GetBucketLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketLogging
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketLogging(GetBucketLoggingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketLoggingRequestMarshaller();
            var unmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketLoggingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLogging.</param>
        /// 
        /// <returns>Returns a  GetBucketLoggingResult from S3.</returns>
        public  GetBucketLoggingResponse EndGetBucketLogging(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketLoggingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketNotification

        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket to get the notification configuration for.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        public GetBucketNotificationResponse GetBucketNotification(string bucketName)
        {
            var request = new GetBucketNotificationRequest();
            request.BucketName = bucketName;
            return GetBucketNotification(request);
        }


        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification service method.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        public GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest request)
        {
            var marshaller = new GetBucketNotificationRequestMarshaller();
            var unmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<GetBucketNotificationRequest,GetBucketNotificationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketNotification
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketNotification(GetBucketNotificationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketNotificationRequestMarshaller();
            var unmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketNotificationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketNotification.</param>
        /// 
        /// <returns>Returns a  GetBucketNotificationResult from S3.</returns>
        public  GetBucketNotificationResponse EndGetBucketNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketPolicy

        /// <summary>
        /// Returns the policy of a specified bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketPolicyRequest used to execute the GetBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        public GetBucketPolicyResponse GetBucketPolicy(string bucketName)
        {
            var request = new GetBucketPolicyRequest();
            request.BucketName = bucketName;
            return GetBucketPolicy(request);
        }


        /// <summary>
        /// Returns the policy of a specified bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        public GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            var marshaller = new GetBucketPolicyRequestMarshaller();
            var unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyRequest,GetBucketPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketPolicy
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketPolicy(GetBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketPolicyRequestMarshaller();
            var unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketPolicy.</param>
        /// 
        /// <returns>Returns a  GetBucketPolicyResult from S3.</returns>
        public  GetBucketPolicyResponse EndGetBucketPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketReplication

        /// <summary>
        /// Retrieves the replication configuration for the given Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication service method.</param>
        /// 
        /// <returns>The response from the GetBucketReplication service method, as returned by S3.</returns>
        public GetBucketReplicationResponse GetBucketReplication(GetBucketReplicationRequest request)
        {
            var marshaller = new GetBucketReplicationRequestMarshaller();
            var unmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<GetBucketReplicationRequest,GetBucketReplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketReplication
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketReplication(GetBucketReplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketReplicationRequestMarshaller();
            var unmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketReplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketReplication.</param>
        /// 
        /// <returns>Returns a  GetBucketReplicationResult from S3.</returns>
        public  GetBucketReplicationResponse EndGetBucketReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketRequestPayment

        /// <summary>
        /// Returns the request payment configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketRequestPaymentRequest used to execute the GetBucketRequestPayment service method.</param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        public GetBucketRequestPaymentResponse GetBucketRequestPayment(string bucketName)
        {
            var request = new GetBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            return GetBucketRequestPayment(request);
        }


        /// <summary>
        /// Returns the request payment configuration of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment service method.</param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        public GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request)
        {
            var marshaller = new GetBucketRequestPaymentRequestMarshaller();
            var unmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<GetBucketRequestPaymentRequest,GetBucketRequestPaymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketRequestPayment
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketRequestPayment(GetBucketRequestPaymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketRequestPaymentRequestMarshaller();
            var unmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketRequestPaymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketRequestPayment.</param>
        /// 
        /// <returns>Returns a  GetBucketRequestPaymentResult from S3.</returns>
        public  GetBucketRequestPaymentResponse EndGetBucketRequestPayment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketRequestPaymentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketTagging

        /// <summary>
        /// Returns the tag set associated with the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging service method.</param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by S3.</returns>
        public GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request)
        {
            var marshaller = new GetBucketTaggingRequestMarshaller();
            var unmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketTaggingRequest,GetBucketTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketTagging
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketTagging(GetBucketTaggingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketTaggingRequestMarshaller();
            var unmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketTaggingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketTagging.</param>
        /// 
        /// <returns>Returns a  GetBucketTaggingResult from S3.</returns>
        public  GetBucketTaggingResponse EndGetBucketTagging(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketTaggingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketVersioning

        /// <summary>
        /// Returns the versioning state of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketVersioningRequest used to execute the GetBucketVersioning service method.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        public GetBucketVersioningResponse GetBucketVersioning(string bucketName)
        {
            var request = new GetBucketVersioningRequest();
            request.BucketName = bucketName;
            return GetBucketVersioning(request);
        }


        /// <summary>
        /// Returns the versioning state of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning service method.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        public GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request)
        {
            var marshaller = new GetBucketVersioningRequestMarshaller();
            var unmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<GetBucketVersioningRequest,GetBucketVersioningResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketVersioning
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketVersioning(GetBucketVersioningRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketVersioningRequestMarshaller();
            var unmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketVersioningRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketVersioning.</param>
        /// 
        /// <returns>Returns a  GetBucketVersioningResult from S3.</returns>
        public  GetBucketVersioningResponse EndGetBucketVersioning(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketVersioningResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketWebsite

        /// <summary>
        /// Returns the website configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketWebsiteRequest used to execute the GetBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        public GetBucketWebsiteResponse GetBucketWebsite(string bucketName)
        {
            var request = new GetBucketWebsiteRequest();
            request.BucketName = bucketName;
            return GetBucketWebsite(request);
        }


        /// <summary>
        /// Returns the website configuration for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        public GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request)
        {
            var marshaller = new GetBucketWebsiteRequestMarshaller();
            var unmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<GetBucketWebsiteRequest,GetBucketWebsiteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketWebsite
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketWebsite(GetBucketWebsiteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBucketWebsiteRequestMarshaller();
            var unmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return BeginInvoke<GetBucketWebsiteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketWebsite.</param>
        /// 
        /// <returns>Returns a  GetBucketWebsiteResult from S3.</returns>
        public  GetBucketWebsiteResponse EndGetBucketWebsite(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketWebsiteResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCORSConfiguration

        /// <summary>
        /// Returns the cors configuration for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetCORSConfigurationRequest used to execute the GetCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public GetCORSConfigurationResponse GetCORSConfiguration(string bucketName)
        {
            var request = new GetCORSConfigurationRequest();
            request.BucketName = bucketName;
            return GetCORSConfiguration(request);
        }


        /// <summary>
        /// Returns the cors configuration for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request)
        {
            var marshaller = new GetCORSConfigurationRequestMarshaller();
            var unmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetCORSConfigurationRequest,GetCORSConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCORSConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginGetCORSConfiguration(GetCORSConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetCORSConfigurationRequestMarshaller();
            var unmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<GetCORSConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCORSConfiguration.</param>
        /// 
        /// <returns>Returns a  GetCORSConfigurationResult from S3.</returns>
        public  GetCORSConfigurationResponse EndGetCORSConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCORSConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLifecycleConfiguration

        /// <summary>
        /// Returns the lifecycle configuration information set on the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetLifecycleConfigurationRequest used to execute the GetLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        public GetLifecycleConfigurationResponse GetLifecycleConfiguration(string bucketName)
        {
            var request = new GetLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return GetLifecycleConfiguration(request);
        }


        /// <summary>
        /// Returns the lifecycle configuration information set on the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        public GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request)
        {
            var marshaller = new GetLifecycleConfigurationRequestMarshaller();
            var unmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLifecycleConfigurationRequest,GetLifecycleConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLifecycleConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginGetLifecycleConfiguration(GetLifecycleConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetLifecycleConfigurationRequestMarshaller();
            var unmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<GetLifecycleConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLifecycleConfigurationResult from S3.</returns>
        public  GetLifecycleConfigurationResponse EndGetLifecycleConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLifecycleConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetObject

        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public GetObjectResponse GetObject(string bucketName, string key)
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObject(request);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public GetObjectResponse GetObject(string bucketName, string key, string versionId)
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObject(request);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObject service method.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public GetObjectResponse GetObject(GetObjectRequest request)
        {
            var marshaller = new GetObjectRequestMarshaller();
            var unmarshaller = GetObjectResponseUnmarshaller.Instance;

            return Invoke<GetObjectRequest,GetObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObject
        ///         operation.</returns>
        public IAsyncResult BeginGetObject(GetObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetObjectRequestMarshaller();
            var unmarshaller = GetObjectResponseUnmarshaller.Instance;

            return BeginInvoke<GetObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObject.</param>
        /// 
        /// <returns>Returns a  GetObjectResult from S3.</returns>
        public  GetObjectResponse EndGetObject(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectResponse>(asyncResult);
        }

        #endregion
        
        #region  GetObjectMetadata

        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public GetObjectMetadataResponse GetObjectMetadata(string bucketName, string key)
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectMetadata(request);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public GetObjectMetadataResponse GetObjectMetadata(string bucketName, string key, string versionId)
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObjectMetadata(request);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata service method.</param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
        {
            var marshaller = new GetObjectMetadataRequestMarshaller();
            var unmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return Invoke<GetObjectMetadataRequest,GetObjectMetadataResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectMetadata
        ///         operation.</returns>
        public IAsyncResult BeginGetObjectMetadata(GetObjectMetadataRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetObjectMetadataRequestMarshaller();
            var unmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return BeginInvoke<GetObjectMetadataRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectMetadata.</param>
        /// 
        /// <returns>Returns a  GetObjectMetadataResult from S3.</returns>
        public  GetObjectMetadataResponse EndGetObjectMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetObjectTorrent

        /// <summary>
        /// Return torrent files from a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// <param name="key">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        public GetObjectTorrentResponse GetObjectTorrent(string bucketName, string key)
        {
            var request = new GetObjectTorrentRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectTorrent(request);
        }


        /// <summary>
        /// Return torrent files from a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent service method.</param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        public GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest request)
        {
            var marshaller = new GetObjectTorrentRequestMarshaller();
            var unmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return Invoke<GetObjectTorrentRequest,GetObjectTorrentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectTorrent
        ///         operation.</returns>
        public IAsyncResult BeginGetObjectTorrent(GetObjectTorrentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetObjectTorrentRequestMarshaller();
            var unmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return BeginInvoke<GetObjectTorrentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectTorrent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectTorrent.</param>
        /// 
        /// <returns>Returns a  GetObjectTorrentResult from S3.</returns>
        public  GetObjectTorrentResponse EndGetObjectTorrent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectTorrentResponse>(asyncResult);
        }

        #endregion
        
        #region  HeadBucket

        /// <summary>
        /// This operation is useful to determine if a bucket exists and you have permission to
        /// access it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HeadBucket service method.</param>
        /// 
        /// <returns>The response from the HeadBucket service method, as returned by S3.</returns>
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
        /// <param name="request">Container for the necessary parameters to execute the HeadBucket operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHeadBucket
        ///         operation.</returns>
        internal IAsyncResult BeginHeadBucket(HeadBucketRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new HeadBucketRequestMarshaller();
            var unmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return BeginInvoke<HeadBucketRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HeadBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHeadBucket.</param>
        /// 
        /// <returns>Returns a  HeadBucketResult from S3.</returns>
        internal  HeadBucketResponse EndHeadBucket(IAsyncResult asyncResult)
        {
            return EndInvoke<HeadBucketResponse>(asyncResult);
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
        /// </summary>
        /// <param name="bucketName">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// <param name="key">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public InitiateMultipartUploadResponse InitiateMultipartUpload(string bucketName, string key)
        {
            var request = new InitiateMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return InitiateMultipartUpload(request);
        }


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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitiateMultipartUpload
        ///         operation.</returns>
        public IAsyncResult BeginInitiateMultipartUpload(InitiateMultipartUploadRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return BeginInvoke<InitiateMultipartUploadRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateMultipartUpload.</param>
        /// 
        /// <returns>Returns a  InitiateMultipartUploadResult from S3.</returns>
        public  InitiateMultipartUploadResponse EndInitiateMultipartUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<InitiateMultipartUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBuckets

        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public ListBucketsResponse ListBuckets()
        {
            return ListBuckets(new ListBucketsRequest());
        }

        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets service method.</param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            var marshaller = new ListBucketsRequestMarshaller();
            var unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return Invoke<ListBucketsRequest,ListBucketsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuckets
        ///         operation.</returns>
        public IAsyncResult BeginListBuckets(ListBucketsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListBucketsRequestMarshaller();
            var unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return BeginInvoke<ListBucketsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuckets.</param>
        /// 
        /// <returns>Returns a  ListBucketsResult from S3.</returns>
        public  ListBucketsResponse EndListBuckets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBucketsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMultipartUploads

        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public ListMultipartUploadsResponse ListMultipartUploads(string bucketName)
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            return ListMultipartUploads(request);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// <param name="prefix">Lists in-progress uploads only for those keys that begin with the specified prefix.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public ListMultipartUploadsResponse ListMultipartUploads(string bucketName, string prefix)
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListMultipartUploads(request);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads service method.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsRequest,ListMultipartUploadsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMultipartUploads
        ///         operation.</returns>
        public IAsyncResult BeginListMultipartUploads(ListMultipartUploadsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return BeginInvoke<ListMultipartUploadsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultipartUploads.</param>
        /// 
        /// <returns>Returns a  ListMultipartUploadsResult from S3.</returns>
        public  ListMultipartUploadsResponse EndListMultipartUploads(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMultipartUploadsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListObjects

        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public ListObjectsResponse ListObjects(string bucketName)
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            return ListObjects(request);
        }


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public ListObjectsResponse ListObjects(string bucketName, string prefix)
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListObjects(request);
        }


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjects service method.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            var marshaller = new ListObjectsRequestMarshaller();
            var unmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return Invoke<ListObjectsRequest,ListObjectsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjects operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjects
        ///         operation.</returns>
        public IAsyncResult BeginListObjects(ListObjectsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListObjectsRequestMarshaller();
            var unmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return BeginInvoke<ListObjectsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjects.</param>
        /// 
        /// <returns>Returns a  ListObjectsResult from S3.</returns>
        public  ListObjectsResponse EndListObjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListObjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListObjectsV2

        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket. Note:
        /// ListObjectsV2 is the revised List Objects API and we recommend you use this revised
        /// API for new application development.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectsV2 service method.</param>
        /// 
        /// <returns>The response from the ListObjectsV2 service method, as returned by S3.</returns>
        public ListObjectsV2Response ListObjectsV2(ListObjectsV2Request request)
        {
            var marshaller = new ListObjectsV2RequestMarshaller();
            var unmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return Invoke<ListObjectsV2Request,ListObjectsV2Response>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectsV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectsV2 operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjectsV2
        ///         operation.</returns>
        public IAsyncResult BeginListObjectsV2(ListObjectsV2Request request, AsyncCallback callback, object state)
        {
            var marshaller = new ListObjectsV2RequestMarshaller();
            var unmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return BeginInvoke<ListObjectsV2Request>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectsV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectsV2.</param>
        /// 
        /// <returns>Returns a  ListObjectsV2Result from S3.</returns>
        public  ListObjectsV2Response EndListObjectsV2(IAsyncResult asyncResult)
        {
            return EndInvoke<ListObjectsV2Response>(asyncResult);
        }

        #endregion
        
        #region  ListParts

        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload.
        /// </summary>
        /// <param name="bucketName">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="key">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose parts are being listed.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        public ListPartsResponse ListParts(string bucketName, string key, string uploadId)
        {
            var request = new ListPartsRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return ListParts(request);
        }


        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParts service method.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        public ListPartsResponse ListParts(ListPartsRequest request)
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsRequest,ListPartsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParts
        ///         operation.</returns>
        public IAsyncResult BeginListParts(ListPartsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return BeginInvoke<ListPartsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListParts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParts.</param>
        /// 
        /// <returns>Returns a  ListPartsResult from S3.</returns>
        public  ListPartsResponse EndListParts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPartsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVersions

        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public ListVersionsResponse ListVersions(string bucketName)
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            return ListVersions(request);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public ListVersionsResponse ListVersions(string bucketName, string prefix)
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListVersions(request);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            var marshaller = new ListVersionsRequestMarshaller();
            var unmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return Invoke<ListVersionsRequest,ListVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVersions
        ///         operation.</returns>
        public IAsyncResult BeginListVersions(ListVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListVersionsRequestMarshaller();
            var unmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// 
        /// <returns>Returns a  ListVersionsResult from S3.</returns>
        public  ListVersionsResponse EndListVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutACL

        /// <summary>
        /// Sets the permissions on a bucket using access control lists (ACL).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutACL service method.</param>
        /// 
        /// <returns>The response from the PutACL service method, as returned by S3.</returns>
        public PutACLResponse PutACL(PutACLRequest request)
        {
            var marshaller = new PutACLRequestMarshaller();
            var unmarshaller = PutACLResponseUnmarshaller.Instance;

            return Invoke<PutACLRequest,PutACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutACL operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutACL
        ///         operation.</returns>
        public IAsyncResult BeginPutACL(PutACLRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutACLRequestMarshaller();
            var unmarshaller = PutACLResponseUnmarshaller.Instance;

            return BeginInvoke<PutACLRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutACL.</param>
        /// 
        /// <returns>Returns a  PutACLResult from S3.</returns>
        public  PutACLResponse EndPutACL(IAsyncResult asyncResult)
        {
            return EndInvoke<PutACLResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucket

        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequest used to execute the PutBucket service method.</param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        public PutBucketResponse PutBucket(string bucketName)
        {
            var request = new PutBucketRequest();
            request.BucketName = bucketName;
            return PutBucket(request);
        }


        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucket service method.</param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        public PutBucketResponse PutBucket(PutBucketRequest request)
        {
            var marshaller = new PutBucketRequestMarshaller();
            var unmarshaller = PutBucketResponseUnmarshaller.Instance;

            return Invoke<PutBucketRequest,PutBucketResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucket operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucket
        ///         operation.</returns>
        public IAsyncResult BeginPutBucket(PutBucketRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketRequestMarshaller();
            var unmarshaller = PutBucketResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucket.</param>
        /// 
        /// <returns>Returns a  PutBucketResult from S3.</returns>
        public  PutBucketResponse EndPutBucket(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketAccelerateConfiguration

        /// <summary>
        /// Sets the accelerate configuration of an existing bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAccelerateConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public PutBucketAccelerateConfigurationResponse PutBucketAccelerateConfiguration(PutBucketAccelerateConfigurationRequest request)
        {
            var marshaller = new PutBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketAccelerateConfigurationRequest,PutBucketAccelerateConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAccelerateConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketAccelerateConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginPutBucketAccelerateConfiguration(PutBucketAccelerateConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketAccelerateConfigurationRequestMarshaller();
            var unmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketAccelerateConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketAccelerateConfiguration.</param>
        /// 
        /// <returns>Returns a  PutBucketAccelerateConfigurationResult from S3.</returns>
        public  PutBucketAccelerateConfigurationResponse EndPutBucketAccelerateConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketAccelerateConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketLogging

        /// <summary>
        /// Set the logging parameters for a bucket and to specify permissions for who can view
        /// and modify the logging parameters. To set the logging status of a bucket, you must
        /// be the bucket owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging service method.</param>
        /// 
        /// <returns>The response from the PutBucketLogging service method, as returned by S3.</returns>
        public PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request)
        {
            var marshaller = new PutBucketLoggingRequestMarshaller();
            var unmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketLoggingRequest,PutBucketLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketLogging
        ///         operation.</returns>
        public IAsyncResult BeginPutBucketLogging(PutBucketLoggingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketLoggingRequestMarshaller();
            var unmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketLoggingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketLogging.</param>
        /// 
        /// <returns>Returns a  PutBucketLoggingResult from S3.</returns>
        public  PutBucketLoggingResponse EndPutBucketLogging(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketLoggingResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketNotification

        /// <summary>
        /// Enables notifications of specified events for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification service method.</param>
        /// 
        /// <returns>The response from the PutBucketNotification service method, as returned by S3.</returns>
        public PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest request)
        {
            var marshaller = new PutBucketNotificationRequestMarshaller();
            var unmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<PutBucketNotificationRequest,PutBucketNotificationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketNotification
        ///         operation.</returns>
        public IAsyncResult BeginPutBucketNotification(PutBucketNotificationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketNotificationRequestMarshaller();
            var unmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketNotificationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketNotification.</param>
        /// 
        /// <returns>Returns a  PutBucketNotificationResult from S3.</returns>
        public  PutBucketNotificationResponse EndPutBucketNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketPolicy

        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public PutBucketPolicyResponse PutBucketPolicy(string bucketName, string policy)
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            return PutBucketPolicy(request);
        }


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="contentMD5">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public PutBucketPolicyResponse PutBucketPolicy(string bucketName, string policy, string contentMD5)
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            request.ContentMD5 = contentMD5;
            return PutBucketPolicy(request);
        }


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
        {
            var marshaller = new PutBucketPolicyRequestMarshaller();
            var unmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBucketPolicyRequest,PutBucketPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketPolicy
        ///         operation.</returns>
        public IAsyncResult BeginPutBucketPolicy(PutBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketPolicyRequestMarshaller();
            var unmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketPolicy.</param>
        /// 
        /// <returns>Returns a  PutBucketPolicyResult from S3.</returns>
        public  PutBucketPolicyResponse EndPutBucketPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketReplication

        /// <summary>
        /// Creates a new replication configuration (or replaces an existing one, if present).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication service method.</param>
        /// 
        /// <returns>The response from the PutBucketReplication service method, as returned by S3.</returns>
        public PutBucketReplicationResponse PutBucketReplication(PutBucketReplicationRequest request)
        {
            var marshaller = new PutBucketReplicationRequestMarshaller();
            var unmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<PutBucketReplicationRequest,PutBucketReplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketReplication
        ///         operation.</returns>
        public IAsyncResult BeginPutBucketReplication(PutBucketReplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketReplicationRequestMarshaller();
            var unmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketReplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketReplication.</param>
        /// 
        /// <returns>Returns a  PutBucketReplicationResult from S3.</returns>
        public  PutBucketReplicationResponse EndPutBucketReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketRequestPayment

        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. Documentation on requester pays buckets can be found at http://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// <param name="requestPaymentConfiguration">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        public PutBucketRequestPaymentResponse PutBucketRequestPayment(string bucketName, RequestPaymentConfiguration requestPaymentConfiguration)
        {
            var request = new PutBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            request.RequestPaymentConfiguration = requestPaymentConfiguration;
            return PutBucketRequestPayment(request);
        }


        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. Documentation on requester pays buckets can be found at http://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment service method.</param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        public PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request)
        {
            var marshaller = new PutBucketRequestPaymentRequestMarshaller();
            var unmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<PutBucketRequestPaymentRequest,PutBucketRequestPaymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketRequestPayment
        ///         operation.</returns>
        public IAsyncResult BeginPutBucketRequestPayment(PutBucketRequestPaymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketRequestPaymentRequestMarshaller();
            var unmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketRequestPaymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketRequestPayment.</param>
        /// 
        /// <returns>Returns a  PutBucketRequestPaymentResult from S3.</returns>
        public  PutBucketRequestPaymentResponse EndPutBucketRequestPayment(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketRequestPaymentResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketTagging

        /// <summary>
        /// Sets the tags for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="tagSet">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        public PutBucketTaggingResponse PutBucketTagging(string bucketName, List<Tag> tagSet)
        {
            var request = new PutBucketTaggingRequest();
            request.BucketName = bucketName;
            request.TagSet = tagSet;
            return PutBucketTagging(request);
        }


        /// <summary>
        /// Sets the tags for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging service method.</param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        public PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request)
        {
            var marshaller = new PutBucketTaggingRequestMarshaller();
            var unmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketTaggingRequest,PutBucketTaggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketTagging
        ///         operation.</returns>
        public IAsyncResult BeginPutBucketTagging(PutBucketTaggingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketTaggingRequestMarshaller();
            var unmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketTaggingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketTagging.</param>
        /// 
        /// <returns>Returns a  PutBucketTaggingResult from S3.</returns>
        public  PutBucketTaggingResponse EndPutBucketTagging(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketTaggingResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketVersioning

        /// <summary>
        /// Sets the versioning state of an existing bucket. To set the versioning state, you
        /// must be the bucket owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning service method.</param>
        /// 
        /// <returns>The response from the PutBucketVersioning service method, as returned by S3.</returns>
        public PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest request)
        {
            var marshaller = new PutBucketVersioningRequestMarshaller();
            var unmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<PutBucketVersioningRequest,PutBucketVersioningResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketVersioning
        ///         operation.</returns>
        public IAsyncResult BeginPutBucketVersioning(PutBucketVersioningRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketVersioningRequestMarshaller();
            var unmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketVersioningRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketVersioning.</param>
        /// 
        /// <returns>Returns a  PutBucketVersioningResult from S3.</returns>
        public  PutBucketVersioningResponse EndPutBucketVersioning(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketVersioningResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketWebsite

        /// <summary>
        /// Set the website configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// <param name="websiteConfiguration">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        public PutBucketWebsiteResponse PutBucketWebsite(string bucketName, WebsiteConfiguration websiteConfiguration)
        {
            var request = new PutBucketWebsiteRequest();
            request.BucketName = bucketName;
            request.WebsiteConfiguration = websiteConfiguration;
            return PutBucketWebsite(request);
        }


        /// <summary>
        /// Set the website configuration for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite service method.</param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        public PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request)
        {
            var marshaller = new PutBucketWebsiteRequestMarshaller();
            var unmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<PutBucketWebsiteRequest,PutBucketWebsiteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketWebsite
        ///         operation.</returns>
        public IAsyncResult BeginPutBucketWebsite(PutBucketWebsiteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutBucketWebsiteRequestMarshaller();
            var unmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return BeginInvoke<PutBucketWebsiteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketWebsite.</param>
        /// 
        /// <returns>Returns a  PutBucketWebsiteResult from S3.</returns>
        public  PutBucketWebsiteResponse EndPutBucketWebsite(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketWebsiteResponse>(asyncResult);
        }

        #endregion
        
        #region  PutCORSConfiguration

        /// <summary>
        /// Sets the cors configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// <param name="configuration">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public PutCORSConfigurationResponse PutCORSConfiguration(string bucketName, CORSConfiguration configuration)
        {
            var request = new PutCORSConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutCORSConfiguration(request);
        }


        /// <summary>
        /// Sets the cors configuration for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request)
        {
            var marshaller = new PutCORSConfigurationRequestMarshaller();
            var unmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutCORSConfigurationRequest,PutCORSConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutCORSConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginPutCORSConfiguration(PutCORSConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutCORSConfigurationRequestMarshaller();
            var unmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<PutCORSConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCORSConfiguration.</param>
        /// 
        /// <returns>Returns a  PutCORSConfigurationResult from S3.</returns>
        public  PutCORSConfigurationResponse EndPutCORSConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutCORSConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutLifecycleConfiguration

        /// <summary>
        /// Sets lifecycle configuration for your bucket. If a lifecycle configuration exists,
        /// it replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="configuration">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        public PutLifecycleConfigurationResponse PutLifecycleConfiguration(string bucketName, LifecycleConfiguration configuration)
        {
            var request = new PutLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutLifecycleConfiguration(request);
        }


        /// <summary>
        /// Sets lifecycle configuration for your bucket. If a lifecycle configuration exists,
        /// it replaces it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        public PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            var marshaller = new PutLifecycleConfigurationRequestMarshaller();
            var unmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleConfigurationRequest,PutLifecycleConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLifecycleConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginPutLifecycleConfiguration(PutLifecycleConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutLifecycleConfigurationRequestMarshaller();
            var unmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<PutLifecycleConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a  PutLifecycleConfigurationResult from S3.</returns>
        public  PutLifecycleConfigurationResponse EndPutLifecycleConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLifecycleConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutObject

        /// <summary>
        /// Adds an object to a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by S3.</returns>
        public PutObjectResponse PutObject(PutObjectRequest request)
        {
            var marshaller = new PutObjectRequestMarshaller();
            var unmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectRequest,PutObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutObject
        ///         operation.</returns>
        public IAsyncResult BeginPutObject(PutObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutObjectRequestMarshaller();
            var unmarshaller = PutObjectResponseUnmarshaller.Instance;

            return BeginInvoke<PutObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObject.</param>
        /// 
        /// <returns>Returns a  PutObjectResult from S3.</returns>
        public  PutObjectResponse EndPutObject(IAsyncResult asyncResult)
        {
            return EndInvoke<PutObjectResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreObject

        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public RestoreObjectResponse RestoreObject(string bucketName, string key)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return RestoreObject(request);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public RestoreObjectResponse RestoreObject(string bucketName, string key, int days)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.Days = days;
            return RestoreObject(request);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public RestoreObjectResponse RestoreObject(string bucketName, string key, string versionId)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return RestoreObject(request);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public RestoreObjectResponse RestoreObject(string bucketName, string key, string versionId, int days)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            request.Days = days;
            return RestoreObject(request);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject service method.</param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public RestoreObjectResponse RestoreObject(RestoreObjectRequest request)
        {
            var marshaller = new RestoreObjectRequestMarshaller();
            var unmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return Invoke<RestoreObjectRequest,RestoreObjectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreObject
        ///         operation.</returns>
        public IAsyncResult BeginRestoreObject(RestoreObjectRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RestoreObjectRequestMarshaller();
            var unmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return BeginInvoke<RestoreObjectRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreObject.</param>
        /// 
        /// <returns>Returns a  RestoreObjectResult from S3.</returns>
        public  RestoreObjectResponse EndRestoreObject(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreObjectResponse>(asyncResult);
        }

        #endregion
        
        #region  UploadPart

        /// <summary>
        /// Uploads a part in a multipart upload.
        /// 
        /// 
        /// <para>
        /// <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadPart service method.</param>
        /// 
        /// <returns>The response from the UploadPart service method, as returned by S3.</returns>
        public UploadPartResponse UploadPart(UploadPartRequest request)
        {
            var marshaller = new UploadPartRequestMarshaller();
            var unmarshaller = UploadPartResponseUnmarshaller.Instance;

            return Invoke<UploadPartRequest,UploadPartResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadPart operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadPart
        ///         operation.</returns>
        public IAsyncResult BeginUploadPart(UploadPartRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UploadPartRequestMarshaller();
            var unmarshaller = UploadPartResponseUnmarshaller.Instance;

            return BeginInvoke<UploadPartRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UploadPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadPart.</param>
        /// 
        /// <returns>Returns a  UploadPartResult from S3.</returns>
        public  UploadPartResponse EndUploadPart(IAsyncResult asyncResult)
        {
            return EndInvoke<UploadPartResponse>(asyncResult);
        }

        #endregion
        
    }
}