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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the ListVersions operation.
    /// <important> 
    /// <para>
    /// End of support notice: Beginning October 1, 2025, Amazon S3 will stop returning <c>DisplayName</c>.
    /// Update your applications to use canonical IDs (unique identifier for Amazon Web Services
    /// accounts), Amazon Web Services account ID (12 digit identifier) or IAM ARNs (full
    /// resource naming) as a direct replacement of <c>DisplayName</c>. 
    /// </para>
    ///  
    /// <para>
    /// This change affects the following Amazon Web Services Regions: US East (N. Virginia)
    /// Region, US West (N. California) Region, US West (Oregon) Region, Asia Pacific (Singapore)
    /// Region, Asia Pacific (Sydney) Region, Asia Pacific (Tokyo) Region, Europe (Ireland)
    /// Region, and South America (São Paulo) Region.
    /// </para>
    ///  </important> <note> 
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
    ///  </li> </ul>
    /// </summary>
    public partial class ListVersionsRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _delimiter;
        private EncodingType _encoding;
        private string _expectedBucketOwner;
        private string _keyMarker;
        private int? _maxKeys;
        private List<string> _optionalObjectAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _prefix;
        private RequestPayer _requestPayer;
        private string _versionIdMarker;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name that contains the objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// A delimiter is a character that you specify to group keys. All keys that contain the
        /// same string between the <c>prefix</c> and the first occurrence of the delimiter are
        /// grouped under a single result element in <c>CommonPrefixes</c>. These groups are counted
        /// as one result against the <c>max-keys</c> limitation. These keys are not returned
        /// elsewhere in the response.
        /// </para>
        ///  
        /// <para>
        ///  <c>CommonPrefixes</c> is filtered out from results if it is not lexicographically
        /// greater than the key-marker.
        /// </para>
        /// </summary>
        public string Delimiter
        {
            get { return this._delimiter; }
            set { this._delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this._delimiter != null;
        }

        /// <summary>
        /// Gets and sets the property Encoding.
        /// </summary>
        public EncodingType Encoding
        {
            get { return this._encoding; }
            set { this._encoding = value; }
        }

        // Check to see if Encoding property is set
        internal bool IsSetEncoding()
        {
            return this._encoding != null;
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
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property KeyMarker. 
        /// <para>
        /// Specifies the key to start with when listing objects in a bucket.
        /// </para>
        /// </summary>
        public string KeyMarker
        {
            get { return this._keyMarker; }
            set { this._keyMarker = value; }
        }

        // Check to see if KeyMarker property is set
        internal bool IsSetKeyMarker()
        {
            return this._keyMarker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxKeys. 
        /// <para>
        /// Sets the maximum number of keys returned in the response. By default, the action returns
        /// up to 1,000 key names. The response might contain fewer keys but will never contain
        /// more. If additional keys satisfy the search criteria, but were not returned because
        /// <c>max-keys</c> was exceeded, the response contains <c>&lt;isTruncated&gt;true&lt;/isTruncated&gt;</c>.
        /// To return the additional keys, see <c>key-marker</c> and <c>version-id-marker</c>.
        /// </para>
        /// </summary>
        public int? MaxKeys
        {
            get { return this._maxKeys; }
            set { this._maxKeys = value; }
        }

        // Check to see if MaxKeys property is set
        internal bool IsSetMaxKeys()
        {
            return this._maxKeys.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptionalObjectAttributes. 
        /// <para>
        /// Specifies the optional fields that you want returned in the response. Fields that
        /// you do not specify are not returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// think of using <c>prefix</c> to make groups in the same way that you'd use a folder
        /// in a file system.) You can use <c>prefix</c> with <c>delimiter</c> to roll up numerous
        /// objects into a single result under <c>CommonPrefixes</c>. 
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
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
        /// Gets and sets the property VersionIdMarker. 
        /// <para>
        /// Specifies the object version you want to start listing from.
        /// </para>
        /// </summary>
        public string VersionIdMarker
        {
            get { return this._versionIdMarker; }
            set { this._versionIdMarker = value; }
        }

        // Check to see if VersionIdMarker property is set
        internal bool IsSetVersionIdMarker()
        {
            return this._versionIdMarker != null;
        }

    }
}