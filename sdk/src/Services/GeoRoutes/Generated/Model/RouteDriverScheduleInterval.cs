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
    /// Interval of the driver work-rest schedule. Stops are added to fulfil the provided
    /// rest schedule.
    /// </summary>
    public partial class RouteDriverScheduleInterval
    {
        private long? _driveDuration;
        private long? _restDuration;

        /// <summary>
        /// Gets and sets the property DriveDuration. 
        /// <para>
        /// Maximum allowed driving time before stopping to rest.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? DriveDuration
        {
            get { return this._driveDuration; }
            set { this._driveDuration = value; }
        }

        // Check to see if DriveDuration property is set
        internal bool IsSetDriveDuration()
        {
            return this._driveDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestDuration. 
        /// <para>
        /// Resting time before the driver can continue driving.
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

    }
}