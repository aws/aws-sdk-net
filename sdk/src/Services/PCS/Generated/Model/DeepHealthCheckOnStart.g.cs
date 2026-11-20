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
    /// The deep health check that runs each time an instance starts, including after a reboot,
    /// before the compute node accepts jobs.
    /// </summary>
    public partial class DeepHealthCheckOnStart
    {
        /// <summary>
        /// Gets and sets the property Profile. 
        /// <para>
        /// The deep health check profile to run. Each profile other than <c>NONE</c> runs NVIDIA
        /// Data Center GPU Manager (DCGM) diagnostics. More thorough profiles run more tests
        /// and add more time to instance launch. A profile other than <c>NONE</c> requires instance
        /// types with NVIDIA GPUs. This value is required when you specify <c>onStart</c>. There
        /// is no default value. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> – Turns off the deep health check. You can't specify <c>repairAction</c>
        /// with this profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUICK</c> – Runs basic GPU tests (DCGM diagnostics level 1). This profile adds
        /// the least time to instance launch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEDIUM</c> – Runs extended GPU tests (DCGM diagnostics level 2).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LONG</c> – Runs GPU stress and diagnostic tests (DCGM diagnostics level 3). This
        /// profile adds the most time to instance launch.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeepHealthCheckOnStartProfile Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;

        /// <summary>
        /// Gets and sets the property RepairAction. 
        /// <para>
        /// The action that PCS takes when an instance fails the deep health check. You can't
        /// specify this value when <c>profile</c> is <c>NONE</c>. If you don't specify this value
        /// and <c>profile</c> isn't <c>NONE</c>, PCS uses <c>AUTO</c>. <c>GetComputeNodeGroup</c>
        /// doesn't return a <c>repairAction</c> that you didn't specify. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AUTO</c> – PCS chooses the repair action based on the fault.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLACE</c> – Replaces the instance before it accepts jobs.
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
        public DeepHealthCheckOnStartRepairAction RepairAction { get; set; }

        /// <summary>
        /// Checks to see if the RepairAction property is set.
        /// </summary>
        internal bool IsSetRepairAction() => this.RepairAction != null;
    }
}
