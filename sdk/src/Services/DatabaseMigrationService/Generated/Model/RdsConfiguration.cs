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
    /// Provides information that describes the configuration of the recommended target engine
    /// on Amazon RDS.
    /// </summary>
    public partial class RdsConfiguration
    {
        private string _deploymentOption;
        private string _engineEdition;
        private double? _instanceMemory;
        private string _instanceType;
        private double? _instanceVcpu;
        private int? _storageIops;
        private int? _storageSize;
        private string _storageType;

        /// <summary>
        /// Gets and sets the property DeploymentOption. 
        /// <para>
        /// Describes the deployment option for the recommended Amazon RDS DB instance. The deployment
        /// options include Multi-AZ and Single-AZ deployments. Valid values include <code>"MULTI_AZ"</code>
        /// and <code>"SINGLE_AZ"</code>.
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
        /// Describes the recommended target Amazon RDS engine edition.
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
        /// Describes the memory on the recommended Amazon RDS DB instance that meets your requirements.
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Describes the recommended target Amazon RDS instance type.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceVcpu. 
        /// <para>
        /// Describes the number of virtual CPUs (vCPU) on the recommended Amazon RDS DB instance
        /// that meets your requirements.
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
        /// Describes the number of I/O operations completed each second (IOPS) on the recommended
        /// Amazon RDS DB instance that meets your requirements.
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
        /// Describes the storage size of the recommended Amazon RDS DB instance that meets your
        /// requirements.
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

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Describes the storage type of the recommended Amazon RDS DB instance that meets your
        /// requirements.
        /// </para>
        ///  
        /// <para>
        /// Amazon RDS provides three storage types: General Purpose SSD (also known as gp2 and
        /// gp3), Provisioned IOPS SSD (also known as io1), and magnetic (also known as standard).
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}