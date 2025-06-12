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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGateway operation.
    /// Creates a new gateway. The request must include at least one network (up to four).
    /// </summary>
    public partial class CreateGatewayRequest : AmazonMediaConnectRequest
    {
        private List<string> _egressCidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private List<GatewayNetwork> _networks = AWSConfigs.InitializeCollections ? new List<GatewayNetwork>() : null;

        /// <summary>
        /// Gets and sets the property EgressCidrBlocks. 
        /// <para>
        ///  The range of IP addresses that are allowed to contribute content or initiate output
        /// requests for flows communicating with this gateway. These IP addresses should be in
        /// the form of a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> EgressCidrBlocks
        {
            get { return this._egressCidrBlocks; }
            set { this._egressCidrBlocks = value; }
        }

        // Check to see if EgressCidrBlocks property is set
        internal bool IsSetEgressCidrBlocks()
        {
            return this._egressCidrBlocks != null && (this._egressCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the gateway. This name can not be modified after the gateway is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Networks. 
        /// <para>
        ///  The list of networks that you want to add to the gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GatewayNetwork> Networks
        {
            get { return this._networks; }
            set { this._networks = value; }
        }

        // Check to see if Networks property is set
        internal bool IsSetNetworks()
        {
            return this._networks != null && (this._networks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}