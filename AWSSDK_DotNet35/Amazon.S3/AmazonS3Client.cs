/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using System.Collections.Generic;
using Amazon.S3.Util;


namespace Amazon.S3
{
    /// <summary>
    /// Implementation for accessing AmazonS3.
    ///  
    /// 
    /// </summary>
    public partial class AmazonS3Client : AmazonWebServiceClient, IAmazonS3
    {
        S3Signer signer = new S3Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion
        
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonS3Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonS3 Configuration Object</param>
        public AmazonS3Client(AmazonS3Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : this(credentials, new AmazonS3Config(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials and an
        /// AmazonS3Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AWSCredentials credentials, AmazonS3Config clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config(){RegionEndpoint = region})
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion
  
        #region GetCORSConfiguration

        /// <summary>
        /// <para>Returns the cors configuration for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getCORSConfigurationRequest">Container for the necessary parameters to execute the GetCORSConfiguration service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by AmazonS3.</returns>
        /// 
        public GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest getCORSConfigurationRequest)
        {
            IAsyncResult asyncResult = invokeGetCORSConfiguration(getCORSConfigurationRequest, null, null, true);
            return EndGetCORSConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="getCORSConfigurationRequest">Container for the necessary parameters to execute the GetCORSConfiguration operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCORSConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginGetCORSConfiguration(GetCORSConfigurationRequest getCORSConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokeGetCORSConfiguration(getCORSConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCORSConfiguration.</param>
        /// 
        /// <returns>Returns a GetCORSConfigurationResult from AmazonS3.</returns>
        public GetCORSConfigurationResponse EndGetCORSConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<GetCORSConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeGetCORSConfiguration(GetCORSConfigurationRequest getCORSConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetCORSConfigurationRequestMarshaller().Marshall(getCORSConfigurationRequest);
            var unmarshaller = GetCORSConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetObjectTorrent

        /// <summary>
        /// <para>Return torrent files from a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getObjectTorrentRequest">Container for the necessary parameters to execute the GetObjectTorrent service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by AmazonS3.</returns>
        /// 
        public GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest getObjectTorrentRequest)
        {
            IAsyncResult asyncResult = invokeGetObjectTorrent(getObjectTorrentRequest, null, null, true);
            return EndGetObjectTorrent(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectTorrent"/>
        /// </summary>
        /// 
        /// <param name="getObjectTorrentRequest">Container for the necessary parameters to execute the GetObjectTorrent operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectTorrent
        ///         operation.</returns>
        public IAsyncResult BeginGetObjectTorrent(GetObjectTorrentRequest getObjectTorrentRequest, AsyncCallback callback, object state)
        {
            return invokeGetObjectTorrent(getObjectTorrentRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetObjectTorrent operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectTorrent"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectTorrent.</param>
        /// 
        /// <returns>Returns a GetObjectTorrentResult from AmazonS3.</returns>
        public GetObjectTorrentResponse EndGetObjectTorrent(IAsyncResult asyncResult)
        {
            return endOperation<GetObjectTorrentResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetObjectTorrent(GetObjectTorrentRequest getObjectTorrentRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetObjectTorrentRequestMarshaller().Marshall(getObjectTorrentRequest);
            var unmarshaller = GetObjectTorrentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutObject

        /// <summary>
        /// <para>Adds an object to a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putObjectRequest">Container for the necessary parameters to execute the PutObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by AmazonS3.</returns>
        /// 
        public PutObjectResponse PutObject(PutObjectRequest putObjectRequest)
        {
            IAsyncResult asyncResult = invokePutObject(putObjectRequest, null, null, true);
            return EndPutObject(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutObject"/>
        /// </summary>
        /// 
        /// <param name="putObjectRequest">Container for the necessary parameters to execute the PutObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutObject
        ///         operation.</returns>
        public IAsyncResult BeginPutObject(PutObjectRequest putObjectRequest, AsyncCallback callback, object state)
        {
            return invokePutObject(putObjectRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObject.</param>
        /// 
        /// <returns>Returns a PutObjectResult from AmazonS3.</returns>
        public PutObjectResponse EndPutObject(IAsyncResult asyncResult)
        {
            return endOperation<PutObjectResponse>(asyncResult);
        }
        
        IAsyncResult invokePutObject(PutObjectRequest putObjectRequest, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new PutObjectRequestMarshaller();
            var unmarshaller = PutObjectResponseUnmarshaller.GetInstance();
            var result = Invoke<IRequest, PutObjectRequest>(putObjectRequest, callback, state, synchronized, marshaller, unmarshaller, this.signer);
            return result;
        }
        
        

        #endregion

        #region PutLifecycleConfiguration

        /// <summary>
        /// <para>Sets lifecycle configuration for your bucket. If a lifecycle configuration exists, it replaces it.</para>
        /// </summary>
        /// 
        /// <param name="putLifecycleConfigurationRequest">Container for the necessary parameters to execute the PutLifecycleConfiguration service method on
        ///          AmazonS3.</param>
        /// 
        public PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest putLifecycleConfigurationRequest)
        {
            IAsyncResult asyncResult = invokePutLifecycleConfiguration(putLifecycleConfigurationRequest, null, null, true);
            return EndPutLifecycleConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="putLifecycleConfigurationRequest">Container for the necessary parameters to execute the PutLifecycleConfiguration operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutLifecycleConfiguration(PutLifecycleConfigurationRequest putLifecycleConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokePutLifecycleConfiguration(putLifecycleConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLifecycleConfiguration.</param>
        public PutLifecycleConfigurationResponse EndPutLifecycleConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<PutLifecycleConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokePutLifecycleConfiguration(PutLifecycleConfigurationRequest putLifecycleConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutLifecycleConfigurationRequestMarshaller().Marshall(putLifecycleConfigurationRequest);
            var unmarshaller = PutLifecycleConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion

        #region PutCORSConfiguration

        /// <summary>
        /// <para>Sets the cors configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putCORSConfigurationRequest">Container for the necessary parameters to execute the PutCORSConfiguration service method on AmazonS3.</param>
        /// 
        public PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest putCORSConfigurationRequest)
        {
            IAsyncResult asyncResult = invokePutCORSConfiguration(putCORSConfigurationRequest, null, null, true);
            return EndPutCORSConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="putCORSConfigurationRequest">Container for the necessary parameters to execute the PutCORSConfiguration operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutCORSConfiguration(PutCORSConfigurationRequest putCORSConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokePutCORSConfiguration(putCORSConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCORSConfiguration.</param>
        public PutCORSConfigurationResponse EndPutCORSConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<PutCORSConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokePutCORSConfiguration(PutCORSConfigurationRequest putCORSConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutCORSConfigurationRequestMarshaller().Marshall(putCORSConfigurationRequest);
            var unmarshaller = PutCORSConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutBucketTagging

        /// <summary>
        /// <para>Sets the tags for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketTaggingRequest">Container for the necessary parameters to execute the PutBucketTagging service method on
        ///          AmazonS3.</param>
        /// 
        public PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest putBucketTaggingRequest)
        {
            IAsyncResult asyncResult = invokePutBucketTagging(putBucketTaggingRequest, null, null, true);
            return EndPutBucketTagging(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="putBucketTaggingRequest">Container for the necessary parameters to execute the PutBucketTagging operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutBucketTagging(PutBucketTaggingRequest putBucketTaggingRequest, AsyncCallback callback, object state)
        {
            return invokePutBucketTagging(putBucketTaggingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketTagging.</param>
        public PutBucketTaggingResponse EndPutBucketTagging(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketTaggingResponse>(asyncResult);
        }
        
        IAsyncResult invokePutBucketTagging(PutBucketTaggingRequest putBucketTaggingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutBucketTaggingRequestMarshaller().Marshall(putBucketTaggingRequest);
            var unmarshaller = PutBucketTaggingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutBucket

        /// <summary>
        /// <para>Creates a new bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketRequest">Container for the necessary parameters to execute the PutBucket service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by AmazonS3.</returns>
        /// 
        public PutBucketResponse PutBucket(PutBucketRequest putBucketRequest)
        {
            IAsyncResult asyncResult = invokePutBucket(putBucketRequest, null, null, true);
            return EndPutBucket(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucket"/>
        /// </summary>
        /// 
        /// <param name="putBucketRequest">Container for the necessary parameters to execute the PutBucket operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucket
        ///         operation.</returns>
        public IAsyncResult BeginPutBucket(PutBucketRequest putBucketRequest, AsyncCallback callback, object state)
        {
            return invokePutBucket(putBucketRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucket"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucket.</param>
        /// 
        /// <returns>Returns a PutBucketResult from AmazonS3.</returns>
        public PutBucketResponse EndPutBucket(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketResponse>(asyncResult);
        }
        
        IAsyncResult invokePutBucket(PutBucketRequest putBucketRequest, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new PutBucketRequestMarshaller();
            var unmarshaller = PutBucketResponseUnmarshaller.GetInstance();
            var result = Invoke(putBucketRequest, callback, state, synchronized, marshaller, unmarshaller, this.signer);
            return result;
        }
        
        

        #endregion

        #region ListVersions

        /// <summary>
        /// <para>Returns metadata about all of the versions of objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="listVersionsRequest">Container for the necessary parameters to execute the ListVersions service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by AmazonS3.</returns>
        /// 
        public ListVersionsResponse ListVersions(ListVersionsRequest listVersionsRequest)
        {
            IAsyncResult asyncResult = invokeListVersions(listVersionsRequest, null, null, true);
            return EndListVersions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListVersions"/>
        /// </summary>
        /// 
        /// <param name="listVersionsRequest">Container for the necessary parameters to execute the ListVersions operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListVersions operation.</returns>
        public IAsyncResult BeginListVersions(ListVersionsRequest listVersionsRequest, AsyncCallback callback, object state)
        {
            return invokeListVersions(listVersionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListVersions operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListVersions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// 
        /// <returns>Returns a ListVersionsResult from AmazonS3.</returns>
        public ListVersionsResponse EndListVersions(IAsyncResult asyncResult)
        {
            return endOperation<ListVersionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListVersions(ListVersionsRequest listVersionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListVersionsRequestMarshaller().Marshall(listVersionsRequest);
            var unmarshaller = ListVersionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteObjects

        /// <summary>
        /// <para>This operation enables you to delete multiple objects from a bucket using a single HTTP request. You may specify up to 1000
        /// keys.</para>
        /// </summary>
        /// 
        /// <param name="deleteObjectsRequest">Container for the necessary parameters to execute the DeleteObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObjects service method, as returned by AmazonS3.</returns>
        /// 
        public DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest deleteObjectsRequest)
        {
            IAsyncResult asyncResult = invokeDeleteObjects(deleteObjectsRequest, null, null, true);
            return EndDeleteObjects(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObjects"/>
        /// </summary>
        /// 
        /// <param name="deleteObjectsRequest">Container for the necessary parameters to execute the DeleteObjects operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObjects
        ///         operation.</returns>
        public IAsyncResult BeginDeleteObjects(DeleteObjectsRequest deleteObjectsRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteObjects(deleteObjectsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObjects"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObjects.</param>
        /// 
        /// <returns>Returns a DeleteObjectsResult from AmazonS3.</returns>
        public DeleteObjectsResponse EndDeleteObjects(IAsyncResult asyncResult)
        {
            return endOperation<DeleteObjectsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteObjects(DeleteObjectsRequest deleteObjectsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteObjectsRequestMarshaller().Marshall(deleteObjectsRequest);
            var unmarshaller = DeleteObjectsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetBucketTagging

        /// <summary>
        /// <para>Returns the tag set associated with the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketTaggingRequest">Container for the necessary parameters to execute the GetBucketTagging service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by AmazonS3.</returns>
        /// 
        public GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest getBucketTaggingRequest)
        {
            IAsyncResult asyncResult = invokeGetBucketTagging(getBucketTaggingRequest, null, null, true);
            return EndGetBucketTagging(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="getBucketTaggingRequest">Container for the necessary parameters to execute the GetBucketTagging operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketTagging
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketTagging(GetBucketTaggingRequest getBucketTaggingRequest, AsyncCallback callback, object state)
        {
            return invokeGetBucketTagging(getBucketTaggingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketTagging.</param>
        /// 
        /// <returns>Returns a GetBucketTaggingResult from AmazonS3.</returns>
        public GetBucketTaggingResponse EndGetBucketTagging(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketTaggingResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetBucketTagging(GetBucketTaggingRequest getBucketTaggingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetBucketTaggingRequestMarshaller().Marshall(getBucketTaggingRequest);
            var unmarshaller = GetBucketTaggingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetBucketLocation

        /// <summary>
        /// <para>Returns the region the bucket resides in.</para>
        /// </summary>
        /// 
        /// <param name="getBucketLocationRequest">Container for the necessary parameters to execute the GetBucketLocation service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by AmazonS3.</returns>
        /// 
        public GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest getBucketLocationRequest)
        {
            IAsyncResult asyncResult = invokeGetBucketLocation(getBucketLocationRequest, null, null, true);
            return EndGetBucketLocation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLocation"/>
        /// </summary>
        /// 
        /// <param name="getBucketLocationRequest">Container for the necessary parameters to execute the GetBucketLocation operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketLocation
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketLocation(GetBucketLocationRequest getBucketLocationRequest, AsyncCallback callback, object state)
        {
            return invokeGetBucketLocation(getBucketLocationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketLocation operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLocation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLocation.</param>
        /// 
        /// <returns>Returns a GetBucketLocationResult from AmazonS3.</returns>
        public GetBucketLocationResponse EndGetBucketLocation(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketLocationResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetBucketLocation(GetBucketLocationRequest getBucketLocationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetBucketLocationRequestMarshaller().Marshall(getBucketLocationRequest);
            var unmarshaller = GetBucketLocationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutBucketPolicy

        /// <summary>
        /// <para>Replaces a policy on a bucket. If the bucket already has a policy, the one in this request completely replaces it.</para>
        /// </summary>
        /// 
        /// <param name="putBucketPolicyRequest">Container for the necessary parameters to execute the PutBucketPolicy service method on
        ///          AmazonS3.</param>
        /// 
        public PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest putBucketPolicyRequest)
        {
            IAsyncResult asyncResult = invokePutBucketPolicy(putBucketPolicyRequest, null, null, true);
            return EndPutBucketPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="putBucketPolicyRequest">Container for the necessary parameters to execute the PutBucketPolicy operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutBucketPolicy(PutBucketPolicyRequest putBucketPolicyRequest, AsyncCallback callback, object state)
        {
            return invokePutBucketPolicy(putBucketPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketPolicy.</param>
        public PutBucketPolicyResponse EndPutBucketPolicy(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokePutBucketPolicy(PutBucketPolicyRequest putBucketPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutBucketPolicyRequestMarshaller().Marshall(putBucketPolicyRequest);
            var unmarshaller = PutBucketPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutBucketLogging

        /// <summary>
        /// <para>Set the logging parameters for a bucket and to specify permissions for who can view and modify the logging parameters. To set the
        /// logging status of a bucket, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="putBucketLoggingRequest">Container for the necessary parameters to execute the PutBucketLogging service method on
        ///          AmazonS3.</param>
        /// 
        public PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest putBucketLoggingRequest)
        {
            IAsyncResult asyncResult = invokePutBucketLogging(putBucketLoggingRequest, null, null, true);
            return EndPutBucketLogging(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="putBucketLoggingRequest">Container for the necessary parameters to execute the PutBucketLogging operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutBucketLogging(PutBucketLoggingRequest putBucketLoggingRequest, AsyncCallback callback, object state)
        {
            return invokePutBucketLogging(putBucketLoggingRequest, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketLogging.</param>
        public PutBucketLoggingResponse EndPutBucketLogging(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketLoggingResponse>(asyncResult);
        }
        
        IAsyncResult invokePutBucketLogging(PutBucketLoggingRequest putBucketLoggingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutBucketLoggingRequestMarshaller().Marshall(putBucketLoggingRequest);
            var unmarshaller = PutBucketLoggingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
    
        #region PutBucketNotification

        /// <summary>
        /// <para>Enables notifications of specified events for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketNotificationRequest">Container for the necessary parameters to execute the PutBucketNotification service method on
        ///          AmazonS3.</param>
        /// 
        public PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest putBucketNotificationRequest)
        {
            IAsyncResult asyncResult = invokePutBucketNotification(putBucketNotificationRequest, null, null, true);
            return EndPutBucketNotification(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="putBucketNotificationRequest">Container for the necessary parameters to execute the PutBucketNotification operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutBucketNotification(PutBucketNotificationRequest putBucketNotificationRequest, AsyncCallback callback, object state)
        {
            return invokePutBucketNotification(putBucketNotificationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketNotification.</param>
        public PutBucketNotificationResponse EndPutBucketNotification(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketNotificationResponse>(asyncResult);
        }
        
        IAsyncResult invokePutBucketNotification(PutBucketNotificationRequest putBucketNotificationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutBucketNotificationRequestMarshaller().Marshall(putBucketNotificationRequest);
            var unmarshaller = PutBucketNotificationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteBucket

        /// <summary>
        /// <para>Deletes the bucket. All objects (including all object versions and Delete Markers) in the bucket must be deleted before the bucket
        /// itself can be deleted.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketRequest">Container for the necessary parameters to execute the DeleteBucket service method on AmazonS3.</param>
        /// 
        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest deleteBucketRequest)
        {
            IAsyncResult asyncResult = invokeDeleteBucket(deleteBucketRequest, null, null, true);
            return EndDeleteBucket(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucket"/>
        /// </summary>
        /// 
        /// <param name="deleteBucketRequest">Container for the necessary parameters to execute the DeleteBucket operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteBucket(DeleteBucketRequest deleteBucketRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteBucket(deleteBucketRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucket"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucket.</param>
        public DeleteBucketResponse EndDeleteBucket(IAsyncResult asyncResult)
        {
            return endOperation<DeleteBucketResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteBucket(DeleteBucketRequest deleteBucketRequest, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteBucketRequestMarshaller();
            var unmarshaller = DeleteBucketResponseUnmarshaller.GetInstance();
            var result = Invoke(deleteBucketRequest, callback, state, synchronized, marshaller, unmarshaller, this.signer);
            return result;
        }
        
        

        #endregion
    
        #region ListMultipartUploads

        /// <summary>
        /// <para>This operation lists in-progress multipart uploads.</para>
        /// </summary>
        /// 
        /// <param name="listMultipartUploadsRequest">Container for the necessary parameters to execute the ListMultipartUploads service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by AmazonS3.</returns>
        /// 
        public ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest listMultipartUploadsRequest)
        {
            IAsyncResult asyncResult = invokeListMultipartUploads(listMultipartUploadsRequest, null, null, true);
            return EndListMultipartUploads(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListMultipartUploads"/>
        /// </summary>
        /// 
        /// <param name="listMultipartUploadsRequest">Container for the necessary parameters to execute the ListMultipartUploads operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListMultipartUploads operation.</returns>
        public IAsyncResult BeginListMultipartUploads(ListMultipartUploadsRequest listMultipartUploadsRequest, AsyncCallback callback, object state)
        {
            return invokeListMultipartUploads(listMultipartUploadsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListMultipartUploads"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultipartUploads.</param>
        /// 
        /// <returns>Returns a ListMultipartUploadsResult from AmazonS3.</returns>
        public ListMultipartUploadsResponse EndListMultipartUploads(IAsyncResult asyncResult)
        {
            return endOperation<ListMultipartUploadsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListMultipartUploads(ListMultipartUploadsRequest listMultipartUploadsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListMultipartUploadsRequestMarshaller().Marshall(listMultipartUploadsRequest);
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteBucketTagging

        /// <summary>
        /// <para>Deletes the tags from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketTaggingRequest">Container for the necessary parameters to execute the DeleteBucketTagging service method on
        ///          AmazonS3.</param>
        /// 
        public DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest deleteBucketTaggingRequest)
        {
            IAsyncResult asyncResult = invokeDeleteBucketTagging(deleteBucketTaggingRequest, null, null, true);
            return EndDeleteBucketTagging(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="deleteBucketTaggingRequest">Container for the necessary parameters to execute the DeleteBucketTagging operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteBucketTagging(DeleteBucketTaggingRequest deleteBucketTaggingRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteBucketTagging(deleteBucketTaggingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketTagging.</param>
        public DeleteBucketTaggingResponse EndDeleteBucketTagging(IAsyncResult asyncResult)
        {
            return endOperation<DeleteBucketTaggingResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteBucketTagging(DeleteBucketTaggingRequest deleteBucketTaggingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteBucketTaggingRequestMarshaller().Marshall(deleteBucketTaggingRequest);
            var unmarshaller = DeleteBucketTaggingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CompleteMultipartUpload

        /// <summary>
        /// <para>Completes a multipart upload by assembling previously uploaded parts.</para>
        /// </summary>
        /// 
        /// <param name="completeMultipartUploadRequest">Container for the necessary parameters to execute the CompleteMultipartUpload service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by AmazonS3.</returns>
        /// 
        public CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest completeMultipartUploadRequest)
        {
            IAsyncResult asyncResult = invokeCompleteMultipartUpload(completeMultipartUploadRequest, null, null, true);
            return EndCompleteMultipartUpload(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CompleteMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="completeMultipartUploadRequest">Container for the necessary parameters to execute the CompleteMultipartUpload operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCompleteMultipartUpload operation.</returns>
        public IAsyncResult BeginCompleteMultipartUpload(CompleteMultipartUploadRequest completeMultipartUploadRequest, AsyncCallback callback, object state)
        {
            return invokeCompleteMultipartUpload(completeMultipartUploadRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CompleteMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteMultipartUpload.</param>
        /// 
        /// <returns>Returns a CompleteMultipartUploadResult from AmazonS3.</returns>
        public CompleteMultipartUploadResponse EndCompleteMultipartUpload(IAsyncResult asyncResult)
        {
            return endOperation<CompleteMultipartUploadResponse>(asyncResult);
        }
        
        IAsyncResult invokeCompleteMultipartUpload(CompleteMultipartUploadRequest completeMultipartUploadRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CompleteMultipartUploadRequestMarshaller().Marshall(completeMultipartUploadRequest);
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion

        #region GetLifecycleConfiguration

        /// <summary>
        /// <para>Returns the lifecycle configuration information set on the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getLifecycleConfigurationRequest">Container for the necessary parameters to execute the GetLifecycleConfiguration service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by AmazonS3.</returns>
        /// 
        public GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest getLifecycleConfigurationRequest)
        {
            IAsyncResult asyncResult = invokeGetLifecycleConfiguration(getLifecycleConfigurationRequest, null, null, true);
            return EndGetLifecycleConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="getLifecycleConfigurationRequest">Container for the necessary parameters to execute the GetLifecycleConfiguration operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetLifecycleConfiguration operation.</returns>
        public IAsyncResult BeginGetLifecycleConfiguration(GetLifecycleConfigurationRequest getLifecycleConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokeGetLifecycleConfiguration(getLifecycleConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a GetLifecycleConfiguration from AmazonS3.</returns>
        public GetLifecycleConfigurationResponse EndGetLifecycleConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<GetLifecycleConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeGetLifecycleConfiguration(GetLifecycleConfigurationRequest getLifecycleConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetLifecycleConfigurationRequestMarshaller().Marshall(getLifecycleConfigurationRequest);
            var unmarshaller = GetLifecycleConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion

        #region GetACL

        /// <summary>
        /// <para>Returns the access control list (ACL) of an object.</para>
        /// </summary>
        /// 
        /// <param name="getACLRequest">Container for the necessary parameters to execute the GetACL service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by AmazonS3.</returns>
        /// 
        public GetACLResponse GetACL(GetACLRequest getACLRequest)
        {
            IAsyncResult asyncResult = invokeGetACL(getACLRequest, null, null, true);
            return EndGetACL(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetACL"/>
        /// </summary>
        /// 
        /// <param name="getACLRequest">Container for the necessary parameters to execute the GetACL operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetACL
        ///         operation.</returns>
        public IAsyncResult BeginGetACL(GetACLRequest getACLRequest, AsyncCallback callback, object state)
        {
            return invokeGetACL(getACLRequest, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetACL"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetACL.</param>
        /// 
        /// <returns>Returns a GetACLResponse from AmazonS3.</returns>
        public GetACLResponse EndGetACL(IAsyncResult asyncResult)
        {
            return endOperation<GetACLResponse>(asyncResult);
        }

        IAsyncResult invokeGetACL(GetACLRequest getACLRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetACLRequestMarshaller().Marshall(getACLRequest);
            var unmarshaller = GetACLResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
    
        #region CopyObject

        /// <summary>
        /// <para>Creates a copy of an object that is already stored in Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="copyObjectRequest">Container for the necessary parameters to execute the CopyObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by AmazonS3.</returns>
        /// 
        public CopyObjectResponse CopyObject(CopyObjectRequest copyObjectRequest)
        {
            IAsyncResult asyncResult = invokeCopyObject(copyObjectRequest, null, null, true);
            return EndCopyObject(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyObject"/>
        /// </summary>
        /// 
        /// <param name="copyObjectRequest">Container for the necessary parameters to execute the CopyObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyObject
        ///         operation.</returns>
        public IAsyncResult BeginCopyObject(CopyObjectRequest copyObjectRequest, AsyncCallback callback, object state)
        {
            return invokeCopyObject(copyObjectRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CopyObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyObject.</param>
        /// 
        /// <returns>Returns a CopyObjectResult from AmazonS3.</returns>
        public CopyObjectResponse EndCopyObject(IAsyncResult asyncResult)
        {
            return endOperation<CopyObjectResponse>(asyncResult);
        }
        
        IAsyncResult invokeCopyObject(CopyObjectRequest copyObjectRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CopyObjectRequestMarshaller().Marshall(copyObjectRequest);
            var unmarshaller = CopyObjectResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteBucketPolicy

        /// <summary>
        /// <para>Deletes the policy from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketPolicyRequest">Container for the necessary parameters to execute the DeleteBucketPolicy service method on
        ///          AmazonS3.</param>
        /// 
        public DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest deleteBucketPolicyRequest)
        {
            IAsyncResult asyncResult = invokeDeleteBucketPolicy(deleteBucketPolicyRequest, null, null, true);
            return EndDeleteBucketPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteBucketPolicyRequest">Container for the necessary parameters to execute the DeleteBucketPolicy operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteBucketPolicy(DeleteBucketPolicyRequest deleteBucketPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteBucketPolicy(deleteBucketPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketPolicy.</param>
        public DeleteBucketPolicyResponse EndDeleteBucketPolicy(IAsyncResult asyncResult)
        {
            return endOperation<DeleteBucketPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteBucketPolicy(DeleteBucketPolicyRequest deleteBucketPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteBucketPolicyRequestMarshaller().Marshall(deleteBucketPolicyRequest);
            var unmarshaller = DeleteBucketPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetObject

        /// <summary>
        /// <para>Retrieves objects from Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="getObjectRequest">Container for the necessary parameters to execute the GetObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by AmazonS3.</returns>
        /// 
        public GetObjectResponse GetObject(GetObjectRequest getObjectRequest)
        {
            IAsyncResult asyncResult = invokeGetObject(getObjectRequest, null, null, true);
            return EndGetObject(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObject"/>
        /// </summary>
        /// 
        /// <param name="getObjectRequest">Container for the necessary parameters to execute the GetObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObject
        ///         operation.</returns>
        public IAsyncResult BeginGetObject(GetObjectRequest getObjectRequest, AsyncCallback callback, object state)
        {
            return invokeGetObject(getObjectRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObject.</param>
        /// 
        /// <returns>Returns a GetObjectResult from AmazonS3.</returns>
        public GetObjectResponse EndGetObject(IAsyncResult asyncResult)
        {
            return endOperation<GetObjectResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetObject(GetObjectRequest getObjectRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetObjectRequestMarshaller().Marshall(getObjectRequest);
            var unmarshaller = GetObjectResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AbortMultipartUpload

        /// <summary>
        /// <para>Aborts a multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="abortMultipartUploadRequest">Container for the necessary parameters to execute the AbortMultipartUpload service method on
        ///          AmazonS3.</param>
        /// 
        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest abortMultipartUploadRequest)
        {
            IAsyncResult asyncResult = invokeAbortMultipartUpload(abortMultipartUploadRequest, null, null, true);
            return EndAbortMultipartUpload(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="abortMultipartUploadRequest">Container for the necessary parameters to execute the AbortMultipartUpload operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAbortMultipartUpload(AbortMultipartUploadRequest abortMultipartUploadRequest, AsyncCallback callback, object state)
        {
            return invokeAbortMultipartUpload(abortMultipartUploadRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortMultipartUpload.</param>
        public AbortMultipartUploadResponse EndAbortMultipartUpload(IAsyncResult asyncResult)
        {
            return endOperation<AbortMultipartUploadResponse>(asyncResult);
        }
        
        IAsyncResult invokeAbortMultipartUpload(AbortMultipartUploadRequest abortMultipartUploadRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AbortMultipartUploadRequestMarshaller().Marshall(abortMultipartUploadRequest);
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UploadPart

        /// <summary>
        /// <para>Uploads a part in a multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="uploadPartRequest">Container for the necessary parameters to execute the UploadPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the UploadPart service method, as returned by AmazonS3.</returns>
        /// 
        public UploadPartResponse UploadPart(UploadPartRequest uploadPartRequest)
        {
            IAsyncResult asyncResult = invokeUploadPart(uploadPartRequest, null, null, true);
            return EndUploadPart(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.UploadPart"/>
        /// </summary>
        /// 
        /// <param name="uploadPartRequest">Container for the necessary parameters to execute the UploadPart operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadPart
        ///         operation.</returns>
        public IAsyncResult BeginUploadPart(UploadPartRequest uploadPartRequest, AsyncCallback callback, object state)
        {
            return invokeUploadPart(uploadPartRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UploadPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.UploadPart"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadPart.</param>
        /// 
        /// <returns>Returns a UploadPartResult from AmazonS3.</returns>
        public UploadPartResponse EndUploadPart(IAsyncResult asyncResult)
        {
            return endOperation<UploadPartResponse>(asyncResult);
        }
        
        IAsyncResult invokeUploadPart(UploadPartRequest uploadPartRequest, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UploadPartRequestMarshaller();
            var unmarshaller = UploadPartResponseUnmarshaller.GetInstance();
            var result = Invoke<IRequest, UploadPartRequest>(uploadPartRequest, callback, state, synchronized, marshaller, unmarshaller, this.signer);
            return result;
        }
        
        

        #endregion
    
        #region RestoreObject

        /// <summary>
        /// <para>Restores an archived copy of an object back into Amazon S3</para>
        /// </summary>
        /// 
        /// <param name="restoreObjectRequest">Container for the necessary parameters to execute the RestoreObject service method on AmazonS3.</param>
        /// 
        public RestoreObjectResponse RestoreObject(RestoreObjectRequest restoreObjectRequest)
        {
            IAsyncResult asyncResult = invokeRestoreObject(restoreObjectRequest, null, null, true);
            return EndRestoreObject(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.RestoreObject"/>
        /// </summary>
        /// 
        /// <param name="restoreObjectRequest">Container for the necessary parameters to execute the RestoreObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRestoreObject(RestoreObjectRequest restoreObjectRequest, AsyncCallback callback, object state)
        {
            return invokeRestoreObject(restoreObjectRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RestoreObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.RestoreObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreObject.</param>
        public RestoreObjectResponse EndRestoreObject(IAsyncResult asyncResult)
        {
            return endOperation<RestoreObjectResponse>(asyncResult);
        }
        
        IAsyncResult invokeRestoreObject(RestoreObjectRequest restoreObjectRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RestoreObjectRequestMarshaller().Marshall(restoreObjectRequest);
            var unmarshaller = RestoreObjectResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetBucketPolicy

        /// <summary>
        /// <para>Returns the policy of a specified bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketPolicyRequest">Container for the necessary parameters to execute the GetBucketPolicy service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by AmazonS3.</returns>
        /// 
        public GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest getBucketPolicyRequest)
        {
            IAsyncResult asyncResult = invokeGetBucketPolicy(getBucketPolicyRequest, null, null, true);
            return EndGetBucketPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="getBucketPolicyRequest">Container for the necessary parameters to execute the GetBucketPolicy operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketPolicy
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketPolicy(GetBucketPolicyRequest getBucketPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeGetBucketPolicy(getBucketPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketPolicy.</param>
        /// 
        /// <returns>Returns a GetBucketPolicyResult from AmazonS3.</returns>
        public GetBucketPolicyResponse EndGetBucketPolicy(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetBucketPolicy(GetBucketPolicyRequest getBucketPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetBucketPolicyRequestMarshaller().Marshall(getBucketPolicyRequest);
            var unmarshaller = GetBucketPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetBucketLogging

        /// <summary>
        /// <para>Returns the logging status of a bucket and the permissions users have to view and modify that status. To use GET, you must be the
        /// bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="getBucketLoggingRequest">Container for the necessary parameters to execute the GetBucketLogging service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by AmazonS3.</returns>
        /// 
        public GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest getBucketLoggingRequest)
        {
            IAsyncResult asyncResult = invokeGetBucketLogging(getBucketLoggingRequest, null, null, true);
            return EndGetBucketLogging(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="getBucketLoggingRequest">Container for the necessary parameters to execute the GetBucketLogging operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketLogging
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketLogging(GetBucketLoggingRequest getBucketLoggingRequest, AsyncCallback callback, object state)
        {
            return invokeGetBucketLogging(getBucketLoggingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLogging.</param>
        /// 
        /// <returns>Returns a GetBucketLoggingResult from AmazonS3.</returns>
        public GetBucketLoggingResponse EndGetBucketLogging(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketLoggingResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetBucketLogging(GetBucketLoggingRequest getBucketLoggingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetBucketLoggingRequestMarshaller().Marshall(getBucketLoggingRequest);
            var unmarshaller = GetBucketLoggingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteObject

        /// <summary>
        /// <para>Removes the null version (if there is one) of an object and inserts a delete marker, which becomes the latest version of the object.
        /// If there isn''t a null version, Amazon S3 does not remove any objects.</para>
        /// </summary>
        /// 
        /// <param name="deleteObjectRequest">Container for the necessary parameters to execute the DeleteObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by AmazonS3.</returns>
        /// 
        public DeleteObjectResponse DeleteObject(DeleteObjectRequest deleteObjectRequest)
        {
            IAsyncResult asyncResult = invokeDeleteObject(deleteObjectRequest, null, null, true);
            return EndDeleteObject(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObject"/>
        /// </summary>
        /// 
        /// <param name="deleteObjectRequest">Container for the necessary parameters to execute the DeleteObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObject
        ///         operation.</returns>
        public IAsyncResult BeginDeleteObject(DeleteObjectRequest deleteObjectRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteObject(deleteObjectRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObject.</param>
        /// 
        /// <returns>Returns a DeleteObjectResult from AmazonS3.</returns>
        public DeleteObjectResponse EndDeleteObject(IAsyncResult asyncResult)
        {
            return endOperation<DeleteObjectResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteObject(DeleteObjectRequest deleteObjectRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteObjectRequestMarshaller().Marshall(deleteObjectRequest);
            var unmarshaller = DeleteObjectResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion

        #region InitiateMultipartUpload

        /// <summary>
        /// <para>Initiates a multipart upload and returns an upload ID.</para>
        /// </summary>
        /// 
        /// <param name="initiateMultipartUploadRequest">Container for the necessary parameters to execute the InitiateMultipartUpload service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by AmazonS3.</returns>
        /// 
        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest initiateMultipartUploadRequest)
        {
            IAsyncResult asyncResult = invokeInitiateMultipartUpload(initiateMultipartUploadRequest, null, null, true);
            return EndInitiateMultipartUpload(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.InitiateMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="initiateMultipartUploadRequest">Container for the necessary parameters to execute the InitiateMultipartUpload operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndInitiateMultipartUpload operation.</returns>
        public IAsyncResult BeginInitiateMultipartUpload(InitiateMultipartUploadRequest initiateMultipartUploadRequest, AsyncCallback callback, object state)
        {
            return invokeInitiateMultipartUpload(initiateMultipartUploadRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.InitiateMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateMultipartUpload.</param>
        /// 
        /// <returns>Returns a InitiateMultipartUploadResult from AmazonS3.</returns>
        public InitiateMultipartUploadResponse EndInitiateMultipartUpload(IAsyncResult asyncResult)
        {
            return endOperation<InitiateMultipartUploadResponse>(asyncResult);
        }

        IAsyncResult invokeInitiateMultipartUpload(InitiateMultipartUploadRequest initiateMultipartUploadRequest, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.GetInstance();
            var result = Invoke < IRequest, InitiateMultipartUploadRequest>(initiateMultipartUploadRequest, callback, state, synchronized, marshaller, unmarshaller, signer);
            return result;
        }
        
        

        #endregion

        #region DeleteCORSConfiguration

        /// <summary>
        /// <para>Deletes the cors configuration information set for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteCORSConfigurationRequest">Container for the necessary parameters to execute the DeleteCORSConfiguration service method on
        ///          AmazonS3.</param>
        /// 
        public DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest deleteCORSConfigurationRequest)
        {
            IAsyncResult asyncResult = invokeDeleteCORSConfiguration(deleteCORSConfigurationRequest, null, null, true);
            return EndDeleteCORSConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteCORSConfigurationRequest">Container for the necessary parameters to execute the DeleteCORSConfiguration operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteCORSConfiguration(DeleteCORSConfigurationRequest deleteCORSConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteCORSConfiguration(deleteCORSConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCORSConfiguration.</param>
        public DeleteCORSConfigurationResponse EndDeleteCORSConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<DeleteCORSConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteCORSConfiguration(DeleteCORSConfigurationRequest deleteCORSConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteCORSConfigurationRequestMarshaller().Marshall(deleteCORSConfigurationRequest);
            var unmarshaller = DeleteCORSConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion

        #region PutBucketVersioning

        /// <summary>
        /// <para>Puts the versioning state of an existing bucket. To set the versioning state, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="putBucketVersioningRequest">Container for the necessary parameters to execute the PutBucketVersioning service method on
        ///          AmazonS3.</param>
        /// 
        public PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest putBucketVersioningRequest)
        {
            IAsyncResult asyncResult = invokePutBucketVersioning(putBucketVersioningRequest, null, null, true);
            return EndPutBucketVersioning(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="putBucketVersioningRequest">Container for the necessary parameters to execute the PutBucketVersioning operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutBucketVersioning(PutBucketVersioningRequest putBucketVersioningRequest, AsyncCallback callback, object state)
        {
            return invokePutBucketVersioning(putBucketVersioningRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketVersioning.</param>
        public PutBucketVersioningResponse EndPutBucketVersioning(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketVersioningResponse>(asyncResult);
        }
        
        IAsyncResult invokePutBucketVersioning(PutBucketVersioningRequest putBucketVersioningRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutBucketVersioningRequestMarshaller().Marshall(putBucketVersioningRequest);
            var unmarshaller = PutBucketVersioningResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CopyPart

        /// <summary>
        /// <para>Uploads a part by copying data from an existing object as data source.</para>
        /// </summary>
        /// 
        /// <param name="copyPartRequest">Container for the necessary parameters to execute the CopyPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by AmazonS3.</returns>
        /// 
        public CopyPartResponse CopyPart(CopyPartRequest copyPartRequest)
        {
            IAsyncResult asyncResult = invokeCopyPart(copyPartRequest, null, null, true);
            return EndCopyPart(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyPart"/>
        /// </summary>
        /// 
        /// <param name="copyPartRequest">Container for the necessary parameters to execute the CopyPart operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyPart
        ///         operation.</returns>
        public IAsyncResult BeginCopyPart(CopyPartRequest copyPartRequest, AsyncCallback callback, object state)
        {
            return invokeCopyPart(copyPartRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CopyPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyPart"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyPart.</param>
        /// 
        /// <returns>Returns a CopyPartResult from AmazonS3.</returns>
        public CopyPartResponse EndCopyPart(IAsyncResult asyncResult)
        {
            return endOperation<CopyPartResponse>(asyncResult);
        }
        
        IAsyncResult invokeCopyPart(CopyPartRequest copyPartRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CopyPartRequestMarshaller().Marshall(copyPartRequest);
            var unmarshaller = CopyPartResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region HeadBucket

        /// <summary>
        /// <para>This operation is useful to determine if a bucket exists and you have permission to access it.</para>
        /// </summary>
        /// 
        /// <param name="headBucketRequest">Container for the necessary parameters to execute the HeadBucket service method on AmazonS3.</param>
        /// 
        internal HeadBucketResponse HeadBucket(HeadBucketRequest headBucketRequest)
        {
            IAsyncResult asyncResult = invokeHeadBucket(headBucketRequest, null, null, true);
            return EndHeadBucket(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the HeadBucket operation.
        /// </summary>
        /// 
        /// <param name="headBucketRequest">Container for the necessary parameters to execute the HeadBucket operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        internal IAsyncResult BeginHeadBucket(HeadBucketRequest headBucketRequest, AsyncCallback callback, object state)
        {
            return invokeHeadBucket(headBucketRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the HeadBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHeadBucket.</param>
        internal HeadBucketResponse EndHeadBucket(IAsyncResult asyncResult)
        {
            return endOperation<HeadBucketResponse>(asyncResult);
        }
        
        IAsyncResult invokeHeadBucket(HeadBucketRequest headBucketRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new HeadBucketRequestMarshaller().Marshall(headBucketRequest);
            var unmarshaller = HeadBucketResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutBucketWebsite

        /// <summary>
        /// <para>Set the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketWebsiteRequest">Container for the necessary parameters to execute the PutBucketWebsite service method on
        ///          AmazonS3.</param>
        /// 
        public PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest putBucketWebsiteRequest)
        {
            IAsyncResult asyncResult = invokePutBucketWebsite(putBucketWebsiteRequest, null, null, true);
            return EndPutBucketWebsite(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="putBucketWebsiteRequest">Container for the necessary parameters to execute the PutBucketWebsite operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutBucketWebsite(PutBucketWebsiteRequest putBucketWebsiteRequest, AsyncCallback callback, object state)
        {
            return invokePutBucketWebsite(putBucketWebsiteRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketWebsite.</param>
        public PutBucketWebsiteResponse EndPutBucketWebsite(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketWebsiteResponse>(asyncResult);
        }
        
        IAsyncResult invokePutBucketWebsite(PutBucketWebsiteRequest putBucketWebsiteRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutBucketWebsiteRequestMarshaller().Marshall(putBucketWebsiteRequest);
            var unmarshaller = PutBucketWebsiteResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion

        #region DeleteLifecycleConfiguration

        /// <summary>
        /// <para>Deletes the lifecycle configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteLifecycleConfigurationRequest">Container for the necessary parameters to execute the DeleteLifecycleConfiguration service method on
        ///          AmazonS3.</param>
        /// 
        public DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest deleteLifecycleConfigurationRequest)
        {
            IAsyncResult asyncResult = invokeDeleteLifecycleConfiguration(deleteLifecycleConfigurationRequest, null, null, true);
            return EndDeleteLifecycleConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteLifecycleConfigurationRequest">Container for the necessary parameters to execute the DeleteLifecycleConfiguration operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest deleteLifecycleConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteLifecycleConfiguration(deleteLifecycleConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecycleConfiguration.</param>
        public DeleteLifecycleConfigurationResponse EndDeleteLifecycleConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<DeleteLifecycleConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest deleteLifecycleConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLifecycleConfigurationRequestMarshaller().Marshall(deleteLifecycleConfigurationRequest);
            var unmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutBucketRequestPayment

        /// <summary>
        /// <para>Sets the request payment configuration for a bucket. By default, the bucket owner pays for downloads from the bucket. This
        /// configuration parameter enables the bucket owner (only) to specify that the person requesting the download will be charged for the
        /// download.</para>
        /// </summary>
        /// 
        /// <param name="putBucketRequestPaymentRequest">Container for the necessary parameters to execute the PutBucketRequestPayment service method on
        ///          AmazonS3.</param>
        /// 
        public PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest putBucketRequestPaymentRequest)
        {
            IAsyncResult asyncResult = invokePutBucketRequestPayment(putBucketRequestPaymentRequest, null, null, true);
            return EndPutBucketRequestPayment(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="putBucketRequestPaymentRequest">Container for the necessary parameters to execute the PutBucketRequestPayment operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutBucketRequestPayment(PutBucketRequestPaymentRequest putBucketRequestPaymentRequest, AsyncCallback callback, object state)
        {
            return invokePutBucketRequestPayment(putBucketRequestPaymentRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketRequestPayment.</param>
        public PutBucketRequestPaymentResponse EndPutBucketRequestPayment(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketRequestPaymentResponse>(asyncResult);
        }
        
        IAsyncResult invokePutBucketRequestPayment(PutBucketRequestPaymentRequest putBucketRequestPaymentRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutBucketRequestPaymentRequestMarshaller().Marshall(putBucketRequestPaymentRequest);
            var unmarshaller = PutBucketRequestPaymentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion

        #region PutACL

        /// <summary>
        /// <para>uses the acl subresource to set the access control list (ACL) permissions for an object that already exists in a bucket</para>
        /// </summary>
        /// 
        /// <param name="putACLRequest">Container for the necessary parameters to execute the PutObjectAcl service method on AmazonS3.</param>
        /// 
        public PutACLResponse PutACL(PutACLRequest putACLRequest)
        {
            IAsyncResult asyncResult = invokePutACL(putACLRequest, null, null, true);
            return EndPutACL(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutACL"/>
        /// </summary>
        /// 
        /// <param name="putACLRequest">Container for the necessary parameters to execute the PutACL operation on IAmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginPutACL(PutACLRequest putACLRequest, AsyncCallback callback, object state)
        {
            return invokePutACL(putACLRequest, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutACL"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutACL.</param>
        public PutACLResponse EndPutACL(IAsyncResult asyncResult)
        {
            return endOperation<PutACLResponse>(asyncResult);
        }

        IAsyncResult invokePutACL(PutACLRequest putACLRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutACLRequestMarshaller().Marshall(putACLRequest);
            var unmarshaller = PutACLResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
    
        #region GetBucketWebsite

        /// <summary>
        /// <para>Returns the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketWebsiteRequest">Container for the necessary parameters to execute the GetBucketWebsite service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by AmazonS3.</returns>
        /// 
        public GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest getBucketWebsiteRequest)
        {
            IAsyncResult asyncResult = invokeGetBucketWebsite(getBucketWebsiteRequest, null, null, true);
            return EndGetBucketWebsite(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="getBucketWebsiteRequest">Container for the necessary parameters to execute the GetBucketWebsite operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketWebsite
        ///         operation.</returns>
        public IAsyncResult BeginGetBucketWebsite(GetBucketWebsiteRequest getBucketWebsiteRequest, AsyncCallback callback, object state)
        {
            return invokeGetBucketWebsite(getBucketWebsiteRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketWebsite.</param>
        /// 
        /// <returns>Returns a GetBucketWebsiteResult from AmazonS3.</returns>
        public GetBucketWebsiteResponse EndGetBucketWebsite(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketWebsiteResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetBucketWebsite(GetBucketWebsiteRequest getBucketWebsiteRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetBucketWebsiteRequestMarshaller().Marshall(getBucketWebsiteRequest);
            var unmarshaller = GetBucketWebsiteResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteBucketWebsite

        /// <summary>
        /// <para>This operation removes the website configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketWebsiteRequest">Container for the necessary parameters to execute the DeleteBucketWebsite service method on
        ///          AmazonS3.</param>
        /// 
        public DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest deleteBucketWebsiteRequest)
        {
            IAsyncResult asyncResult = invokeDeleteBucketWebsite(deleteBucketWebsiteRequest, null, null, true);
            return EndDeleteBucketWebsite(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="deleteBucketWebsiteRequest">Container for the necessary parameters to execute the DeleteBucketWebsite operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteBucketWebsite(DeleteBucketWebsiteRequest deleteBucketWebsiteRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteBucketWebsite(deleteBucketWebsiteRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketWebsite.</param>
        public DeleteBucketWebsiteResponse EndDeleteBucketWebsite(IAsyncResult asyncResult)
        {
            return endOperation<DeleteBucketWebsiteResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteBucketWebsite(DeleteBucketWebsiteRequest deleteBucketWebsiteRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteBucketWebsiteRequestMarshaller().Marshall(deleteBucketWebsiteRequest);
            var unmarshaller = DeleteBucketWebsiteResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetBucketRequestPayment

        /// <summary>
        /// <para>Returns the request payment configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketRequestPaymentRequest">Container for the necessary parameters to execute the GetBucketRequestPayment service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by AmazonS3.</returns>
        /// 
        public GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest getBucketRequestPaymentRequest)
        {
            IAsyncResult asyncResult = invokeGetBucketRequestPayment(getBucketRequestPaymentRequest, null, null, true);
            return EndGetBucketRequestPayment(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="getBucketRequestPaymentRequest">Container for the necessary parameters to execute the GetBucketRequestPayment operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetBucketRequestPayment operation.</returns>
        public IAsyncResult BeginGetBucketRequestPayment(GetBucketRequestPaymentRequest getBucketRequestPaymentRequest, AsyncCallback callback, object state)
        {
            return invokeGetBucketRequestPayment(getBucketRequestPaymentRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketRequestPayment.</param>
        /// 
        /// <returns>Returns a GetBucketRequestPaymentResult from AmazonS3.</returns>
        public GetBucketRequestPaymentResponse EndGetBucketRequestPayment(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketRequestPaymentResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetBucketRequestPayment(GetBucketRequestPaymentRequest getBucketRequestPaymentRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetBucketRequestPaymentRequestMarshaller().Marshall(getBucketRequestPaymentRequest);
            var unmarshaller = GetBucketRequestPaymentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion

        #region GetObjectMetadata

        /// <summary>
        /// Returns information about a specified object.
        /// </summary>
        /// <remarks>
        /// Retrieves information about a specific object or object size, without actually fetching the object itself. 
        /// This is useful if you're only interested in the object metadata, and don't want to waste bandwidth on the object data.
        /// The response is identical to the GetObject response, except that there is no response body.
        /// </remarks>
        /// <param name="getObjectMetadataRequest">Container for the necessary parameters to execute the GetObjectMetadata service method on AmazonS3.</param>
        /// <returns>The response from the HeadObject service method, as returned by AmazonS3.</returns>
        public GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest getObjectMetadataRequest)
        {
            IAsyncResult asyncResult = invokeGetObjectMetadata(getObjectMetadataRequest, null, null, true);
            return EndGetObjectMetadata(asyncResult);
        }



        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectMetadata"/>
        /// </summary>
        /// 
        /// <param name="getObjectMetadataRequest">Container for the necessary parameters to execute the GetObjectMetadata operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectMetadata
        ///         operation.</returns>
        public IAsyncResult BeginGetObjectMetadata(GetObjectMetadataRequest getObjectMetadataRequest, AsyncCallback callback, object state)
        {
            return invokeGetObjectMetadata(getObjectMetadataRequest, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the GetObjectMetadata operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectMetadata"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectMetadata.</param>
        /// 
        /// <returns>Returns a HeadObjectResult from AmazonS3.</returns>
        public GetObjectMetadataResponse EndGetObjectMetadata(IAsyncResult asyncResult)
        {
            return endOperation<GetObjectMetadataResponse>(asyncResult);
        }

        IAsyncResult invokeGetObjectMetadata(GetObjectMetadataRequest getObjectMetadataRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetObjectMetadataRequestMarshaller().Marshall(getObjectMetadataRequest);
            var unmarshaller = GetObjectMetadataResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListObjects

        /// <summary>
        /// <para>Returns some or all (up to 1000) of the objects in a bucket. You can use the request parameters as selection criteria to return a
        /// subset of the objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="listObjectsRequest">Container for the necessary parameters to execute the ListObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by AmazonS3.</returns>
        /// 
        public ListObjectsResponse ListObjects(ListObjectsRequest listObjectsRequest)
        {
            IAsyncResult asyncResult = invokeListObjects(listObjectsRequest, null, null, true);
            return EndListObjects(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListObjects"/>
        /// </summary>
        /// 
        /// <param name="listObjectsRequest">Container for the necessary parameters to execute the ListObjects operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjects
        ///         operation.</returns>
        public IAsyncResult BeginListObjects(ListObjectsRequest listObjectsRequest, AsyncCallback callback, object state)
        {
            return invokeListObjects(listObjectsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListObjects"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjects.</param>
        /// 
        /// <returns>Returns a ListObjectsResult from AmazonS3.</returns>
        public ListObjectsResponse EndListObjects(IAsyncResult asyncResult)
        {
            return endOperation<ListObjectsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListObjects(ListObjectsRequest listObjectsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListObjectsRequestMarshaller().Marshall(listObjectsRequest);
            var unmarshaller = ListObjectsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetBucketNotification

        /// <summary>
        /// <para>Return the notification configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketNotificationRequest">Container for the necessary parameters to execute the GetBucketNotification service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by AmazonS3.</returns>
        /// 
        public GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest getBucketNotificationRequest)
        {
            IAsyncResult asyncResult = invokeGetBucketNotification(getBucketNotificationRequest, null, null, true);
            return EndGetBucketNotification(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="getBucketNotificationRequest">Container for the necessary parameters to execute the GetBucketNotification operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetBucketNotification operation.</returns>
        public IAsyncResult BeginGetBucketNotification(GetBucketNotificationRequest getBucketNotificationRequest, AsyncCallback callback, object state)
        {
            return invokeGetBucketNotification(getBucketNotificationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketNotification.</param>
        /// 
        /// <returns>Returns a GetBucketNotificationResult from AmazonS3.</returns>
        public GetBucketNotificationResponse EndGetBucketNotification(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketNotificationResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetBucketNotification(GetBucketNotificationRequest getBucketNotificationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetBucketNotificationRequestMarshaller().Marshall(getBucketNotificationRequest);
            var unmarshaller = GetBucketNotificationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetBucketVersioning

        /// <summary>
        /// <para>Returns the versioning state of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketVersioningRequest">Container for the necessary parameters to execute the GetBucketVersioning service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by AmazonS3.</returns>
        /// 
        public GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest getBucketVersioningRequest)
        {
            IAsyncResult asyncResult = invokeGetBucketVersioning(getBucketVersioningRequest, null, null, true);
            return EndGetBucketVersioning(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="getBucketVersioningRequest">Container for the necessary parameters to execute the GetBucketVersioning operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetBucketVersioning operation.</returns>
        public IAsyncResult BeginGetBucketVersioning(GetBucketVersioningRequest getBucketVersioningRequest, AsyncCallback callback, object state)
        {
            return invokeGetBucketVersioning(getBucketVersioningRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketVersioning.</param>
        /// 
        /// <returns>Returns a GetBucketVersioningResult from AmazonS3.</returns>
        public GetBucketVersioningResponse EndGetBucketVersioning(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketVersioningResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetBucketVersioning(GetBucketVersioningRequest getBucketVersioningRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetBucketVersioningRequestMarshaller().Marshall(getBucketVersioningRequest);
            var unmarshaller = GetBucketVersioningResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListBuckets

        /// <summary>
        /// <para>Returns a list of all buckets owned by the authenticated sender of the request.</para>
        /// </summary>
        /// 
        /// <param name="listBucketsRequest">Container for the necessary parameters to execute the ListBuckets service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by AmazonS3.</returns>
        /// 
        public ListBucketsResponse ListBuckets(ListBucketsRequest listBucketsRequest)
        {
            IAsyncResult asyncResult = invokeListBuckets(listBucketsRequest, null, null, true);
            return EndListBuckets(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListBuckets"/>
        /// </summary>
        /// 
        /// <param name="listBucketsRequest">Container for the necessary parameters to execute the ListBuckets operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuckets
        ///         operation.</returns>
        public IAsyncResult BeginListBuckets(ListBucketsRequest listBucketsRequest, AsyncCallback callback, object state)
        {
            return invokeListBuckets(listBucketsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListBuckets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuckets.</param>
        /// 
        /// <returns>Returns a ListBucketsResult from AmazonS3.</returns>
        public ListBucketsResponse EndListBuckets(IAsyncResult asyncResult)
        {
            return endOperation<ListBucketsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListBuckets(ListBucketsRequest listBucketsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListBucketsRequestMarshaller().Marshall(listBucketsRequest);
            var unmarshaller = ListBucketsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns a list of all buckets owned by the authenticated sender of the request.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by AmazonS3.</returns>
        /// 
        public ListBucketsResponse ListBuckets()
        {
            return ListBuckets(new ListBucketsRequest());
        }
        

        #endregion
    
        #region ListParts

        /// <summary>
        /// <para>Lists the parts that have been uploaded for a specific multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="listPartsRequest">Container for the necessary parameters to execute the ListParts service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by AmazonS3.</returns>
        /// 
        public ListPartsResponse ListParts(ListPartsRequest listPartsRequest)
        {
            IAsyncResult asyncResult = invokeListParts(listPartsRequest, null, null, true);
            return EndListParts(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListParts"/>
        /// </summary>
        /// 
        /// <param name="listPartsRequest">Container for the necessary parameters to execute the ListParts operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParts
        ///         operation.</returns>
        public IAsyncResult BeginListParts(ListPartsRequest listPartsRequest, AsyncCallback callback, object state)
        {
            return invokeListParts(listPartsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListParts operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListParts"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParts.</param>
        /// 
        /// <returns>Returns a ListPartsResult from AmazonS3.</returns>
        public ListPartsResponse EndListParts(IAsyncResult asyncResult)
        {
            return endOperation<ListPartsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListParts(ListPartsRequest listPartsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListPartsRequestMarshaller().Marshall(listPartsRequest);
            var unmarshaller = ListPartsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    }
}
    
