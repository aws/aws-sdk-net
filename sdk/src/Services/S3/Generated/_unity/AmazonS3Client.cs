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
        /// Return the notification configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketNotificationRequest used to execute the GetBucketNotification service method.</param>
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
        
    }
}