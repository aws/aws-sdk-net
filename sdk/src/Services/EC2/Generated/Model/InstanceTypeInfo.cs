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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private bool? _autoRecoverySupported;
        private bool? _bareMetal;
        private bool? _burstablePerformanceSupported;
        private bool? _currentGeneration;
        private bool? _dedicatedHostsSupported;
        private EbsInfo _ebsInfo;
        private FpgaInfo _fpgaInfo;
        private bool? _freeTierEligible;
        private GpuInfo _gpuInfo;
        private bool? _hibernationSupported;
        private InstanceTypeHypervisor _hypervisor;
        private InferenceAcceleratorInfo _inferenceAcceleratorInfo;
        private InstanceStorageInfo _instanceStorageInfo;
        private bool? _instanceStorageSupported;
        private InstanceType _instanceType;
        private MediaAcceleratorInfo _mediaAcceleratorInfo;
        private MemoryInfo _memoryInfo;
        private NetworkInfo _networkInfo;
        private NeuronInfo _neuronInfo;
        private NitroEnclavesSupport _nitroEnclavesSupport;
        private NitroTpmInfo _nitroTpmInfo;
        private NitroTpmSupport _nitroTpmSupport;
        private PhcSupport _phcSupport;
        private PlacementGroupInfo _placementGroupInfo;
        private ProcessorInfo _processorInfo;
        private RebootMigrationSupport _rebootMigrationSupport;
        private List<string> _supportedBootModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedRootDeviceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedUsageClasses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedVirtualizationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VCpuInfo _vCpuInfo;

        /// <summary>
        /// Gets and sets the property AutoRecoverySupported. 
        /// <para>
        /// Indicates whether Amazon CloudWatch action based recovery is supported.
        /// </para>
        /// </summary>
        public bool? AutoRecoverySupported
        {
            get { return this._autoRecoverySupported; }
            set { this._autoRecoverySupported = value; }
        }

        // Check to see if AutoRecoverySupported property is set
        internal bool IsSetAutoRecoverySupported()
        {
            return this._autoRecoverySupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BareMetal. 
        /// <para>
        /// Indicates whether the instance is a bare metal instance type.
        /// </para>
        /// </summary>
        public bool? BareMetal
        {
            get { return this._bareMetal; }
            set { this._bareMetal = value; }
        }

        // Check to see if BareMetal property is set
        internal bool IsSetBareMetal()
        {
            return this._bareMetal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BurstablePerformanceSupported. 
        /// <para>
        /// Indicates whether the instance type is a burstable performance T instance type. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a>.
        /// </para>
        /// </summary>
        public bool? BurstablePerformanceSupported
        {
            get { return this._burstablePerformanceSupported; }
            set { this._burstablePerformanceSupported = value; }
        }

        // Check to see if BurstablePerformanceSupported property is set
        internal bool IsSetBurstablePerformanceSupported()
        {
            return this._burstablePerformanceSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentGeneration. 
        /// <para>
        /// Indicates whether the instance type is current generation.
        /// </para>
        /// </summary>
        public bool? CurrentGeneration
        {
            get { return this._currentGeneration; }
            set { this._currentGeneration = value; }
        }

        // Check to see if CurrentGeneration property is set
        internal bool IsSetCurrentGeneration()
        {
            return this._currentGeneration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DedicatedHostsSupported. 
        /// <para>
        /// Indicates whether Dedicated Hosts are supported on the instance type.
        /// </para>
        /// </summary>
        public bool? DedicatedHostsSupported
        {
            get { return this._dedicatedHostsSupported; }
            set { this._dedicatedHostsSupported = value; }
        }

        // Check to see if DedicatedHostsSupported property is set
        internal bool IsSetDedicatedHostsSupported()
        {
            return this._dedicatedHostsSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsInfo. 
        /// <para>
        /// Describes the Amazon EBS settings for the instance type.
        /// </para>
        /// </summary>
        public EbsInfo EbsInfo
        {
            get { return this._ebsInfo; }
            set { this._ebsInfo = value; }
        }

        // Check to see if EbsInfo property is set
        internal bool IsSetEbsInfo()
        {
            return this._ebsInfo != null;
        }

        /// <summary>
        /// Gets and sets the property FpgaInfo. 
        /// <para>
        /// Describes the FPGA accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public FpgaInfo FpgaInfo
        {
            get { return this._fpgaInfo; }
            set { this._fpgaInfo = value; }
        }

        // Check to see if FpgaInfo property is set
        internal bool IsSetFpgaInfo()
        {
            return this._fpgaInfo != null;
        }

        /// <summary>
        /// Gets and sets the property FreeTierEligible. 
        /// <para>
        /// Indicates whether the instance type is eligible for the free tier.
        /// </para>
        /// </summary>
        public bool? FreeTierEligible
        {
            get { return this._freeTierEligible; }
            set { this._freeTierEligible = value; }
        }

        // Check to see if FreeTierEligible property is set
        internal bool IsSetFreeTierEligible()
        {
            return this._freeTierEligible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GpuInfo. 
        /// <para>
        /// Describes the GPU accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public GpuInfo GpuInfo
        {
            get { return this._gpuInfo; }
            set { this._gpuInfo = value; }
        }

        // Check to see if GpuInfo property is set
        internal bool IsSetGpuInfo()
        {
            return this._gpuInfo != null;
        }

        /// <summary>
        /// Gets and sets the property HibernationSupported. 
        /// <para>
        /// Indicates whether On-Demand hibernation is supported.
        /// </para>
        /// </summary>
        public bool? HibernationSupported
        {
            get { return this._hibernationSupported; }
            set { this._hibernationSupported = value; }
        }

        // Check to see if HibernationSupported property is set
        internal bool IsSetHibernationSupported()
        {
            return this._hibernationSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hypervisor. 
        /// <para>
        /// The hypervisor for the instance type.
        /// </para>
        /// </summary>
        public InstanceTypeHypervisor Hypervisor
        {
            get { return this._hypervisor; }
            set { this._hypervisor = value; }
        }

        // Check to see if Hypervisor property is set
        internal bool IsSetHypervisor()
        {
            return this._hypervisor != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceAcceleratorInfo. 
        /// <para>
        /// Describes the Inference accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public InferenceAcceleratorInfo InferenceAcceleratorInfo
        {
            get { return this._inferenceAcceleratorInfo; }
            set { this._inferenceAcceleratorInfo = value; }
        }

        // Check to see if InferenceAcceleratorInfo property is set
        internal bool IsSetInferenceAcceleratorInfo()
        {
            return this._inferenceAcceleratorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceStorageInfo. 
        /// <para>
        /// Describes the instance storage for the instance type.
        /// </para>
        /// </summary>
        public InstanceStorageInfo InstanceStorageInfo
        {
            get { return this._instanceStorageInfo; }
            set { this._instanceStorageInfo = value; }
        }

        // Check to see if InstanceStorageInfo property is set
        internal bool IsSetInstanceStorageInfo()
        {
            return this._instanceStorageInfo != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceStorageSupported. 
        /// <para>
        /// Indicates whether instance storage is supported.
        /// </para>
        /// </summary>
        public bool? InstanceStorageSupported
        {
            get { return this._instanceStorageSupported; }
            set { this._instanceStorageSupported = value; }
        }

        // Check to see if InstanceStorageSupported property is set
        internal bool IsSetInstanceStorageSupported()
        {
            return this._instanceStorageSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceType InstanceType
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
        /// Gets and sets the property MediaAcceleratorInfo. 
        /// <para>
        /// Describes the media accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public MediaAcceleratorInfo MediaAcceleratorInfo
        {
            get { return this._mediaAcceleratorInfo; }
            set { this._mediaAcceleratorInfo = value; }
        }

        // Check to see if MediaAcceleratorInfo property is set
        internal bool IsSetMediaAcceleratorInfo()
        {
            return this._mediaAcceleratorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryInfo. 
        /// <para>
        /// Describes the memory for the instance type.
        /// </para>
        /// </summary>
        public MemoryInfo MemoryInfo
        {
            get { return this._memoryInfo; }
            set { this._memoryInfo = value; }
        }

        // Check to see if MemoryInfo property is set
        internal bool IsSetMemoryInfo()
        {
            return this._memoryInfo != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInfo. 
        /// <para>
        /// Describes the network settings for the instance type.
        /// </para>
        /// </summary>
        public NetworkInfo NetworkInfo
        {
            get { return this._networkInfo; }
            set { this._networkInfo = value; }
        }

        // Check to see if NetworkInfo property is set
        internal bool IsSetNetworkInfo()
        {
            return this._networkInfo != null;
        }

        /// <summary>
        /// Gets and sets the property NeuronInfo. 
        /// <para>
        /// Describes the Neuron accelerator settings for the instance type.
        /// </para>
        /// </summary>
        public NeuronInfo NeuronInfo
        {
            get { return this._neuronInfo; }
            set { this._neuronInfo = value; }
        }

        // Check to see if NeuronInfo property is set
        internal bool IsSetNeuronInfo()
        {
            return this._neuronInfo != null;
        }

        /// <summary>
        /// Gets and sets the property NitroEnclavesSupport. 
        /// <para>
        /// Indicates whether Nitro Enclaves is supported.
        /// </para>
        /// </summary>
        public NitroEnclavesSupport NitroEnclavesSupport
        {
            get { return this._nitroEnclavesSupport; }
            set { this._nitroEnclavesSupport = value; }
        }

        // Check to see if NitroEnclavesSupport property is set
        internal bool IsSetNitroEnclavesSupport()
        {
            return this._nitroEnclavesSupport != null;
        }

        /// <summary>
        /// Gets and sets the property NitroTpmInfo. 
        /// <para>
        /// Describes the supported NitroTPM versions for the instance type.
        /// </para>
        /// </summary>
        public NitroTpmInfo NitroTpmInfo
        {
            get { return this._nitroTpmInfo; }
            set { this._nitroTpmInfo = value; }
        }

        // Check to see if NitroTpmInfo property is set
        internal bool IsSetNitroTpmInfo()
        {
            return this._nitroTpmInfo != null;
        }

        /// <summary>
        /// Gets and sets the property NitroTpmSupport. 
        /// <para>
        /// Indicates whether NitroTPM is supported.
        /// </para>
        /// </summary>
        public NitroTpmSupport NitroTpmSupport
        {
            get { return this._nitroTpmSupport; }
            set { this._nitroTpmSupport = value; }
        }

        // Check to see if NitroTpmSupport property is set
        internal bool IsSetNitroTpmSupport()
        {
            return this._nitroTpmSupport != null;
        }

        /// <summary>
        /// Gets and sets the property PhcSupport. 
        /// <para>
        /// Indicates whether a local Precision Time Protocol (PTP) hardware clock (PHC) is supported.
        /// </para>
        /// </summary>
        public PhcSupport PhcSupport
        {
            get { return this._phcSupport; }
            set { this._phcSupport = value; }
        }

        // Check to see if PhcSupport property is set
        internal bool IsSetPhcSupport()
        {
            return this._phcSupport != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementGroupInfo. 
        /// <para>
        /// Describes the placement group settings for the instance type.
        /// </para>
        /// </summary>
        public PlacementGroupInfo PlacementGroupInfo
        {
            get { return this._placementGroupInfo; }
            set { this._placementGroupInfo = value; }
        }

        // Check to see if PlacementGroupInfo property is set
        internal bool IsSetPlacementGroupInfo()
        {
            return this._placementGroupInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessorInfo. 
        /// <para>
        /// Describes the processor.
        /// </para>
        /// </summary>
        public ProcessorInfo ProcessorInfo
        {
            get { return this._processorInfo; }
            set { this._processorInfo = value; }
        }

        // Check to see if ProcessorInfo property is set
        internal bool IsSetProcessorInfo()
        {
            return this._processorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RebootMigrationSupport. 
        /// <para>
        /// Indicates whether reboot migration during a user-initiated reboot is supported for
        /// instances that have a scheduled <c>system-reboot</c> event. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/schedevents_actions_reboot.html#reboot-migration">Enable
        /// or disable reboot migration</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public RebootMigrationSupport RebootMigrationSupport
        {
            get { return this._rebootMigrationSupport; }
            set { this._rebootMigrationSupport = value; }
        }

        // Check to see if RebootMigrationSupport property is set
        internal bool IsSetRebootMigrationSupport()
        {
            return this._rebootMigrationSupport != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedBootModes. 
        /// <para>
        /// The supported boot modes. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Boot
        /// modes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedBootModes
        {
            get { return this._supportedBootModes; }
            set { this._supportedBootModes = value; }
        }

        // Check to see if SupportedBootModes property is set
        internal bool IsSetSupportedBootModes()
        {
            return this._supportedBootModes != null && (this._supportedBootModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedRootDeviceTypes. 
        /// <para>
        /// The supported root device types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedRootDeviceTypes
        {
            get { return this._supportedRootDeviceTypes; }
            set { this._supportedRootDeviceTypes = value; }
        }

        // Check to see if SupportedRootDeviceTypes property is set
        internal bool IsSetSupportedRootDeviceTypes()
        {
            return this._supportedRootDeviceTypes != null && (this._supportedRootDeviceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedUsageClasses. 
        /// <para>
        /// Indicates whether the instance type is offered for spot, On-Demand, or Capacity Blocks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedUsageClasses
        {
            get { return this._supportedUsageClasses; }
            set { this._supportedUsageClasses = value; }
        }

        // Check to see if SupportedUsageClasses property is set
        internal bool IsSetSupportedUsageClasses()
        {
            return this._supportedUsageClasses != null && (this._supportedUsageClasses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedVirtualizationTypes. 
        /// <para>
        /// The supported virtualization types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedVirtualizationTypes
        {
            get { return this._supportedVirtualizationTypes; }
            set { this._supportedVirtualizationTypes = value; }
        }

        // Check to see if SupportedVirtualizationTypes property is set
        internal bool IsSetSupportedVirtualizationTypes()
        {
            return this._supportedVirtualizationTypes != null && (this._supportedVirtualizationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VCpuInfo. 
        /// <para>
        /// Describes the vCPU configurations for the instance type.
        /// </para>
        /// </summary>
        public VCpuInfo VCpuInfo
        {
            get { return this._vCpuInfo; }
            set { this._vCpuInfo = value; }
        }

        // Check to see if VCpuInfo property is set
        internal bool IsSetVCpuInfo()
        {
            return this._vCpuInfo != null;
        }

    }
}