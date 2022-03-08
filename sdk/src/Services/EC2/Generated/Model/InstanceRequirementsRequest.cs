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
    /// The attributes for the instance types. When you specify instance attributes, Amazon
    /// EC2 will identify instance types with these attributes.
    /// 
    ///  
    /// <para>
    /// When you specify multiple parameters, you get instance types that satisfy all of the
    /// specified parameters. If you specify multiple values for a parameter, you get instance
    /// types that satisfy any of the specified values.
    /// </para>
    ///  <note> 
    /// <para>
    /// You must specify <code>VCpuCount</code> and <code>MemoryMiB</code>. All other parameters
    /// are optional. Any unspecified optional parameter is set to its default.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-attribute-based-instance-type-selection.html">Attribute-based
    /// instance type selection for EC2 Fleet</a>, <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-attribute-based-instance-type-selection.html">Attribute-based
    /// instance type selection for Spot Fleet</a>, and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html">Spot
    /// placement score</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class InstanceRequirementsRequest
    {
        private AcceleratorCountRequest _acceleratorCount;
        private List<string> _acceleratorManufacturers = new List<string>();
        private List<string> _acceleratorNames = new List<string>();
        private AcceleratorTotalMemoryMiBRequest _acceleratorTotalMemoryMiB;
        private List<string> _acceleratorTypes = new List<string>();
        private BareMetal _bareMetal;
        private BaselineEbsBandwidthMbpsRequest _baselineEbsBandwidthMbps;
        private BurstablePerformance _burstablePerformance;
        private List<string> _cpuManufacturers = new List<string>();
        private List<string> _excludedInstanceTypes = new List<string>();
        private List<string> _instanceGenerations = new List<string>();
        private LocalStorage _localStorage;
        private List<string> _localStorageTypes = new List<string>();
        private MemoryGiBPerVCpuRequest _memoryGiBPerVCpu;
        private MemoryMiBRequest _memoryMiB;
        private NetworkInterfaceCountRequest _networkInterfaceCount;
        private int? _onDemandMaxPricePercentageOverLowestPrice;
        private bool? _requireHibernateSupport;
        private int? _spotMaxPricePercentageOverLowestPrice;
        private TotalLocalStorageGBRequest _totalLocalStorageGB;
        private VCpuCountRangeRequest _vCpuCount;

        /// <summary>
        /// Gets and sets the property AcceleratorCount. 
        /// <para>
        /// The minimum and maximum number of accelerators (GPUs, FPGAs, or Amazon Web Services
        /// Inferentia chips) on an instance.
        /// </para>
        ///  
        /// <para>
        /// To exclude accelerator-enabled instance types, set <code>Max</code> to <code>0</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public AcceleratorCountRequest AcceleratorCount
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
        /// Gets and sets the property AcceleratorManufacturers. 
        /// <para>
        /// Indicates whether instance types must have accelerators by specific manufacturers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For instance types with NVIDIA devices, specify <code>nvidia</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with AMD devices, specify <code>amd</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Amazon Web Services devices, specify <code>amazon-web-services</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Xilinx devices, specify <code>xilinx</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Any manufacturer
        /// </para>
        /// </summary>
        public List<string> AcceleratorManufacturers
        {
            get { return this._acceleratorManufacturers; }
            set { this._acceleratorManufacturers = value; }
        }

        // Check to see if AcceleratorManufacturers property is set
        internal bool IsSetAcceleratorManufacturers()
        {
            return this._acceleratorManufacturers != null && this._acceleratorManufacturers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AcceleratorNames. 
        /// <para>
        /// The accelerators that must be on the instance type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For instance types with NVIDIA A100 GPUs, specify <code>a100</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA V100 GPUs, specify <code>v100</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA K80 GPUs, specify <code>k80</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA T4 GPUs, specify <code>t4</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA M60 GPUs, specify <code>m60</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with AMD Radeon Pro V520 GPUs, specify <code>radeon-pro-v520</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Xilinx VU9P FPGAs, specify <code> vu9p</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Any accelerator
        /// </para>
        /// </summary>
        public List<string> AcceleratorNames
        {
            get { return this._acceleratorNames; }
            set { this._acceleratorNames = value; }
        }

        // Check to see if AcceleratorNames property is set
        internal bool IsSetAcceleratorNames()
        {
            return this._acceleratorNames != null && this._acceleratorNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AcceleratorTotalMemoryMiB. 
        /// <para>
        /// The minimum and maximum amount of total accelerator memory, in MiB.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public AcceleratorTotalMemoryMiBRequest AcceleratorTotalMemoryMiB
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
        /// The accelerator types that must be on the instance type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To include instance types with GPU hardware, specify <code>gpu</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To include instance types with FPGA hardware, specify <code>fpga</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To include instance types with inference hardware, specify <code>inference</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Any accelerator type
        /// </para>
        /// </summary>
        public List<string> AcceleratorTypes
        {
            get { return this._acceleratorTypes; }
            set { this._acceleratorTypes = value; }
        }

        // Check to see if AcceleratorTypes property is set
        internal bool IsSetAcceleratorTypes()
        {
            return this._acceleratorTypes != null && this._acceleratorTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BareMetal. 
        /// <para>
        /// Indicates whether bare metal instance types must be included, excluded, or required.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To include bare metal instance types, specify <code>included</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To require only bare metal instance types, specify <code>required</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To exclude bare metal instance types, specify <code>excluded</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>excluded</code> 
        /// </para>
        /// </summary>
        public BareMetal BareMetal
        {
            get { return this._bareMetal; }
            set { this._bareMetal = value; }
        }

        // Check to see if BareMetal property is set
        internal bool IsSetBareMetal()
        {
            return this._bareMetal != null;
        }

        /// <summary>
        /// Gets and sets the property BaselineEbsBandwidthMbps. 
        /// <para>
        /// The minimum and maximum baseline bandwidth to Amazon EBS, in Mbps. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-optimized.html">Amazon
        /// EBS–optimized instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public BaselineEbsBandwidthMbpsRequest BaselineEbsBandwidthMbps
        {
            get { return this._baselineEbsBandwidthMbps; }
            set { this._baselineEbsBandwidthMbps = value; }
        }

        // Check to see if BaselineEbsBandwidthMbps property is set
        internal bool IsSetBaselineEbsBandwidthMbps()
        {
            return this._baselineEbsBandwidthMbps != null;
        }

        /// <summary>
        /// Gets and sets the property BurstablePerformance. 
        /// <para>
        /// Indicates whether burstable performance T instance types are included, excluded, or
        /// required. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To include burstable performance instance types, specify <code>included</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To require only burstable performance instance types, specify <code>required</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To exclude burstable performance instance types, specify <code>excluded</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>excluded</code> 
        /// </para>
        /// </summary>
        public BurstablePerformance BurstablePerformance
        {
            get { return this._burstablePerformance; }
            set { this._burstablePerformance = value; }
        }

        // Check to see if BurstablePerformance property is set
        internal bool IsSetBurstablePerformance()
        {
            return this._burstablePerformance != null;
        }

        /// <summary>
        /// Gets and sets the property CpuManufacturers. 
        /// <para>
        /// The CPU manufacturers to include.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For instance types with Intel CPUs, specify <code>intel</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with AMD CPUs, specify <code>amd</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Amazon Web Services CPUs, specify <code>amazon-web-services</code>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Don't confuse the CPU manufacturer with the CPU architecture. Instances will be launched
        /// with a compatible CPU architecture based on the Amazon Machine Image (AMI) that you
        /// specify in your launch template.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: Any manufacturer
        /// </para>
        /// </summary>
        public List<string> CpuManufacturers
        {
            get { return this._cpuManufacturers; }
            set { this._cpuManufacturers = value; }
        }

        // Check to see if CpuManufacturers property is set
        internal bool IsSetCpuManufacturers()
        {
            return this._cpuManufacturers != null && this._cpuManufacturers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExcludedInstanceTypes. 
        /// <para>
        /// The instance types to exclude. You can use strings with one or more wild cards, represented
        /// by an asterisk (<code>*</code>), to exclude an instance family, type, size, or generation.
        /// The following are examples: <code>m5.8xlarge</code>, <code>c5*.*</code>, <code>m5a.*</code>,
        /// <code>r*</code>, <code>*3*</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <code>c5*</code>,Amazon EC2 will exclude the entire C5
        /// instance family, which includes all C5a and C5n instance types. If you specify <code>m5a.*</code>,
        /// Amazon EC2 will exclude all the M5a instance types, but not the M5n instance types.
        /// </para>
        ///  
        /// <para>
        /// Default: No excluded instance types
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=400)]
        public List<string> ExcludedInstanceTypes
        {
            get { return this._excludedInstanceTypes; }
            set { this._excludedInstanceTypes = value; }
        }

        // Check to see if ExcludedInstanceTypes property is set
        internal bool IsSetExcludedInstanceTypes()
        {
            return this._excludedInstanceTypes != null && this._excludedInstanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGenerations. 
        /// <para>
        /// Indicates whether current or previous generation instance types are included. The
        /// current generation instance types are recommended for use. Current generation instance
        /// types are typically the latest two to three generations in each instance family. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For current generation instance types, specify <code>current</code>.
        /// </para>
        ///  
        /// <para>
        /// For previous generation instance types, specify <code>previous</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: Current and previous generation instance types
        /// </para>
        /// </summary>
        public List<string> InstanceGenerations
        {
            get { return this._instanceGenerations; }
            set { this._instanceGenerations = value; }
        }

        // Check to see if InstanceGenerations property is set
        internal bool IsSetInstanceGenerations()
        {
            return this._instanceGenerations != null && this._instanceGenerations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocalStorage. 
        /// <para>
        /// Indicates whether instance types with instance store volumes are included, excluded,
        /// or required. For more information, <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
        /// EC2 instance store</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To include instance types with instance store volumes, specify <code>included</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To require only instance types with instance store volumes, specify <code>required</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To exclude instance types with instance store volumes, specify <code>excluded</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>included</code> 
        /// </para>
        /// </summary>
        public LocalStorage LocalStorage
        {
            get { return this._localStorage; }
            set { this._localStorage = value; }
        }

        // Check to see if LocalStorage property is set
        internal bool IsSetLocalStorage()
        {
            return this._localStorage != null;
        }

        /// <summary>
        /// Gets and sets the property LocalStorageTypes. 
        /// <para>
        /// The type of local storage that is required.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For instance types with hard disk drive (HDD) storage, specify <code>hdd</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with solid state drive (SDD) storage, specify <code>sdd</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>hdd</code> and <code>sdd</code> 
        /// </para>
        /// </summary>
        public List<string> LocalStorageTypes
        {
            get { return this._localStorageTypes; }
            set { this._localStorageTypes = value; }
        }

        // Check to see if LocalStorageTypes property is set
        internal bool IsSetLocalStorageTypes()
        {
            return this._localStorageTypes != null && this._localStorageTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MemoryGiBPerVCpu. 
        /// <para>
        /// The minimum and maximum amount of memory per vCPU, in GiB.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public MemoryGiBPerVCpuRequest MemoryGiBPerVCpu
        {
            get { return this._memoryGiBPerVCpu; }
            set { this._memoryGiBPerVCpu = value; }
        }

        // Check to see if MemoryGiBPerVCpu property is set
        internal bool IsSetMemoryGiBPerVCpu()
        {
            return this._memoryGiBPerVCpu != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryMiB. 
        /// <para>
        /// The minimum and maximum amount of memory, in MiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryMiBRequest MemoryMiB
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
        /// Gets and sets the property NetworkInterfaceCount. 
        /// <para>
        /// The minimum and maximum number of network interfaces.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public NetworkInterfaceCountRequest NetworkInterfaceCount
        {
            get { return this._networkInterfaceCount; }
            set { this._networkInterfaceCount = value; }
        }

        // Check to see if NetworkInterfaceCount property is set
        internal bool IsSetNetworkInterfaceCount()
        {
            return this._networkInterfaceCount != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandMaxPricePercentageOverLowestPrice. 
        /// <para>
        /// The price protection threshold for On-Demand Instances. This is the maximum you’ll
        /// pay for an On-Demand Instance, expressed as a percentage above the cheapest M, C,
        /// or R instance type with your specified attributes. When Amazon EC2 selects instance
        /// types with your attributes, it excludes instance types priced above your threshold.
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 interprets as a percentage.
        /// </para>
        ///  
        /// <para>
        /// To turn off price protection, specify a high value, such as <code>999999</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetSpotPlacementScores.html">GetSpotPlacementScores</a>
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetInstanceTypesFromInstanceRequirements.html">GetInstanceTypesFromInstanceRequirements</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set <code>TargetCapacityUnitType</code> to <code>vcpu</code> or <code>memory-mib</code>,
        /// the price protection threshold is applied based on the per-vCPU or per-memory price
        /// instead of the per-instance price.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <code>20</code> 
        /// </para>
        /// </summary>
        public int OnDemandMaxPricePercentageOverLowestPrice
        {
            get { return this._onDemandMaxPricePercentageOverLowestPrice.GetValueOrDefault(); }
            set { this._onDemandMaxPricePercentageOverLowestPrice = value; }
        }

        // Check to see if OnDemandMaxPricePercentageOverLowestPrice property is set
        internal bool IsSetOnDemandMaxPricePercentageOverLowestPrice()
        {
            return this._onDemandMaxPricePercentageOverLowestPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireHibernateSupport. 
        /// <para>
        /// Indicates whether instance types must support hibernation for On-Demand Instances.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetSpotPlacementScores.html">GetSpotPlacementScores</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool RequireHibernateSupport
        {
            get { return this._requireHibernateSupport.GetValueOrDefault(); }
            set { this._requireHibernateSupport = value; }
        }

        // Check to see if RequireHibernateSupport property is set
        internal bool IsSetRequireHibernateSupport()
        {
            return this._requireHibernateSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpotMaxPricePercentageOverLowestPrice. 
        /// <para>
        /// The price protection threshold for Spot Instance. This is the maximum you’ll pay for
        /// an Spot Instance, expressed as a percentage above the cheapest M, C, or R instance
        /// type with your specified attributes. When Amazon EC2 selects instance types with your
        /// attributes, it excludes instance types priced above your threshold.
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 interprets as a percentage.
        /// </para>
        ///  
        /// <para>
        /// To turn off price protection, specify a high value, such as <code>999999</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetSpotPlacementScores.html">GetSpotPlacementScores</a>
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetInstanceTypesFromInstanceRequirements.html">GetInstanceTypesFromInstanceRequirements</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set <code>TargetCapacityUnitType</code> to <code>vcpu</code> or <code>memory-mib</code>,
        /// the price protection threshold is applied based on the per-vCPU or per-memory price
        /// instead of the per-instance price.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <code>100</code> 
        /// </para>
        /// </summary>
        public int SpotMaxPricePercentageOverLowestPrice
        {
            get { return this._spotMaxPricePercentageOverLowestPrice.GetValueOrDefault(); }
            set { this._spotMaxPricePercentageOverLowestPrice = value; }
        }

        // Check to see if SpotMaxPricePercentageOverLowestPrice property is set
        internal bool IsSetSpotMaxPricePercentageOverLowestPrice()
        {
            return this._spotMaxPricePercentageOverLowestPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalLocalStorageGB. 
        /// <para>
        /// The minimum and maximum amount of total local storage, in GB.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public TotalLocalStorageGBRequest TotalLocalStorageGB
        {
            get { return this._totalLocalStorageGB; }
            set { this._totalLocalStorageGB = value; }
        }

        // Check to see if TotalLocalStorageGB property is set
        internal bool IsSetTotalLocalStorageGB()
        {
            return this._totalLocalStorageGB != null;
        }

        /// <summary>
        /// Gets and sets the property VCpuCount. 
        /// <para>
        /// The minimum and maximum number of vCPUs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VCpuCountRangeRequest VCpuCount
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