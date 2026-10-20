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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The instance requirements for attribute-based instance type selection. Instead of
    /// specifying exact instance types, you define requirements such as vCPU count, memory
    /// size, network performance, and accelerator specifications. Amazon ECS automatically
    /// selects Amazon EC2 instance types that match these requirements, providing flexibility
    /// and helping to mitigate capacity constraints.
    /// </summary>
    public partial class InstanceRequirementsRequest
    {
        /// <summary>
        /// Gets and sets the property AcceleratorCount. 
        /// <para>
        /// The minimum and maximum number of accelerators for the instance types. This is used
        /// when you need instances with specific numbers of GPUs or other accelerators.
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
        /// The accelerator manufacturers to include. You can specify <c>nvidia</c>, <c>amd</c>,
        /// <c>amazon-web-services</c>, or <c>xilinx</c> depending on your accelerator requirements.
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
        /// The specific accelerator names to include. For example, you can specify <c>a100</c>,
        /// <c>v100</c>, <c>k80</c>, or other specific accelerator models.
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
        /// The minimum and maximum total accelerator memory in mebibytes (MiB). This is important
        /// for GPU workloads that require specific amounts of video memory.
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
        /// The accelerator types to include. You can specify <c>gpu</c> for graphics processing
        /// units, <c>fpga</c> for field programmable gate arrays, or <c>inference</c> for machine
        /// learning inference accelerators.
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
        /// The instance types to include in the selection. When specified, Amazon ECS only considers
        /// these instance types, subject to the other requirements specified.
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
        /// Indicates whether to include bare metal instance types. Set to <c>included</c> to
        /// allow bare metal instances, <c>excluded</c> to exclude them, or <c>required</c> to
        /// use only bare metal instances.
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
        /// The minimum and maximum baseline Amazon EBS bandwidth in megabits per second (Mbps).
        /// This is important for workloads with high storage I/O requirements.
        /// </para>
        /// </summary>
        public BaselineEbsBandwidthMbpsRequest BaselineEbsBandwidthMbps { get; set; }

        /// <summary>
        /// Checks to see if the BaselineEbsBandwidthMbps property is set.
        /// </summary>
        internal bool IsSetBaselineEbsBandwidthMbps() => this.BaselineEbsBandwidthMbps != null;

        /// <summary>
        /// Gets and sets the property BurstablePerformance. 
        /// <para>
        /// Indicates whether to include burstable performance instance types (T2, T3, T3a, T4g).
        /// Set to <c>included</c> to allow burstable instances, <c>excluded</c> to exclude them,
        /// or <c>required</c> to use only burstable instances.
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
        /// The CPU manufacturers to include or exclude. You can specify <c>intel</c>, <c>amd</c>,
        /// or <c>amazon-web-services</c> to control which CPU types are used for your workloads.
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
        /// The instance types to exclude from selection. Use this to prevent Amazon ECS from
        /// selecting specific instance types that may not be suitable for your workloads.
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
        /// The instance generations to include. You can specify <c>current</c> to use the latest
        /// generation instances, or <c>previous</c> to include previous generation instances
        /// for cost optimization.
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
        /// Indicates whether to include instance types with local storage. Set to <c>included</c>
        /// to allow local storage, <c>excluded</c> to exclude it, or <c>required</c> to use only
        /// instances with local storage.
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
        /// The local storage types to include. You can specify <c>hdd</c> for hard disk drives,
        /// <c>ssd</c> for solid state drives, or both.
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
        /// The maximum price for Spot instances as a percentage of the optimal On-Demand price.
        /// This provides more precise cost control for Spot instance selection.
        /// </para>
        /// </summary>
        public int? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

        /// <summary>
        /// Checks to see if the MaxSpotPriceAsPercentageOfOptimalOnDemandPrice property is set.
        /// </summary>
        internal bool IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice() => this.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryGiBPerVCpu. 
        /// <para>
        /// The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This helps ensure
        /// that instance types have the appropriate memory-to-CPU ratio for your workloads.
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
        /// The minimum and maximum amount of memory in mebibytes (MiB) for the instance types.
        /// Amazon ECS selects instance types that have memory within this range.
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
        /// The minimum and maximum network bandwidth in gigabits per second (Gbps). This is crucial
        /// for network-intensive workloads that require high throughput.
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
        /// The minimum and maximum number of network interfaces for the instance types. This
        /// is useful for workloads that require multiple network interfaces.
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
        /// The price protection threshold for On-Demand Instances, as a percentage higher than
        /// an identified On-Demand price. The identified On-Demand price is the price of the
        /// lowest priced current generation C, M, or R instance type with your specified attributes.
        /// If no current generation C, M, or R instance type matches your attributes, then the
        /// identified price is from either the lowest priced current generation instance types
        /// or, failing that, the lowest priced previous generation instance types that match
        /// your attributes. When Amazon ECS selects instance types with your attributes, we will
        /// exclude instance types whose price exceeds your specified threshold.
        /// </para>
        /// </summary>
        public int? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandMaxPricePercentageOverLowestPrice property is set.
        /// </summary>
        internal bool IsSetOnDemandMaxPricePercentageOverLowestPrice() => this.OnDemandMaxPricePercentageOverLowestPrice.HasValue;

        /// <summary>
        /// Gets and sets the property RequireHibernateSupport. 
        /// <para>
        /// Indicates whether the instance types must support hibernation. When set to <c>true</c>,
        /// only instance types that support hibernation are selected.
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
        /// The maximum price for Spot instances as a percentage over the lowest priced On-Demand
        /// instance. This helps control Spot instance costs while maintaining access to capacity.
        /// </para>
        /// </summary>
        public int? SpotMaxPricePercentageOverLowestPrice { get; set; }

        /// <summary>
        /// Checks to see if the SpotMaxPricePercentageOverLowestPrice property is set.
        /// </summary>
        internal bool IsSetSpotMaxPricePercentageOverLowestPrice() => this.SpotMaxPricePercentageOverLowestPrice.HasValue;

        /// <summary>
        /// Gets and sets the property TotalLocalStorageGB. 
        /// <para>
        /// The minimum and maximum total local storage in gigabytes (GB) for instance types with
        /// local storage.
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
        /// The minimum and maximum number of vCPUs for the instance types. Amazon ECS selects
        /// instance types that have vCPU counts within this range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VCpuCountRangeRequest VCpuCount { get; set; }

        /// <summary>
        /// Checks to see if the VCpuCount property is set.
        /// </summary>
        internal bool IsSetVCpuCount() => this.VCpuCount != null;
    }
}
