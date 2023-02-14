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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Represents an element of a leg within a route. A step contains instructions for how
    /// to move to the next step in the leg.
    /// </summary>
    public partial class Step
    {
        private double? _distance;
        private double? _durationSeconds;
        private List<double> _endPosition = new List<double>();
        private int? _geometryOffset;
        private List<double> _startPosition = new List<double>();

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The travel distance between the step's <code>StartPosition</code> and <code>EndPosition</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double Distance
        {
            get { return this._distance.GetValueOrDefault(); }
            set { this._distance = value; }
        }

        // Check to see if Distance property is set
        internal bool IsSetDistance()
        {
            return this._distance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The estimated travel time, in seconds, from the step's <code>StartPosition</code>
        /// to the <code>EndPosition</code>. . The travel mode and departure time that you specify
        /// in the request determines the calculated time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndPosition. 
        /// <para>
        /// The end position of a step. If the position the last step in the leg, this position
        /// is the same as the end position of the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> EndPosition
        {
            get { return this._endPosition; }
            set { this._endPosition = value; }
        }

        // Check to see if EndPosition property is set
        internal bool IsSetEndPosition()
        {
            return this._endPosition != null && this._endPosition.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GeometryOffset. 
        /// <para>
        /// Represents the start position, or index, in a sequence of steps within the leg's line
        /// string geometry. For example, the index of the first step in a leg geometry is <code>0</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Included in the response for queries that set <code>IncludeLegGeometry</code> to <code>True</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int GeometryOffset
        {
            get { return this._geometryOffset.GetValueOrDefault(); }
            set { this._geometryOffset = value; }
        }

        // Check to see if GeometryOffset property is set
        internal bool IsSetGeometryOffset()
        {
            return this._geometryOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartPosition. 
        /// <para>
        /// The starting position of a step. If the position is the first step in the leg, this
        /// position is the same as the start position of the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> StartPosition
        {
            get { return this._startPosition; }
            set { this._startPosition = value; }
        }

        // Check to see if StartPosition property is set
        internal bool IsSetStartPosition()
        {
            return this._startPosition != null && this._startPosition.Count > 0; 
        }

    }
}