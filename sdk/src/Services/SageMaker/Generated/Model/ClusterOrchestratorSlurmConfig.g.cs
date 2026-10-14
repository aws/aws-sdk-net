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
    /// The configuration settings for the Slurm orchestrator used with the SageMaker HyperPod
    /// cluster.
    /// </summary>
    public partial class ClusterOrchestratorSlurmConfig
    {
        /// <summary>
        /// Gets and sets the property AccountingDatabase. 
        /// <para>
        /// The external database that stores the Slurm accounting data for the cluster, such
        /// as job history, associations, and usage. When you omit this field, Slurm accounting
        /// uses a database on the cluster's controller node.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is only supported for clusters using <c>Continuous</c> as the <c>NodeProvisioningMode</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public ClusterAccountingDatabase AccountingDatabase { get; set; }

        /// <summary>
        /// Checks to see if the AccountingDatabase property is set.
        /// </summary>
        internal bool IsSetAccountingDatabase() => this.AccountingDatabase != null;

        /// <summary>
        /// Gets and sets the property SlurmConfigStrategy. 
        /// <para>
        /// The strategy for managing partitions for the Slurm configuration. Valid values are
        /// <c>Managed</c>, <c>Overwrite</c>, and <c>Merge</c>.
        /// </para>
        /// </summary>
        public ClusterSlurmConfigStrategy SlurmConfigStrategy { get; set; }

        /// <summary>
        /// Checks to see if the SlurmConfigStrategy property is set.
        /// </summary>
        internal bool IsSetSlurmConfigStrategy() => this.SlurmConfigStrategy != null;
    }
}
