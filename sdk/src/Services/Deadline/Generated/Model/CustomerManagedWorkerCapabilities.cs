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
    /// The worker capabilities for a customer managed workflow.
    /// </summary>
    public partial class CustomerManagedWorkerCapabilities
    {
        private AcceleratorCountRange _acceleratorCount;
        private AcceleratorTotalMemoryMiBRange _acceleratorTotalMemoryMiB;
        private List<string> _acceleratorTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CpuArchitectureType _cpuArchitectureType;
        private List<FleetAmountCapability> _customAmounts = AWSConfigs.InitializeCollections ? new List<FleetAmountCapability>() : null;
        private List<FleetAttributeCapability> _customAttributes = AWSConfigs.InitializeCollections ? new List<FleetAttributeCapability>() : null;
        private MemoryMiBRange _memoryMiB;
        private CustomerManagedFleetOperatingSystemFamily _osFamily;
        private VCpuCountRange _vCpuCount;

        /// <summary>
        /// Gets and sets the property AcceleratorCount. 
        /// <para>
        /// The range of the accelerator.
        /// </para>
        /// </summary>
        public AcceleratorCountRange AcceleratorCount
        {
            get { return this._acceleratorCount; }
            set { this._acceleratorCount = value; }
        }

        // Check to see if AcceleratorCount property is set
        internal bool IsSetAcceleratorCount()
        {
            return this._acceleratorCount != null;
        }

        /// <summary>
        /// Gets and sets the property AcceleratorTotalMemoryMiB. 
        /// <para>
        /// The total memory (MiB) for the customer managed worker capabilities.
        /// </para>
        /// </summary>
        public AcceleratorTotalMemoryMiBRange AcceleratorTotalMemoryMiB
        {
            get { return this._acceleratorTotalMemoryMiB; }
            set { this._acceleratorTotalMemoryMiB = value; }
        }

        // Check to see if AcceleratorTotalMemoryMiB property is set
        internal bool IsSetAcceleratorTotalMemoryMiB()
        {
            return this._acceleratorTotalMemoryMiB != null;
        }

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        /// The accelerator types for the customer managed worker capabilities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AcceleratorTypes
        {
            get { return this._acceleratorTypes; }
            set { this._acceleratorTypes = value; }
        }

        // Check to see if AcceleratorTypes property is set
        internal bool IsSetAcceleratorTypes()
        {
            return this._acceleratorTypes != null && (this._acceleratorTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CpuArchitectureType. 
        /// <para>
        /// The CPU architecture type for the customer managed worker capabilities.
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
        /// Custom requirement ranges for customer managed worker capabilities.
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
        /// Custom attributes for the customer manged worker capabilities.
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
        /// Gets and sets the property MemoryMiB. 
        /// <para>
        /// The memory (MiB).
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
        public CustomerManagedFleetOperatingSystemFamily OsFamily
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
        /// Gets and sets the property VCpuCount. 
        /// <para>
        /// The vCPU count for the customer manged worker capabilities.
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