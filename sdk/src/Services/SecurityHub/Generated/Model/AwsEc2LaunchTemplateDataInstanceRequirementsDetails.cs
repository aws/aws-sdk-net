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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The attributes for the Amazon EC2 instance types.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataInstanceRequirementsDetails
    {
        private AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorCountDetails _acceleratorCount;
        private List<string> _acceleratorManufacturers = new List<string>();
        private List<string> _acceleratorNames = new List<string>();
        private AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorTotalMemoryMiBDetails _acceleratorTotalMemoryMiB;
        private List<string> _acceleratorTypes = new List<string>();
        private string _bareMetal;
        private AwsEc2LaunchTemplateDataInstanceRequirementsBaselineEbsBandwidthMbpsDetails _baselineEbsBandwidthMbps;
        private string _burstablePerformance;
        private List<string> _cpuManufacturers = new List<string>();
        private List<string> _excludedInstanceTypes = new List<string>();
        private List<string> _instanceGenerations = new List<string>();
        private string _localStorage;
        private List<string> _localStorageTypes = new List<string>();
        private AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails _memoryGiBPerVCpu;
        private AwsEc2LaunchTemplateDataInstanceRequirementsMemoryMiBDetails _memoryMiB;
        private AwsEc2LaunchTemplateDataInstanceRequirementsNetworkInterfaceCountDetails _networkInterfaceCount;
        private int? _onDemandMaxPricePercentageOverLowestPrice;
        private bool? _requireHibernateSupport;
        private int? _spotMaxPricePercentageOverLowestPrice;
        private AwsEc2LaunchTemplateDataInstanceRequirementsTotalLocalStorageGBDetails _totalLocalStorageGB;
        private AwsEc2LaunchTemplateDataInstanceRequirementsVCpuCountDetails _vCpuCount;

        /// <summary>
        /// Gets and sets the property AcceleratorCount. 
        /// <para>
        ///  The minimum and maximum number of accelerators (GPUs, FPGAs, or Amazon Web Services
        /// Inferentia chips) on an instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorCountDetails AcceleratorCount
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
        /// 
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
        ///  The accelerators that must be on the instance type. 
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
        ///  The minimum and maximum amount of total accelerator memory, in MiB. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorTotalMemoryMiBDetails AcceleratorTotalMemoryMiB
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
        /// 
        /// </para>
        /// </summary>
        public string BareMetal
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
        ///  The minimum and maximum baseline bandwidth to Amazon EBS, in Mbps. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-optimized.html">Amazon
        /// EBS optimized instances</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsBaselineEbsBandwidthMbpsDetails BaselineEbsBandwidthMbps
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
        ///  Indicates whether burstable performance T instance types are included, excluded,
        /// or required. For more information, <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        public string BurstablePerformance
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
        ///  The CPU manufacturers to include. 
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
        ///  The instance types to exclude. 
        /// </para>
        /// </summary>
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
        ///  Indicates whether current or previous generation instance types are included. 
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
        ///  Indicates whether instance types with instance store volumes are included, excluded,
        /// or required. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
        /// EC2 instance store</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        public string LocalStorage
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
        ///  The type of local storage that is required. 
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
        ///  The minimum and maximum amount of memory per vCPU, in GiB. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails MemoryGiBPerVCpu
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
        ///  The minimum and maximum amount of memory, in MiB. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsMemoryMiBDetails MemoryMiB
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
        ///  The minimum and maximum number of network interfaces. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsNetworkInterfaceCountDetails NetworkInterfaceCount
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
        ///  The price protection threshold for On-Demand Instances. This is the maximum you'll
        /// pay for an On-Demand Instance, expressed as a percentage above the least expensive
        /// current generation M, C, or R instance type with your specified attributes. When Amazon
        /// EC2 selects instance types with your attributes, it excludes instance types priced
        /// above your threshold.
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 interprets as a percentage.
        /// </para>
        ///  
        /// <para>
        /// A high value, such as <code>999999</code>, turns off price protection.
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
        ///  Indicates whether instance types must support hibernation for On-Demand Instances.
        /// 
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
        ///  The price protection threshold for Spot Instances. This is the maximum you'll pay
        /// for a Spot Instance, expressed as a percentage above the least expensive current generation
        /// M, C, or R instance type with your specified attributes. When Amazon EC2 selects instance
        /// types with your attributes, it excludes instance types priced above your threshold.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The parameter accepts an integer, which Amazon EC2 interprets as a percentage.
        /// </para>
        ///  
        /// <para>
        /// A high value, such as <code>999999</code>, turns off price protection.
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
        ///  The minimum and maximum amount of total local storage, in GB. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsTotalLocalStorageGBDetails TotalLocalStorageGB
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
        ///  The minimum and maximum number of vCPUs. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsVCpuCountDetails VCpuCount
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