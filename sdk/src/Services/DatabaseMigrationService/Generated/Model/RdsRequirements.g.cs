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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes the requirements to the target engine on Amazon
    /// RDS.
    /// </summary>
    public partial class RdsRequirements
    {
        /// <summary>
        /// Gets and sets the property DeploymentOption. 
        /// <para>
        /// The required deployment option for the Amazon RDS DB instance. Valid values include
        /// <c>"MULTI_AZ"</c> for Multi-AZ deployments and <c>"SINGLE_AZ"</c> for Single-AZ deployments.
        /// </para>
        /// </summary>
        public string DeploymentOption { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentOption property is set.
        /// </summary>
        internal bool IsSetDeploymentOption() => this.DeploymentOption != null;

        /// <summary>
        /// Gets and sets the property EngineEdition. 
        /// <para>
        /// The required target Amazon RDS engine edition.
        /// </para>
        /// </summary>
        public string EngineEdition { get; set; }

        /// <summary>
        /// Checks to see if the EngineEdition property is set.
        /// </summary>
        internal bool IsSetEngineEdition() => this.EngineEdition != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The required target Amazon RDS engine version.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property InstanceMemory. 
        /// <para>
        /// The required memory on the Amazon RDS DB instance.
        /// </para>
        /// </summary>
        public double? InstanceMemory { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMemory property is set.
        /// </summary>
        internal bool IsSetInstanceMemory() => this.InstanceMemory.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceVcpu. 
        /// <para>
        /// The required number of virtual CPUs (vCPU) on the Amazon RDS DB instance.
        /// </para>
        /// </summary>
        public double? InstanceVcpu { get; set; }

        /// <summary>
        /// Checks to see if the InstanceVcpu property is set.
        /// </summary>
        internal bool IsSetInstanceVcpu() => this.InstanceVcpu.HasValue;

        /// <summary>
        /// Gets and sets the property StorageIops. 
        /// <para>
        /// The required number of I/O operations completed each second (IOPS) on your Amazon
        /// RDS DB instance.
        /// </para>
        /// </summary>
        public int? StorageIops { get; set; }

        /// <summary>
        /// Checks to see if the StorageIops property is set.
        /// </summary>
        internal bool IsSetStorageIops() => this.StorageIops.HasValue;

        /// <summary>
        /// Gets and sets the property StorageSize. 
        /// <para>
        /// The required Amazon RDS DB instance storage size.
        /// </para>
        /// </summary>
        public int? StorageSize { get; set; }

        /// <summary>
        /// Checks to see if the StorageSize property is set.
        /// </summary>
        internal bool IsSetStorageSize() => this.StorageSize.HasValue;
    }
}
