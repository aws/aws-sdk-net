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
    /// Time breakdown for the sequence.
    /// </summary>
    public partial class WaypointOptimizationTimeBreakdown
    {
        private long? _restDuration;
        private long? _serviceDuration;
        private long? _travelDuration;
        private long? _waitDuration;

        /// <summary>
        /// Gets and sets the property RestDuration. 
        /// <para>
        /// Resting phase of the cycle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
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
        /// Gets and sets the property ServiceDuration. 
        /// <para>
        /// Service time spent at the destination. At an appointment, the service time should
        /// be the appointment duration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? ServiceDuration
        {
            get { return this._serviceDuration; }
            set { this._serviceDuration = value; }
        }

        // Check to see if ServiceDuration property is set
        internal bool IsSetServiceDuration()
        {
            return this._serviceDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TravelDuration. 
        /// <para>
        /// Traveling phase of the cycle.
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
        /// Waiting phase of the cycle.
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