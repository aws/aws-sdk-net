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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Details about Kubernetes resources such as a Kubernetes user or workload resource
    /// involved in a Kubernetes finding.
    /// </summary>
    public partial class KubernetesDetails
    {
        /// <summary>
        /// Gets and sets the property KubernetesUserDetails. 
        /// <para>
        /// Details about the Kubernetes user involved in a Kubernetes finding.
        /// </para>
        /// </summary>
        public KubernetesUserDetails KubernetesUserDetails { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesUserDetails property is set.
        /// </summary>
        internal bool IsSetKubernetesUserDetails() => this.KubernetesUserDetails != null;

        /// <summary>
        /// Gets and sets the property KubernetesWorkloadDetails. 
        /// <para>
        /// Details about the Kubernetes workload involved in a Kubernetes finding.
        /// </para>
        /// </summary>
        public KubernetesWorkloadDetails KubernetesWorkloadDetails { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesWorkloadDetails property is set.
        /// </summary>
        internal bool IsSetKubernetesWorkloadDetails() => this.KubernetesWorkloadDetails != null;
    }
}
