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
        private string _instanceGroupType;
        private string _instanceType;
        private string _market;
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


        /// <summary>
        /// Sets the BidPrice property
        /// </summary>
        /// <param name="bidPrice">The value to set for the BidPrice property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroup WithBidPrice(string bidPrice)
        {
            this._bidPrice = bidPrice;
            return this;
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


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroup WithId(string id)
        {
            this._id = id;
            return this;
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
        public string InstanceGroupType
        {
            get { return this._instanceGroupType; }
            set { this._instanceGroupType = value; }
        }


        /// <summary>
        /// Sets the InstanceGroupType property
        /// </summary>
        /// <param name="instanceGroupType">The value to set for the InstanceGroupType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroup WithInstanceGroupType(string instanceGroupType)
        {
            this._instanceGroupType = instanceGroupType;
            return this;
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


        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroup WithInstanceType(string instanceType)
        {
            this._instanceType = instanceType;
            return this;
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
        public string Market
        {
            get { return this._market; }
            set { this._market = value; }
        }


        /// <summary>
        /// Sets the Market property
        /// </summary>
        /// <param name="market">The value to set for the Market property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroup WithMarket(string market)
        {
            this._market = market;
            return this;
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


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroup WithName(string name)
        {
            this._name = name;
            return this;
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


        /// <summary>
        /// Sets the RequestedInstanceCount property
        /// </summary>
        /// <param name="requestedInstanceCount">The value to set for the RequestedInstanceCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroup WithRequestedInstanceCount(int requestedInstanceCount)
        {
            this._requestedInstanceCount = requestedInstanceCount;
            return this;
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


        /// <summary>
        /// Sets the RunningInstanceCount property
        /// </summary>
        /// <param name="runningInstanceCount">The value to set for the RunningInstanceCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroup WithRunningInstanceCount(int runningInstanceCount)
        {
            this._runningInstanceCount = runningInstanceCount;
            return this;
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


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroup WithStatus(InstanceGroupStatus status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}