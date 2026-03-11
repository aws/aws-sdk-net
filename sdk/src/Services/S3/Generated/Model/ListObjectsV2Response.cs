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
    /// This is the response object from the ListObjectsV2 operation.
    /// </summary>
    public partial class ListObjectsV2Response : AmazonWebServiceResponse
    {
        private List<string> _commonPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _continuationToken;
        private string _delimiter;
        private EncodingType _encoding;
        private bool? _isTruncated;
        private int? _keyCount;
        private int? _maxKeys;
        private string _name;
        private string _nextContinuationToken;
        private string _prefix;
        private RequestCharged _requestCharged;
        private List<S3Object> _s3Objects = AWSConfigs.InitializeCollections ? new List<S3Object>() : null;
        private string _startAfter;

        /// <summary>
        /// Gets and sets the property CommonPrefixes. 
        /// <para>
        /// All of the keys (up to 1,000) that share the same prefix are grouped together. When
        /// counting the total numbers of returns by this API operation, this group of keys is
        /// considered as one item.
        /// </para>
        ///  
        /// <para>
        /// A response can contain <c>CommonPrefixes</c> only if you specify a delimiter.
        /// </para>
        ///  
        /// <para>
        ///  <c>CommonPrefixes</c> contains all (if there are any) keys between <c>Prefix</c>
        /// and the next occurrence of the string specified by a delimiter.
        /// </para>
        ///  
        /// <para>
        ///  <c>CommonPrefixes</c> lists keys that act like subdirectories in the directory specified
        /// by <c>Prefix</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, if the prefix is <c>notes/</c> and the delimiter is a slash (<c>/</c>)
        /// as in <c>notes/summer/july</c>, the common prefix is <c>notes/summer/</c>. All of
        /// the keys that roll up into a common prefix count as a single return when calculating
        /// the number of returns. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, only prefixes that end in a delimiter
        /// (<c>/</c>) are supported.
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
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        ///  If <c>ContinuationToken</c> was sent with the request, it is included in the response.
        /// You can use the returned <c>ContinuationToken</c> for pagination of the list response.
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// Causes keys that contain the same string between the <c>prefix</c> and the first occurrence
        /// of the delimiter to be rolled up into a single result element in the <c>CommonPrefixes</c>
        /// collection. These rolled-up keys are not returned elsewhere in the response. Each
        /// rolled-up result counts as only one return against the <c>MaxKeys</c> value.
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
        /// Gets and sets the property Encoding. 
        /// <para>
        /// Encoding type used by Amazon S3 to encode object key names in the XML response.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>encoding-type</c> request parameter, Amazon S3 includes this
        /// element in the response, and returns encoded key name values in the following response
        /// elements:
        /// </para>
        ///  
        /// <para>
        ///  <c>Delimiter, Prefix, Key,</c> and <c>StartAfter</c>.
        /// </para>
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
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Set to <c>false</c> if all of the results were returned. Set to <c>true</c> if more
        /// keys are available to return. If the number of results exceeds that specified by <c>MaxKeys</c>,
        /// all of the results might not be returned.
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
        /// Gets and sets the property KeyCount. 
        /// <para>
        ///  <c>KeyCount</c> is the number of keys returned with this request. <c>KeyCount</c>
        /// will always be less than or equal to the <c>MaxKeys</c> field. For example, if you
        /// ask for 50 keys, your result will include 50 keys or fewer.
        /// </para>
        /// </summary>
        public int? KeyCount
        {
            get { return this._keyCount; }
            set { this._keyCount = value; }
        }

        // Check to see if KeyCount property is set
        internal bool IsSetKeyCount()
        {
            return this._keyCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxKeys. 
        /// <para>
        /// Sets the maximum number of keys returned in the response. By default, the action returns
        /// up to 1,000 key names. The response might contain fewer keys but will never contain
        /// more.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The bucket name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextContinuationToken. 
        /// <para>
        ///  <c>NextContinuationToken</c> is sent when <c>isTruncated</c> is true, which means
        /// there are more keys in the bucket that can be listed. The next list requests to Amazon
        /// S3 can be continued with this <c>NextContinuationToken</c>. <c>NextContinuationToken</c>
        /// is obfuscated and is not a real key
        /// </para>
        /// </summary>
        public string NextContinuationToken
        {
            get { return this._nextContinuationToken; }
            set { this._nextContinuationToken = value; }
        }

        // Check to see if NextContinuationToken property is set
        internal bool IsSetNextContinuationToken()
        {
            return this._nextContinuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Keys that begin with the indicated prefix.
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
        /// Gets and sets the property S3Objects. 
        /// <para>
        /// Metadata about each object returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Object> S3Objects
        {
            get { return this._s3Objects; }
            set { this._s3Objects = value; }
        }

        // Check to see if S3Objects property is set
        internal bool IsSetS3Objects()
        {
            return this._s3Objects != null && (this._s3Objects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartAfter. 
        /// <para>
        /// If StartAfter was sent with the request, it is included in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string StartAfter
        {
            get { return this._startAfter; }
            set { this._startAfter = value; }
        }

        // Check to see if StartAfter property is set
        internal bool IsSetStartAfter()
        {
            return this._startAfter != null;
        }

    }
}