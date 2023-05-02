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
using System.Collections.ObjectModel;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the GetObject operation.
    /// Retrieves objects from Amazon S3. To use <code>GET</code>, you must have <code>READ</code>
    /// access to the object. If you grant <code>READ</code> access to the anonymous user,
    /// you can return the object without using an authorization header.
    /// 
    ///  
    /// <para>
    /// An Amazon S3 bucket has no directory hierarchy such as you would find in a typical
    /// computer file system. You can, however, create a logical hierarchy by using object
    /// key names that imply a folder structure. For example, instead of naming an object
    /// <code>sample.jpg</code>, you can name it <code>photos/2006/February/sample.jpg</code>.
    /// </para>
    ///  
    /// <para>
    /// To get an object from such a logical hierarchy, specify the full key name for the
    /// object in the <code>GET</code> operation. For a virtual hosted-style request example,
    /// if you have the object <code>photos/2006/February/sample.jpg</code>, specify the resource
    /// as <code>/photos/2006/February/sample.jpg</code>. For a path-style request example,
    /// if you have the object <code>photos/2006/February/sample.jpg</code> in the bucket
    /// named <code>examplebucket</code>, specify the resource as <code>/examplebucket/photos/2006/February/sample.jpg</code>.
    /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
    /// Host Header Bucket Specification</a>.
    /// </para>
    ///  
    /// <para>
    /// To distribute large files to many people, you can save bandwidth costs by using BitTorrent.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3Torrent.html">Amazon
    /// S3 Torrent</a>. For more information about returning the ACL of an object, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAcl.html">GetObjectAcl</a>.
    /// </para>
    ///  
    /// <para>
    /// If the object you are retrieving is stored in the S3 Glacier or S3 Glacier Deep Archive
    /// storage class, or S3 Intelligent-Tiering Archive or S3 Intelligent-Tiering Deep Archive
    /// tiers, before you can retrieve the object you must first restore a copy using <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_RestoreObject.html">RestoreObject</a>.
    /// Otherwise, this action returns an <code>InvalidObjectStateError</code> error. For
    /// information about restoring archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
    /// Archived Objects</a>.
    /// </para>
    ///  
    /// <para>
    /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
    /// not be sent for GET requests if your object uses server-side encryption with KMS keys
    /// (SSE-KMS) or server-side encryption with Amazon S3 managed encryption keys (SSE-S3).
    /// If your object does use these types of keys, you'll get an HTTP 400 BadRequest error.
    /// </para>
    ///  
    /// <para>
    /// If you encrypt an object by using server-side encryption with customer-provided encryption
    /// keys (SSE-C) when you store the object in Amazon S3, then when you GET the object,
    /// you must use the following headers:
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
    ///  
    /// <para>
    /// Assuming you have the relevant permission to read object tags, the response also returns
    /// the <code>x-amz-tagging-count</code> header that provides the count of number of tags
    /// associated with the object. You can use <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectTagging.html">GetObjectTagging</a>
    /// to retrieve the tag set associated with an object.
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
    /// S3 returns depends on whether you also have the <code>s3:ListBucket</code> permission.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 will
    /// return an HTTP status code 404 ("no such key") error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 will return
    /// an HTTP status code 403 ("access denied") error.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Versioning</b> 
    /// </para>
    ///  
    /// <para>
    /// By default, the GET action returns the current version of an object. To return a different
    /// version, use the <code>versionId</code> subresource.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You need the <code>s3:GetObjectVersion</code> permission to access a specific version
    /// of an object. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the current version of the object is a delete marker, Amazon S3 behaves as if the
    /// object was deleted and includes <code>x-amz-delete-marker: true</code> in the response.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// For more information about versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketVersioning.html">PutBucketVersioning</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Overriding Response Header Values</b> 
    /// </para>
    ///  
    /// <para>
    /// There are times when you want to override certain response header values in a GET
    /// response. For example, you might override the Content-Disposition response header
    /// value in your GET request.
    /// </para>
    ///  
    /// <para>
    /// You can override values for a set of response headers using the following query parameters.
    /// These response header values are sent only on a successful request, that is, when
    /// status code 200 OK is returned. The set of headers you can override using these parameters
    /// is a subset of the headers that Amazon S3 accepts when you create an object. The response
    /// headers that you can override for the GET response are <code>Content-Type</code>,
    /// <code>Content-Language</code>, <code>Expires</code>, <code>Cache-Control</code>, <code>Content-Disposition</code>,
    /// and <code>Content-Encoding</code>. To override these header values in the GET response,
    /// you use the following request parameters.
    /// </para>
    ///  <note> 
    /// <para>
    /// You must sign the request, either using an Authorization header or a presigned URL,
    /// when using these parameters. They cannot be used with an unsigned (anonymous) request.
    /// </para>
    ///  </note> <ul> <li> 
    /// <para>
    ///  <code>response-content-type</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>response-content-language</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>response-expires</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>response-cache-control</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>response-content-disposition</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>response-content-encoding</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Additional Considerations about Request Headers</b> 
    /// </para>
    ///  
    /// <para>
    /// If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code> headers
    /// are present in the request as follows: <code>If-Match</code> condition evaluates to
    /// <code>true</code>, and; <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
    /// then, S3 returns 200 OK and the data requested. 
    /// </para>
    ///  
    /// <para>
    /// If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code> headers
    /// are present in the request as follows:<code> If-None-Match</code> condition evaluates
    /// to <code>false</code>, and; <code>If-Modified-Since</code> condition evaluates to
    /// <code>true</code>; then, S3 returns 304 Not Modified response code.
    /// </para>
    ///  
    /// <para>
    /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
    /// 7232</a>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>GetObject</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListBuckets.html">ListBuckets</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAcl.html">GetObjectAcl</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetObjectRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string expectedBucketOwner;
        DateTime? modifiedSinceDate;
        DateTime? unmodifiedSinceDate;
        DateTime? modifiedSinceDateUtc;
        DateTime? unmodifiedSinceDateUtc;
        string etagToMatch;
        string etagToNotMatch;
        private string key;
        private int? partNumber;
        private ByteRange byteRange;
        private RequestPayer requestPayer;
        private DateTime? responseExpires;
        private DateTime? responseExpiresUtc;
        private ResponseHeaderOverrides responseHeaders;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;
        private string versionId;
        private ChecksumMode _checksumMode;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name containing the object. 
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
        /// When using an Object Lambda access point the hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-object-lambda.<i>Region</i>.amazonaws.com.
        /// </para>
        ///  
        /// <para>
        /// When you use this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
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
            get { return this.modifiedSinceDate ?? default(DateTime); }
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

        // Check to see if UnmodifiedSinceDateUtc property is set
        internal bool IsSetUnmodifiedSinceDateUtc()
        {
            return this.unmodifiedSinceDateUtc.HasValue;
        }

        /// <summary>
        /// Gets and sets the Key property. This is the user defined key that identifies the object in the bucket.
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
        /// Part number of the object being read. This is a positive integer between 1 and 10,000.
        /// Effectively performs a 'ranged' GET request for the part specified. Useful for downloading just a part of an object.
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
        /// Checks if PartNumber property is set.
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
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ResponseExpiresUtc instead. Setting either ResponseExpires or
        /// ResponseExpiresUtc results in both ResponseExpires and ResponseExpiresUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value of both.
        /// ResponseExpires is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        /// Sets the Expires header of the response.
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ResponseExpiresUtc instead. Setting either ResponseExpires or ResponseExpiresUtc results in both ResponseExpires and " +
            "ResponseExpiresUtc being assigned, the latest assignment to either one of the two property is " +
            "reflected in the value of both. ResponseExpires is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ResponseExpires
        {
            get { return this.responseExpires.GetValueOrDefault(); }
            set
            {
                this.responseExpires = value;
                this.responseExpiresUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }

        /// <summary>
        /// Sets the Expires header of the response.
        /// </summary>
        public DateTime ResponseExpiresUtc
        {
            get { return this.responseExpiresUtc ?? default(DateTime); }
            set
            {
                this.responseExpiresUtc = value;
                this.responseExpires = value;
            }
        }

        // Check to see if ResponseExpiresUtc property is set
        internal bool IsSetResponseExpiresUtc()
        {
            return this.responseExpiresUtc.HasValue;
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
        /// VersionId used to reference a specific version of the object.
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
        /// Downloads the specified range bytes of an object. For more information about the HTTP
        /// Range header, see <a href="https://www.rfc-editor.org/rfc/rfc9110.html#name-range">https://www.rfc-editor.org/rfc/rfc9110.html#name-range</a>.
        /// </para>
        /// <note> 
        /// <para>
        /// Amazon S3 doesn't support retrieving multiple ranges of data per <code>GET</code>
        /// request.
        /// </para>
        /// </note>
        /// </summary>
        public ByteRange ByteRange
        {
            get { return this.byteRange; }
            set { this.byteRange = value; }
        }

        // Check to see if ByteRange property is set
        internal bool IsSetByteRange()
        {
            return this.byteRange != null && this.byteRange.FormattedByteRange != null;
        }

        /// <summary>
        /// A set of response headers that should be returned with the object.
        /// </summary>
        public ResponseHeaderOverrides ResponseHeaderOverrides
        {
            get
            {
                if (this.responseHeaders == null)
                {
                    this.responseHeaders = new ResponseHeaderOverrides();
                }
                return this.responseHeaders;
            }
            set
            {
                this.responseHeaders = value;
            }
        }

        /// <summary>
        /// Gets and sets the property ChecksumMode. 
        /// <para>
        /// This must be enabled to retrieve the checksum.
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
        /// This must be enabled to retrieve the checksum
        /// </summary>
        protected override CoreChecksumResponseBehavior CoreChecksumMode
        {
            get
            {
                if (IsSetChecksumMode())
                {
                    return (CoreChecksumResponseBehavior)Enum.Parse(typeof(CoreChecksumResponseBehavior), this.ChecksumMode);
                }

                return CoreChecksumResponseBehavior.DISABLED;
            }
        }

        private static List<CoreChecksumAlgorithm> _supportedChecksumAlgorithms = new List<CoreChecksumAlgorithm>
        {
            CoreChecksumAlgorithm.CRC32C,
            CoreChecksumAlgorithm.CRC32,
            CoreChecksumAlgorithm.SHA256,
            CoreChecksumAlgorithm.SHA1
        };

        /// <summary>
        /// Checksum algorithms supported by this operation for response validation
        /// </summary>
        protected override ReadOnlyCollection<CoreChecksumAlgorithm> ChecksumResponseAlgorithms => _supportedChecksumAlgorithms.AsReadOnly();
    }
}
