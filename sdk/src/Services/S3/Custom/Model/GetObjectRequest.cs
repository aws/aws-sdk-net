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
    /// Retrieves an object from Amazon S3.
    /// 
    ///  
    /// <para>
    /// In the <code>GetObject</code> request, specify the full key name for the object.
    /// </para>
    ///  
    /// <para>
    ///  <b>General purpose buckets</b> - Both the virtual-hosted-style requests and the path-style
    /// requests are supported. For a virtual hosted-style request example, if you have the
    /// object <code>photos/2006/February/sample.jpg</code>, specify the object key name as
    /// <code>/photos/2006/February/sample.jpg</code>. For a path-style request example, if
    /// you have the object <code>photos/2006/February/sample.jpg</code> in the bucket named
    /// <code>examplebucket</code>, specify the object key name as <code>/examplebucket/photos/2006/February/sample.jpg</code>.
    /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
    /// Host Header Bucket Specification</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - Only virtual-hosted-style requests are supported. For
    /// a virtual hosted-style request example, if you have the object <code>photos/2006/February/sample.jpg</code>
    /// in the bucket named <code>examplebucket--use1-az5--x-s3</code>, specify the object
    /// key name as <code>/photos/2006/February/sample.jpg</code>. Also, when you make requests
    /// to this API operation, your requests are sent to the Zonal endpoint. These endpoints
    /// support virtual-hosted-style requests in the format <code>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </code>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - You must have the required permissions
    /// in a policy. To use <code>GetObject</code>, you must have the <code>READ</code> access
    /// to the object (or version). If you grant <code>READ</code> access to the anonymous
    /// user, the <code>GetObject</code> operation returns the object without using an authorization
    /// header. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
    /// permissions in a policy</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you include a <code>versionId</code> in your request header, you must have the
    /// <code>s3:GetObjectVersion</code> permission to access a specific version of an object.
    /// The <code>s3:GetObject</code> permission is not required in this scenario.
    /// </para>
    ///  
    /// <para>
    /// If you request the current version of an object without a specific <code>versionId</code>
    /// in the request header, only the <code>s3:GetObject</code> permission is required.
    /// The <code>s3:GetObjectVersion</code> permission is not required in this scenario.
    /// 
    /// </para>
    ///  
    /// <para>
    /// If the object that you request doesn’t exist, the error that Amazon S3 returns depends
    /// on whether you also have the <code>s3:ListBucket</code> permission.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 returns
    /// an HTTP status code <code>404 Not Found</code> error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 returns an
    /// HTTP status code <code>403 Access Denied</code> error.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation on a
    /// directory bucket, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <code>CreateSession</code> </a> API operation for session-based authorization. Specifically,
    /// you grant the <code>s3express:CreateSession</code> permission to the directory bucket
    /// in a bucket policy or an IAM identity-based policy. Then, you make the <code>CreateSession</code>
    /// API call on the bucket to obtain a session token. With the session token in your request
    /// header, you can make API requests to this operation. After the session token expires,
    /// you make another <code>CreateSession</code> API call to generate a new session token
    /// for use. Amazon Web Services CLI or SDKs create session and refresh the session token
    /// automatically to avoid service interruptions when a session expires. For more information
    /// about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <code>CreateSession</code> </a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Storage classes</dt> <dd> 
    /// <para>
    /// If the object you are retrieving is stored in the S3 Glacier Flexible Retrieval storage
    /// class, the S3 Glacier Deep Archive storage class, the S3 Intelligent-Tiering Archive
    /// Access tier, or the S3 Intelligent-Tiering Deep Archive Access tier, before you can
    /// retrieve the object you must first restore a copy using <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_RestoreObject.html">RestoreObject</a>.
    /// Otherwise, this operation returns an <code>InvalidObjectState</code> error. For information
    /// about restoring archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
    /// Archived Objects</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, only the S3 Express One Zone storage
    /// class is supported to store newly created objects. Unsupported storage class values
    /// won't write a destination object and will respond with the HTTP status code <code>400
    /// Bad Request</code>.
    /// </para>
    ///  </dd> <dt>Encryption</dt> <dd> 
    /// <para>
    /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
    /// not be sent for the <code>GetObject</code> requests, if your object uses server-side
    /// encryption with Amazon S3 managed encryption keys (SSE-S3), server-side encryption
    /// with Key Management Service (KMS) keys (SSE-KMS), or dual-layer server-side encryption
    /// with Amazon Web Services KMS keys (DSSE-KMS). If you include the header in your <code>GetObject</code>
    /// requests for the object that uses these types of keys, you’ll get an HTTP <code>400
    /// Bad Request</code> error.
    /// </para>
    ///  </dd> <dt>Overriding response header values through the request</dt> <dd> 
    /// <para>
    /// There are times when you want to override certain response header values of a <code>GetObject</code>
    /// response. For example, you might override the <code>Content-Disposition</code> response
    /// header value through your <code>GetObject</code> request.
    /// </para>
    ///  
    /// <para>
    /// You can override values for a set of response headers. These modified response header
    /// values are included only in a successful response, that is, when the HTTP status code
    /// <code>200 OK</code> is returned. The headers you can override using the following
    /// query parameters in the request are a subset of the headers that Amazon S3 accepts
    /// when you create an object. 
    /// </para>
    ///  
    /// <para>
    /// The response headers that you can override for the <code>GetObject</code> response
    /// are <code>Cache-Control</code>, <code>Content-Disposition</code>, <code>Content-Encoding</code>,
    /// <code>Content-Language</code>, <code>Content-Type</code>, and <code>Expires</code>.
    /// </para>
    ///  
    /// <para>
    /// To override values for a set of response headers in the <code>GetObject</code> response,
    /// you can use the following query parameters in the request.
    /// </para>
    ///  <ul> <li> 
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
    ///  </li> <li> 
    /// <para>
    ///  <code>response-content-language</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>response-content-type</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>response-expires</code> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// When you use these parameters, you must sign the request by using either an Authorization
    /// header or a presigned URL. These parameters cannot be used with an unsigned (anonymous)
    /// request.
    /// </para>
    ///  </note> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <code> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</code>.
    /// </para>
    ///  </dd> </dl> 
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
        ///  <b>Directory buckets</b> - When you use this operation with a directory bucket, you
        /// must use virtual-hosted-style requests in the format <code> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</code>.
        /// Path-style requests are not supported. Directory bucket names must be unique in the
        /// chosen Availability Zone. Bucket names must follow the format <code> <i>bucket_base_name</i>--<i>az-id</i>--x-s3</code>
        /// (for example, <code> <i>DOC-EXAMPLE-BUCKET</i>--<i>usw2-az2</i>--x-s3</code>). For
        /// information about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access points</b> - When you use this action with an access point, you must provide
        /// the alias of the access point in place of the bucket name or specify the access point
        /// ARN. When using the access point ARN, you must direct requests to the access point
        /// hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Object Lambda access points</b> - When you use this action with an Object Lambda
        /// access point, you must direct requests to the Object Lambda access point hostname.
        /// The Object Lambda access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-object-lambda.<i>Region</i>.amazonaws.com.
        /// </para>
        ///  <note> 
        /// <para>
        /// Access points and Object Lambda access points are not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>S3 on Outposts</b> - When you use this action with Amazon S3 on Outposts, you
        /// must direct requests to the S3 on Outposts hostname. The S3 on Outposts hostname takes
        /// the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <code>403 Forbidden</code> (access denied).
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
        public DateTime? ModifiedSinceDate
        {
            get { return this.modifiedSinceDate; }
            set
            {
                if (value == null)
                {
                    this.modifiedSinceDate = null;
                    this.modifiedSinceDateUtc = null;
                }
                else
                {
                    this.modifiedSinceDate = value;
                    this.modifiedSinceDateUtc = new DateTime(value.Value.Ticks, DateTimeKind.Utc);
                }
            }
        }

        /// <summary>
        /// Returns the object only if it has been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime? ModifiedSinceDateUtc
        {
            get { return this.modifiedSinceDateUtc ?? default(DateTime); }
            set
            {
                if (value == null)
                {
                    this.modifiedSinceDate = null;
                    this.modifiedSinceDateUtc = null;
                }
                else
                {
                    this.modifiedSinceDateUtc = value;
                    this.modifiedSinceDate = value;
                }
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
        public DateTime? UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate ?? default(DateTime); }
            set
            {
                if (value == null)
                {
                    this.unmodifiedSinceDate = null;
                    this.unmodifiedSinceDateUtc = null;
                }
                else
                {
                    this.unmodifiedSinceDate = value;
                    this.unmodifiedSinceDateUtc = new DateTime(value.Value.Ticks, DateTimeKind.Utc);
                }
            }
        }

        /// <summary>
        /// Returns the object only if it has not been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime? UnmodifiedSinceDateUtc
        {
            get { return this.unmodifiedSinceDateUtc ?? default(DateTime); }
            set
            {
                if (value == null)
                {
                    this.unmodifiedSinceDate = null;
                    this.unmodifiedSinceDateUtc = null;
                }
                else
                {
                    this.unmodifiedSinceDateUtc = value;
                    this.unmodifiedSinceDate = value;
                }
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
        /// <para>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". 
        /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory.
        /// </para>
        /// <para>
        /// Starting with .NET 8, the AWS .NET SDK disables System.Uri's feature of canonicalizing the resource path. This allows S3 keys like
        /// "foo/../bar/file.txt" to work correctly with the AWS .NET SDK.
        /// </para>
        /// <para>
        /// For further information view the documentation for the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </para>
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
        public DateTime? ResponseExpires
        {
            get { return this.responseExpires; }
            set
            {
                if (value == null)
                {
                    this.responseExpires = null;
                    this.responseExpiresUtc = null;
                }
                else
                {
                    this.responseExpires = value;
                    this.responseExpiresUtc = new DateTime(value.Value.Ticks, DateTimeKind.Utc);
                }
            }
        }

        /// <summary>
        /// Sets the Expires header of the response.
        /// </summary>
        public DateTime? ResponseExpiresUtc
        {
            get { return this.responseExpiresUtc; }
            set
            {
                if (value == null)
                {
                    this.responseExpires = null;
                    this.responseExpiresUtc = null;
                }
                else
                {
                    this.responseExpiresUtc = value;
                    this.responseExpires = value;
                }
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
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionCustomerProvidedKey
        {
            get { return this.serverSideEncryptionCustomerProvidedKey; }
            set { this.serverSideEncryptionCustomerProvidedKey = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKey property is set.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the ServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this.serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// VersionId used to reference a specific version of the object.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// otherwise a NotModified (304) signal is returned.
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
