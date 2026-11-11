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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the instance type.
    /// </summary>
    public partial class InstanceTypeInfo
    {
        /// <summary>
        /// Gets and sets the property AutoRecoverySupported. 
        /// <para>
        /// Indicates whether Amazon CloudWatch action based recovery is supported.
        /// </para>
        /// </summary>
        public bool? AutoRecoverySupported { get; set; }

        /// <summary>
        /// Checks to see if the AutoRecoverySupported property is set.
        /// </summary>
        internal bool IsSetAutoRecoverySupported() => this.AutoRecoverySupported.HasValue;

        /// <summary>
        /// Gets and sets the property BareMetal. 
        /// <para>
        /// Indicates whether the instance is a bare metal instance type.
        /// </para>
        /// </summary>
        public bool? BareMetal { get; set; }

        /// <summary>
        /// Checks to see if the BareMetal property is set.
        /// </summary>
        internal bool IsSetBareMetal() => this.BareMetal.HasValue;

        /// <summary>
        /// Gets and sets the property BurstablePerformanceSupported. 
        /// <para>
        /// Indicates whether the instance type is a burstable performance T instance type. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a>.
        /// </para>
        /// </summary>
        public bool? BurstablePerformanceSupported { get; set; }

        /// <summary>
        /// Checks to see if the BurstablePerformanceSupported property is set.
        /// </summary>
        internal bool IsSetBurstablePerformanceSupported() => this.BurstablePerformanceSupported.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentGeneration. 
        /// <para>
        /// Indicates whether the instance type is current generation.
        /// </para>
        /// </summary>
        public bool? CurrentGeneration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentGeneration property is set.
        /// </summary>
        internal bool IsSetCurrentGeneration() => this.CurrentGeneration.HasValue;

        /// <summary>
        /// Gets and sets the property DedicatedHostsSupported. 
        /// <para>
        /// Indicates whether Dedicated Hosts are supported on the instance type.
        /// </para>
        /// </summary>
        public bool? DedicatedHostsSupported { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedHostsSupported property is set.
        /// </summary>
        internal bool IsSetDedicatedHostsSupported() => this.DedicatedHostsSupported.HasValue;

        /// <summary>
        /// Gets and sets the property EbsInfo. 
        /// <para>
        /// Describes the Amazon EBS settings for the instance type.
        /// </para>
        /// </summary>
        public EbsInfo EbsInfo { get; set; }

        /// <summary>
        /// Checks to see if the EbsInfo property is set.
        /// </summary>
        internal bool IsSetEbsInfo() => this.EbsInfo != null;

        /// <summary>
        /// Gets and sets the property FpgaInfo. 
        /// <para>
        /// Describes the FPGA accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public FpgaInfo FpgaInfo { get; set; }

        /// <summary>
        /// Checks to see if the FpgaInfo property is set.
        /// </summary>
        internal bool IsSetFpgaInfo() => this.FpgaInfo != null;

        /// <summary>
        /// Gets and sets the property FreeTierEligible. 
        /// <para>
        /// Indicates whether the instance type is eligible for the free tier.
        /// </para>
        /// </summary>
        public bool? FreeTierEligible { get; set; }

        /// <summary>
        /// Checks to see if the FreeTierEligible property is set.
        /// </summary>
        internal bool IsSetFreeTierEligible() => this.FreeTierEligible.HasValue;

        /// <summary>
        /// Gets and sets the property GpuInfo. 
        /// <para>
        /// Describes the GPU accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public GpuInfo GpuInfo { get; set; }

        /// <summary>
        /// Checks to see if the GpuInfo property is set.
        /// </summary>
        internal bool IsSetGpuInfo() => this.GpuInfo != null;

        /// <summary>
        /// Gets and sets the property HibernationSupported. 
        /// <para>
        /// Indicates whether On-Demand hibernation is supported.
        /// </para>
        /// </summary>
        public bool? HibernationSupported { get; set; }

        /// <summary>
        /// Checks to see if the HibernationSupported property is set.
        /// </summary>
        internal bool IsSetHibernationSupported() => this.HibernationSupported.HasValue;

        /// <summary>
        /// Gets and sets the property Hypervisor. 
        /// <para>
        /// The hypervisor for the instance type.
        /// </para>
        /// </summary>
        public InstanceTypeHypervisor Hypervisor { get; set; }

        /// <summary>
        /// Checks to see if the Hypervisor property is set.
        /// </summary>
        internal bool IsSetHypervisor() => this.Hypervisor != null;

        /// <summary>
        /// Gets and sets the property InferenceAcceleratorInfo. 
        /// <para>
        /// Describes the Inference accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public InferenceAcceleratorInfo InferenceAcceleratorInfo { get; set; }

        /// <summary>
        /// Checks to see if the InferenceAcceleratorInfo property is set.
        /// </summary>
        internal bool IsSetInferenceAcceleratorInfo() => this.InferenceAcceleratorInfo != null;

        /// <summary>
        /// Gets and sets the property InstanceStorageInfo. 
        /// <para>
        /// Describes the instance storage for the instance type.
        /// </para>
        /// </summary>
        public InstanceStorageInfo InstanceStorageInfo { get; set; }

        /// <summary>
        /// Checks to see if the InstanceStorageInfo property is set.
        /// </summary>
        internal bool IsSetInstanceStorageInfo() => this.InstanceStorageInfo != null;

        /// <summary>
        /// Gets and sets the property InstanceStorageSupported. 
        /// <para>
        /// Indicates whether instance storage is supported.
        /// </para>
        /// </summary>
        public bool? InstanceStorageSupported { get; set; }

        /// <summary>
        /// Checks to see if the InstanceStorageSupported property is set.
        /// </summary>
        internal bool IsSetInstanceStorageSupported() => this.InstanceStorageSupported.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MediaAcceleratorInfo. 
        /// <para>
        /// Describes the media accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public MediaAcceleratorInfo MediaAcceleratorInfo { get; set; }

        /// <summary>
        /// Checks to see if the MediaAcceleratorInfo property is set.
        /// </summary>
        internal bool IsSetMediaAcceleratorInfo() => this.MediaAcceleratorInfo != null;

        /// <summary>
        /// Gets and sets the property MemoryInfo. 
        /// <para>
        /// Describes the memory for the instance type.
        /// </para>
        /// </summary>
        public MemoryInfo MemoryInfo { get; set; }

        /// <summary>
        /// Checks to see if the MemoryInfo property is set.
        /// </summary>
        internal bool IsSetMemoryInfo() => this.MemoryInfo != null;

        /// <summary>
        /// Gets and sets the property NetworkInfo. 
        /// <para>
        /// Describes the network settings for the instance type.
        /// </para>
        /// </summary>
        public NetworkInfo NetworkInfo { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInfo property is set.
        /// </summary>
        internal bool IsSetNetworkInfo() => this.NetworkInfo != null;

        /// <summary>
        /// Gets and sets the property NeuronInfo. 
        /// <para>
        /// Describes the Neuron accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public NeuronInfo NeuronInfo { get; set; }

        /// <summary>
        /// Checks to see if the NeuronInfo property is set.
        /// </summary>
        internal bool IsSetNeuronInfo() => this.NeuronInfo != null;

        /// <summary>
        /// Gets and sets the property NitroEnclavesSupport. 
        /// <para>
        /// Indicates whether Nitro Enclaves is supported.
        /// </para>
        /// </summary>
        public NitroEnclavesSupport NitroEnclavesSupport { get; set; }

        /// <summary>
        /// Checks to see if the NitroEnclavesSupport property is set.
        /// </summary>
        internal bool IsSetNitroEnclavesSupport() => this.NitroEnclavesSupport != null;

        /// <summary>
        /// Gets and sets the property NitroTpmInfo. 
        /// <para>
        /// Describes the supported NitroTPM versions for the instance type.
        /// </para>
        /// </summary>
        public NitroTpmInfo NitroTpmInfo { get; set; }

        /// <summary>
        /// Checks to see if the NitroTpmInfo property is set.
        /// </summary>
        internal bool IsSetNitroTpmInfo() => this.NitroTpmInfo != null;

        /// <summary>
        /// Gets and sets the property NitroTpmSupport. 
        /// <para>
        /// Indicates whether NitroTPM is supported.
        /// </para>
        /// </summary>
        public NitroTpmSupport NitroTpmSupport { get; set; }

        /// <summary>
        /// Checks to see if the NitroTpmSupport property is set.
        /// </summary>
        internal bool IsSetNitroTpmSupport() => this.NitroTpmSupport != null;

        /// <summary>
        /// Gets and sets the property PhcSupport. 
        /// <para>
        /// Indicates whether a local Precision Time Protocol (PTP) hardware clock (PHC) is supported.
        /// </para>
        /// </summary>
        public PhcSupport PhcSupport { get; set; }

        /// <summary>
        /// Checks to see if the PhcSupport property is set.
        /// </summary>
        internal bool IsSetPhcSupport() => this.PhcSupport != null;

        /// <summary>
        /// Gets and sets the property PlacementGroupInfo. 
        /// <para>
        /// Describes the placement group settings for the instance type.
        /// </para>
        /// </summary>
        public PlacementGroupInfo PlacementGroupInfo { get; set; }

        /// <summary>
        /// Checks to see if the PlacementGroupInfo property is set.
        /// </summary>
        internal bool IsSetPlacementGroupInfo() => this.PlacementGroupInfo != null;

        /// <summary>
        /// Gets and sets the property ProcessorInfo. 
        /// <para>
        /// Describes the processor.
        /// </para>
        /// </summary>
        public ProcessorInfo ProcessorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ProcessorInfo property is set.
        /// </summary>
        internal bool IsSetProcessorInfo() => this.ProcessorInfo != null;

        /// <summary>
        /// Gets and sets the property RebootMigrationSupport. 
        /// <para>
        /// Indicates whether reboot migration during a user-initiated reboot is supported for
        /// instances that have a scheduled <c>system-reboot</c> event. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/schedevents_actions_reboot.html#reboot-migration">Enable
        /// or disable reboot migration</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public RebootMigrationSupport RebootMigrationSupport { get; set; }

        /// <summary>
        /// Checks to see if the RebootMigrationSupport property is set.
        /// </summary>
        internal bool IsSetRebootMigrationSupport() => this.RebootMigrationSupport != null;

        /// <summary>
        /// Gets and sets the property SupportedBootModes. 
        /// <para>
        /// The supported boot modes. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Boot
        /// modes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedBootModes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedBootModes property is set.
        /// </summary>
        internal bool IsSetSupportedBootModes() => this.SupportedBootModes != null && (this.SupportedBootModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedInRegion. 
        /// <para>
        /// Indicates whether the instance type is supported in the current Region.
        /// </para>
        /// </summary>
        public bool? SupportedInRegion { get; set; }

        /// <summary>
        /// Checks to see if the SupportedInRegion property is set.
        /// </summary>
        internal bool IsSetSupportedInRegion() => this.SupportedInRegion.HasValue;

        /// <summary>
        /// Gets and sets the property SupportedRootDeviceTypes. 
        /// <para>
        /// The supported root device types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedRootDeviceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedRootDeviceTypes property is set.
        /// </summary>
        internal bool IsSetSupportedRootDeviceTypes() => this.SupportedRootDeviceTypes != null && (this.SupportedRootDeviceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedUsageClasses. 
        /// <para>
        /// Indicates whether the instance type is offered for spot, On-Demand, or Capacity Blocks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedUsageClasses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedUsageClasses property is set.
        /// </summary>
        internal bool IsSetSupportedUsageClasses() => this.SupportedUsageClasses != null && (this.SupportedUsageClasses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedVirtualizationTypes. 
        /// <para>
        /// The supported virtualization types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedVirtualizationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedVirtualizationTypes property is set.
        /// </summary>
        internal bool IsSetSupportedVirtualizationTypes() => this.SupportedVirtualizationTypes != null && (this.SupportedVirtualizationTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VCpuInfo. 
        /// <para>
        /// Describes the vCPU configurations for the instance type.
        /// </para>
        /// </summary>
        public VCpuInfo VCpuInfo { get; set; }

        /// <summary>
        /// Checks to see if the VCpuInfo property is set.
        /// </summary>
        internal bool IsSetVCpuInfo() => this.VCpuInfo != null;
    }
}
