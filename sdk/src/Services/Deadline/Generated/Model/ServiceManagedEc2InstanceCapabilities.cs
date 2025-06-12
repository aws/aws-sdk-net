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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The Amazon EC2 instance capabilities.
    /// </summary>
    public partial class ServiceManagedEc2InstanceCapabilities
    {
        private AcceleratorCapabilities _acceleratorCapabilities;
        private List<string> _allowedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CpuArchitectureType _cpuArchitectureType;
        private List<FleetAmountCapability> _customAmounts = AWSConfigs.InitializeCollections ? new List<FleetAmountCapability>() : null;
        private List<FleetAttributeCapability> _customAttributes = AWSConfigs.InitializeCollections ? new List<FleetAttributeCapability>() : null;
        private List<string> _excludedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MemoryMiBRange _memoryMiB;
        private ServiceManagedFleetOperatingSystemFamily _osFamily;
        private Ec2EbsVolume _rootEbsVolume;
        private VCpuCountRange _vCpuCount;

        /// <summary>
        /// Gets and sets the property AcceleratorCapabilities. 
        /// <para>
        /// Describes the GPU accelerator capabilities required for worker host instances in this
        /// fleet.
        /// </para>
        /// </summary>
        public AcceleratorCapabilities AcceleratorCapabilities
        {
            get { return this._acceleratorCapabilities; }
            set { this._acceleratorCapabilities = value; }
        }

        // Check to see if AcceleratorCapabilities property is set
        internal bool IsSetAcceleratorCapabilities()
        {
            return this._acceleratorCapabilities != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedInstanceTypes. 
        /// <para>
        /// The allowable Amazon EC2 instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> AllowedInstanceTypes
        {
            get { return this._allowedInstanceTypes; }
            set { this._allowedInstanceTypes = value; }
        }

        // Check to see if AllowedInstanceTypes property is set
        internal bool IsSetAllowedInstanceTypes()
        {
            return this._allowedInstanceTypes != null && (this._allowedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CpuArchitectureType. 
        /// <para>
        /// The CPU architecture type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CpuArchitectureType CpuArchitectureType
        {
            get { return this._cpuArchitectureType; }
            set { this._cpuArchitectureType = value; }
        }

        // Check to see if CpuArchitectureType property is set
        internal bool IsSetCpuArchitectureType()
        {
            return this._cpuArchitectureType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomAmounts. 
        /// <para>
        /// The custom capability amounts to require for instances in this fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public List<FleetAmountCapability> CustomAmounts
        {
            get { return this._customAmounts; }
            set { this._customAmounts = value; }
        }

        // Check to see if CustomAmounts property is set
        internal bool IsSetCustomAmounts()
        {
            return this._customAmounts != null && (this._customAmounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// The custom capability attributes to require for instances in this fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public List<FleetAttributeCapability> CustomAttributes
        {
            get { return this._customAttributes; }
            set { this._customAttributes = value; }
        }

        // Check to see if CustomAttributes property is set
        internal bool IsSetCustomAttributes()
        {
            return this._customAttributes != null && (this._customAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludedInstanceTypes. 
        /// <para>
        /// The instance types to exclude from the fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ExcludedInstanceTypes
        {
            get { return this._excludedInstanceTypes; }
            set { this._excludedInstanceTypes = value; }
        }

        // Check to see if ExcludedInstanceTypes property is set
        internal bool IsSetExcludedInstanceTypes()
        {
            return this._excludedInstanceTypes != null && (this._excludedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MemoryMiB. 
        /// <para>
        /// The memory, as MiB, for the Amazon EC2 instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryMiBRange MemoryMiB
        {
            get { return this._memoryMiB; }
            set { this._memoryMiB = value; }
        }

        // Check to see if MemoryMiB property is set
        internal bool IsSetMemoryMiB()
        {
            return this._memoryMiB != null;
        }

        /// <summary>
        /// Gets and sets the property OsFamily. 
        /// <para>
        /// The operating system (OS) family.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceManagedFleetOperatingSystemFamily OsFamily
        {
            get { return this._osFamily; }
            set { this._osFamily = value; }
        }

        // Check to see if OsFamily property is set
        internal bool IsSetOsFamily()
        {
            return this._osFamily != null;
        }

        /// <summary>
        /// Gets and sets the property RootEbsVolume. 
        /// <para>
        /// The root EBS volume.
        /// </para>
        /// </summary>
        public Ec2EbsVolume RootEbsVolume
        {
            get { return this._rootEbsVolume; }
            set { this._rootEbsVolume = value; }
        }

        // Check to see if RootEbsVolume property is set
        internal bool IsSetRootEbsVolume()
        {
            return this._rootEbsVolume != null;
        }

        /// <summary>
        /// Gets and sets the property VCpuCount. 
        /// <para>
        /// The amount of vCPU to require for instances in this fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VCpuCountRange VCpuCount
        {
            get { return this._vCpuCount; }
            set { this._vCpuCount = value; }
        }

        // Check to see if VCpuCount property is set
        internal bool IsSetVCpuCount()
        {
            return this._vCpuCount != null;
        }

    }
}