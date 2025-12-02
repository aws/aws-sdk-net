
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
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Returns metadata about all versions of the objects in a bucket. You can also use request
    /// parameters as selection criteria to return metadata about a subset of all the object
    /// versions.
    /// </para>
    ///  <important> 
    /// <para>
    ///  To use this operation, you must have permission to perform the <c>s3:ListBucketVersions</c>
    /// action. Be aware of the name difference. 
    /// </para>
    ///  </important> <note> 
    /// <para>
    ///  A <c>200 OK</c> response can contain valid or invalid XML. Make sure to design your
    /// application to parse the contents of the response and handle it appropriately.
    /// </para>
    ///  </note> 
    /// <para>
    /// To use this operation, you must have READ access to the bucket.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>ListObjectVersions</c>:
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
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListVersionsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string delimiter;
        private string keyMarker;
        private int? maxKeys;
        private string prefix;
        private List<string> _optionalObjectAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// same string between the <c>prefix</c> and the first occurrence of the delimiter
        /// are grouped under a single result element in <c>CommonPrefixes</c>. These groups
        /// are counted as one result against the <c>max-keys</c> limitation. These keys
        /// are not returned elsewhere in the response.
        /// </para>
        /// <para>
        /// <c>CommonPrefixes</c> is filtered out from results if it is not lexicographically greater than the key-marker.
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
        /// Sets the maximum number of keys returned in the response. By default, the action returns
        /// up to 1,000 key names. The response might contain fewer keys but will never contain
        /// more. If additional keys satisfy the search criteria, but were not returned because
        /// <code>max-keys</code> was exceeded, the response contains <code>&lt;isTruncated&gt;true&lt;/isTruncated&gt;</code>.
        /// To return the additional keys, see <code>key-marker</code> and <code>version-id-marker</code>.
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
        /// Use this parameter to select only those keys that begin with the specified prefix.
        /// You can use prefixes to separate a bucket into different groupings of keys. (You can
        /// think of using <code>prefix</code> to make groups in the same way that you'd use a
        /// folder in a file system.) You can use <code>prefix</code> with <code>delimiter</code>
        /// to roll up numerous objects into a single result under <code>CommonPrefixes</code>.
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
        /// <para>Encoding type used by Amazon S3 to encode the 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html">object keys</a> in 
        /// the response. Responses are encoded only in UTF-8. An object key can contain any Unicode character. 
        /// However, the XML 1.0 parser can't parse certain characters, such as characters with an ASCII value 
        /// from 0 to 10. For characters that aren't supported in XML 1.0, you can add this parameter to request 
        /// that Amazon S3 encode the keys in the response. For more information about characters to avoid in object 
        /// key names, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-guidelines">Object key naming guidelines</a>.
        /// </para> <note> <para>When using the URL encoding type, non-ASCII characters that are used in an 
        /// object's key name will be percent-encoded according to UTF-8 code values. For example, the object 
        /// <code>test_file(3).png</code> will appear as <code>test_file%283%29.png</code>.</para> </note>
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
    }
}
    
