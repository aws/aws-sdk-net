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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
        private AcceleratorCountRequest _acceleratorCount;
        private List<string> _acceleratorManufacturers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _acceleratorNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AcceleratorTotalMemoryMiBRequest _acceleratorTotalMemoryMiB;
        private List<string> _acceleratorTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private BareMetal _bareMetal;
        private BaselineEbsBandwidthMbpsRequest _baselineEbsBandwidthMbps;
        private BurstablePerformance _burstablePerformance;
        private List<string> _cpuManufacturers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _excludedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _instanceGenerations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private LocalStorage _localStorage;
        private List<string> _localStorageTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxSpotPriceAsPercentageOfOptimalOnDemandPrice;
        private MemoryGiBPerVCpuRequest _memoryGiBPerVCpu;
        private MemoryMiBRequest _memoryMiB;
        private NetworkBandwidthGbpsRequest _networkBandwidthGbps;
        private NetworkInterfaceCountRequest _networkInterfaceCount;
        private int? _onDemandMaxPricePercentageOverLowestPrice;
        private bool? _requireHibernateSupport;
        private int? _spotMaxPricePercentageOverLowestPrice;
        private TotalLocalStorageGBRequest _totalLocalStorageGB;
        private VCpuCountRangeRequest _vCpuCount;

        /// <summary>
        /// Gets and sets the property AcceleratorCount. 
        /// <para>
        /// The minimum and maximum number of accelerators for the instance types. This is used
        /// when you need instances with specific numbers of GPUs or other accelerators.
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
        /// The accelerator manufacturers to include. You can specify <c>nvidia</c>, <c>amd</c>,
        /// <c>amazon-web-services</c>, or <c>xilinx</c> depending on your accelerator requirements.
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
        /// The specific accelerator names to include. For example, you can specify <c>a100</c>,
        /// <c>v100</c>, <c>k80</c>, or other specific accelerator models.
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
        /// The minimum and maximum total accelerator memory in mebibytes (MiB). This is important
        /// for GPU workloads that require specific amounts of video memory.
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
        /// The accelerator types to include. You can specify <c>gpu</c> for graphics processing
        /// units, <c>fpga</c> for field programmable gate arrays, or <c>inference</c> for machine
        /// learning inference accelerators.
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
        /// The instance types to include in the selection. When specified, Amazon ECS only considers
        /// these instance types, subject to the other requirements specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=400)]
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
        /// Indicates whether to include bare metal instance types. Set to <c>included</c> to
        /// allow bare metal instances, <c>excluded</c> to exclude them, or <c>required</c> to
        /// use only bare metal instances.
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
        /// The minimum and maximum baseline Amazon EBS bandwidth in megabits per second (Mbps).
        /// This is important for workloads with high storage I/O requirements.
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
        /// Indicates whether to include burstable performance instance types (T2, T3, T3a, T4g).
        /// Set to <c>included</c> to allow burstable instances, <c>excluded</c> to exclude them,
        /// or <c>required</c> to use only burstable instances.
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
        /// The CPU manufacturers to include or exclude. You can specify <c>intel</c>, <c>amd</c>,
        /// or <c>amazon-web-services</c> to control which CPU types are used for your workloads.
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
        /// The instance types to exclude from selection. Use this to prevent Amazon ECS from
        /// selecting specific instance types that may not be suitable for your workloads.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=400)]
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
        /// The instance generations to include. You can specify <c>current</c> to use the latest
        /// generation instances, or <c>previous</c> to include previous generation instances
        /// for cost optimization.
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
        /// Indicates whether to include instance types with local storage. Set to <c>included</c>
        /// to allow local storage, <c>excluded</c> to exclude it, or <c>required</c> to use only
        /// instances with local storage.
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
        /// The local storage types to include. You can specify <c>hdd</c> for hard disk drives,
        /// <c>ssd</c> for solid state drives, or both.
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
        /// The maximum price for Spot instances as a percentage of the optimal On-Demand price.
        /// This provides more precise cost control for Spot instance selection.
        /// </para>
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
        /// The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This helps ensure
        /// that instance types have the appropriate memory-to-CPU ratio for your workloads.
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
        /// The minimum and maximum amount of memory in mebibytes (MiB) for the instance types.
        /// Amazon ECS selects instance types that have memory within this range.
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
        /// Gets and sets the property NetworkBandwidthGbps. 
        /// <para>
        /// The minimum and maximum network bandwidth in gigabits per second (Gbps). This is crucial
        /// for network-intensive workloads that require high throughput.
        /// </para>
        /// </summary>
        public NetworkBandwidthGbpsRequest NetworkBandwidthGbps
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
        /// The minimum and maximum number of network interfaces for the instance types. This
        /// is useful for workloads that require multiple network interfaces.
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
        /// Indicates whether the instance types must support hibernation. When set to <c>true</c>,
        /// only instance types that support hibernation are selected.
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
        /// The maximum price for Spot instances as a percentage over the lowest priced On-Demand
        /// instance. This helps control Spot instance costs while maintaining access to capacity.
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
        /// The minimum and maximum total local storage in gigabytes (GB) for instance types with
        /// local storage.
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
        /// The minimum and maximum number of vCPUs for the instance types. Amazon ECS selects
        /// instance types that have vCPU counts within this range.
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