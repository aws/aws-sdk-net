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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the configuration, dimension, and other settings for a segment. A WriteSegmentRequest
    /// object can include a Dimensions object or a SegmentGroups object, but not both.
    /// </summary>
    public partial class WriteSegmentRequest
    {
        private SegmentDimensions _dimensions;
        private string _name;
        private SegmentGroupList _segmentGroups;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The criteria that define the dimensions for the segment.
        /// </para>
        /// </summary>
        public SegmentDimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the segment.
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
        /// Gets and sets the property SegmentGroups. 
        /// <para>
        /// The segment group to use and the dimensions to apply to the group's base segments
        /// in order to build the segment. A segment group can consist of zero or more base segments.
        /// Your request can include only one segment group.
        /// </para>
        /// </summary>
        public SegmentGroupList SegmentGroups
        {
            get { return this._segmentGroups; }
            set { this._segmentGroups = value; }
        }

        // Check to see if SegmentGroups property is set
        internal bool IsSetSegmentGroups()
        {
            return this._segmentGroups != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A string-to-string map of key-value pairs that defines the tags to associate with
        /// the segment. Each tag consists of a required tag key and an associated tag value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}