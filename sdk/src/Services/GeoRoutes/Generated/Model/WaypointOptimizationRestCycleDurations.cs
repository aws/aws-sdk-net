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
    /// Driver work-rest schedules defined by a short and long cycle. A rest needs to be taken
    /// after the short work duration. The short cycle can be repeated until you hit the long
    /// work duration, at which point the long rest duration should be taken before restarting.
    /// 
    ///  
    /// <para>
    ///  <b>Unit</b>: <c>seconds</c> 
    /// </para>
    /// </summary>
    public partial class WaypointOptimizationRestCycleDurations
    {
        private long? _restDuration;
        private long? _workDuration;

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
        /// Gets and sets the property WorkDuration. 
        /// <para>
        /// Working phase of the cycle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? WorkDuration
        {
            get { return this._workDuration; }
            set { this._workDuration = value; }
        }

        // Check to see if WorkDuration property is set
        internal bool IsSetWorkDuration()
        {
            return this._workDuration.HasValue; 
        }

    }
}