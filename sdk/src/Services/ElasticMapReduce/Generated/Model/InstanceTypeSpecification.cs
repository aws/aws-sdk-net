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
    /// The configuration specification for each instance type in an instance fleet.
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InstanceTypeSpecification
    {
        private string _bidPrice;
        private double? _bidPriceAsPercentageOfOnDemandPrice;
        private List<Configuration> _configurations = new List<Configuration>();
        private List<EbsBlockDevice> _ebsBlockDevices = new List<EbsBlockDevice>();
        private bool? _ebsOptimized;
        private string _instanceType;
        private int? _weightedCapacity;

        /// <summary>
        /// Gets and sets the property BidPrice. 
        /// <para>
        /// The bid price for each EC2 Spot instance type as defined by <code>InstanceType</code>.
        /// Expressed in USD.
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
        /// Gets and sets the property BidPriceAsPercentageOfOnDemandPrice. 
        /// <para>
        /// The bid price, as a percentage of On-Demand price, for each EC2 Spot instance as defined
        /// by <code>InstanceType</code>. Expressed as a number (for example, 20 specifies 20%).
        /// </para>
        /// </summary>
        public double BidPriceAsPercentageOfOnDemandPrice
        {
            get { return this._bidPriceAsPercentageOfOnDemandPrice.GetValueOrDefault(); }
            set { this._bidPriceAsPercentageOfOnDemandPrice = value; }
        }

        // Check to see if BidPriceAsPercentageOfOnDemandPrice property is set
        internal bool IsSetBidPriceAsPercentageOfOnDemandPrice()
        {
            return this._bidPriceAsPercentageOfOnDemandPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// A configuration classification that applies when provisioning cluster instances, which
        /// can include configurations for applications and software bundled with Amazon EMR.
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
        /// Gets and sets the property EbsBlockDevices. 
        /// <para>
        /// The configuration of Amazon Elastic Block Storage (EBS) attached to each instance
        /// as defined by <code>InstanceType</code>.
        /// </para>
        /// </summary>
        public List<EbsBlockDevice> EbsBlockDevices
        {
            get { return this._ebsBlockDevices; }
            set { this._ebsBlockDevices = value; }
        }

        // Check to see if EbsBlockDevices property is set
        internal bool IsSetEbsBlockDevices()
        {
            return this._ebsBlockDevices != null && this._ebsBlockDevices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Evaluates to <code>TRUE</code> when the specified <code>InstanceType</code> is EBS-optimized.
        /// </para>
        /// </summary>
        public bool EbsOptimized
        {
            get { return this._ebsOptimized.GetValueOrDefault(); }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The EC2 instance type, for example <code>m3.xlarge</code>.
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
        /// Gets and sets the property WeightedCapacity. 
        /// <para>
        /// The number of units that a provisioned instance of this type provides toward fulfilling
        /// the target capacities defined in <a>InstanceFleetConfig</a>. Capacity values represent
        /// performance characteristics such as vCPUs, memory, or I/O. If not specified, the default
        /// value is 1.
        /// </para>
        /// </summary>
        public int WeightedCapacity
        {
            get { return this._weightedCapacity.GetValueOrDefault(); }
            set { this._weightedCapacity = value; }
        }

        // Check to see if WeightedCapacity property is set
        internal bool IsSetWeightedCapacity()
        {
            return this._weightedCapacity.HasValue; 
        }

    }
}