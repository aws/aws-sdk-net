/*******************************************************************************
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
 *
 */

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
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;

using Amazon.Util;
using Amazon.S3.Model;
using Amazon.S3.Util;

namespace Amazon.S3
{
    using Map = System.Collections.Generic.IDictionary<Amazon.S3.Model.S3QueryParameter, string>;

    /// <summary>
    /// Amazon S3 is storage for the Internet. It is designed to make web-scale computing easier for developers.
    /// Amazon S3 provides a simple web services interface that can be used to store and retrieve any amount of data,
    /// at any time, from anywhere on the web. It gives any developer access to the same highly scalable, reliable,
    /// fast, inexpensive data storage infrastructure that Amazon uses to run its own global network of web sites.
    /// The service aims to maximize benefits of scale and to pass those benefits on to developers.
    /// </summary>
    public class AmazonS3Client : AmazonS3
    {
        #region Private Members

        private string awsAccessKeyId;
        private SecureString awsSecretAccessKey;
        private AmazonS3Config config;
        private bool disposed;
        private Type myType;

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
        /// AmazonS3 Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="amazonS3Config">The S3 Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3Config amazonS3Config)
        {
            if (awsSecretAccessKey != null)
            {
                this.awsSecretAccessKey = new SecureString();
                foreach (char ch in awsSecretAccessKey.ToCharArray())
                {
                    this.awsSecretAccessKey.AppendChar(ch);
                }
                this.awsSecretAccessKey.MakeReadOnly();
            }
            this.awsAccessKeyId = awsAccessKeyId;
            this.config = amazonS3Config;
            this.myType = this.GetType();
        }

        /// <summary>
        /// Constructs an AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// Amazon S3 Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="amazonS3Config">The S3 Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonS3Config amazonS3Config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = amazonS3Config;
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
        /// operations on your bucket.
        /// </summary>
        /// <param name="request">The GetPreSignedUrlRequest that defines the 
        /// parameters of the operation.</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        public string GetPreSignedURL(GetPreSignedUrlRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The PreSignedUrlRequest specified is null!");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName Specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The Key Specified is null or empty!");
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

            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonS3Exception("The AWS Access Key ID cannot be NULL or a Zero length string");
            }

            ConvertGetPreSignedUrl(request);
            IDictionary<S3QueryParameter, string> parameters = request.parameters;

            string urlPrefix = "https://";
            if (request.Protocol == Protocol.HTTP)
            {
                 urlPrefix = "http://";
            }

            // Use V2 bucket addressing if possible, otherwise use V1.
            StringBuilder signedURL = new StringBuilder(urlPrefix, 512);

            // Get the bucket version from the parameters;
            // the version is added by AddS3QueryParameters
            string bucketVer = parameters[S3QueryParameter.BucketVersion];
            if (bucketVer.Equals(S3Constants.BucketVersions[2]))
            {
                // V2 style addressing
                signedURL.Append(request.BucketName);
                signedURL.Append(".");
                signedURL.Append(S3Constants.S3DefaultEndpoint);
                signedURL.Append("/");
                signedURL.Append(AmazonS3Util.UrlEncode(request.Key, true));
            }
            else
            {
                // Path style addressing
                signedURL.Append(S3Constants.S3DefaultEndpoint);
                signedURL.Append("/").Append(request.BucketName).Append("/");
                signedURL.Append(AmazonS3Util.UrlEncode(request.Key, true));
            }
            signedURL.Append("?AWSAccessKeyId=");
            signedURL.Append(this.awsAccessKeyId);
            signedURL.Append("&Expires=");
            signedURL.Append(parameters[S3QueryParameter.Expires]);
            signedURL.Append("&Signature=");
            signedURL.Append(AmazonS3Util.UrlEncode(parameters[S3QueryParameter.Authorization], false));
            return signedURL.ToString();
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

             if (!config.IsSetGrants()) 
             {
                 throw new ArgumentNullException(S3Constants.RequestParam, "The Grants of the LoggingConfig is null!");
             }
            
