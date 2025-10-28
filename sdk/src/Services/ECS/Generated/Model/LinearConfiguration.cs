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
    /// Configuration for linear deployment strategy that shifts production traffic in equal
    /// percentage increments with configurable wait times between each step until 100% of
    /// traffic is shifted to the new service revision. This is only valid when you run <c>CreateService</c>
    /// or <c>UpdateService</c> with <c>deploymentController</c> set to <c>ECS</c> and a <c>deploymentConfiguration</c>
    /// with a strategy set to <c>LINEAR</c>.
    /// </summary>
    public partial class LinearConfiguration
    {
        private int? _stepBakeTimeInMinutes;
        private double? _stepPercent;

        /// <summary>
        /// Gets and sets the property StepBakeTimeInMinutes. 
        /// <para>
        /// The amount of time in minutes to wait between each traffic shifting step during a
        /// linear deployment. Valid values are 0 to 1440 minutes (24 hours). The default value
        /// is 6. This bake time is not applied after reaching 100% traffic.
        /// </para>
        /// </summary>
        public int? StepBakeTimeInMinutes
        {
            get { return this._stepBakeTimeInMinutes; }
            set { this._stepBakeTimeInMinutes = value; }
        }

        // Check to see if StepBakeTimeInMinutes property is set
        internal bool IsSetStepBakeTimeInMinutes()
        {
            return this._stepBakeTimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepPercent. 
        /// <para>
        /// The percentage of production traffic to shift in each step during a linear deployment.
        /// Valid values are 3.0 to 100.0. The default value is 10.0.
        /// </para>
        /// </summary>
        public double? StepPercent
        {
            get { return this._stepPercent; }
            set { this._stepPercent = value; }
        }

        // Check to see if StepPercent property is set
        internal bool IsSetStepPercent()
        {
            return this._stepPercent.HasValue; 
        }

    }
}