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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a transit gateway peering attachment.
    /// </summary>
    public partial class TransitGatewayPeering
    {
        private Peering _peering;
        private string _transitGatewayArn;
        private string _transitGatewayPeeringAttachmentId;

        /// <summary>
        /// Gets and sets the property Peering. 
        /// <para>
        /// Describes a transit gateway peer connection.
        /// </para>
        /// </summary>
        public Peering Peering
        {
            get { return this._peering; }
            set { this._peering = value; }
        }

        // Check to see if Peering property is set
        internal bool IsSetPeering()
        {
            return this._peering != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayArn. 
        /// <para>
        /// The ARN of the transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string TransitGatewayArn
        {
            get { return this._transitGatewayArn; }
            set { this._transitGatewayArn = value; }
        }

        // Check to see if TransitGatewayArn property is set
        internal bool IsSetTransitGatewayArn()
        {
            return this._transitGatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayPeeringAttachmentId. 
        /// <para>
        /// The ID of the transit gateway peering attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string TransitGatewayPeeringAttachmentId
        {
            get { return this._transitGatewayPeeringAttachmentId; }
            set { this._transitGatewayPeeringAttachmentId = value; }
        }

        // Check to see if TransitGatewayPeeringAttachmentId property is set
        internal bool IsSetTransitGatewayPeeringAttachmentId()
        {
            return this._transitGatewayPeeringAttachmentId != null;
        }

    }
}