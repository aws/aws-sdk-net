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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The Amazon EC2 instance capabilities.
    /// </summary>
    public partial class ServiceManagedEc2InstanceCapabilities
    {
        /// <summary>
        /// Gets and sets the property AcceleratorCapabilities. 
        /// <para>
        /// Describes the GPU accelerator capabilities required for worker host instances in this
        /// fleet.
        /// </para>
        /// </summary>
        public AcceleratorCapabilities AcceleratorCapabilities { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorCapabilities property is set.
        /// </summary>
        internal bool IsSetAcceleratorCapabilities() => this.AcceleratorCapabilities != null;

        /// <summary>
        /// Gets and sets the property AllowedInstanceTypes. 
        /// <para>
        /// The allowable Amazon EC2 instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> AllowedInstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedInstanceTypes property is set.
        /// </summary>
        internal bool IsSetAllowedInstanceTypes() => this.AllowedInstanceTypes != null && (this.AllowedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CpuArchitectureType. 
        /// <para>
        /// The CPU architecture type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CpuArchitectureType CpuArchitectureType { get; set; }

        /// <summary>
        /// Checks to see if the CpuArchitectureType property is set.
        /// </summary>
        internal bool IsSetCpuArchitectureType() => this.CpuArchitectureType != null;

        /// <summary>
        /// Gets and sets the property CustomAmounts. 
        /// <para>
        /// The custom capability amounts to require for instances in this fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public List<FleetAmountCapability> CustomAmounts { get; set; } = AWSConfigs.InitializeCollections ? new List<FleetAmountCapability>() : null;

        /// <summary>
        /// Checks to see if the CustomAmounts property is set.
        /// </summary>
        internal bool IsSetCustomAmounts() => this.CustomAmounts != null && (this.CustomAmounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// The custom capability attributes to require for instances in this fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public List<FleetAttributeCapability> CustomAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<FleetAttributeCapability>() : null;

        /// <summary>
        /// Checks to see if the CustomAttributes property is set.
        /// </summary>
        internal bool IsSetCustomAttributes() => this.CustomAttributes != null && (this.CustomAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExcludedInstanceTypes. 
        /// <para>
        /// The instance types to exclude from the fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> ExcludedInstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedInstanceTypes property is set.
        /// </summary>
        internal bool IsSetExcludedInstanceTypes() => this.ExcludedInstanceTypes != null && (this.ExcludedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MemoryMiB. 
        /// <para>
        /// The memory, as MiB, for the Amazon EC2 instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryMiBRange MemoryMiB { get; set; }

        /// <summary>
        /// Checks to see if the MemoryMiB property is set.
        /// </summary>
        internal bool IsSetMemoryMiB() => this.MemoryMiB != null;

        /// <summary>
        /// Gets and sets the property OsFamily. 
        /// <para>
        /// The operating system (OS) family.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceManagedFleetOperatingSystemFamily OsFamily { get; set; }

        /// <summary>
        /// Checks to see if the OsFamily property is set.
        /// </summary>
        internal bool IsSetOsFamily() => this.OsFamily != null;

        /// <summary>
        /// Gets and sets the property RootEbsVolume. 
        /// <para>
        /// The root EBS volume.
        /// </para>
        /// </summary>
        public Ec2EbsVolume RootEbsVolume { get; set; }

        /// <summary>
        /// Checks to see if the RootEbsVolume property is set.
        /// </summary>
        internal bool IsSetRootEbsVolume() => this.RootEbsVolume != null;

        /// <summary>
        /// Gets and sets the property SoftwareAddOns. 
        /// <para>
        /// The software add-ons that the service installs on worker hosts when they launch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<FleetSoftwareAddOn> SoftwareAddOns { get; set; } = AWSConfigs.InitializeCollections ? new List<FleetSoftwareAddOn>() : null;

        /// <summary>
        /// Checks to see if the SoftwareAddOns property is set.
        /// </summary>
        internal bool IsSetSoftwareAddOns() => this.SoftwareAddOns != null && (this.SoftwareAddOns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VCpuCount. 
        /// <para>
        /// The amount of vCPU to require for instances in this fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VCpuCountRange VCpuCount { get; set; }

        /// <summary>
        /// Checks to see if the VCpuCount property is set.
        /// </summary>
        internal bool IsSetVCpuCount() => this.VCpuCount != null;
    }
}
