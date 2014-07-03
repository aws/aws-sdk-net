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
    /// Configuration defining a new instance group.
    /// </summary>
    public partial class InstanceGroupConfig
    {
        private string _bidPrice;
        private int? _instanceCount;
        private InstanceRoleType _instanceRole;
        private string _instanceType;
        private MarketType _market;
        private string _name;


        /// <summary>
        /// Gets and sets the property BidPrice. 
        /// <para>
        /// Bid price for each Amazon EC2 instance in the         instance group when launching
        /// nodes as Spot Instances, expressed in USD.
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
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Target number of instances for the instance group. 
        /// </para>
        /// </summary>
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
        /// The Amazon EC2 instance type for all instances in the instance group. 
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
        /// Market type of the Amazon EC2 instances used to create a cluster node. 
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