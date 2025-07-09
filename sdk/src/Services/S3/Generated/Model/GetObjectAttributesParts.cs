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
    /// A collection of parts associated with a multipart upload.
    /// </summary>
    public partial class GetObjectAttributesParts
    {
        private bool? _isTruncated;
        private int? _maxParts;
        private int? _nextPartNumberMarker;
        private int? _partNumberMarker;
        private List<ObjectPart> _parts = AWSConfigs.InitializeCollections ? new List<ObjectPart>() : null;
        private int? _totalPartsCount;

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Indicates whether the returned list of parts is truncated. A value of <c>true</c>
        /// indicates that the list was truncated. A list can be truncated if the number of parts
        /// exceeds the limit returned in the <c>MaxParts</c> element.
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
        /// Gets and sets the property MaxParts. 
        /// <para>
        /// The maximum number of parts allowed in the response.
        /// </para>
        /// </summary>
        public int? MaxParts
        {
            get { return this._maxParts; }
            set { this._maxParts = value; }
        }

        // Check to see if MaxParts property is set
        internal bool IsSetMaxParts()
        {
            return this._maxParts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextPartNumberMarker. 
        /// <para>
        /// When a list is truncated, this element specifies the last part in the list, as well
        /// as the value to use for the <c>PartNumberMarker</c> request parameter in a subsequent
        /// request.
        /// </para>
        /// </summary>
        public int? NextPartNumberMarker
        {
            get { return this._nextPartNumberMarker; }
            set { this._nextPartNumberMarker = value; }
        }

        // Check to see if NextPartNumberMarker property is set
        internal bool IsSetNextPartNumberMarker()
        {
            return this._nextPartNumberMarker.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartNumberMarker. 
        /// <para>
        /// The marker for the current part.
        /// </para>
        /// </summary>
        public int? PartNumberMarker
        {
            get { return this._partNumberMarker; }
            set { this._partNumberMarker = value; }
        }

        // Check to see if PartNumberMarker property is set
        internal bool IsSetPartNumberMarker()
        {
            return this._partNumberMarker.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parts. 
        /// <para>
        /// A container for elements related to a particular part. A response can contain zero
        /// or more <c>Parts</c> elements.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <b>General purpose buckets</b> - For <c>GetObjectAttributes</c>, if an additional
        /// checksum (including <c>x-amz-checksum-crc32</c>, <c>x-amz-checksum-crc32c</c>, <c>x-amz-checksum-sha1</c>,
        /// or <c>x-amz-checksum-sha256</c>) isn't applied to the object specified in the request,
        /// the response doesn't return the <c>Part</c> element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Directory buckets</b> - For <c>GetObjectAttributes</c>, regardless of whether
        /// an additional checksum is applied to the object specified in the request, the response
        /// returns the <c>Part</c> element.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ObjectPart> Parts
        {
            get { return this._parts; }
            set { this._parts = value; }
        }

        // Check to see if Parts property is set
        internal bool IsSetParts()
        {
            return this._parts != null && (this._parts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalPartsCount. 
        /// <para>
        /// The total number of parts.
        /// </para>
        /// </summary>
        public int? TotalPartsCount
        {
            get { return this._totalPartsCount; }
            set { this._totalPartsCount = value; }
        }

        // Check to see if TotalPartsCount property is set
        internal bool IsSetTotalPartsCount()
        {
            return this._totalPartsCount.HasValue; 
        }

    }
}