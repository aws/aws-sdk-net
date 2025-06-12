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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
        private BrokerAZDistribution _brokerAZDistribution;
        private List<string> _clientSubnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ConnectivityInfo _connectivityInfo;
        private string _instanceType;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StorageInfo _storageInfo;
        private List<string> _zoneIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        public BrokerAZDistribution BrokerAZDistribution
        {
            get { return this._brokerAZDistribution; }
            set { this._brokerAZDistribution = value; }
        }

        // Check to see if BrokerAZDistribution property is set
        internal bool IsSetBrokerAZDistribution()
        {
            return this._brokerAZDistribution != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSubnets.             
        /// <para>
        /// The list of subnets to connect to in the client virtual private cloud (VPC). AWS creates
        /// elastic network interfaces inside these subnets. Client applications use elastic network
        /// interfaces to produce and consume data. Client subnets can't occupy the Availability
        /// Zone with ID use use1-az3.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ClientSubnets
        {
            get { return this._clientSubnets; }
            set { this._clientSubnets = value; }
        }

        // Check to see if ClientSubnets property is set
        internal bool IsSetClientSubnets()
        {
            return this._clientSubnets != null && (this._clientSubnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectivityInfo.             
        /// <para>
        /// Information about the broker access configuration.
        /// </para>
        /// </summary>
        public ConnectivityInfo ConnectivityInfo
        {
            get { return this._connectivityInfo; }
            set { this._connectivityInfo = value; }
        }

        // Check to see if ConnectivityInfo property is set
        internal bool IsSetConnectivityInfo()
        {
            return this._connectivityInfo != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType.             
        /// <para>
        /// The type of Amazon EC2 instances to use for Apache Kafka brokers. The following instance
        /// types are allowed: kafka.m5.large, kafka.m5.xlarge, kafka.m5.2xlarge,kafka.m5.4xlarge,
        /// kafka.m5.12xlarge, and kafka.m5.24xlarge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=32)]
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
        /// Gets and sets the property SecurityGroups.             
        /// <para>
        /// The AWS security groups to associate with the elastic network interfaces in order
        /// to specify who can connect to and communicate with the Amazon MSK cluster. If you
        /// don't specify a security group, Amazon MSK uses the default security group associated
        /// with the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageInfo.             
        /// <para>
        /// Contains information about storage volumes attached to MSK broker nodes.
        /// </para>
        /// </summary>
        public StorageInfo StorageInfo
        {
            get { return this._storageInfo; }
            set { this._storageInfo = value; }
        }

        // Check to see if StorageInfo property is set
        internal bool IsSetStorageInfo()
        {
            return this._storageInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneIds.             
        /// <para>
        /// The list of zoneIds for the cluster in the virtual private cloud (VPC).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ZoneIds
        {
            get { return this._zoneIds; }
            set { this._zoneIds = value; }
        }

        // Check to see if ZoneIds property is set
        internal bool IsSetZoneIds()
        {
            return this._zoneIds != null && (this._zoneIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}