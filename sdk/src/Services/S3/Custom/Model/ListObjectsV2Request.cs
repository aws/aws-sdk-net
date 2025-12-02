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
    /// Container for the parameters to the ListObjectsV2 operation.
    /// Returns some or all (up to 1,000) of the objects in a bucket with each request. You
    /// can use the request parameters as selection criteria to return a subset of the objects
    /// in a bucket. A <c>200 OK</c> response can contain valid or invalid XML. Make sure
    /// to design your application to parse the contents of the response and handle it appropriately.
    /// For more information about listing objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ListingKeysUsingAPIs.html">Listing
    /// object keys programmatically</a> in the <i>Amazon S3 User Guide</i>. To get a list
    /// of your buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListBuckets.html">ListBuckets</a>.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket</b> - For general purpose buckets, <c>ListObjectsV2</c>
    /// doesn't return prefixes that are related only to in-progress multipart uploads.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, <c>ListObjectsV2</c> response includes
    /// the prefixes that are related only to in-progress multipart uploads. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>amzn-s3-demo-bucket</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - To use this operation, you must have
    /// READ access to the bucket. You must have permission to perform the <c>s3:ListBucket</c>
    /// action. The bucket owner has this permission by default and can grant this permission
    /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation on a
    /// directory bucket, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a> API operation for session-based authorization. Specifically,
    /// you grant the <c>s3express:CreateSession</c> permission to the directory bucket in
    /// a bucket policy or an IAM identity-based policy. Then, you make the <c>CreateSession</c>
    /// API call on the bucket to obtain a session token. With the session token in your request
    /// header, you can make API requests to this operation. After the session token expires,
    /// you make another <c>CreateSession</c> API call to generate a new session token for
    /// use. Amazon Web Services CLI or SDKs create session and refresh the session token
    /// automatically to avoid service interruptions when a session expires. For more information
    /// about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Sorting order of returned objects</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket</b> - For general purpose buckets, <c>ListObjectsV2</c>
    /// returns objects in lexicographical order based on their key names.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket</b> - For directory buckets, <c>ListObjectsV2</c> does not return
    /// objects in lexicographical order.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> <important> 
    /// <para>
    /// This section describes the latest revision of this action. We recommend that you use
    /// this revised API operation for application development. For backward compatibility,
    /// Amazon S3 continues to support the prior version of this API operation, <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjects.html">ListObjects</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// The following operations are related to <c>ListObjectsV2</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListObjectsV2Request : AmazonWebServiceRequest
    {
        private string bucketName;
        private string continuationToken;
        private string delimiter;
        private EncodingType encoding;
        private string expectedBucketOwner;
        private bool? fetchOwner;
        private int? maxKeys;
        private List<string> _optionalObjectAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string prefix;
        private RequestPayer requestPayer;
        private string startAfter;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para> 
        /// <b>Directory buckets</b> - When you use this operation with a directory bucket, you must use virtual-hosted-style requests in the 
        /// format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>. Path-style requests are not 
        /// supported. Directory bucket names must be unique in the chosen Zone (Availability Zone or Local Zone). Bucket names must follow the 
        /// format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>). For 
        /// information about bucket naming restrictions, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory bucket naming rules</a> in 
        /// the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <para> 
        /// <b>Access points</b> - When you use this action with an access point for general purpose buckets, you must provide the alias of the access 
        /// point in place of the bucket name or specify the access point ARN. When you use this action with an access point for directory buckets, you 
        /// must provide the access point name in place of the bucket name. When using the access point ARN, you must direct requests to the access 
        /// point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When 
        /// using this action with an access point through the Amazon Web Services SDKs, you provide the access point ARN in place of the bucket name. For 
        /// more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para> 
        /// </note> 
        /// <para> 
        /// <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct requests to the S3 on Outposts hostname. The S3 on Outposts 
        /// hostname takes the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>. When you use this 
        /// action with S3 on Outposts, the destination bucket must be the Outposts access point ARN or the access point alias. For more information about S3 
        /// on Outposts, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        ///  <c>ContinuationToken</c> indicates to Amazon S3 that the list is being continued
        /// on this bucket with a token. <c>ContinuationToken</c> is obfuscated and is not
        /// a real key. You can use this <c>ContinuationToken</c> for pagination of the
        /// list results. 
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this.continuationToken; }
            set { this.continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this.continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// A delimiter is a character that you use to group keys.
        /// </para>
        /// <para>
        /// <c>CommonPrefixes</c> is filtered out from results if it is not lexicographically greater than the <c>StartAfter</c> value.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, <c>/</c> is the only supported
        /// delimiter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Directory buckets </b> - When you query <c>ListObjectsV2</c> with a delimiter
        /// during in-progress multipart uploads, the <c>CommonPrefixes</c> response parameter
        /// contains the prefixes that are associated with the in-progress multipart uploads.
        /// For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
        /// Upload Overview</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this.delimiter != null;
        }

        /// <summary>
        /// Gets and sets the property EncodingType. 
        /// <para>
        /// Encoding type used by Amazon S3 to encode object keys in the response. If using <c>url</c>,
        /// non-ASCII characters used in an object's key name will be URL encoded. For example,
        /// the object test_file(3).png will appear as test_file%283%29.png.
        /// </para>
        /// </summary>
        public EncodingType Encoding
        {
            get { return this.encoding; }
            set { this.encoding = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetEncoding()
        {
            return this.encoding != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
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
        /// Gets and sets the property FetchOwner. 
        /// <para>
        /// The owner field is not present in <c>ListObjectsV2</c> by default. If you want
        /// to return the owner field with each key in the result, then set the <c>FetchOwner</c>
        /// field to <c>true</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, the bucket owner is returned as
        /// the object owner for all objects.
        /// </para>
        ///  </note>
        /// </summary>
        public bool FetchOwner
        {
            get { return this.fetchOwner.GetValueOrDefault(); }
            set { this.fetchOwner = value; }
        }

        // Check to see if FetchOwner property is set
        internal bool IsSetFetchOwner()
        {
            return this.fetchOwner != null;
        }

        /// <summary>
        /// Gets and sets the property MaxKeys. 
        /// <para>
        /// Sets the maximum number of keys returned in the response. By default the action returns
        /// up to 1,000 key names. The response might contain fewer keys but will never contain
        /// more.
        /// </para>
        /// </summary>
        public int MaxKeys
        {
            get { return this.maxKeys ?? default(int); }
            set { this.maxKeys = value; }
        }
        
        // Check to see if MaxKeys property is set
        internal bool IsSetMaxKeys()
        {
            return this.maxKeys.HasValue;
        }

        /// <summary>
        /// Gets and sets the property OptionalObjectAttributes. 
        /// <para>
        /// Specifies the optional fields that you want returned in the response. Fields that
        /// you do not specify are not returned.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> OptionalObjectAttributes
        {
            get { return this._optionalObjectAttributes; }
            set { this._optionalObjectAttributes = value; }
        }

        // Check to see if OptionalObjectAttributes property is set
        internal bool IsSetOptionalObjectAttributes()
        {
            return this._optionalObjectAttributes != null && (this._optionalObjectAttributes.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Limits the response to keys that begin with the specified prefix.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, only prefixes that end in a delimiter
        /// (<c>/</c>) are supported.
        /// </para>
        ///  </note>
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this.prefix != null;
        }

        /// <summary>
        /// Gets and sets the property RequestPayer. 
        /// <para>
        /// Confirms that the requester knows that she or he will be charged for the list objects
        /// request in V2 style. Bucket owners need not specify this parameter in their requests.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property StartAfter. 
        /// <para>
        /// StartAfter is where you want Amazon S3 to start listing from. Amazon S3 starts listing
        /// after this specified key. StartAfter can be any key in the bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string StartAfter
        {
            get { return this.startAfter; }
            set { this.startAfter = value; }
        }

        // Check to see if StartAfter property is set
        internal bool IsSetStartAfter()
        {
            return this.StartAfter != null;
        }

    }
}
    
