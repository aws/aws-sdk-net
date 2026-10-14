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
    /// The type of orchestrator used for the SageMaker HyperPod cluster.
    /// </summary>
    public partial class ClusterOrchestrator
    {
        /// <summary>
        /// Gets and sets the property Eks. 
        /// <para>
        /// The Amazon EKS cluster used as the orchestrator for the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public ClusterOrchestratorEksConfig Eks { get; set; }

        /// <summary>
        /// Checks to see if the Eks property is set.
        /// </summary>
        internal bool IsSetEks() => this.Eks != null;

        /// <summary>
        /// Gets and sets the property Slurm. 
        /// <para>
        /// The Slurm orchestrator configuration for the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public ClusterOrchestratorSlurmConfig Slurm { get; set; }

        /// <summary>
        /// Checks to see if the Slurm property is set.
        /// </summary>
        internal bool IsSetSlurm() => this.Slurm != null;
    }
}
