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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  ListMultipartUploads response and response metadata.
    /// </summary>
    public class ListMultipartUploadsResponse : AmazonWebServiceResponse
    {
        private string _bucketName;
        private string keyMarker;
        private string uploadIdMarker;
        private string nextKeyMarker;
        private string nextUploadIdMarker;
        private int? maxUploads;
        private RequestCharged _requestCharged;
        private bool? isTruncated;

        private List<MultipartUpload> multipartUploads = AWSConfigs.InitializeCollections ? new List<MultipartUpload>() : null;
        private string delimiter;
        private List<string> commonPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string prefix;

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
        /// The key at or after which the listing began.
        ///  
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
            get { return this.uploadIdMarker; }
            set { this.uploadIdMarker = value; }
        }

        // Check to see if UploadIdMarker property is set
        internal bool IsSetUploadIdMarker()
        {
            return this.uploadIdMarker != null;
        }

        /// <summary>
        /// When a list is truncated, this element specifies the value that should be used for the key-marker request parameter in a subsequent request.
        ///  
        /// </summary>
        public string NextKeyMarker
        {
            get { return this.nextKeyMarker; }
            set { this.nextKeyMarker = value; }
        }

        // Check to see if NextKeyMarker property is set
        internal bool IsSetNextKeyMarker()
        {
            return this.nextKeyMarker != null;
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
            get { return this.nextUploadIdMarker; }
            set { this.nextUploadIdMarker = value; }
        }

        // Check to see if NextUploadIdMarker property is set
        internal bool IsSetNextUploadIdMarker()
        {
            return this.nextUploadIdMarker != null;
        }

        /// <summary>
        /// Maximum number of multipart uploads that could have been included in the response.
        ///  
        /// </summary>
        public int? MaxUploads
        {
            get { return this.maxUploads; }
            set { this.maxUploads = value; }
        }

        // Check to see if MaxUploads property is set
        internal bool IsSetMaxUploads()
        {
            return this.maxUploads.HasValue;
        }

        /// <summary>
        /// Indicates whether the returned list of multipart uploads is truncated. A value of true indicates that the list was truncated. The list can
        /// be truncated if the number of multipart uploads exceeds the limit allowed or specified by max uploads.
        ///  
        /// </summary>
        public bool? IsTruncated
        {
            get { return this.isTruncated; }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
        }

        /// <summary>
        /// Gets and sets the MultipartUploads property.
        /// <para>
        /// Container for elements related to a particular multipart upload. A response
        /// can contain zero or more Upload elements.
        /// </para>
        /// </summary>
        public List<MultipartUpload> MultipartUploads
        {
            get { return this.multipartUploads; }
            set { this.multipartUploads = value; }
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
            get { return this.prefix; }
            set { this.prefix = value; }
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
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        /// <summary>
        /// Gets and sets the property CommonPrefixes. 
        /// <para>
        /// If you specify a delimiter in the request, then the result returns each distinct key
        /// prefix containing the delimiter in a <c>CommonPrefixes</c> element. The distinct
        /// key prefixes are returned in the <c>Prefix</c> child element.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, only prefixes that end in a delimiter
        /// (<c>/</c>) are supported.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> CommonPrefixes
        {
            get { return this.commonPrefixes; }
            set { this.commonPrefixes = value; }
        }
    }
}
    
