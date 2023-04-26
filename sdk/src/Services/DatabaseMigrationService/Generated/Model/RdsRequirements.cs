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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes the requirements to the target engine on Amazon
    /// RDS.
    /// </summary>
    public partial class RdsRequirements
    {
        private string _deploymentOption;
        private string _engineEdition;
        private double? _instanceMemory;
        private double? _instanceVcpu;
        private int? _storageIops;
        private int? _storageSize;

        /// <summary>
        /// Gets and sets the property DeploymentOption. 
        /// <para>
        /// The required deployment option for the Amazon RDS DB instance. Valid values include
        /// <code>"MULTI_AZ"</code> for Multi-AZ deployments and <code>"SINGLE_AZ"</code> for
        /// Single-AZ deployments.
        /// </para>
        /// </summary>
        public string DeploymentOption
        {
            get { return this._deploymentOption; }
            set { this._deploymentOption = value; }
        }

        // Check to see if DeploymentOption property is set
        internal bool IsSetDeploymentOption()
        {
            return this._deploymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property EngineEdition. 
        /// <para>
        /// The required target Amazon RDS engine edition.
        /// </para>
        /// </summary>
        public string EngineEdition
        {
            get { return this._engineEdition; }
            set { this._engineEdition = value; }
        }

        // Check to see if EngineEdition property is set
        internal bool IsSetEngineEdition()
        {
            return this._engineEdition != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceMemory. 
        /// <para>
        /// The required memory on the Amazon RDS DB instance.
        /// </para>
        /// </summary>
        public double InstanceMemory
        {
            get { return this._instanceMemory.GetValueOrDefault(); }
            set { this._instanceMemory = value; }
        }

        // Check to see if InstanceMemory property is set
        internal bool IsSetInstanceMemory()
        {
            return this._instanceMemory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceVcpu. 
        /// <para>
        /// The required number of virtual CPUs (vCPU) on the Amazon RDS DB instance.
        /// </para>
        /// </summary>
        public double InstanceVcpu
        {
            get { return this._instanceVcpu.GetValueOrDefault(); }
            set { this._instanceVcpu = value; }
        }

        // Check to see if InstanceVcpu property is set
        internal bool IsSetInstanceVcpu()
        {
            return this._instanceVcpu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageIops. 
        /// <para>
        /// The required number of I/O operations completed each second (IOPS) on your Amazon
        /// RDS DB instance.
        /// </para>
        /// </summary>
        public int StorageIops
        {
            get { return this._storageIops.GetValueOrDefault(); }
            set { this._storageIops = value; }
        }

        // Check to see if StorageIops property is set
        internal bool IsSetStorageIops()
        {
            return this._storageIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageSize. 
        /// <para>
        /// The required Amazon RDS DB instance storage size.
        /// </para>
        /// </summary>
        public int StorageSize
        {
            get { return this._storageSize.GetValueOrDefault(); }
            set { this._storageSize = value; }
        }

        // Check to see if StorageSize property is set
        internal bool IsSetStorageSize()
        {
            return this._storageSize.HasValue; 
        }

    }
}