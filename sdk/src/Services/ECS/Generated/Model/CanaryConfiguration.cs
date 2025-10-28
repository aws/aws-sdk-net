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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Configuration for canary deployment strategy that shifts a fixed percentage of traffic
    /// to the new service revision, waits for a specified bake time, then shifts the remaining
    /// traffic. 
    /// 
    ///  
    /// <para>
    /// This is only valid when you run <c>CreateService</c> or <c>UpdateService</c> with
    /// <c>deploymentController</c> set to <c>ECS</c> and a <c>deploymentConfiguration</c>
    /// with a strategy set to <c>CANARY</c>. 
    /// </para>
    /// </summary>
    public partial class CanaryConfiguration
    {
        private int? _canaryBakeTimeInMinutes;
        private double? _canaryPercent;

        /// <summary>
        /// Gets and sets the property CanaryBakeTimeInMinutes. 
        /// <para>
        /// The amount of time in minutes to wait during the canary phase before shifting the
        /// remaining production traffic to the new service revision. Valid values are 0 to 1440
        /// minutes (24 hours). The default value is 10.
        /// </para>
        /// </summary>
        public int? CanaryBakeTimeInMinutes
        {
            get { return this._canaryBakeTimeInMinutes; }
            set { this._canaryBakeTimeInMinutes = value; }
        }

        // Check to see if CanaryBakeTimeInMinutes property is set
        internal bool IsSetCanaryBakeTimeInMinutes()
        {
            return this._canaryBakeTimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CanaryPercent. 
        /// <para>
        /// The percentage of production traffic to shift to the new service revision during the
        /// canary phase. Valid values are 0.1 to 100.0. The default value is 5.0.
        /// </para>
        /// </summary>
        public double? CanaryPercent
        {
            get { return this._canaryPercent; }
            set { this._canaryPercent = value; }
        }

        // Check to see if CanaryPercent property is set
        internal bool IsSetCanaryPercent()
        {
            return this._canaryPercent.HasValue; 
        }

    }
}