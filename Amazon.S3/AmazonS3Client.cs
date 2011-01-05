/* *****************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  Author(s): Manoj Mehta, Nathan Schnarr
 */

#if TRACE
using System.Diagnostics;
#endif

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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

using Amazon.Runtime.Internal.Util;

namespace Amazon.S3
{
    using Map = System.Collections.Generic.IDictionary<Amazon.S3.Model.S3QueryParameter, string>;

    /// <summary>
    /// AmazonS3Client is an implementation of AmazonS3; the client allows you to manage your AmazonS3 buckets
    /// and keys/objects.<br />
    /// If you want to use the AmazonS3Client from a Medium Trust hosting environment, please create the
    /// client with an AmazonS3Config object whose UseSecureStringForAwsSecretKey property is false.
    /// </summary>
    /// <remarks>
    /// Amazon S3 is storage for the Internet. It is designed to make web-scale computing easier for developers.
    /// Amazon S3 provides a simple web services interface that can be used to store and retrieve any amount of data,
    /// at any time, from anywhere on the web. It gives any developer access to the same highly scalable, reliable,
    /// fast, inexpensive data storage infrastructure that Amazon uses to run its own global network of web sites.
    /// The service aims to maximize benefits of scale and to pass those benefits on to developers.
    /// </remarks>
    /// <seealso cref="P:Amazon.S3.AmazonS3Config.UseSecureStringForAwsSecretKey"/>
    public class AmazonS3Client : AmazonS3
    {
        #region Private Members

        private readonly string awsAccessKeyId;
        private SecureString awsSecretAccessKey;
        private AmazonS3Config config;
        private bool disposed;
        private Type myType;
        private readonly string clearAwsSecretAccessKey;

        #endregion

        Logger logger = new Logger(typeof(AmazonS3));

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
                if (fDisposing)
                {
                    //Remove Unmanaged Resources
                    // I.O.W. remove resources that have to be explicitly
                    // "Dispose"d or Closed
                    if (awsSecretAccessKey != null)
                    {
                        awsSecretAccessKey.Dispose();
                        awsSecretAccessKey = null;
                    }
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

        #region Public API

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
        {
            if (!String.IsNullOrEmpty(awsSecretAccessKey))
            {
                if (config.UseSecureStringForAwsSecretKey)
                {
                    this.awsSecretAccessKey = new SecureString();
                    foreach (char ch in awsSecretAccessKey.ToCharArray())
                    {
                        this.awsSecretAccessKey.AppendChar(ch);
                    }
                    this.awsSecretAccessKey.MakeReadOnly();
                }
                else
                {
                    clearAwsSecretAccessKey = awsSecretAccessKey;
                }
            }
            this.awsAccessKeyId = awsAccessKeyId;
            this.config = config;
            this.myType = this.GetType();
        }

        /// <summary>
        /// Constructs an AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// Amazon S3 Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The S3 Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonS3Config config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
            this.myType = this.GetType();
        }

        /// <summary>
        /// The GetPreSignedURL operations creates a signed http request.
        /// Query string authentication is useful for giving HTTP or browser
        /// access to resources that would normally require authentication.
        /// When using query string authentication, you create a query,
        /// specify an expiration time for the query, sign it with your
        /// signature, place the data in an HTTP request, and distribute
        /// the request to a user or embed the request in a web page.
        /// A PreSigned URL can be generated for GET, PUT and HEAD
        /// operations on your bucket, keys, and versions.
        /// </summary>
        /// <param name="request">The GetPreSignedUrlRequest that defines the
        /// parameters of the operation.</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        public string GetPreSignedURL(GetPreSignedUrlRequest request)
        {
            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonS3Exception("The AWS Access Key ID cannot be NULL or a Zero length string");
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

        /// <summary>
        /// The ListBuckets operation returns a list of all of the buckets
        /// owned by the authenticated sender of the request.
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
        /// The ListBuckets operation returns a list of all of the buckets
        /// owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">The ListBucketsRequest that defines the parameters
        /// of this operation</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse with the response from S3.</returns>
        public ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The ListObjectsRequest is null!");
            }

            ConvertListBuckets(request);
            return Invoke<ListBucketsResponse>(request);
        }

