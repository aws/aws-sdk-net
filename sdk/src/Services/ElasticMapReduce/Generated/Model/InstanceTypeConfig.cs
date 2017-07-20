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
    /// An instance type configuration for each instance type in an instance fleet, which
    /// determines the EC2 instances Amazon EMR attempts to provision to fulfill On-Demand
    /// and Spot target capacities. There can be a maximum of 5 instance type configurations
    /// in a fleet.
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InstanceTypeConfig
    {
        private string _bidPrice;
        private double? _bidPriceAsPercentageOfOnDemandPrice;
        private List<Configuration> _configurations = new List<Configuration>();
        private EbsConfiguration _ebsConfiguration;
        private string _instanceType;
        private int? _weightedCapacity;

        /// <summary>
        /// Gets and sets the property BidPrice. 
        /// <para>
        /// The bid price for each EC2 Spot instance type as defined by <code>InstanceType</code>.
        /// Expressed in USD. If neither <code>BidPrice</code> nor <code>BidPriceAsPercentageOfOnDemandPrice</code>
        /// is provided, <code>BidPriceAsPercentageOfOnDemandPrice</code> defaults to 100%. 
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
        /// If neither <code>BidPrice</code> nor <code>BidPriceAsPercentageOfOnDemandPrice</code>
        /// is provided, <code>BidPriceAsPercentageOfOnDemandPrice</code> defaults to 100%.
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
        /// can include configurations for applications and software that run on the cluster.
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
        /// The configuration of Amazon Elastic Block Storage (EBS) attached to each instance
        /// as defined by <code>InstanceType</code>. 
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// An EC2 instance type, such as <code>m3.xlarge</code>. 
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
        /// the target capacities defined in <a>InstanceFleetConfig</a>. This value is 1 for a
        /// master instance fleet, and must be 1 or greater for core and task instance fleets.
        /// Defaults to 1 if not specified. 
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