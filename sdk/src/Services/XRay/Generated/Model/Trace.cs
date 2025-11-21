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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// A collection of segment documents with matching trace IDs.
    /// </summary>
    public partial class Trace
    {
        private double? _duration;
        private string _id;
        private bool? _limitExceeded;
        private List<Segment> _segments = AWSConfigs.InitializeCollections ? new List<Segment>() : null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The length of time in seconds between the start time of the earliest segment that
        /// started and the end time of the last segment that completed.
        /// </para>
        /// </summary>
        public double? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the request that generated the trace's segments and subsegments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=35)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LimitExceeded. 
        /// <para>
        /// LimitExceeded is set to true when the trace has exceeded the <c>Trace document size</c>
        /// limit. For more information about this limit and other X-Ray limits and quotas, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/xray.html">Amazon Web Services
        /// X-Ray endpoints and quotas</a>.
        /// </para>
        /// </summary>
        public bool? LimitExceeded
        {
            get { return this._limitExceeded; }
            set { this._limitExceeded = value; }
        }

        // Check to see if LimitExceeded property is set
        internal bool IsSetLimitExceeded()
        {
            return this._limitExceeded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Segments. 
        /// <para>
        /// Segment documents for the segments and subsegments that comprise the trace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Segment> Segments
        {
            get { return this._segments; }
            set { this._segments = value; }
        }

        // Check to see if Segments property is set
        internal bool IsSetSegments()
        {
            return this._segments != null && (this._segments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}