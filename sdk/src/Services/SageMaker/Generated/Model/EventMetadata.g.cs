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
    /// Metadata associated with a cluster event, which may include details about various
    /// resource types.
    /// </summary>
    public partial class EventMetadata
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// Metadata specific to cluster-level events.
        /// </para>
        /// </summary>
        public ClusterMetadata Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property DatabaseConfiguration. 
        /// <para>
        /// Metadata specific to events about the external Slurm accounting database of the cluster.
        /// </para>
        /// </summary>
        public DatabaseConfigurationMetadata DatabaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseConfiguration property is set.
        /// </summary>
        internal bool IsSetDatabaseConfiguration() => this.DatabaseConfiguration != null;

        /// <summary>
        /// Gets and sets the property Instance. 
        /// <para>
        /// Metadata specific to instance-level events.
        /// </para>
        /// </summary>
        public InstanceMetadata Instance { get; set; }

        /// <summary>
        /// Checks to see if the Instance property is set.
        /// </summary>
        internal bool IsSetInstance() => this.Instance != null;

        /// <summary>
        /// Gets and sets the property InstanceGroup. 
        /// <para>
        /// Metadata specific to instance group-level events.
        /// </para>
        /// </summary>
        public InstanceGroupMetadata InstanceGroup { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroup property is set.
        /// </summary>
        internal bool IsSetInstanceGroup() => this.InstanceGroup != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupScaling. 
        /// <para>
        /// Metadata related to instance group scaling events.
        /// </para>
        /// </summary>
        public InstanceGroupScalingMetadata InstanceGroupScaling { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupScaling property is set.
        /// </summary>
        internal bool IsSetInstanceGroupScaling() => this.InstanceGroupScaling != null;

        /// <summary>
        /// Gets and sets the property SlurmHealth. 
        /// <para>
        /// Metadata specific to events about the health of the Slurm components on the controller
        /// node of the cluster.
        /// </para>
        /// </summary>
        public SlurmHealthMetadata SlurmHealth { get; set; }

        /// <summary>
        /// Checks to see if the SlurmHealth property is set.
        /// </summary>
        internal bool IsSetSlurmHealth() => this.SlurmHealth != null;
    }
}
