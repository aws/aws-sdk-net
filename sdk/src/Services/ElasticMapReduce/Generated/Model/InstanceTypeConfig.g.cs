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
    /// An instance type configuration for each instance type in an instance fleet, which
    /// determines the Amazon EC2 instances Amazon EMR attempts to provision to fulfill On-Demand
    /// and Spot target capacities. When you use an allocation strategy, you can include a
    /// maximum of 30 instance type configurations for a fleet. For more information about
    /// how to use an allocation strategy, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-instance-fleet.html">Configure
    /// Instance Fleets</a>. Without an allocation strategy, you may specify a maximum of
    /// five instance type configurations for a fleet.
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InstanceTypeConfig
    {
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
        /// Gets and sets the property BidPriceAsPercentageOfOnDemandPrice. 
        /// <para>
        /// The bid price, as a percentage of On-Demand price, for each Amazon EC2 Spot Instance
        /// as defined by <c>InstanceType</c>. Expressed as a number (for example, 20 specifies
        /// 20%). If neither <c>BidPrice</c> nor <c>BidPriceAsPercentageOfOnDemandPrice</c> is
        /// provided, <c>BidPriceAsPercentageOfOnDemandPrice</c> defaults to 100%.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? BidPriceAsPercentageOfOnDemandPrice { get; set; }

        /// <summary>
        /// Checks to see if the BidPriceAsPercentageOfOnDemandPrice property is set.
        /// </summary>
        internal bool IsSetBidPriceAsPercentageOfOnDemandPrice() => this.BidPriceAsPercentageOfOnDemandPrice.HasValue;

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// A configuration classification that applies when provisioning cluster instances, which
        /// can include configurations for applications and software that run on the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> Configurations { get; set; } = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;

        /// <summary>
        /// Checks to see if the Configurations property is set.
        /// </summary>
        internal bool IsSetConfigurations() => this.Configurations != null && (this.Configurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomAmiId. 
        /// <para>
        /// The custom AMI ID to use for the instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CustomAmiId { get; set; }

        /// <summary>
        /// Checks to see if the CustomAmiId property is set.
        /// </summary>
        internal bool IsSetCustomAmiId() => this.CustomAmiId != null;

        /// <summary>
        /// Gets and sets the property EbsConfiguration. 
        /// <para>
        /// The configuration of Amazon Elastic Block Store (Amazon EBS) attached to each instance
        /// as defined by <c>InstanceType</c>. 
        /// </para>
        /// </summary>
        public EbsConfiguration EbsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EbsConfiguration property is set.
        /// </summary>
        internal bool IsSetEbsConfiguration() => this.EbsConfiguration != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// An Amazon EC2 instance type, such as <c>m3.xlarge</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority at which Amazon EMR launches the Amazon EC2 instances with this instance
        /// type. Priority starts at 0, which is the highest priority. Amazon EMR considers the
        /// highest priority first.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property WeightedCapacity. 
        /// <para>
        /// The number of units that a provisioned instance of this type provides toward fulfilling
        /// the target capacities defined in <a>InstanceFleetConfig</a>. This value is 1 for a
        /// master instance fleet, and must be 1 or greater for core and task instance fleets.
        /// Defaults to 1 if not specified. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? WeightedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the WeightedCapacity property is set.
        /// </summary>
        internal bool IsSetWeightedCapacity() => this.WeightedCapacity.HasValue;
    }
}
