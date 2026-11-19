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
    /// Contains details about a Kubernetes workload.
    /// </summary>
    public partial class InvestigationKubernetesWorkload
    {
        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The containers in the workload.
        /// </para>
        /// </summary>
        public string Containers { get; set; }

        /// <summary>
        /// Checks to see if the Containers property is set.
        /// </summary>
        internal bool IsSetContainers() => this.Containers != null;

        /// <summary>
        /// Gets and sets the property SecurityContext. 
        /// <para>
        /// The security context of the workload.
        /// </para>
        /// </summary>
        public string SecurityContext { get; set; }

        /// <summary>
        /// Checks to see if the SecurityContext property is set.
        /// </summary>
        internal bool IsSetSecurityContext() => this.SecurityContext != null;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// The volumes of the workload.
        /// </para>
        /// </summary>
        public string Volumes { get; set; }

        /// <summary>
        /// Checks to see if the Volumes property is set.
        /// </summary>
        internal bool IsSetVolumes() => this.Volumes != null;

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload.
        /// </para>
        /// </summary>
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;

        /// <summary>
        /// Gets and sets the property WorkloadType. 
        /// <para>
        /// The type of the workload.
        /// </para>
        /// </summary>
        public string WorkloadType { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadType property is set.
        /// </summary>
        internal bool IsSetWorkloadType() => this.WorkloadType != null;
    }
}
