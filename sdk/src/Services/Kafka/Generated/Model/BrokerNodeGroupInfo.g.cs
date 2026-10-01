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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Describes the setup to be used for Apache Kafka broker nodes in the cluster.
    /// </summary>
    public partial class BrokerNodeGroupInfo
    {
        /// <summary>
        /// Gets and sets the property BrokerAZDistribution. 
        /// <para>
        /// The distribution of broker nodes across Availability Zones. This is an optional parameter.
        /// If you don't specify it, Amazon MSK gives it the value DEFAULT. You can also explicitly
        /// set this parameter to the value DEFAULT. No other values are currently allowed.
        /// </para>
        ///  
        /// <para>
        /// Amazon MSK distributes the broker nodes evenly across the Availability Zones that
        /// correspond to the subnets you provide when you create the cluster.
        /// </para>
        /// </summary>
        public BrokerAZDistribution BrokerAZDistribution { get; set; }

        /// <summary>
        /// Checks to see if the BrokerAZDistribution property is set.
        /// </summary>
        internal bool IsSetBrokerAZDistribution() => this.BrokerAZDistribution != null;

        /// <summary>
        /// Gets and sets the property ClientSubnets. 
        /// <para>
        /// The list of subnets to connect to in the client virtual private cloud (VPC). AWS creates
        /// elastic network interfaces inside these subnets. Client applications use elastic network
        /// interfaces to produce and consume data. Client subnets can't occupy the Availability
        /// Zone with ID use use1-az3.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ClientSubnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClientSubnets property is set.
        /// </summary>
        internal bool IsSetClientSubnets() => this.ClientSubnets != null && (this.ClientSubnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectivityInfo. 
        /// <para>
        /// Information about the broker access configuration.
        /// </para>
        /// </summary>
        public ConnectivityInfo ConnectivityInfo { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityInfo property is set.
        /// </summary>
        internal bool IsSetConnectivityInfo() => this.ConnectivityInfo != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of Amazon EC2 instances to use for Apache Kafka brokers. The following instance
        /// types are allowed: kafka.m5.large, kafka.m5.xlarge, kafka.m5.2xlarge, kafka.m5.4xlarge,
        /// kafka.m5.12xlarge, and kafka.m5.24xlarge.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 32)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The AWS security groups to associate with the elastic network interfaces in order
        /// to specify who can connect to and communicate with the Amazon MSK cluster. If you
        /// don't specify a security group, Amazon MSK uses the default security group associated
        /// with the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageInfo. 
        /// <para>
        /// Contains information about storage volumes attached to MSK broker nodes.
        /// </para>
        /// </summary>
        public StorageInfo StorageInfo { get; set; }

        /// <summary>
        /// Checks to see if the StorageInfo property is set.
        /// </summary>
        internal bool IsSetStorageInfo() => this.StorageInfo != null;

        /// <summary>
        /// Gets and sets the property ZoneIds. 
        /// <para>
        /// The list of zoneIds for the cluster in the virtual private cloud (VPC).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ZoneIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ZoneIds property is set.
        /// </summary>
        internal bool IsSetZoneIds() => this.ZoneIds != null && (this.ZoneIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
