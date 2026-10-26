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
    /// The worker capabilities for a customer managed workflow.
    /// </summary>
    public partial class CustomerManagedWorkerCapabilities
    {
        /// <summary>
        /// Gets and sets the property AcceleratorCount. The range of the accelerator.
        /// </summary>
        public AcceleratorCountRange AcceleratorCount { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorCount property is set.
        /// </summary>
        internal bool IsSetAcceleratorCount() => this.AcceleratorCount != null;

        /// <summary>
        /// Gets and sets the property AcceleratorTotalMemoryMiB. The total memory (MiB) for the
        /// customer managed worker capabilities.
        /// </summary>
        public AcceleratorTotalMemoryMiBRange AcceleratorTotalMemoryMiB { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorTotalMemoryMiB property is set.
        /// </summary>
        internal bool IsSetAcceleratorTotalMemoryMiB() => this.AcceleratorTotalMemoryMiB != null;

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. The accelerator types for the customer
        /// managed worker capabilities.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AcceleratorTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AcceleratorTypes property is set.
        /// </summary>
        internal bool IsSetAcceleratorTypes() => this.AcceleratorTypes != null && (this.AcceleratorTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CpuArchitectureType. The CPU architecture type for the
        /// customer managed worker capabilities.
        /// </summary>
        [AWSProperty(Required = true)]
        public CpuArchitectureType CpuArchitectureType { get; set; }

        /// <summary>
        /// Checks to see if the CpuArchitectureType property is set.
        /// </summary>
        internal bool IsSetCpuArchitectureType() => this.CpuArchitectureType != null;

        /// <summary>
        /// Gets and sets the property CustomAmounts. Custom requirement ranges for customer managed
        /// worker capabilities.
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
        /// Gets and sets the property CustomAttributes. Custom attributes for the customer manged
        /// worker capabilities.
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
        /// Gets and sets the property MemoryMiB. The memory (MiB).
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryMiBRange MemoryMiB { get; set; }

        /// <summary>
        /// Checks to see if the MemoryMiB property is set.
        /// </summary>
        internal bool IsSetMemoryMiB() => this.MemoryMiB != null;

        /// <summary>
        /// Gets and sets the property OsFamily. The operating system (OS) family.
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomerManagedFleetOperatingSystemFamily OsFamily { get; set; }

        /// <summary>
        /// Checks to see if the OsFamily property is set.
        /// </summary>
        internal bool IsSetOsFamily() => this.OsFamily != null;

        /// <summary>
        /// Gets and sets the property VCpuCount. The vCPU count for the customer manged worker
        /// capabilities.
        /// </summary>
        [AWSProperty(Required = true)]
        public VCpuCountRange VCpuCount { get; set; }

        /// <summary>
        /// Checks to see if the VCpuCount property is set.
        /// </summary>
        internal bool IsSetVCpuCount() => this.VCpuCount != null;
    }
}
