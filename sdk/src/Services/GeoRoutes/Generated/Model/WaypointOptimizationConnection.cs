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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// This contains information such as distance and duration from one waypoint to the next
    /// waypoint in the sequence.
    /// </summary>
    public partial class WaypointOptimizationConnection
    {
        private long? _distance;
        private string _from;
        private long? _restDuration;
        private string _to;
        private long? _travelDuration;
        private long? _waitDuration;

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// Distance of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? Distance
        {
            get { return this._distance; }
            set { this._distance = value; }
        }

        // Check to see if Distance property is set
        internal bool IsSetDistance()
        {
            return this._distance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// contains the ID of the starting waypoint in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property RestDuration. 
        /// <para>
        /// Resting time before the driver can continue driving.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? RestDuration
        {
            get { return this._restDuration; }
            set { this._restDuration = value; }
        }

        // Check to see if RestDuration property is set
        internal bool IsSetRestDuration()
        {
            return this._restDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// Contains the ID of the ending waypoint in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null;
        }

        /// <summary>
        /// Gets and sets the property TravelDuration. 
        /// <para>
        /// Total duration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? TravelDuration
        {
            get { return this._travelDuration; }
            set { this._travelDuration = value; }
        }

        // Check to see if TravelDuration property is set
        internal bool IsSetTravelDuration()
        {
            return this._travelDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WaitDuration. 
        /// <para>
        /// Duration of a wait step.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? WaitDuration
        {
            get { return this._waitDuration; }
            set { this._waitDuration = value; }
        }

        // Check to see if WaitDuration property is set
        internal bool IsSetWaitDuration()
        {
            return this._waitDuration.HasValue; 
        }

    }
}