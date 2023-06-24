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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTransitGatewayRouteTableAttachment operation.
    /// Creates a transit gateway route table attachment.
    /// </summary>
    public partial class CreateTransitGatewayRouteTableAttachmentRequest : AmazonNetworkManagerRequest
    {
        private string _clientToken;
        private string _peeringId;
        private List<Tag> _tags = new List<Tag>();
        private string _transitGatewayRouteTableArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property PeeringId. 
        /// <para>
        /// The ID of the peer for the 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string PeeringId
        {
            get { return this._peeringId; }
            set { this._peeringId = value; }
        }

        // Check to see if PeeringId property is set
        internal bool IsSetPeeringId()
        {
            return this._peeringId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value tags associated with the request.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableArn. 
        /// <para>
        /// The ARN of the transit gateway route table for the attachment request. For example,
        /// <code>"TransitGatewayRouteTableArn": "arn:aws:ec2:us-west-2:123456789012:transit-gateway-route-table/tgw-rtb-9876543210123456"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
        public string TransitGatewayRouteTableArn
        {
            get { return this._transitGatewayRouteTableArn; }
            set { this._transitGatewayRouteTableArn = value; }
        }

        // Check to see if TransitGatewayRouteTableArn property is set
        internal bool IsSetTransitGatewayRouteTableArn()
        {
            return this._transitGatewayRouteTableArn != null;
        }

    }
}