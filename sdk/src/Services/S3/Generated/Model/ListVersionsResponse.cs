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
    /// This is the response object from the ListVersions operation.
    /// </summary>
    public partial class ListVersionsResponse : AmazonWebServiceResponse
    {
        private List<string> _commonPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _delimiter;
        private EncodingType _encoding;
        private bool? _isTruncated;
        private string _keyMarker;
        private int? _maxKeys;
        private string _name;
        private string _nextKeyMarker;
        private string _nextVersionIdMarker;
        private string _prefix;
        private RequestCharged _requestCharged;
        private string _versionIdMarker;
        private List<S3ObjectVersion> _versions = AWSConfigs.InitializeCollections ? new List<S3ObjectVersion>() : null;

        /// <summary>
        /// Gets and sets the property CommonPrefixes. 
        /// <para>
        /// All of the keys rolled up into a common prefix count as a single return when calculating
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
        /// The delimiter grouping the included keys. A delimiter is a character that you specify
        /// to group keys. All keys that contain the same string between the prefix and the first
        /// occurrence of the delimiter are grouped under a single result element in <c>CommonPrefixes</c>.
        /// These groups are counted as one result against the <c>max-keys</c> limitation. These
        /// keys are not returned elsewhere in the response.
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
        /// <para>
        ///  Encoding type used by Amazon S3 to encode object key names in the XML response.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>encoding-type</c> request parameter, Amazon S3 includes this
        /// element in the response, and returns encoded key name values in the following response
        /// elements:
        /// </para>
        ///  
        /// <para>
        ///  <c>KeyMarker, NextKeyMarker, Prefix, Key</c>, and <c>Delimiter</c>.
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
        /// A flag that indicates whether Amazon S3 returned all of the results that satisfied
        /// the search criteria. If your results were truncated, you can make a follow-up paginated
        /// request by using the <c>NextKeyMarker</c> and <c>NextVersionIdMarker</c> response
        /// parameters as a starting place in another request to return the rest of the results.
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
        /// Marks the last key returned in a truncated response.
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
        /// Specifies the maximum number of objects to return.
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
        /// Gets and sets the property NextKeyMarker. 
        /// <para>
        /// When the number of responses exceeds the value of <c>MaxKeys</c>, <c>NextKeyMarker</c>
        /// specifies the first key not returned that satisfies the search criteria. Use this
        /// value for the key-marker request parameter in a subsequent request.
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
        /// Gets and sets the property NextVersionIdMarker. 
        /// <para>
        /// When the number of responses exceeds the value of <c>MaxKeys</c>, <c>NextVersionIdMarker</c>
        /// specifies the first object version not returned that satisfies the search criteria.
        /// Use this value for the <c>version-id-marker</c> request parameter in a subsequent
        /// request.
        /// </para>
        /// </summary>
        public string NextVersionIdMarker
        {
            get { return this._nextVersionIdMarker; }
            set { this._nextVersionIdMarker = value; }
        }

        // Check to see if NextVersionIdMarker property is set
        internal bool IsSetNextVersionIdMarker()
        {
            return this._nextVersionIdMarker != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Selects objects that start with the value supplied by this parameter.
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
        /// Gets and sets the property VersionIdMarker. 
        /// <para>
        /// Marks the last version of the key returned in a truncated response.
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

        /// <summary>
        /// Gets and sets the property Versions. 
        /// <para>
        /// Container for version information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3ObjectVersion> Versions
        {
            get { return this._versions; }
            set { this._versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this._versions != null && (this._versions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}