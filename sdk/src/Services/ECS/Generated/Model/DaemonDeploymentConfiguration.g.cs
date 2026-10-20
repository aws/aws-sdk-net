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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Optional deployment parameters that control how a daemon rolls out updates across
    /// container instances.
    /// </summary>
    public partial class DaemonDeploymentConfiguration
    {
        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The CloudWatch alarm configuration for the daemon deployment. When alarms are triggered
        /// during a deployment, the deployment can be automatically rolled back.
        /// </para>
        /// </summary>
        public DaemonAlarmConfiguration Alarms { get; set; }

        /// <summary>
        /// Checks to see if the Alarms property is set.
        /// </summary>
        internal bool IsSetAlarms() => this.Alarms != null;

        /// <summary>
        /// Gets and sets the property BakeTimeInMinutes. 
        /// <para>
        /// The amount of time (in minutes) to wait after a successful deployment step before
        /// proceeding. This allows time to monitor for issues before continuing. The default
        /// value is 0.
        /// </para>
        /// </summary>
        public int? BakeTimeInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the BakeTimeInMinutes property is set.
        /// </summary>
        internal bool IsSetBakeTimeInMinutes() => this.BakeTimeInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property DrainPercent. 
        /// <para>
        /// The percentage of container instances to drain simultaneously during a daemon deployment.
        /// Valid values are between 0.0 and 100.0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? DrainPercent { get; set; }

        /// <summary>
        /// Checks to see if the DrainPercent property is set.
        /// </summary>
        internal bool IsSetDrainPercent() => this.DrainPercent.HasValue;
    }
}
