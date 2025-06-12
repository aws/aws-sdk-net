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
    /// Zookeeper node information.
    /// </summary>
    public partial class ZookeeperNodeInfo
    {
        private string _attachedENIId;
        private string _clientVpcIpAddress;
        private List<string> _endpoints = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _zookeeperId;
        private string _zookeeperVersion;

        /// <summary>
        /// Gets and sets the property AttachedENIId.             
        /// <para>
        /// The attached elastic network interface of the broker.
        /// </para>
        /// </summary>
        public string AttachedENIId
        {
            get { return this._attachedENIId; }
            set { this._attachedENIId = value; }
        }

        // Check to see if AttachedENIId property is set
        internal bool IsSetAttachedENIId()
        {
            return this._attachedENIId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientVpcIpAddress.             
        /// <para>
        /// The virtual private cloud (VPC) IP address of the client.
        /// </para>
        /// </summary>
        public string ClientVpcIpAddress
        {
            get { return this._clientVpcIpAddress; }
            set { this._clientVpcIpAddress = value; }
        }

        // Check to see if ClientVpcIpAddress property is set
        internal bool IsSetClientVpcIpAddress()
        {
            return this._clientVpcIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoints.             
        /// <para>
        /// Endpoints for accessing the ZooKeeper.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && (this._endpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ZookeeperId.             
        /// <para>
        /// The role-specific ID for Zookeeper.
        /// </para>
        /// </summary>
        public double? ZookeeperId
        {
            get { return this._zookeeperId; }
            set { this._zookeeperId = value; }
        }

        // Check to see if ZookeeperId property is set
        internal bool IsSetZookeeperId()
        {
            return this._zookeeperId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ZookeeperVersion.             
        /// <para>
        /// The version of Zookeeper.
        /// </para>
        /// </summary>
        public string ZookeeperVersion
        {
            get { return this._zookeeperVersion; }
            set { this._zookeeperVersion = value; }
        }

        // Check to see if ZookeeperVersion property is set
        internal bool IsSetZookeeperVersion()
        {
            return this._zookeeperVersion != null;
        }

    }
}