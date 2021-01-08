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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTransitGatewayPrefixListReference operation.
    /// Creates a reference (route) to a prefix list in a specified transit gateway route
    /// table.
    /// </summary>
    public partial class CreateTransitGatewayPrefixListReferenceRequest : AmazonEC2Request
    {
        private bool? _blackhole;
        private string _prefixListId;
        private string _transitGatewayAttachmentId;
        private string _transitGatewayRouteTableId;

        /// <summary>
        /// Gets and sets the property Blackhole. 
        /// <para>
        /// Indicates whether to drop traffic that matches this route.
        /// </para>
        /// </summary>
        public bool Blackhole
        {
            get { return this._blackhole.GetValueOrDefault(); }
            set { this._blackhole = value; }
        }

        // Check to see if Blackhole property is set
        internal bool IsSetBlackhole()
        {
            return this._blackhole.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list that is used for destination matches.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the attachment to which traffic is routed.
        /// </para>
        /// </summary>
        public string TransitGatewayAttachmentId
        {
            get { return this._transitGatewayAttachmentId; }
            set { this._transitGatewayAttachmentId = value; }
        }

        // Check to see if TransitGatewayAttachmentId property is set
        internal bool IsSetTransitGatewayAttachmentId()
        {
            return this._transitGatewayAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayRouteTableId
        {
            get { return this._transitGatewayRouteTableId; }
            set { this._transitGatewayRouteTableId = value; }
        }

        // Check to see if TransitGatewayRouteTableId property is set
        internal bool IsSetTransitGatewayRouteTableId()
        {
            return this._transitGatewayRouteTableId != null;
        }

    }
}