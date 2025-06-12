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
    /// The attributes for the instance types. When you specify instance attributes, Amazon
    /// EC2 will identify instance types with these attributes.
    /// 
    ///  
    /// <para>
    /// You must specify <c>VCpuCount</c> and <c>MemoryMiB</c>. All other attributes are optional.
    /// Any unspecified optional attribute is set to its default.
    /// </para>
    ///  
    /// <para>
    /// When you specify multiple attributes, you get instance types that satisfy all of the
    /// specified attributes. If you specify multiple values for an attribute, you get instance
    /// types that satisfy any of the specified values.
    /// </para>
    ///  
    /// <para>
    /// To limit the list of instance types from which Amazon EC2 can identify matching instance
    /// types, you can use one of the following parameters, but not both in the same request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>AllowedInstanceTypes</c> - The instance types to include in the list. All other
    /// instance types are ignored, even if they match your specified attributes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ExcludedInstanceTypes</c> - The instance types to exclude from the list, even
    /// if they match your specified attributes.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// If you specify <c>InstanceRequirements</c>, you can't specify <c>InstanceType</c>.
    /// </para>
    ///  
    /// <para>
    /// Attribute-based instance type selection is only supported when using Auto Scaling
    /// groups, EC2 Fleet, and Spot Fleet to launch instances. If you plan to use the launch
    /// template in the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-instance-wizard.html">launch
    /// instance wizard</a> or with the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances
    /// API</a>, you can't specify <c>InstanceRequirements</c>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-mixed-instances-group-attribute-based-instance-type-selection.html">Create
    /// mixed instances group using attribute-based instance type selection</a> in the <i>Amazon
    /// EC2 Auto Scaling User Guide</i>, and also <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-attribute-based-instance-type-selection.html">Specify
    /// attributes for instance type selection for EC2 Fleet or Spot Fleet</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html">Spot
    /// placement score</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class InstanceRequirements
    {
        private AcceleratorCount _acceleratorCount;
        private List<string> _acceleratorManufacturers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _acceleratorNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AcceleratorTotalMemoryMiB _acceleratorTotalMemoryMiB;
        private List<string> _acceleratorTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private BareMetal _bareMetal;
        private BaselineEbsBandwidthMbps _baselineEbsBandwidthMbps;
        private BaselinePerformanceFactors _baselinePerformanceFactors;
        private BurstablePerformance _burstablePerformance;
        private List<string> _cpuManufacturers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _instanceGenerations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private LocalStorage _localStorage;
        private List<string> _localStorageTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxSpotPriceAsPercentageOfOptimalOnDemandPrice;
        private MemoryGiBPerVCpu _memoryGiBPerVCpu;
        private MemoryMiB _memoryMiB;
        private NetworkBandwidthGbps _networkBandwidthGbps;
        private NetworkInterfaceCount _networkInterfaceCount;
        private int? _onDemandMaxPricePercentageOverLowestPrice;
        private bool? _requireHibernateSupport;
        private int? _spotMaxPricePercentageOverLowestPrice;
        private TotalLocalStorageGB _totalLocalStorageGB;
        private VCpuCountRange _vCpuCount;

        /// <summary>
        /// Gets and sets the property AcceleratorCount. 
        /// <para>
        /// The minimum and maximum number of accelerators (GPUs, FPGAs, or Amazon Web Services
        /// Inferentia chips) on an instance.
        /// </para>
        ///  
        /// <para>
        /// To exclude accelerator-enabled instance types, set <c>Max</c> to <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public AcceleratorCount AcceleratorCount
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
        /// For instance types with Amazon Web Services devices, specify <c>amazon-web-services</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with AMD devices, specify <c>amd</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Habana devices, specify <c>habana</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA devices, specify <c>nvidia</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Xilinx devices, specify <c>xilinx</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Any manufacturer
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AcceleratorManufacturers
        {
            get { return this._acceleratorManufacturers; }
            set { this._acceleratorManufacturers = value; }
        }

        // Check to see if AcceleratorManufacturers property is set
        internal bool IsSetAcceleratorManufacturers()
        {
            return this._acceleratorManufacturers != null && (this._acceleratorManufacturers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AcceleratorNames. 
        /// <para>
        /// The accelerators that must be on the instance type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For instance types with NVIDIA A10G GPUs, specify <c>a10g</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA A100 GPUs, specify <c>a100</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA H100 GPUs, specify <c>h100</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Amazon Web Services Inferentia chips, specify <c>inferentia</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA GRID K520 GPUs, specify <c>k520</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA K80 GPUs, specify <c>k80</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA M60 GPUs, specify <c>m60</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with AMD Radeon Pro V520 GPUs, specify <c>radeon-pro-v520</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA T4 GPUs, specify <c>t4</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA T4G GPUs, specify <c>t4g</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Xilinx VU9P FPGAs, specify <c>vu9p</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA V100 GPUs, specify <c>v100</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Any accelerator
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AcceleratorNames
        {
            get { return this._acceleratorNames; }
            set { this._acceleratorNames = value; }
        }

        // Check to see if AcceleratorNames property is set
        internal bool IsSetAcceleratorNames()
        {
            return this._acceleratorNames != null && (this._acceleratorNames.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        public AcceleratorTotalMemoryMiB AcceleratorTotalMemoryMiB
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
        /// For instance types with FPGA accelerators, specify <c>fpga</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with GPU accelerators, specify <c>gpu</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Inference accelerators, specify <c>inference</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Any accelerator type
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
        /// Gets and sets the property AllowedInstanceTypes. 
        /// <para>
        /// The instance types to apply your specified attributes against. All other instance
        /// types are ignored, even if they match your specified attributes.
        /// </para>
        ///  
        /// <para>
        /// You can use strings with one or more wild cards, represented by an asterisk (<c>*</c>),
        /// to allow an instance type, size, or generation. The following are examples: <c>m5.8xlarge</c>,
        /// <c>c5*.*</c>, <c>m5a.*</c>, <c>r*</c>, <c>*3*</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <c>c5*</c>,Amazon EC2 will allow the entire C5 instance
        /// family, which includes all C5a and C5n instance types. If you specify <c>m5a.*</c>,
        /// Amazon EC2 will allow all the M5a instance types, but not the M5n instance types.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>AllowedInstanceTypes</c>, you can't specify <c>ExcludedInstanceTypes</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: All instance types
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=400)]
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
        /// Gets and sets the property BareMetal. 
        /// <para>
        /// Indicates whether bare metal instance types must be included, excluded, or required.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To include bare metal instance types, specify <c>included</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To require only bare metal instance types, specify <c>required</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To exclude bare metal instance types, specify <c>excluded</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>excluded</c> 
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
        public BaselineEbsBandwidthMbps BaselineEbsBandwidthMbps
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
        /// Gets and sets the property BaselinePerformanceFactors. 
        /// <para>
        /// The baseline performance to consider, using an instance family as a baseline reference.
        /// The instance family establishes the lowest acceptable level of performance. Amazon
        /// EC2 uses this baseline to guide instance type selection, but there is no guarantee
        /// that the selected instance types will always exceed the baseline for every application.
        /// Currently, this parameter only supports CPU performance as a baseline performance
        /// factor. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-attribute-based-instance-type-selection.html#ec2fleet-abis-performance-protection">Performance
        /// protection</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public BaselinePerformanceFactors BaselinePerformanceFactors
        {
            get { return this._baselinePerformanceFactors; }
            set { this._baselinePerformanceFactors = value; }
        }

        // Check to see if BaselinePerformanceFactors property is set
        internal bool IsSetBaselinePerformanceFactors()
        {
            return this._baselinePerformanceFactors != null;
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
        /// To include burstable performance instance types, specify <c>included</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To require only burstable performance instance types, specify <c>required</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To exclude burstable performance instance types, specify <c>excluded</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>excluded</c> 
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
        /// For instance types with Intel CPUs, specify <c>intel</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with AMD CPUs, specify <c>amd</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Amazon Web Services CPUs, specify <c>amazon-web-services</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Apple CPUs, specify <c>apple</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CpuManufacturers
        {
            get { return this._cpuManufacturers; }
            set { this._cpuManufacturers = value; }
        }

        // Check to see if CpuManufacturers property is set
        internal bool IsSetCpuManufacturers()
        {
            return this._cpuManufacturers != null && (this._cpuManufacturers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludedInstanceTypes. 
        /// <para>
        /// The instance types to exclude.
        /// </para>
        ///  
        /// <para>
        /// You can use strings with one or more wild cards, represented by an asterisk (<c>*</c>),
        /// to exclude an instance type, size, or generation. The following are examples: <c>m5.8xlarge</c>,
        /// <c>c5*.*</c>, <c>m5a.*</c>, <c>r*</c>, <c>*3*</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <c>c5*</c>,Amazon EC2 will exclude the entire C5 instance
        /// family, which includes all C5a and C5n instance types. If you specify <c>m5a.*</c>,
        /// Amazon EC2 will exclude all the M5a instance types, but not the M5n instance types.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>ExcludedInstanceTypes</c>, you can't specify <c>AllowedInstanceTypes</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: No excluded instance types
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._excludedInstanceTypes != null && (this._excludedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// For current generation instance types, specify <c>current</c>.
        /// </para>
        ///  
        /// <para>
        /// For previous generation instance types, specify <c>previous</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: Current and previous generation instance types
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceGenerations
        {
            get { return this._instanceGenerations; }
            set { this._instanceGenerations = value; }
        }

        // Check to see if InstanceGenerations property is set
        internal bool IsSetInstanceGenerations()
        {
            return this._instanceGenerations != null && (this._instanceGenerations.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// To include instance types with instance store volumes, specify <c>included</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To require only instance types with instance store volumes, specify <c>required</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To exclude instance types with instance store volumes, specify <c>excluded</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>included</c> 
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
        /// For instance types with hard disk drive (HDD) storage, specify <c>hdd</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with solid state drive (SSD) storage, specify <c>ssd</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>hdd</c> and <c>ssd</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LocalStorageTypes
        {
            get { return this._localStorageTypes; }
            set { this._localStorageTypes = value; }
        }

        // Check to see if LocalStorageTypes property is set
        internal bool IsSetLocalStorageTypes()
        {
            return this._localStorageTypes != null && (this._localStorageTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxSpotPriceAsPercentageOfOptimalOnDemandPrice. 
        /// <para>
        /// [Price protection] The price protection threshold for Spot Instances, as a percentage
        /// of an identified On-Demand price. The identified On-Demand price is the price of the
        /// lowest priced current generation C, M, or R instance type with your specified attributes.
        /// If no current generation C, M, or R instance type matches your attributes, then the
        /// identified price is from the lowest priced current generation instance types, and
        /// failing that, from the lowest priced previous generation instance types that match
        /// your attributes. When Amazon EC2 selects instance types with your attributes, it will
        /// exclude instance types whose price exceeds your specified threshold.
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 interprets as a percentage.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>TargetCapacityUnitType</c> to <c>vcpu</c> or <c>memory-mib</c>, the
        /// price protection threshold is based on the per vCPU or per memory price instead of
        /// the per instance price.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only one of <c>SpotMaxPricePercentageOverLowestPrice</c> or <c>MaxSpotPriceAsPercentageOfOptimalOnDemandPrice</c>
        /// can be specified. If you don't specify either, Amazon EC2 will automatically apply
        /// optimal price protection to consistently select from a wide range of instance types.
        /// To indicate no price protection threshold for Spot Instances, meaning you want to
        /// consider all instance types that match your attributes, include one of these parameters
        /// and specify a high value, such as <c>999999</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public int? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
        {
            get { return this._maxSpotPriceAsPercentageOfOptimalOnDemandPrice; }
            set { this._maxSpotPriceAsPercentageOfOptimalOnDemandPrice = value; }
        }

        // Check to see if MaxSpotPriceAsPercentageOfOptimalOnDemandPrice property is set
        internal bool IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice()
        {
            return this._maxSpotPriceAsPercentageOfOptimalOnDemandPrice.HasValue; 
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
        public MemoryGiBPerVCpu MemoryGiBPerVCpu
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
        public MemoryMiB MemoryMiB
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
        /// Gets and sets the property NetworkBandwidthGbps. 
        /// <para>
        /// The minimum and maximum amount of network bandwidth, in gigabits per second (Gbps).
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public NetworkBandwidthGbps NetworkBandwidthGbps
        {
            get { return this._networkBandwidthGbps; }
            set { this._networkBandwidthGbps = value; }
        }

        // Check to see if NetworkBandwidthGbps property is set
        internal bool IsSetNetworkBandwidthGbps()
        {
            return this._networkBandwidthGbps != null;
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
        public NetworkInterfaceCount NetworkInterfaceCount
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
        /// [Price protection] The price protection threshold for On-Demand Instances, as a percentage
        /// higher than an identified On-Demand price. The identified On-Demand price is the price
        /// of the lowest priced current generation C, M, or R instance type with your specified
        /// attributes. When Amazon EC2 selects instance types with your attributes, it will exclude
        /// instance types whose price exceeds your specified threshold.
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 interprets as a percentage.
        /// </para>
        ///  
        /// <para>
        /// To turn off price protection, specify a high value, such as <c>999999</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetSpotPlacementScores.html">GetSpotPlacementScores</a>
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetInstanceTypesFromInstanceRequirements.html">GetInstanceTypesFromInstanceRequirements</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set <c>TargetCapacityUnitType</c> to <c>vcpu</c> or <c>memory-mib</c>, the
        /// price protection threshold is applied based on the per-vCPU or per-memory price instead
        /// of the per-instance price.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>20</c> 
        /// </para>
        /// </summary>
        public int? OnDemandMaxPricePercentageOverLowestPrice
        {
            get { return this._onDemandMaxPricePercentageOverLowestPrice; }
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
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? RequireHibernateSupport
        {
            get { return this._requireHibernateSupport; }
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
        /// [Price protection] The price protection threshold for Spot Instances, as a percentage
        /// higher than an identified Spot price. The identified Spot price is the Spot price
        /// of the lowest priced current generation C, M, or R instance type with your specified
        /// attributes. If no current generation C, M, or R instance type matches your attributes,
        /// then the identified Spot price is from the lowest priced current generation instance
        /// types, and failing that, from the lowest priced previous generation instance types
        /// that match your attributes. When Amazon EC2 selects instance types with your attributes,
        /// it will exclude instance types whose Spot price exceeds your specified threshold.
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 interprets as a percentage.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>TargetCapacityUnitType</c> to <c>vcpu</c> or <c>memory-mib</c>, the
        /// price protection threshold is applied based on the per-vCPU or per-memory price instead
        /// of the per-instance price.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetSpotPlacementScores.html">GetSpotPlacementScores</a>
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetInstanceTypesFromInstanceRequirements.html">GetInstanceTypesFromInstanceRequirements</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only one of <c>SpotMaxPricePercentageOverLowestPrice</c> or <c>MaxSpotPriceAsPercentageOfOptimalOnDemandPrice</c>
        /// can be specified. If you don't specify either, Amazon EC2 will automatically apply
        /// optimal price protection to consistently select from a wide range of instance types.
        /// To indicate no price protection threshold for Spot Instances, meaning you want to
        /// consider all instance types that match your attributes, include one of these parameters
        /// and specify a high value, such as <c>999999</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>100</c> 
        /// </para>
        /// </summary>
        public int? SpotMaxPricePercentageOverLowestPrice
        {
            get { return this._spotMaxPricePercentageOverLowestPrice; }
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
        public TotalLocalStorageGB TotalLocalStorageGB
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