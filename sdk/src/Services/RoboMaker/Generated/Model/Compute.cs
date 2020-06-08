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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Compute information for the simulation job.
    /// </summary>
    public partial class Compute
    {
        private int? _simulationUnitLimit;

        /// <summary>
        /// Gets and sets the property SimulationUnitLimit. 
        /// <para>
        /// The simulation unit limit. Your simulation is allocated CPU and memory proportional
        /// to the supplied simulation unit limit. A simulation unit is 1 vcpu and 2GB of memory.
        /// You are only billed for the SU utilization you consume up to the maximim value provided.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public int SimulationUnitLimit
        {
            get { return this._simulationUnitLimit.GetValueOrDefault(); }
            set { this._simulationUnitLimit = value; }
        }

        // Check to see if SimulationUnitLimit property is set
        internal bool IsSetSimulationUnitLimit()
        {
            return this._simulationUnitLimit.HasValue; 
        }

    }
}