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
        private string _instanceRole;
        private string _instanceType;
        private string _market;
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


        /// <summary>
        /// Sets the BidPrice property
        /// </summary>
        /// <param name="bidPrice">The value to set for the BidPrice property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupConfig WithBidPrice(string bidPrice)
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


        /// <summary>
        /// Sets the InstanceCount property
        /// </summary>
        /// <param name="instanceCount">The value to set for the InstanceCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupConfig WithInstanceCount(int instanceCount)
        {
            this._instanceCount = instanceCount;
            return this;
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
        public string InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }


        /// <summary>
        /// Sets the InstanceRole property
        /// </summary>
        /// <param name="instanceRole">The value to set for the InstanceRole property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupConfig WithInstanceRole(string instanceRole)
        {
            this._instanceRole = instanceRole;
            return this;
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


        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceGroupConfig WithInstanceType(string instanceType)
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
        /// Market type of the Amazon EC2 instances used to create a cluster node. 
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
        public InstanceGroupConfig WithMarket(string market)
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
        /// Friendly name given to the instance group.
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
        public InstanceGroupConfig WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}