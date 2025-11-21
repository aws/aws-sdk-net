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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Time-tagged azimuth elevation pointing data.
    /// 
    ///  
    /// <para>
    /// Specifies the antenna pointing direction at a specific time offset from the segment's
    /// reference epoch.
    /// </para>
    /// </summary>
    public partial class TimeAzEl
    {
        private double? _az;
        private double? _dt;
        private double? _el;

        /// <summary>
        /// Gets and sets the property Az. 
        /// <para>
        /// Azimuth angle at the specified time.
        /// </para>
        ///  
        /// <para>
        /// Valid ranges by unit:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DEGREE_ANGLE</c>: -180 to 360 degrees, measured clockwise from true north
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RADIAN</c>: -π to 2π radians, measured clockwise from true north
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Az
        {
            get { return this._az; }
            set { this._az = value; }
        }

        // Check to see if Az property is set
        internal bool IsSetAz()
        {
            return this._az.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Dt. 
        /// <para>
        /// Time offset in atomic seconds from the segment's reference epoch.
        /// </para>
        ///  
        /// <para>
        /// All <c>dt</c> values within a segment must be in ascending order with no duplicates.
        /// </para>
        ///  
        /// <para>
        ///  <c>dt</c> values may be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// negative
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// expressed as fractions of a second
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// expressed in scientific notation
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Dt
        {
            get { return this._dt; }
            set { this._dt = value; }
        }

        // Check to see if Dt property is set
        internal bool IsSetDt()
        {
            return this._dt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property El. 
        /// <para>
        /// Elevation angle at the specified time.
        /// </para>
        ///  
        /// <para>
        /// Valid ranges by unit:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DEGREE_ANGLE</c>: -90 to 90 degrees, where 0 is the horizon, 90 is zenith, and
        /// negative values are below the horizon 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RADIAN</c>: -π/2 to π/2 radians, where 0 is the horizon, π/2 is zenith, and negative
        /// values are below the horizon 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? El
        {
            get { return this._el; }
            set { this._el = value; }
        }

        // Check to see if El property is set
        internal bool IsSetEl()
        {
            return this._el.HasValue; 
        }

    }
}