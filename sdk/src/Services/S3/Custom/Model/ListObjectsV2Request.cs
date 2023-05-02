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
    /// in a bucket. A <code>200 OK</code> response can contain valid or invalid XML. Make
    /// sure to design your application to parse the contents of the response and handle it
    /// appropriately. Objects are returned sorted in an ascending order of the respective
    /// key names in the list. For more information about listing objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ListingKeysUsingAPIs.html">Listing
    /// object keys programmatically</a> 
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have READ access to the bucket.
    /// </para>
    ///  
    /// <para>
    /// To use this action in an Identity and Access Management (IAM) policy, you must have
    /// permissions to perform the <code>s3:ListBucket</code> action. The bucket owner has
    /// this permission by default and can grant this permission to others. For more information
    /// about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// This section describes the latest revision of this action. We recommend that you use
    /// this revised API for application development. For backward compatibility, Amazon S3
    /// continues to support the prior version of this API, <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjects.html">ListObjects</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// To get a list of your buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListBuckets.html">ListBuckets</a>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>ListObjectsV2</code>:
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
    ///  </li> </ul>
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
        private string prefix;
        private RequestPayer requestPayer;
        private string startAfter;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// Bucket name to list. 
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

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// ContinuationToken indicates Amazon S3 that the list is being continued on this bucket
        /// with a token. ContinuationToken is obfuscated and is not a real key.
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
        /// A delimiter is a character you use to group keys.
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
        /// Requests Amazon S3 to encode the object keys in the response and specifies
        /// the encoding method to use. An object key may contain any Unicode character;
        /// however, XML 1.0 parser cannot parse some characters, such as characters
        /// with an ASCII value from 0 to 10. For characters that are not supported in
        /// XML 1.0, you can add this parameter to request that Amazon S3 encode the
        /// keys in the response.
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
        /// The owner field is not present in ListObjectsV2 responses by default.
        /// If you want to return owner field with each key in the result then set this field to true.
        /// If not specified, the Owner field on S3Object will be null.
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
        /// Limits the response to keys that begin with the specified prefix.
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
    
