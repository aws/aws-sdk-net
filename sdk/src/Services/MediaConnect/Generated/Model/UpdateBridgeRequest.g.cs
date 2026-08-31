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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBridge operation. Updates the bridge.
    /// </summary>
    public partial class UpdateBridgeRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  TheAmazon Resource Name (ARN) of the bridge that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BridgeArn { get; set; }

        /// <summary>
        /// Checks to see if the BridgeArn property is set.
        /// </summary>
        internal bool IsSetBridgeArn() => this.BridgeArn != null;

        /// <summary>
        /// Gets and sets the property EgressGatewayBridge. 
        /// <para>
        ///  A cloud-to-ground bridge. The content comes from an existing MediaConnect flow and
        /// is delivered to your premises. 
        /// </para>
        /// </summary>
        public UpdateEgressGatewayBridgeRequest EgressGatewayBridge { get; set; }

        /// <summary>
        /// Checks to see if the EgressGatewayBridge property is set.
        /// </summary>
        internal bool IsSetEgressGatewayBridge() => this.EgressGatewayBridge != null;

        /// <summary>
        /// Gets and sets the property IngressGatewayBridge. 
        /// <para>
        ///  A ground-to-cloud bridge. The content originates at your premises and is delivered
        /// to the cloud. 
        /// </para>
        /// </summary>
        public UpdateIngressGatewayBridgeRequest IngressGatewayBridge { get; set; }

        /// <summary>
        /// Checks to see if the IngressGatewayBridge property is set.
        /// </summary>
        internal bool IsSetIngressGatewayBridge() => this.IngressGatewayBridge != null;

        /// <summary>
        /// Gets and sets the property SourceFailoverConfig. 
        /// <para>
        ///  The settings for source failover. 
        /// </para>
        /// </summary>
        public UpdateFailoverConfig SourceFailoverConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceFailoverConfig property is set.
        /// </summary>
        internal bool IsSetSourceFailoverConfig() => this.SourceFailoverConfig != null;
    }
}
