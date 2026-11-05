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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The attributes for the instance types for a mixed instances policy. Amazon EC2 Auto
    /// Scaling uses your specified requirements to identify instance types. Then, it uses
    /// your On-Demand and Spot allocation strategies to launch instances from these instance
    /// types.
    /// 
    ///  
    /// <para>
    /// When you specify multiple attributes, you get instance types that satisfy all of the
    /// specified attributes. If you specify multiple values for an attribute, you get instance
    /// types that satisfy any of the specified values.
    /// </para>
    ///  
    /// <para>
    /// To limit the list of instance types from which Amazon EC2 Auto Scaling can identify
    /// matching instance types, you can use one of the following parameters, but not both
    /// in the same request:
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
    /// You must specify <c>VCpuCount</c> and <c>MemoryMiB</c>. All other attributes are optional.
    /// Any unspecified optional attribute is set to its default.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-mixed-instances-group-attribute-based-instance-type-selection.html">Create
    /// a mixed instances group using attribute-based instance type selection</a> in the <i>Amazon
    /// EC2 Auto Scaling User Guide</i>. For help determining which instance types match your
    /// attributes before you apply them to your Auto Scaling group, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-attribute-based-instance-type-selection.html#ec2fleet-get-instance-types-from-instance-requirements">Preview
    /// instance types with specified attributes</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class InstanceRequirements
    {
        /// <summary>
        /// Gets and sets the property AcceleratorCount. 
        /// <para>
        /// The minimum and maximum number of accelerators (GPUs, FPGAs, or Amazon Web Services
        /// Inferentia chips) for an instance type.
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
        public AcceleratorCountRequest AcceleratorCount { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorCount property is set.
        /// </summary>
        internal bool IsSetAcceleratorCount() => this.AcceleratorCount != null;

        /// <summary>
        /// Gets and sets the property AcceleratorManufacturers. 
        /// <para>
        /// Indicates whether instance types must have accelerators by specific manufacturers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For instance types with NVIDIA devices, specify <c>nvidia</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with AMD devices, specify <c>amd</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with Amazon Web Services devices, specify <c>amazon-web-services</c>.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AcceleratorManufacturers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AcceleratorManufacturers property is set.
        /// </summary>
        internal bool IsSetAcceleratorManufacturers() => this.AcceleratorManufacturers != null && (this.AcceleratorManufacturers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AcceleratorNames. 
        /// <para>
        /// Lists the accelerators that must be on an instance type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For instance types with NVIDIA A100 GPUs, specify <c>a100</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA V100 GPUs, specify <c>v100</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA K80 GPUs, specify <c>k80</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with NVIDIA T4 GPUs, specify <c>t4</c>.
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
        /// For instance types with Xilinx VU9P FPGAs, specify <c>vu9p</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Any accelerator
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AcceleratorNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AcceleratorNames property is set.
        /// </summary>
        internal bool IsSetAcceleratorNames() => this.AcceleratorNames != null && (this.AcceleratorNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AcceleratorTotalMemoryMiB. 
        /// <para>
        /// The minimum and maximum total memory size for the accelerators on an instance type,
        /// in MiB.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public AcceleratorTotalMemoryMiBRequest AcceleratorTotalMemoryMiB { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorTotalMemoryMiB property is set.
        /// </summary>
        internal bool IsSetAcceleratorTotalMemoryMiB() => this.AcceleratorTotalMemoryMiB != null;

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        /// Lists the accelerator types that must be on an instance type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For instance types with GPU accelerators, specify <c>gpu</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with FPGA accelerators, specify <c>fpga</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For instance types with inference accelerators, specify <c>inference</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Any accelerator type
        /// </para>
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
        /// For example, if you specify <c>c5*</c>, Amazon EC2 Auto Scaling will allow the entire
        /// C5 instance family, which includes all C5a and C5n instance types. If you specify
        /// <c>m5a.*</c>, Amazon EC2 Auto Scaling will allow all the M5a instance types, but not
        /// the M5n instance types.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 400)]
        public List<string> AllowedInstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedInstanceTypes property is set.
        /// </summary>
        internal bool IsSetAllowedInstanceTypes() => this.AllowedInstanceTypes != null && (this.AllowedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BareMetal. 
        /// <para>
        /// Indicates whether bare metal instance types are included, excluded, or required.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>excluded</c> 
        /// </para>
        /// </summary>
        public BareMetal BareMetal { get; set; }

        /// <summary>
        /// Checks to see if the BareMetal property is set.
        /// </summary>
        internal bool IsSetBareMetal() => this.BareMetal != null;

        /// <summary>
        /// Gets and sets the property BaselineEbsBandwidthMbps. 
        /// <para>
        /// The minimum and maximum baseline bandwidth performance for an instance type, in Mbps.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-optimized.html">Amazon
        /// EBS–optimized instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public BaselineEbsBandwidthMbpsRequest BaselineEbsBandwidthMbps { get; set; }

        /// <summary>
        /// Checks to see if the BaselineEbsBandwidthMbps property is set.
        /// </summary>
        internal bool IsSetBaselineEbsBandwidthMbps() => this.BaselineEbsBandwidthMbps != null;

        /// <summary>
        /// Gets and sets the property BaselinePerformanceFactors. 
        /// <para>
        ///  The baseline performance factors for the instance requirements. 
        /// </para>
        /// </summary>
        public BaselinePerformanceFactorsRequest BaselinePerformanceFactors { get; set; }

        /// <summary>
        /// Checks to see if the BaselinePerformanceFactors property is set.
        /// </summary>
        internal bool IsSetBaselinePerformanceFactors() => this.BaselinePerformanceFactors != null;

        /// <summary>
        /// Gets and sets the property BurstablePerformance. 
        /// <para>
        /// Indicates whether burstable performance instance types are included, excluded, or
        /// required. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>excluded</c> 
        /// </para>
        /// </summary>
        public BurstablePerformance BurstablePerformance { get; set; }

        /// <summary>
        /// Checks to see if the BurstablePerformance property is set.
        /// </summary>
        internal bool IsSetBurstablePerformance() => this.BurstablePerformance != null;

        /// <summary>
        /// Gets and sets the property CpuManufacturers. 
        /// <para>
        /// Lists which specific CPU manufacturers to include.
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
        /// Don't confuse the CPU hardware manufacturer with the CPU hardware architecture. Instances
        /// will be launched with a compatible CPU architecture based on the Amazon Machine Image
        /// (AMI) that you specify in your launch template. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: Any manufacturer
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CpuManufacturers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CpuManufacturers property is set.
        /// </summary>
        internal bool IsSetCpuManufacturers() => this.CpuManufacturers != null && (this.CpuManufacturers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExcludedInstanceTypes. 
        /// <para>
        /// The instance types to exclude. You can use strings with one or more wild cards, represented
        /// by an asterisk (<c>*</c>), to exclude an instance family, type, size, or generation.
        /// The following are examples: <c>m5.8xlarge</c>, <c>c5*.*</c>, <c>m5a.*</c>, <c>r*</c>,
        /// <c>*3*</c>. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you specify <c>c5*</c>, you are excluding the entire C5 instance family,
        /// which includes all C5a and C5n instance types. If you specify <c>m5a.*</c>, Amazon
        /// EC2 Auto Scaling will exclude all the M5a instance types, but not the M5n instance
        /// types.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 400)]
        public List<string> ExcludedInstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedInstanceTypes property is set.
        /// </summary>
        internal bool IsSetExcludedInstanceTypes() => this.ExcludedInstanceTypes != null && (this.ExcludedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceGenerations. 
        /// <para>
        /// Indicates whether current or previous generation instance types are included.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For current generation instance types, specify <c>current</c>. The current generation
        /// includes EC2 instance types currently recommended for use. This typically includes
        /// the latest two to three generations in each instance family. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For previous generation instance types, specify <c>previous</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Any current or previous generation
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceGenerations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceGenerations property is set.
        /// </summary>
        internal bool IsSetInstanceGenerations() => this.InstanceGenerations != null && (this.InstanceGenerations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocalStorage. 
        /// <para>
        /// Indicates whether instance types with instance store volumes are included, excluded,
        /// or required. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
        /// EC2 instance store</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>included</c> 
        /// </para>
        /// </summary>
        public LocalStorage LocalStorage { get; set; }

        /// <summary>
        /// Checks to see if the LocalStorage property is set.
        /// </summary>
        internal bool IsSetLocalStorage() => this.LocalStorage != null;

        /// <summary>
        /// Gets and sets the property LocalStorageTypes. 
        /// <para>
        /// Indicates the type of local storage that is required.
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
        /// Default: Any local storage type
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LocalStorageTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LocalStorageTypes property is set.
        /// </summary>
        internal bool IsSetLocalStorageTypes() => this.LocalStorageTypes != null && (this.LocalStorageTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxSpotPriceAsPercentageOfOptimalOnDemandPrice. 
        /// <para>
        /// [Price protection] The price protection threshold for Spot Instances, as a percentage
        /// of an identified On-Demand price. The identified On-Demand price is the price of the
        /// lowest priced current generation C, M, or R instance type with your specified attributes.
        /// If no current generation C, M, or R instance type matches your attributes, then the
        /// identified price is from either the lowest priced current generation instance types
        /// or, failing that, the lowest priced previous generation instance types that match
        /// your attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes,
        /// we will exclude instance types whose price exceeds your specified threshold.
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>DesiredCapacityType</c> to <c>vcpu</c> or <c>memory-mib</c>, the price
        /// protection threshold is based on the per-vCPU or per-memory price instead of the per
        /// instance price. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Only one of <c>SpotMaxPricePercentageOverLowestPrice</c> or <c>MaxSpotPriceAsPercentageOfOptimalOnDemandPrice</c>
        /// can be specified. If you don't specify either, Amazon EC2 Auto Scaling will automatically
        /// apply optimal price protection to consistently select from a wide range of instance
        /// types. To indicate no price protection threshold for Spot Instances, meaning you want
        /// to consider all instance types that match your attributes, include one of these parameters
        /// and specify a high value, such as <c>999999</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

        /// <summary>
        /// Checks to see if the MaxSpotPriceAsPercentageOfOptimalOnDemandPrice property is set.
        /// </summary>
        internal bool IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice() => this.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryGiBPerVCpu. 
        /// <para>
        /// The minimum and maximum amount of memory per vCPU for an instance type, in GiB.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public MemoryGiBPerVCpuRequest MemoryGiBPerVCpu { get; set; }

        /// <summary>
        /// Checks to see if the MemoryGiBPerVCpu property is set.
        /// </summary>
        internal bool IsSetMemoryGiBPerVCpu() => this.MemoryGiBPerVCpu != null;

        /// <summary>
        /// Gets and sets the property MemoryMiB. 
        /// <para>
        /// The minimum and maximum instance memory size for an instance type, in MiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryMiBRequest MemoryMiB { get; set; }

        /// <summary>
        /// Checks to see if the MemoryMiB property is set.
        /// </summary>
        internal bool IsSetMemoryMiB() => this.MemoryMiB != null;

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
        public NetworkBandwidthGbpsRequest NetworkBandwidthGbps { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBandwidthGbps property is set.
        /// </summary>
        internal bool IsSetNetworkBandwidthGbps() => this.NetworkBandwidthGbps != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceCount. 
        /// <para>
        /// The minimum and maximum number of network interfaces for an instance type.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public NetworkInterfaceCountRequest NetworkInterfaceCount { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceCount property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceCount() => this.NetworkInterfaceCount != null;

        /// <summary>
        /// Gets and sets the property OnDemandMaxPricePercentageOverLowestPrice. 
        /// <para>
        /// [Price protection] The price protection threshold for On-Demand Instances, as a percentage
        /// higher than an identified On-Demand price. The identified On-Demand price is the price
        /// of the lowest priced current generation C, M, or R instance type with your specified
        /// attributes. If no current generation C, M, or R instance type matches your attributes,
        /// then the identified price is from either the lowest priced current generation instance
        /// types or, failing that, the lowest priced previous generation instance types that
        /// match your attributes. When Amazon EC2 Auto Scaling selects instance types with your
        /// attributes, we will exclude instance types whose price exceeds your specified threshold.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage.
        /// </para>
        ///  
        /// <para>
        /// To turn off price protection, specify a high value, such as <c>999999</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you set <c>DesiredCapacityType</c> to <c>vcpu</c> or <c>memory-mib</c>, the price
        /// protection threshold is applied based on the per-vCPU or per-memory price instead
        /// of the per instance price. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>20</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandMaxPricePercentageOverLowestPrice property is set.
        /// </summary>
        internal bool IsSetOnDemandMaxPricePercentageOverLowestPrice() => this.OnDemandMaxPricePercentageOverLowestPrice.HasValue;

        /// <summary>
        /// Gets and sets the property RequireHibernateSupport. 
        /// <para>
        /// Indicates whether instance types must provide On-Demand Instance hibernation support.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? RequireHibernateSupport { get; set; }

        /// <summary>
        /// Checks to see if the RequireHibernateSupport property is set.
        /// </summary>
        internal bool IsSetRequireHibernateSupport() => this.RequireHibernateSupport.HasValue;

        /// <summary>
        /// Gets and sets the property SpotMaxPricePercentageOverLowestPrice. 
        /// <para>
        /// [Price protection] The price protection threshold for Spot Instances, as a percentage
        /// higher than an identified Spot price. The identified Spot price is the price of the
        /// lowest priced current generation C, M, or R instance type with your specified attributes.
        /// If no current generation C, M, or R instance type matches your attributes, then the
        /// identified price is from either the lowest priced current generation instance types
        /// or, failing that, the lowest priced previous generation instance types that match
        /// your attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes,
        /// we will exclude instance types whose price exceeds your specified threshold.
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you set <c>DesiredCapacityType</c> to <c>vcpu</c> or <c>memory-mib</c>, the price
        /// protection threshold is based on the per-vCPU or per-memory price instead of the per
        /// instance price. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Only one of <c>SpotMaxPricePercentageOverLowestPrice</c> or <c>MaxSpotPriceAsPercentageOfOptimalOnDemandPrice</c>
        /// can be specified. If you don't specify either, Amazon EC2 Auto Scaling will automatically
        /// apply optimal price protection to consistently select from a wide range of instance
        /// types. To indicate no price protection threshold for Spot Instances, meaning you want
        /// to consider all instance types that match your attributes, include one of these parameters
        /// and specify a high value, such as <c>999999</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SpotMaxPricePercentageOverLowestPrice { get; set; }

        /// <summary>
        /// Checks to see if the SpotMaxPricePercentageOverLowestPrice property is set.
        /// </summary>
        internal bool IsSetSpotMaxPricePercentageOverLowestPrice() => this.SpotMaxPricePercentageOverLowestPrice.HasValue;

        /// <summary>
        /// Gets and sets the property TotalLocalStorageGB. 
        /// <para>
        /// The minimum and maximum total local storage size for an instance type, in GB.
        /// </para>
        ///  
        /// <para>
        /// Default: No minimum or maximum limits
        /// </para>
        /// </summary>
        public TotalLocalStorageGBRequest TotalLocalStorageGB { get; set; }

        /// <summary>
        /// Checks to see if the TotalLocalStorageGB property is set.
        /// </summary>
        internal bool IsSetTotalLocalStorageGB() => this.TotalLocalStorageGB != null;

        /// <summary>
        /// Gets and sets the property VCpuCount. 
        /// <para>
        /// The minimum and maximum number of vCPUs for an instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VCpuCountRequest VCpuCount { get; set; }

        /// <summary>
        /// Checks to see if the VCpuCount property is set.
        /// </summary>
        internal bool IsSetVCpuCount() => this.VCpuCount != null;
    }
}
