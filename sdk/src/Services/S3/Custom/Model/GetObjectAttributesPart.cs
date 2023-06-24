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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private List<ObjectPart> _parts = new List<ObjectPart>();
        private int? _totalPartsCount;

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Indicates whether the returned list of parts is truncated. A value of true indicates
        /// that the list was truncated. A list can be truncated if the number of parts exceeds
        /// the limit returned in the <code>MaxParts</code> element.
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
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
        public int MaxParts
        {
            get { return this._maxParts.GetValueOrDefault(); }
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
        /// as the value to use for the part-number-marker request parameter in a subsequent request.
        /// </para>
        /// </summary>
        public int NextPartNumberMarker
        {
            get { return this._nextPartNumberMarker.GetValueOrDefault(); }
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
        public int PartNumberMarker
        {
            get { return this._partNumberMarker.GetValueOrDefault(); }
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
        /// Container for elements related to a particular part. A response can contain zero or
        /// more <code>Parts</code> elements.
        /// </para>
        /// </summary>
        public List<ObjectPart> Parts
        {
            get { return this._parts; }
            set { this._parts = value; }
        }

        // Check to see if Parts property is set
        internal bool IsSetParts()
        {
            return this._parts != null && this._parts.Count > 0;
        }

        /// <summary>
        /// Gets and sets the property TotalPartsCount. 
        /// <para>
        /// The total number of parts.
        /// </para>
        /// </summary>
        public int TotalPartsCount
        {
            get { return this._totalPartsCount.GetValueOrDefault(); }
            set { this._totalPartsCount = value; }
        }

        // Check to see if TotalPartsCount property is set
        internal bool IsSetTotalPartsCount()
        {
            return this._totalPartsCount.HasValue;
        }

    }
}