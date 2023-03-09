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
    /// Describes a transit gateway route table attachment.
    /// </summary>
    public partial class TransitGatewayRouteTableAttachment
    {
        private Attachment _attachment;
        private string _peeringId;
        private string _transitGatewayRouteTableArn;

        /// <summary>
        /// Gets and sets the property Attachment.
        /// </summary>
        public Attachment Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this._attachment != null;
        }

        /// <summary>
        /// Gets and sets the property PeeringId. 
        /// <para>
        /// The ID of the peering attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property TransitGatewayRouteTableArn. 
        /// <para>
        /// The ARN of the transit gateway attachment route table. For example, <code>"TransitGatewayRouteTableArn":
        /// "arn:aws:ec2:us-west-2:123456789012:transit-gateway-route-table/tgw-rtb-9876543210123456"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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