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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// The configuration settings for the Slurm orchestrator used with the SageMaker HyperPod
    /// cluster.
    /// </summary>
    public partial class ClusterOrchestratorSlurmConfig
    {
        private ClusterSlurmConfigStrategy _slurmConfigStrategy;

        /// <summary>
        /// Gets and sets the property SlurmConfigStrategy. 
        /// <para>
        /// The strategy for managing partitions for the Slurm configuration. Valid values are
        /// <c>Managed</c>, <c>Overwrite</c>, and <c>Merge</c>.
        /// </para>
        /// </summary>
        public ClusterSlurmConfigStrategy SlurmConfigStrategy
        {
            get { return this._slurmConfigStrategy; }
            set { this._slurmConfigStrategy = value; }
        }

        // Check to see if SlurmConfigStrategy property is set
        internal bool IsSetSlurmConfigStrategy()
        {
            return this._slurmConfigStrategy != null;
        }

    }
}