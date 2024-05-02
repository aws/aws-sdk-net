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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies a condition to evaluate for an activity in a journey.
    /// </summary>
    public partial class SimpleCondition
    {
        private EventCondition _eventCondition;
        private SegmentCondition _segmentCondition;
        private SegmentDimensions _segmentDimensions;

        /// <summary>
        /// Gets and sets the property EventCondition. 
        /// <para>
        /// The dimension settings for the event that's associated with the activity.
        /// </para>
        /// </summary>
        public EventCondition EventCondition
        {
            get { return this._eventCondition; }
            set { this._eventCondition = value; }
        }

        // Check to see if EventCondition property is set
        internal bool IsSetEventCondition()
        {
            return this._eventCondition != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentCondition. 
        /// <para>
        /// The segment that's associated with the activity.
        /// </para>
        /// </summary>
        public SegmentCondition SegmentCondition
        {
            get { return this._segmentCondition; }
            set { this._segmentCondition = value; }
        }

        // Check to see if SegmentCondition property is set
        internal bool IsSetSegmentCondition()
        {
            return this._segmentCondition != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentDimensions. 
        /// <para>
        /// The dimension settings for the segment that's associated with the activity.
        /// </para>
        /// </summary>
        public SegmentDimensions SegmentDimensions
        {
            get { return this._segmentDimensions; }
            set { this._segmentDimensions = value; }
        }

        // Check to see if SegmentDimensions property is set
        internal bool IsSetSegmentDimensions()
        {
            return this._segmentDimensions != null;
        }

    }
}