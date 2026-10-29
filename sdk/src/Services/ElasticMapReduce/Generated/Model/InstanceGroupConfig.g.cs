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
    /// Configuration defining a new instance group.
    /// </summary>
    public partial class InstanceGroupConfig
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public InstanceGroupConfig() { }

        /// <summary>
        /// Instantiates InstanceGroupConfig with the parameterized properties
        /// </summary>
        /// <param name="instanceRole">The role of the instance group in the cluster.</param>
        /// <param name="instanceType">The Amazon EC2 instance type for all instances in the instance group.</param>
        /// <param name="instanceCount">Target number of instances for the instance group.</param>
        public InstanceGroupConfig(InstanceRoleType instanceRole, string instanceType, int? instanceCount)
        {
            this.InstanceRole = instanceRole;
            this.InstanceType = instanceType;
            this.InstanceCount = instanceCount;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingPolicy. 
        /// <para>
        /// An automatic scaling policy for a core instance group or task instance group in an
        /// Amazon EMR cluster. The automatic scaling policy defines how an instance group dynamically
        /// adds and terminates Amazon EC2 instances in response to the value of a CloudWatch
        /// metric. See <a>PutAutoScalingPolicy</a>.
        /// </para>
        /// </summary>
        public AutoScalingPolicy AutoScalingPolicy { get; set; }

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
        [AWSProperty(Min = 0, Max = 256)]
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
        /// Gets and sets the property EbsConfiguration. 
        /// <para>
        /// EBS configurations that will be attached to each Amazon EC2 instance in the instance
        /// group.
        /// </para>
        /// </summary>
        public EbsConfiguration EbsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EbsConfiguration property is set.
        /// </summary>
        internal bool IsSetEbsConfiguration() => this.EbsConfiguration != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Target number of instances for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// The role of the instance group in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceRoleType InstanceRole { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRole property is set.
        /// </summary>
        internal bool IsSetInstanceRole() => this.InstanceRole != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type for all instances in the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Market. 
        /// <para>
        /// Market type of the Amazon EC2 instances used to create a cluster node.
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
        /// Friendly name given to the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
