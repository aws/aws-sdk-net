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
    /// BrokerNodeInfo
    /// </summary>
    public partial class BrokerNodeInfo
    {
        /// <summary>
        /// Gets and sets the property AttachedENIId. 
        /// <para>
        /// The attached elastic network interface of the broker.
        /// </para>
        /// </summary>
        public string AttachedENIId { get; set; }

        /// <summary>
        /// Checks to see if the AttachedENIId property is set.
        /// </summary>
        internal bool IsSetAttachedENIId() => this.AttachedENIId != null;

        /// <summary>
        /// Gets and sets the property BrokerId. 
        /// <para>
        /// The ID of the broker.
        /// </para>
        /// </summary>
        public double? BrokerId { get; set; }

        /// <summary>
        /// Checks to see if the BrokerId property is set.
        /// </summary>
        internal bool IsSetBrokerId() => this.BrokerId.HasValue;

        /// <summary>
        /// Gets and sets the property ClientSubnet. 
        /// <para>
        /// The client subnet to which this broker node belongs.
        /// </para>
        /// </summary>
        public string ClientSubnet { get; set; }

        /// <summary>
        /// Checks to see if the ClientSubnet property is set.
        /// </summary>
        internal bool IsSetClientSubnet() => this.ClientSubnet != null;

        /// <summary>
        /// Gets and sets the property ClientVpcIpAddress. 
        /// <para>
        /// The virtual private cloud (VPC) of the client.
        /// </para>
        /// </summary>
        public string ClientVpcIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpcIpAddress property is set.
        /// </summary>
        internal bool IsSetClientVpcIpAddress() => this.ClientVpcIpAddress != null;

        /// <summary>
        /// Gets and sets the property CurrentBrokerSoftwareInfo. 
        /// <para>
        /// Information about the version of software currently deployed on the Apache Kafka brokers
        /// in the cluster.
        /// </para>
        /// </summary>
        public BrokerSoftwareInfo CurrentBrokerSoftwareInfo { get; set; }

        /// <summary>
        /// Checks to see if the CurrentBrokerSoftwareInfo property is set.
        /// </summary>
        internal bool IsSetCurrentBrokerSoftwareInfo() => this.CurrentBrokerSoftwareInfo != null;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// Endpoints for accessing the broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
