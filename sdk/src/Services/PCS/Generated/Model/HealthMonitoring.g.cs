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
    /// The health monitoring settings of a compute node group. Health monitoring continuously
    /// checks running instances for hardware and software faults.
    /// </summary>
    public partial class HealthMonitoring
    {
        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The health monitoring mode. This value is required when you specify <c>healthMonitoring</c>.
        /// There is no default value. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> – Turns off health monitoring. You can't specify <c>repairAction</c>
        /// with this mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STANDARD</c> – Continuously checks running instances for hardware and software
        /// faults.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HealthMonitoringMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property RepairAction. 
        /// <para>
        /// The action that PCS takes when health monitoring finds a fault on an instance. You
        /// can't specify this value when <c>mode</c> is <c>NONE</c>. If you don't specify this
        /// value and <c>mode</c> isn't <c>NONE</c>, PCS uses <c>AUTO</c>. <c>GetComputeNodeGroup</c>
        /// doesn't return a <c>repairAction</c> that you didn't specify. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AUTO</c> – PCS chooses the repair action based on the fault.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLACE</c> – Replaces the instance after running jobs finish.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ISOLATE</c> – Stops new jobs on the instance and keeps the instance running until
        /// you investigate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – Records the fault in Slurm and leaves the instance available for jobs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HealthMonitoringRepairAction RepairAction { get; set; }

        /// <summary>
        /// Checks to see if the RepairAction property is set.
        /// </summary>
        internal bool IsSetRepairAction() => this.RepairAction != null;
    }
}
