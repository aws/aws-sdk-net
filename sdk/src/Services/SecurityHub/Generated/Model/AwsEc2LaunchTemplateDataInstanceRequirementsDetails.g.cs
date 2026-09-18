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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The attributes for the Amazon EC2 instance types.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataInstanceRequirementsDetails
    {
        /// <summary>
        /// Gets and sets the property AcceleratorCount. 
        /// <para>
        ///  The minimum and maximum number of accelerators (GPUs, FPGAs, or Amazon Web Services
        /// Inferentia chips) on an instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorCountDetails AcceleratorCount { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorCount property is set.
        /// </summary>
        internal bool IsSetAcceleratorCount() => this.AcceleratorCount != null;

        /// <summary>
        /// Gets and sets the property AcceleratorManufacturers. 
        /// <para>
        /// Indicates whether instance types must have accelerators by specific manufacturers.
        /// 
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
        ///  The accelerators that must be on the instance type. 
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
        ///  The minimum and maximum amount of total accelerator memory, in MiB. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorTotalMemoryMiBDetails AcceleratorTotalMemoryMiB { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorTotalMemoryMiB property is set.
        /// </summary>
        internal bool IsSetAcceleratorTotalMemoryMiB() => this.AcceleratorTotalMemoryMiB != null;

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        /// The accelerator types that must be on the instance type. 
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
        /// Gets and sets the property BareMetal. 
        /// <para>
        /// Indicates whether bare metal instance types must be included, excluded, or required.
        /// 
        /// </para>
        /// </summary>
        public string BareMetal { get; set; }

        /// <summary>
        /// Checks to see if the BareMetal property is set.
        /// </summary>
        internal bool IsSetBareMetal() => this.BareMetal != null;

        /// <summary>
        /// Gets and sets the property BaselineEbsBandwidthMbps. 
        /// <para>
        ///  The minimum and maximum baseline bandwidth to Amazon EBS, in Mbps. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-optimized.html">Amazon
        /// EBS optimized instances</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsBaselineEbsBandwidthMbpsDetails BaselineEbsBandwidthMbps { get; set; }

        /// <summary>
        /// Checks to see if the BaselineEbsBandwidthMbps property is set.
        /// </summary>
        internal bool IsSetBaselineEbsBandwidthMbps() => this.BaselineEbsBandwidthMbps != null;

        /// <summary>
        /// Gets and sets the property BurstablePerformance. 
        /// <para>
        ///  Indicates whether burstable performance T instance types are included, excluded,
        /// or required. For more information, <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        public string BurstablePerformance { get; set; }

        /// <summary>
        /// Checks to see if the BurstablePerformance property is set.
        /// </summary>
        internal bool IsSetBurstablePerformance() => this.BurstablePerformance != null;

        /// <summary>
        /// Gets and sets the property CpuManufacturers. 
        /// <para>
        ///  The CPU manufacturers to include. 
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
        ///  The instance types to exclude. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludedInstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedInstanceTypes property is set.
        /// </summary>
        internal bool IsSetExcludedInstanceTypes() => this.ExcludedInstanceTypes != null && (this.ExcludedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceGenerations. 
        /// <para>
        ///  Indicates whether current or previous generation instance types are included. 
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
        ///  Indicates whether instance types with instance store volumes are included, excluded,
        /// or required. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
        /// EC2 instance store</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        public string LocalStorage { get; set; }

        /// <summary>
        /// Checks to see if the LocalStorage property is set.
        /// </summary>
        internal bool IsSetLocalStorage() => this.LocalStorage != null;

        /// <summary>
        /// Gets and sets the property LocalStorageTypes. 
        /// <para>
        ///  The type of local storage that is required. 
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
        /// Gets and sets the property MemoryGiBPerVCpu. 
        /// <para>
        ///  The minimum and maximum amount of memory per vCPU, in GiB. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetails MemoryGiBPerVCpu { get; set; }

        /// <summary>
        /// Checks to see if the MemoryGiBPerVCpu property is set.
        /// </summary>
        internal bool IsSetMemoryGiBPerVCpu() => this.MemoryGiBPerVCpu != null;

        /// <summary>
        /// Gets and sets the property MemoryMiB. 
        /// <para>
        ///  The minimum and maximum amount of memory, in MiB. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsMemoryMiBDetails MemoryMiB { get; set; }

        /// <summary>
        /// Checks to see if the MemoryMiB property is set.
        /// </summary>
        internal bool IsSetMemoryMiB() => this.MemoryMiB != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceCount. 
        /// <para>
        ///  The minimum and maximum number of network interfaces. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsNetworkInterfaceCountDetails NetworkInterfaceCount { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceCount property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceCount() => this.NetworkInterfaceCount != null;

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
        /// A high value, such as <c>999999</c>, turns off price protection.
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
        ///  Indicates whether instance types must support hibernation for On-Demand Instances.
        /// 
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
        /// A high value, such as <c>999999</c>, turns off price protection.
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
        ///  The minimum and maximum amount of total local storage, in GB. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsTotalLocalStorageGBDetails TotalLocalStorageGB { get; set; }

        /// <summary>
        /// Checks to see if the TotalLocalStorageGB property is set.
        /// </summary>
        internal bool IsSetTotalLocalStorageGB() => this.TotalLocalStorageGB != null;

        /// <summary>
        /// Gets and sets the property VCpuCount. 
        /// <para>
        ///  The minimum and maximum number of vCPUs. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsVCpuCountDetails VCpuCount { get; set; }

        /// <summary>
        /// Checks to see if the VCpuCount property is set.
        /// </summary>
        internal bool IsSetVCpuCount() => this.VCpuCount != null;
    }
}
