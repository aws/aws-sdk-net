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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// The instance health check settings of a compute node group. Instance health checks
    /// detect faults on instances in the compute node group and respond with the repair action
    /// that you choose.
    /// </summary>
    public partial class InstanceHealthChecks
    {
        /// <summary>
        /// Gets and sets the property DeepHealthChecks. 
        /// <para>
        /// The deep health check settings. Deep health checks test the graphics processing units
        /// (GPUs) of an instance each time it starts, including after a reboot, before it accepts
        /// jobs.
        /// </para>
        /// </summary>
        public DeepHealthChecks DeepHealthChecks { get; set; }

        /// <summary>
        /// Checks to see if the DeepHealthChecks property is set.
        /// </summary>
        internal bool IsSetDeepHealthChecks() => this.DeepHealthChecks != null;

        /// <summary>
        /// Gets and sets the property HealthMonitoring. 
        /// <para>
        /// The health monitoring settings. Health monitoring continuously checks running instances
        /// for hardware and software faults.
        /// </para>
        /// </summary>
        public HealthMonitoring HealthMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the HealthMonitoring property is set.
        /// </summary>
        internal bool IsSetHealthMonitoring() => this.HealthMonitoring != null;
    }
}
