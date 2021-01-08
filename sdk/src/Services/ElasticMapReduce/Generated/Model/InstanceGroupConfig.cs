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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Configuration defining a new instance group.
    /// </summary>
    public partial class InstanceGroupConfig
    {
        private AutoScalingPolicy _autoScalingPolicy;
        private string _bidPrice;
        private List<Configuration> _configurations = new List<Configuration>();
        private EbsConfiguration _ebsConfiguration;
        private int? _instanceCount;
        private InstanceRoleType _instanceRole;
        private string _instanceType;
        private MarketType _market;
        private string _name;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public InstanceGroupConfig() { }

        /// <summary>
        /// Instantiates InstanceGroupConfig with the parameterized properties
        /// </summary>
        /// <param name="instanceRole">The role of the instance group in the cluster.</param>
        /// <param name="instanceType">The EC2 instance type for all instances in the instance group.</param>
        /// <param name="instanceCount">Target number of instances for the instance group.</param>
        public InstanceGroupConfig(InstanceRoleType instanceRole, string instanceType, int instanceCount)
        {
            _instanceRole = instanceRole;
            _instanceType = instanceType;
            _instanceCount = instanceCount;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingPolicy. 
        /// <para>
        /// An automatic scaling policy for a core instance group or task instance group in an
        /// Amazon EMR cluster. The automatic scaling policy defines how an instance group dynamically
        /// adds and terminates EC2 instances in response to the value of a CloudWatch metric.
        /// See <a>PutAutoScalingPolicy</a>.
        /// </para>
        /// </summary>
        public AutoScalingPolicy AutoScalingPolicy
        {
            get { return this._autoScalingPolicy; }
            set { this._autoScalingPolicy = value; }
        }

        // Check to see if AutoScalingPolicy property is set
        internal bool IsSetAutoScalingPolicy()
        {
            return this._autoScalingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property BidPrice. 
        /// <para>
        /// The bid price for each EC2 Spot Instance type as defined by <code>InstanceType</code>.
        /// Expressed in USD. If neither <code>BidPrice</code> nor <code>BidPriceAsPercentageOfOnDemandPrice</code>
        /// is provided, <code>BidPriceAsPercentageOfOnDemandPrice</code> defaults to 100%.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string BidPrice
        {
            get { return this._bidPrice; }
            set { this._bidPrice = value; }
        }

        // Check to see if BidPrice property is set
        internal bool IsSetBidPrice()
        {
            return this._bidPrice != null;
        }

        /// <summary>
        /// Gets and sets the property Configurations. <note> 
        /// <para>
        /// Amazon EMR releases 4.x or later.
        /// </para>
        ///  </note> 
        /// <para>
        /// The list of configurations supplied for an EMR cluster instance group. You can specify
        /// a separate configuration for each instance group (master, core, and task).
        /// </para>
        /// </summary>
        public List<Configuration> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && this._configurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EbsConfiguration. 
        /// <para>
        /// EBS configurations that will be attached to each EC2 instance in the instance group.
        /// </para>
        /// </summary>
        public EbsConfiguration EbsConfiguration
        {
            get { return this._ebsConfiguration; }
            set { this._ebsConfiguration = value; }
        }

        // Check to see if EbsConfiguration property is set
        internal bool IsSetEbsConfiguration()
        {
            return this._ebsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Target number of instances for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// The role of the instance group in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceRoleType InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this._instanceRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The EC2 instance type for all instances in the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Market. 
        /// <para>
        /// Market type of the EC2 instances used to create a cluster node.
        /// </para>
        /// </summary>
        public MarketType Market
        {
            get { return this._market; }
            set { this._market = value; }
        }

        // Check to see if Market property is set
        internal bool IsSetMarket()
        {
            return this._market != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Friendly name given to the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}