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
        private MemoryInfo _memoryInfo;
        private NetworkInfo _networkInfo;
        private PlacementGroupInfo _placementGroupInfo;
        private ProcessorInfo _processorInfo;
        private List<string> _supportedRootDeviceTypes = new List<string>();
        private List<string> _supportedUsageClasses = new List<string>();
        private List<string> _supportedVirtualizationTypes = new List<string>();
        private VCpuInfo _vCpuInfo;

        /// <summary>
        /// Gets and sets the property AutoRecoverySupported. 
        /// <para>
        /// Indicates whether auto recovery is supported.
        /// </para>
        /// </summary>
        public bool AutoRecoverySupported
        {
            get { return this._autoRecoverySupported.GetValueOrDefault(); }
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
        public bool BareMetal
        {
            get { return this._bareMetal.GetValueOrDefault(); }
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
        /// Indicates whether the instance type is a burstable performance instance type.
        /// </para>
        /// </summary>
        public bool BurstablePerformanceSupported
        {
            get { return this._burstablePerformanceSupported.GetValueOrDefault(); }
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
        public bool CurrentGeneration
        {
            get { return this._currentGeneration.GetValueOrDefault(); }
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
        public bool DedicatedHostsSupported
        {
            get { return this._dedicatedHostsSupported.GetValueOrDefault(); }
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
        public bool FreeTierEligible
        {
            get { return this._freeTierEligible.GetValueOrDefault(); }
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
        public bool HibernationSupported
        {
            get { return this._hibernationSupported.GetValueOrDefault(); }
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
        public bool InstanceStorageSupported
        {
            get { return this._instanceStorageSupported.GetValueOrDefault(); }
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
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// Gets and sets the property SupportedRootDeviceTypes. 
        /// <para>
        /// The supported root device types.
        /// </para>
        /// </summary>
        public List<string> SupportedRootDeviceTypes
        {
            get { return this._supportedRootDeviceTypes; }
            set { this._supportedRootDeviceTypes = value; }
        }

        // Check to see if SupportedRootDeviceTypes property is set
        internal bool IsSetSupportedRootDeviceTypes()
        {
            return this._supportedRootDeviceTypes != null && this._supportedRootDeviceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedUsageClasses. 
        /// <para>
        /// Indicates whether the instance type is offered for spot or On-Demand.
        /// </para>
        /// </summary>
        public List<string> SupportedUsageClasses
        {
            get { return this._supportedUsageClasses; }
            set { this._supportedUsageClasses = value; }
        }

        // Check to see if SupportedUsageClasses property is set
        internal bool IsSetSupportedUsageClasses()
        {
            return this._supportedUsageClasses != null && this._supportedUsageClasses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedVirtualizationTypes. 
        /// <para>
        /// The supported virtualization types.
        /// </para>
        /// </summary>
        public List<string> SupportedVirtualizationTypes
        {
            get { return this._supportedVirtualizationTypes; }
            set { this._supportedVirtualizationTypes = value; }
        }

        // Check to see if SupportedVirtualizationTypes property is set
        internal bool IsSetSupportedVirtualizationTypes()
        {
            return this._supportedVirtualizationTypes != null && this._supportedVirtualizationTypes.Count > 0; 
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