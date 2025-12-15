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
    /// This is the response object from the ListMultipartUploads operation.
    /// </summary>
    public partial class ListMultipartUploadsResponse : AmazonWebServiceResponse
    {
        private string _bucketName;
        private List<string> _commonPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _delimiter;
        private EncodingType _encodingType;
        private bool? _isTruncated;
        private string _keyMarker;
        private int? _maxUploads;
        private List<MultipartUpload> _multipartUploads = AWSConfigs.InitializeCollections ? new List<MultipartUpload>() : null;
        private string _nextKeyMarker;
        private string _nextUploadIdMarker;
        private string _prefix;
        private RequestCharged _requestCharged;
        private string _uploadIdMarker;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to which the multipart upload was initiated. Does not return
        /// the access point ARN or access point alias if used.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CommonPrefixes. 
        /// <para>
        /// If you specify a delimiter in the request, then the result returns each distinct key
        /// prefix containing the delimiter in a <c>CommonPrefixes</c> element. The distinct key
        /// prefixes are returned in the <c>Prefix</c> child element.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, only prefixes that end in a delimiter
        /// (<c>/</c>) are supported.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CommonPrefixes
        {
            get { return this._commonPrefixes; }
            set { this._commonPrefixes = value; }
        }

        // Check to see if CommonPrefixes property is set
        internal bool IsSetCommonPrefixes()
        {
            return this._commonPrefixes != null && (this._commonPrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// Contains the delimiter you specified in the request. If you don't specify a delimiter
        /// in your request, this element is absent from the response.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, <c>/</c> is the only supported
        /// delimiter.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property EncodingType. 
        /// <para>
        /// Encoding type used by Amazon S3 to encode object keys in the response.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>encoding-type</c> request parameter, Amazon S3 includes this
        /// element in the response, and returns encoded key name values in the following response
        /// elements:
        /// </para>
        ///  
        /// <para>
        ///  <c>Delimiter</c>, <c>KeyMarker</c>, <c>Prefix</c>, <c>NextKeyMarker</c>, <c>Key</c>.
        /// </para>
        /// </summary>
        public EncodingType EncodingType
        {
            get { return this._encodingType; }
            set { this._encodingType = value; }
        }

        // Check to see if EncodingType property is set
        internal bool IsSetEncodingType()
        {
            return this._encodingType != null;
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Indicates whether the returned list of multipart uploads is truncated. A value of
        /// true indicates that the list was truncated. The list can be truncated if the number
        /// of multipart uploads exceeds the limit allowed or specified by max uploads.
        /// </para>
        /// </summary>
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyMarker. 
        /// <para>
        /// The key at or after which the listing began.
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
        /// Gets and sets the property MaxUploads. 
        /// <para>
        /// Maximum number of multipart uploads that could have been included in the response.
        /// </para>
        /// </summary>
        public int? MaxUploads
        {
            get { return this._maxUploads; }
            set { this._maxUploads = value; }
        }

        // Check to see if MaxUploads property is set
        internal bool IsSetMaxUploads()
        {
            return this._maxUploads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultipartUploads. 
        /// <para>
        /// Container for elements related to a particular multipart upload. A response can contain
        /// zero or more <c>Upload</c> elements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MultipartUpload> MultipartUploads
        {
            get { return this._multipartUploads; }
            set { this._multipartUploads = value; }
        }

        // Check to see if MultipartUploads property is set
        internal bool IsSetMultipartUploads()
        {
            return this._multipartUploads != null && (this._multipartUploads.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextKeyMarker. 
        /// <para>
        /// When a list is truncated, this element specifies the value that should be used for
        /// the key-marker request parameter in a subsequent request.
        /// </para>
        /// </summary>
        public string NextKeyMarker
        {
            get { return this._nextKeyMarker; }
            set { this._nextKeyMarker = value; }
        }

        // Check to see if NextKeyMarker property is set
        internal bool IsSetNextKeyMarker()
        {
            return this._nextKeyMarker != null;
        }

        /// <summary>
        /// Gets and sets the property NextUploadIdMarker. 
        /// <para>
        /// When a list is truncated, this element specifies the value that should be used for
        /// the <c>upload-id-marker</c> request parameter in a subsequent request.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextUploadIdMarker
        {
            get { return this._nextUploadIdMarker; }
            set { this._nextUploadIdMarker = value; }
        }

        // Check to see if NextUploadIdMarker property is set
        internal bool IsSetNextUploadIdMarker()
        {
            return this._nextUploadIdMarker != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// When a prefix is provided in the request, this field contains the specified prefix.
        /// The result contains only keys starting with the specified prefix.
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
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property UploadIdMarker. 
        /// <para>
        /// Together with key-marker, specifies the multipart upload after which listing should
        /// begin. If key-marker is not specified, the upload-id-marker parameter is ignored.
        /// Otherwise, any multipart uploads for a key equal to the key-marker might be included
        /// in the list only if they have an upload ID lexicographically greater than the specified
        /// <c>upload-id-marker</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string UploadIdMarker
        {
            get { return this._uploadIdMarker; }
            set { this._uploadIdMarker = value; }
        }

        // Check to see if UploadIdMarker property is set
        internal bool IsSetUploadIdMarker()
        {
            return this._uploadIdMarker != null;
        }

    }
}