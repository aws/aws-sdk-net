/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>This entity represents an instance group, which is a group of instances that have common purpose. For example, CORE instance group is
    /// used for HDFS.</para>
    /// </summary>
    public class InstanceGroup
    {
        
        private string id;
        private string name;
        private MarketType market;
        private InstanceGroupType instanceGroupType;
        private string bidPrice;
        private string instanceType;
        private int? requestedInstanceCount;
        private int? runningInstanceCount;
        private InstanceGroupStatus status;


        /// <summary>
        /// The identifier of the instance group.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The name of the instance group.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The marketplace to provision instances for this group. Valid values are ON_DEMAND or SPOT.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ON_DEMAND, SPOT</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public MarketType Market
        {
            get { return this.market; }
            set { this.market = value; }
        }

        // Check to see if Market property is set
        internal bool IsSetMarket()
        {
            return this.market != null;
        }

        /// <summary>
        /// The type of the instance group. Valid values are MASTER, CORE or TASK.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>MASTER, CORE, TASK</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceGroupType InstanceGroupType
        {
            get { return this.instanceGroupType; }
            set { this.instanceGroupType = value; }
        }

        // Check to see if InstanceGroupType property is set
        internal bool IsSetInstanceGroupType()
        {
            return this.instanceGroupType != null;
        }

        /// <summary>
        /// The bid price for each EC2 instance in the instance group when launching nodes as Spot Instances, expressed in USD.
        ///  
        /// </summary>
        public string BidPrice
        {
            get { return this.bidPrice; }
            set { this.bidPrice = value; }
        }

        // Check to see if BidPrice property is set
        internal bool IsSetBidPrice()
        {
            return this.bidPrice != null;
        }

        /// <summary>
        /// The EC2 instance type for all instances in the instance group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// The target number of instances for the instance group.
        ///  
        /// </summary>
        public int RequestedInstanceCount
        {
            get { return this.requestedInstanceCount ?? default(int); }
            set { this.requestedInstanceCount = value; }
        }

        // Check to see if RequestedInstanceCount property is set
        internal bool IsSetRequestedInstanceCount()
        {
            return this.requestedInstanceCount.HasValue;
        }

        /// <summary>
        /// The number of instances currently running in this instance group.
        ///  
        /// </summary>
        public int RunningInstanceCount
        {
            get { return this.runningInstanceCount ?? default(int); }
            set { this.runningInstanceCount = value; }
        }

        // Check to see if RunningInstanceCount property is set
        internal bool IsSetRunningInstanceCount()
        {
            return this.runningInstanceCount.HasValue;
        }

        /// <summary>
        /// The current status of the instance group.
        ///  
        /// </summary>
        public InstanceGroupStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}
