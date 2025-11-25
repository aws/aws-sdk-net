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
    /// This is the response object from the ListObjects operation.
    /// </summary>
    public partial class ListObjectsResponse : AmazonWebServiceResponse
    {
        private List<string> _commonPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _delimiter;
        private EncodingType _encodingType;
        private bool? _isTruncated;
        private string _marker;
        private int? _maxKeys;
        private string _name;
        private string _nextMarker;
        private string _prefix;
        private RequestCharged _requestCharged;
        private List<S3Object> _s3Objects = AWSConfigs.InitializeCollections ? new List<S3Object>() : null;

        /// <summary>
        /// Gets and sets the property CommonPrefixes. 
        /// <para>
        /// All of the keys (up to 1,000) rolled up in a common prefix count as a single return
        /// when calculating the number of returns. 
        /// </para>
        ///  
        /// <para>
        /// A response can contain <c>CommonPrefixes</c> only if you specify a delimiter.
        /// </para>
        ///  
        /// <para>
        ///  <c>CommonPrefixes</c> contains all (if there are any) keys between <c>Prefix</c>
        /// and the next occurrence of the string specified by the delimiter.
        /// </para>
        ///  
        /// <para>
        ///  <c>CommonPrefixes</c> lists keys that act like subdirectories in the directory specified
        /// by <c>Prefix</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, if the prefix is <c>notes/</c> and the delimiter is a slash (<c>/</c>),
        /// as in <c>notes/summer/july</c>, the common prefix is <c>notes/summer/</c>. All of
        /// the keys that roll up into a common prefix count as a single return when calculating
        /// the number of returns.
        /// </para>
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
        /// Causes keys that contain the same string between the prefix and the first occurrence
        /// of the delimiter to be rolled up into a single result element in the <c>CommonPrefixes</c>
        /// collection. These rolled-up keys are not returned elsewhere in the response. Each
        /// rolled-up result counts as only one return against the <c>MaxKeys</c> value.
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
        /// Gets and sets the property EncodingType. 
        /// <para>
        /// Encoding type used by Amazon S3 to encode the <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html">object
        /// keys</a> in the response. Responses are encoded only in UTF-8. An object key can contain
        /// any Unicode character. However, the XML 1.0 parser can't parse certain characters,
        /// such as characters with an ASCII value from 0 to 10. For characters that aren't supported
        /// in XML 1.0, you can add this parameter to request that Amazon S3 encode the keys in
        /// the response. For more information about characters to avoid in object key names,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-guidelines">Object
        /// key naming guidelines</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When using the URL encoding type, non-ASCII characters that are used in an object's
        /// key name will be percent-encoded according to UTF-8 code values. For example, the
        /// object <c>test_file(3).png</c> will appear as <c>test_file%283%29.png</c>.
        /// </para>
        ///  </note>
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
        /// A flag that indicates whether Amazon S3 returned all of the results that satisfied
        /// the search criteria.
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// Indicates where in the bucket listing begins. Marker is included in the response if
        /// it was sent with the request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxKeys. 
        /// <para>
        /// The maximum number of keys returned in the response body.
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
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When the response is truncated (the <c>IsTruncated</c> element value in the response
        /// is <c>true</c>), you can use the key name in this field as the <c>marker</c> parameter
        /// in the subsequent request to get the next set of objects. Amazon S3 lists objects
        /// in alphabetical order. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This element is returned only if you have the <c>delimiter</c> request parameter specified.
        /// If the response does not include the <c>NextMarker</c> element and it is truncated,
        /// you can use the value of the last <c>Key</c> element in the response as the <c>marker</c>
        /// parameter in the subsequent request to get the next set of object keys.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextMarker
        {
            get { return NextMarkerCustomGetter(); }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Keys that begin with the indicated prefix.
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

    }
}