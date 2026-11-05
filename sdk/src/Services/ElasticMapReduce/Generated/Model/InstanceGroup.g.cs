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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This entity represents an instance group, which is a group of instances that have
    /// common purpose. For example, CORE instance group is used for HDFS.
    /// </summary>
    public partial class InstanceGroup
    {
        /// <summary>
        /// Gets and sets the property AutoScalingPolicy. 
        /// <para>
        /// An automatic scaling policy for a core instance group or task instance group in an
        /// Amazon EMR cluster. The automatic scaling policy defines how an instance group dynamically
        /// adds and terminates Amazon EC2 instances in response to the value of a CloudWatch
        /// metric. See PutAutoScalingPolicy.
        /// </para>
        /// </summary>
        public AutoScalingPolicyDescription AutoScalingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingPolicy property is set.
        /// </summary>
        internal bool IsSetAutoScalingPolicy() => this.AutoScalingPolicy != null;

        /// <summary>
        /// Gets and sets the property BidPrice. 
        /// <para>
        /// The bid price for each Amazon EC2 Spot Instance type as defined by <c>InstanceType</c>.
        /// Expressed in USD. If neither <c>BidPrice</c> nor <c>BidPriceAsPercentageOfOnDemandPrice</c>
        /// is provided, <c>BidPriceAsPercentageOfOnDemandPrice</c> defaults to 100%.
        /// </para>
        /// </summary>
        public string BidPrice { get; set; }

        /// <summary>
        /// Checks to see if the BidPrice property is set.
        /// </summary>
        internal bool IsSetBidPrice() => this.BidPrice != null;

        /// <summary>
        /// Gets and sets the property Configurations. <note> 
        /// <para>
        /// Amazon EMR releases 4.x or later.
        /// </para>
        ///  </note> 
        /// <para>
        /// The list of configurations supplied for an Amazon EMR cluster instance group. You
        /// can specify a separate configuration for each instance group (master, core, and task).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> Configurations { get; set; } = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;

        /// <summary>
        /// Checks to see if the Configurations property is set.
        /// </summary>
        internal bool IsSetConfigurations() => this.Configurations != null && (this.Configurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConfigurationsVersion. 
        /// <para>
        /// The version number of the requested configuration specification for this instance
        /// group.
        /// </para>
        /// </summary>
        public long? ConfigurationsVersion { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationsVersion property is set.
        /// </summary>
        internal bool IsSetConfigurationsVersion() => this.ConfigurationsVersion.HasValue;

        /// <summary>
        /// Gets and sets the property CustomAmiId. 
        /// <para>
        /// The custom AMI ID to use for the provisioned instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CustomAmiId { get; set; }

        /// <summary>
        /// Checks to see if the CustomAmiId property is set.
        /// </summary>
        internal bool IsSetCustomAmiId() => this.CustomAmiId != null;

        /// <summary>
        /// Gets and sets the property EbsBlockDevices. 
        /// <para>
        /// The EBS block devices that are mapped to this instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EbsBlockDevice> EbsBlockDevices { get; set; } = AWSConfigs.InitializeCollections ? new List<EbsBlockDevice>() : null;

        /// <summary>
        /// Checks to see if the EbsBlockDevices property is set.
        /// </summary>
        internal bool IsSetEbsBlockDevices() => this.EbsBlockDevices != null && (this.EbsBlockDevices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// If the instance group is EBS-optimized. An Amazon EBS-optimized instance uses an optimized
        /// configuration stack and provides additional, dedicated capacity for Amazon EBS I/O.
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupType. 
        /// <para>
        /// The type of the instance group. Valid values are MASTER, CORE or TASK.
        /// </para>
        /// </summary>
        public InstanceGroupType InstanceGroupType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupType property is set.
        /// </summary>
        internal bool IsSetInstanceGroupType() => this.InstanceGroupType != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type for all instances in the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LastSuccessfullyAppliedConfigurations. 
        /// <para>
        /// A list of configurations that were successfully applied for an instance group last
        /// time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> LastSuccessfullyAppliedConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;

        /// <summary>
        /// Checks to see if the LastSuccessfullyAppliedConfigurations property is set.
        /// </summary>
        internal bool IsSetLastSuccessfullyAppliedConfigurations() => this.LastSuccessfullyAppliedConfigurations != null && (this.LastSuccessfullyAppliedConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastSuccessfullyAppliedConfigurationsVersion. 
        /// <para>
        /// The version number of a configuration specification that was successfully applied
        /// for an instance group last time. 
        /// </para>
        /// </summary>
        public long? LastSuccessfullyAppliedConfigurationsVersion { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfullyAppliedConfigurationsVersion property is set.
        /// </summary>
        internal bool IsSetLastSuccessfullyAppliedConfigurationsVersion() => this.LastSuccessfullyAppliedConfigurationsVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Market. 
        /// <para>
        /// The marketplace to provision instances for this group. Valid values are ON_DEMAND
        /// or SPOT.
        /// </para>
        /// </summary>
        public MarketType Market { get; set; }

        /// <summary>
        /// Checks to see if the Market property is set.
        /// </summary>
        internal bool IsSetMarket() => this.Market != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the instance group.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestedInstanceCount. 
        /// <para>
        /// The target number of instances for the instance group.
        /// </para>
        /// </summary>
        public int? RequestedInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the RequestedInstanceCount property is set.
        /// </summary>
        internal bool IsSetRequestedInstanceCount() => this.RequestedInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property RunningInstanceCount. 
        /// <para>
        /// The number of instances currently running in this instance group.
        /// </para>
        /// </summary>
        public int? RunningInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningInstanceCount property is set.
        /// </summary>
        internal bool IsSetRunningInstanceCount() => this.RunningInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ShrinkPolicy. 
        /// <para>
        /// Policy for customizing shrink operations.
        /// </para>
        /// </summary>
        public ShrinkPolicy ShrinkPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ShrinkPolicy property is set.
        /// </summary>
        internal bool IsSetShrinkPolicy() => this.ShrinkPolicy != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the instance group.
        /// </para>
        /// </summary>
        public InstanceGroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
