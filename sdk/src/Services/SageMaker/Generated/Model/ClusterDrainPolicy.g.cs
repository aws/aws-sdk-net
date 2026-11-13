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
    /// Specifies how pods are evicted from an instance before it is patched with the <c>DrainFirst</c>
    /// strategy. By default, evictions respect Kubernetes Pod Disruption Budgets.
    /// </summary>
    public partial class ClusterDrainPolicy
    {
        /// <summary>
        /// Gets and sets the property DrainTimeoutInSeconds. 
        /// <para>
        /// The maximum time, in seconds, to wait for the pods on an instance to drain. Valid
        /// values are from 0 to 5400 (90 minutes). The default is 3600 (1 hour).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 5400)]
        public int? DrainTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DrainTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetDrainTimeoutInSeconds() => this.DrainTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property OnDrainTimeout. 
        /// <para>
        /// The action to take if the pods on an instance don't drain within <c>DrainTimeoutInSeconds</c>.
        /// The default is <c>Skip</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Skip</c>: Doesn't patch the instance. The instance is uncordoned and remains on
        /// the previous AMI version. This can leave the instance group partially patched. You
        /// can then use UpdateClusterSoftware with the desired ImageReleaseVersion to manually
        /// update the remaining instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Force</c>: Deletes the remaining pods without respecting Pod Disruption Budgets,
        /// and then patches the instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClusterOnDrainTimeout OnDrainTimeout { get; set; }

        /// <summary>
        /// Checks to see if the OnDrainTimeout property is set.
        /// </summary>
        internal bool IsSetOnDrainTimeout() => this.OnDrainTimeout != null;
    }
}