            if (!config.IsSetTargetBucketName())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The BucketName of the LoggingConfig is null or empty!");
            }

            if (!config.IsSetTargetPrefix())
            {
                throw new ArgumentNullException(S3Constants.RequestParam, "The TargetPrefix of the LoggingConfig is null!");
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

            ConvertSetBucketVersioning(request);
            return Invoke<SetBucketVersioningResponse>(request);
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
        /// <remarks><para>
        /// Since buckets can contain a virtually unlimited number of objects, the complete 
        /// results of a list query can be extremely large. To manage large result sets, 
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should 
        /// always check the <see cref="P:Amazon.S3.Model.ListObjectsResponse.IsTruncated" />
        /// to see if the returned listing 
        /// is complete, or if callers need to make additional calls to get more results.
        /// The marker parameter allows callers to specify where to start the object listing. 
        /// </para>
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
        /// <remarks><para>
        /// Since buckets can contain a virtually unlimited number of objects, the complete 
        /// results of a list query can be extremely large. To manage large result sets, 
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should 
        /// always check the <see cref="P:Amazon.S3.Model.ListVersionsResonse.IsTruncated" />
        /// to see if the returned listing 
        /// is complete, or if callers need to make additional calls to get more results.
        /// The KeyMarker and VersionIdMarker parameters of the ListVersionsRequest object
        /// allow callers to specify where to start the version listing. 
        /// </para>
        /// <para>In order to enable versioning on a bucket, please refer to the 
        /// <see cref="M:Amazon.S3.AmazonS3Client.SetBucketVersioning">SetBucketVersioning</see>
        /// operation's details.
        /// </para>
        /// List performance is not substantially affected by the total number of keys in your 
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
        /// <remarks><para>
        /// Every object stored in Amazon S3 is contained in a bucket. Buckets
        /// partition the namespace of objects stored in Amazon S3 at the top level.
        /// Within a bucket, you can use any names for your objects, but bucket names
        /// must be unique across all of Amazon S3.
        /// </para><para>
        /// Buckets are similar to Internet domain names. Just as Amazon is the only owner
        /// of the domain name Amazon.com, only one person or organization can own a bucket
        /// within Amazon S3. The similarities between buckets and domain names is not a
        /// coincidence - there is a direct mapping between Amazon S3 buckets and subdomains
        /// of s3.amazonaws.com. Objects stored in Amazon S3 are addressable using the REST API
        /// under the domain bucketname.s3.amazonaws.com. For example, the object homepage.html
        /// stored in the Amazon S3 bucket mybucket can be addressed as
        /// http://mybucket.s3.amazonaws.com/homepage.html.
        ///</para>
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
                throw new ArgumentNullException(S3Constants.RequestParam, "An S3 Bucket must be specified for S3 PUT object.");
            }
                
            if (!(request.IsSetKey() || request.IsSetFilePath()))
            {
                throw new ArgumentException(
                    "Either a Key or a Filename need to be specified for S3 PUT object.",
                    S3Constants.RequestParam
                    );
            }

            // Either:
            // 1. A file is being transferred - so a filename or a stream needs to be provided
            // 2. The content body needs to be set
            if (!request.IsSetFilePath() &&
                !request.IsSetInputStream() &&
                !request.IsSetContentBody())
            {
                throw new ArgumentException(
                    "Please specify either a Filename, provide a FileStream or provide a ContentBody to PUT an object into S3.",
                    S3Constants.RequestParam
                    );
            }

            if (request.IsSetInputStream() && request.IsSetContentBody())
            {
                throw new ArgumentException(
                    "Please specify one of either an Input FileStream or the ContentBody to be PUT as an S3 object.",
                    S3Constants.RequestParam
                    );
            }

            if (request.IsSetInputStream() && request.IsSetFilePath())
            {
                throw new ArgumentException(
                    "Please specify one of either an Input FileStream or a Filename to be PUT as an S3 object.",
                    S3Constants.RequestParam
                    );
            }

            if (request.IsSetFilePath() && request.IsSetContentBody())
            {
                throw new ArgumentException(
                    "Please specify one of either a Filename or the ContentBody to be PUT as an S3 object.",
                    S3Constants.RequestParam
                    );
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

            ConvertPutObject(request);
            return Invoke<PutObjectResponse>(request);
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

            ConvertDeleteObject(request);
            return Invoke<DeleteObjectResponse>(request);
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
            webHeaders[AWSSDKUtils.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;
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
                webHeaders[AWSSDKUtils.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;
            }

            if (request.IsSetCannedACL())
            {
                webHeaders.Add(GetCannedACLHeader(request.CannedACL));
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
         *
         */
        private void ConvertPutBucket(PutBucketRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.PutVerb;
            parameters[S3QueryParameter.Action] = "PutBucket";

            if (request.BucketRegion == S3Region.EU)
            {
                string content = String.Format("<CreateBucketConstraint><LocationConstraint>{0}</LocationConstraint></CreateBucketConstraint>", request.BucketRegion.ToString());
                parameters[S3QueryParameter.ContentBody] = content;
            }
            else if (request.BucketRegion == S3Region.SFO)
            {
                string content = String.Format("<CreateBucketConstraint><LocationConstraint>us-west-1</LocationConstraint></CreateBucketConstraint>");
                parameters[S3QueryParameter.ContentBody] = content;
            }
            AddS3QueryParameters(request, request.BucketName);
        }

        /**
         *
         */
        private void ConvertDeleteBucket(DeleteBucketRequest request)
        {
            Map parameters = request.parameters;

            parameters[S3QueryParameter.Verb] = S3Constants.DeleteVerb;
            parameters[S3QueryParameter.Action] = "DeleteBucket";
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
                webHeaders.Add(GetIfMatchHeader(request.ETagToMatch));
            }
            if (request.IsSetETagToNotMatch())
            {
                webHeaders.Add(GetIfNoneMatchHeader(request.ETagToNotMatch));
            }
            if (request.IsSetModifiedSinceDate())
            {
                webHeaders.Add(GetIfModifiedSinceHeader(request.ModifiedSinceDate));
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                webHeaders.Add(GetIfUnmodifiedSinceHeader(request.UnmodifiedSinceDate));
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
                webHeaders.Add(GetIfNoneMatchHeader(request.ETagToNotMatch));
            }
            if (request.IsSetModifiedSinceDate())
            {
                webHeaders.Add(GetIfModifiedSinceHeader(request.ModifiedSinceDate));
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                webHeaders.Add(GetIfUnmodifiedSinceHeader(request.UnmodifiedSinceDate));
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
                webHeaders[AWSSDKUtils.ContentTypeHeader] = request.ContentType;
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
            }

            // Add the Timeout parameter
            parameters[S3QueryParameter.RequestTimeout] = request.Timeout.ToString();

            // Add the Put Object specific headers to the request
            // 1. The Canned ACL
            if (request.IsSetCannedACL())
            {
                webHeaders.Add(GetCannedACLHeader(request.CannedACL));
            }

            // 2. The MetaData
            if (request.IsSetMetaData())
            {
                // Add headers of type x-amz-meta-<key> to the request
                foreach (string key in request.metaData)
                {
                    webHeaders[String.Concat("x-amz-meta-", key)] = request.metaData[key];
                }
            }

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
            parameters[S3QueryParameter.Key] = request.Key;
            string value = Convert.ToInt64((request.Expires.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
            parameters[S3QueryParameter.Expires] = value;

            AddS3QueryParameters(request, request.BucketName);
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
                webHeaders.Add(GetIfMatchCopyHeader(request.ETagToMatch));
            }
            if (request.IsSetETagToNotMatch())
            {
                webHeaders.Add(GetIfNoneMatchCopyHeader(request.ETagToNotMatch));
            }
            if (request.IsSetModifiedSinceDate())
            {
                webHeaders.Add(GetIfModifiedSinceCopyHeader(request.ModifiedSinceDate));
            }
            if (request.IsSetUnmodifiedSinceDate())
            {
                webHeaders.Add(GetIfUnmodifiedSinceCopyHeader(request.UnmodifiedSinceDate));
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
            webHeaders.Add(GetCopySourceHeader(request.SourceBucket, sourceKey));

            // there is always a directive associated with the request
            webHeaders.Add(GetMetadataDirectiveHeader(request.Directive));

            // if the user has specified the REPLACE directive
            // and specified new metadata for the copied object
            // specify the metadata using the x-amz-meta header
            if (request.Directive == S3MetadataDirective.REPLACE &&
                request.IsSetMetaData())
            {
                // Add headers of type x-amz-meta-<key> to the request
                foreach (string key in request.metaData)
                {
                    webHeaders[String.Concat("x-amz-meta-", key)] = request.metaData[key];
                }
            }

            // The Canned ACL
            if (request.IsSetCannedACL())
            {
                webHeaders.Add(GetCannedACLHeader(request.CannedACL));
            }

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

            webHeaders[AWSSDKUtils.ContentTypeHeader] = AWSSDKUtils.UrlEncodedContent;

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
                parameters[S3QueryParameter.DestinationBucket] =  destinationBucket;
                if (AmazonS3Util.ValidateV2Bucket(destinationBucket))
                {
                    parameters[S3QueryParameter.BucketVersion] = S3Constants.BucketVersions[2];
                }
                else
                {
                    parameters[S3QueryParameter.BucketVersion] = S3Constants.BucketVersions[1];
                }
                canonicalResource.Append(destinationBucket);
                canonicalResource.Append("/");
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
            parameters[S3QueryParameter.Authorization] = BuildSigningString(parameters, webHeaders, this.awsSecretAccessKey);

            // Insert the S3 Url into the parameters
            GetUrlFromParameters(parameters, config);
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
            int maxRetries = config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : S3Constants.DefaultMaxRetry;

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
                verb.Equals(S3Constants.HeadVerb)))
            {
                throw new AmazonS3Exception("Invalid HTTP Operation attempted! Supported operations - GET, HEAD, PUT, DELETE");
            }

            if (verb.Equals(S3Constants.PutVerb))
            {
                if (parameters.ContainsKey(S3QueryParameter.ContentBody))
                {
                    string reqBody = parameters[S3QueryParameter.ContentBody];
                    requestData = Encoding.UTF8.GetBytes(reqBody);

                    // Since there is a request body, determine the length of the
                    // data that will be sent to the server.
                    reqDataLen = requestData.Length;
                    parameters[S3QueryParameter.ContentLength] = reqDataLen.ToString();
                }

                if (parameters.ContainsKey(S3QueryParameter.ContentLength))
                {
                    reqDataLen = Int64.Parse(parameters[S3QueryParameter.ContentLength]);
                    if (reqDataLen > S3Constants.MaxS3ObjectSize)
                    {
                        throw new AmazonS3Exception(
                            "Your proposed upload exceeds the maximum allowed object size",
                            HttpStatusCode.BadRequest,
                            "EntityTooLarge",
                            "",
                            "",
                            "",
                            config.ServiceURL,
                            null
                            );
                    }
                }
            }

            bool shouldRetry;
            int retries = 0;
            string requestAddr = null;

            try
            {
                HttpWebRequest request;
                HttpWebResponse httpResponse = null;
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
                                    // Reset the file stream's position to the starting point
                                    fStream.Position = 0;
                                    byte[] buffer = new byte[65536];
                                    int bytesRead = 0;
                                    while ((bytesRead = fStream.Read(buffer, 0, buffer.Length)) > 0)
                                    {
                                        requestStream.Write(buffer, 0, bytesRead);
                                    }
                                }
                                else
                                {
                                    using (MemoryStream ms = new MemoryStream(requestData))
                                    {
                                        byte[] buffer = new byte[32768];
                                        int count = 0;
                                        while ((count = ms.Read(buffer, 0, buffer.Length)) > 0)
                                        {
                                            requestStream.Write(buffer, 0, count);
                                        }
                                    }
                                }
                            }
                        }

                        httpResponse = request.GetResponse() as HttpWebResponse;
                        statusCode = httpResponse.StatusCode;
                        if (!IsRedirect(httpResponse))
                        {
                            // The request submission has completed. Retrieve the response.
                            response = ProcessRequestResponse<T>(httpResponse, parameters, myType);
                        }
                        else
                        {
                            shouldRetry = true;

                            ProcessRedirect(userRequest, httpResponse);

                            PauseOnRetry(++retries, maxRetries, statusCode, requestAddr, httpResponse.Headers);

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
                    // Web exception is thrown on unsucessful responses
                    catch (WebException we)
                    {
                        WebHeaderCollection respHdrs;
                        statusCode = ((HttpWebResponse)we.Response).StatusCode;
                        shouldRetry = ProcessRequestError(request, we, requestAddr, out respHdrs, myType);

                        if (httpResponse != null)
                        {
                            httpResponse.Close();
                            httpResponse = null;
                        }
                        // Abort the unsuccessful request regardless of whether we should
                        // or shouldn't retry.
                        request.Abort();
                        
                        if (shouldRetry)
                        {
                            PauseOnRetry(++retries, maxRetries, statusCode, requestAddr, respHdrs);
                        }
                    }
                    catch (IOException)
                    {
                        if (httpResponse != null)
                        {
                            httpResponse.Close();
                            httpResponse = null;
                        }
                        // Abort the unsuccessful request 
                        request.Abort();

                        throw;
                    }

                    if (shouldRetry)
                    {
                        // Reset the request so that streams are recreated,
                        // removed headers are added back, etc
                        PrepareRequestForRetry(userRequest);
                    }
                } while (shouldRetry && retries <= maxRetries);
            }
            finally
            {
                // Regardless of what happens, if a file stream
                // was passed in by the user, it should be closed               
                if (fStream != null)
                {
                    fStream.Close();
                }
            }

            return response;
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
            if (!String.IsNullOrEmpty(value = respHeaders.Get("Location")))
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
        private void PrepareRequestForRetry(S3Request request)
        {
            if (request.InputStream != null)
            {
                request.InputStream.Position = 0;
            }

            if (request.removedHeaders.Count > 0)
            {
                request.Headers.Add(request.removedHeaders);
            }
        }

        private static T ProcessRequestResponse<T>(HttpWebResponse httpResponse, IDictionary<S3QueryParameter, string> parameters, Type t)
            where T : S3Response, new()
        {
            T response = default(T);
            string actionName = parameters[S3QueryParameter.Action];

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
                            string checksumFromS3 = headerCollection.Get(AWSSDKUtils.ETagHeader);
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
                                    httpResponse.Headers
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
                            responseBody = reader.ReadToEnd();
                        }

                        // Perform response transformation
                        if (responseBody.EndsWith(">"))
                        {
                            string transformed = Transform(responseBody, actionName, t);

                            // Attempt to deserialize response into <Action> Response type
                            XmlSerializer serializer = new XmlSerializer(typeof(T));
                            using (XmlTextReader sr = new XmlTextReader(new StringReader(transformed)))
                            {
                                response = (T)serializer.Deserialize(sr);
                            }
                        }
                        else
                        {
                            // We can receive responses that have no response body.
                            // All responses have headers so at a future point,
                            // we "do" attach the headers to the response.
                            response = new T();
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

            return response;
        }

        private static bool ProcessRequestError(HttpWebRequest request, WebException we, string requestAddr, out WebHeaderCollection respHdrs, Type t)
        {
            bool shouldRetry = false;
            HttpStatusCode statusCode = default(HttpStatusCode);
            string responseBody = null;

            // Initialize the out parameter to null
            // in case there is no httpErrorResponse
            respHdrs = null;

            using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
            {
                if (httpErrorResponse == null)
                {
                    throw new WebException(
                        "The Web Response for a request error is null!",
                        WebExceptionStatus.ProtocolError
                        );
                }

                // Set the response headers for future use
                respHdrs = httpErrorResponse.Headers;

                // Obtain the HTTP status code
                statusCode = httpErrorResponse.StatusCode;

                using (StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                {
                    responseBody = reader.ReadToEnd();
                }

                if (request.Method.Equals("HEAD") &&
                    statusCode == HttpStatusCode.NotFound)
                {
                    throw new AmazonS3Exception(
                        we.Message,
                        statusCode,
                        "NoSuchKey",
                        respHdrs[S3Constants.AmzRequestIdHeader],
                        "",
                        "",
                        requestAddr,
                        respHdrs
                        );
                }

                if (statusCode == HttpStatusCode.InternalServerError ||
                    statusCode == HttpStatusCode.ServiceUnavailable)
                {
                    shouldRetry = true;
                }
                else
                {
                    // Attempt to deserialize response into ErrorResponse type
                    using (XmlTextReader sr = new XmlTextReader(new StringReader(Transform(responseBody, "S3Error", t))))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(S3Error));
                        S3Error error = (S3Error)serializer.Deserialize(sr);

                        // Throw formatted exception with information available from the error response
                        throw new AmazonS3Exception(
                            error.Message,
                            statusCode,
                            error.Code,
                            error.RequestId,
                            error.HostId,
                            responseBody,
                            requestAddr,
                            respHdrs
                            );
                    }
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
        private static void GetUrlFromParameters(IDictionary<S3QueryParameter, string> parameters, AmazonS3Config config)
        {
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

            if (config.IsSetProxyHost() && config.IsSetProxyPort())
            {
                httpRequest.Proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
            }
            httpRequest.UserAgent = config.UserAgent;

            string value = headers.Get(AWSSDKUtils.IfModifiedSinceHeader);
            if (!String.IsNullOrEmpty(value))
            {
                DateTime date = DateTime.ParseExact(value, AWSSDKUtils.GMTDateFormat, null);
                httpRequest.IfModifiedSince = date;
                headers.Remove(AWSSDKUtils.IfModifiedSinceHeader);
                request.removedHeaders[AWSSDKUtils.IfModifiedSinceHeader] = value;
            }

            value = headers.Get(AWSSDKUtils.ContentTypeHeader);
            if (!String.IsNullOrEmpty(value))
            {
                httpRequest.ContentType = value;
                headers.Remove(AWSSDKUtils.ContentTypeHeader);
                request.removedHeaders[AWSSDKUtils.ContentTypeHeader] = value;
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

            value = parameters[S3QueryParameter.Action];
            // Let's enable Expect100Continue only for PutObject requests
            httpRequest.ServicePoint.Expect100Continue = value.Equals("PutObject");

            // While checking the Action, for Put and Copy Object, set
            // the timeout to the value specified in the request.
            if (value.Equals("PutObject") ||
                value.Equals("CopyObject"))
            {
                int timeout = S3Constants.PutObjectDefaultTimeout;
                Int32.TryParse(parameters[S3QueryParameter.RequestTimeout], out timeout);
                httpRequest.ReadWriteTimeout = timeout;
                httpRequest.Timeout = timeout;
            }
            
            httpRequest.Headers.Add(headers);
            httpRequest.Method = parameters[S3QueryParameter.Verb];
            httpRequest.ContentLength = contentLength;
            httpRequest.KeepAlive = false;
            httpRequest.AllowWriteStreamBuffering = false;
            httpRequest.AllowAutoRedirect = false;

            return httpRequest;
        }

        /**
         * Exponential sleep on failed request
         */
        private static void PauseOnRetry(int retries, int maxRetries, HttpStatusCode status, string requestAddr, WebHeaderCollection headers)
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
                    "",
                    "",
                    "",
                    "",
                    requestAddr,
                    headers
                    );
            }
        }

        /*
         *  Transforms response based on xslt template
         */
        private static string Transform(string responseBody, string actionName, Type t)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();
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
        /// Gets the header information to use a S3CannedACL.
        /// </summary>
        /// <param name="acl">Enum for the type of canned acl wanted</param>
        /// <returns>A key/value to be used in a http header for the S3CannedACL parameter</returns>
        private static NameValueCollection GetCannedACLHeader(S3CannedACL acl)
        {
            return AmazonS3Util.CreateHeaderEntry(
                S3Constants.AmzAclHeader, 
                S3Constants.CannedAcls[(int)acl]
                );
        }

        /// <summary>
        /// Creates an If-Match Header.
        ///
        /// Return the object only if its entity tag (ETag) is the same as the one
        /// specified, otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="eTag">The ETag to match against</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetIfMatchHeader(string eTag)
        {
            return AmazonS3Util.CreateHeaderEntry(AWSSDKUtils.IfMatchHeader, eTag);
        }

        /// <summary>
        /// Creates an If-None-Match Header.
        ///
        /// Return the object only if its entity tag (ETag) is different from the one
        /// specified, otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="eTag">The ETag to match against</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetIfNoneMatchHeader(string eTag)
        {
            return AmazonS3Util.CreateHeaderEntry("If-None-Match", eTag);
        }

        /// <summary>
        /// Creates an If-Modifed-Since Header.
        ///
        /// Return the object only if it has been modified since the specified time,
        /// otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="date">DateTime Object representing the date to use</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetIfModifiedSinceHeader(DateTime date)
        {
            return AmazonS3Util.CreateHeaderEntry(
                AWSSDKUtils.IfModifiedSinceHeader,
                date.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat)
                );
        }

        /// <summary>
        /// Creates an If-Unmodifed-Since Header.
        ///
        /// Return the object only if it has not been modified since the specified time,
        /// otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="date">DateTime Object representing the date to use</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetIfUnmodifiedSinceHeader(DateTime date)
        {
            return AmazonS3Util.CreateHeaderEntry(
                "If-Unmodified-Since",
                date.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat)
                );
        }

        /// <summary>
        /// Creates an If-Match Header for the CopyObject operation.
        ///
        /// Return the object only if its entity tag (ETag) is the same as the one
        /// specified, otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="eTag">The ETag to match against</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetIfMatchCopyHeader(string eTag)
        {
            return AmazonS3Util.CreateHeaderEntry("x-amz-copy-source-if-match", eTag);
        }

        /// <summary>
        /// Creates an If-None-Match Header for the CopyObject operation.
        ///
        /// Return the object only if its entity tag (ETag) is different from the one
        /// specified, otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="eTag">The ETag to match against</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetIfNoneMatchCopyHeader(string eTag)
        {
            return AmazonS3Util.CreateHeaderEntry("x-amz-copy-source-if-none-match", eTag);
        }

        /// <summary>
        /// Creates an If-Modifed-Since Header for the CopyObject operation.
        ///
        /// Return the object only if it has been modified since the specified time,
        /// otherwise return a 304 (not modified).
        /// </summary>
        /// <param name="date">DateTime Object representing the date to use</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetIfModifiedSinceCopyHeader(DateTime date)
        {
            return AmazonS3Util.CreateHeaderEntry(
                "x-amz-copy-source-if-modified-since",
                date.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat)
                );
        }

        /// <summary>
        /// Creates an If-Unmodifed-Since Header for the CopyObject operation.
        ///
        /// Return the object only if it has not been modified since the specified time,
        /// otherwise return a 412 (precondition failed).
        /// </summary>
        /// <param name="date">DateTime Object representing the date to use</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetIfUnmodifiedSinceCopyHeader(DateTime date)
        {
            return AmazonS3Util.CreateHeaderEntry(
                "x-amz-copy-source-if-unmodified-since",
                date.ToUniversalTime().ToString(AWSSDKUtils.GMTDateFormat)
                );
        }

        /// <summary>
        /// Valid values: COPY | REPLACE
        /// Constraints: Values other than COPY or REPLACE result in an immediate 400-based error
        /// response. You cannot copy an object to itself unless the S3MetadataDirective header is
        /// specified and its value set to REPLACE.
        /// </summary>
        /// <param name="directive">Either COPY or REPLACE</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetMetadataDirectiveHeader(S3MetadataDirective directive)
        {
            return AmazonS3Util.CreateHeaderEntry(
                S3Constants.AmzMetadataDirectiveHeader, 
                S3Constants.MetaDataDirectives[(int)directive]
                );
        }

        /// <summary>
        /// Returns an x-amz-copy-source header based on the bucket and key passed
        /// as input.
        /// </summary>
        /// <param name="bucket">The source bucket</param>
        /// <param name="key">The source key</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetCopySourceHeader(string bucket, string key)
        {
            string source = bucket;
            if (key != null)
            {
                source = String.Concat("/", bucket, "/", key);
            }
            return AmazonS3Util.CreateHeaderEntry("x-amz-copy-source", AmazonS3Util.UrlEncode(source, true));
        }

        /// <summary>
        /// Returns an x-amz-version-id header based on the versionId passed as input
        /// </summary>
        /// <param name="versionId">The versionId of the desired S3 object</param>
        /// <returns>A name value collection with the appropriate header information</returns>
        private static NameValueCollection GetVersionIdHeader(string versionId)
        {
            return AmazonS3Util.CreateHeaderEntry(
                S3Constants.AmzVersionIdHeader, 
                versionId
                );
        }

        /**
         * Creates a string based on the parameters and encrypts it using
         * key. Returns the encrypted string.
         */
        private static string BuildSigningString(IDictionary<S3QueryParameter, string> parameters, WebHeaderCollection webHeaders, SecureString key)
        {
            KeyedHashAlgorithm algorithm = new HMACSHA1();
            StringBuilder sb = new StringBuilder("", 256);
            string value = null;

            sb.Append(parameters[S3QueryParameter.Verb]);
            sb.Append("\n");

            if (webHeaders != null)
            {
                if (!String.IsNullOrEmpty(value = webHeaders.Get(AWSSDKUtils.ContentMD5Header)))
                {
                    sb.Append(value);
                }
                sb.Append("\n");

                if (!String.IsNullOrEmpty(value = webHeaders.Get(AWSSDKUtils.ContentTypeHeader)))
                {
                    sb.Append(value);
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

            return AmazonS3Util.Sign(sb.ToString(), key, algorithm);
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
