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
    /// Container for the parameters to the UpdateBridge operation.
    /// Updates the bridge.
    /// </summary>
    public partial class UpdateBridgeRequest : AmazonMediaConnectRequest
    {
        private string _bridgeArn;
        private UpdateEgressGatewayBridgeRequest _egressGatewayBridge;
        private UpdateIngressGatewayBridgeRequest _ingressGatewayBridge;
        private UpdateFailoverConfig _sourceFailoverConfig;

        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  TheAmazon Resource Name (ARN) of the bridge that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BridgeArn
        {
            get { return this._bridgeArn; }
            set { this._bridgeArn = value; }
        }

        // Check to see if BridgeArn property is set
        internal bool IsSetBridgeArn()
        {
            return this._bridgeArn != null;
        }

        /// <summary>
        /// Gets and sets the property EgressGatewayBridge. 
        /// <para>
        ///  A cloud-to-ground bridge. The content comes from an existing MediaConnect flow and
        /// is delivered to your premises. 
        /// </para>
        /// </summary>
        public UpdateEgressGatewayBridgeRequest EgressGatewayBridge
        {
            get { return this._egressGatewayBridge; }
            set { this._egressGatewayBridge = value; }
        }

        // Check to see if EgressGatewayBridge property is set
        internal bool IsSetEgressGatewayBridge()
        {
            return this._egressGatewayBridge != null;
        }

        /// <summary>
        /// Gets and sets the property IngressGatewayBridge. 
        /// <para>
        ///  A ground-to-cloud bridge. The content originates at your premises and is delivered
        /// to the cloud. 
        /// </para>
        /// </summary>
        public UpdateIngressGatewayBridgeRequest IngressGatewayBridge
        {
            get { return this._ingressGatewayBridge; }
            set { this._ingressGatewayBridge = value; }
        }

        // Check to see if IngressGatewayBridge property is set
        internal bool IsSetIngressGatewayBridge()
        {
            return this._ingressGatewayBridge != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFailoverConfig. 
        /// <para>
        ///  The settings for source failover. 
        /// </para>
        /// </summary>
        public UpdateFailoverConfig SourceFailoverConfig
        {
            get { return this._sourceFailoverConfig; }
            set { this._sourceFailoverConfig = value; }
        }

        // Check to see if SourceFailoverConfig property is set
        internal bool IsSetSourceFailoverConfig()
        {
            return this._sourceFailoverConfig != null;
        }

    }
}