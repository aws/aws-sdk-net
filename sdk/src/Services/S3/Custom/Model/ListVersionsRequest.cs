
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
    /// Container for the parameters to the ListVersions operation.
    /// Returns metadata about all versions of the objects in a bucket. You can also use request
    /// parameters as selection criteria to return metadata about a subset of all the object
    /// versions.
    /// 
    ///  <important> 
    /// <para>
    ///  To use this operation, you must have permissions to perform the <code>s3:ListBucketVersions</code>
    /// action. Be aware of the name difference. 
    /// </para>
    ///  </important> <note> 
    /// <para>
    ///  A 200 OK response can contain valid or invalid XML. Make sure to design your application
    /// to parse the contents of the response and handle it appropriately.
    /// </para>
    ///  </note> 
    /// <para>
    /// To use this operation, you must have READ access to the bucket.
    /// </para>
    ///  
    /// <para>
    /// This action is not supported by Amazon S3 on Outposts.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>ListObjectVersions</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjectsV2.html">ListObjectsV2</a>
    /// 
    /// </para>
    ///  </li> <li> 
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
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListVersionsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string delimiter;
        private string keyMarker;
        private int? maxKeys;
        private string prefix;
        private RequestPayer _requestPayer;
        private string versionIdMarker;
        private EncodingType encoding;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name that contains the objects. 
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
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// A delimiter is a character that you specify to group keys. All keys that contain the
        /// same string between the <code>prefix</code> and the first occurrence of the delimiter
        /// are grouped under a single result element in CommonPrefixes. These groups are counted
        /// as one result against the max-keys limitation. These keys are not returned elsewhere
        /// in the response.
        /// </para>
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
        /// Specifies the key to start with when listing objects in a bucket.
        /// </summary>
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        // Check to see if KeyMarker property is set
        internal bool IsSetKeyMarker()
        {
            return this.keyMarker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxKeys. 
        /// <para>
        /// Sets the maximum number of keys returned in the response. By default the action returns
        /// up to 1,000 key names. The response might contain fewer keys but will never contain
        /// more. If additional keys satisfy the search criteria, but were not returned because
        /// max-keys was exceeded, the response contains &lt;isTruncated&gt;true&lt;/isTruncated&gt;.
        /// To return the additional keys, see key-marker and version-id-marker.
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
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Use this parameter to select only those keys that begin with the specified prefix.
        /// You can use prefixes to separate a bucket into different groupings of keys. (You can
        /// think of using prefix to make groups in the same way you'd use a folder in a file
        /// system.) You can use prefix with delimiter to roll up numerous objects into a single
        /// result under CommonPrefixes. 
        /// </para>
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
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this._requestPayer; }
            set { this._requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return this._requestPayer != null;
        }

        /// <summary>
        /// Specifies the object version you want to start listing from.
        /// </summary>
        public string VersionIdMarker
        {
            get { return this.versionIdMarker; }
            set { this.versionIdMarker = value; }
        }

        // Check to see if VersionIdMarker property is set
        internal bool IsSetVersionIdMarker()
        {
            return this.versionIdMarker != null;
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
        /// The account ID of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
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
    
