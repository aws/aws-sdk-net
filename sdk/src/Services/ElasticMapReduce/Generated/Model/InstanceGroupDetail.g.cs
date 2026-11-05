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
    /// Detailed information about an instance group.
    /// </summary>
    public partial class InstanceGroupDetail
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public InstanceGroupDetail() { }

        /// <summary>
        /// Instantiates InstanceGroupDetail with the parameterized properties
        /// </summary>
        /// <param name="instanceRole">Instance group role in the cluster</param>
        /// <param name="instanceType">Amazon EC2 instance type.</param>
        /// <param name="instanceRequestCount">Target number of instances to run in the instance group.</param>
        /// <param name="instanceRunningCount">Actual count of running instances.</param>
        /// <param name="state">State of instance group. The following values are no longer supported: STARTING,   TERMINATED, and FAILED.</param>
        /// <param name="creationDateTime">The date/time the instance group was created.</param>
        public InstanceGroupDetail(InstanceRoleType instanceRole, string instanceType, int? instanceRequestCount, int? instanceRunningCount, InstanceGroupState state, DateTime? creationDateTime)
        {
            this.InstanceRole = instanceRole;
            this.InstanceType = instanceType;
            this.InstanceRequestCount = instanceRequestCount;
            this.InstanceRunningCount = instanceRunningCount;
            this.State = state;
            this.CreationDateTime = creationDateTime;
        }

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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date/time the instance group was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

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
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date/time the instance group was terminated.
        /// </para>
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EndDateTime property is set.
        /// </summary>
        internal bool IsSetEndDateTime() => this.EndDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// Unique identifier for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupId property is set.
        /// </summary>
        internal bool IsSetInstanceGroupId() => this.InstanceGroupId != null;

        /// <summary>
        /// Gets and sets the property InstanceRequestCount. 
        /// <para>
        /// Target number of instances to run in the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? InstanceRequestCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequestCount property is set.
        /// </summary>
        internal bool IsSetInstanceRequestCount() => this.InstanceRequestCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// Instance group role in the cluster
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceRoleType InstanceRole { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRole property is set.
        /// </summary>
        internal bool IsSetInstanceRole() => this.InstanceRole != null;

        /// <summary>
        /// Gets and sets the property InstanceRunningCount. 
        /// <para>
        /// Actual count of running instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? InstanceRunningCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRunningCount property is set.
        /// </summary>
        internal bool IsSetInstanceRunningCount() => this.InstanceRunningCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Amazon EC2 instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LastStateChangeReason. 
        /// <para>
        /// Details regarding the state of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string LastStateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the LastStateChangeReason property is set.
        /// </summary>
        internal bool IsSetLastStateChangeReason() => this.LastStateChangeReason != null;

        /// <summary>
        /// Gets and sets the property Market. 
        /// <para>
        /// Market type of the Amazon EC2 instances used to create a cluster node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MarketType Market { get; set; }

        /// <summary>
        /// Checks to see if the Market property is set.
        /// </summary>
        internal bool IsSetMarket() => this.Market != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Friendly name for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReadyDateTime. 
        /// <para>
        /// The date/time the instance group was available to the cluster.
        /// </para>
        /// </summary>
        public DateTime? ReadyDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ReadyDateTime property is set.
        /// </summary>
        internal bool IsSetReadyDateTime() => this.ReadyDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date/time the instance group was started.
        /// </para>
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartDateTime property is set.
        /// </summary>
        internal bool IsSetStartDateTime() => this.StartDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of instance group. The following values are no longer supported: STARTING, TERMINATED,
        /// and FAILED.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceGroupState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
