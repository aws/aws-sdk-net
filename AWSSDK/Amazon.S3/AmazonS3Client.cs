/* *****************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *  Author(s): Norm Johanson
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;


using Amazon.Util;
using Amazon.S3.Model;
using Amazon.S3.Util;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;

using Map = System.Collections.Generic.IDictionary<Amazon.S3.Model.S3QueryParameter, string>;
using System.Globalization;

namespace Amazon.S3
{
    public class AmazonS3Client : AmazonS3
    {
        #region Private Members

        private AmazonS3Config config;
        private bool disposed;
        private Type myType;
        private bool ownCredentials;
        private AWSCredentials credentials;

        #endregion

        static Logger LOGGER = Logger.GetLogger(typeof(AmazonS3Client));
        static MethodInfo ADD_RANGE_METHODINFO;

        #region Events

        internal event RequestEventHandler BeforeRequestEvent = delegate { };

        #endregion

        #region Dispose Pattern

        /// <summary>
        /// Implements the Dispose pattern for the AmazonS3Client
        /// </summary>
        /// <param name="fDisposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool fDisposing)
        {
            if (!this.disposed)
            {
                if (fDisposing && credentials != null)
                {
                    if (ownCredentials)
                    {
                        credentials.Dispose();
                    }
                    credentials = null;
                }
                if (fDisposing && LOGGER != null)
                {
                    LOGGER.Flush();
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~AmazonS3Client()
        {
            this.Dispose(false);
        }

        #endregion


        #region Constructors

        static AmazonS3Client()
        {
            Type t = typeof(HttpWebRequest);
            ADD_RANGE_METHODINFO = t.GetMethod("AddRange", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(string), typeof(string), typeof(string) }, null);
        }
        
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
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config(), true) { }

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
        /// <param name="config">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AmazonS3Config config)
            : this(FallbackCredentialsFactory.GetCredentials(), config, true) { }

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
        /// <param name="region">The region to connect to.</param>
        public AmazonS3Client(RegionEndpoint region)
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config() { RegionEndpoint = region }, true) { }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(CreateCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonS3Config(), true) { }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3 Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The S3 Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3Config config)
            : this(CreateCredentials(awsAccessKeyId, awsSecretAccessKey), config, true) { }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3 Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect to.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(CreateCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonS3Config() { RegionEndpoint = region }, true) { }

        /// <summary>
        /// Constructs an AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// Amazon S3 Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The S3 Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonS3Config config)
            : this(CreateCredentials(awsAccessKeyId, awsSecretAccessKey), config, true) { }

        /// <summary>
        /// Constructs an AmazonS3Client with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        public AmazonS3Client(AWSCredentials credentials)
            : this(credentials, new AmazonS3Config()) { }

        /// <summary>
        /// Constructs an AmazonS3Client with AWSCredentials and an
        /// Amazon S3 Configuration object
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="config"></param>
        public AmazonS3Client(AWSCredentials credentials, AmazonS3Config config)
            : this(credentials, config, false) { }

        /// <summary>
        /// Constructs an AmazonS3Client with AWSCredentials and an
        /// Amazon S3 Configuration object
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="region">The region to connect to.</param>
        public AmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3Config() { RegionEndpoint = region }, false) { }

        private AmazonS3Client(AWSCredentials credentials, AmazonS3Config config, bool ownCredentials)
        {
            this.config = config;
            this.myType = this.GetType();
            this.credentials = credentials;
            this.ownCredentials = ownCredentials;
        }

        #endregion

        #region GetPreSignedURL

        /// <summary>
        /// Create a signed URL allowing access to a resource that would 
        /// usually require authentication.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When using query string authentication you create a query,
        /// specify an expiration time for the query, sign it with your
        /// signature, place the data in an HTTP request, and distribute
        /// the request to a user or embed the request in a web page.
        /// </para>
        /// <para>
        /// A PreSigned URL can be generated for GET, PUT and HEAD
        /// operations on your bucket, keys, and versions.
        /// </para>
        /// </remarks>
        /// <param name="request">The GetPreSignedUrlRequest that defines the
        /// parameters of the operation.</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        public string GetPreSignedURL(GetPreSignedUrlRequest request)
        {
            if (credentials == null)
            {
                throw new AmazonS3Exception("Credentials must be specified, cannot call method anonymously");
            }

            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The PreSignedUrlRequest specified is null!");
            }

            if (!request.IsSetExpires())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Expires Specified is null!");
            }

            if (request.Verb > HttpVerb.PUT)
            {
                throw new ArgumentException(
                    "An Invalid HttpVerb was specified for the GetPreSignedURL request. Valid - GET, HEAD, PUT",
                    S3Constants.RequestParam
                    );
            }

            ConvertGetPreSignedUrl(request);
            return request.parameters[S3QueryParameter.Url];
        }

        #endregion

        #region ListBuckets

        /// <summary>
        /// Return a list of all of the buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse with the response from S3.</returns>
        public ListBucketsResponse ListBuckets()
        {
            return ListBuckets(new ListBucketsRequest());
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListBuckets"/>
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse with the response from S3.</returns>
        public IAsyncResult BeginListBuckets(AsyncCallback callback, object state)
        {
            return BeginListBuckets(new ListBucketsRequest(), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListBuckets"/>
        /// </summary>
        /// <param name="request">The ListBucketsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">
        /// A user-defined state object that is passed to the callback procedure. Retrieve this object from 
        /// within the callback procedure using the AsyncState property.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListBuckets.</returns>
        public IAsyncResult BeginListBuckets(ListBucketsRequest request, AsyncCallback callback, object state)
        {
            return invokeListBuckets(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListBuckets"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuckets.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse from S3.</returns>
        public ListBucketsResponse EndListBuckets(IAsyncResult asyncResult)
        {
            return endOperation<ListBucketsResponse>(asyncResult);
        }

        /// <summary>
        /// Return a list of all of the buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">The ListBucketsRequest that defines the parameters
        /// of this operation</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse with the response from S3.</returns>
        public ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            IAsyncResult asyncResult = invokeListBuckets(request, null, null, true);
            return EndListBuckets(asyncResult);
        }

        IAsyncResult invokeListBuckets(ListBucketsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The ListObjectsRequest is null!");
            }

            ConvertListBuckets(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<ListBucketsResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetBucketLocation

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketLocation"/>
        /// </summary>
        /// <param name="request">The GetBucketLocationRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketLocation.</returns>
        public IAsyncResult BeginGetBucketLocation(GetBucketLocationRequest request, AsyncCallback callback, object state)
        {
            return invokeGetBucketLocation(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketLocation operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketLocation"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLocation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLocationResponse from S3.</returns>
        public GetBucketLocationResponse EndGetBucketLocation(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketLocationResponse>(asyncResult);
        }

        /// <summary>
        /// Returns the location of a specified bucket. 
        /// </summary>
        /// <remarks>
        /// The information returned can be used to determine the bucket's geographical location.
        /// To determine the location of a bucket, you must be the bucket owner.
        /// </remarks>
        /// <param name="request">The GetBucketLocationRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLocationResponse from S3.</returns>
        public GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request)
        {
            IAsyncResult asyncResult = invokeGetBucketLocation(request, null, null, true);
            return EndGetBucketLocation(asyncResult);
        }

        IAsyncResult invokeGetBucketLocation(GetBucketLocationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetBucketLocationRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertGetBucketLocation(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetBucketLocationResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketLogging"/>
        /// </summary>
        /// <param name="request">The GetBucketLoggingRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketLogging.</returns>
        public IAsyncResult BeginGetBucketLogging(GetBucketLoggingRequest request, AsyncCallback callback, object state)
        {
            return invokeGetBucketLogging(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketLogging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLogging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLoggingResponse from S3.</returns>
        public GetBucketLoggingResponse EndGetBucketLogging(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketLoggingResponse>(asyncResult);
        }

        /// <summary>
        /// Gets the logging status for the specified bucket.
        /// </summary>
        /// <remarks>
        /// For more information about S3Bucket Logging see <see href="http://docs.amazonwebservices.com/AmazonS3/latest/ServerLogs.html" />
        /// </remarks>
        /// <param name="request">The GetBucketLoggingRequest that defines
        /// the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLoggingResponse from S3.</returns>
        public GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request)
        {
            IAsyncResult asyncResult = invokeGetBucketLogging(request, null, null, true);
            return EndGetBucketLogging(asyncResult);
        }

        IAsyncResult invokeGetBucketLogging(GetBucketLoggingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetBucketLoggingRequest specified is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertGetBucketLogging(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetBucketLoggingResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region EnableBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the EnableBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.EnableBucketLogging"/>
        /// </summary>
        /// <param name="request">The EnableBucketLoggingRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndEnableBucketLogging.</returns>
        public IAsyncResult BeginEnableBucketLogging(EnableBucketLoggingRequest request, AsyncCallback callback, object state)
        {
            return invokeEnableBucketLogging(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the EnableBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.EnableBucketLogging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableBucketLogging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a EnableBucketLoggingResponse from S3.</returns>
        public EnableBucketLoggingResponse EndEnableBucketLogging(IAsyncResult asyncResult)
        {
            return endOperation<EnableBucketLoggingResponse>(asyncResult);
        }

        /// <summary>
        /// Turn on bucket logging for a specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// An Amazon S3 bucket can be configured to create access log records for the
        /// requests made against it. An access log record contains details about the
        /// request such as the request type, the resource with which the request worked,
        /// and the time and date that the request was processed. Server access logs are
        /// useful for many applications, because they give bucket owners insight into
        /// the nature of requests made by clients not under their control.
        /// </para>
        /// <para>
        /// Changes to the logging status for a bucket are visible in the configuration API immediately,
        /// but they take time to actually affect the delivery of log files. For example, if you enable
        /// logging for a bucket, some requests made in the following hour might be logged, while others
        /// might not. Or, if you change the target bucket for logging from bucket A to bucket B, some
        /// logs for the next hour might continue to be delivered to bucket A, while others might be delivered
        /// to the new target bucket B. In all cases, the new settings will eventually take effect without any
        /// further action on your part.
        /// </para>
        /// </remarks>
        /// <param name="request">The EnableBucketLoggingRequest that defines the parameters of
        /// the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a EnableBucketLoggingResponse from S3.</returns>
        public EnableBucketLoggingResponse EnableBucketLogging(EnableBucketLoggingRequest request)
        {
            IAsyncResult asyncResult = invokeEnableBucketLogging(request, null, null, true);
            return EndEnableBucketLogging(asyncResult);
        }

        IAsyncResult invokeEnableBucketLogging(EnableBucketLoggingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The SetBucketLoggingRequest specified is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            S3BucketLoggingConfig config = request.LoggingConfig;
            if (config == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The LoggingConfig is null!");
            }

            if (!config.IsSetTargetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName of the LoggingConfig is null or empty!");
            }

            ConvertEnableBucketLogging(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<EnableBucketLoggingResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region DisableBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the DisableBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DisableBucketLogging"/>
        /// </summary>
        /// <param name="request">The DisableBucketLoggingRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDisableBucketLogging.</returns>
        public IAsyncResult BeginDisableBucketLogging(DisableBucketLoggingRequest request, AsyncCallback callback, object state)
        {
            return invokeDisableBucketLogging(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DisableBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DisableBucketLogging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableBucketLogging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DisableBucketLoggingResponse from S3.</returns>
        public DisableBucketLoggingResponse EndDisableBucketLogging(IAsyncResult asyncResult)
        {
            return endOperation<DisableBucketLoggingResponse>(asyncResult);
        }

        /// <summary>
        /// Turn off logging for a specified bucket.
        /// </summary>
        /// <remarks>
        /// An Amazon S3 bucket can be configured to create access log records for the
        /// requests made against it. An access log record contains details about the
        /// request such as the request type, the resource with which the request worked,
        /// and the time and date that the request was processed. Server access logs are
        /// useful for many applications, because they give bucket owners insight into
        /// the nature of requests made by clients not under their control.
        /// </remarks>
        /// <param name="request">
        /// The DisableBucketLoggingRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DisableBucketLoggingResponse from S3.</returns>
        public DisableBucketLoggingResponse DisableBucketLogging(DisableBucketLoggingRequest request)
        {
            IAsyncResult asyncResult = invokeDisableBucketLogging(request, null, null, true);
            return EndDisableBucketLogging(asyncResult);
        }

        IAsyncResult invokeDisableBucketLogging(DisableBucketLoggingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The SetBucketLoggingRequest specified is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertDisableBucketLogging(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, true);
            invoke<GetObjectResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetBucketVersioning

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketVersioning"/>
        /// </summary>
        /// <param name="request">The GetBucketVersioningRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketVersioning.</returns>
        public IAsyncResult BeginGetBucketVersioning(GetBucketVersioningRequest request, AsyncCallback callback, object state)
        {
            return invokeGetBucketVersioning(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketVersioning operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketVersioning"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketVersioning.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketVersioningResponse from S3.</returns>
        public GetBucketVersioningResponse EndGetBucketVersioning(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketVersioningResponse>(asyncResult);
        }

        /// <summary>
        /// Returns the versioning status of a bucket.
        /// </summary>
        /// <param name="request">The GetBucketVersioningRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketVersioningResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3BucketVersioningConfig"/>
        public GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request)
        {
            IAsyncResult asyncResult = invokeGetBucketVersioning(request, null, null, true);
            return EndGetBucketVersioning(asyncResult);
        }

        IAsyncResult invokeGetBucketVersioning(GetBucketVersioningRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetBucketVersioningRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertGetBucketVersioning(request);

            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetBucketVersioningResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region SetBucketVersioning

        /// <summary>
        /// Initiates the asynchronous execution of the SetBucketVersioning operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetBucketVersioning"/>
        /// </summary>
        /// <param name="request">The SetBucketVersioningRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndSetBucketVersioning.</returns>
        public IAsyncResult BeginSetBucketVersioning(SetBucketVersioningRequest request, AsyncCallback callback, object state)
        {
            return invokeSetBucketVersioning(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the SetBucketVersioning operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetBucketVersioning"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetBucketVersioning.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetBucketVersioningResponse from S3.</returns>
        public SetBucketVersioningResponse EndSetBucketVersioning(IAsyncResult asyncResult)
        {
            return endOperation<SetBucketVersioningResponse>(asyncResult);
        }

        /// <summary>
        /// Enable or suspend versioning on a bucket.
        /// </summary>
        /// <remarks>
        /// Once versioning has been "Enabled" on a bucket, it can be "Suspended" but cannot be switched "Off".
        /// </remarks>
        /// <param name="request">The SetBucketVersioningRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentException">
        /// If SetBucketVersioningRequest.VersioningStatus has the value S3BucketVersioningStatus.Off
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetBucketVersioningResponse from S3.</returns>
        public SetBucketVersioningResponse SetBucketVersioning(SetBucketVersioningRequest request)
        {
            IAsyncResult asyncResult = invokeSetBucketVersioning(request, null, null, true);
            return EndSetBucketVersioning(asyncResult);
        }

        IAsyncResult invokeSetBucketVersioning(SetBucketVersioningRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The SetBucketVersioningRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            if (!request.IsSetVersioningConfig())
            {
                throw new ArgumentException(
                    "Invalid Versioning Config specified",
                    S3Constants.RequestParam
                    );
            }

            // MFA requests must pass over HTTPS. Switch protocol
            // to HTTPS just for this call
            Protocol current = config.CommunicationProtocol;
            if (request.VersioningConfig.IsSetEnableMfaDelete())
            {
                if (!request.IsSetMfaCodes())
                {
                    throw new ArgumentNullException(
                        "request",
                        "MfaDelete has been enabled, but the Mfa Codes haven't been supplied in the request."
                        );
                }
                config.CommunicationProtocol = Protocol.HTTPS;
            }

            // Build out the request's parameters
            ConvertSetBucketVersioning(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<SetBucketVersioningResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetBucketPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketPolicy"/>
        /// </summary>
        /// <param name="request">The GetBucketPolicyRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketPolicy.</returns>
        public IAsyncResult BeginGetBucketPolicy(GetBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeGetBucketPolicy(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketPolicy"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketPolicy.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketPolicyResponse from S3.</returns>
        public GetBucketPolicyResponse EndGetBucketPolicy(IAsyncResult asyncResult)
        {
            try
            {
                return endOperation<GetBucketPolicyResponse>(asyncResult);
            }
            catch (AmazonS3Exception e)
            {
                if (e.ErrorCode == S3Constants.NoSuchBucketPolicy)
                {
                    return new GetBucketPolicyResponse();
                }

                throw;
            }
        }

        /// <summary>
        /// Retrieves the policy for a specified bucket. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// Only the owner of the bucket can retrieve the policy. If no policy has been set for the bucket,
        /// then an error will be thrown.
        /// </para>
        /// <para>
        /// Bucket policies provide access control management at the bucket level for
        /// both the bucket resource and contained object resources. Only one policy
        /// can be specified per-bucket.
        /// </para>
        /// <para>
        /// For more information on forming bucket polices, see: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The GetBucketPolicyRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetBucketPolicyResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetBucketPolicyRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertGetBucketPolicy(request);
            IAsyncResult asyncResult = invokeGetBucketPolicy(request, null, null, true);
            return EndGetBucketPolicy(asyncResult);
        }

        IAsyncResult invokeGetBucketPolicy(GetBucketPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetBucketPolicyRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertGetBucketPolicy(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetBucketPolicyResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region PutBucketPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketPolicy"/>
        /// </summary>
        /// <param name="request">The PutBucketPolicyRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutBucketPolicy.</returns>
        public IAsyncResult BeginPutBucketPolicy(PutBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokePutBucketPolicy(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketPolicy"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketPolicy.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketPolicyResponse from S3.</returns>
        public PutBucketPolicyResponse EndPutBucketPolicy(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketPolicyResponse>(asyncResult);
        }

        /// <summary>
        /// Set the policy associated with a specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sets the policy associated with the specified bucket. Only the owner of
        /// the bucket can set a bucket policy. If a policy already exists for the
        /// specified bucket, the new policy will replace the existing policy.
        /// </para>
        /// <para>
        /// Bucket policies provide access control management at the bucket level for
        /// both the bucket resource and contained object resources. Only one policy
        /// may be specified per-bucket.
        /// </para>
        /// <para>
        /// For more information on forming bucket polices, see: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The PutBucketPolicyRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a PutBucketPolicyResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
        {
            IAsyncResult asyncResult = invokePutBucketPolicy(request, null, null, true);
            return EndPutBucketPolicy(asyncResult);
        }

        IAsyncResult invokePutBucketPolicy(PutBucketPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The PutBucketPolicyRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            if (!request.IsSetPolicy())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The policy specified is null or empty!");
            }

            ConvertPutBucketPolicy(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<PutBucketPolicyResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region DeleteBucketPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketPolicy"/>
        /// </summary>
        /// <param name="request">The DeleteBucketPolicyRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteBucketPolicy.</returns>
        public IAsyncResult BeginDeleteBucketPolicy(DeleteBucketPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteBucketPolicy(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketPolicy"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketPolicy.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketPolicyResponse from S3.</returns>
        public DeleteBucketPolicyResponse EndDeleteBucketPolicy(IAsyncResult asyncResult)
        {
            return endOperation<DeleteBucketPolicyResponse>(asyncResult);
        }

        /// <summary>
        /// Deletes the policy associated with the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        ///  Only the owner of the bucket can delete the bucket policy. If you delete a policy that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </para>
        /// <para>
        /// Bucket policies provide access control management at the bucket level for
        /// both the bucket resource and contained object resources. Only one policy
        /// may be specified per-bucket.
        /// </para>
        /// <para>
        /// For more information on forming bucket polices, see: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The DeleteBucketPolicyRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a DeleteBucketPolicyResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteBucketPolicy(request, null, null, true);
            return EndDeleteBucketPolicy(asyncResult);
        }

        IAsyncResult invokeDeleteBucketPolicy(DeleteBucketPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The DeleteBucketPolicyRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertDeleteBucketPolicy(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<DeleteBucketPolicyResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region SetNotificationConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the SetNotificationConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetNotificationConfiguration"/>
        /// </summary>
        /// <param name="request">The SetNotificationConfigurationRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndSetNotificationConfiguration.</returns>
        public IAsyncResult BeginSetNotificationConfiguration(SetNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeSetNotificationConfiguration(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the SetNotificationConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetNotificationConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetNotificationConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetNotificationConfigurationResponse from S3.</returns>
        public SetNotificationConfigurationResponse EndSetNotificationConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<SetNotificationConfigurationResponse>(asyncResult);
        }

        /// <summary>
        /// Set or change the configuration of notifications for the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The notification configuration of a bucket provides near realtime notifications
        /// of events the user is interested in, using SNS as the delivery service.
        /// Notification is turned on by enabling configuration on a bucket, specifying
        /// the events and the SNS topic. This configuration can only be turned
        /// on by the bucket owner. If a notification configuration already exists for the
        /// specified bucket, the new notification configuration will replace the existing
        /// notification configuration.  To remove the notification configuration pass in
        /// an empty request.  Currently, buckets may only have a single event and topic
        /// configuration.
        /// </para>
        /// <para>
        /// S3 is eventually consistent. It may take time for the notification status
        /// of a bucket to be propagated throughout the system.
        /// </para>
        /// </remarks>
        /// <param name="request">The SetNotificationConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a SetNotificationConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public SetNotificationConfigurationResponse SetNotificationConfiguration(SetNotificationConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeSetNotificationConfiguration(request, null, null, true);
            return EndSetNotificationConfiguration(asyncResult);
        }

        IAsyncResult invokeSetNotificationConfiguration(SetNotificationConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The SetNotificationConfigurationRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }


            ConvertSetNotificationConfiguration(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<SetNotificationConfigurationResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetNotificationConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetNotificationConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetNotificationConfiguration"/>
        /// </summary>
        /// <param name="request">The GetNotificationConfigurationRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetNotificationConfiguration.</returns>
        public IAsyncResult BeginGetNotificationConfiguration(GetNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeGetNotificationConfiguration(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetNotificationConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetNotificationConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetNotificationConfigurationResponse from S3.</returns>
        public GetNotificationConfigurationResponse EndGetNotificationConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<GetNotificationConfigurationResponse>(asyncResult);
        }

        /// <summary>
        /// Retrieve the notification configuration for the specified bucket.
        /// </summary>
        /// <remarks>
        /// Only the owner of the bucket can retrieve the notification configuration.
        /// </remarks>
        /// <param name="request">The GetNotificationConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetNotificationConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public GetNotificationConfigurationResponse GetNotificationConfiguration(GetNotificationConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeGetNotificationConfiguration(request, null, null, true);
            return EndGetNotificationConfiguration(asyncResult);
        }

        IAsyncResult invokeGetNotificationConfiguration(GetNotificationConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetNotificationConfigurationRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }


            ConvertGetNotificationConfiguration(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetNotificationConfigurationResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region ListObjects

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListObjects"/>
        /// </summary>
        /// <param name="request">The ListObjectsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListObjects.</returns>
        public IAsyncResult BeginListObjects(ListObjectsRequest request, AsyncCallback callback, object state)
        {
            return invokeListObjects(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the ListObjects operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListObjects"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjects.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListObjectsResponse from S3.</returns>
        public ListObjectsResponse EndListObjects(IAsyncResult asyncResult)
        {
            return endOperation<ListObjectsResponse>(asyncResult);
        }

        /// <summary>
        /// Return the set of objects/keys in the specified bucket, ordered lexicographically (from a-Z).
        /// </summary>
        /// <remarks>
        /// <para>
        /// Since buckets can contain a virtually unlimited number of objects, the complete
        /// results of a list query can be extremely large. To manage large result sets,
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should
        /// always check the <see cref="P:Amazon.S3.Model.ListObjectsResponse.IsTruncated" />
        /// to see if the returned listing is complete, or if callers need to make additional 
        /// calls to get more results. The marker parameter allows callers to specify where to 
        /// start the object listing.
        /// </para>
        /// <para>
        /// List performance is not substantially affected by the total number of keys in your
        /// bucket, nor by the presence or absence of any additional query parameters.
        /// The list can be filtered via the Marker property of the ListObjectsRequest.
        /// </para>
        /// <para>
        /// In order to List Objects, you must have READ access to the bucket.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The ListObjectsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListObjectsResponse from S3 with a list of S3Objects,
        /// headers and request parameters used to filter the list.</returns>
        public ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            IAsyncResult asyncResult = invokeListObjects(request, null, null, true);
            return EndListObjects(asyncResult);
        }

        IAsyncResult invokeListObjects(ListObjectsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The ListObjectsRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertListObjects(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<ListObjectsResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region ListVersions

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListVersions"/>
        /// </summary>
        /// <param name="request">The ListVersionsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListVersions.</returns>
        public IAsyncResult BeginListVersions(ListVersionsRequest request, AsyncCallback callback, object state)
        {
            return invokeListVersions(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the ListVersions operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListVersions"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListVersionsResponse from S3.</returns>
        public ListVersionsResponse EndListVersions(IAsyncResult asyncResult)
        {
            return endOperation<ListVersionsResponse>(asyncResult);
        }

        /// <summary>
        /// Returns the set of versions of objects in the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Since buckets can contain a virtually unlimited number of objects, the complete
        /// results of a list query can be extremely large. To manage large result sets,
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should
        /// always check the <see cref="P:Amazon.S3.Model.ListVersionsResonse.IsTruncated" />
        /// to see if the returned listing
        /// is complete, or if callers need to make additional calls to get more results.
        /// The KeyMarker and VersionIdMarker parameters of the ListVersionsRequest object
        /// allow callers to specify where to start the version listing. In order to enable
        /// versioning on a bucket, please refer to the <see cref="M:Amazon.S3.AmazonS3Client.SetBucketVersioning">SetBucketVersioning</see>
        /// operation's details.
        /// </para>
        /// <para>
        /// List performance is not substantially affected by the total number of keys in your
        /// bucket, nor by the presence or absence of any additional query parameters.
        /// The ListVersions operation returns a list of object versions in the bucket
        /// specified ordered first by key and then by version. Keys are sorted lexicographically
        /// (i.e. alphabetically from a-Z); versions are sorted from most to least recent.
        /// Both versions with data and delete markers are included in the results.
        /// </para>
        /// <para>
        /// In order to List Versions, you must have READ access to the bucket.
        /// When the list is not filtered by a specific key, only the metadata
        /// associated with the latest version of objects in the bucket is returned.
        /// The use of KeyMarker and VersionIdMarker allow you to filter results.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The ListVersionsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListVersionsResponse from S3 that contains a list of
        /// versions along with metadata and the original request parameters.</returns>
        public ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            IAsyncResult asyncResult = invokeListVersions(request, null, null, true);
            return EndListVersions(asyncResult);
        }

        IAsyncResult invokeListVersions(ListVersionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The ListVersionsRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertListVersions(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<ListVersionsResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetACL

        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetACL"/>
        /// </summary>
        /// <param name="request">The GetACLRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetACL.</returns>
        public IAsyncResult BeginGetACL(GetACLRequest request, AsyncCallback callback, object state)
        {
            return invokeGetACL(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetACL operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetACL"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetACL.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetACLResponse from S3.</returns>
        public GetACLResponse EndGetACL(IAsyncResult asyncResult)
        {
            return endOperation<GetACLResponse>(asyncResult);
        }

        /// <summary>
        /// Returns the S3AccessControlList for the specified bucket or object.
        /// </summary>
        /// <remarks>
        /// Each bucket and object in Amazon S3 has an ACL that defines its access control
        /// policy, which is a list of grants. A grant consists of one grantee and one permission.
        /// ACLs only grant permissions; they do not deny them.
        /// </remarks>
        /// <param name="request">
        /// The GetACLRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetACLResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        public GetACLResponse GetACL(GetACLRequest request)
        {
            IAsyncResult asyncResult = invokeGetACL(request, null, null, true);
            return EndGetACL(asyncResult);
        }

        IAsyncResult invokeGetACL(GetACLRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetACLRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertGetACL(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetACLResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region SetACL

        /// <summary>
        /// Initiates the asynchronous execution of the SetACL operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetACL"/>
        /// </summary>
        /// <param name="request">The SetACLRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndSetACL.</returns>
        public IAsyncResult BeginSetACL(SetACLRequest request, AsyncCallback callback, object state)
        {
            return invokeSetACL(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the SetACL operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetACL"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetACL.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetACLResponse from S3.</returns>
        public SetACLResponse EndSetACL(IAsyncResult asyncResult)
        {
            return endOperation<SetACLResponse>(asyncResult);
        }

        /// <summary>
        /// Sets an S3AccessControlList on the specified bucket or object.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Each bucket and object in Amazon S3 has an ACL that defines its access control
        /// policy, which is a list of grants. A grant consists of one grantee and one permission.
        /// ACLs only grant permissions; they do not deny them.
        /// </para>
        /// <para>
        /// Often used ACLs are defined in the S3CannedACL enumeration.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The SetACLRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetACLResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        public SetACLResponse SetACL(SetACLRequest request)
        {
            IAsyncResult asyncResult = invokeSetACL(request, null, null, true);
            return EndSetACL(asyncResult);
        }

        IAsyncResult invokeSetACL(SetACLRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The SetACLRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            if (!request.IsSetACL() &&
                !request.IsSetCannedACL())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "No ACL or CannedACL specified!");
            }

            if (request.IsSetACL() && request.ACL.Owner == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "No owner for the ACL specified!");
            }

            ConvertSetACL(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<SetACLResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region PutBucket

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucket"/>
        /// </summary>
        /// <param name="request">The PutBucketRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutBucket.</returns>
        public IAsyncResult BeginPutBucket(PutBucketRequest request, AsyncCallback callback, object state)
        {
            return invokePutBucket(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucket operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucket"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucket.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketResponse from S3.</returns>
        public PutBucketResponse EndPutBucket(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketResponse>(asyncResult);
        }

        /// <summary>
        /// Create a new S3 bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Depending on your latency and legal requirements, you can specify a location
        /// constraint that will affect where your data physically resides.
        /// Every object stored in Amazon S3 is contained in a bucket. Buckets
        /// partition the namespace of objects stored in Amazon S3 at the top level.
        /// Within a bucket, you can use any names for your objects, but bucket names
        /// must be unique across all of Amazon S3.
        /// </para>
        /// <para>
        /// Buckets are similar to Internet domain names. Just as Amazon is the only owner
        /// of the domain name Amazon.com, only one person or organization can own a bucket
        /// within Amazon S3. The similarities between buckets and domain names is not a
        /// coincidence - there is a direct mapping between Amazon S3 buckets and subdomains
        /// of s3.amazonaws.com. Objects stored in Amazon S3 are addressable using the REST API
        /// under the domain bucketname.s3.amazonaws.com. For example, the object homepage.html
        /// stored in the Amazon S3 bucket mybucket can be addressed as
        /// http://mybucket.s3.amazonaws.com/homepage.html.
        /// </para>
        /// <para>
        /// To conform with DNS requirements, the following constraints apply:
        /// <list type="bullet">
        /// <item>Bucket names should not contain underscores (_)</item>
        /// <item>Bucket names should be between 3 and 63 characters long</item>
        /// <item>Bucket names should not end with a dash</item>
        /// <item>Bucket names cannot contain two, adjacent periods</item>
        /// <item>Bucket names cannot contain dashes next to periods
        ///   (e.g., "my-.bucket.com" and "my.-bucket" are invalid)</item>
        /// <item>Bucket names cannot contain uppercase characters</item>
        /// </list>
        /// </para>
        /// <para>
        /// There is no limit to the number of objects that can be stored in a bucket and no
        /// variation in performance when using many buckets or just a few. You can store all
        /// of your objects in a single bucket or organize them across several buckets.
        /// </para>
        /// </remarks>
        /// <seealso cref="T:Amazon.S3.Model.S3Region"/>
        /// <param name="request">
        /// The PutBucketRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketResponse from S3.</returns>
        public PutBucketResponse PutBucket(PutBucketRequest request)
        {
            IAsyncResult asyncResult = invokePutBucket(request, null, null, true);
            return EndPutBucket(asyncResult);
        }

        IAsyncResult invokePutBucket(PutBucketRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The PutBucketRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertPutBucket(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<PutBucketResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region DeleteBucket

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucket"/>
        /// </summary>
        /// <param name="request">The DeleteBucketRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteBucket.</returns>
        public IAsyncResult BeginDeleteBucket(DeleteBucketRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteBucket(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucket operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucket"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucket.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketResponse from S3.</returns>
        public DeleteBucketResponse EndDeleteBucket(IAsyncResult asyncResult)
        {
            return endOperation<DeleteBucketResponse>(asyncResult);
        }

        /// <summary>
        /// Deletes an S3 bucket.
        /// </summary>
        /// <remarks>
        /// All objects in the bucket must be deleted before the bucket itself can be deleted.
        /// Only the owner of a bucket can delete it, regardless of the bucket's access control policy.
        /// </remarks>
        /// <param name="request">
        /// The DeleteBucketRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketResponse from S3.</returns>
        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteBucket(request, null, null, true);
            return EndDeleteBucket(asyncResult);
        }

        IAsyncResult invokeDeleteBucket(DeleteBucketRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The DeleteBucketRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertDeleteBucket(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<DeleteBucketResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetObject

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetObject"/>
        /// </summary>
        /// <param name="request">The GetObjectRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetObject.</returns>
        public IAsyncResult BeginGetObject(GetObjectRequest request, AsyncCallback callback, object state)
        {
            return invokeGetObject(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetObject"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectResponse from S3.</returns>
        public GetObjectResponse EndGetObject(IAsyncResult asyncResult)
        {
            GetObjectResponse response = endOperation<GetObjectResponse>(asyncResult);

            S3AsyncResult s3AsyncResult = asyncResult as S3AsyncResult;
            GetObjectRequest request = s3AsyncResult.S3Request as GetObjectRequest;
            response.BucketName = request.BucketName;
            response.Key = request.Key;

            return response;
        }

        /// <summary>
        /// Fetches the most recent version of an S3 object.
        /// </summary>
        /// <remarks>
        /// <para>
        /// You must have READ access to the object.
        /// </para>
        /// <para>
        /// If READ access is granted to an anonymous user, an object can be retrieved
        /// without an authorization header. Providing a version-id for the object will
        /// fetch the specific version from S3 instead of the most recent one.
        /// </para>
        /// <para>
        /// You should wrap the response you get from calling GetObject in a using clause.
        /// This ensures that all underlying IO resources allocated for the response
        /// are disposed once the response has been processed. This is one way to
        /// call GetObject:
        /// <code>
        /// using (GetObjectResponse response = s3Client.GetObject(request))
        /// {
        ///     ... Process the response:
        ///     Get the Stream, get the content-length, write contents to disk, etc
        /// }
        /// </code>
        /// To see what resources are cleaned up at the end of the using block, please
        /// see <see cref="M:Amazon.S3.Model.S3Response.Dispose"/>
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The GetObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectResponse from S3.</returns>
        public GetObjectResponse GetObject(GetObjectRequest request)
        {
            IAsyncResult asyncResult = invokeGetObject(request, null, null, true);
            GetObjectResponse response = EndGetObject(asyncResult);
            ((S3AsyncResult)asyncResult).FinalResponse = null;
            return response;
        }

        IAsyncResult invokeGetObject(GetObjectRequest request, AsyncCallback callback, object state, bool synchronzied)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetObjectRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Key Specified is null or empty!");
            }

            ConvertGetObject(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronzied);
            invoke<GetObjectResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetObjectMetadata

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetObjectMetadata"/>
        /// </summary>
        /// <param name="request">The GetObjectMetadataRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetObjectMetadata.</returns>
        public IAsyncResult BeginGetObjectMetadata(GetObjectMetadataRequest request, AsyncCallback callback, object state)
        {
            return invokeGetObjectMetadata(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetObjectMetadata operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetObjectMetadata"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectMetadata.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectMetadataResponse from S3.</returns>
        public GetObjectMetadataResponse EndGetObjectMetadata(IAsyncResult asyncResult)
        {
            return endOperation<GetObjectMetadataResponse>(asyncResult);
        }

        /// <summary>
        /// Returns information about a specified object.
        /// </summary>
        /// <remarks>
        /// Retrieves information about a specific object or object size, without actually fetching the object itself. 
        /// This is useful if you're only interested in the object metadata, and don't want to waste bandwidth on the object data.
        /// The response is identical to the GetObject response, except that there is no response body.
        /// </remarks>
        /// <param name="request">
        /// The GetObjectMetadataRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectMetadataResponse from S3.</returns>
        public GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
        {
            IAsyncResult asyncResult = invokeGetObjectMetadata(request, null, null, true);
            return EndGetObjectMetadata(asyncResult);
        }

        IAsyncResult invokeGetObjectMetadata(GetObjectMetadataRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetObjectMetadataRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Key Specified is null or empty!");
            }

            ConvertGetObjectMetadata(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetObjectMetadataResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region PutObject

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutObject"/>
        /// </summary>
        /// <param name="request">The PutObjectRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutObject.</returns>
        public IAsyncResult BeginPutObject(PutObjectRequest request, AsyncCallback callback, object state)
        {
            return invokePutObject(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutObject"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutObjectResponse from S3.</returns>
        public PutObjectResponse EndPutObject(IAsyncResult asyncResult)
        {
            // from the checks made, it is guaranteed that if a filename is not specified
            // and the flow of execution gets this far, there has to be either an InputStream
            // or a ContentBody with a Key
            try
            {
                PutObjectResponse response = endOperation<PutObjectResponse>(asyncResult);
                return response;
            }
            finally
            {
                try
                {
                    S3AsyncResult s3AsyncResult = asyncResult as S3AsyncResult;
                    PutObjectRequest request = s3AsyncResult.S3Request as PutObjectRequest;
                    if (request.InputStream != null && (request.IsSetFilePath() || request.AutoCloseStream))
                    {
                        request.InputStream.Close();
                    }
                }
                catch (Exception e)
                {
                    LOGGER.Error(e, "Error closing stream after PutObject.");
                }
            }
        }

        /// <summary>
        /// Adds an object to an S3 bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The response indicates that the object has been successfully stored.
        /// Amazon S3 never stores partial objects: if you receive a successful
        /// response, then you can be confident that the entire object was stored.
        /// </para>
        /// <para>
        /// To ensure data is not corrupted over the network, use the Content-MD5
        /// header. When you use the Content-MD5 header, Amazon S3 checks the object
        /// against the provided MD5 value. If they do not match, Amazon S3 returns an error.
        /// Additionally, you can calculate the MD5 while putting an object to
        /// Amazon S3 and compare the returned Etag to the calculated MD5 value.
        /// </para>
        /// <para>
        /// If an object already exists in a bucket, the new object will overwrite
        /// it because Amazon S3 stores the last write request. However, Amazon S3
        /// is a distributed system. If Amazon S3 receives multiple write requests
        /// for the same object nearly simultaneously, all of the objects might be
        /// stored, even though only one wins in the end. Amazon S3 does not provide
        /// object locking; if you need this, make sure to build it into your application
        /// layer.
        /// </para>
        /// <para>
        /// If you specify a location constraint when creating a bucket, all objects
        /// added to the bucket are stored in the bucket's location.
        /// </para>
        /// <para>
        /// You must have WRITE access to the bucket to add an object.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The PutObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <exception cref="T:System.IO.FileNotFoundException"></exception>
        /// <returns>Returns a PutObjectResponse from S3.</returns>
        public PutObjectResponse PutObject(PutObjectRequest request)
        {
            IAsyncResult asyncResult;
            asyncResult = invokePutObject(request, null, null, true);
            return EndPutObject(asyncResult);
        }

        IAsyncResult invokePutObject(PutObjectRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The PutObjectRequest specified is null!");
            }

            // The BucketName and one of either the Key or the FilePath needs to be set
            if (!request.IsSetBucketName())
            {
                throw new ArgumentException("An S3 Bucket must be specified for S3 PUT object.");
            }

            if (!(request.IsSetKey() || request.IsSetFilePath()))
            {
                throw new ArgumentException(
                    "Either a Key or a Filename need to be specified for S3 PUT object.");
            }

            // Either:
            // 1. A file is being transferred - so a filename or a stream needs to be provided
            // 2. The content body needs to be set
            if (!request.IsSetWebsiteRedirectLocation() &&
                !request.IsSetFilePath() &&
                !request.IsSetInputStream() &&
                !request.IsSetContentBody())
            {
                throw new ArgumentException(
                    "Please specify either a Filename, provide a FileStream or provide a ContentBody to PUT an object into S3.");
            }

            if (request.IsSetInputStream() && request.IsSetContentBody())
            {
                throw new ArgumentException(
                    "Please specify one of either an Input FileStream or the ContentBody to be PUT as an S3 object.");
            }

            if (request.IsSetInputStream() && request.IsSetFilePath())
            {
                throw new ArgumentException(
                    "Please specify one of either an Input FileStream or a Filename to be PUT as an S3 object.");
            }

            if (request.IsSetFilePath() && request.IsSetContentBody())
            {
                throw new ArgumentException(
                    "Please specify one of either a Filename or the ContentBody to be PUT as an S3 object.");
            }

            if (request.IsSetFilePath())
            {
                // Create a stream from the filename specified
                if (File.Exists(request.FilePath))
                {
                    request.InputStream = new FileStream(request.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                }
                else
                {
                    throw new FileNotFoundException("The specified file does not exist");
                }

                if (!request.IsSetKey())
                {
                    string path = request.FilePath;
                    // Set the key to be the filename
                    request.Key = Path.GetFileName(path);
                }
            }

            ConvertPutObject(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<PutObjectResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region DeleteObject

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteObject"/>
        /// </summary>
        /// <param name="request">The DeleteObjectRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteObject.</returns>
        public IAsyncResult BeginDeleteObject(DeleteObjectRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteObject(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteObject"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteObjectResponse from S3.</returns>
        public DeleteObjectResponse EndDeleteObject(IAsyncResult asyncResult)
        {
            return endOperation<DeleteObjectResponse>(asyncResult);
        }

        /// <summary>
        /// Removes the specified object from Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The DeleteObject operation removes the specified object from Amazon S3.
        /// Once deleted, there is no method to restore or undelete an object.
        /// </para>
        /// <para>
        /// If you delete an object that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The DeleteObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteObjectResponse from S3.</returns>
        public DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteObject(request, null, null, true);
            return EndDeleteObject(asyncResult);
        }

        IAsyncResult invokeDeleteObject(DeleteObjectRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The DeleteObjectRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 Key Specified is null or empty!");
            }

            // MFA requests must pass over HTTPS. Switch protocol
            // to HTTPS just for this call
            Protocol current = config.CommunicationProtocol;
            if (request.IsSetMfaCodes())
            {
                config.CommunicationProtocol = Protocol.HTTPS;
            }

            ConvertDeleteObject(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<DeleteObjectResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region DeleteObjects

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteObjects"/>
        /// </summary>
        /// <param name="request">The DeleteObjectsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteObjects.</returns>
        public IAsyncResult BeginDeleteObjects(DeleteObjectsRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteObjects(request, callback, state, false);
        }

        /// <summary>
        /// <para>
        /// Finishes the asynchronous execution of the DeleteObjects operation.
        /// </para>
        /// <para>
        /// DeleteObjectsException will be thrown if any of the deletes fail.
        /// </para>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObjects.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <exception cref="T:Amazon.S3.Model.DeleteObjectsException">
        /// If any objects are not deleted during the operation.
        /// </exception>
        /// <returns>Returns a DeleteObjectsResponse from S3.</returns>
        public DeleteObjectsResponse EndDeleteObjects(IAsyncResult asyncResult)
        {
            DeleteObjectsErrorResponse response = endOperation<DeleteObjectsErrorResponse>(asyncResult);

            if (response != null && response.DeleteErrors != null && response.DeleteErrors.Count > 0)
            {
                throw new DeleteObjectsException(response);
            }

            return response;
        }

        /// <summary>
        /// Removes the specified objects from Amazon S3.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteObjects"/>
        /// </summary>
        /// <remarks>
        /// <para>
        /// The DeleteObjects operation removes the specified object from Amazon S3.
        /// Once deleted, there is no method to restore or undelete the objects.
        /// </para>
        /// <para>
        /// DeleteObjectsException will be thrown if any of the deletes fail.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The DeleteObjectsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <exception cref="T:Amazon.S3.Model.DeleteObjectsException">
        /// If any objects are not deleted during the operation.
        /// </exception>
        /// <returns>Returns a DeleteObjectsResponse from S3.</returns>
        public DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteObjects(request, null, null, true);
            return EndDeleteObjects(asyncResult);
        }

        IAsyncResult invokeDeleteObjects(DeleteObjectsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The DeleteObjectsRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }
            if (request.Keys == null || request.Keys.Count == 0)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "No S3 keys specified!");
            }

            ConvertDeleteObjects(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<DeleteObjectsErrorResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region CopyObject

        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.CopyObject"/>
        /// </summary>
        /// <param name="request">The CopyObjectRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndCopyObject.</returns>
        public IAsyncResult BeginCopyObject(CopyObjectRequest request, AsyncCallback callback, object state)
        {
            return invokeCopyObject(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the CopyObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.CopyObject"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CopyObjectResponse from S3.</returns>
        public CopyObjectResponse EndCopyObject(IAsyncResult asyncResult)
        {
            return endOperation<CopyObjectResponse>(asyncResult);
        }

        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When copying an object, you can preserve all metadata (default) or specify new metadata.
        /// However, the ACL is not preserved and is set to private for the user making the request.
        /// To override the default ACL setting, specify a new ACL when generating a copy request.
        /// </para>
        /// <para>
        /// If versioning has been enabled on the source bucket, and you want to copy a specific
        /// version of an object, please use
        /// <see cref="P:Amazon.S3.Model.CopyObjectRequest.SourceVersionId" /> to specify the
        /// version. By default, the most recent version of an object is copied to the
        /// destination bucket.
        /// </para>
        /// <para>
        /// If Versioning has been enabled on the target bucket, S3 generates a
        /// unique version ID for the object being copied. This version ID is different
        /// from the version ID of the source object. Additionally, S3 returns the version
        /// ID of the copied object in the x-amz-version-id response header in the response.
        /// If you do not enable Versioning or suspend it on the target bucket, the version ID
        /// S3 generates is always the string literal - "null".
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The CopyObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CopyObjectResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        public CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            IAsyncResult asyncResult = invokeCopyObject(request, null, null, true);
            return EndCopyObject(asyncResult);
        }

        IAsyncResult invokeCopyObject(CopyObjectRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The CopyObjectRequest specified is null!");
            }

            if (!request.IsSetDestinationBucket())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Destination S3Bucket must be specified!");
            }

            if (!request.IsSetSourceBucket())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Source S3Bucket must be specified!");
            }

            if (!request.IsSetSourceKey())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Source Key must be specified!");
            }

            ConvertCopyObject(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<CopyObjectResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region InitiateMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.InitiateMultipartUpload"/>
        /// </summary>
        /// <param name="request">The InitiateMultipartUploadRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndInitiateMultipartUpload.</returns>
        public IAsyncResult BeginInitiateMultipartUpload(InitiateMultipartUploadRequest request, AsyncCallback callback, object state)
        {
            return invokeInitiateMultipartUpload(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.InitiateMultipartUpload"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateMultipartUpload.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a InitiateMultipartUploadResponse from S3.</returns>
        public InitiateMultipartUploadResponse EndInitiateMultipartUpload(IAsyncResult asyncResult)
        {
            return endOperation<InitiateMultipartUploadResponse>(asyncResult);
        }

        /// <summary>
        /// Initiates a multipart upload and returns an InitiateMultipartUploadResponse which contains an upload ID.
        /// </summary>
        /// <remarks>
        /// The upload ID associates all the parts in the specific upload. You specify this upload ID in each of 
        /// your subsequent Upload Part requests. You also include this upload ID in the final request to either 
        /// complete, or abort the multipart upload request.
        /// </remarks>
        /// <param name="request">
        /// The CopyObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a InitiateMultipartUploadResponse from S3.</returns>
        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            IAsyncResult asyncResult = invokeInitiateMultipartUpload(request, null, null, true);
            return EndInitiateMultipartUpload(asyncResult);
        }

        IAsyncResult invokeInitiateMultipartUpload(InitiateMultipartUploadRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The InitiateMultipartUploadRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Key Specified is null or empty!");
            }

            ConvertInitiateMultipartUpload(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<InitiateMultipartUploadResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region UploadPart

        const string ORIGINAL_STREAM_PARAM = "ORIGINAL_STREAM_PARAM";
        const string FILE_STREAM_PARAM = "FILE_STREAM_PARAM";

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.UploadPart"/>
        /// </summary>
        /// <param name="request">The UploadPartRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndUploadPart.</returns>
        public IAsyncResult BeginUploadPart(UploadPartRequest request, AsyncCallback callback, object state)
        {
            return invokeUploadPart(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the UploadPart operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.UploadPart"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadPart.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a UploadPartResponse from S3.</returns>
        public UploadPartResponse EndUploadPart(IAsyncResult asyncResult)
        {
            S3AsyncResult s3AsyncResult = asyncResult as S3AsyncResult;
            if (s3AsyncResult == null)
                return null;

            Stream orignalStream = s3AsyncResult.Parameters[ORIGINAL_STREAM_PARAM] as Stream;
            Stream fileStream = s3AsyncResult.Parameters[FILE_STREAM_PARAM] as Stream;

            UploadPartRequest request = s3AsyncResult.S3Request as UploadPartRequest;
            try
            {
                UploadPartResponse response = endOperation<UploadPartResponse>(asyncResult);
                response.PartNumber = request.PartNumber;
                return response;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }

                request.InputStream = orignalStream;
            }
        }

        /// <summary>
        /// Uploads a single part in a multipart upload.  
        /// </summary>
        /// <remarks>
        /// <para>
        /// You must initiate a multipart upload before you can upload any part.
        /// </para>
        /// <para>
        /// Your UploadPart request must include an upload ID and a part number. 
        /// The upload ID is the ID returned by Amazon S3 in response to your 
        /// Initiate Multipart Upload request. Part number can be any number between 1 and
        /// 10,000, inclusive. A part number uniquely identifies a part and also 
        /// defines its position within the object being uploaded. If you 
        /// upload a new part using the same part number as an existing
        /// part, that part is overwritten.
        /// </para>
        /// <para>
        /// To ensure data is not corrupted traversing the network, specify the 
        /// Content-MD5 header in the Upload Part request. Amazon S3 checks 
        /// the part data against the provided MD5 value. If they do not match,
        /// Amazon S3 returns an error.
        /// </para>
        /// <para>
        /// When you upload a part, the UploadPartResponse response contains an ETag property.
        /// You should record this ETag property value and the part 
        /// number. After uploading all parts, you must send a CompleteMultipartUpload
        /// request. At that time Amazon S3 constructs a complete object by 
        /// concatenating all the parts you uploaded, in ascending order based on 
        /// the part numbers. The CompleteMultipartUpload request requires you to
        /// send all the part numbers and the corresponding ETag values.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The UploadPartRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a UploadPartResponse from S3.</returns>
        public UploadPartResponse UploadPart(UploadPartRequest request)
        {
            IAsyncResult asyncResult = invokeUploadPart(request, null, null, true);
            return EndUploadPart(asyncResult);
        }

        IAsyncResult invokeUploadPart(UploadPartRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The UploadPartUpload is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentException("The S3 BucketName specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentException("The Key Specified is null or empty!");
            }
            if (!request.IsSetUploadId())
            {
                throw new ArgumentException("The UploadId Specified is null or empty!");
            }
            if (!request.IsSetInputStream() && !request.IsSetFilePath())
            {
                throw new ArgumentException("Either InputStream or FilePath must be set.");
            }
            if (request.IsSetInputStream() && request.IsSetFilePath())
            {
                throw new ArgumentException("Both InputStream and FilePath can not be set.");
            }
            if (request.IsSetFilePath() && !request.IsSetFilePosition())
            {
                throw new ArgumentException("FilePosition is not set which is required when using FilePath.");
            }

            Stream fileStream = null;
            Stream orignalStream = request.InputStream;
            try
            {
                if (request.IsSetInputStream())
                {
                    request.InputStream = new PartStreamWrapper(request.InputStream, request.PartSize);
                }
                else
                {
                    fileStream = File.OpenRead(request.FilePath);
                    fileStream.Position = request.FilePosition;
                    request.InputStream = new PartStreamWrapper(fileStream, request.PartSize);
                }

                ConvertUploadPart(request);
                S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
                asyncResult.Parameters[ORIGINAL_STREAM_PARAM] = orignalStream;
                asyncResult.Parameters[FILE_STREAM_PARAM] = fileStream;
                invoke<UploadPartResponse>(asyncResult);
                return asyncResult;
            }
            catch
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
                request.InputStream = orignalStream;
                throw;
            }
        }


        #endregion

        #region CopyPart

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.UploadPart"/>
        /// </summary>
        /// <param name="request">The CopyPartRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndCopyPart.</returns>
        public IAsyncResult BeginCopyPart(CopyPartRequest request, AsyncCallback callback, object state)
        {
            return invokeCopyPart(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the CopyPart operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.UploadPart"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyPart.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CopyPartResponse from S3.</returns>
        public CopyPartResponse EndCopyPart(IAsyncResult asyncResult)
        {
            S3AsyncResult s3AsyncResult = asyncResult as S3AsyncResult;
            if (s3AsyncResult == null)
                return null;

            CopyPartRequest request = s3AsyncResult.S3Request as CopyPartRequest;
            CopyPartResponse response = endOperation<CopyPartResponse>(asyncResult);
            response.PartNumber = request.PartNumber;
            return response;
        }

        /// <summary>
        /// Creates a part in a multipart upload from an existing Amazon S3 Object.  
        /// </summary>
        /// <remarks>
        /// <para>
        /// You must initiate a multipart upload before you can copy a part.
        /// </para>
        /// <para>
        /// Your CopyPart request must include an upload ID and a part number. 
        /// The upload ID is the ID returned by Amazon S3 in response to your 
        /// Initiate Multipart Upload request. Part number can be any number between 1 and
        /// 10,000, inclusive. A part number uniquely identifies a part and also 
        /// defines its position within the object being uploaded. If you 
        /// copy a part using the same part number as an existing part, that part is overwritten.
        /// </para>
        /// <para>
        /// When you copy a part, the CopyPartResponse response contains an ETag property.
        /// You should record this ETag property value and the part 
        /// number. After uploading all parts, you must send a CompleteMultipartUpload
        /// request. At that time Amazon S3 constructs a complete object by 
        /// concatenating all the parts you uploaded, in ascending order based on 
        /// the part numbers. The CompleteMultipartUpload request requires you to
        /// send all the part numbers and the corresponding ETag values.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The CopyPartRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a CopyPartResponse from S3.</returns>
        public CopyPartResponse CopyPart(CopyPartRequest request)
        {
            IAsyncResult asyncResult = invokeCopyPart(request, null, null, true);
            return EndCopyPart(asyncResult);
        }

        IAsyncResult invokeCopyPart(CopyPartRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The CopyPartRequest is null!");
            }
            if (!request.IsSetSourceBucket())
            {
                throw new ArgumentException("The Source S3 BucketName specified is null or empty!");
            }
            if (!request.IsSetSourceKey())
            {
                throw new ArgumentException("The Source Key Specified is null or empty!");
            }
            if (!request.IsSetDestinationBucket())
            {
                throw new ArgumentException("The Destination S3 BucketName specified is null or empty!");
            }
            if (!request.IsSetDestinationKey())
            {
                throw new ArgumentException("The Destination Key Specified is null or empty!");
            }
            if (!request.IsSetUploadID())
            {
                throw new ArgumentException("The UploadId Specified is null or empty!");
            }
            if (!request.IsSetPartNumber())
            {
                throw new ArgumentException("The PartNumber Specified is null or empty!");
            }

            ConvertCopyPart(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<CopyPartResponse>(asyncResult);
            return asyncResult;
        }


        #endregion //CopyPart

        #region ListParts

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListParts"/>
        /// </summary>
        /// <param name="request">The ListPartsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListParts.</returns>
        public IAsyncResult BeginListParts(ListPartsRequest request, AsyncCallback callback, object state)
        {
            return invokeListParts(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the ListParts operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListParts"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParts.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListPartsResponse from S3.</returns>
        public ListPartsResponse EndListParts(IAsyncResult asyncResult)
        {
            return endOperation<ListPartsResponse>(asyncResult);
        }

        /// <summary>
        /// Lists the parts that have been uploaded for a particular multipart upload.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method must include the upload ID, returned by 
        /// the InitiateMultipartUpload request. This request 
        /// returns a maximum of 1000 uploaded parts by default. You can
        /// restrict the number of parts returned by specifying the 
        /// MaxParts property on the ListPartsRequest. 
        /// </para>
        /// <para>
        /// If your multipart upload consists of more parts than allowed in the 
        /// ListParts response, the response returns a IsTruncated
        /// field with value true, and a NextPartNumberMarker property. 
        /// In subsequent ListParts request you can include the 
        /// PartNumberMarker property and set its value to the
        /// NextPartNumberMarker property value from the previous response.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The ListPartsRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a ListPartsResponse from S3.</returns>
        public ListPartsResponse ListParts(ListPartsRequest request)
        {
            IAsyncResult asyncResult = invokeListParts(request, null, null, true);
            return EndListParts(asyncResult);
        }

        IAsyncResult invokeListParts(ListPartsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The ListPartsRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Key Specified is null or empty!");
            }
            if (!request.IsSetUploadId())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The UploadId Specified is null or empty!");
            }

            ConvertListParts(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<ListPartsResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region AbortMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <param name="request">The AbortMultipartUploadRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndAbortMultipartUpload.</returns>
        public IAsyncResult BeginAbortMultipartUpload(AbortMultipartUploadRequest request, AsyncCallback callback, object state)
        {
            return invokeAbortMultipartUpload(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortMultipartUpload.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a AbortMultipartUploadResponse from S3.</returns>
        public AbortMultipartUploadResponse EndAbortMultipartUpload(IAsyncResult asyncResult)
        {
            return endOperation<AbortMultipartUploadResponse>(asyncResult);
        }

        /// <summary>
        /// Aborts a multipart upload. 
        /// </summary>
        /// <remarks>
        /// After a multipart upload is aborted, no additional parts can be uploaded using 
        /// that upload ID. The storage consumed by any previously uploaded parts will be freed.
        /// However, if any part uploads are currently in progress, those part 
        /// uploads may or may not succeed. As a result, it may be necessary to 
        /// abort a given multipart upload multiple times in order to completely free
        /// all storage consumed by all parts.
        /// </remarks>
        /// <param name="request">
        /// The AbortMultipartUploadRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a AbortMultipartUploadResponse from S3.</returns>
        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            IAsyncResult asyncResult = invokeAbortMultipartUpload(request, null, null, true);
            return EndAbortMultipartUpload(asyncResult);
        }

        IAsyncResult invokeAbortMultipartUpload(AbortMultipartUploadRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The AbortMultipartUploadRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Key Specified is null or empty!");
            }
            if (!request.IsSetUploadId())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The UploadId Specified is null or empty!");
            }

            ConvertAbortMultipartUpload(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<AbortMultipartUploadResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region CompleteMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.CompleteMultipartUpload"/>
        /// </summary>
        /// <param name="request">The CompleteMultipartUploadRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndCompleteMultipartUpload.</returns>
        public IAsyncResult BeginCompleteMultipartUpload(CompleteMultipartUploadRequest request, AsyncCallback callback, object state)
        {
            return invokeCompleteMultipartUpload(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.CompleteMultipartUpload"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteMultipartUpload.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CompleteMultipartUploadResponse from S3.</returns>
        public CompleteMultipartUploadResponse EndCompleteMultipartUpload(IAsyncResult asyncResult)
        {
            return endOperation<CompleteMultipartUploadResponse>(asyncResult);
        }

        /// <summary>
        /// Completes a multipart upload by assembling previously uploaded parts.
        /// </summary>
        /// <remarks>
        /// <para>
        /// You first upload all parts using the UploadPart method. 
        /// After successfully uploading all relevant parts of an upload, 
        /// you call this operation to complete the upload. Upon receiving
        /// this request, Amazon S3 concatenates all the parts in ascending 
        /// order by part number to create a new object. In the 
        /// CompleteMultipartUpload request, you must provide the 
        /// parts list. For each part in the list, you provide the 
        /// part number and the ETag header value, returned after that 
        /// part was uploaded.
        /// </para>
        /// <para>
        /// Processing of a CompleteMultipartUpload request may take 
        /// several minutes to complete.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The CompleteMultipartUploadRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a CompleteMultipartUploadResponse from S3.</returns>
        public CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            IAsyncResult asyncResult = invokeCompleteMultipartUpload(request, null, null, true);
            return EndCompleteMultipartUpload(asyncResult);
        }

        IAsyncResult invokeCompleteMultipartUpload(CompleteMultipartUploadRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The CompleteMultipartUploadRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentException("The S3 BucketName specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentException("The Key Specified is null or empty!");
            }
            if (!request.IsSetUploadId())
            {
                throw new ArgumentException("The UploadId Specified is null or empty!");
            }
            if (request.PartETags.Count == 0)
            {
                throw new ArgumentException("No part etags were added to the request!");
            }

            ConvertCompleteMultipartUpload(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<CompleteMultipartUploadResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region ListMultipartUploads

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListMultipartUploads"/>
        /// </summary>
        /// <param name="request">The ListMultipartUploadsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListMultipartUploads.</returns>
        public IAsyncResult BeginListMultipartUploads(ListMultipartUploadsRequest request, AsyncCallback callback, object state)
        {
            return invokeListMultipartUploads(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListMultipartUploads"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultipartUploads.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListMultipartUploadsResponse from S3.</returns>
        public ListMultipartUploadsResponse EndListMultipartUploads(IAsyncResult asyncResult)
        {
            return endOperation<ListMultipartUploadsResponse>(asyncResult);
        }

        /// <summary>
        /// Lists in-progress multipart uploads.
        /// </summary>
        /// <remarks>
        /// <para>
        /// An in-progress multipart upload is a multipart upload that has been initiated, 
        /// using the InitiateMultipartUpload request, but has not yet been completed or 
        /// aborted.
        /// </para>
        /// <para>
        /// This operation returns at most 1,000 multipart uploads in the 
        /// response by default. The number of multipart uploads can be further 
        /// limited using the MaxUploads property on the request parameter. If there are 
        /// additional multipart uploads that satisfy the list criteria, the 
        /// response will contain an IsTruncated property with the value set to true.
        /// To list the additional multipart uploads use the KeyMarker and 
        /// UploadIdMarker properties on the request parameters.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The ListMultipartUploadsRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a ListMultipartUploadsResponse from S3.</returns>
        public ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            IAsyncResult asyncResult = invokeListMultipartUploads(request, null, null, true);
            return EndListMultipartUploads(asyncResult);
        }

        IAsyncResult invokeListMultipartUploads(ListMultipartUploadsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The ListMultipartUploadsRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentException("The S3 BucketName specified is null or empty!");
            }

            ConvertListMultipartUploads(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<ListMultipartUploadsResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region PutBucketWebsite

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketWebsite"/>
        /// </summary>
        /// <param name="request">The PutBucketWebsiteRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutBucketWebsite.</returns>
        public IAsyncResult BeginPutBucketWebsite(PutBucketWebsiteRequest request, AsyncCallback callback, object state)
        {
            return invokePutBucketWebsite(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketWebsite operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketWebsite"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketWebsite.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketWebsiteResponse from S3.</returns>
        public PutBucketWebsiteResponse EndPutBucketWebsite(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketWebsiteResponse>(asyncResult);
        }

        /// <summary>
        /// Enables or configures an S3-based website using the corresponding bucket as the content source. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// The website will have one default domain name associated with it, which is the bucket name.
        /// If you attempt to configure an S3 website for a bucket whose name is not compatible with DNS, 
        /// Amazon S3 returns an InvalidBucketName error. For more information on bucket names and DNS, 
        /// refer to Bucket Restrictions and Limitations.
        /// </para>
        /// <para>
        /// To visit the S3 bucket as a website a new endpoint is created in the following pattern 
        /// http://[bucketName].s3-website-[region].amazonaws.com/. This is a sample url for a bucket
        /// called example-bucket in the us-east-1 region. http://example-bucket.s3-website-us-east-1.amazonaws.com/
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The PutBucketWebsiteRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a PutBucketWebsiteResponse from S3.</returns>
        public PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request)
        {
            IAsyncResult asyncResult = invokePutBucketWebsite(request, null, null, true);
            return EndPutBucketWebsite(asyncResult);
        }

        IAsyncResult invokePutBucketWebsite(PutBucketWebsiteRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The PutBucketWebsiteRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentException("The S3 BucketName specified is null or empty!");
            }

            ConvertPutBucketWebsite(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<PutBucketWebsiteResponse>(asyncResult);
            return asyncResult;
        }

        void ConvertPutBucketWebsite(PutBucketWebsiteRequest request)
        {
            Map parameters = request.parameters;
            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "PutBucketWebsite";
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?website";

            parameters[S3QueryParameter.ContentBody] = request.WebsiteConfiguration.ToXML();
            parameters[S3QueryParameter.ContentType] = "application/xml";

            request.RequestDestinationBucket = request.BucketName;
        }

        #endregion

        #region GetBucketWebsite

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketWebsite"/>
        /// </summary>
        /// <param name="request">The GetBucketWebsiteRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketWebsite.</returns>
        public IAsyncResult BeginGetBucketWebsite(GetBucketWebsiteRequest request, AsyncCallback callback, object state)
        {
            return invokeGetBucketWebsite(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketWebsite operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketWebsite"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketWebsite.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketWebsiteResponse from S3.</returns>
        public GetBucketWebsiteResponse EndGetBucketWebsite(IAsyncResult asyncResult)
        {
            try
            {
                return endOperation<GetBucketWebsiteResponse>(asyncResult);
            }
            catch (AmazonS3Exception e)
            {
                if (e.ErrorCode == S3Constants.NoSuchWebsiteConfiguration)
                {
                    return new GetBucketWebsiteResponse();
                }

                throw;
            }
        }

        /// <summary>
        /// Retrieves the website configuration for a bucket.
        /// </summary>
        /// <remarks>
        /// The contents of this response is identical to the content submitted by the user during the PutBucketWebsite 
        /// operation if it has ever been configured. 
        /// </remarks>
        /// <param name="request">
        /// The GetBucketWebsiteRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a GetBucketWebsiteResponse from S3.</returns>
        public GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request)
        {
            IAsyncResult asyncResult = invokeGetBucketWebsite(request, null, null, true);
            return EndGetBucketWebsite(asyncResult);
        }

        IAsyncResult invokeGetBucketWebsite(GetBucketWebsiteRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetBucketWebsiteRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentException("The S3 BucketName specified is null or empty!");
            }

            ConvertGetBucketWebsite(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetBucketWebsiteResponse>(asyncResult);
            return asyncResult;
        }

        void ConvertGetBucketWebsite(GetBucketWebsiteRequest request)
        {
            Map parameters = request.parameters;
            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetBucketWebsite";
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?website";

            request.RequestDestinationBucket = request.BucketName;
        }

        #endregion

        #region DeleteBucketWebsite

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketWebsite"/>
        /// </summary>
        /// <param name="request">The DeleteBucketWebsiteRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteBucketWebsite.</returns>
        public IAsyncResult BeginDeleteBucketWebsite(DeleteBucketWebsiteRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteBucketWebsite(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketWebsite operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketWebsite"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketWebsite.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketWebsiteResponse from S3.</returns>
        public DeleteBucketWebsiteResponse EndDeleteBucketWebsite(IAsyncResult asyncResult)
        {
            return endOperation<DeleteBucketWebsiteResponse>(asyncResult);
        }

        /// <summary>
        /// Removes the website configuration for a bucket. 
        /// </summary>
        /// <param name="request">
        /// The DeleteBucketWebsiteRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a DeleteBucketWebsiteResponse from S3.</returns>
        public DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteBucketWebsite(request, null, null, true);
            return EndDeleteBucketWebsite(asyncResult);
        }

        IAsyncResult invokeDeleteBucketWebsite(DeleteBucketWebsiteRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The DeleteBucketWebsiteRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentException("The S3 BucketName specified is null or empty!");
            }

            ConvertDeleteBucketWebsite(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<DeleteBucketWebsiteResponse>(asyncResult);
            return asyncResult;
        }

        void ConvertDeleteBucketWebsite(DeleteBucketWebsiteRequest request)
        {
            Map parameters = request.parameters;
            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "DeleteBucketWebsite";
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?website";

            request.RequestDestinationBucket = request.BucketName;
        }

        #endregion

        #region PutLifecycleConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutLifecycleConfiguration"/>
        /// </summary>
        /// <param name="request">The PutLifecycleConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutLifecycleConfiguration.</returns>
        public IAsyncResult BeginPutLifecycleConfiguration(PutLifecycleConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokePutLifecycleConfiguration(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutLifecycleConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutLifecycleConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLifecycleConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutLifecycleConfigurationResponse from S3.</returns>
        public PutLifecycleConfigurationResponse EndPutLifecycleConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<PutLifecycleConfigurationResponse>(asyncResult);
        }

        /// <summary>
        /// Sets the lifecycle configuration that should be applied to a bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If a configuration already exists for the specified bucket, the new
        /// configuration will replace the existing configuration.
        /// </para>
        /// <para>
        /// Lifecycle configuration provides a way to define the lifetime of
        /// objects for a keyspace. Objects are automatically deleted after the
        /// predefined lifetime.
        /// </para>
        /// <para>
        /// For more information on lifecycle configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The PutLifecycleConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a PutLifecycleConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokePutLifecycleConfiguration(request, null, null, true);
            return EndPutLifecycleConfiguration(asyncResult);
        }

        IAsyncResult invokePutLifecycleConfiguration(PutLifecycleConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The PutLifecycleConfigurationRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertPutLifecycleConfiguration(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<PutLifecycleConfigurationResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetLifecycleConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetLifecycleConfiguration"/>
        /// </summary>
        /// <param name="request">The GetLifecycleConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetLifecycleConfiguration.</returns>
        public IAsyncResult BeginGetLifecycleConfiguration(GetLifecycleConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeGetLifecycleConfiguration(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetLifecycleConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetLifecycleConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLifecycleConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetLifecycleConfigurationResponse from S3.</returns>
        public GetLifecycleConfigurationResponse EndGetLifecycleConfiguration(IAsyncResult asyncResult)
        {
            try
            {
                return endOperation<GetLifecycleConfigurationResponse>(asyncResult);
            }
            catch (AmazonS3Exception e)
            {
                if (e.ErrorCode == S3Constants.NoSuchLifecycleConfiguration)
                {
                    return new GetLifecycleConfigurationResponse();
                }

                throw;
            }
        }

        /// <summary>
        /// Retrieves the lifecycle configuration for the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If no configuration has been set for the bucket, the Configuration
        /// property of the response will be null.
        /// </para>
        /// <para>
        /// Lifecycle configuration provides a way to define the lifetime of
        /// objects for a keyspace. Objects are automatically deleted after the
        /// predefined lifetime.
        /// </para>
        /// <para>
        /// For more information on lifecycle configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The GetLifecycleConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetLifecycleConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeGetLifecycleConfiguration(request, null, null, true);
            return EndGetLifecycleConfiguration(asyncResult);
        }

        IAsyncResult invokeGetLifecycleConfiguration(GetLifecycleConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetLifecycleConfigurationRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertGetLifecycleConfiguration(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetLifecycleConfigurationResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region DeleteLifecycleConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteLifecycleConfiguration"/>
        /// </summary>
        /// <param name="request">The DeleteLifecycleConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteLifecycleConfiguration.</returns>
        public IAsyncResult BeginDeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteLifecycleConfiguration(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteLifecycleConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecycleConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteLifecycleConfigurationResponse from S3.</returns>
        public DeleteLifecycleConfigurationResponse EndDeleteLifecycleConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<DeleteLifecycleConfigurationResponse>(asyncResult);
        }

        /// <summary>
        /// Deletes the lifecycle configuration for the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you delete a configuration that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </para>
        /// <para>
        /// Lifecycle configuration provides a way to define the lifetime of
        /// objects for a keyspace. Objects are automatically deleted after the
        /// predefined lifetime.
        /// </para>
        /// <para>
        /// For more information on lifecycle configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The DeleteLifecycleConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a DeleteLifecycleConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteLifecycleConfiguration(request, null, null, true);
            return EndDeleteLifecycleConfiguration(asyncResult);
        }

        IAsyncResult invokeDeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The DeleteLifecycleConfigurationRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertDeleteLifecycleConfiguration(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<DeleteLifecycleConfigurationResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region PutBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketTagging"/>
        /// </summary>
        /// <param name="request">The PutBucketTaggingRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutBucketTagging.</returns>
        public IAsyncResult BeginPutBucketTagging(PutBucketTaggingRequest request, AsyncCallback callback, object state)
        {
            return invokePutBucketTagging(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketTagging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketTagging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketTagging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketTaggingResponse from S3.</returns>
        public PutBucketTaggingResponse EndPutBucketTagging(IAsyncResult asyncResult)
        {
            return endOperation<PutBucketTaggingResponse>(asyncResult);
        }

        /// <summary>
        /// Add a set of tags to a bucket.
        /// </summary>
        /// <remarks>
        /// If tagging already exists for the specified bucket, the new
        /// tagging will replace the existing configuration.
        /// </remarks>
        /// <param name="request">The PutBucketTaggingRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a PutBucketTaggingResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request)
        {
            IAsyncResult asyncResult = invokePutBucketTagging(request, null, null, true);
            return EndPutBucketTagging(asyncResult);
        }

        IAsyncResult invokePutBucketTagging(PutBucketTaggingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The PutBucketTaggingRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertPutBucketTagging(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<PutBucketTaggingResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketTagging"/>
        /// </summary>
        /// <param name="request">The GetBucketTaggingRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketTagging.</returns>
        public IAsyncResult BeginGetBucketTagging(GetBucketTaggingRequest request, AsyncCallback callback, object state)
        {
            return invokeGetBucketTagging(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketTagging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketTagging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketTagging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketTaggingResponse from S3.</returns>
        public GetBucketTaggingResponse EndGetBucketTagging(IAsyncResult asyncResult)
        {
            return endOperation<GetBucketTaggingResponse>(asyncResult);
        }

        /// <summary>
        /// Retrieves the tags that have been applied to a bucket.
        /// </summary>
        /// <remarks>
        /// If no tags have been set for the bucket, an AmazonS3Exception will be thrown.
        /// </remarks>
        /// <param name="request">The GetBucketTaggingRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetBucketTaggingResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request)
        {
            IAsyncResult asyncResult = invokeGetBucketTagging(request, null, null, true);
            return EndGetBucketTagging(asyncResult);
        }

        IAsyncResult invokeGetBucketTagging(GetBucketTaggingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetBucketTaggingRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertGetBucketTagging(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetBucketTaggingResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region DeleteBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketTagging"/>
        /// </summary>
        /// <param name="request">The DeleteBucketTaggingRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteBucketTagging.</returns>
        public IAsyncResult BeginDeleteBucketTagging(DeleteBucketTaggingRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteBucketTagging(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketTagging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketTagging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketTagging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketTaggingResponse from S3.</returns>
        public DeleteBucketTaggingResponse EndDeleteBucketTagging(IAsyncResult asyncResult)
        {
            return endOperation<DeleteBucketTaggingResponse>(asyncResult);
        }

        /// <summary>
        /// Deletes the tags set on a bucket.
        /// </summary>
        /// <remarks>
        /// If you delete a tagging that does not exist yet, Amazon S3 will return a
        /// success (not an error message).
        /// </remarks>
        /// <param name="request">The DeleteBucketTaggingRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a DeleteBucketTaggingResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteBucketTagging(request, null, null, true);
            return EndDeleteBucketTagging(asyncResult);
        }

        IAsyncResult invokeDeleteBucketTagging(DeleteBucketTaggingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The DeleteBucketTaggingRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertDeleteBucketTagging(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<DeleteBucketTaggingResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region PutCORSConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutCORSConfiguration"/>
        /// </summary>
        /// <param name="request">The PutCORSConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutCORSConfiguration.</returns>
        public IAsyncResult BeginPutCORSConfiguration(PutCORSConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokePutCORSConfiguration(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutCORSConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutCORSConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCORSConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutCORSConfigurationResponse from S3.</returns>
        public PutCORSConfigurationResponse EndPutCORSConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<PutCORSConfigurationResponse>(asyncResult);
        }

        /// <summary>
        /// Applies a CORS (cross-origin resource sharing) configuration to a bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// You set this configuration on a bucket so that the bucket can service cross-origin requests.
        /// </para>
        /// <para>
        /// If a configuration already exists for the specified bucket, the new
        /// configuration will replace the existing configuration.
        /// </para>
        /// <para>
        /// For more information on CORS configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The PutCORSConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a PutCORSConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokePutCORSConfiguration(request, null, null, true);
            return EndPutCORSConfiguration(asyncResult);
        }

        IAsyncResult invokePutCORSConfiguration(PutCORSConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The PutCORSConfigurationRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertPutCORSConfiguration(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<PutCORSConfigurationResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region GetCORSConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetCORSConfiguration"/>
        /// </summary>
        /// <param name="request">The GetCORSConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetCORSConfiguration.</returns>
        public IAsyncResult BeginGetCORSConfiguration(GetCORSConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeGetCORSConfiguration(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetCORSConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetCORSConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCORSConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetCORSConfigurationResponse from S3.</returns>
        public GetCORSConfigurationResponse EndGetCORSConfiguration(IAsyncResult asyncResult)
        {
            try
            {
                return endOperation<GetCORSConfigurationResponse>(asyncResult);
            }
            catch (AmazonS3Exception e)
            {
                if (e.ErrorCode == S3Constants.NoSuchCORSConfiguration)
                {
                    return new GetCORSConfigurationResponse();
                }

                throw;
            }

        }

        /// <summary>
        /// Retrieves the CORS (cross-origin resource sharing) configuration for a bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If no configuration has been set for the bucket, the Configuration
        /// property of the response will be null.
        /// </para>
        /// <para>
        /// For more information on CORS configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The GetCORSConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetCORSConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeGetCORSConfiguration(request, null, null, true);
            return EndGetCORSConfiguration(asyncResult);
        }

        IAsyncResult invokeGetCORSConfiguration(GetCORSConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetCORSConfigurationRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertGetCORSConfiguration(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<GetCORSConfigurationResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region DeleteCORSConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteCORSConfiguration"/>
        /// </summary>
        /// <param name="request">The DeleteCORSConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteCORSConfiguration.</returns>
        public IAsyncResult BeginDeleteCORSConfiguration(DeleteCORSConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteCORSConfiguration(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCORSConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteCORSConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCORSConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteCORSConfigurationResponse from S3.</returns>
        public DeleteCORSConfigurationResponse EndDeleteCORSConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<DeleteCORSConfigurationResponse>(asyncResult);
        }

        /// <summary>
        /// Deletes the CORS (cross-origin resource sharing) configuration for a bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you delete a configuration that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </para>
        /// <para>
        /// For more information on CORS configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The DeleteCORSConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a DeleteCORSConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteCORSConfiguration(request, null, null, true);
            return EndDeleteCORSConfiguration(asyncResult);
        }

        IAsyncResult invokeDeleteCORSConfiguration(DeleteCORSConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The DeleteCORSConfigurationRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertDeleteCORSConfiguration(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<DeleteCORSConfigurationResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region RestoreObject

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.RestoreObject"/>
        /// </summary>
        /// <param name="request">The RestoreObjectRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndRestoreObject.</returns>
        public IAsyncResult BeginRestoreObject(RestoreObjectRequest request, AsyncCallback callback, object state)
        {
            return invokeRestoreObject(request, callback, state, false);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the RestoreObject operation.
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a RestoreObjectResponse from S3.</returns>
        public RestoreObjectResponse EndRestoreObject(IAsyncResult asyncResult)
        {
            return endOperation<RestoreObjectResponse>(asyncResult);
        }

        /// <summary>
        /// <para>
        /// This operation begins a restore object request for an object that has been 
        /// stored in Amazon Glacier.  The object will stay active in Amazon S3 for the number
        /// of days set on the RestoreObjectRequest object.
        /// </para>
        /// </summary>
        /// <param name="request">The RestoreObjectRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a RestoreObjectResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public RestoreObjectResponse RestoreObject(RestoreObjectRequest request)
        {
            IAsyncResult asyncResult = invokeRestoreObject(request, null, null, true);
            return EndRestoreObject(asyncResult);
        }

        IAsyncResult invokeRestoreObject(RestoreObjectRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The RestoreObjectRequest is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The S3 BucketName specified is null or empty!");
            }

            ConvertRestoreObject(request);
            S3AsyncResult asyncResult = new S3AsyncResult(request, state, callback, synchronized);
            invoke<RestoreObjectResponse>(asyncResult);
            return asyncResult;
        }

        #endregion

        #region Private ConvertXXX Methods

        /**
        * Convert ListBucketsRequest to key/value pairs
        */
        private void ConvertListBuckets(ListBucketsRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "ListBuckets";
            request.RequestDestinationBucket = null;
        }

        /**
         * Convert GetBucketLocationRequest to key/value pairs.
         */
        private void ConvertGetBucketLocation(GetBucketLocationRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetBucketLocation";
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?location";

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert GetBucketLoggingRequest to key/value pairs.
         */
        private void ConvertGetBucketLogging(GetBucketLoggingRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetBucketLogging";
            parameters[S3QueryParameter.Query] = "?logging";
            parameters[S3QueryParameter.QueryToSign] = "?logging";

            request.RequestDestinationBucket = request.BucketName;

        }

        /**
         * Convert SetBucketLoggingRequest for enable logging, to key/value pairs.
         */
        private void ConvertEnableBucketLogging(EnableBucketLoggingRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.ContentBody] = request.LoggingConfig.ToString();
            parameters[S3QueryParameter.ContentType] = AWSSDKUtils.UrlEncodedContent;
            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "SetBucketLogging";
            parameters[S3QueryParameter.Query] = "?logging";
            parameters[S3QueryParameter.QueryToSign] = "?logging";

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert DisableBucketLoggingRequest for disable logging, to key/value pairs.
         */
        private void ConvertDisableBucketLogging(DisableBucketLoggingRequest request)
        {
            ConvertEnableBucketLogging(request);
        }

        /**
         * Convert ListObjectsRequest to key/value pairs
         */
        private void ConvertListObjects(ListObjectsRequest request)
        {
            Map parameters = request.parameters;

            //Create query string if any of the values are set.
            StringBuilder sb = new StringBuilder("?", 256);
            if (request.IsSetPrefix())
            {
                sb.Append(String.Concat("prefix=", AmazonS3Util.UrlEncode(request.Prefix, false), "&"));
            }
            if (request.IsSetMarker())
            {
                sb.Append(String.Concat("marker=", AmazonS3Util.UrlEncode(request.Marker, false), "&"));
            }
            if (request.IsSetDelimiter())
            {
                sb.Append(String.Concat("delimiter=", AmazonS3Util.UrlEncode(request.Delimiter, false), "&"));
            }
            if (request.IsSetMaxKeys())
            {
                sb.Append(String.Concat("max-keys=", request.MaxKeys, "&"));
            }

            string query = sb.ToString();

            // Remove trailing & character
            if (query.EndsWith("&"))
            {
                query = query.Remove(query.Length - 1);
            }

            // We initialized the query with a "?". If none of
            // Prefix, Marker, Delimiter, MaxKeys is set, there
            // is no query
            if (query.Length > 1)
            {
                parameters[S3QueryParameter.Query] = query;
            }

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "ListObjects";
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert ListVersionsRequest to key/value pairs
         */
        private void ConvertListVersions(ListVersionsRequest request)
        {
            Map parameters = request.parameters;

            //Create query string if any of the values are set.
            StringBuilder sb = new StringBuilder("?versions", 256);

            // This part of the query needs to be signed, the rest don't need to be
            parameters[S3QueryParameter.QueryToSign] = sb.ToString();

            if (request.IsSetPrefix())
            {
                sb.Append(String.Concat("&prefix=", AmazonS3Util.UrlEncode(request.Prefix, false)));
            }
            if (request.IsSetKeyMarker())
            {
                sb.Append(String.Concat("&key-marker=", AmazonS3Util.UrlEncode(request.KeyMarker, false)));
            }
            if (request.IsSetVersionIdMarker())
            {
                sb.Append(String.Concat("&version-id-marker=", AmazonS3Util.UrlEncode(request.VersionIdMarker, false)));
            }
            if (request.IsSetDelimiter())
            {
                sb.Append(String.Concat("&delimiter=", AmazonS3Util.UrlEncode(request.Delimiter, false)));
            }
            if (request.IsSetMaxKeys())
            {
                sb.Append(String.Concat("&max-keys=", request.MaxKeys));
            }

            parameters[S3QueryParameter.Query] = sb.ToString();
            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "ListVersions";
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert GetAclRequest to key/value pairs.
         */
        private void ConvertGetACL(GetACLRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetACL";

            string queryStr = "?acl";

            if (request.IsSetKey())
            {
                parameters[S3QueryParameter.Key] = request.Key;

                // The queryStr needs to be changed from its default value only
                // if a version-id is specified
                if (request.IsSetVersionId())
                {
                    queryStr = String.Concat(queryStr, "&versionId=", request.VersionId);
                }
            }

            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         *  Convert SetACLRequest to key/value pairs.
         */
        private void ConvertSetACL(SetACLRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            if (request.IsSetACL())
            {
                parameters[S3QueryParameter.ContentBody] = request.ACL.ToString();
                parameters[S3QueryParameter.ContentType] = AWSSDKUtils.UrlEncodedContent;
            }

            if (request.IsSetCannedACL())
            {
                setCannedACLHeader(webHeaders, request.CannedACL);
            }

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "SetACL";

            string queryStr = "?acl";

            if (request.IsSetKey())
            {
                parameters[S3QueryParameter.Key] = request.Key;

                // The queryStr needs to be changed from its default value only
                // if a version-id is specified
                if (request.IsSetVersionId())
                {
                    queryStr = String.Concat(queryStr, "&versionId=", request.VersionId);
                }
            }

            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Converts the PutBucketRequest to key/value pairs
         */
        private void ConvertPutBucket(PutBucketRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "PutBucket";

            string regionCode;
            if (request.UseClientRegion)
            {
                regionCode = Amazon.Util.AWSSDKUtils.DetermineRegion(this.determinedConfiguredServiceURL());
                if (regionCode == S3Constants.REGION_US_EAST_1)
                    regionCode = null;
                else if(regionCode == S3Constants.REGION_EU_WEST_1)
                    regionCode = S3Constants.LocationConstraints[(int)S3Region.EU];
            }
            else if (!string.IsNullOrEmpty(request.BucketRegionName))
            {
                if (string.Equals(request.BucketRegionName, S3Constants.REGION_EU_WEST_1))
                {
                    regionCode = S3Constants.LocationConstraints[(int)S3Region.EU];
                }
                else
                {
                    regionCode = request.BucketRegionName;
                }
            }
            else
            {
                regionCode = S3Constants.LocationConstraints[(int)request.BucketRegion];
            }

            if (!string.IsNullOrEmpty(regionCode) && !string.Equals(request.BucketRegionName, S3Constants.REGION_US_EAST_1))
            {
                string content = String.Format(
                    "<CreateBucketConstraint><LocationConstraint>{0}</LocationConstraint></CreateBucketConstraint>",
                    regionCode
                    );
                parameters[S3QueryParameter.ContentBody] = content;
                parameters[S3QueryParameter.ContentType] = AWSSDKUtils.UrlEncodedContent;
            }

            if (request.IsSetCannedACL())
                setCannedACLHeader(request.Headers, request.CannedACL);
            else
                ConvertPutWithACLRequest(request);

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert DeleteBucketRequest to key/value pairs
         */
        private void ConvertDeleteBucket(DeleteBucketRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "DeleteBucket";
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert GetBucketPolicyRequest to key/value pairs.
         */
        private void ConvertGetBucketPolicy(GetBucketPolicyRequest request)
        {
            Map parameters = request.parameters;
            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetBucketPolicy";
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?policy";

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert PutBucketPolicyRequest to key/value pairs.
         */
        private void ConvertPutBucketPolicy(PutBucketPolicyRequest request)
        {
            Map parameters = request.parameters;
            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "PutBucketPolicy";
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?policy";

            parameters[S3QueryParameter.ContentBody] = request.Policy;
            parameters[S3QueryParameter.ContentType] = AWSSDKUtils.UrlEncodedContent;

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert DeleteBucketPolicyRequest to key/value pairs.
         */
        private void ConvertDeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            Map parameters = request.parameters;
            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "DeleteBucketPolicy";
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?policy";

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert SetNotificationConfigurationRequest to key/value pairs.
         */
        private void ConvertSetNotificationConfiguration(SetNotificationConfigurationRequest request)
        {
            Map parameters = request.parameters;
            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "SetNotificationConfiguration";
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?notification";

            parameters[S3QueryParameter.ContentType] = AWSSDKUtils.UrlEncodedContent;

            // If this is null then assume the configuration is intented to be removed which is
            // done by sending an xml document without any topic configurations.
            if (request.NotificationConfiguration == null)
            {
                parameters[S3QueryParameter.ContentBody] = new NotificationConfigurationList().ToXML();
            }
            else
            {
                parameters[S3QueryParameter.ContentBody] = request.NotificationConfiguration.ToXML();
            }

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert GetNotificationConfigurationRequest to key/value pairs.
         */
        private void ConvertGetNotificationConfiguration(GetNotificationConfigurationRequest request)
        {
            Map parameters = request.parameters;
            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetNotificationConfiguration";
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?notification";

            request.RequestDestinationBucket = request.BucketName;
        }


        /**
          * Convert GetObjectRequest to key/value pairs.
          */
        private void ConvertGetObject(GetObjectRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetObject";
            parameters[S3QueryParameter.Key] = request.Key;

            if (request.IsSetByteRange())
            {
                parameters[S3QueryParameter.Range] = String.Concat(
                    request.ByteRangeLong.First,
                    ":",
                    request.ByteRangeLong.Second
                    );
            }

            // Add the necessary get object specific headers to the request.Headers object
            if (request.IsSetETagToMatch())
            {
                setIfMatchHeader(webHeaders, request.ETagToMatch);
            }
            if (request.IsSetETagToNotMatch())
            {
                setIfNoneMatchHeader(webHeaders, request.ETagToNotMatch);
            }
            if (request.IsSetModifiedSinceDate())
            {
                setIfModifiedSinceHeader(webHeaders, request.ModifiedSinceDate);
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                setIfUnmodifiedSinceHeader(webHeaders, request.UnmodifiedSinceDate);
            }

            StringBuilder queryStr = new StringBuilder();

            addParameter(queryStr, "versionId", request.VersionId);
            addParameter(queryStr, ResponseHeaderOverrides.RESPONSE_CACHE_CONTROL, request.ResponseHeaderOverrides.CacheControl);
            addParameter(queryStr, ResponseHeaderOverrides.RESPONSE_CONTENT_DISPOSITION, request.ResponseHeaderOverrides.ContentDisposition);
            addParameter(queryStr, ResponseHeaderOverrides.RESPONSE_CONTENT_ENCODING, request.ResponseHeaderOverrides.ContentEncoding);
            addParameter(queryStr, ResponseHeaderOverrides.RESPONSE_CONTENT_LANGUAGE, request.ResponseHeaderOverrides.ContentLanguage);
            addParameter(queryStr, ResponseHeaderOverrides.RESPONSE_CONTENT_TYPE, request.ResponseHeaderOverrides.ContentType);
            addParameter(queryStr, ResponseHeaderOverrides.RESPONSE_EXPIRES, request.ResponseHeaderOverrides.Expires);


            if (queryStr.Length > 0)
            {
                parameters[S3QueryParameter.Query] = "?" + queryStr.ToString();
                parameters[S3QueryParameter.QueryToSign] = parameters[S3QueryParameter.Query];
            }

            request.RequestDestinationBucket = request.BucketName;
        }

        void addParameter(StringBuilder queryStr, string key, string value)
        {
            addParameter(queryStr, null, key, value);
        }
        void addParameter(StringBuilder queryStr, StringBuilder encodedQueryStr, string key, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (queryStr != null && queryStr.Length > 0)
                    queryStr.Append("&");
                if (encodedQueryStr != null && encodedQueryStr.Length > 0)
                    encodedQueryStr.Append("&");

                if (queryStr != null)
                    queryStr.AppendFormat("{0}={1}", key, value);
                if (encodedQueryStr != null)
                    encodedQueryStr.AppendFormat("{0}={1}", key, AmazonS3Util.UrlEncode(value, true));
            }
        }

        /**
         * Convert GetObjectMetadataRequest to key/value pairs.
         */
        private void ConvertGetObjectMetadata(GetObjectMetadataRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.HeadVerb;
            parameters[S3QueryParameter.Action] = "GetObjectMetadata";
            parameters[S3QueryParameter.Key] = request.Key;

            if (request.IsSetETagToNotMatch())
            {
                setIfNoneMatchHeader(webHeaders, request.ETagToNotMatch);
            }
            if (request.IsSetModifiedSinceDate())
            {
                setIfModifiedSinceHeader(webHeaders, request.ModifiedSinceDate);
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                setIfUnmodifiedSinceHeader(webHeaders, request.UnmodifiedSinceDate);
            }
            if (request.IsSetVersionId())
            {
                string queryStr = String.Concat("?versionId=", request.VersionId);
                parameters[S3QueryParameter.Query] = queryStr;
                parameters[S3QueryParameter.QueryToSign] = queryStr;
            }

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert grants to headers for those requests which support them. 
         */
        protected internal void ConvertPutWithACLRequest(S3PutWithACLRequest request)
        {
            Dictionary<S3Permission, string> protoHeaders = new Dictionary<S3Permission, string>();
            foreach (var grant in request.Grants)
            {
                string grantee = null;
                if (grant.Grantee.CanonicalUser != null && !string.IsNullOrEmpty(grant.Grantee.CanonicalUser.First))
                    grantee = String.Format("id=\"{0}\"", grant.Grantee.CanonicalUser.First);
                else if (grant.Grantee.IsSetEmailAddress())
                    grantee = String.Format("emailAddress=\"{0}\"", grant.Grantee.EmailAddress);
                else if (grant.Grantee.IsSetURI())
                    grantee = String.Format("uri=\"{0}\"", grant.Grantee.URI);
                else continue;

                string glist = null;
                if (protoHeaders.TryGetValue(grant.Permission, out glist))
                    protoHeaders[grant.Permission] = String.Format("{0}, {1}", glist, grantee);
                else
                    protoHeaders.Add(grant.Permission, grantee);
            }

            foreach (var permission in protoHeaders.Keys)
            {
                switch(permission)
                {
                    case S3Permission.READ:
                        request.Headers[S3Constants.AmzGrantHeaderRead] = protoHeaders[permission];
                        break;
                    case S3Permission.WRITE:
                        request.Headers[S3Constants.AmzGrantHeaderWrite] = protoHeaders[permission];
                        break;
                    case S3Permission.READ_ACP:
                        request.Headers[S3Constants.AmzGrantHeaderReadAcp]= protoHeaders[permission];
                        break;
                    case S3Permission.WRITE_ACP:
                        request.Headers[S3Constants.AmzGrantHeaderWriteAcp]= protoHeaders[permission];
                        break;
                    case S3Permission.RESTORE_OBJECT:
                        request.Headers[S3Constants.AmzGrantHeaderRestoreObject] = protoHeaders[permission];
                        break;
                    case S3Permission.FULL_CONTROL:
                        request.Headers[S3Constants.AmzGrantHeaderFullControl] = protoHeaders[permission];
                        break;
                }
            }
        }

        /**
         * Convert PutObjectRequest to key/value pairs.
         */
        protected internal void ConvertPutObject(PutObjectRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "PutObject";
            parameters[S3QueryParameter.Key] = request.Key;
            if (request.IsSetMD5Digest())
            {
                webHeaders[AWSSDKUtils.ContentMD5Header] = request.MD5Digest;
            }
            else if (request.GenerateMD5Digest)
            {
                string checksum = null;
                if (request.IsSetInputStream())
                {
                    checksum = AmazonS3Util.GenerateChecksumForStream(request.InputStream, true);
                }
                else
                {
                    // If there isn't an input stream, there has to be a content body.
                    checksum = AmazonS3Util.GenerateChecksumForContent(request.ContentBody, true);
                }

                webHeaders[AWSSDKUtils.ContentMD5Header] = checksum;
            }

            // Add the Content Type
            if (request.IsSetContentType())
            {
                parameters[S3QueryParameter.ContentType] = request.ContentType;
            }
            else if (request.IsSetFilePath() ||
                request.IsSetKey())
            {
                // Get the extension of the file from the path.
                // Try the key as well.
                string ext = Path.GetExtension(request.FilePath);
                if (String.IsNullOrEmpty(ext) &&
                    request.IsSetKey())
                {
                    ext = Path.GetExtension(request.Key);
                }
                // Use the extension to get the mime-type
                if (!String.IsNullOrEmpty(ext))
                {
                    parameters[S3QueryParameter.ContentType] = AmazonS3Util.MimeTypeFromExtension(ext);
                }
            }

            // Set the Content Length based on whether there is a stream
            if (request.IsSetInputStream())
            {
                parameters[S3QueryParameter.ContentLength] = request.InputStream.Length.ToString();
            }

            if (request.IsSetContentBody())
            {
                // The content length is determined based on the number of bytes
                // needed to represent the content string - check invoke<T>
                parameters[S3QueryParameter.ContentBody] = request.ContentBody;
                // Since a content body was set, let's determine whether a content type was set
                if (!parameters.ContainsKey(S3QueryParameter.ContentType))
                {
                    parameters[S3QueryParameter.ContentType] = AWSSDKUtils.UrlEncodedContent;
                }
            }

            // Add the Put Object specific headers to the request
            // 1. The Canned ACL
            if (request.IsSetCannedACL())
            {
                setCannedACLHeader(webHeaders, request.CannedACL);
            }

            // 2. The MetaData
            if (request.IsSetMetaData())
            {
                // Add headers of type x-amz-meta-<key> to the request
                foreach (string key in request.metaData)
                {
                    string prefixedKey;
                    if (!key.StartsWith("x-amz-meta-"))
                    {
                        prefixedKey = String.Concat("x-amz-meta-", key);
                    }
                    else
                    {
                        prefixedKey = key;
                    }

                    webHeaders[prefixedKey] = request.metaData[key];
                }
            }

            // Add the storage class header
            webHeaders[S3Constants.AmzStorageClassHeader] = S3Constants.StorageClasses[(int)request.StorageClass];

            ConvertPutWithACLRequest(request);

            // Add server side encryption
            if (request.ServerSideEncryptionMethod != ServerSideEncryptionMethod.None)
            {
                webHeaders[S3Constants.AmzServerSideEncryptionHeader] = request.ServerSideEncryptionMethod.ToString();
            }
            if (request.IsSetWebsiteRedirectLocation())
            {
                webHeaders[S3Constants.AmzWebsiteRedirectLocationHeader] = request.WebsiteRedirectLocation;
            }

            // Finally, add the S3 specific parameters and headers
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert GetPreSignedUrlRequest to key/value pairs.
         */
        private void ConvertGetPreSignedUrl(GetPreSignedUrlRequest request)
        {
            using (ImmutableCredentials immutableCredentials = credentials.GetCredentials())
            {
                Map parameters = request.parameters;

                parameters[S3QueryParameter.Verb] = S3Constants.Verbs[(int)request.Verb];
                parameters[S3QueryParameter.Action] = "GetPreSignedUrl";
                StringBuilder queryStr = new StringBuilder("?", 512);

                if (immutableCredentials.UseToken)
                {
                    queryStr.Append("x-amz-security-token=");
                    // Token must be as-is for the signature code, but must be url-encoded in the url
                    queryStr.Append(AmazonS3Util.UrlEncode(immutableCredentials.Token, false));
                    queryStr.Append("&");
                }

                queryStr.Append("AWSAccessKeyId=" + immutableCredentials.AccessKey);
                if (request.IsSetKey())
                {
                    parameters[S3QueryParameter.Key] = request.Key;
                }
                else if (request.Verb == HttpVerb.HEAD)
                {
                    queryStr.Append("&max-keys=0");
                }

                if (request.IsSetContentType())
                {
                    parameters[S3QueryParameter.ContentType] = request.ContentType;
                }

                if (queryStr.Length != 0)
                {
                    queryStr.Append("&");
                }
                queryStr.Append("Expires=");

                string value = Convert.ToInt64((request.Expires.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
                queryStr.Append(value);
                parameters[S3QueryParameter.Expires] = value;


                StringBuilder encodedQueryStrToSign = new StringBuilder();
                StringBuilder queryStrToSign = new StringBuilder();
                if (request.IsSetKey() &&
                    request.IsSetVersionId() &&
                    request.Verb < HttpVerb.PUT)
                {
                    addParameter(queryStrToSign, encodedQueryStrToSign, "versionId", request.VersionId);
                }

                addParameter(queryStrToSign, encodedQueryStrToSign, ResponseHeaderOverrides.RESPONSE_CACHE_CONTROL, request.ResponseHeaderOverrides.CacheControl);
                addParameter(queryStrToSign, encodedQueryStrToSign, ResponseHeaderOverrides.RESPONSE_CONTENT_DISPOSITION, request.ResponseHeaderOverrides.ContentDisposition);
                addParameter(queryStrToSign, encodedQueryStrToSign, ResponseHeaderOverrides.RESPONSE_CONTENT_ENCODING, request.ResponseHeaderOverrides.ContentEncoding);
                addParameter(queryStrToSign, encodedQueryStrToSign, ResponseHeaderOverrides.RESPONSE_CONTENT_LANGUAGE, request.ResponseHeaderOverrides.ContentLanguage);
                addParameter(queryStrToSign, encodedQueryStrToSign, ResponseHeaderOverrides.RESPONSE_CONTENT_TYPE, request.ResponseHeaderOverrides.ContentType);
                addParameter(queryStrToSign, encodedQueryStrToSign, ResponseHeaderOverrides.RESPONSE_EXPIRES, request.ResponseHeaderOverrides.Expires);

                if (queryStrToSign.Length > 0)
                {
                    parameters[S3QueryParameter.QueryToSign] = "?" + queryStrToSign.ToString();
                    queryStr.Append("&" + encodedQueryStrToSign.ToString());
                }

                parameters[S3QueryParameter.Query] = queryStr.ToString();
                request.RequestDestinationBucket = request.BucketName;
                addS3QueryParameters(request, immutableCredentials);

                // the url needs to be modified so that:
                // 1. The right http protocol is used
                // 2. The auth string is added to the url
                string url = request.parameters[S3QueryParameter.Url];

                // the url's protocol prefix is generated using the config's
                // CommunicationProtocol property. If the request's
                // protocol differs from that set in the config, make the
                // necessary string replacements.
                if (request.Protocol != config.CommunicationProtocol)
                {
                    switch (config.CommunicationProtocol)
                    {
                        case Protocol.HTTP:
                            url = url.Replace("http://", "https://");
                            break;
                        case Protocol.HTTPS:
                            url = url.Replace("https://", "http://");
                            break;
                    }
                }

                // Add server side encryption
                if (request.ServerSideEncryptionMethod != ServerSideEncryptionMethod.None)
                {
                    request.Headers[S3Constants.AmzServerSideEncryptionHeader] = request.ServerSideEncryptionMethod.ToString();
                }

                //sign the request
                string toSign = buildSigningString(parameters, request.Headers);
                string auth;
                if (immutableCredentials.UseSecureStringForSecretKey)
                {
                    KeyedHashAlgorithm algorithm = new HMACSHA1();
                    auth = AWSSDKUtils.HMACSign(toSign, immutableCredentials.SecureSecretKey, algorithm);
                }
                else
                {
                    KeyedHashAlgorithm algorithm = new HMACSHA1();
                    auth = AWSSDKUtils.HMACSign(toSign, immutableCredentials.ClearSecretKey, algorithm);
                }
                parameters[S3QueryParameter.Authorization] = auth;

                parameters[S3QueryParameter.Url] = String.Concat(
                    url,
                    "&Signature=",
                    AmazonS3Util.UrlEncode(request.parameters[S3QueryParameter.Authorization], false)
                    );
            }
        }

        /**
         * Convert DeleteObjectRequest to key/value pairs.
         */
        private void ConvertDeleteObject(DeleteObjectRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "DeleteObject";
            parameters[S3QueryParameter.Key] = request.Key;
            if (request.IsSetVersionId())
            {
                string queryStr = String.Concat("?versionId=", request.VersionId);
                parameters[S3QueryParameter.Query] = queryStr;
                parameters[S3QueryParameter.QueryToSign] = queryStr;
            }

            if (request.IsSetMfaCodes())
            {
                setMfaHeader(request.Headers, request.MfaCodes);
            }

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert CopyObjectRequest to key/value pairs.
         */
        private void ConvertCopyObject(CopyObjectRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "CopyObject";

            // the name of the new key created in the destination bucket is the
            // DestinationKey parameter unless it isn't specified, in which case,
            // use the SourceKey.
            if (request.IsSetDestinationKey())
            {
                parameters[S3QueryParameter.Key] = request.DestinationKey;
            }
            else
            {
                parameters[S3QueryParameter.Key] = request.SourceKey;
            }

            // Add the Copy Object specific headers to the request
            if (request.IsSetETagToMatch())
            {
                setIfMatchCopyHeader(webHeaders, request.ETagToMatch);
            }
            if (request.IsSetETagToNotMatch())
            {
                setIfNoneMatchCopyHeader(webHeaders, request.ETagToNotMatch);
            }
            if (request.IsSetModifiedSinceDate())
            {
                setIfModifiedSinceCopyHeader(webHeaders, request.ModifiedSinceDate);
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                setIfUnmodifiedSinceCopyHeader(webHeaders, request.UnmodifiedSinceDate);
            }

            // Add the Copy Source header which makes this a COPY request
            setCopySourceHeader(webHeaders, request.SourceBucket, request.SourceKey, request.SourceVersionId);

            // there is always a directive associated with the request
            setMetadataDirectiveHeader(webHeaders, request.Directive);

            // if the user has specified the REPLACE directive
            // and specified new metadata for the copied object
            // specify the metadata using the x-amz-meta header.
            // also, pass the content type header.
            if (request.Directive == S3MetadataDirective.REPLACE)
            {
                if (request.IsSetMetaData())
                {
                    // Add headers of type x-amz-meta-<key> to the request
                    foreach (string key in request.metaData)
                    {
                        string prefixedKey;
                        if (!key.StartsWith("x-amz-meta-"))
                        {
                            prefixedKey = String.Concat("x-amz-meta-", key);
                        }
                        else
                        {
                            prefixedKey = key;
                        }

                        webHeaders[prefixedKey] = request.metaData[key];
                    }
                }

                // Add the Content Type, if it is specified
                // or determine the content type from the extension
                if (request.IsSetContentType())
                {
                    parameters[S3QueryParameter.ContentType] = request.ContentType;
                }
                else if (request.IsSetDestinationKey())
                {
                    // Get the extension of the file from the destination key.
                    // Try the key as well.
                    string ext = Path.GetExtension(request.DestinationKey);
                    if (String.IsNullOrEmpty(ext))
                    {
                        ext = Path.GetExtension(request.SourceKey);
                    }
                    // Use the extension to get the mime-type
                    if (!String.IsNullOrEmpty(ext))
                    {
                        parameters[S3QueryParameter.ContentType] = AmazonS3Util.MimeTypeFromExtension(ext);
                    }
                }
            }

            // The Canned ACL
            if (request.IsSetCannedACL())
            {
                setCannedACLHeader(webHeaders, request.CannedACL);
            }

            // Custom ACLs
            ConvertPutWithACLRequest(request);

            // Add the storage class header
            webHeaders[S3Constants.AmzStorageClassHeader] = S3Constants.StorageClasses[(int)request.StorageClass];

            // Add server side encryption, even if method is None
            if (request.ServerSideEncryptionMethod != ServerSideEncryptionMethod.None)
            {
                webHeaders[S3Constants.AmzServerSideEncryptionHeader] = request.ServerSideEncryptionMethod.ToString();
            }
            if (request.IsSetWebsiteRedirectLocation())
            {
                webHeaders[S3Constants.AmzWebsiteRedirectLocationHeader] = request.WebsiteRedirectLocation;
            }

            request.RequestDestinationBucket = request.DestinationBucket;
        }

        /**
         * Convert GetBucketVersioningRequest to key/value pairs.
         */
        private void ConvertGetBucketVersioning(GetBucketVersioningRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = HttpVerb.GET.ToString();
            parameters[S3QueryParameter.Action] = "GetBucketVersioning";
            parameters[S3QueryParameter.Query] = "?versioning";
            parameters[S3QueryParameter.QueryToSign] = "?versioning";

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert SetBucketVersioningRequest to key/value pairs.
         */
        private void ConvertSetBucketVersioning(SetBucketVersioningRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = HttpVerb.PUT.ToString();
            parameters[S3QueryParameter.Action] = "SetBucketVersioning";
            parameters[S3QueryParameter.Query] = "?versioning";
            parameters[S3QueryParameter.QueryToSign] = "?versioning";
            parameters[S3QueryParameter.ContentBody] = request.VersioningConfig.ToString();
            parameters[S3QueryParameter.ContentType] = AWSSDKUtils.UrlEncodedContent;

            if (request.VersioningConfig.IsSetEnableMfaDelete())
            {
                setMfaHeader(webHeaders, request.MfaCodes);
            }

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert InitiateMultipartUpload to key/value pairs.
         */
        private void ConvertInitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PostVerb;
            parameters[S3QueryParameter.Action] = "InitiateMultipartUpload";
            parameters[S3QueryParameter.Key] = request.Key;
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = "?uploads";

            // Add the Content Type
            if (request.IsSetContentType())
            {
                parameters[S3QueryParameter.ContentType] = request.ContentType;
            }
            else if (request.IsSetKey())
            {
                // Get the extension of the file from the path.
                // Try the key as well.
                string ext = Path.GetExtension(request.Key);
                // Use the extension to get the mime-type
                if (!String.IsNullOrEmpty(ext))
                {
                    parameters[S3QueryParameter.ContentType] = AmazonS3Util.MimeTypeFromExtension(ext);
                }
            }

            // Add the Put Object specific headers to the request
            // 1. The Canned ACL
            if (request.IsSetCannedACL())
            {
                setCannedACLHeader(webHeaders, request.CannedACL);
            }

            // 2. The Metadata
            if (request.IsSetMetaData())
            {
                // Add headers of type x-amz-meta-<key> to the request
                foreach (string key in request.metaData)
                {
                    webHeaders[String.Concat("x-amz-meta-", key)] = request.metaData[key];
                }
            }

            // 3. Custom ACLs

            ConvertPutWithACLRequest(request);

            // Add the storage class header
            webHeaders[S3Constants.AmzStorageClassHeader] = S3Constants.StorageClasses[(int)request.StorageClass];

            // Add server side encryption
            if (request.ServerSideEncryptionMethod != ServerSideEncryptionMethod.None)
            {
                webHeaders[S3Constants.AmzServerSideEncryptionHeader] = request.ServerSideEncryptionMethod.ToString();
            }
            if (request.IsSetWebsiteRedirectLocation())
            {
                webHeaders[S3Constants.AmzWebsiteRedirectLocationHeader] = request.WebsiteRedirectLocation;
            }

            // Finally, add the S3 specific parameters and headers
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert AbortMultipartUploadRequest for enable logging, to key/value pairs.
         */
        private void ConvertAbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "AbortMultipartUpload";
            parameters[S3QueryParameter.Key] = request.Key;
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = string.Format("?uploadId={0}", request.UploadId);


            // Finally, add the S3 specific parameters and headers
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert ListMultipartUploadsRequest for enable logging, to key/value pairs.
         */
        private void ConvertListMultipartUploads(ListMultipartUploadsRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "ListMultipartUploads";
            parameters[S3QueryParameter.QueryToSign] = "?uploads";

            //Create query string if any of the values are set.
            StringBuilder sb = new StringBuilder("?uploads&", 256);
            if (request.IsSetMaxUploads())
            {
                sb.Append(String.Concat("max-uploads=", request.MaxUploads.ToString(), "&"));
            }
            if (request.IsSetKeyMarker())
            {
                sb.Append(String.Concat("key-marker=", AmazonS3Util.UrlEncode(request.KeyMarker, false), "&"));
            }
            if (request.IsSetUploadIdMarker())
            {
                sb.Append(String.Concat("upload-idmarker=", AmazonS3Util.UrlEncode(request.UploadIdMarker, false), "&"));
            }
            if (request.IsSetPrefix())
            {
                sb.Append(String.Concat("prefix=", AmazonS3Util.UrlEncode(request.Prefix, false), "&"));
            }
            if (request.IsSetDelimiter())
            {
                sb.Append(String.Concat("delimiter=", AmazonS3Util.UrlEncode(request.Delimiter, false), "&"));
            }

            string query = sb.ToString();

            // Remove trailing & character
            if (query.EndsWith("&"))
            {
                query = query.Remove(query.Length - 1);
            }

            parameters[S3QueryParameter.Query] = query;

            // Finally, add the S3 specific parameters and headers
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert ListPartsRequest for enable logging, to key/value pairs.
         */
        private void ConvertListParts(ListPartsRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "ListParts";
            parameters[S3QueryParameter.Key] = request.Key;
            parameters[S3QueryParameter.QueryToSign] = string.Format("?uploadId={0}", request.UploadId);

            //Create query string if any of the values are set.
            StringBuilder sb = new StringBuilder(string.Format("?uploadId={0}&", request.UploadId), 256);
            if (request.IsSetMaxParts())
            {
                sb.Append(String.Concat("max-parts=", request.MaxParts.ToString(), "&"));
            }
            if (request.IsSetPartNumberMarker())
            {
                sb.Append(String.Concat("part-number-marker=", AmazonS3Util.UrlEncode(request.PartNumberMarker, false), "&"));
            }

            string query = sb.ToString();

            // Remove trailing & character
            if (query.EndsWith("&"))
            {
                query = query.Remove(query.Length - 1);
            }

            parameters[S3QueryParameter.Query] = query;

            // Finally, add the S3 specific parameters and headers
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert CompleteMultipartUploadRequest for enable logging, to key/value pairs.
         */
        private void ConvertCompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PostVerb;
            parameters[S3QueryParameter.Action] = "CompleteMultipartUpload";
            parameters[S3QueryParameter.Key] = request.Key;
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = string.Format("?uploadId={0}", request.UploadId);
            parameters[S3QueryParameter.ContentBody] = request.ContentXML;
            parameters[S3QueryParameter.ContentType] = "application/xml";


            // Finally, add the S3 specific parameters and headers
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         * Convert SetBucketLoggingRequest for enable logging, to key/value pairs.
         */
        private void ConvertUploadPart(UploadPartRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "UploadPart";
            parameters[S3QueryParameter.Key] = request.Key;
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = string.Format("?partNumber={1}&uploadId={0}", request.UploadId, request.PartNumber);

            if (request.IsSetMD5Digest())
            {
                webHeaders[AWSSDKUtils.ContentMD5Header] = request.MD5Digest;
            }
            else if (request.GenerateMD5Digest)
            {
                string checksum = null;
                if (request.IsSetInputStream())
                {
                    checksum = AmazonS3Util.GenerateChecksumForStream(request.InputStream, true);
                }

                webHeaders[AWSSDKUtils.ContentMD5Header] = checksum;
            }

            // InputStream is a PartStreamWrapper that will take care of computing the length for the part.
            parameters[S3QueryParameter.ContentLength] = request.InputStream.Length.ToString();

            // Finally, add the S3 specific parameters and headers
            request.RequestDestinationBucket = request.BucketName;
        }

        /**
        * Convert CopyPartRequest for enable logging, to key/value pairs.
        */
        private void ConvertCopyPart(CopyPartRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "CopyPart";
            parameters[S3QueryParameter.Key] = request.DestinationKey;
            parameters[S3QueryParameter.Query] = parameters[S3QueryParameter.QueryToSign] = string.Format("?partNumber={1}&uploadId={0}", request.UploadID, request.PartNumber);

            // Add the Copy Source header
            setCopySourceHeader(webHeaders, request.SourceBucket, request.SourceKey, request.SourceVersionId);

            // Add the copy range header
            if (request.IsSetFirstByte() && request.IsSetLastByte())
            {
                setCopySourceRangeHeader(webHeaders, request.FirstByte, request.LastByte);
            }

            // Add the conditional copy headers to the request
            if (request.IsSetETagToMatch())
            {
                setIfMatchCopyHeader(webHeaders, AWSSDKUtils.Join(request.ETagToMatch));
            }
            if (request.IsSetETagToNotMatch())
            {
                setIfNoneMatchCopyHeader(webHeaders, AWSSDKUtils.Join(request.ETagsToNotMatch));
            }
            if (request.IsSetModifiedSinceDate())
            {
                setIfModifiedSinceCopyHeader(webHeaders, request.ModifiedSinceDate);
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                setIfUnmodifiedSinceCopyHeader(webHeaders, request.UnmodifiedSinceDate);
            }

            // Add server side encryption
            if (request.ServerSideEncryptionMethod != ServerSideEncryptionMethod.None)
            {
                webHeaders[S3Constants.AmzServerSideEncryptionHeader] = request.ServerSideEncryptionMethod.ToString();
            }

            // Finally, add the S3 specific parameters and headers
            request.RequestDestinationBucket = request.DestinationBucket;
        }

        /**
         * Convert DeleteObjectsRequest to key/value pairs.
         */
        private void ConvertDeleteObjects(DeleteObjectsRequest request)
        {
            WebHeaderCollection webHeaders = request.Headers;
            Map parameters = request.parameters;

            string content = request.ContentXML;
            string queryStr = "?delete";
            parameters[S3QueryParameter.Action] = "DeleteObjects";
            parameters[S3QueryParameter.Verb] = S3Constants.PostVerb;
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;
            parameters[S3QueryParameter.ContentBody] = content;
            parameters[S3QueryParameter.ContentType] = "application/xml";

            string checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
            webHeaders[AWSSDKUtils.ContentMD5Header] = checksum;
            request.RequestDestinationBucket = request.BucketName;

            if (request.IsSetMfaCodes())
            {
                setMfaHeader(request.Headers, request.MfaCodes);
            }
        }

        /**
         *  Convert PutLifecycleConfigurationRequest to key/value pairs.
         */
        private void ConvertPutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "PutLifecycleConfiguration";

            string queryStr = "?lifecycle";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            string content = request.ContentXML;
            parameters[S3QueryParameter.ContentBody] = content;
            parameters[S3QueryParameter.ContentType] = "application/xml";

            string checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
            webHeaders[AWSSDKUtils.ContentMD5Header] = checksum;

            request.RequestDestinationBucket = request.BucketName;
        }
        /**
         *  Convert GetLifecycleConfigurationRequest to key/value pairs.
         */
        private void ConvertGetLifecycleConfiguration(GetLifecycleConfigurationRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetLifecycleConfiguration";

            string queryStr = "?lifecycle";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            request.RequestDestinationBucket = request.BucketName;
        }
        /**
         *  Convert DeleteLifecycleConfigurationRequest to key/value pairs.
         */
        private void ConvertDeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "DeleteLifecycleConfiguration";

            string queryStr = "?lifecycle";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         *  Convert PutLifecycleConfigurationRequest to key/value pairs.
         */
        private void ConvertRestoreObject(RestoreObjectRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PostVerb;
            parameters[S3QueryParameter.Action] = "RestoreObject";
            parameters[S3QueryParameter.Key] = request.Key;

            string queryStr = "?restore";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            string content = request.ContentXML;
            parameters[S3QueryParameter.ContentBody] = content;
            parameters[S3QueryParameter.ContentType] = "application/xml";

            string checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
            webHeaders[AWSSDKUtils.ContentMD5Header] = checksum;

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         *  Convert ConvertPutBucketTagging to key/value pairs.
         */
        private void ConvertPutBucketTagging(PutBucketTaggingRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "PutBucketTagging";

            string queryStr = "?tagging";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            string content = request.ContentXML;
            parameters[S3QueryParameter.ContentBody] = content;
            parameters[S3QueryParameter.ContentType] = "application/xml";

            string checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
            webHeaders[AWSSDKUtils.ContentMD5Header] = checksum;

            request.RequestDestinationBucket = request.BucketName;
        }
        /**
         *  Convert ConvertGetBucketTagging to key/value pairs.
         */
        private void ConvertGetBucketTagging(GetBucketTaggingRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetBucketTagging";

            string queryStr = "?tagging";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            request.RequestDestinationBucket = request.BucketName;
        }
        /**
         *  Convert ConvertDeleteBucketTagging to key/value pairs.
         */
        private void ConvertDeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "DeleteLifecycleConfiguration";

            string queryStr = "?tagging";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            request.RequestDestinationBucket = request.BucketName;
        }

        /**
         *  Convert PutCORSConfigurationRequest to key/value pairs.
         */
        private void ConvertPutCORSConfiguration(PutCORSConfigurationRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "PutCORSConfiguration";

            string queryStr = "?cors";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            string content = request.ContentXML;
            parameters[S3QueryParameter.ContentBody] = content;
            parameters[S3QueryParameter.ContentType] = "application/xml";

            string checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
            webHeaders[AWSSDKUtils.ContentMD5Header] = checksum;

            request.RequestDestinationBucket = request.BucketName;
        }
        /**
         *  Convert GetCORSConfigurationRequest to key/value pairs.
         */
        private void ConvertGetCORSConfiguration(GetCORSConfigurationRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.GetVerb;
            parameters[S3QueryParameter.Action] = "GetCORSConfiguration";

            string queryStr = "?cors";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            request.RequestDestinationBucket = request.BucketName;
        }
        /**
         *  Convert DeleteCORSConfigurationRequest to key/value pairs.
         */
        private void ConvertDeleteCORSConfiguration(DeleteCORSConfigurationRequest request)
        {
            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "DeleteCORSConfiguration";

            string queryStr = "?cors";
            parameters[S3QueryParameter.Query] = queryStr;
            parameters[S3QueryParameter.QueryToSign] = queryStr;

            request.RequestDestinationBucket = request.BucketName;
        }

        #endregion

        #region Private Methods

        T endOperation<T>(IAsyncResult result) where T : class
        {
            S3AsyncResult s3AsyncResult = result as S3AsyncResult;
            if (s3AsyncResult == null)
                return default(T);

            if (!s3AsyncResult.IsCompleted)
            {
                s3AsyncResult.AsyncWaitHandle.WaitOne();
            }

            if (s3AsyncResult.Exception != null)
            {
                AWSSDKUtils.PreserveStackTrace(s3AsyncResult.Exception);
                throw s3AsyncResult.Exception;
            }

            T response = s3AsyncResult.FinalResponse as T;
            //s3AsyncResult.FinalResponse = null;
            return response;
        }

        void invoke<T>(S3AsyncResult s3AsyncResult) where T : S3Response, new()
        {
            invoke<T>(s3AsyncResult, false);
        }

        void invoke<T>(S3AsyncResult s3AsyncResult, bool isRedirect) where T : S3Response, new()
        {
            if (s3AsyncResult.S3Request == null)
            {
                throw new AmazonS3Exception("No request specified for the S3 operation!");
            }

            string userAgent = config.UserAgent + " " + (s3AsyncResult.CompletedSynchronously ? "S3Sync" : "S3Async");
            s3AsyncResult.S3Request.Headers[AWSSDKUtils.UserAgentHeader] = userAgent;

            ProcessRequestHandlers(s3AsyncResult.S3Request);
                        
            ImmutableCredentials immutableCredentials = credentials == null || credentials is AnonymousAWSCredentials ? null : credentials.GetCredentials();
            try
            {
                if (!isRedirect)
                {
                    addS3QueryParameters(s3AsyncResult.S3Request, immutableCredentials);
                }

                WebHeaderCollection headers = s3AsyncResult.S3Request.Headers;
                Map parameters = s3AsyncResult.S3Request.parameters;
                Stream fStream = s3AsyncResult.S3Request.InputStream;

                // if credentials are present (non-anonymous) sign the request
                if (immutableCredentials != null)
                {
                    string toSign = buildSigningString(parameters, headers);
                    string auth;
                    if (immutableCredentials.UseSecureStringForSecretKey)
                    {
                        KeyedHashAlgorithm algorithm = new HMACSHA1();
                        auth = AWSSDKUtils.HMACSign(toSign, immutableCredentials.SecureSecretKey, algorithm);
                    }
                    else
                    {
                        KeyedHashAlgorithm algorithm = new HMACSHA1();
                        auth = AWSSDKUtils.HMACSign(toSign, immutableCredentials.ClearSecretKey, algorithm);
                    }
                    parameters[S3QueryParameter.Authorization] = auth;
                }

                string actionName = parameters[S3QueryParameter.Action];
                string verb = parameters[S3QueryParameter.Verb];

                LOGGER.DebugFormat("Starting request (id {0}) for {0}", s3AsyncResult.S3Request.Id, actionName);

                // Variables that pertain to PUT requests
                byte[] requestData = Encoding.UTF8.GetBytes("");
                long reqDataLen = 0;

                validateVerb(verb);

                if (verb.Equals(S3Constants.PutVerb) || verb.Equals(S3Constants.PostVerb))
                {
                    if (parameters.ContainsKey(S3QueryParameter.ContentBody))
                    {
                        string reqBody = parameters[S3QueryParameter.ContentBody];
                        s3AsyncResult.S3Request.BytesProcessed = reqBody.Length;
                        LOGGER.DebugFormat("Request (id {0}) body's length [{1}]", s3AsyncResult.S3Request.Id, reqBody.Length);
                        requestData = Encoding.UTF8.GetBytes(reqBody);

                        // Since there is a request body, determine the length of the
                        // data that will be sent to the server.
                        reqDataLen = requestData.Length;
                        parameters[S3QueryParameter.ContentLength] = reqDataLen.ToString();
                    }

                    if (parameters.ContainsKey(S3QueryParameter.ContentLength))
                    {
                        reqDataLen = Int64.Parse(parameters[S3QueryParameter.ContentLength]);
                    }
                }

                int maxRetries = config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : AWSSDKUtils.DefaultMaxRetry;

                if (fStream != null)
                {
                    s3AsyncResult.OrignalStreamPosition = fStream.Position;
                }

                HttpWebRequest request = configureWebRequest(s3AsyncResult.S3Request, reqDataLen, immutableCredentials);

                parameters[S3QueryParameter.RequestAddress] = request.Address.ToString();

                try
                {
                    s3AsyncResult.RequestState = new RequestState(request, parameters, fStream, requestData, reqDataLen, s3AsyncResult.S3Request.ElapsedTicks);
                    if (reqDataLen > 0)
                    {
                        if (s3AsyncResult.CompletedSynchronously)
                        {
                            this.getRequestStreamCallback<T>(s3AsyncResult);
                        }
                        else
                        {
                            IAsyncResult httpResult = request.BeginGetRequestStream(new AsyncCallback(this.getRequestStreamCallback<T>), s3AsyncResult);
                            if (httpResult.CompletedSynchronously)
                            {
                                if (!s3AsyncResult.RequestState.GetRequestStreamCallbackCalled)
                                {
                                    getRequestStreamCallback<T>(httpResult);
                                }
                                s3AsyncResult.SetCompletedSynchronously(true);
                            }
                        }
                    }
                    else
                    {
                        if (s3AsyncResult.CompletedSynchronously)
                        {
                            this.getResponseCallback<T>(s3AsyncResult);
                        }
                        else
                        {
                            IAsyncResult httpResult = request.BeginGetResponse(new AsyncCallback(this.getResponseCallback<T>), s3AsyncResult);
                            if (httpResult.CompletedSynchronously)
                            {
                                if (!s3AsyncResult.RequestState.GetResponseCallbackCalled)
                                {
                                    getResponseCallback<T>(httpResult);
                                }
                                s3AsyncResult.SetCompletedSynchronously(true);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    LOGGER.Error(e, "Error starting async http operation");
                    throw;
                }
            }
            finally
            {
                if (immutableCredentials != null)
                {
                    immutableCredentials.Dispose();
                }
            }
        }

        void validateVerb(string verb)
        {
            // The HTTP operation specified has to be one of the operations
            // the Amazon S3 service explicitly supports
            if (!(verb.Equals(S3Constants.PutVerb) ||
                verb.Equals(S3Constants.GetVerb) ||
                verb.Equals(S3Constants.DeleteVerb) ||
                verb.Equals(S3Constants.HeadVerb) ||
                verb.Equals(S3Constants.PostVerb)))
            {
                throw new AmazonS3Exception("Invalid HTTP Operation attempted! Supported operations - GET, HEAD, PUT, DELETE, POST");
            }
        }

        void getRequestStreamCallback<T>(IAsyncResult result) where T : S3Response, new()
        {
            S3AsyncResult s3AsyncResult;
            if (result is S3AsyncResult)
                s3AsyncResult = result as S3AsyncResult;
            else
                s3AsyncResult = result.AsyncState as S3AsyncResult;

            s3AsyncResult.RequestState.GetRequestStreamCallbackCalled = true;
            try
            {
                RequestState state = s3AsyncResult.RequestState;
                bool shouldRetry = false;
                try
                {
                    Stream requestStream;
                    if (s3AsyncResult.CompletedSynchronously)
                        requestStream = state.WebRequest.GetRequestStream();
                    else
                        requestStream = state.WebRequest.EndGetRequestStream(result);

                    using (requestStream)
                    {
                        Stream stream = state.InputStream != null ? state.InputStream : new MemoryStream(state.RequestData);
                        writeStreamToService(s3AsyncResult.S3Request, state.RequestDataLength, stream, requestStream);
                    }
                }
                catch (IOException e)
                {
                    shouldRetry = handleIOException(s3AsyncResult.S3Request, s3AsyncResult.RequestState.WebRequest, null, e, s3AsyncResult.RetriesAttempt);
                }

                if (shouldRetry)
                {
                    s3AsyncResult.RetriesAttempt++;
                    handleRetry(s3AsyncResult.S3Request, s3AsyncResult.RequestState.WebRequest, null, s3AsyncResult.OrignalStreamPosition,
                        s3AsyncResult.RetriesAttempt, HttpStatusCode.OK, null);
                    invoke<T>(s3AsyncResult);
                }
                else
                {
                    if (s3AsyncResult.CompletedSynchronously)
                    {
                        this.getResponseCallback<T>(s3AsyncResult);
                    }
                    else
                    {
                        IAsyncResult httpResult = state.WebRequest.BeginGetResponse(new AsyncCallback(this.getResponseCallback<T>), s3AsyncResult);
                        if (httpResult.CompletedSynchronously)
                        {
                            if (!s3AsyncResult.RequestState.GetResponseCallbackCalled)
                            {
                                getResponseCallback<T>(httpResult);
                            }
                            s3AsyncResult.SetCompletedSynchronously(true);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                s3AsyncResult.RequestState.WebRequest.Abort();
                LOGGER.Error(e, "Error for GetRequestStream");
                s3AsyncResult.Exception = e;

                s3AsyncResult.SignalWaitHandle();
                if (s3AsyncResult.Callback != null)
                    s3AsyncResult.Callback(s3AsyncResult);
            }
        }

        void getResponseCallback<T>(IAsyncResult result) where T : S3Response, new()
        {
            S3AsyncResult s3AsyncResult;
            if (result is S3AsyncResult)
                s3AsyncResult = result as S3AsyncResult;
            else
                s3AsyncResult = result.AsyncState as S3AsyncResult;

            s3AsyncResult.RequestState.GetResponseCallbackCalled = true;
            bool shouldRetry = false;
            try
            {
                Exception cause = null;
                HttpStatusCode statusCode = HttpStatusCode.OK;
                RequestState state = s3AsyncResult.RequestState;
                HttpWebResponse httpResponse = null;
                T response = null;
                try
                {
                    if (s3AsyncResult.CompletedSynchronously)
                        httpResponse = state.WebRequest.GetResponse() as HttpWebResponse;
                    else
                        httpResponse = state.WebRequest.EndGetResponse(result) as HttpWebResponse;

                    long lengthOfRequest = s3AsyncResult.S3Request.ElapsedTicks - state.WebRequestStart;
                    s3AsyncResult.S3Request.ResponseTime = lengthOfRequest;
                    shouldRetry = handleHttpResponse<T>(
                        s3AsyncResult.S3Request,
                        state.WebRequest,
                        httpResponse,
                        s3AsyncResult.RetriesAttempt,
                        lengthOfRequest,
                        out response, out cause, out statusCode);
                    if (!shouldRetry)
                    {
                        s3AsyncResult.FinalResponse = response;
                    }
                }
                catch (WebException we)
                {
                    shouldRetry = handleHttpWebErrorResponse(s3AsyncResult.S3Request, we, s3AsyncResult.RequestState.WebRequest, httpResponse, out cause, out statusCode);
                }
                catch (IOException e)
                {
                    shouldRetry = handleIOException(s3AsyncResult.S3Request, s3AsyncResult.RequestState.WebRequest, httpResponse, e, s3AsyncResult.RetriesAttempt);
                }

                if (shouldRetry)
                {
                    s3AsyncResult.RetriesAttempt++;
                    WebHeaderCollection respHeaders = null;
                    if (response != null)
                    {
                        respHeaders = response.Headers;
                    }

                    handleRetry(s3AsyncResult.S3Request, s3AsyncResult.RequestState.WebRequest, respHeaders, s3AsyncResult.OrignalStreamPosition,
                        s3AsyncResult.RetriesAttempt, statusCode, cause);

                    invoke<T>(s3AsyncResult, (httpResponse == null) ? false : isRedirect(httpResponse));
                }
                else if (cause != null)
                {
                    s3AsyncResult.Exception = cause;
                }
            }
            catch (Exception e)
            {
                LOGGER.Error(e, "Error for GetResponse");
                s3AsyncResult.Exception = e;
                shouldRetry = false;
            }
            finally
            {
                if (!shouldRetry)
                {
                    s3AsyncResult.SignalWaitHandle();
                    if (s3AsyncResult.Callback != null)
                        s3AsyncResult.Callback(s3AsyncResult);
                }
            }
        }

        /**
         * Add authentication related and version parameters
         */
        void addS3QueryParameters(S3Request request, ImmutableCredentials immutableCredentials)
        {
            if (request == null)
            {
                return;
            }

            string destinationBucket = request.RequestDestinationBucket;

            Map parameters = request.parameters;
            WebHeaderCollection webHeaders = request.Headers;

            if (webHeaders != null)
            {
                webHeaders[S3Constants.AmzDateHeader] = AmazonS3Util.FormattedCurrentTimestamp;
            }

            StringBuilder canonicalResource = new StringBuilder("/", 512);
            if (!String.IsNullOrEmpty(destinationBucket))
            {
                parameters[S3QueryParameter.DestinationBucket] = destinationBucket;
                if (AmazonS3Util.ValidateV2Bucket(destinationBucket))
                {
                    parameters[S3QueryParameter.BucketVersion] = S3Constants.BucketVersions[2];
                }
                else
                {
                    parameters[S3QueryParameter.BucketVersion] = S3Constants.BucketVersions[1];
                }
                canonicalResource.Append(destinationBucket);
                if (!destinationBucket.EndsWith("/"))
                {
                    canonicalResource.Append("/");
                }
            }
            else
            {
                // If there is no destination bucket specified, just use V2.
                parameters[S3QueryParameter.BucketVersion] = S3Constants.BucketVersions[2];
            }

            // The canonical resource doesn't need the query because it is added
            // in the configureWebRequest function directly to the URL
            if (parameters.ContainsKey(S3QueryParameter.Key))
            {
                canonicalResource.Append(parameters[S3QueryParameter.Key]);
            }

            parameters[S3QueryParameter.CanonicalizedResource] = canonicalResource.ToString();

            // Has the user added the Content-Type header to the request?
            string value = webHeaders[AWSSDKUtils.ContentTypeHeader];
            if (!String.IsNullOrEmpty(value))
            {
                // Remove the header from the webHeaders collection
                // and add it to the parameters
                parameters[S3QueryParameter.ContentType] = value;
                webHeaders.Remove(AWSSDKUtils.ContentTypeHeader);
            }

            // Add token if available
            if (immutableCredentials != null && immutableCredentials.UseToken ) 
            {
                webHeaders[S3Constants.AmzSecurityTokenHeader] = immutableCredentials.Token;
            }

            // Insert the S3 Url into the parameters
            addUrlToParameters(request, config);
        }

        void writeStreamToService(S3Request request, long reqDataLen, Stream inputStream, Stream requestStream)
        {
            if (inputStream != null)
            {
                long current = 0;
                // Reset the file stream's position to the starting point
                inputStream.Position = 0;
                byte[] buffer = new byte[this.config.BufferSize];
                int bytesRead = 0;
                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    current += bytesRead;
                    requestStream.Write(buffer, 0, bytesRead);
                    if (request != null)
                    {
                        request.OnRaiseProgressEvent(bytesRead, current, reqDataLen);
                    }
                }
            }
        }


        void handleRetry(S3Request userRequest, HttpWebRequest request, WebHeaderCollection respHdrs, long orignalStreamPosition, int retries, HttpStatusCode statusCode, Exception cause)
        {
            string actionName = userRequest.parameters[S3QueryParameter.Action];
            string requestAddr = request.Address.ToString();

            if (retries <= this.config.MaxErrorRetry)
            {
                LOGGER.InfoFormat("Retry number {0} for request {1}.", retries, actionName);
            }
            long pauseStart = userRequest.ElapsedTicks;
            pauseOnRetry(retries, this.config.MaxErrorRetry, statusCode, requestAddr, respHdrs, cause);
            userRequest.PauseTime += (userRequest.ElapsedTicks - pauseStart);

            // Reset the request so that streams are recreated,
            // removed headers are added back, etc
            prepareRequestForRetry(userRequest, orignalStreamPosition);
        }

        bool handleIOException(S3Request userRequest, HttpWebRequest request, HttpWebResponse httpResponse, IOException e, int retries)
        {
            if (isInnerExceptionThreadAbort(e))
                throw e;

            string actionName = userRequest.parameters[S3QueryParameter.Action];
            LOGGER.Error(e, "Error making request {0}.", actionName);
            if (httpResponse != null)
            {
                httpResponse.Close();
                httpResponse = null;
            }
            // Abort the unsuccessful request
            request.Abort();

            return retries <= this.config.MaxErrorRetry;
        }

        bool isInnerExceptionThreadAbort(Exception e)
        {
            if (e.InnerException is ThreadAbortException)
                return true;
            if (e.InnerException != null)
                return isInnerExceptionThreadAbort(e.InnerException);
            return false;
        }

        bool handleHttpWebErrorResponse(S3Request userRequest, WebException we, HttpWebRequest request, HttpWebResponse httpResponse, out Exception cause, out HttpStatusCode statusCode)
        {
            WebHeaderCollection respHdrs;
            string actionName = userRequest.parameters[S3QueryParameter.Action];
            string requestAddr = request.Address.ToString();

            LOGGER.Debug(we, "Error making request {0}.", actionName);

            bool shouldRetry;
            using (HttpWebResponse errorResponse = we.Response as HttpWebResponse)
            {
                if (errorResponse != null)
                    shouldRetry = processRequestError(actionName, request, we, errorResponse, requestAddr, out respHdrs, typeof(AmazonS3Client), out cause);
                else
                {
                    shouldRetry = true;
                    cause = we;
                }

                if (httpResponse != null)
                {
                    httpResponse.Close();
                    httpResponse = null;
                }
                // Abort the unsuccessful request regardless of whether we should
                // or shouldn't retry.
                request.Abort();

                if (errorResponse != null)
                {
                    statusCode = errorResponse.StatusCode;
                }
                else
                {
                    statusCode = HttpStatusCode.BadRequest;
                }
            }

            return shouldRetry;
        }

        bool handleHttpResponse<T>(S3Request userRequest, HttpWebRequest request, HttpWebResponse httpResponse,
            int retries,
            long lengthOfRequest, out T response, out Exception cause, out HttpStatusCode statusCode)
            where T : S3Response, new()
        {
            response = null;
            cause = null;
            WebHeaderCollection respHdrs = httpResponse.Headers;
            statusCode = httpResponse.StatusCode;
            Map parameters = userRequest.parameters;
            string actionName = parameters[S3QueryParameter.Action];
            string requestAddr = request.Address.ToString();

            bool shouldRetry;
            respHdrs = httpResponse.Headers;
            LOGGER.InfoFormat("Received response for {0} (id {1}) with status code {2} in {3}.", actionName, userRequest.Id, httpResponse.StatusCode, lengthOfRequest);

            statusCode = httpResponse.StatusCode;

            if (!isRedirect(httpResponse))
            {
                // The request submission has completed. Retrieve the response.
                shouldRetry = processRequestResponse<T>(httpResponse, userRequest, myType, out response, out cause);
            }
            else
            {
                if (httpResponse != null && string.IsNullOrEmpty(httpResponse.Headers["Location"]))
                {
                    throw new WebException(
                        "A redirect was returned without a new location.  This can be caused by attempting to access buckets with periods in the name in a different region then the client is configured for.",
                        WebExceptionStatus.ProtocolError
                        );
                }

                shouldRetry = true;

                processRedirect(userRequest, httpResponse);
                LOGGER.InfoFormat("Request for {0} is being redirect to {1}.", actionName, userRequest.parameters[S3QueryParameter.Url]);

                long pauseStart = userRequest.ElapsedTicks;
                pauseOnRetry(retries + 1, this.config.MaxErrorRetry, statusCode, requestAddr, httpResponse.Headers, cause);
                userRequest.PauseTime += (userRequest.ElapsedTicks - pauseStart);

                // The HTTPResponse object needs to be closed. Once this is done, the request
                // is gracefully terminated. Mind you, if this response object is not closed,
                // the client will start getting timeout errors.
                // P.S. This sequence of close-response followed by abort-request
                // will be repeated through the exception handlers for this try block
                httpResponse.Close();
                httpResponse = null;
                request.Abort();
            }

            return shouldRetry;
        }

        static void processRedirect(S3Request userRequest, HttpWebResponse httpResponse)
        {
            if (httpResponse == null)
            {
                throw new WebException(
                    "The Web Response for a redirected request is null!",
                    WebExceptionStatus.ProtocolError
                    );
            }

            // This is a redirect. Get the URL from the location header
            WebHeaderCollection respHeaders = httpResponse.Headers;
            string value;
            if (!String.IsNullOrEmpty(value = respHeaders["Location"]))
            {
                // This should be the new location for the request
                userRequest.parameters[S3QueryParameter.Url] = value;
            }
        }

        static bool isRedirect(HttpWebResponse httpResponse)
        {
            if (httpResponse == null)
            {
                throw new ArgumentNullException("httpResponse", "Input parameter is null");
            }

            HttpStatusCode statusCode = httpResponse.StatusCode;

            if (statusCode == HttpStatusCode.NotModified)
                return false;

            return (statusCode >= HttpStatusCode.MovedPermanently &&
                statusCode < HttpStatusCode.BadRequest);
        }

        /*
         * 1. Add removed headers back to the request's headers
         * 2. If the InputStream is not-null, reset its position to 0
         */
        void prepareRequestForRetry(S3Request request, long orignalStreamPosition)
        {
            if (request.InputStream != null)
            {
                request.InputStream.Position = orignalStreamPosition;
            }

            if (request.removedHeaders.Count > 0)
            {
                request.Headers.Add(request.removedHeaders);
            }
        }

        bool processRequestResponse<T>(HttpWebResponse httpResponse, S3Request request, Type t, out T response, out Exception cause)
            where T : S3Response, new()
        {
            response = default(T);
            cause = null;
            IDictionary<S3QueryParameter, string> parameters = request.parameters;
            string actionName = parameters[S3QueryParameter.Action];
            bool shouldRetry = false;

            if (httpResponse == null)
            {
                throw new WebException(
                    "The Web Response for a successful request is null!",
                    WebExceptionStatus.ProtocolError
                    );
            }

            WebHeaderCollection headerCollection = httpResponse.Headers;
            HttpStatusCode statusCode = httpResponse.StatusCode;
            string responseBody = null;
            bool hasError = false;

            try
            {
                if (actionName.Equals("GetObject"))
                {
                    response = new T();
                    Stream respStr = httpResponse.GetResponseStream();
                    request.BytesProcessed = httpResponse.ContentLength;

                    if (parameters.ContainsKey(S3QueryParameter.VerifyChecksum))
                    {
                        try
                        {
                            // The md5Digest needs to be verified
                            string checksumFromS3 = headerCollection[AWSSDKUtils.ETagHeader];
                            checksumFromS3 = checksumFromS3.Replace("\"", String.Empty);
                            if (respStr.CanSeek)
                            {
                                response.ResponseStream = respStr;
                            }
                            else
                            {
                                response.ResponseStream = AmazonS3Util.MakeStreamSeekable(respStr);
                            }
                            string calculatedCS = AmazonS3Util.GenerateChecksumForStream(response.ResponseStream, false);

                            // do a case-insensitive comparison of the 2 strings.
                            if (0 != StringComparer.OrdinalIgnoreCase.Compare(calculatedCS, checksumFromS3))
                            {
                                string msg = String.Concat(
                                    "The calculated md5Digest '",
                                    calculatedCS,
                                    "' differs from the md5Digest returned by S3 '",
                                    checksumFromS3
                                    );

                                throw new AmazonS3Exception(
                                    msg,
                                    HttpStatusCode.BadRequest,
                                    "BadDigest",
                                    "",
                                    "",
                                    "",
                                    parameters[S3QueryParameter.RequestAddress],
                                    headerCollection
                                    );
                            }
                        }
                        catch (Exception)
                        {
                            // Handle this error gracefully by setting the response object
                            // to be null. The outer finally block will catch the exception
                            // and close the httpResponse if the response object is null
                            response = null;
                            throw;
                        }
                    }
                    else
                    {
                        response.ResponseStream = respStr;
                    }
                }
                else
                {
                    using (httpResponse)
                    {
                        long streamRead = request.ElapsedTicks;

                        using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }

                        request.BytesProcessed = responseBody.Length;
                        responseBody = responseBody.Trim();

                        if (responseBody.EndsWith("/Error>"))
                        {
                            // Even though we received a 200 OK, there is a possibility of receiving an error
                            string transformed = transform(responseBody, "S3Error", t);
                            // Attempt to deserialize response into S3ErrorResponse type
                            S3Error error;
                            XmlSerializer serializer = new XmlSerializer(typeof(S3Error));
                            using (XmlTextReader sr = new XmlTextReader(new StringReader(transformed)))
                            {
                                error = (S3Error)serializer.Deserialize(sr);
                            }
                            cause = new AmazonS3Exception(statusCode, responseBody, parameters[S3QueryParameter.RequestAddress], headerCollection, error);
                            shouldRetry = true;
                        }

                        // Perform response transformation
                        else if (responseBody.EndsWith(">"))
                        {
                            string transformed = transform(responseBody, actionName, t);

                            long streamParsed = request.ElapsedTicks;

                            // Attempt to deserialize response into <Action> Response type
                            XmlSerializer serializer = new XmlSerializer(typeof(T));
                            using (XmlTextReader sr = new XmlTextReader(new StringReader(transformed)))
                            {
                                response = (T)serializer.Deserialize(sr);
                            }
                            long objectCreated = request.ElapsedTicks;
                            request.ResponseReadTime = streamParsed - streamRead;
                            request.ResponseProcessingTime = objectCreated - streamParsed;
                            LOGGER.InfoFormat("Done reading response stream for request (id {0}). Stream read: {1}. Object create: {2}. Length of body: {3}",
                                request.Id,
                                request.ResponseReadTime,
                                request.ResponseProcessingTime,
                                request.BytesProcessed);
                        }
                        else
                        {
                            // We can receive responses that have no response body.
                            // All responses have headers so at a future point,
                            // we "do" attach the headers to the response.
                            response = new T();
                            response.ProcessResponseBody(responseBody);

                            long streamParsed = request.ElapsedTicks;
                            request.ResponseReadTime = streamParsed - streamRead;
                        }
                    }

                    // We are done with our use of the httpResponse object
                    httpResponse = null;
                }
            }
            catch (Exception e)
            {
                hasError = true;
                if (AWSConfigs.ResponseLogging == ResponseLoggingOption.OnError)
                    LOGGER.Error(e, "Received response: [{0}]", responseBody);
                throw;
            }
            finally
            {
                if (actionName.Equals("GetObject") &&
                    response != null)
                {
                    // Save the http response object so that it can be closed
                    // gracefully when the GetObjectResponse object is either
                    // garbage-collected or disposed
                    response.httpResponse = httpResponse;
                }
                else if (httpResponse != null)
                {
                    httpResponse.Close();
                    httpResponse = null;
                }

                // Store the headers in the response for all successful service requests
                if (response != null)
                {
                    // Add the header key/value pairs to our <Action> Response type
                    response.Headers = headerCollection;
                    response.ResponseXml = responseBody;
                }

                // log only if no error was encountered and ResponseLogging == Always
                if (!hasError && AWSConfigs.ResponseLogging == ResponseLoggingOption.Always)
                {
                    LOGGER.DebugFormat("Received response: [{0}]", responseBody);
                }
            }

            return shouldRetry;
        }

        private bool processRequestError(string actionName, HttpWebRequest request, WebException we, HttpWebResponse errorResponse, string requestAddr, out WebHeaderCollection respHdrs, Type t, out Exception cause)
        {
            bool shouldRetry = false;
            HttpStatusCode statusCode = default(HttpStatusCode);
            string responseBody = null;

            // Initialize the out parameter to null
            // in case there is no errorResponse
            respHdrs = null;

            if (errorResponse == null)
            {
                LOGGER.Error(we, "Error making request {0}.", actionName);
                throw we;
            }

            // Set the response headers for future use
            respHdrs = errorResponse.Headers;

            // Obtain the HTTP status code
            statusCode = errorResponse.StatusCode;

            using (StreamReader reader = new StreamReader(errorResponse.GetResponseStream(), Encoding.UTF8))
            {
                responseBody = reader.ReadToEnd();
            }

            if (request.Method.Equals("HEAD"))
            {
                string message = we.Message;
                string errorCode = statusCode.ToString();
                if (statusCode == HttpStatusCode.NotFound)
                {
                    message = "The specified key does not exist";
                    errorCode = "NoSuchKey";
                }

                AmazonS3Exception excep = new AmazonS3Exception(
                    message,
                    statusCode,
                    errorCode,
                    respHdrs[S3Constants.AmzRequestIdHeader],
                    "",
                    "",
                    requestAddr,
                    respHdrs
                    );

                if (AWSConfigs.ResponseLogging == ResponseLoggingOption.OnError)
                    LOGGER.Error(excep, "Received response: [{0}]", responseBody);

                LOGGER.Error(excep, "Error making request {0}.", actionName);
                throw excep;
            }

            if (statusCode == HttpStatusCode.InternalServerError ||
                statusCode == HttpStatusCode.ServiceUnavailable)
            {
                if (AWSConfigs.ResponseLogging == ResponseLoggingOption.OnError)
                    LOGGER.Error(we, "Received response: [{0}]", responseBody);
                shouldRetry = true;
                cause = we;
            }
            else
            {
                // Attempt to deserialize response into ErrorResponse type
                using (XmlTextReader sr = new XmlTextReader(new StringReader(transform(responseBody, "S3Error", t))))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(S3Error));
                    S3Error error = (S3Error)serializer.Deserialize(sr);

                    // Throw formatted exception with information available from the error response
                    AmazonS3Exception excep = new AmazonS3Exception(
                        error.Message,
                        statusCode,
                        error.Code,
                        error.RequestId,
                        error.HostId,
                        responseBody,
                        requestAddr,
                        respHdrs
                        );

                    if (AWSConfigs.ResponseLogging == ResponseLoggingOption.OnError)
                        LOGGER.Error(excep, "Received response: [{0}]", responseBody);

                    LOGGER.Error(excep, "Error making request {0}.", actionName);
                    throw excep;
                }
            }

            return shouldRetry;
        }

        /**
         * Build the Url from the parameters passed in.
         * Component parts are:
         * - RegionEndpoint or ServiceURL from the Config
         * - Bucket
         * - Key
         * - urlPrefix
         * - Query
         */
        void addUrlToParameters(S3Request request, AmazonS3Config config)
        {
            Map parameters = request.parameters;

            if (!config.IsSetServiceURL())
            {
                throw new AmazonS3Exception("The Amazon S3 Service URL is either null or empty");
            }

            string url = determinedConfiguredServiceURL();

            if (parameters[S3QueryParameter.BucketVersion].Equals(S3Constants.BucketVersions[1]))
            {
                url = String.Concat(url, parameters[S3QueryParameter.CanonicalizedResource]);
            }
            else if (parameters.ContainsKey(S3QueryParameter.DestinationBucket))
            {
                string bucketName = parameters[S3QueryParameter.DestinationBucket];
                if (config.CommunicationProtocol == Protocol.HTTPS && bucketName.Contains("."))
                    url = String.Concat(url, "/", bucketName, "/");
                else
                    url = String.Concat(bucketName, ".", url, "/");

                if (parameters.ContainsKey(S3QueryParameter.Key))
                {
                    url = String.Concat(url, parameters[S3QueryParameter.Key]);
                }
            }

            string urlPrefix = "https://";
            if (config.CommunicationProtocol == Protocol.HTTP)
            {
                urlPrefix = "http://";
            }
            url = String.Concat(urlPrefix, url);

            // Encode the URL
            url = AmazonS3Util.UrlEncode(url, true);

            if (parameters.ContainsKey(S3QueryParameter.Query))
            {
                url = String.Concat(url, parameters[S3QueryParameter.Query]);
            }

            // Add the Url to the parameters
            parameters[S3QueryParameter.Url] = url;
        }

        string determinedConfiguredServiceURL()
        {
            string url;
            if (config.RegionEndpoint == null)
                url = config.ServiceURL;
            else
                url = config.RegionEndpoint.GetEndpointForService(config.RegionEndpointServiceName).Hostname;

            return url;
        }

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonEC2Config instance
         */
        HttpWebRequest configureWebRequest(S3Request request, long contentLength, ImmutableCredentials credentials)
        {
            WebHeaderCollection headers = request.Headers;
            Map parameters = request.parameters;

            if (!parameters.ContainsKey(S3QueryParameter.Url))
            {
                throw new AmazonS3Exception("The Amazon S3 URL is either null or empty");
            }

            string url = parameters[S3QueryParameter.Url];

            HttpWebRequest httpRequest = WebRequest.Create(url) as HttpWebRequest;

            if (request != null)
            {
                httpRequest.ServicePoint.ConnectionLimit = this.config.ConnectionLimit;
                ConfigureProxy(httpRequest);

                string value = headers[AWSSDKUtils.IfModifiedSinceHeader];
                if (!String.IsNullOrEmpty(value))
                {
                    DateTime date = DateTime.ParseExact(value, AWSSDKUtils.GMTDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToUniversalTime();
                    httpRequest.IfModifiedSince = date;
                    headers.Remove(AWSSDKUtils.IfModifiedSinceHeader);
                    request.removedHeaders[AWSSDKUtils.IfModifiedSinceHeader] = value;
                }

                // The Content-Type header could have been specified using
                // the S3Request.AddHeader method. If Content-Type was specified,
                // it needs to be removed and set as an explicit property
                // of the HttpWebRequest.
                value = headers[AWSSDKUtils.ContentTypeHeader];
                if (!String.IsNullOrEmpty(value))
                {
                    httpRequest.ContentType = value;
                    headers.Remove(AWSSDKUtils.ContentTypeHeader);
                    request.removedHeaders[AWSSDKUtils.ContentTypeHeader] = value;
                }

                // The User-Agent header could have been specified using
                // the S3Request.AddHeader method. If User-Agent was specified,
                // it needs to be removed and set as an explicit property
                // of the HttpWebRequest.
                value = headers[AWSSDKUtils.UserAgentHeader];
                if (!String.IsNullOrEmpty(value))
                {
                    httpRequest.UserAgent = value;
                    headers.Remove(AWSSDKUtils.UserAgentHeader);
                    request.removedHeaders[AWSSDKUtils.UserAgentHeader] = value;
                }

                if (parameters.ContainsKey(S3QueryParameter.ContentType))
                {
                    httpRequest.ContentType = parameters[S3QueryParameter.ContentType];
                }

                if (parameters.ContainsKey(S3QueryParameter.Range))
                {
                    string rangeHeader = parameters[S3QueryParameter.Range];
                    char[] splitter = { ':' };
                    string[] myRange = rangeHeader.Split(splitter);
                    addHttpRange(httpRequest, long.Parse(myRange[0]), long.Parse(myRange[1]));
                }

                // Add the AWS Authorization header.
                if (credentials != null && !string.IsNullOrEmpty(credentials.AccessKey))
                {
                    httpRequest.Headers[S3Constants.AuthorizationHeader] = String.Concat(
                        "AWS ",
                        credentials.AccessKey,
                        ":",
                        parameters[S3QueryParameter.Authorization]);
                }

                // Let's enable Expect100Continue only for PutObject requests
                httpRequest.ServicePoint.Expect100Continue = request.Expect100Continue;

                // While checking the Action, for Get, Put and Copy Object, set
                // the timeout to the value specified in the request.
                int timeout = request.Timeout;
                if (timeout > 0 || timeout == System.Threading.Timeout.Infinite)
                {
                    httpRequest.Timeout = timeout;
                    httpRequest.ReadWriteTimeout = timeout; // set both for backwards compatibility
                }

                // While checking the Action, for Get, Put and Copy Object, set
                // the read/write timeout to the value specified in the request.
                int readWriteTimeout = request.ReadWriteTimeout;
                if (readWriteTimeout > 0 || readWriteTimeout == System.Threading.Timeout.Infinite)
                {
                    httpRequest.ReadWriteTimeout = readWriteTimeout;
                }

                httpRequest.Headers.Add(headers);
                httpRequest.Method = parameters[S3QueryParameter.Verb];
                httpRequest.ContentLength = contentLength;
                httpRequest.AllowWriteStreamBuffering = false;
                httpRequest.AllowAutoRedirect = false;
            }
            return httpRequest;
        }

        internal void ConfigureProxy(HttpWebRequest httpRequest)
        {
            if (config.IsSetProxyHost() && config.IsSetProxyPort())
            {
                WebProxy proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                LOGGER.DebugFormat("Configured request to use proxy with host {0} and port {1}.", config.ProxyHost, config.ProxyPort);
                httpRequest.Proxy = proxy;
            }
            if (httpRequest.Proxy != null && config.IsSetProxyCredentials())
            {
                httpRequest.Proxy.Credentials = config.ProxyCredentials;
            }
        }

        /**
         * Exponential sleep on failed request
         */
        void pauseOnRetry(int retries, int maxRetries, HttpStatusCode status, string requestAddr, WebHeaderCollection headers, Exception cause)
        {
            if (retries <= maxRetries)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw new AmazonS3Exception(
                    String.Concat("Maximum number of retry attempts reached : ", (retries - 1)),
                    status,
                    requestAddr,
                    headers,
                    cause
                    );
            }
        }

        /*
         *  Transforms response based on xslt template
         */
        string transform(string responseBody, string actionName, Type t)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();
            char[] seps = { ',' };
            Assembly assembly = Assembly.GetAssembly(t);

            string assemblyName = assembly.FullName;
            assemblyName = assemblyName.Split(seps)[0];

            // Build the name of the xslt transform to apply to the response
            string ns = t.Namespace;
            string resourceName = String.Concat(
                assemblyName,
                ".",
                ns,
                ".Model.",
                actionName,
                "Response.xslt"
                );

            using (XmlTextReader xmlReader = new XmlTextReader(assembly.GetManifestResourceStream(resourceName)))
            {
                transformer.Load(xmlReader);

                using (XmlTextReader xmlR = new XmlTextReader(new StringReader(responseBody)))
                {
                    StringBuilder sb = new StringBuilder(1024);
                    using (StringWriter sw = new StringWriter(sb))
                    {
                        transformer.Transform(xmlR, null, sw);
                        return sb.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// Sets the header information to use a S3CannedACL.
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="acl">Enum for the type of canned acl wanted</param>
        void setCannedACLHeader(WebHeaderCollection headers, S3CannedACL acl)
        {
            headers[S3Constants.AmzAclHeader] = S3Constants.CannedAcls[(int)acl];
        }

        /// <summary>
        /// Sets the If-Match Header in the specified header collection.
        ///
        /// Return the object only if its entity tag (ETag) is the same as the one
        /// specified, otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="eTag">The ETag to match against</param>
        void setIfMatchHeader(WebHeaderCollection headers, string eTag)
        {
            headers[AWSSDKUtils.IfMatchHeader] = eTag;
        }

        /// <summary>
        /// Set the If-None-Match Header in the specified header collection.
        ///
        /// Return the object only if its entity tag (ETag) is different from the one
        /// specified, otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="eTag">The ETag to match against</param>
        void setIfNoneMatchHeader(WebHeaderCollection headers, string eTag)
        {
            headers["If-None-Match"] = eTag;
        }

        /// <summary>
        /// Sets the If-Modifed-Since Header in the specified header collection.
        ///
        /// Return the object only if it has been modified since the specified time,
        /// otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="date">DateTime Object representing the date to use</param>
        void setIfModifiedSinceHeader(WebHeaderCollection headers, DateTime date)
        {
            headers[AWSSDKUtils.IfModifiedSinceHeader] = date.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat);
        }

        /// <summary>
        /// Sets the If-Unmodifed-Since Header in the specified header collection.
        ///
        /// Return the object only if it has not been modified since the specified time,
        /// otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="date">DateTime Object representing the date to use</param>
        void setIfUnmodifiedSinceHeader(WebHeaderCollection headers, DateTime date)
        {
            headers["If-Unmodified-Since"] = date.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat);
        }

        /// <summary>
        /// Sets the If-Match Header for the CopyObject operation in the specified header collection.
        ///
        /// Return the object only if its entity tag (ETag) is the same as the one
        /// specified, otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="eTag">The ETag to match against</param>
        void setIfMatchCopyHeader(WebHeaderCollection headers, string eTag)
        {
            headers["x-amz-copy-source-if-match"] = eTag;
        }

        /// <summary>
        /// Sets the If-None-Match Header for the CopyObject operation.
        ///
        /// Return the object only if its entity tag (ETag) is different from the one
        /// specified, otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="eTag">The ETag to match against</param>
        void setIfNoneMatchCopyHeader(WebHeaderCollection headers, string eTag)
        {
            headers["x-amz-copy-source-if-none-match"] = eTag;
        }

        /// <summary>
        /// Sets the If-Modifed-Since Header for the CopyObject operation.
        ///
        /// Return the object only if it has been modified since the specified time,
        /// otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="date">DateTime Object representing the date to use</param>
        void setIfModifiedSinceCopyHeader(WebHeaderCollection headers, DateTime date)
        {
            headers["x-amz-copy-source-if-modified-since"] = date.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat);
        }

        /// <summary>
        /// Sets the If-Unmodifed-Since Header for the CopyObject operation.
        ///
        /// Return the object only if it has not been modified since the specified time,
        /// otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="date">DateTime Object representing the date to use</param>
        void setIfUnmodifiedSinceCopyHeader(WebHeaderCollection headers, DateTime date)
        {
            headers["x-amz-copy-source-if-unmodified-since"] = date.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat);
        }

        /// <summary>
        /// Valid values: COPY | REPLACE
        /// Constraints: Values other than COPY or REPLACE result in an immediate 400-based error
        /// response. You cannot copy an object to itself unless the S3MetadataDirective header is
        /// specified and its value set to REPLACE.
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="directive">Either COPY or REPLACE</param>
        void setMetadataDirectiveHeader(WebHeaderCollection headers, S3MetadataDirective directive)
        {
            headers[S3Constants.AmzMetadataDirectiveHeader] = S3Constants.MetaDataDirectives[(int)directive];
        }

        /// <summary>
        /// Sets the x-amz-copy-source header based on the bucket and key passed
        /// as input.
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="bucket">The source bucket</param>
        /// <param name="key">The source key</param>
        /// <param name="version">The version of the object to copy (or null if most recent)</param>
        void setCopySourceHeader(WebHeaderCollection headers, string bucket, string key, string version)
        {
            string source;
            if (!String.IsNullOrEmpty(key))
            {
                source = AmazonS3Util.UrlEncode(String.Concat("/", bucket, "/", key), true);
                if (!String.IsNullOrEmpty(version))
                {
                    source = String.Format("{0}?versionId={1}", source, AmazonS3Util.UrlEncode(version, true));
                }
            }
            else
            {
                source = AmazonS3Util.UrlEncode(bucket, true);
            }
            headers["x-amz-copy-source"] = source;
        }

        /// <summary>
        /// Sets the x-amz-copy-source-range header based on the firstByte and lastByte passed
        /// as input.
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="firstByte">The position of the first byte to copy</param>
        /// <param name="lastByte">The position of the last byte to copy</param>
        void setCopySourceRangeHeader(WebHeaderCollection headers, long firstByte, long lastByte)
        {
            headers["x-amz-copy-source-range"] = String.Format("bytes={0}-{1}", firstByte, lastByte);
        }

        /// <summary>
        /// Sets the x-amz-version-id header based on the versionId passed as input
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="versionId">The versionId of the desired S3 object</param>
        void setVersionIdHeader(WebHeaderCollection headers, string versionId)
        {
            headers[S3Constants.AmzVersionIdHeader] = versionId;
        }

        /// <summary>
        /// Sets the x-amz-mfa based on the serial and token passed as input
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="mfaCodes">The tuple of the authentication device codes</param>
        void setMfaHeader(WebHeaderCollection headers, Tuple<string, string> mfaCodes)
        {
            headers[S3Constants.AmzMfaHeader] = String.Concat(mfaCodes.First, " ", mfaCodes.Second);
        }

        /**
         * Creates a string based on the parameters and encrypts it using
         * key. Returns the encrypted string.
         */
        string buildSigningString(IDictionary<S3QueryParameter, string> parameters, WebHeaderCollection webHeaders)
        {
            StringBuilder sb = new StringBuilder("", 256);
            string value = null;

            sb.Append(parameters[S3QueryParameter.Verb]);
            sb.Append("\n");

            if (webHeaders != null)
            {
                if (!String.IsNullOrEmpty(value = webHeaders[AWSSDKUtils.ContentMD5Header]))
                {
                    sb.Append(value);
                }
                sb.Append("\n");

                if (parameters.ContainsKey(S3QueryParameter.ContentType))
                {
                    sb.Append(parameters[S3QueryParameter.ContentType]);
                }
                sb.Append("\n");
            }
            else
            {
                // The headers are null, but we still need to append
                // the 2 newlines that are required by S3.
                // Without these, S3 rejects the signature.
                sb.Append("\n\n");
            }

            if (parameters.ContainsKey(S3QueryParameter.Expires))
            {
                sb.Append(parameters[S3QueryParameter.Expires]);
                webHeaders.Remove(S3Constants.AmzDateHeader);
            }

            sb.Append("\n");
            sb.Append(buildCanonicalizedHeaders(webHeaders));

            if (parameters.ContainsKey(S3QueryParameter.CanonicalizedResource))
            {
                sb.Append(AmazonS3Util.UrlEncode(parameters[S3QueryParameter.CanonicalizedResource], true));
            }

            string action = parameters[S3QueryParameter.Action];

            if (parameters.ContainsKey(S3QueryParameter.QueryToSign))
            {
                sb.Append(parameters[S3QueryParameter.QueryToSign]);
            }

            return sb.ToString();
        }

        /**
         * Returns a string of all x-amz headers sorted by Ordinal.
         */
        StringBuilder buildCanonicalizedHeaders(WebHeaderCollection headers)
        {
            // Build a sorted list of headers that start with x-amz
            List<string> list = new List<string>(headers.Count);
            foreach (string key in headers.AllKeys)
            {
                string lowerKey = key.ToLower();
                if (lowerKey.StartsWith("x-amz-"))
                {
                    list.Add(lowerKey);
                }
            }
            // Using the recommendations from:
            // http://msdn.microsoft.com/en-us/library/ms973919.aspx
            list.Sort(StringComparer.Ordinal);

            // Create the canonicalized header string to return.
            StringBuilder sb = new StringBuilder(256);
            foreach (string key in list)
            {
                sb.Append(String.Concat(key, ":", headers[key], "\n"));
            }

            return sb;
        }

        private void ProcessRequestHandlers(S3Request request)
        {
            if (request == null) throw new ArgumentNullException("request");

            S3RequestEventArgs args = S3RequestEventArgs.Create(request, config);

            if (request != null)
                request.FireBeforeRequestEvent(this, args);

            BeforeRequestEvent(this, args);
        }

        void addHttpRange(HttpWebRequest request, long start, long end)
        {
            if (ADD_RANGE_METHODINFO != null)
            {
                string rangeSpecifier = "bytes";
                string fromString = start.ToString();
                string toString = end.ToString();

                object[] args = new object[3];

                args[0] = rangeSpecifier;
                args[1] = fromString;
                args[2] = toString;

                ADD_RANGE_METHODINFO.Invoke(request, args);
            }
            else
            {
                request.AddRange(Convert.ToInt32(start), Convert.ToInt32(end));
            }
        }

        private static AWSCredentials CreateCredentials(string awsAccessKeyId, SecureString awsSecretAccessKey)
        {
            if (string.IsNullOrEmpty(awsAccessKeyId))
            {
                return null; // anonymous access, no credentials specified
            }
            else
            {
                return new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey);
            }
        }

        private static AWSCredentials CreateCredentials(string awsAccessKeyId, string awsSecretAccessKey)
        {
            if (string.IsNullOrEmpty(awsAccessKeyId))
            {
                return null; // anonymous access, no credentials specified
            }
            else
            {
                return new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey);
            }
        }

        #endregion

        #region Async Classes
        class S3AsyncResult : IAsyncResult
        {
            private static Logger _logger = Logger.GetLogger(typeof(S3AsyncResult));

            bool _isComplete;
            bool _completedSynchronously;
            ManualResetEvent _waitHandle;
            S3Request _s3Request;
            AsyncCallback _callback;
            RequestState _requestState;
            long _orignalStreamPosition;
            object _state;
            int _retiresAttempt;
            Exception _exception;
            S3Response _finalResponse;
            Dictionary<string, object> _parameters;
            object _lockObj;

            private long _startTime;

            internal S3AsyncResult(S3Request s3Request, object state, AsyncCallback callback, bool completeSynchronized)
            {
                this._s3Request = s3Request;
                this._callback = callback;
                this._state = state;
                this._completedSynchronously = completeSynchronized;

                this._lockObj = new object();
                this._startTime = this.S3Request.ElapsedTicks;
            }

            internal S3Request S3Request
            {
                get { return this._s3Request; }
                set { this._s3Request = value; }
            }

            internal Exception Exception
            {
                get { return this._exception; }
                set { this._exception = value; }
            }

            internal long OrignalStreamPosition
            {
                get { return this._orignalStreamPosition; }
                set { this._orignalStreamPosition = value; }
            }

            internal int RetriesAttempt
            {
                get { return this._retiresAttempt; }
                set { this._retiresAttempt = value; }
            }

            internal AsyncCallback Callback
            {
                get { return this._callback; }
            }

            internal void SignalWaitHandle()
            {
                this._isComplete = true;

                if (this._waitHandle != null)
                {
                    this._waitHandle.Set();
                }
            }

            internal object State
            {
                get { return this._state; }
            }

            public bool CompletedSynchronously
            {
                get { return this._completedSynchronously; }
            }

            internal void SetCompletedSynchronously(bool completedSynchronously)
            {
                this._completedSynchronously = completedSynchronously;
            }

            public bool IsCompleted
            {
                get { return this._isComplete; }
            }

            internal void SetIsComplete(bool isComplete)
            {
                this._isComplete = isComplete;
            }

            public object AsyncState
            {
                get { return this._state; }
            }

            public WaitHandle AsyncWaitHandle
            {
                get
                {
                    if (this._waitHandle != null)
                    {
                        return this._waitHandle;
                    }

                    lock (this._lockObj)
                    {
                        if (this._waitHandle == null)
                        {
                            this._waitHandle = new ManualResetEvent(this._isComplete);
                        }
                    }

                    return this._waitHandle;
                }
            }

            internal RequestState RequestState
            {
                get { return this._requestState; }
                set { this._requestState = value; }
            }


            internal S3Response FinalResponse
            {
                get { return this._finalResponse; }
                set
                {
                    this._finalResponse = value;
                    long endTime = this._s3Request.ElapsedTicks;
                    long timeToComplete = endTime - this._startTime;
                    this._s3Request.TotalRequestTime = timeToComplete;
                    _logger.InfoFormat("S3 request completed: {0}", this._s3Request);
                    _logger.Flush();
                }
            }

            internal Dictionary<string, object> Parameters
            {
                get
                {
                    if (this._parameters == null)
                    {
                        this._parameters = new Dictionary<string, object>();
                    }

                    return this._parameters;
                }
            }
        }


        class RequestState
        {
            Stream _inputStream;
            byte[] _requestData;
            long _requestDataLength;
            HttpWebRequest _webRequest;
            Map _parameters;
            long _webRequestStart;
            bool _getRequestStreamCallbackCalled;
            bool _getResponseCallbackCalled;


            public RequestState(HttpWebRequest webRequest, Map parameters, Stream inputStream, byte[] requestData, long requestDataLength, long startTime)
            {
                this._webRequest = webRequest;
                this._parameters = parameters;
                this._inputStream = inputStream;
                this._requestData = requestData;
                this._requestDataLength = requestDataLength;
                this._webRequestStart = startTime;
            }

            internal HttpWebRequest WebRequest
            {
                get { return this._webRequest; }
            }

            internal Map Parameters
            {
                get { return this._parameters; }
            }

            internal Stream InputStream
            {
                get { return this._inputStream; }
            }

            internal byte[] RequestData
            {
                get { return this._requestData; }
            }

            internal long RequestDataLength
            {
                get { return this._requestDataLength; }
            }

            internal long WebRequestStart
            {
                get { return this._webRequestStart; }
                set { this._webRequestStart = value; }
            }

            internal bool GetRequestStreamCallbackCalled
            {
                get { return this._getRequestStreamCallbackCalled; }
                set { this._getRequestStreamCallbackCalled = value; }
            }

            internal bool GetResponseCallbackCalled
            {
                get { return this._getResponseCallbackCalled; }
                set { this._getResponseCallbackCalled = value; }
            }
        }
        #endregion
    }
}