        /// <summary>
        /// The GetBucketLocation operation takes in a bucket's name and lists the location
        /// of the bucket. This information can be used to determine the bucket's geographical
        /// location.
        /// To determine the location of a bucket, you must be the bucket owner.
        /// </summary>
        /// <param name="request">The GetBucketLocationRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLocationResponse from S3.</returns>
        public GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request)
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
            return Invoke<GetBucketLocationResponse>(request);
        }

        /// <summary>
        /// The GetBucketLogging operating gets the logging status for the bucket specified.
        /// For more information about S3Bucket Logging
        /// see <see href="http://docs.amazonwebservices.com/AmazonS3/latest/ServerLogs.html" />
        /// </summary>
        /// <param name="request">The GetBucketLoggingRequest that defines
        /// the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLoggingResponse from S3.</returns>
        public GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request)
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
            return Invoke<GetBucketLoggingResponse>(request);
        }

        /// <summary>
        /// The EnableBucketLogging operation will turn on bucket logging for the bucket
        /// specified in the request.
        ///
        /// An Amazon S3 bucket can be configured to create access log records for the
        /// requests made against it. An access log record contains details about the
        /// request such as the request type, the resource with which the request worked,
        /// and the time and date that the request was processed. Server access logs are
        /// useful for many applications, because they give bucket owners insight into
        /// the nature of requests made by clients not under their control.
        /// </summary>
        /// <param name="request">The EnableBucketLoggingRequest that defines the parameters of
        /// the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a EnableBucketLoggingResponse from S3.</returns>
        /// <remarks>
        /// Changes to the logging status for a bucket are visible in the configuration API immediately,
        /// but they take time to actually affect the delivery of log files. For example, if you enable
        /// logging for a bucket, some requests made in the following hour might be logged, while others
        /// might not. Or, if you change the target bucket for logging from bucket A to bucket B, some
        /// logs for the next hour might continue to be delivered to bucket A, while others might be delivered
        /// to the new target bucket B. In all cases, the new settings will eventually take effect without any
        /// further action on your part.
        /// </remarks>
        public EnableBucketLoggingResponse EnableBucketLogging(EnableBucketLoggingRequest request)
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
            return Invoke<EnableBucketLoggingResponse>(request);
        }

        /// <summary>
        /// The DisableBucketLogging will turn off bucket logging for the bucket specified
        /// in the request.
        ///
        /// An Amazon S3 bucket can be configured to create access log records for the
        /// requests made against it. An access log record contains details about the
        /// request such as the request type, the resource with which the request worked,
        /// and the time and date that the request was processed. Server access logs are
        /// useful for many applications, because they give bucket owners insight into
        /// the nature of requests made by clients not under their control.
        /// </summary>
        /// <param name="request">
        /// The DisableBucketLoggingRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DisableBucketLoggingResponse from S3.</returns>
        public DisableBucketLoggingResponse DisableBucketLogging(DisableBucketLoggingRequest request)
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
            return Invoke<DisableBucketLoggingResponse>(request);
        }

        /// <summary>
        /// The GetBucketVersioning operation takes in a bucket's name and get the versioning
        /// status of the bucket.
        /// </summary>
        /// <param name="request">The GetBucketVersioningRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketVersioningResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3BucketVersioningConfig"/>
        public GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request)
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
            return Invoke<GetBucketVersioningResponse>(request);
        }

        /// <summary>
        /// The SetBucketVersioning operation takes in a bucket's name and the versioning
        /// status you want to set on the bucket.
        /// <para>Valid values for the Versioning Status are Enabled and Suspended.
        /// Once Versioning has been "Enabled" on a bucket, it can be "Suspended"
        /// but cannot be switched "Off".</para>
        /// </summary>
        /// <param name="request">The SetBucketVersioningRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentException">
        /// If SetBucketVersioningRequest.VersioningStatus has the value S3BucketVersioningStatus.Off
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetBucketVersioningResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3BucketVersioningConfig"/>
        public SetBucketVersioningResponse SetBucketVersioning(SetBucketVersioningRequest request)
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

            SetBucketVersioningResponse resp = Invoke<SetBucketVersioningResponse>(request);
            config.CommunicationProtocol = current;
            return resp;
        }

        /// <summary>
        /// <para>
        /// Retrieves the policy for the specified bucket. Only the owner of the
        /// bucket can retrieve the policy. If no policy has been set for the bucket,
        /// then an error will be thrown.
        /// </para>
        /// <para>
        /// Bucket policies provide access control management at the bucket level for
        /// both the bucket resource and contained object resources. Only one policy
        /// can be specified per-bucket.
        /// </para>
        /// <para>
        /// For more information on forming bucket polices, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </summary>
        /// <param name="request">The GetBucketPolicyRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetBucketPolicyResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            try
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
                return this.Invoke<GetBucketPolicyResponse>(request);
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
        /// For more information on forming bucket polices, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </summary>
        /// <param name="request">The PutBucketPolicyRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a PutBucketPolicyResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
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
            return this.Invoke<PutBucketPolicyResponse>(request);
        }

        /// <summary>
        /// <para>
        /// Deletes the policy associated with the specified bucket. Only the owner
        /// of the bucket can delete the bucket policy.
        /// </para>
        /// <para>
        /// If you delete a policy that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </para>
        /// <para>
        /// Bucket policies provide access control management at the bucket level for
        /// both the bucket resource and contained object resources. Only one policy
        /// may be specified per-bucket.
        /// </para>
        /// <para>
        /// For more information on forming bucket polices, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </summary>
        /// <param name="request">The DeleteBucketPolicyRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a DeleteBucketPolicyResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
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
            return this.Invoke<DeleteBucketPolicyResponse>(request);
        }

        /// <summary>
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
        /// </summary>
        /// <param name="request">The SetNotificationConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a SetNotificationConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public SetNotificationConfigurationResponse SetNotificationConfiguration(SetNotificationConfigurationRequest request)
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
            return this.Invoke<SetNotificationConfigurationResponse>(request);
        }

        /// <summary>
        /// <para>
        /// Retrieves the notification configuration for the specified bucket. Only the owner of the
        /// bucket can retrieve the notification configuration.
        /// </para>
        /// </summary>
        /// <param name="request">The GetNotificationConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetNotificationConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public GetNotificationConfigurationResponse GetNotificationConfiguration(GetNotificationConfigurationRequest request)
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
            return this.Invoke<GetNotificationConfigurationResponse>(request);
        }

        /// <summary>
        /// The ListObjects operation lists the objects/keys in a bucket ordered
        /// lexicographically (from a-Z). The list can be filtered via the Marker
        /// property of the ListObjectsRequest.
        /// In order to List Objects, you must have READ access to the bucket.
        /// </summary>
        /// <param name="request">
        /// The ListObjectsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListObjectsResponse from S3 with a list of S3Objects,
        /// headers and request parameters used to filter the list.</returns>
        /// <remarks>
        /// Since buckets can contain a virtually unlimited number of objects, the complete
        /// results of a list query can be extremely large. To manage large result sets,
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should
        /// always check the <see cref="P:Amazon.S3.Model.ListObjectsResponse.IsTruncated" />
        /// to see if the returned listing
        /// is complete, or if callers need to make additional calls to get more results.
        /// The marker parameter allows callers to specify where to start the object listing.
        /// List performance is not substantially affected by the total number of keys in your
        /// bucket, nor by the presence or absence of any additional query parameters.
        /// </remarks>
        public ListObjectsResponse ListObjects(ListObjectsRequest request)
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
            return Invoke<ListObjectsResponse>(request);
        }

        /// <summary>
        /// The ListVersions operation returns a list of object versions in the bucket
        /// specified ordered first by key and then by version. Keys are sorted lexicographically
        /// (i.e. alphabetically from a-Z); versions are sorted from most to least recent.
        /// Both versions with data and delete markers are included in the results.
        /// <para>
        /// In order to List Versions, you must have READ access to the bucket.
        /// When the list is not filtered by a specific key, only the metadata
        /// associated with the latest version of objects in the bucket is returned.
        /// The use of KeyMarker and VersionIdMarker allow you to filter results.</para>
        /// </summary>
        /// <param name="request">
        /// The ListVersionsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListVersionsResponse from S3 that contains a list of
        /// versions along with metadata and the original request parameters.</returns>
        /// <remarks>
        /// Since buckets can contain a virtually unlimited number of objects, the complete
        /// results of a list query can be extremely large. To manage large result sets,
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should
        /// always check the <see cref="P:Amazon.S3.Model.ListVersionsResonse.IsTruncated" />
        /// to see if the returned listing
        /// is complete, or if callers need to make additional calls to get more results.
        /// The KeyMarker and VersionIdMarker parameters of the ListVersionsRequest object
        /// allow callers to specify where to start the version listing. In order to enable
        /// versioning on a bucket, please refer to the
        /// <see cref="M:Amazon.S3.AmazonS3Client.SetBucketVersioning">SetBucketVersioning</see>
        /// operation's details.
        /// <br />List performance is not substantially affected by the total number of keys in your
        /// bucket, nor by the presence or absence of any additional query parameters.
        /// </remarks>
        public ListVersionsResponse ListVersions(ListVersionsRequest request)
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
            return Invoke<ListVersionsResponse>(request);
        }

        /// <summary>
        /// The GetACL operation gets the S3AccessControlList for a given bucket or object.
        /// Each bucket and object in Amazon S3 has an ACL that defines its access control
        /// policy, which is a list of grants. A grant consists of one grantee and one permission.
        /// ACLs only grant permissions; they do not deny them.
        /// </summary>
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
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The GetACLRequest specified is null!");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName specified is null or empty!");
            }

            ConvertGetACL(request);
            return Invoke<GetACLResponse>(request);
        }

        /// <summary>
        /// The SetACL operation gets the S3AccessControlList for a given bucket or object.
        /// Each bucket and object in Amazon S3 has an ACL that defines its access control
        /// policy, which is a list of grants. A grant consists of one grantee and one permission.
        /// ACLs only grant permissions; they do not deny them.
        /// </summary>
        /// <remarks>
        /// Often used ACLs are defined in the S3CannedACL enumeration.
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
            return Invoke<SetACLResponse>(request);
        }

        /// <summary>
        /// The PutBucket operation creates a new S3 Bucket.
        /// Depending on your latency and legal requirements, you can specify a location
        /// constraint that will affect where your data physically resides.
        /// You can currently specify either a Europe (EU) or a SFO (US-WEST-1)
        /// location constraint.
        /// </summary>
        /// <param name="request">
        /// The PutBucketRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketResponse from S3.</returns>
        /// <remarks>
        /// Every object stored in Amazon S3 is contained in a bucket. Buckets
        /// partition the namespace of objects stored in Amazon S3 at the top level.
        /// Within a bucket, you can use any names for your objects, but bucket names
        /// must be unique across all of Amazon S3.
        /// <para>
        /// Buckets are similar to Internet domain names. Just as Amazon is the only owner
        /// of the domain name Amazon.com, only one person or organization can own a bucket
        /// within Amazon S3. The similarities between buckets and domain names is not a
        /// coincidence - there is a direct mapping between Amazon S3 buckets and subdomains
        /// of s3.amazonaws.com. Objects stored in Amazon S3 are addressable using the REST API
        /// under the domain bucketname.s3.amazonaws.com. For example, the object homepage.html
        /// stored in the Amazon S3 bucket mybucket can be addressed as
        /// http://mybucket.s3.amazonaws.com/homepage.html.</para>
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
        /// There is no limit to the number of objects that can be stored in a bucket and no
        /// variation in performance when using many buckets or just a few. You can store all
        /// of your objects in a single bucket or organize them across several buckets.
        /// </remarks>
        /// <seealso cref="T:Amazon.S3.Model.S3Region"/>
        public PutBucketResponse PutBucket(PutBucketRequest request)
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
            return Invoke<PutBucketResponse>(request);
        }

        /// <summary>
        /// The DeleteBucket operation deletes the bucket named in the request.
        /// All objects in the bucket must be deleted before the bucket itself can be deleted.
        /// Only the owner of a bucket can delete it, regardless of the bucket's access control policy.
        /// </summary>
        /// <param name="request">
        /// The DeleteBucketRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketResponse from S3.</returns>
        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
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
            return Invoke<DeleteBucketResponse>(request);
        }

        /// <summary>
        /// The GetObject operation fetches the most recent version of an S3 object
        /// from the specified S3 bucket. You must have READ access to the object.
        /// If READ access is granted to an anonymous user, an object can be retrieved
        /// without an authorization header. Providing a version-id for the object will
        /// fetch the specific version from S3 instead of the most recent one.
        /// </summary>
        /// <param name="request">
        /// The GetObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectResponse from S3.</returns>
        /// <remarks>
        /// Please wrap the response you get from calling GetObject in a using clause.
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
        /// </remarks>
        public GetObjectResponse GetObject(GetObjectRequest request)
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
            return Invoke<GetObjectResponse>(request);
        }

        /// <summary>
        /// The GetObjectMetadata operation is used to retrieve information about a specific object
        /// or object size, without actually fetching the object itself. This is useful if you're
        /// only interested in the object metadata, and don't want to waste bandwidth on the object data.
        /// The response is identical to the GetObject response, except that there is no response body.
        /// </summary>
        /// <param name="request">
        /// The GetObjectMetadataRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectMetadataResponse from S3.</returns>
        public GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
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
            return Invoke<GetObjectMetadataResponse>(request);
        }

        /// <summary>
        /// The PutObject operation adds an object to an S3 Bucket.
        /// The response indicates that the object has been successfully stored.
        /// Amazon S3 never stores partial objects: if you receive a successful
        /// response, then you can be confident that the entire object was stored.
        ///
        /// To ensure data is not corrupted over the network, use the Content-MD5
        /// header. When you use the Content-MD5 header, Amazon S3 checks the object
        /// against the provided MD5 value. If they do not match, Amazon S3 returns an error.
        /// Additionally, you can calculate the MD5 while putting an object to
        /// Amazon S3 and compare the returned Etag to the calculated MD5 value.
        ///
        /// If an object already exists in a bucket, the new object will overwrite
        /// it because Amazon S3 stores the last write request. However, Amazon S3
        /// is a distributed system. If Amazon S3 receives multiple write requests
        /// for the same object nearly simultaneously, all of the objects might be
        /// stored, even though only one wins in the end. Amazon S3 does not provide
        /// object locking; if you need this, make sure to build it into your application
        /// layer.
        ///
        /// If you specify a location constraint when creating a bucket, all objects
        /// added to the bucket are stored in the bucket's location.
        ///
        /// You must have WRITE access to the bucket to add an object.
        /// </summary>
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
            if (!request.IsSetFilePath() &&
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
                    request.InputStream = new FileStream(request.FilePath, FileMode.Open, FileAccess.Read);
                }
                else
                {
                    throw new FileNotFoundException("The specified file does not exist");
                }

                if (!request.IsSetKey())
                {
                    string name = request.FilePath;
                    // Set the key to be the name of the file sans directories
                    request.Key = name.Substring(name.LastIndexOf(@"\") + 1);
                }
            }

            // from the checks made, it is guaranteed that if a filename is not specified
            // and the flow of execution gets this far, there has to be either an InputStream
            // or a ContentBody with a Key
            try
            {
                ConvertPutObject(request);
                return Invoke<PutObjectResponse>(request);
            }
            finally
            {
                try
                {
                    if (request.InputStream != null && (request.IsSetFilePath() || request.AutoCloseStream))
                    {
                        request.InputStream.Close();
                    }
                }
                catch(Exception e) 
                {
                    this.logger.Error("Error closing stream after PutObject.", e);
                }
            }
        }

        /// <summary>
        /// The DeleteObject operation removes the specified object from Amazon S3.
        /// Once deleted, there is no method to restore or undelete an object.
        ///
        /// If you delete an object that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </summary>
        /// <param name="request">
        /// The DeleteObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteObjectResponse from S3.</returns>
        public DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
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
            DeleteObjectResponse resp = Invoke<DeleteObjectResponse>(request);
            config.CommunicationProtocol = current;

            return resp;
        }

        /// <summary>
        /// The copy operation creates a copy of an object that is already stored in Amazon S3.
        /// When copying an object, you can preserve all metadata (default) or specify new metadata.
        /// However, the ACL is not preserved and is set to private for the user making the request.
        /// To override the default ACL setting, specify a new ACL when generating a copy request.
        /// If versioning has been enabled on the source bucket, and you want to copy a specific
        /// version of an object, please use
        /// <see cref="P:Amazon.S3.Model.CopyObjectRequest.SourceVersionId" /> to specify the
        /// version. By default, the most recent version of an object is copied to the
        /// destination bucket.
        /// </summary>
        /// <param name="request">
        /// The CopyObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CopyObjectResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        /// <remarks>
        /// If Versioning has been enabled on the target bucket, S3 generates a
        /// unique version ID for the object being copied. This version ID is different
        /// from the version ID of the source object. Additionally, S3 returns the version
        /// ID of the copied object in the x-amz-version-id response header in the response.
        /// If you do not enable Versioning or suspend it on the target bucket, the version ID
        /// S3 generates is always the string literal - "null".
        /// </remarks>
        public CopyObjectResponse CopyObject(CopyObjectRequest request)
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
            return Invoke<CopyObjectResponse>(request);
        }

        /// <summary>
        /// This method initiates a multipart upload and returns an InitiateMultipartUploadResponse 
        /// which contains an upload ID. This upload ID associates all the
        /// parts in the specific upload. You specify this upload ID in each of 
        /// your subsequent Upload Part requests. You also include
        /// this upload ID in the final request to either complete, or abort
        /// the multipart upload request.
        /// </summary>
        /// <param name="request">
        /// The CopyObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a InitiateMultipartUploadResponse from S3.</returns>
        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
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
            return Invoke<InitiateMultipartUploadResponse>(request);
        }

        /// <summary>
        /// This method uploads a part in a multipart upload.  You must initiate a 
        /// multipart upload before you can upload any part.
        /// <para>
        /// Your UploadPart request must include an upload ID and a part number. 
        /// The upload ID is the ID returned by Amazon S3 in response to your 
        /// Initiate Multipart Upload request. For more information on initiating a
        /// multipart upload. Part number can be any number between 1 and
        /// 10,000, inclusive. A part number uniquely identifies a part and also 
        /// defines its position within the object being uploaded. If you 
        /// upload a new part using the same part number that was specified in uploading a
        /// previous part, the previously uploaded part is overwritten.
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
        /// </summary>
        /// <param name="request">
        /// The UploadPartRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a UploadPartResponse from S3.</returns>
        public UploadPartResponse UploadPart(UploadPartRequest request)
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

            Stream fStream = null;
            Stream orignalStream = request.InputStream;
            try
            {
                if (request.IsSetInputStream())
                {
                    request.InputStream = new PartStreamWrapper(request.InputStream, request.PartSize);
                }
                else
                {
                    fStream = File.OpenRead(request.FilePath);
                    fStream.Position = request.FilePosition;
                    request.InputStream = new PartStreamWrapper(fStream, request.PartSize);
                }

                ConvertUploadPart(request);
                UploadPartResponse response = Invoke<UploadPartResponse>(request);
                response.PartNumber = request.PartNumber;
                return response;
            }
            finally
            {
                if (fStream != null)
                {
                    fStream.Close();
                }
                request.InputStream = orignalStream;
            }
        }

        /// <summary>
        /// This method lists the parts that have been uploaded 
        /// for a particular multipart upload.
        /// <para>
        /// This method must include the upload ID, returned by 
        /// the InitiateMultipartUpload request. This request 
        /// returns a maximum of 1000 uploaded parts by default. You can
        /// restrict the number of parts returned by specifying the 
        /// MaxParts property on the ListPartsRequest. If your multipart
        /// upload consists of more parts than allowed in the 
        /// ListParts response, the response returns a IsTruncated
        /// field with value true, and a NextPartNumberMarker property. 
        /// In subsequent ListParts request you can include the 
        /// PartNumberMarker property and set its value to the
        /// NextPartNumberMarker property value from the previous response.
        /// </para>
        /// </summary>
        /// <param name="request">
        /// The ListPartsRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a ListPartsResponse from S3.</returns>
        public ListPartsResponse ListParts(ListPartsRequest request)
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
            return Invoke<ListPartsResponse>(request);
        }

        /// <summary>
        /// This method aborts a multipart upload. After a multipart upload is 
        /// aborted, no additional parts can be uploaded using that upload ID. 
        /// The storage consumed by any previously uploaded parts will be freed.
        /// However, if any part uploads are currently in progress, those part 
        /// uploads may or may not succeed. As a result, it may be necessary to 
        /// abort a given multipart upload multiple times in order to completely free
        /// all storage consumed by all parts.
        /// </summary>
        /// <param name="request">
        /// The AbortMultipartUploadRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a AbortMultipartUploadResponse from S3.</returns>
        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
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
            return Invoke<AbortMultipartUploadResponse>(request);
        }

        /// <summary>
        /// This operation completes a multipart upload by assembling 
        /// previously uploaded parts.
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
        /// </summary>
        /// <param name="request">
        /// The CompleteMultipartUploadRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a CompleteMultipartUploadResponse from S3.</returns>
        public CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
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
            return Invoke<CompleteMultipartUploadResponse>(request);
        }

        /// <summary>
        /// This operation lists in-progress multipart uploads. An in-progress 
        /// multipart upload is a multipart upload that has been initiated, 
        /// using the InitiateMultipartUpload request, but has not yet been 
        /// completed or aborted.
        /// <para>
        /// This operation returns at most 1,000 multipart uploads in the 
        /// response by default. The number of multipart uploads can be further 
        /// limited using the MaxUploads property on the request parameter. If there are 
        /// additional multipart uploads that satisfy the list criteria, the 
        /// response will contain an IsTruncated property with the value set to true.
        /// To list the additional multipart uploads use the KeyMarker and 
        /// UploadIdMarker properties on the request parameters.
        /// </para>
        /// </summary>
        /// <param name="request">
        /// The ListMultipartUploadsRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a ListMultipartUploadsResponse from S3.</returns>
        public ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
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
            return Invoke<ListMultipartUploadsResponse>(request);
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
            AddS3QueryParameters(request, null);
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

            AddS3QueryParameters(request, request.BucketName);
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

            AddS3QueryParameters(request, request.BucketName);

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

            AddS3QueryParameters(request, request.BucketName);
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
            AddS3QueryParameters(request, request.BucketName);
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
            AddS3QueryParameters(request, request.BucketName);
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

            AddS3QueryParameters(request, request.BucketName);
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
                SetCannedACLHeader(webHeaders, request.CannedACL);
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

            AddS3QueryParameters(request, request.BucketName);
        }

        /**
         * Converts the PutBucketRequest to key/value pairs
         */
        private void ConvertPutBucket(PutBucketRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "PutBucket";

            if (request.BucketRegion > S3Region.US)
            {
                string content = String.Format(
                    "<CreateBucketConstraint><LocationConstraint>{0}</LocationConstraint></CreateBucketConstraint>",
                    S3Constants.LocationConstraints[(int)request.BucketRegion]
                    );
                parameters[S3QueryParameter.ContentBody] = content;
                parameters[S3QueryParameter.ContentType] = AWSSDKUtils.UrlEncodedContent;
            }
            AddS3QueryParameters(request, request.BucketName);
        }

        /**
         * Convert DeleteBucketRequest to key/value pairs
         */
        private void ConvertDeleteBucket(DeleteBucketRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "DeleteBucket";
            AddS3QueryParameters(request, request.BucketName);
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

            AddS3QueryParameters(request, request.BucketName);
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

            AddS3QueryParameters(request, request.BucketName);
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

            AddS3QueryParameters(request, request.BucketName);
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

            AddS3QueryParameters(request, request.BucketName);
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

            AddS3QueryParameters(request, request.BucketName);
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
                    request.ByteRange.First,
                    ":",
                    request.ByteRange.Second
                    );
            }

            // Add the necessary get object specific headers to the request.Headers object
            if (request.IsSetETagToMatch())
            {
                SetIfMatchHeader(webHeaders, request.ETagToMatch);
            }
            if (request.IsSetETagToNotMatch())
            {
                SetIfNoneMatchHeader(webHeaders, request.ETagToNotMatch);
            }
            if (request.IsSetModifiedSinceDate())
            {
                SetIfModifiedSinceHeader(webHeaders, request.ModifiedSinceDate);
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                SetIfUnmodifiedSinceHeader(webHeaders, request.UnmodifiedSinceDate);
            }
            if (request.IsSetVersionId())
            {
                string queryStr = String.Concat("?versionId=", request.VersionId);
                parameters[S3QueryParameter.Query] = queryStr;
                parameters[S3QueryParameter.QueryToSign] = queryStr;
            }

            // Add the Timeout parameter
            parameters[S3QueryParameter.RequestTimeout] = request.Timeout.ToString();

            AddS3QueryParameters(request, request.BucketName);
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
                SetIfNoneMatchHeader(webHeaders, request.ETagToNotMatch);
            }
            if (request.IsSetModifiedSinceDate())
            {
                SetIfModifiedSinceHeader(webHeaders, request.ModifiedSinceDate);
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                SetIfUnmodifiedSinceHeader(webHeaders, request.UnmodifiedSinceDate);
            }
            if (request.IsSetVersionId())
            {
                string queryStr = String.Concat("?versionId=", request.VersionId);
                parameters[S3QueryParameter.Query] = queryStr;
                parameters[S3QueryParameter.QueryToSign] = queryStr;
            }

            AddS3QueryParameters(request, request.BucketName);
        }

        /**
         * Convert PutObjectRequest to key/value pairs.
         */
        private void ConvertPutObject(PutObjectRequest request)
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
                // needed to represent the content string - check Invoke<T>
                parameters[S3QueryParameter.ContentBody] = request.ContentBody;
                // Since a content body was set, let's determine whether a content type was set
                if (!parameters.ContainsKey(S3QueryParameter.ContentType))
                {
                    parameters[S3QueryParameter.ContentType] = AWSSDKUtils.UrlEncodedContent;
                }
            }

            // Add the Timeout parameter
            parameters[S3QueryParameter.RequestTimeout] = request.Timeout.ToString();

            // Add the Put Object specific headers to the request
            // 1. The Canned ACL
            if (request.IsSetCannedACL())
            {
                SetCannedACLHeader(webHeaders, request.CannedACL);
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

            // Finally, add the S3 specific parameters and headers
            AddS3QueryParameters(request, request.BucketName);
        }

        /**
         * Convert GetPreSignedUrlRequest to key/value pairs.
         */
        private void ConvertGetPreSignedUrl(GetPreSignedUrlRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.Verbs[(int)request.Verb];
            parameters[S3QueryParameter.Action] = "GetPreSignedUrl";
            StringBuilder queryStr = new StringBuilder("?AWSAccessKeyId=", 512);
            queryStr.Append(this.awsAccessKeyId);

            if (request.IsSetKey())
            {
                parameters[S3QueryParameter.Key] = request.Key;
            }
            else if (request.Verb == HttpVerb.HEAD)
            {
                queryStr.Append("&max-keys=0");
            }

            if (queryStr.Length != 0)
            {
                queryStr.Append("&");
            }            
            queryStr.Append("Expires=");

            string value = Convert.ToInt64((request.Expires.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
            queryStr.Append(value);
            parameters[S3QueryParameter.Expires] = value;

            if (request.IsSetKey() &&
                request.IsSetVersionId() &&
                request.Verb < HttpVerb.PUT)
            {
                string queryStrToSign = String.Concat("?versionId=", request.VersionId);
                parameters[S3QueryParameter.QueryToSign] = queryStrToSign;
                queryStr.Append(String.Concat("&versionId=", request.VersionId));
            }

            parameters[S3QueryParameter.Query] = queryStr.ToString();
            AddS3QueryParameters(request, request.BucketName);

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

            parameters[S3QueryParameter.Url] = String.Concat(
                url,
                "&Signature=",
                AmazonS3Util.UrlEncode(request.parameters[S3QueryParameter.Authorization], false)
                );
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
                SetMfaHeader(request.Headers, request.MfaCodes);
            }

            AddS3QueryParameters(request, request.BucketName);
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

            // Add the Timeout parameter
            parameters[S3QueryParameter.RequestTimeout] = request.Timeout.ToString();

            // Add the Copy Object specific headers to the request
            if (request.IsSetETagToMatch())
            {
                SetIfMatchCopyHeader(webHeaders, request.ETagToMatch);
            }
            if (request.IsSetETagToNotMatch())
            {
                SetIfNoneMatchCopyHeader(webHeaders, request.ETagToNotMatch);
            }
            if (request.IsSetModifiedSinceDate())
            {
                SetIfModifiedSinceCopyHeader(webHeaders, request.ModifiedSinceDate);
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                SetIfUnmodifiedSinceCopyHeader(webHeaders, request.UnmodifiedSinceDate);
            }

            // Add the Copy Source header which makes this a COPY request
            string sourceKey = request.SourceKey;
            if (request.IsSetSourceVersionId())
            {
                sourceKey = String.Concat(
                    sourceKey,
                    "?versionId=",
                    request.SourceVersionId
                    );
            }
            SetCopySourceHeader(webHeaders, request.SourceBucket, sourceKey);

            // there is always a directive associated with the request
            SetMetadataDirectiveHeader(webHeaders, request.Directive);

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
                SetCannedACLHeader(webHeaders, request.CannedACL);
            }

            // Add the storage class header
            webHeaders[S3Constants.AmzStorageClassHeader] = S3Constants.StorageClasses[(int)request.StorageClass];

            AddS3QueryParameters(request, request.DestinationBucket);
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

            AddS3QueryParameters(request, request.BucketName);
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
                SetMfaHeader(webHeaders, request.MfaCodes);
            }

            AddS3QueryParameters(request, request.BucketName);
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

            // Add the Put Object specific headers to the request
            // 1. The Canned ACL
            if (request.IsSetCannedACL())
            {
                SetCannedACLHeader(webHeaders, request.CannedACL);
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

            // Add the storage class header
            webHeaders[S3Constants.AmzStorageClassHeader] = S3Constants.StorageClasses[(int)request.StorageClass];

            // Finally, add the S3 specific parameters and headers
            AddS3QueryParameters(request, request.BucketName);
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
            AddS3QueryParameters(request, request.BucketName);
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

            string query = sb.ToString();

            // Remove trailing & character
            if (query.EndsWith("&"))
            {
                query = query.Remove(query.Length - 1);
            }

            parameters[S3QueryParameter.Query] = query;

            // Finally, add the S3 specific parameters and headers
            AddS3QueryParameters(request, request.BucketName);
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
            AddS3QueryParameters(request, request.BucketName);
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
            AddS3QueryParameters(request, request.BucketName);
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


            // Add the Timeout parameter
            parameters[S3QueryParameter.RequestTimeout] = request.Timeout.ToString();


            // Finally, add the S3 specific parameters and headers
            AddS3QueryParameters(request, request.BucketName);
        }

        #endregion

        #region Private Methods

        /**
         * Add authentication related and version parameters
         */
        private void AddS3QueryParameters(S3Request request, string destinationBucket)
        {
            if (request == null)
            {
                return;
            }

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
            // in the ConfigureWebRequest function directly to the URL
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

            string toSign = BuildSigningString(parameters, webHeaders);
            string auth;
            if (config.UseSecureStringForAwsSecretKey)
            {
                KeyedHashAlgorithm algorithm = new HMACSHA1();
                auth = AWSSDKUtils.HMACSign(
                    toSign,
                    awsSecretAccessKey,
                    algorithm
                    );
            }
            else
            {
                KeyedHashAlgorithm algorithm = new HMACSHA1();
                auth = AWSSDKUtils.HMACSign(
                    toSign,
                    clearAwsSecretAccessKey,
                    algorithm
                    );
            }
            parameters[S3QueryParameter.Authorization] = auth;

            // Insert the S3 Url into the parameters
            AddUrlToParameters(request, config);
        }

        private void WriteStreamToService(S3Request request, long reqDataLen, Stream inputStream, Stream requestStream)
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


        /**
        * Invoke request and return response
        */
        private T Invoke<T>(S3Request userRequest) where T : S3Response, new()
        {
            if (userRequest == null)
            {
                throw new AmazonS3Exception("No request specified for the S3 operation!");
            }

            WebHeaderCollection headers = userRequest.Headers;
            Map parameters = userRequest.parameters;
            Stream fStream = userRequest.InputStream;

            string actionName = parameters[S3QueryParameter.Action];
            T response = default(T);
            HttpStatusCode statusCode = default(HttpStatusCode);
            string verb = parameters[S3QueryParameter.Verb];

            this.logger.DebugFormat("Starting request for {0}", actionName);

            // Variables that pertain to PUT requests
            byte[] requestData = Encoding.UTF8.GetBytes("");
            long reqDataLen = 0;

            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonS3Exception("The AWS Access Key ID cannot be NULL or a Zero length string");
            }

            // The HTTP operation specified has to be one of the operations
            // the Amazon S3 service explicitly supports
            if (!(verb.Equals(S3Constants.PutVerb) ||
                verb.Equals(S3Constants.GetVerb) ||
                verb.Equals(S3Constants.DeleteVerb) ||
                verb.Equals(S3Constants.HeadVerb) ||
                verb.Equals(S3Constants.PostVerb)))
            {
                throw new AmazonS3Exception("Invalid HTTP Operation attempted! Supported operations - GET, HEAD, PUT, DELETE");
            }

            if (verb.Equals(S3Constants.PutVerb) || verb.Equals(S3Constants.PostVerb))
            {
                if (parameters.ContainsKey(S3QueryParameter.ContentBody))
                {
                    string reqBody = parameters[S3QueryParameter.ContentBody];
                    this.logger.DebugFormat("Request body's content [{0}]", reqBody);
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

            bool shouldRetry;
            int retries = 0;
            int maxRetries = config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : AWSSDKUtils.DefaultMaxRetry;

            HttpWebRequest request;
            HttpWebResponse httpResponse = null;
            string requestAddr;
            WebHeaderCollection respHdrs = null;
            Exception cause = null;

            long orignalStreamPosition = 0;
            if (fStream != null)
            {
                orignalStreamPosition = fStream.Position;
            }
            do
            {
                shouldRetry = false;
                request = ConfigureWebRequest(userRequest, reqDataLen);

                // Determine the Request Address and add it to our properties bag
                requestAddr = request.Address.ToString();
                parameters[S3QueryParameter.RequestAddress] = requestAddr;

                // Submit the request and read response body
                try
                {
                    // Accessing the Request Stream for operations other than PUT results
                    // is a ProtocolViolationException. Good thing to test is whether
                    // the request data length > 0 or the HTTP Verb is "PUT"
                    if (reqDataLen > 0)
                    {
                        using (Stream requestStream = request.GetRequestStream())
                        {
                            if (fStream != null)
                            {
                                WriteStreamToService(userRequest, reqDataLen, fStream, requestStream);
                            }
                            else
                            {
                                using (MemoryStream ms = new MemoryStream(requestData))
                                {
                                    WriteStreamToService(userRequest, reqDataLen, ms, requestStream);
                                }
                            }
                        }
                        this.logger.DebugFormat("Processed parameters and making request for {0} with {1} of bytes in request to {2}.", actionName, reqDataLen, request.RequestUri);
                    }
                    else
                    {
                        this.logger.DebugFormat("Processed parameters and making request for {0} to {1}.", actionName, request.RequestUri);
                    }

                    DateTime requestSent = DateTime.UtcNow;
                    httpResponse = request.GetResponse() as HttpWebResponse;
                    DateTime responseReceived = DateTime.UtcNow;

                    if (httpResponse != null)
                    {
                        respHdrs = httpResponse.Headers;
                        this.logger.InfoFormat("Received response for {0} with status code {1} in {2} ms.", actionName, httpResponse.StatusCode, (responseReceived - requestSent).TotalMilliseconds);

                        statusCode = httpResponse.StatusCode;
                        if (!IsRedirect(httpResponse))
                        {
                            // The request submission has completed. Retrieve the response.
                            shouldRetry = ProcessRequestResponse<T>(httpResponse, parameters, myType, out response, out cause);
                        }
                        else
                        {
                            shouldRetry = true;

                            ProcessRedirect(userRequest, httpResponse);
                            this.logger.InfoFormat("Request for {0} is being redirect to {1}.", actionName, userRequest.parameters[S3QueryParameter.Url]);

                            PauseOnRetry(++retries, maxRetries, statusCode, requestAddr, httpResponse.Headers, cause);

                            // The HTTPResponse object needs to be closed. Once this is done, the request
                            // is gracefully terminated. Mind you, if this response object is not closed,
                            // the client will start getting timeout errors.
                            // P.S. This sequence of close-response followed by abort-request
                            // will be repeated through the exception handlers for this try block
                            httpResponse.Close();
                            httpResponse = null;
                            request.Abort();
                        }
                    }
                }
                // Web exception is thrown on unsucessful responses
                catch (WebException we)
                {
                    this.logger.Debug(string.Format("Error making request {0}.", actionName), we);

                    using (HttpWebResponse errorResponse = we.Response as HttpWebResponse)
                    {
                        shouldRetry = ProcessRequestError(actionName, request, we, errorResponse, requestAddr, out respHdrs, myType, out cause);

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
                }
                catch (IOException e)
                {
                    if (this.isInnerExceptionThreadAbort(e))
                        throw;

                    this.logger.Error(string.Format("Error making request {0}.", actionName), e);
                    if (httpResponse != null)
                    {
                        httpResponse.Close();
                        httpResponse = null;
                    }
                    // Abort the unsuccessful request
                    request.Abort();

                    if (retries <= maxRetries)
                        shouldRetry = true;
                    else
                        throw;
                }

                if (shouldRetry)
                {
                    if (retries <= maxRetries)
                    {
                        this.logger.InfoFormat("Retry number {0} for request {1}.", retries, actionName);
                    }
                    PauseOnRetry(++retries, maxRetries, statusCode, requestAddr, respHdrs, cause);
                    // Reset the request so that streams are recreated,
                    // removed headers are added back, etc
                    PrepareRequestForRetry(userRequest, orignalStreamPosition);
                }
            } while (shouldRetry && retries <= maxRetries);

            return response;
        }

        private bool isInnerExceptionThreadAbort(Exception e)
        {
            if (e.InnerException is ThreadAbortException)
                return true;
            if (e.InnerException != null)
                return isInnerExceptionThreadAbort(e.InnerException);
            return false;
        }

        private static void ProcessRedirect(S3Request userRequest, HttpWebResponse httpResponse)
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

        private static bool IsRedirect(HttpWebResponse httpResponse)
        {
            if (httpResponse == null)
            {
                throw new ArgumentNullException("httpResponse", "Input parameter is null");
            }

            HttpStatusCode statusCode = httpResponse.StatusCode;

            return (statusCode >= HttpStatusCode.MovedPermanently &&
                statusCode < HttpStatusCode.BadRequest);
        }

        /*
         * 1. Add removed headers back to the request's headers
         * 2. If the InputStream is not-null, reset its position to 0
         */
        private void PrepareRequestForRetry(S3Request request, long orignalStreamPosition)
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

        private static bool ProcessRequestResponse<T>(HttpWebResponse httpResponse, IDictionary<S3QueryParameter, string> parameters, Type t, out T response, out Exception cause)
            where T : S3Response, new()
        {
            response = default(T);
            cause = null;
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

            try
            {
                if (actionName.Equals("GetObject"))
                {
                    response = new T();
                    Stream respStr = httpResponse.GetResponseStream();

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
                        using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd().Trim();
                        }

#if TRACE
                        DateTime streamRead = DateTime.UtcNow;
#endif
                        if (responseBody.EndsWith("/Error>"))
                        {
                            // Even though we received a 200 OK, there is a possibility of receiving an error
                            string transformed = Transform(responseBody, "S3Error", t);
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
                            string transformed = Transform(responseBody, actionName, t);

#if TRACE
                            DateTime streamParsed = DateTime.UtcNow;
#endif
                            // Attempt to deserialize response into <Action> Response type
                            XmlSerializer serializer = new XmlSerializer(typeof(T));
                            using (XmlTextReader sr = new XmlTextReader(new StringReader(transformed)))
                            {
                                response = (T)serializer.Deserialize(sr);
                            }
#if TRACE
                            DateTime objectCreated = DateTime.UtcNow;
                            Trace.Write(
                                String.Format("{0}, {1}, ",
                                (streamParsed - streamRead).TotalMilliseconds,
                                (objectCreated - streamParsed).TotalMilliseconds
                                ));
#endif
                        }
                        else
                        {
                            // We can receive responses that have no response body.
                            // All responses have headers so at a future point,
                            // we "do" attach the headers to the response.
                            response = new T();
                            response.ProcessResponseBody(responseBody);
                        }
                    }

                    // We are done with our use of the httpResponse object
                    httpResponse = null;
                }
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
            }

            return shouldRetry;
        }

        private bool ProcessRequestError(string actionName, HttpWebRequest request, WebException we, HttpWebResponse errorResponse, string requestAddr, out WebHeaderCollection respHdrs, Type t, out Exception cause)
        {
            bool shouldRetry = false;
            HttpStatusCode statusCode = default(HttpStatusCode);
            string responseBody = null;

            // Initialize the out parameter to null
            // in case there is no errorResponse
            respHdrs = null;

            if (errorResponse == null)
            {
                this.logger.Error(string.Format("Error making request {0}.", actionName), we);
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

                this.logger.Error(string.Format("Error making request {0}.", actionName), excep);
                throw excep;
            }

            if (statusCode == HttpStatusCode.InternalServerError ||
                statusCode == HttpStatusCode.ServiceUnavailable)
            {
                shouldRetry = true;
                cause = we;
            }
            else
            {
                // Attempt to deserialize response into ErrorResponse type
                using (XmlTextReader sr = new XmlTextReader(new StringReader(Transform(responseBody, "S3Error", t))))
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

                    this.logger.Error(string.Format("Error making request {0}.", actionName), excep);
                    throw excep;
                }
            }

            return shouldRetry;
        }

        /**
         * Build the Url from the parameters passed in.
         * Component parts are:
         * - ServiceURL from the Config
         * - Bucket
         * - Key
         * - urlPrefix
         * - Query
         */
        private static void AddUrlToParameters(S3Request request, AmazonS3Config config)
        {
            Map parameters = request.parameters;

            if (!config.IsSetServiceURL())
            {
                throw new AmazonS3Exception("The Amazon S3 Service URL is either null or empty");
            }

            string url = config.ServiceURL;

            if (parameters[S3QueryParameter.BucketVersion].Equals(S3Constants.BucketVersions[1]))
            {
                url = String.Concat(url, parameters[S3QueryParameter.CanonicalizedResource]);
            }
            else if (parameters.ContainsKey(S3QueryParameter.DestinationBucket))
            {
                url = String.Concat(parameters[S3QueryParameter.DestinationBucket], ".", url, "/");

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

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonEC2Config instance
         */
        private HttpWebRequest ConfigureWebRequest(S3Request request, long contentLength)
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
                if (config.IsSetProxyHost() && config.IsSetProxyPort())
                {
                    WebProxy proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                    if (config.IsSetProxyUsername())
                    {
                        proxy.Credentials = new NetworkCredential(
                            config.ProxyUsername,
                            config.ProxyPassword ?? String.Empty
                            );
                        this.logger.DebugFormat("Configured request to use proxy with host {0} and port {1} for user {2}.", config.ProxyHost, config.ProxyPort, config.ProxyUsername); 
                    }
                    else
                    {
                        this.logger.DebugFormat("Configured request to use proxy with host {0} and port {1}.", config.ProxyHost, config.ProxyPort);
                    }
                    httpRequest.Proxy = proxy;
                }

                httpRequest.UserAgent = config.UserAgent;

                string value = headers[AWSSDKUtils.IfModifiedSinceHeader];
                if (!String.IsNullOrEmpty(value))
                {
                    DateTime date = DateTime.ParseExact(value, AWSSDKUtils.GMTDateFormat, null);
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

                if (parameters.ContainsKey(S3QueryParameter.ContentType))
                {
                    httpRequest.ContentType = parameters[S3QueryParameter.ContentType];
                }

                if (parameters.ContainsKey(S3QueryParameter.Range))
                {
                    string rangeHeader = parameters[S3QueryParameter.Range];
                    char[] splitter = { ':' };
                    string[] myRange = rangeHeader.Split(splitter);
                    httpRequest.AddRange(int.Parse(myRange[0]), int.Parse(myRange[1]));
                }

                // Add the AWS Authorization header.
                httpRequest.Headers[S3Constants.AuthorizationHeader] = String.Concat(
                    "AWS ",
                    this.awsAccessKeyId,
                    ":",
                    parameters[S3QueryParameter.Authorization]);

                if (config.IsSetUserAgent())
                {
                    httpRequest.UserAgent = config.UserAgent;
                }

                // Let's enable Expect100Continue only for PutObject requests
                httpRequest.ServicePoint.Expect100Continue = request.Expect100Continue;

                // While checking the Action, for Get, Put and Copy Object, set
                // the timeout to the value specified in the request.
                if (request.SupportTimeout)
                {
                    int timeout = 0;
                    Int32.TryParse(parameters[S3QueryParameter.RequestTimeout], out timeout);
                    if (timeout > 0)
                    {
                        httpRequest.ReadWriteTimeout = timeout;
                        httpRequest.Timeout = timeout;
                    }
                }

                httpRequest.Headers.Add(headers);
                httpRequest.Method = parameters[S3QueryParameter.Verb];
                httpRequest.ContentLength = contentLength;
                httpRequest.KeepAlive = false;
                httpRequest.AllowWriteStreamBuffering = false;
                httpRequest.AllowAutoRedirect = false;
            }
            return httpRequest;
        }

        /**
         * Exponential sleep on failed request
         */
        private static void PauseOnRetry(int retries, int maxRetries, HttpStatusCode status, string requestAddr, WebHeaderCollection headers, Exception cause)
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
        private static string Transform(string responseBody, string actionName, Type t)
        {
            char[] seps = { ',' };
            Assembly assembly = Assembly.GetAssembly(t);

            string assemblyName = assembly.FullName;
            assemblyName = assemblyName.Split(seps)[0];

            // Build the name of the xslt Transform to apply to the response
            string ns = t.Namespace;
            string resourceName = String.Concat(
                assemblyName,
                ".",
                ns,
                ".Model.",
                actionName,
                "Response.xslt"
                );

            XslCompiledTransform transformer = AWSSDKUtils.GetXslCompiledTransform(resourceName);
            StringBuilder sb = new StringBuilder(1024);
            using (XmlTextReader xmlR = new XmlTextReader(new StringReader(responseBody)))
            {
                using (StringWriter sw = new StringWriter(sb))
                {
                    transformer.Transform(xmlR, null, sw);
                    return sb.ToString();
                }
            }
        }

        /// <summary>
        /// Sets the header information to use a S3CannedACL.
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="acl">Enum for the type of canned acl wanted</param>
        private static void SetCannedACLHeader(WebHeaderCollection headers, S3CannedACL acl)
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
        private static void SetIfMatchHeader(WebHeaderCollection headers, string eTag)
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
        private static void SetIfNoneMatchHeader(WebHeaderCollection headers, string eTag)
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
        private static void SetIfModifiedSinceHeader(WebHeaderCollection headers, DateTime date)
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
        private static void SetIfUnmodifiedSinceHeader(WebHeaderCollection headers, DateTime date)
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
        private static void SetIfMatchCopyHeader(WebHeaderCollection headers, string eTag)
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
        private static void SetIfNoneMatchCopyHeader(WebHeaderCollection headers, string eTag)
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
        private static void SetIfModifiedSinceCopyHeader(WebHeaderCollection headers, DateTime date)
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
        private static void SetIfUnmodifiedSinceCopyHeader(WebHeaderCollection headers, DateTime date)
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
        private static void SetMetadataDirectiveHeader(WebHeaderCollection headers, S3MetadataDirective directive)
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
        private static void SetCopySourceHeader(WebHeaderCollection headers, string bucket, string key)
        {
            string source = bucket;
            if (key != null)
            {
                source = String.Concat("/", bucket, "/", key);
            }
            headers["x-amz-copy-source"] = AmazonS3Util.UrlEncode(source, true);
        }

        /// <summary>
        /// Sets the x-amz-version-id header based on the versionId passed as input
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="versionId">The versionId of the desired S3 object</param>
        private static void SetVersionIdHeader(WebHeaderCollection headers, string versionId)
        {
            headers[S3Constants.AmzVersionIdHeader] = versionId;
        }

        /// <summary>
        /// Sets the x-amz-mfa based on the serial and token passed as input
        /// </summary>
        /// <param name="headers">The header collection to add the new header to</param>
        /// <param name="mfaCodes">The tuple of the authentication device codes</param>
        private static void SetMfaHeader(WebHeaderCollection headers, Tuple<string, string> mfaCodes)
        {
            headers[S3Constants.AmzMfaHeader] = String.Concat(mfaCodes.First, " ", mfaCodes.Second);
        }

        /**
         * Creates a string based on the parameters and encrypts it using
         * key. Returns the encrypted string.
         */
        private static string BuildSigningString(IDictionary<S3QueryParameter, string> parameters, WebHeaderCollection webHeaders)
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
                sb.Append("\n");
            }
            else
            {
                sb.Append("\n");
                sb.Append(BuildCanonicalizedHeaders(webHeaders));
            }
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
        private static StringBuilder BuildCanonicalizedHeaders(WebHeaderCollection headers)
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

        #endregion
    }
}