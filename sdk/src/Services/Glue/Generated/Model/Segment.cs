/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a non-overlapping region of a table's partitions, allowing multiple requests
    /// to be executed in parallel.
    /// </summary>
    public partial class Segment
    {
        private int? _segmentNumber;
        private int? _totalSegments;

        /// <summary>
        /// Gets and sets the property SegmentNumber. 
        /// <para>
        /// The zero-based index number of the this segment. For example, if the total number
        /// of segments is 4, SegmentNumber values will range from zero through three.
        /// </para>
        /// </summary>
        public int SegmentNumber
        {
            get { return this._segmentNumber.GetValueOrDefault(); }
            set { this._segmentNumber = value; }
        }

        // Check to see if SegmentNumber property is set
        internal bool IsSetSegmentNumber()
        {
            return this._segmentNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSegments. 
        /// <para>
        /// The total numer of segments.
        /// </para>
        /// </summary>
        public int TotalSegments
        {
            get { return this._totalSegments.GetValueOrDefault(); }
            set { this._totalSegments = value; }
        }

        // Check to see if TotalSegments property is set
        internal bool IsSetTotalSegments()
        {
            return this._totalSegments.HasValue; 
        }

    }
}