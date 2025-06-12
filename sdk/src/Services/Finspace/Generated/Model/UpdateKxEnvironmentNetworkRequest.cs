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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKxEnvironmentNetwork operation.
    /// Updates environment network to connect to your internal network by using a transit
    /// gateway. This API supports request to create a transit gateway attachment from FinSpace
    /// VPC to your transit gateway ID and create a custom Route-53 outbound resolvers.
    /// 
    ///  
    /// <para>
    /// Once you send a request to update a network, you cannot change it again. Network update
    /// might require termination of any clusters that are running in the existing network.
    /// </para>
    /// </summary>
    public partial class UpdateKxEnvironmentNetworkRequest : AmazonFinspaceRequest
    {
        private string _clientToken;
        private List<CustomDNSServer> _customdnsConfiguration = AWSConfigs.InitializeCollections ? new List<CustomDNSServer>() : null;
        private string _environmentId;
        private TransitGatewayConfiguration _transitGatewayConfiguration;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDNSConfiguration. 
        /// <para>
        /// A list of DNS server name and server IP. This is used to set up Route-53 outbound
        /// resolvers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomDNSServer> CustomDNSConfiguration
        {
            get { return this._customdnsConfiguration; }
            set { this._customdnsConfiguration = value; }
        }

        // Check to see if CustomDNSConfiguration property is set
        internal bool IsSetCustomDNSConfiguration()
        {
            return this._customdnsConfiguration != null && (this._customdnsConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier for the kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayConfiguration. 
        /// <para>
        /// Specifies the transit gateway and network configuration to connect the kdb environment
        /// to an internal network.
        /// </para>
        /// </summary>
        public TransitGatewayConfiguration TransitGatewayConfiguration
        {
            get { return this._transitGatewayConfiguration; }
            set { this._transitGatewayConfiguration = value; }
        }

        // Check to see if TransitGatewayConfiguration property is set
        internal bool IsSetTransitGatewayConfiguration()
        {
            return this._transitGatewayConfiguration != null;
        }

    }
}