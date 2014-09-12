/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This entity represents an instance group, which is a group of instances that have
    /// common purpose. For example, CORE instance group is used for HDFS.
    /// </summary>
    public partial class InstanceGroup
    {
        private string _bidPrice;
        private string _id;
        private InstanceGroupType _instanceGroupType;
        private string _instanceType;
        private MarketType _market;
        private string _name;
        private int? _requestedInstanceCount;
        private int? _runningInstanceCount;
        private InstanceGroupStatus _status;

        /// <summary>
        /// Gets and sets the property BidPrice. 
        /// <para>
        /// The bid price for each EC2 instance in the         instance group when launching nodes
        /// as Spot Instances, expressed in USD.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the instance group.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupType. 
        /// <para>
        /// The type of the instance group. Valid values are MASTER, CORE or TASK.
        /// </para>
        /// </summary>
        public InstanceGroupType InstanceGroupType
        {
            get { return this._instanceGroupType; }
            set { this._instanceGroupType = value; }
        }

        // Check to see if InstanceGroupType property is set
        internal bool IsSetInstanceGroupType()
        {
            return this._instanceGroupType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The EC2 instance type for all instances in the instance group. 
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
        /// Gets and sets the property Market. 
        /// <para>
        /// The marketplace to provision instances for this group. Valid values are ON_DEMAND
        /// or SPOT.
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
        /// The name of the instance group.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property RequestedInstanceCount. 
        /// <para>
        /// The target number of instances for the instance group. 
        /// </para>
        /// </summary>
        public int RequestedInstanceCount
        {
            get { return this._requestedInstanceCount.GetValueOrDefault(); }
            set { this._requestedInstanceCount = value; }
        }

        // Check to see if RequestedInstanceCount property is set
        internal bool IsSetRequestedInstanceCount()
        {
            return this._requestedInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningInstanceCount. 
        /// <para>
        /// The number of instances currently running in this instance group.
        /// </para>
        /// </summary>
        public int RunningInstanceCount
        {
            get { return this._runningInstanceCount.GetValueOrDefault(); }
            set { this._runningInstanceCount = value; }
        }

        // Check to see if RunningInstanceCount property is set
        internal bool IsSetRunningInstanceCount()
        {
            return this._runningInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the instance group.
        /// </para>
        /// </summary>
        public InstanceGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}