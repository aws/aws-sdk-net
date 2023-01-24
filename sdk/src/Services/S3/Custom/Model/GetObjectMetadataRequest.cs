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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the GetObjectMetadata operation.
    /// The HEAD action retrieves metadata from an object without returning the object itself.
    /// This action is useful if you're only interested in an object's metadata. To use HEAD,
    /// you must have READ access to the object.
    /// 
    ///  
    /// <para>
    /// A <code>HEAD</code> request has the same options as a <code>GET</code> action on an
    /// object. The response is identical to the <code>GET</code> response except that there
    /// is no response body. Because of this, if the <code>HEAD</code> request generates an
    /// error, it returns a generic <code>404 Not Found</code> or <code>403 Forbidden</code>
    /// code. It is not possible to retrieve the exact exception beyond these error codes.
    /// </para>
    ///  
    /// <para>
    /// If you encrypt an object by using server-side encryption with customer-provided encryption
    /// keys (SSE-C) when you store the object in Amazon S3, then when you retrieve the metadata
    /// from the object, you must use the following headers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-algorithm
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-key
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-key-MD5
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
    /// Encryption (Using Customer-Provided Encryption Keys)</a>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
    /// not be sent for GET requests if your object uses server-side encryption with CMKs
    /// stored in Amazon Web Services KMS (SSE-KMS) or server-side encryption with Amazon
    /// S3–managed encryption keys (SSE-S3). If your object does use these types of keys,
    /// you’ll get an HTTP 400 BadRequest error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The last modified property in this case is the creation date of the object.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// Request headers are limited to 8 KB in size. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTCommonRequestHeaders.html">Common
    /// Request Headers</a>.
    /// </para>
    ///  
    /// <para>
    /// Consider the following when using request headers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  Consideration 1 – If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code>
    /// headers are present in the request as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>If-Match</code> condition evaluates to <code>true</code>, and;
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Then Amazon S3 returns <code>200 OK</code> and the data requested.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Consideration 2 – If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code>
    /// headers are present in the request as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>If-None-Match</code> condition evaluates to <code>false</code>, and;
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>If-Modified-Since</code> condition evaluates to <code>true</code>;
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Then Amazon S3 returns the <code>304 Not Modified</code> response code.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
    /// 7232</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// You need the relevant read object (or version) permission for this operation. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
    /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
    /// S3 returns depends on whether you also have the s3:ListBucket permission.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 returns
    /// an HTTP status code 404 ("no such key") error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 returns an
    /// HTTP status code 403 ("access denied") error.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following action is related to <code>HeadObject</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetObjectMetadataRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumMode _checksumMode;
        DateTime? modifiedSinceDate;
        DateTime? unmodifiedSinceDate;
        DateTime? modifiedSinceDateUtc;
        DateTime? unmodifiedSinceDateUtc;
        string etagToMatch;
        string etagToNotMatch;
        private string key;
        private string versionId;
        private int? partNumber;
        private RequestPayer requestPayer;
        private string expectedBucketOwner;

        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket containing the object.
        /// </para>
        ///  
        /// <para>
        /// When using this action with an access point, you must direct requests to the access
        /// point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When using this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com.
        /// When using this action using S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts bucket ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumMode. 
        /// <para>
        /// This must be enabled to retrieve the checksum.
        /// </para>
        ///  
        /// <para>
        /// In addition, if you enable <code>ChecksumMode</code> and the object is KMS encrypted,
        /// you must have permission to the <code>kms:Decrypt</code> action for the request to
        /// succeed.
        /// </para>
        /// </summary>
        public ChecksumMode ChecksumMode
        {
            get { return this._checksumMode; }
            set { this._checksumMode = value; }
        }

        // Check to see if ChecksumMode property is set
        internal bool IsSetChecksumMode()
        {
            return this._checksumMode != null;
        }

        /// <summary>
        /// ETag to be matched as a pre-condition for returning the object,
        /// otherwise a PreconditionFailed signal is returned.
        /// </summary>
        public string EtagToMatch
        {
            get { return this.etagToMatch; }
            set { this.etagToMatch = value; }
        }

        // Check to see if EtagToMatch property is set
        internal bool IsSetEtagToMatch()
        {
            return this.etagToMatch != null;
        }

        /// <summary>
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ModifiedSinceDateUtc instead. Setting either ModifiedSinceDate or
        /// ModifiedSinceDateUtc results in both ModifiedSinceDate and ModifiedSinceDateUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value of both.
        /// ModifiedSinceDate is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        /// Returns the object only if it has been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ModifiedSinceDateUtc instead. Setting either ModifiedSinceDate or ModifiedSinceDateUtc results in both ModifiedSinceDate and " +
            "ModifiedSinceDateUtc being assigned, the latest assignment to either one of the two property is " +
            "reflected in the value of both. ModifiedSinceDate is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set
            {
                this.modifiedSinceDate = value;
                this.modifiedSinceDateUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }

        /// <summary>
        /// Returns the object only if it has been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime ModifiedSinceDateUtc
        {
            get { return this.modifiedSinceDateUtc.GetValueOrDefault(); }
            set
            {
                this.modifiedSinceDateUtc = value;
                this.modifiedSinceDate = value;
            }
        }

        // Check to see if ModifiedSinceDateUtc property is set
        internal bool IsSetModifiedSinceDateUtc()
        {
            return this.modifiedSinceDateUtc.HasValue;
        }

        /// <summary>
        /// ETag that should not be matched as a pre-condition for returning the object,
        /// otherwise a PreconditionFailed signal is returned.
        /// </summary>
        public string EtagToNotMatch
        {
            get { return this.etagToNotMatch; }
            set { this.etagToNotMatch = value; }
        }

        // Check to see if EtagToNotMatch property is set
        internal bool IsSetEtagToNotMatch()
        {
            return this.etagToNotMatch != null;
        }

        /// <summary>
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use UnmodifiedSinceDateUtc instead. Setting either UnmodifiedSinceDate or
        /// UnmodifiedSinceDateUtc results in both UnmodifiedSinceDate and UnmodifiedSinceDateUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value of both.
        /// UnmodifiedSinceDate is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        /// Returns the object only if it has not been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use UnmodifiedSinceDateUtc instead. Setting either UnmodifiedSinceDate or UnmodifiedSinceDateUtc results in both UnmodifiedSinceDate and " +
            "UnmodifiedSinceDateUtc being assigned, the latest assignment to either one of the two property is " +
            "reflected in the value of both. UnmodifiedSinceDate is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set
            {
                this.unmodifiedSinceDate = value;
                this.unmodifiedSinceDateUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }

        /// <summary>
        /// Returns the object only if it has not been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime UnmodifiedSinceDateUtc
        {
            get { return this.unmodifiedSinceDateUtc ?? default(DateTime); }
            set
            {
                this.unmodifiedSinceDateUtc = value;
                this.unmodifiedSinceDate = value;
            }
        }

        // Check to see if IfUnmodifiedSinceUtc property is set
        internal bool IsSetUnmodifiedSinceDateUtc()
        {
            return this.unmodifiedSinceDateUtc.HasValue;
        }

        /// <summary>
        /// The key of the object.
        /// </summary>
        /// <remarks>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </remarks>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// VersionId used to reference a specific version of the object.
        ///  
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this.serverSideCustomerEncryption; }
            set { this.serverSideCustomerEncryption = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this.serverSideCustomerEncryption != null && this.serverSideCustomerEncryption != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// The base64-encoded encryption key for Amazon S3 to use to decrypt the object
        /// <para>
        /// Using the encryption key you provide as part of your request Amazon S3 manages both the encryption, as it writes 
        /// to disks, and decryption, when you access your objects. Therefore, you don't need to maintain any data encryption code. The only 
        /// thing you do is manage the encryption keys you provide.
        /// </para>
        /// <para>
        /// When you retrieve an object, you must provide the same encryption key as part of your request. Amazon S3 first verifies 
        /// the encryption key you provided matches, and then decrypts the object before returning the object data to you.
        /// </para>
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionCustomerProvidedKey
        {
            get { return this.serverSideEncryptionCustomerProvidedKey; }
            set { this.serverSideEncryptionCustomerProvidedKey = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKey property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the ServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this.serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// Part number of the object being read. This is a positive integer between 1 and 10,000.
        /// Effectively performs a 'ranged' HEAD request for the part specified.
        /// Useful querying about the size of the part and the number of parts in this object.
        /// </summary>
        public int? PartNumber
        {
            get { return this.partNumber; }
            set
            {
                if (value.HasValue)
                {
                    if (value < 1 || 10000 < value)
                    {
                        throw new ArgumentException("PartNumber must be a positve integer between 1 and 10,000.");
                    }
                }
                
                this.partNumber = value;
            }
       }

        /// <summary>
        /// Check if PartNumber property is set.
        /// </summary>
        /// <returns>true if PartNumber property is set.</returns>
        internal bool IsSetPartNumber()
        {
            return this.partNumber.HasValue;
        }

        /// <summary>
        /// Confirms that the requester knows that she or he will be charged for the request.
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }

        /// <summary>
        /// Checks to see if RequetsPayer is set.
        /// </summary>
        /// <returns>true, if RequestPayer property is set.</returns>
        internal bool IsSetRequestPayer()
        {
            return requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request will fail with an HTTP <code>403 (Access Denied)</code> error.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }
    }
}