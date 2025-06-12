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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes a recommendation option for an Amazon EC2 instance.
    /// </summary>
    public partial class InstanceRecommendationOption
    {
        private GpuInfo _instanceGpuInfo;
        private string _instanceType;
        private MigrationEffort _migrationEffort;
        private double? _performanceRisk;
        private List<string> _platformDifferences = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<UtilizationMetric> _projectedUtilizationMetrics = AWSConfigs.InitializeCollections ? new List<UtilizationMetric>() : null;
        private int? _rank;
        private SavingsOpportunity _savingsOpportunity;
        private InstanceSavingsOpportunityAfterDiscounts _savingsOpportunityAfterDiscounts;

        /// <summary>
        /// Gets and sets the property InstanceGpuInfo. 
        /// <para>
        ///  Describes the GPU accelerator settings for the recommended instance type. 
        /// </para>
        /// </summary>
        public GpuInfo InstanceGpuInfo
        {
            get { return this._instanceGpuInfo; }
            set { this._instanceGpuInfo = value; }
        }

        // Check to see if InstanceGpuInfo property is set
        internal bool IsSetInstanceGpuInfo()
        {
            return this._instanceGpuInfo != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the instance recommendation.
        /// </para>
        /// </summary>
        public string InstanceType
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
        /// Gets and sets the property MigrationEffort. 
        /// <para>
        /// The level of effort required to migrate from the current instance type to the recommended
        /// instance type.
        /// </para>
        ///  
        /// <para>
        /// For example, the migration effort is <c>Low</c> if Amazon EMR is the inferred workload
        /// type and an Amazon Web Services Graviton instance type is recommended. The migration
        /// effort is <c>Medium</c> if a workload type couldn't be inferred but an Amazon Web
        /// Services Graviton instance type is recommended. The migration effort is <c>VeryLow</c>
        /// if both the current and recommended instance types are of the same CPU architecture.
        /// </para>
        /// </summary>
        public MigrationEffort MigrationEffort
        {
            get { return this._migrationEffort; }
            set { this._migrationEffort = value; }
        }

        // Check to see if MigrationEffort property is set
        internal bool IsSetMigrationEffort()
        {
            return this._migrationEffort != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceRisk. 
        /// <para>
        /// The performance risk of the instance recommendation option.
        /// </para>
        ///  
        /// <para>
        /// Performance risk indicates the likelihood of the recommended instance type not meeting
        /// the resource needs of your workload. Compute Optimizer calculates an individual performance
        /// risk score for each specification of the recommended instance, including CPU, memory,
        /// EBS throughput, EBS IOPS, disk throughput, disk IOPS, network throughput, and network
        /// PPS. The performance risk of the recommended instance is calculated as the maximum
        /// performance risk score across the analyzed resource specifications.
        /// </para>
        ///  
        /// <para>
        /// The value ranges from <c>0</c> - <c>4</c>, with <c>0</c> meaning that the recommended
        /// resource is predicted to always provide enough hardware capability. The higher the
        /// performance risk is, the more likely you should validate whether the recommendation
        /// will meet the performance requirements of your workload before migrating your resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4)]
        public double? PerformanceRisk
        {
            get { return this._performanceRisk; }
            set { this._performanceRisk = value; }
        }

        // Check to see if PerformanceRisk property is set
        internal bool IsSetPerformanceRisk()
        {
            return this._performanceRisk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlatformDifferences. 
        /// <para>
        /// Describes the configuration differences between the current instance and the recommended
        /// instance type. You should consider the configuration differences before migrating
        /// your workloads from the current instance to the recommended instance type. The <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-resize.html">Change
        /// the instance type guide for Linux</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ec2-instance-resize.html">Change
        /// the instance type guide for Windows</a> provide general guidance for getting started
        /// with an instance migration.
        /// </para>
        ///  
        /// <para>
        /// Platform differences include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Hypervisor</c> </b> — The hypervisor of the recommended instance type is different
        /// than that of the current instance. For example, the recommended instance type uses
        /// a Nitro hypervisor and the current instance uses a Xen hypervisor. The differences
        /// that you should consider between these hypervisors are covered in the <a href="http://aws.amazon.com/ec2/faqs/#Nitro_Hypervisor">Nitro
        /// Hypervisor</a> section of the Amazon EC2 frequently asked questions. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">Instances
        /// built on the Nitro System</a> in the <i>Amazon EC2 User Guide for Linux</i>, or <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/instance-types.html#ec2-nitro-instances">Instances
        /// built on the Nitro System</a> in the <i>Amazon EC2 User Guide for Windows</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NetworkInterface</c> </b> — The network interface of the recommended instance
        /// type is different than that of the current instance. For example, the recommended
        /// instance type supports enhanced networking and the current instance might not. To
        /// enable enhanced networking for the recommended instance type, you must install the
        /// Elastic Network Adapter (ENA) driver or the Intel 82599 Virtual Function driver. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#instance-networking-storage">Networking
        /// and storage features</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/enhanced-networking.html">Enhanced
        /// networking on Linux</a> in the <i>Amazon EC2 User Guide for Linux</i>, or <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/instance-types.html#instance-networking-storage">Networking
        /// and storage features</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/enhanced-networking.html">Enhanced
        /// networking on Windows</a> in the <i>Amazon EC2 User Guide for Windows</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>StorageInterface</c> </b> — The storage interface of the recommended instance
        /// type is different than that of the current instance. For example, the recommended
        /// instance type uses an NVMe storage interface and the current instance does not. To
        /// access NVMe volumes for the recommended instance type, you will need to install or
        /// upgrade the NVMe driver. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#instance-networking-storage">Networking
        /// and storage features</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nvme-ebs-volumes.html">Amazon
        /// EBS and NVMe on Linux instances</a> in the <i>Amazon EC2 User Guide for Linux</i>,
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/instance-types.html#instance-networking-storage">Networking
        /// and storage features</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/nvme-ebs-volumes.html">Amazon
        /// EBS and NVMe on Windows instances</a> in the <i>Amazon EC2 User Guide for Windows</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>InstanceStoreAvailability</c> </b> — The recommended instance type does not
        /// support instance store volumes and the current instance does. Before migrating, you
        /// might need to back up the data on your instance store volumes if you want to preserve
        /// them. For more information, see <a href="https://aws.amazon.com/premiumsupport/knowledge-center/back-up-instance-store-ebs/">How
        /// do I back up an instance store volume on my Amazon EC2 instance to Amazon EBS?</a>
        /// in the <i>Amazon Web Services Premium Support Knowledge Base</i>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#instance-networking-storage">Networking
        /// and storage features</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
        /// EC2 instance store</a> in the <i>Amazon EC2 User Guide for Linux</i>, or see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/instance-types.html#instance-networking-storage">Networking
        /// and storage features</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/InstanceStorage.html">Amazon
        /// EC2 instance store</a> in the <i>Amazon EC2 User Guide for Windows</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>VirtualizationType</c> </b> — The recommended instance type uses the hardware
        /// virtual machine (HVM) virtualization type and the current instance uses the paravirtual
        /// (PV) virtualization type. For more information about the differences between these
        /// virtualization types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/virtualization_types.html">Linux
        /// AMI virtualization types</a> in the <i>Amazon EC2 User Guide for Linux</i>, or <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/windows-ami-version-history.html#virtualization-types">Windows
        /// AMI virtualization types</a> in the <i>Amazon EC2 User Guide for Windows</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Architecture</c> </b> — The CPU architecture between the recommended instance
        /// type and the current instance is different. For example, the recommended instance
        /// type might use an Arm CPU architecture and the current instance type might use a different
        /// one, such as x86. Before migrating, you should consider recompiling the software on
        /// your instance for the new architecture. Alternatively, you might switch to an Amazon
        /// Machine Image (AMI) that supports the new architecture. For more information about
        /// the CPU architecture for each instance type, see <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PlatformDifferences
        {
            get { return this._platformDifferences; }
            set { this._platformDifferences = value; }
        }

        // Check to see if PlatformDifferences property is set
        internal bool IsSetPlatformDifferences()
        {
            return this._platformDifferences != null && (this._platformDifferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProjectedUtilizationMetrics. 
        /// <para>
        /// An array of objects that describe the projected utilization metrics of the instance
        /// recommendation option.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Cpu</c> and <c>Memory</c> metrics are the only projected utilization metrics
        /// returned. Additionally, the <c>Memory</c> metric is returned only for resources that
        /// have the unified CloudWatch agent installed on them. For more information, see <a
        /// href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// Memory Utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UtilizationMetric> ProjectedUtilizationMetrics
        {
            get { return this._projectedUtilizationMetrics; }
            set { this._projectedUtilizationMetrics = value; }
        }

        // Check to see if ProjectedUtilizationMetrics property is set
        internal bool IsSetProjectedUtilizationMetrics()
        {
            return this._projectedUtilizationMetrics != null && (this._projectedUtilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        /// The rank of the instance recommendation option.
        /// </para>
        ///  
        /// <para>
        /// The top recommendation option is ranked as <c>1</c>.
        /// </para>
        /// </summary>
        public int? Rank
        {
            get { return this._rank; }
            set { this._rank = value; }
        }

        // Check to see if Rank property is set
        internal bool IsSetRank()
        {
            return this._rank.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SavingsOpportunity. 
        /// <para>
        /// An object that describes the savings opportunity for the instance recommendation option.
        /// Savings opportunity includes the estimated monthly savings amount and percentage.
        /// </para>
        /// </summary>
        public SavingsOpportunity SavingsOpportunity
        {
            get { return this._savingsOpportunity; }
            set { this._savingsOpportunity = value; }
        }

        // Check to see if SavingsOpportunity property is set
        internal bool IsSetSavingsOpportunity()
        {
            return this._savingsOpportunity != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsOpportunityAfterDiscounts. 
        /// <para>
        ///  An object that describes the savings opportunity for the instance recommendation
        /// option that includes Savings Plans and Reserved Instances discounts. Savings opportunity
        /// includes the estimated monthly savings and percentage. 
        /// </para>
        /// </summary>
        public InstanceSavingsOpportunityAfterDiscounts SavingsOpportunityAfterDiscounts
        {
            get { return this._savingsOpportunityAfterDiscounts; }
            set { this._savingsOpportunityAfterDiscounts = value; }
        }

        // Check to see if SavingsOpportunityAfterDiscounts property is set
        internal bool IsSetSavingsOpportunityAfterDiscounts()
        {
            return this._savingsOpportunityAfterDiscounts != null;
        }

    }
}