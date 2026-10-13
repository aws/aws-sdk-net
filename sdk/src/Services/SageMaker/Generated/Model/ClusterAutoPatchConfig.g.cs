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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration for automatic patching of the instance group. When configured, the
    /// system automatically applies security patch AMI updates to the instance group.
    /// </summary>
    public partial class ClusterAutoPatchConfig
    {
        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The deployment configuration for rolling patch updates, including rollback settings
        /// and batch sizes. Only applicable when using a rolling patching strategy.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfig property is set.
        /// </summary>
        internal bool IsSetDeploymentConfig() => this.DeploymentConfig != null;

        /// <summary>
        /// Gets and sets the property PatchSchedule. 
        /// <para>
        /// The schedule for automatic patching, including the next patch date.
        /// </para>
        /// </summary>
        public ClusterPatchSchedule PatchSchedule { get; set; }

        /// <summary>
        /// Checks to see if the PatchSchedule property is set.
        /// </summary>
        internal bool IsSetPatchSchedule() => this.PatchSchedule != null;

        /// <summary>
        /// Gets and sets the property PatchingStrategy. 
        /// <para>
        /// The strategy for applying patches to instances in the group.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>WhenIdle</c>: Cordons all instances and patches each instance as it becomes idle
        /// (no running jobs). Each instance is uncordoned immediately after patching and becomes
        /// available for new jobs. If instances do not become idle, they remain on the previous
        /// AMI version. You can then use UpdateClusterSoftware with the desired ImageReleaseVersion
        /// to manually update the remaining instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WhenAllIdle</c>: Cordons all instances and waits for all to become idle before
        /// patching. All instances are uncordoned after patching completes. If not all instances
        /// become idle, no patching occurs and all instances remain on the previous AMI version.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterPatchingStrategy PatchingStrategy { get; set; }

        /// <summary>
        /// Checks to see if the PatchingStrategy property is set.
        /// </summary>
        internal bool IsSetPatchingStrategy() => this.PatchingStrategy != null;
    }
}
