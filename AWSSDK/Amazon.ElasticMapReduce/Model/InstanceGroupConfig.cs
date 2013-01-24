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
    /// <para>Configuration defining a new instance group.</para>
    /// </summary>
    public class InstanceGroupConfig
    {
        
        private string name;
        private string market;
        private string instanceRole;
        private string bidPrice;
        private string instanceType;
        private int? instanceCount;

        /// <summary>
        /// Friendly name given to the instance group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public InstanceGroupConfig WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// Market type of the Amazon EC2 instances used to create a cluster node.
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
        public string Market
        {
            get { return this.market; }
            set { this.market = value; }
        }

        /// <summary>
        /// Sets the Market property
        /// </summary>
        /// <param name="market">The value to set for the Market property </param>
        /// <returns>this instance</returns>
        public InstanceGroupConfig WithMarket(string market)
        {
            this.market = market;
            return this;
        }
            

        // Check to see if Market property is set
        internal bool IsSetMarket()
        {
            return this.market != null;
        }

        /// <summary>
        /// The role of the instance group in the cluster.
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
        public string InstanceRole
        {
            get { return this.instanceRole; }
            set { this.instanceRole = value; }
        }

        /// <summary>
        /// Sets the InstanceRole property
        /// </summary>
        /// <param name="instanceRole">The value to set for the InstanceRole property </param>
        /// <returns>this instance</returns>
        public InstanceGroupConfig WithInstanceRole(string instanceRole)
        {
            this.instanceRole = instanceRole;
            return this;
        }
            

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this.instanceRole != null;
        }

        /// <summary>
        /// Bid price for each Amazon EC2 instance in the instance group when launching nodes as Spot Instances, expressed in USD.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string BidPrice
        {
            get { return this.bidPrice; }
            set { this.bidPrice = value; }
        }

        /// <summary>
        /// Sets the BidPrice property
        /// </summary>
        /// <param name="bidPrice">The value to set for the BidPrice property </param>
        /// <returns>this instance</returns>
        public InstanceGroupConfig WithBidPrice(string bidPrice)
        {
            this.bidPrice = bidPrice;
            return this;
        }
            

        // Check to see if BidPrice property is set
        internal bool IsSetBidPrice()
        {
            return this.bidPrice != null;
        }

        /// <summary>
        /// The Amazon EC2 instance type for all instances in the instance group.
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

        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        public InstanceGroupConfig WithInstanceType(string instanceType)
        {
            this.instanceType = instanceType;
            return this;
        }
            

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// Target number of instances for the instance group.
        ///  
        /// </summary>
        public int InstanceCount
        {
            get { return this.instanceCount ?? default(int); }
            set { this.instanceCount = value; }
        }

        /// <summary>
        /// Sets the InstanceCount property
        /// </summary>
        /// <param name="instanceCount">The value to set for the InstanceCount property </param>
        /// <returns>this instance</returns>
        public InstanceGroupConfig WithInstanceCount(int instanceCount)
        {
            this.instanceCount = instanceCount;
            return this;
        }
            

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this.instanceCount.HasValue;
        }
    }
}
