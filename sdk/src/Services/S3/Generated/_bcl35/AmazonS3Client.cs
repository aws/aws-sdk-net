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
using System.Net;

using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonS3Metadata();
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
            pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.S3.Internal.AmazonS3RetryPolicy(this.Config)));
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
        public virtual AbortMultipartUploadResponse AbortMultipartUpload(string bucketName, string key, string uploadId)
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
        public virtual AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadResponse>(request, options);
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
        public virtual IAsyncResult BeginAbortMultipartUpload(AbortMultipartUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortMultipartUpload.</param>
        /// 
        /// <returns>Returns a  AbortMultipartUploadResult from S3.</returns>
        public virtual AbortMultipartUploadResponse EndAbortMultipartUpload(IAsyncResult asyncResult)
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
        public virtual CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadResponse>(request, options);
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
        public virtual IAsyncResult BeginCompleteMultipartUpload(CompleteMultipartUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteMultipartUpload.</param>
        /// 
        /// <returns>Returns a  CompleteMultipartUploadResult from S3.</returns>
        public virtual CompleteMultipartUploadResponse EndCompleteMultipartUpload(IAsyncResult asyncResult)
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
        public virtual CopyObjectResponse CopyObject(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey)
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
        public virtual CopyObjectResponse CopyObject(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey)
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
        public virtual CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return Invoke<CopyObjectResponse>(request, options);
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
        public virtual IAsyncResult BeginCopyObject(CopyObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyObject.</param>
        /// 
        /// <returns>Returns a  CopyObjectResult from S3.</returns>
        public virtual CopyObjectResponse EndCopyObject(IAsyncResult asyncResult)
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
        public virtual CopyPartResponse CopyPart(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId)
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
        public virtual CopyPartResponse CopyPart(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId)
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
        public virtual CopyPartResponse CopyPart(CopyPartRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyPartResponseUnmarshaller.Instance;

            return Invoke<CopyPartResponse>(request, options);
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
        public virtual IAsyncResult BeginCopyPart(CopyPartRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyPartResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyPart.</param>
        /// 
        /// <returns>Returns a  CopyPartResult from S3.</returns>
        public virtual CopyPartResponse EndCopyPart(IAsyncResult asyncResult)
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
        public virtual DeleteBucketResponse DeleteBucket(string bucketName)
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
        public virtual DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteBucket(DeleteBucketRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucket.</param>
        /// 
        /// <returns>Returns a  DeleteBucketResult from S3.</returns>
        public virtual DeleteBucketResponse EndDeleteBucket(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketAnalyticsConfiguration

        /// <summary>
        /// Deletes an analytics configuration for the bucket (specified by the analytics configuration
        /// ID).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketAnalyticsConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketAnalyticsConfiguration service method, as returned by S3.</returns>
        public virtual DeleteBucketAnalyticsConfigurationResponse DeleteBucketAnalyticsConfiguration(DeleteBucketAnalyticsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketAnalyticsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketAnalyticsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketAnalyticsConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteBucketAnalyticsConfiguration(DeleteBucketAnalyticsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketAnalyticsConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteBucketAnalyticsConfigurationResult from S3.</returns>
        public virtual DeleteBucketAnalyticsConfigurationResponse EndDeleteBucketAnalyticsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketAnalyticsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketEncryption

        /// <summary>
        /// Deletes the server-side encryption configuration from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketEncryption service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketEncryption service method, as returned by S3.</returns>
        public virtual DeleteBucketEncryptionResponse DeleteBucketEncryption(DeleteBucketEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketEncryptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketEncryption operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketEncryption
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteBucketEncryption(DeleteBucketEncryptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketEncryption.</param>
        /// 
        /// <returns>Returns a  DeleteBucketEncryptionResult from S3.</returns>
        public virtual DeleteBucketEncryptionResponse EndDeleteBucketEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketInventoryConfiguration

        /// <summary>
        /// Deletes an inventory configuration (identified by the inventory ID) from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketInventoryConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketInventoryConfiguration service method, as returned by S3.</returns>
        public virtual DeleteBucketInventoryConfigurationResponse DeleteBucketInventoryConfiguration(DeleteBucketInventoryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketInventoryConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketInventoryConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketInventoryConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteBucketInventoryConfiguration(DeleteBucketInventoryConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketInventoryConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteBucketInventoryConfigurationResult from S3.</returns>
        public virtual DeleteBucketInventoryConfigurationResponse EndDeleteBucketInventoryConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketInventoryConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketMetricsConfiguration

        /// <summary>
        /// Deletes a metrics configuration (specified by the metrics configuration ID) from the
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketMetricsConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketMetricsConfiguration service method, as returned by S3.</returns>
        public virtual DeleteBucketMetricsConfigurationResponse DeleteBucketMetricsConfiguration(DeleteBucketMetricsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketMetricsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketMetricsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketMetricsConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteBucketMetricsConfiguration(DeleteBucketMetricsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketMetricsConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteBucketMetricsConfigurationResult from S3.</returns>
        public virtual DeleteBucketMetricsConfigurationResponse EndDeleteBucketMetricsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketMetricsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketPolicy

        /// <summary>
        /// Deletes the policy from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketPolicyRequest used to execute the DeleteBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        public virtual DeleteBucketPolicyResponse DeleteBucketPolicy(string bucketName)
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
        public virtual DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketPolicyResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteBucketPolicy(DeleteBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteBucketPolicyResult from S3.</returns>
        public virtual DeleteBucketPolicyResponse EndDeleteBucketPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBucketReplication

        /// <summary>
        /// Deletes the replication configuration from the bucket. For information about replication
        /// configuration, see <a href=" https://docs.aws.amazon.com/AmazonS3/latest/dev/crr.html">Cross-Region
        /// Replication (CRR)</a> in the <i>Amazon S3 Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketReplication service method, as returned by S3.</returns>
        public virtual DeleteBucketReplicationResponse DeleteBucketReplication(DeleteBucketReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketReplicationResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteBucketReplication(DeleteBucketReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketReplication.</param>
        /// 
        /// <returns>Returns a  DeleteBucketReplicationResult from S3.</returns>
        public virtual DeleteBucketReplicationResponse EndDeleteBucketReplication(IAsyncResult asyncResult)
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
        public virtual DeleteBucketTaggingResponse DeleteBucketTagging(string bucketName)
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
        public virtual DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketTaggingResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteBucketTagging(DeleteBucketTaggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketTagging.</param>
        /// 
        /// <returns>Returns a  DeleteBucketTaggingResult from S3.</returns>
        public virtual DeleteBucketTaggingResponse EndDeleteBucketTagging(IAsyncResult asyncResult)
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
        public virtual DeleteBucketWebsiteResponse DeleteBucketWebsite(string bucketName)
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
        public virtual DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketWebsiteResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteBucketWebsite(DeleteBucketWebsiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketWebsite.</param>
        /// 
        /// <returns>Returns a  DeleteBucketWebsiteResult from S3.</returns>
        public virtual DeleteBucketWebsiteResponse EndDeleteBucketWebsite(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBucketWebsiteResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCORSConfiguration

        /// <summary>
        /// Deletes the CORS configuration information set for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteCORSConfigurationRequest used to execute the DeleteCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public virtual DeleteCORSConfigurationResponse DeleteCORSConfiguration(string bucketName)
        {
            var request = new DeleteCORSConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteCORSConfiguration(request);
        }


        /// <summary>
        /// Deletes the CORS configuration information set for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public virtual DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCORSConfigurationResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteCORSConfiguration(DeleteCORSConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCORSConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteCORSConfigurationResult from S3.</returns>
        public virtual DeleteCORSConfigurationResponse EndDeleteCORSConfiguration(IAsyncResult asyncResult)
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
        public virtual DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(string bucketName)
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
        public virtual DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleConfigurationResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLifecycleConfigurationResult from S3.</returns>
        public virtual DeleteLifecycleConfigurationResponse EndDeleteLifecycleConfiguration(IAsyncResult asyncResult)
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
        public virtual DeleteObjectResponse DeleteObject(string bucketName, string key)
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
        public virtual DeleteObjectResponse DeleteObject(string bucketName, string key, string versionId)
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
        public virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteObject(DeleteObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObject.</param>
        /// 
        /// <returns>Returns a  DeleteObjectResult from S3.</returns>
        public virtual DeleteObjectResponse EndDeleteObject(IAsyncResult asyncResult)
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
        public virtual DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectsResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteObjects(DeleteObjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObjects.</param>
        /// 
        /// <returns>Returns a  DeleteObjectsResult from S3.</returns>
        public virtual DeleteObjectsResponse EndDeleteObjects(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteObjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteObjectTagging

        /// <summary>
        /// Removes the tag-set from an existing object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteObjectTagging service method, as returned by S3.</returns>
        public virtual DeleteObjectTaggingResponse DeleteObjectTagging(DeleteObjectTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectTaggingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObjectTagging
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteObjectTagging(DeleteObjectTaggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectTaggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObjectTagging.</param>
        /// 
        /// <returns>Returns a  DeleteObjectTaggingResult from S3.</returns>
        public virtual DeleteObjectTaggingResponse EndDeleteObjectTagging(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteObjectTaggingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePublicAccessBlock

        /// <summary>
        /// Removes the <code>PublicAccessBlock</code> configuration from an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the DeletePublicAccessBlock service method, as returned by S3.</returns>
        public virtual DeletePublicAccessBlockResponse DeletePublicAccessBlock(DeletePublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<DeletePublicAccessBlockResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePublicAccessBlock
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeletePublicAccessBlock(DeletePublicAccessBlockRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicAccessBlockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePublicAccessBlock.</param>
        /// 
        /// <returns>Returns a  DeletePublicAccessBlockResult from S3.</returns>
        public virtual DeletePublicAccessBlockResponse EndDeletePublicAccessBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePublicAccessBlockResponse>(asyncResult);
        }

        #endregion
        
        #region  GetACL

        /// <summary>
        /// Gets the access control policy for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetACLRequest used to execute the GetACL service method.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        public virtual GetACLResponse GetACL(string bucketName)
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
        public virtual GetACLResponse GetACL(GetACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetACLResponseUnmarshaller.Instance;

            return Invoke<GetACLResponse>(request, options);
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
        public virtual IAsyncResult BeginGetACL(GetACLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetACLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetACL.</param>
        /// 
        /// <returns>Returns a  GetACLResult from S3.</returns>
        public virtual GetACLResponse EndGetACL(IAsyncResult asyncResult)
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
        public virtual GetBucketAccelerateConfigurationResponse GetBucketAccelerateConfiguration(string bucketName)
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
        public virtual GetBucketAccelerateConfigurationResponse GetBucketAccelerateConfiguration(GetBucketAccelerateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketAccelerateConfigurationResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketAccelerateConfiguration(GetBucketAccelerateConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketAccelerateConfiguration.</param>
        /// 
        /// <returns>Returns a  GetBucketAccelerateConfigurationResult from S3.</returns>
        public virtual GetBucketAccelerateConfigurationResponse EndGetBucketAccelerateConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketAccelerateConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketAnalyticsConfiguration

        /// <summary>
        /// Gets an analytics configuration for the bucket (specified by the analytics configuration
        /// ID).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAnalyticsConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketAnalyticsConfiguration service method, as returned by S3.</returns>
        public virtual GetBucketAnalyticsConfigurationResponse GetBucketAnalyticsConfiguration(GetBucketAnalyticsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketAnalyticsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAnalyticsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketAnalyticsConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetBucketAnalyticsConfiguration(GetBucketAnalyticsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketAnalyticsConfiguration.</param>
        /// 
        /// <returns>Returns a  GetBucketAnalyticsConfigurationResult from S3.</returns>
        public virtual GetBucketAnalyticsConfigurationResponse EndGetBucketAnalyticsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketAnalyticsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketEncryption

        /// <summary>
        /// Returns the server-side encryption configuration of a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketEncryption service method.</param>
        /// 
        /// <returns>The response from the GetBucketEncryption service method, as returned by S3.</returns>
        public virtual GetBucketEncryptionResponse GetBucketEncryption(GetBucketEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetBucketEncryptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketEncryption operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketEncryption
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetBucketEncryption(GetBucketEncryptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketEncryption.</param>
        /// 
        /// <returns>Returns a  GetBucketEncryptionResult from S3.</returns>
        public virtual GetBucketEncryptionResponse EndGetBucketEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketInventoryConfiguration

        /// <summary>
        /// Returns an inventory configuration (identified by the inventory ID) from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketInventoryConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketInventoryConfiguration service method, as returned by S3.</returns>
        public virtual GetBucketInventoryConfigurationResponse GetBucketInventoryConfiguration(GetBucketInventoryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketInventoryConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketInventoryConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketInventoryConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetBucketInventoryConfiguration(GetBucketInventoryConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketInventoryConfiguration.</param>
        /// 
        /// <returns>Returns a  GetBucketInventoryConfigurationResult from S3.</returns>
        public virtual GetBucketInventoryConfigurationResponse EndGetBucketInventoryConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketInventoryConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketLocation

        /// <summary>
        /// Returns the region the bucket resides in.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLocationRequest used to execute the GetBucketLocation service method.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        public virtual GetBucketLocationResponse GetBucketLocation(string bucketName)
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
        public virtual GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return Invoke<GetBucketLocationResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketLocation(GetBucketLocationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLocation.</param>
        /// 
        /// <returns>Returns a  GetBucketLocationResult from S3.</returns>
        public virtual GetBucketLocationResponse EndGetBucketLocation(IAsyncResult asyncResult)
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
        public virtual GetBucketLoggingResponse GetBucketLogging(string bucketName)
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
        public virtual GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketLoggingResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketLogging(GetBucketLoggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLogging.</param>
        /// 
        /// <returns>Returns a  GetBucketLoggingResult from S3.</returns>
        public virtual GetBucketLoggingResponse EndGetBucketLogging(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketLoggingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketMetricsConfiguration

        /// <summary>
        /// Gets a metrics configuration (specified by the metrics configuration ID) from the
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketMetricsConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketMetricsConfiguration service method, as returned by S3.</returns>
        public virtual GetBucketMetricsConfigurationResponse GetBucketMetricsConfiguration(GetBucketMetricsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketMetricsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketMetricsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketMetricsConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetBucketMetricsConfiguration(GetBucketMetricsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketMetricsConfiguration.</param>
        /// 
        /// <returns>Returns a  GetBucketMetricsConfigurationResult from S3.</returns>
        public virtual GetBucketMetricsConfigurationResponse EndGetBucketMetricsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketMetricsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketNotification

        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket to get the notification configuration for.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        public virtual GetBucketNotificationResponse GetBucketNotification(string bucketName)
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
        public virtual GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<GetBucketNotificationResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketNotification(GetBucketNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketNotification.</param>
        /// 
        /// <returns>Returns a  GetBucketNotificationResult from S3.</returns>
        public virtual GetBucketNotificationResponse EndGetBucketNotification(IAsyncResult asyncResult)
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
        public virtual GetBucketPolicyResponse GetBucketPolicy(string bucketName)
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
        public virtual GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketPolicy(GetBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketPolicy.</param>
        /// 
        /// <returns>Returns a  GetBucketPolicyResult from S3.</returns>
        public virtual GetBucketPolicyResponse EndGetBucketPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketPolicyStatus

        /// <summary>
        /// Retrieves the policy status for an Amazon S3 bucket, indicating whether the bucket
        /// is public.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicyStatus service method.</param>
        /// 
        /// <returns>The response from the GetBucketPolicyStatus service method, as returned by S3.</returns>
        public virtual GetBucketPolicyStatusResponse GetBucketPolicyStatus(GetBucketPolicyStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyStatusResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicyStatus operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketPolicyStatus
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetBucketPolicyStatus(GetBucketPolicyStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketPolicyStatus.</param>
        /// 
        /// <returns>Returns a  GetBucketPolicyStatusResult from S3.</returns>
        public virtual GetBucketPolicyStatusResponse EndGetBucketPolicyStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketPolicyStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBucketReplication

        /// <summary>
        /// Retrieves the replication configuration for the given Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication service method.</param>
        /// 
        /// <returns>The response from the GetBucketReplication service method, as returned by S3.</returns>
        public virtual GetBucketReplicationResponse GetBucketReplication(GetBucketReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<GetBucketReplicationResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketReplication(GetBucketReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketReplication.</param>
        /// 
        /// <returns>Returns a  GetBucketReplicationResult from S3.</returns>
        public virtual GetBucketReplicationResponse EndGetBucketReplication(IAsyncResult asyncResult)
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
        public virtual GetBucketRequestPaymentResponse GetBucketRequestPayment(string bucketName)
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
        public virtual GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<GetBucketRequestPaymentResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketRequestPayment(GetBucketRequestPaymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketRequestPayment.</param>
        /// 
        /// <returns>Returns a  GetBucketRequestPaymentResult from S3.</returns>
        public virtual GetBucketRequestPaymentResponse EndGetBucketRequestPayment(IAsyncResult asyncResult)
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
        public virtual GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketTaggingResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketTagging(GetBucketTaggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketTagging.</param>
        /// 
        /// <returns>Returns a  GetBucketTaggingResult from S3.</returns>
        public virtual GetBucketTaggingResponse EndGetBucketTagging(IAsyncResult asyncResult)
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
        public virtual GetBucketVersioningResponse GetBucketVersioning(string bucketName)
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
        public virtual GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<GetBucketVersioningResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketVersioning(GetBucketVersioningRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketVersioning.</param>
        /// 
        /// <returns>Returns a  GetBucketVersioningResult from S3.</returns>
        public virtual GetBucketVersioningResponse EndGetBucketVersioning(IAsyncResult asyncResult)
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
        public virtual GetBucketWebsiteResponse GetBucketWebsite(string bucketName)
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
        public virtual GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<GetBucketWebsiteResponse>(request, options);
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
        public virtual IAsyncResult BeginGetBucketWebsite(GetBucketWebsiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketWebsite.</param>
        /// 
        /// <returns>Returns a  GetBucketWebsiteResult from S3.</returns>
        public virtual GetBucketWebsiteResponse EndGetBucketWebsite(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBucketWebsiteResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCORSConfiguration

        /// <summary>
        /// Returns the CORS configuration for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetCORSConfigurationRequest used to execute the GetCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public virtual GetCORSConfigurationResponse GetCORSConfiguration(string bucketName)
        {
            var request = new GetCORSConfigurationRequest();
            request.BucketName = bucketName;
            return GetCORSConfiguration(request);
        }


        /// <summary>
        /// Returns the CORS configuration for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public virtual GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetCORSConfigurationResponse>(request, options);
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
        public virtual IAsyncResult BeginGetCORSConfiguration(GetCORSConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCORSConfiguration.</param>
        /// 
        /// <returns>Returns a  GetCORSConfigurationResult from S3.</returns>
        public virtual GetCORSConfigurationResponse EndGetCORSConfiguration(IAsyncResult asyncResult)
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
        public virtual GetLifecycleConfigurationResponse GetLifecycleConfiguration(string bucketName)
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
        public virtual GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLifecycleConfigurationResponse>(request, options);
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
        public virtual IAsyncResult BeginGetLifecycleConfiguration(GetLifecycleConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLifecycleConfigurationResult from S3.</returns>
        public virtual GetLifecycleConfigurationResponse EndGetLifecycleConfiguration(IAsyncResult asyncResult)
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
        public virtual GetObjectResponse GetObject(string bucketName, string key)
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
        public virtual GetObjectResponse GetObject(string bucketName, string key, string versionId)
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
        public virtual GetObjectResponse GetObject(GetObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return Invoke<GetObjectResponse>(request, options);
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
        public virtual IAsyncResult BeginGetObject(GetObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObject.</param>
        /// 
        /// <returns>Returns a  GetObjectResult from S3.</returns>
        public virtual GetObjectResponse EndGetObject(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectResponse>(asyncResult);
        }

        #endregion
        
        #region  GetObjectLegalHold

        /// <summary>
        /// Gets an object's current Legal Hold status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLegalHold service method.</param>
        /// 
        /// <returns>The response from the GetObjectLegalHold service method, as returned by S3.</returns>
        public virtual GetObjectLegalHoldResponse GetObjectLegalHold(GetObjectLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLegalHoldResponseUnmarshaller.Instance;

            return Invoke<GetObjectLegalHoldResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectLegalHold operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLegalHold operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectLegalHold
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetObjectLegalHold(GetObjectLegalHoldRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLegalHoldResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectLegalHold operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectLegalHold.</param>
        /// 
        /// <returns>Returns a  GetObjectLegalHoldResult from S3.</returns>
        public virtual GetObjectLegalHoldResponse EndGetObjectLegalHold(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectLegalHoldResponse>(asyncResult);
        }

        #endregion
        
        #region  GetObjectLockConfiguration

        /// <summary>
        /// Gets the Object Lock configuration for a bucket. The rule specified in the Object
        /// Lock configuration will be applied by default to every new object placed in the specified
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLockConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetObjectLockConfiguration service method, as returned by S3.</returns>
        public virtual GetObjectLockConfigurationResponse GetObjectLockConfiguration(GetObjectLockConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetObjectLockConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLockConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectLockConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetObjectLockConfiguration(GetObjectLockConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLockConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectLockConfiguration.</param>
        /// 
        /// <returns>Returns a  GetObjectLockConfigurationResult from S3.</returns>
        public virtual GetObjectLockConfigurationResponse EndGetObjectLockConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectLockConfigurationResponse>(asyncResult);
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
        public virtual GetObjectMetadataResponse GetObjectMetadata(string bucketName, string key)
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
        public virtual GetObjectMetadataResponse GetObjectMetadata(string bucketName, string key, string versionId)
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
        public virtual GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return Invoke<GetObjectMetadataResponse>(request, options);
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
        public virtual IAsyncResult BeginGetObjectMetadata(GetObjectMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectMetadata.</param>
        /// 
        /// <returns>Returns a  GetObjectMetadataResult from S3.</returns>
        public virtual GetObjectMetadataResponse EndGetObjectMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetObjectRetention

        /// <summary>
        /// Retrieves an object's retention settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectRetention service method.</param>
        /// 
        /// <returns>The response from the GetObjectRetention service method, as returned by S3.</returns>
        public virtual GetObjectRetentionResponse GetObjectRetention(GetObjectRetentionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectRetentionResponseUnmarshaller.Instance;

            return Invoke<GetObjectRetentionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectRetention operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectRetention operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectRetention
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetObjectRetention(GetObjectRetentionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectRetentionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectRetention operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectRetention.</param>
        /// 
        /// <returns>Returns a  GetObjectRetentionResult from S3.</returns>
        public virtual GetObjectRetentionResponse EndGetObjectRetention(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectRetentionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetObjectTagging

        /// <summary>
        /// Returns the tag-set of an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTagging service method.</param>
        /// 
        /// <returns>The response from the GetObjectTagging service method, as returned by S3.</returns>
        public virtual GetObjectTaggingResponse GetObjectTagging(GetObjectTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<GetObjectTaggingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectTagging
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetObjectTagging(GetObjectTaggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTaggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectTagging.</param>
        /// 
        /// <returns>Returns a  GetObjectTaggingResult from S3.</returns>
        public virtual GetObjectTaggingResponse EndGetObjectTagging(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectTaggingResponse>(asyncResult);
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
        public virtual GetObjectTorrentResponse GetObjectTorrent(string bucketName, string key)
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
        public virtual GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTorrentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return Invoke<GetObjectTorrentResponse>(request, options);
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
        public virtual IAsyncResult BeginGetObjectTorrent(GetObjectTorrentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTorrentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetObjectTorrent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectTorrent.</param>
        /// 
        /// <returns>Returns a  GetObjectTorrentResult from S3.</returns>
        public virtual GetObjectTorrentResponse EndGetObjectTorrent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetObjectTorrentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPublicAccessBlock

        /// <summary>
        /// Retrieves the <code>PublicAccessBlock</code> configuration for an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the GetPublicAccessBlock service method, as returned by S3.</returns>
        public virtual GetPublicAccessBlockResponse GetPublicAccessBlock(GetPublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<GetPublicAccessBlockResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPublicAccessBlock
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetPublicAccessBlock(GetPublicAccessBlockRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPublicAccessBlock.</param>
        /// 
        /// <returns>Returns a  GetPublicAccessBlockResult from S3.</returns>
        public virtual GetPublicAccessBlockResponse EndGetPublicAccessBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPublicAccessBlockResponse>(asyncResult);
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
        internal virtual HeadBucketResponse HeadBucket(HeadBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HeadBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return Invoke<HeadBucketResponse>(request, options);
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
        internal virtual IAsyncResult BeginHeadBucket(HeadBucketRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HeadBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HeadBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHeadBucket.</param>
        /// 
        /// <returns>Returns a  HeadBucketResult from S3.</returns>
        internal virtual HeadBucketResponse EndHeadBucket(IAsyncResult asyncResult)
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
        ///  <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// </summary>
        /// <param name="bucketName">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// <param name="key">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public virtual InitiateMultipartUploadResponse InitiateMultipartUpload(string bucketName, string key)
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
        ///  <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public virtual InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadResponse>(request, options);
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
        public virtual IAsyncResult BeginInitiateMultipartUpload(InitiateMultipartUploadRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateMultipartUpload.</param>
        /// 
        /// <returns>Returns a  InitiateMultipartUploadResult from S3.</returns>
        public virtual InitiateMultipartUploadResponse EndInitiateMultipartUpload(IAsyncResult asyncResult)
        {
            return EndInvoke<InitiateMultipartUploadResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBucketAnalyticsConfigurations

        /// <summary>
        /// Lists the analytics configurations for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBucketAnalyticsConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListBucketAnalyticsConfigurations service method, as returned by S3.</returns>
        public virtual ListBucketAnalyticsConfigurationsResponse ListBucketAnalyticsConfigurations(ListBucketAnalyticsConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketAnalyticsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketAnalyticsConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketAnalyticsConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketAnalyticsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketAnalyticsConfigurations operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBucketAnalyticsConfigurations
        ///         operation.</returns>
        public virtual IAsyncResult BeginListBucketAnalyticsConfigurations(ListBucketAnalyticsConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketAnalyticsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketAnalyticsConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBucketAnalyticsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBucketAnalyticsConfigurations.</param>
        /// 
        /// <returns>Returns a  ListBucketAnalyticsConfigurationsResult from S3.</returns>
        public virtual ListBucketAnalyticsConfigurationsResponse EndListBucketAnalyticsConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBucketAnalyticsConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBucketInventoryConfigurations

        /// <summary>
        /// Returns a list of inventory configurations for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBucketInventoryConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListBucketInventoryConfigurations service method, as returned by S3.</returns>
        public virtual ListBucketInventoryConfigurationsResponse ListBucketInventoryConfigurations(ListBucketInventoryConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketInventoryConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketInventoryConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketInventoryConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketInventoryConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketInventoryConfigurations operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBucketInventoryConfigurations
        ///         operation.</returns>
        public virtual IAsyncResult BeginListBucketInventoryConfigurations(ListBucketInventoryConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketInventoryConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketInventoryConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBucketInventoryConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBucketInventoryConfigurations.</param>
        /// 
        /// <returns>Returns a  ListBucketInventoryConfigurationsResult from S3.</returns>
        public virtual ListBucketInventoryConfigurationsResponse EndListBucketInventoryConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBucketInventoryConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBucketMetricsConfigurations

        /// <summary>
        /// Lists the metrics configurations for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBucketMetricsConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListBucketMetricsConfigurations service method, as returned by S3.</returns>
        public virtual ListBucketMetricsConfigurationsResponse ListBucketMetricsConfigurations(ListBucketMetricsConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketMetricsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketMetricsConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketMetricsConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketMetricsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketMetricsConfigurations operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBucketMetricsConfigurations
        ///         operation.</returns>
        public virtual IAsyncResult BeginListBucketMetricsConfigurations(ListBucketMetricsConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketMetricsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketMetricsConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBucketMetricsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBucketMetricsConfigurations.</param>
        /// 
        /// <returns>Returns a  ListBucketMetricsConfigurationsResult from S3.</returns>
        public virtual ListBucketMetricsConfigurationsResponse EndListBucketMetricsConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBucketMetricsConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBuckets

        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public virtual ListBucketsResponse ListBuckets()
        {
            return ListBuckets(new ListBucketsRequest());
        }

        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets service method.</param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public virtual ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return Invoke<ListBucketsResponse>(request, options);
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
        public virtual IAsyncResult BeginListBuckets(ListBucketsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuckets.</param>
        /// 
        /// <returns>Returns a  ListBucketsResult from S3.</returns>
        public virtual ListBucketsResponse EndListBuckets(IAsyncResult asyncResult)
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
        public virtual ListMultipartUploadsResponse ListMultipartUploads(string bucketName)
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
        public virtual ListMultipartUploadsResponse ListMultipartUploads(string bucketName, string prefix)
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
        public virtual ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsResponse>(request, options);
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
        public virtual IAsyncResult BeginListMultipartUploads(ListMultipartUploadsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultipartUploads.</param>
        /// 
        /// <returns>Returns a  ListMultipartUploadsResult from S3.</returns>
        public virtual ListMultipartUploadsResponse EndListMultipartUploads(IAsyncResult asyncResult)
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
        public virtual ListObjectsResponse ListObjects(string bucketName)
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
        public virtual ListObjectsResponse ListObjects(string bucketName, string prefix)
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
        public virtual ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return Invoke<ListObjectsResponse>(request, options);
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
        public virtual IAsyncResult BeginListObjects(ListObjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjects.</param>
        /// 
        /// <returns>Returns a  ListObjectsResult from S3.</returns>
        public virtual ListObjectsResponse EndListObjects(IAsyncResult asyncResult)
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
        public virtual ListObjectsV2Response ListObjectsV2(ListObjectsV2Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return Invoke<ListObjectsV2Response>(request, options);
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
        public virtual IAsyncResult BeginListObjectsV2(ListObjectsV2Request request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListObjectsV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjectsV2.</param>
        /// 
        /// <returns>Returns a  ListObjectsV2Result from S3.</returns>
        public virtual ListObjectsV2Response EndListObjectsV2(IAsyncResult asyncResult)
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
        public virtual ListPartsResponse ListParts(string bucketName, string key, string uploadId)
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
        public virtual ListPartsResponse ListParts(ListPartsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsResponse>(request, options);
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
        public virtual IAsyncResult BeginListParts(ListPartsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListParts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParts.</param>
        /// 
        /// <returns>Returns a  ListPartsResult from S3.</returns>
        public virtual ListPartsResponse EndListParts(IAsyncResult asyncResult)
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
        public virtual ListVersionsResponse ListVersions(string bucketName)
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
        public virtual ListVersionsResponse ListVersions(string bucketName, string prefix)
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
        public virtual ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return Invoke<ListVersionsResponse>(request, options);
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
        public virtual IAsyncResult BeginListVersions(ListVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// 
        /// <returns>Returns a  ListVersionsResult from S3.</returns>
        public virtual ListVersionsResponse EndListVersions(IAsyncResult asyncResult)
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
        public virtual PutACLResponse PutACL(PutACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutACLResponseUnmarshaller.Instance;

            return Invoke<PutACLResponse>(request, options);
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
        public virtual IAsyncResult BeginPutACL(PutACLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutACLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutACL.</param>
        /// 
        /// <returns>Returns a  PutACLResult from S3.</returns>
        public virtual PutACLResponse EndPutACL(IAsyncResult asyncResult)
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
        public virtual PutBucketResponse PutBucket(string bucketName)
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
        public virtual PutBucketResponse PutBucket(PutBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketResponseUnmarshaller.Instance;

            return Invoke<PutBucketResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucket(PutBucketRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucket.</param>
        /// 
        /// <returns>Returns a  PutBucketResult from S3.</returns>
        public virtual PutBucketResponse EndPutBucket(IAsyncResult asyncResult)
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
        public virtual PutBucketAccelerateConfigurationResponse PutBucketAccelerateConfiguration(PutBucketAccelerateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketAccelerateConfigurationResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucketAccelerateConfiguration(PutBucketAccelerateConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketAccelerateConfiguration.</param>
        /// 
        /// <returns>Returns a  PutBucketAccelerateConfigurationResult from S3.</returns>
        public virtual PutBucketAccelerateConfigurationResponse EndPutBucketAccelerateConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketAccelerateConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketAnalyticsConfiguration

        /// <summary>
        /// Sets an analytics configuration for the bucket (specified by the analytics configuration
        /// ID).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAnalyticsConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketAnalyticsConfiguration service method, as returned by S3.</returns>
        public virtual PutBucketAnalyticsConfigurationResponse PutBucketAnalyticsConfiguration(PutBucketAnalyticsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketAnalyticsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAnalyticsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketAnalyticsConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutBucketAnalyticsConfiguration(PutBucketAnalyticsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketAnalyticsConfiguration.</param>
        /// 
        /// <returns>Returns a  PutBucketAnalyticsConfigurationResult from S3.</returns>
        public virtual PutBucketAnalyticsConfigurationResponse EndPutBucketAnalyticsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketAnalyticsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketEncryption

        /// <summary>
        /// Creates a new server-side encryption configuration (or replaces an existing one, if
        /// present).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketEncryption service method.</param>
        /// 
        /// <returns>The response from the PutBucketEncryption service method, as returned by S3.</returns>
        public virtual PutBucketEncryptionResponse PutBucketEncryption(PutBucketEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<PutBucketEncryptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketEncryption operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketEncryption
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutBucketEncryption(PutBucketEncryptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketEncryptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketEncryption.</param>
        /// 
        /// <returns>Returns a  PutBucketEncryptionResult from S3.</returns>
        public virtual PutBucketEncryptionResponse EndPutBucketEncryption(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketEncryptionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketInventoryConfiguration

        /// <summary>
        /// Adds an inventory configuration (identified by the inventory ID) from the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketInventoryConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketInventoryConfiguration service method, as returned by S3.</returns>
        public virtual PutBucketInventoryConfigurationResponse PutBucketInventoryConfiguration(PutBucketInventoryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketInventoryConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketInventoryConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketInventoryConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutBucketInventoryConfiguration(PutBucketInventoryConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketInventoryConfiguration.</param>
        /// 
        /// <returns>Returns a  PutBucketInventoryConfigurationResult from S3.</returns>
        public virtual PutBucketInventoryConfigurationResponse EndPutBucketInventoryConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketInventoryConfigurationResponse>(asyncResult);
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
        public virtual PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketLoggingResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucketLogging(PutBucketLoggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketLogging.</param>
        /// 
        /// <returns>Returns a  PutBucketLoggingResult from S3.</returns>
        public virtual PutBucketLoggingResponse EndPutBucketLogging(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketLoggingResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketMetricsConfiguration

        /// <summary>
        /// Sets a metrics configuration (specified by the metrics configuration ID) for the bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketMetricsConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketMetricsConfiguration service method, as returned by S3.</returns>
        public virtual PutBucketMetricsConfigurationResponse PutBucketMetricsConfiguration(PutBucketMetricsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketMetricsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketMetricsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketMetricsConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutBucketMetricsConfiguration(PutBucketMetricsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketMetricsConfiguration.</param>
        /// 
        /// <returns>Returns a  PutBucketMetricsConfigurationResult from S3.</returns>
        public virtual PutBucketMetricsConfigurationResponse EndPutBucketMetricsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketMetricsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketNotification

        /// <summary>
        /// Enables notifications of specified events for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification service method.</param>
        /// 
        /// <returns>The response from the PutBucketNotification service method, as returned by S3.</returns>
        public virtual PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<PutBucketNotificationResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucketNotification(PutBucketNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketNotification.</param>
        /// 
        /// <returns>Returns a  PutBucketNotificationResult from S3.</returns>
        public virtual PutBucketNotificationResponse EndPutBucketNotification(IAsyncResult asyncResult)
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
        public virtual PutBucketPolicyResponse PutBucketPolicy(string bucketName, string policy)
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
        public virtual PutBucketPolicyResponse PutBucketPolicy(string bucketName, string policy, string contentMD5)
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
        public virtual PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBucketPolicyResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucketPolicy(PutBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketPolicy.</param>
        /// 
        /// <returns>Returns a  PutBucketPolicyResult from S3.</returns>
        public virtual PutBucketPolicyResponse EndPutBucketPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutBucketReplication

        /// <summary>
        /// Creates a replication configuration or replaces an existing one. For more information,
        /// see <a href=" https://docs.aws.amazon.com/AmazonS3/latest/dev/crr.html">Cross-Region
        /// Replication (CRR)</a> in the <i>Amazon S3 Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication service method.</param>
        /// 
        /// <returns>The response from the PutBucketReplication service method, as returned by S3.</returns>
        public virtual PutBucketReplicationResponse PutBucketReplication(PutBucketReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<PutBucketReplicationResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucketReplication(PutBucketReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketReplication.</param>
        /// 
        /// <returns>Returns a  PutBucketReplicationResult from S3.</returns>
        public virtual PutBucketReplicationResponse EndPutBucketReplication(IAsyncResult asyncResult)
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
        public virtual PutBucketRequestPaymentResponse PutBucketRequestPayment(string bucketName, RequestPaymentConfiguration requestPaymentConfiguration)
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
        public virtual PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<PutBucketRequestPaymentResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucketRequestPayment(PutBucketRequestPaymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketRequestPayment.</param>
        /// 
        /// <returns>Returns a  PutBucketRequestPaymentResult from S3.</returns>
        public virtual PutBucketRequestPaymentResponse EndPutBucketRequestPayment(IAsyncResult asyncResult)
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
        public virtual PutBucketTaggingResponse PutBucketTagging(string bucketName, List<Tag> tagSet)
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
        public virtual PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketTaggingResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucketTagging(PutBucketTaggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketTagging.</param>
        /// 
        /// <returns>Returns a  PutBucketTaggingResult from S3.</returns>
        public virtual PutBucketTaggingResponse EndPutBucketTagging(IAsyncResult asyncResult)
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
        public virtual PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<PutBucketVersioningResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucketVersioning(PutBucketVersioningRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketVersioning.</param>
        /// 
        /// <returns>Returns a  PutBucketVersioningResult from S3.</returns>
        public virtual PutBucketVersioningResponse EndPutBucketVersioning(IAsyncResult asyncResult)
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
        public virtual PutBucketWebsiteResponse PutBucketWebsite(string bucketName, WebsiteConfiguration websiteConfiguration)
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
        public virtual PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<PutBucketWebsiteResponse>(request, options);
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
        public virtual IAsyncResult BeginPutBucketWebsite(PutBucketWebsiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketWebsite.</param>
        /// 
        /// <returns>Returns a  PutBucketWebsiteResult from S3.</returns>
        public virtual PutBucketWebsiteResponse EndPutBucketWebsite(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBucketWebsiteResponse>(asyncResult);
        }

        #endregion
        
        #region  PutCORSConfiguration

        /// <summary>
        /// Sets the CORS configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// <param name="configuration">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public virtual PutCORSConfigurationResponse PutCORSConfiguration(string bucketName, CORSConfiguration configuration)
        {
            var request = new PutCORSConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutCORSConfiguration(request);
        }


        /// <summary>
        /// Sets the CORS configuration for a bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public virtual PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutCORSConfigurationResponse>(request, options);
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
        public virtual IAsyncResult BeginPutCORSConfiguration(PutCORSConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCORSConfiguration.</param>
        /// 
        /// <returns>Returns a  PutCORSConfigurationResult from S3.</returns>
        public virtual PutCORSConfigurationResponse EndPutCORSConfiguration(IAsyncResult asyncResult)
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
        public virtual PutLifecycleConfigurationResponse PutLifecycleConfiguration(string bucketName, LifecycleConfiguration configuration)
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
        public virtual PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleConfigurationResponse>(request, options);
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
        public virtual IAsyncResult BeginPutLifecycleConfiguration(PutLifecycleConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a  PutLifecycleConfigurationResult from S3.</returns>
        public virtual PutLifecycleConfigurationResponse EndPutLifecycleConfiguration(IAsyncResult asyncResult)
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
        public virtual PutObjectResponse PutObject(PutObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectResponse>(request, options);
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
        public virtual IAsyncResult BeginPutObject(PutObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObject.</param>
        /// 
        /// <returns>Returns a  PutObjectResult from S3.</returns>
        public virtual PutObjectResponse EndPutObject(IAsyncResult asyncResult)
        {
            return EndInvoke<PutObjectResponse>(asyncResult);
        }

        #endregion
        
        #region  PutObjectLegalHold

        /// <summary>
        /// Applies a Legal Hold configuration to the specified object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLegalHold service method.</param>
        /// 
        /// <returns>The response from the PutObjectLegalHold service method, as returned by S3.</returns>
        public virtual PutObjectLegalHoldResponse PutObjectLegalHold(PutObjectLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLegalHoldResponseUnmarshaller.Instance;

            return Invoke<PutObjectLegalHoldResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectLegalHold operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLegalHold operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutObjectLegalHold
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutObjectLegalHold(PutObjectLegalHoldRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLegalHoldResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutObjectLegalHold operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObjectLegalHold.</param>
        /// 
        /// <returns>Returns a  PutObjectLegalHoldResult from S3.</returns>
        public virtual PutObjectLegalHoldResponse EndPutObjectLegalHold(IAsyncResult asyncResult)
        {
            return EndInvoke<PutObjectLegalHoldResponse>(asyncResult);
        }

        #endregion
        
        #region  PutObjectLockConfiguration

        /// <summary>
        /// Places an Object Lock configuration on the specified bucket. The rule specified in
        /// the Object Lock configuration will be applied by default to every new object placed
        /// in the specified bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLockConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutObjectLockConfiguration service method, as returned by S3.</returns>
        public virtual PutObjectLockConfigurationResponse PutObjectLockConfiguration(PutObjectLockConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutObjectLockConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLockConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutObjectLockConfiguration
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutObjectLockConfiguration(PutObjectLockConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLockConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutObjectLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObjectLockConfiguration.</param>
        /// 
        /// <returns>Returns a  PutObjectLockConfigurationResult from S3.</returns>
        public virtual PutObjectLockConfigurationResponse EndPutObjectLockConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutObjectLockConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutObjectRetention

        /// <summary>
        /// Places an Object Retention configuration on an object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObjectRetention service method.</param>
        /// 
        /// <returns>The response from the PutObjectRetention service method, as returned by S3.</returns>
        public virtual PutObjectRetentionResponse PutObjectRetention(PutObjectRetentionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectRetentionResponseUnmarshaller.Instance;

            return Invoke<PutObjectRetentionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectRetention operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectRetention operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutObjectRetention
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutObjectRetention(PutObjectRetentionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectRetentionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutObjectRetention operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObjectRetention.</param>
        /// 
        /// <returns>Returns a  PutObjectRetentionResult from S3.</returns>
        public virtual PutObjectRetentionResponse EndPutObjectRetention(IAsyncResult asyncResult)
        {
            return EndInvoke<PutObjectRetentionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutObjectTagging

        /// <summary>
        /// Sets the supplied tag-set to an object that already exists in a bucket
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObjectTagging service method.</param>
        /// 
        /// <returns>The response from the PutObjectTagging service method, as returned by S3.</returns>
        public virtual PutObjectTaggingResponse PutObjectTagging(PutObjectTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<PutObjectTaggingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutObjectTagging
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutObjectTagging(PutObjectTaggingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectTaggingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObjectTagging.</param>
        /// 
        /// <returns>Returns a  PutObjectTaggingResult from S3.</returns>
        public virtual PutObjectTaggingResponse EndPutObjectTagging(IAsyncResult asyncResult)
        {
            return EndInvoke<PutObjectTaggingResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPublicAccessBlock

        /// <summary>
        /// Creates or modifies the <code>PublicAccessBlock</code> configuration for an Amazon
        /// S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the PutPublicAccessBlock service method, as returned by S3.</returns>
        public virtual PutPublicAccessBlockResponse PutPublicAccessBlock(PutPublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<PutPublicAccessBlockResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPublicAccessBlock
        ///         operation.</returns>
        public virtual IAsyncResult BeginPutPublicAccessBlock(PutPublicAccessBlockRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPublicAccessBlockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPublicAccessBlock.</param>
        /// 
        /// <returns>Returns a  PutPublicAccessBlockResult from S3.</returns>
        public virtual PutPublicAccessBlockResponse EndPutPublicAccessBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPublicAccessBlockResponse>(asyncResult);
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
        public virtual RestoreObjectResponse RestoreObject(string bucketName, string key)
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
        public virtual RestoreObjectResponse RestoreObject(string bucketName, string key, int days)
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
        public virtual RestoreObjectResponse RestoreObject(string bucketName, string key, string versionId)
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
        public virtual RestoreObjectResponse RestoreObject(string bucketName, string key, string versionId, int days)
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
        public virtual RestoreObjectResponse RestoreObject(RestoreObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return Invoke<RestoreObjectResponse>(request, options);
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
        public virtual IAsyncResult BeginRestoreObject(RestoreObjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreObject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreObject.</param>
        /// 
        /// <returns>Returns a  RestoreObjectResult from S3.</returns>
        public virtual RestoreObjectResponse EndRestoreObject(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreObjectResponse>(asyncResult);
        }

        #endregion
        
        #region  SelectObjectContent

        /// <summary>
        /// This operation filters the contents of an Amazon S3 object based on a simple Structured
        /// Query Language (SQL) statement. In the request, along with the SQL expression, you
        /// must also specify a data serialization format (JSON or CSV) of the object. Amazon
        /// S3 uses this to parse object data into records, and returns only records that match
        /// the specified SQL expression. You must also specify the data serialization format
        /// for the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SelectObjectContent service method.</param>
        /// 
        /// <returns>The response from the SelectObjectContent service method, as returned by S3.</returns>
        public virtual SelectObjectContentResponse SelectObjectContent(SelectObjectContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectObjectContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectObjectContentResponseUnmarshaller.Instance;

            return Invoke<SelectObjectContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SelectObjectContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SelectObjectContent operation on AmazonS3Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSelectObjectContent
        ///         operation.</returns>
        public virtual IAsyncResult BeginSelectObjectContent(SelectObjectContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectObjectContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectObjectContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SelectObjectContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSelectObjectContent.</param>
        /// 
        /// <returns>Returns a  SelectObjectContentResult from S3.</returns>
        public virtual SelectObjectContentResponse EndSelectObjectContent(IAsyncResult asyncResult)
        {
            return EndInvoke<SelectObjectContentResponse>(asyncResult);
        }

        #endregion
        
        #region  UploadPart

        /// <summary>
        /// Uploads a part in a multipart upload.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadPart service method.</param>
        /// 
        /// <returns>The response from the UploadPart service method, as returned by S3.</returns>
        public virtual UploadPartResponse UploadPart(UploadPartRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadPartResponseUnmarshaller.Instance;

            return Invoke<UploadPartResponse>(request, options);
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
        public virtual IAsyncResult BeginUploadPart(UploadPartRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadPartResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UploadPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadPart.</param>
        /// 
        /// <returns>Returns a  UploadPartResult from S3.</returns>
        public virtual UploadPartResponse EndUploadPart(IAsyncResult asyncResult)
        {
            return EndInvoke<UploadPartResponse>(asyncResult);
        }

        #endregion
        
    }
}