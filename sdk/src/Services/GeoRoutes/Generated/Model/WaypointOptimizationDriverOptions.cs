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
    /// Driver related options.
    /// </summary>
    public partial class WaypointOptimizationDriverOptions
    {
        private WaypointOptimizationRestCycles _restCycles;
        private WaypointOptimizationRestProfile _restProfile;
        private WaypointOptimizationServiceTimeTreatment _treatServiceTimeAs;

        /// <summary>
        /// Gets and sets the property RestCycles. 
        /// <para>
        /// Driver work-rest schedules defined by a short and long cycle. A rest needs to be taken
        /// after the short work duration. The short cycle can be repeated until you hit the long
        /// work duration, at which point the long rest duration should be taken before restarting.
        /// </para>
        /// </summary>
        public WaypointOptimizationRestCycles RestCycles
        {
            get { return this._restCycles; }
            set { this._restCycles = value; }
        }

        // Check to see if RestCycles property is set
        internal bool IsSetRestCycles()
        {
            return this._restCycles != null;
        }

        /// <summary>
        /// Gets and sets the property RestProfile. 
        /// <para>
        /// Pre defined rest profiles for a driver schedule. The only currently supported profile
        /// is EU.
        /// </para>
        /// </summary>
        public WaypointOptimizationRestProfile RestProfile
        {
            get { return this._restProfile; }
            set { this._restProfile = value; }
        }

        // Check to see if RestProfile property is set
        internal bool IsSetRestProfile()
        {
            return this._restProfile != null;
        }

        /// <summary>
        /// Gets and sets the property TreatServiceTimeAs. 
        /// <para>
        /// If the service time provided at a waypoint/destination should be considered as rest
        /// or work. This contributes to the total time breakdown returned within the response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public WaypointOptimizationServiceTimeTreatment TreatServiceTimeAs
        {
            get { return this._treatServiceTimeAs; }
            set { this._treatServiceTimeAs = value; }
        }

        // Check to see if TreatServiceTimeAs property is set
        internal bool IsSetTreatServiceTimeAs()
        {
            return this._treatServiceTimeAs != null;
        }

    }
}