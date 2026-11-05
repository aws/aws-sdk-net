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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ModifyTransitGatewayAttachmentNatConfiguration operation.
    /// </summary>
    public partial class ModifyTransitGatewayAttachmentNatConfigurationResponse : AmazonWebServiceResponse
    {
        private List<TransitGatewayNatRule> _natGatewayRules = AWSConfigs.InitializeCollections ? new List<TransitGatewayNatRule>() : null;
        private TransitGatewayAttachmentNatGatewaySupportState _natGatewaySupport;
        private TransitGatewayAttachmentNatSystemRouteSupportValue _natSystemRouteSupport;
        private string _transitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property NatGatewayRules. 
        /// <para>
        /// The NAT gateway rules for the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TransitGatewayNatRule> NatGatewayRules
        {
            get { return this._natGatewayRules; }
            set { this._natGatewayRules = value; }
        }

        // Check to see if NatGatewayRules property is set
        internal bool IsSetNatGatewayRules()
        {
            return this._natGatewayRules != null && (this._natGatewayRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NatGatewaySupport. 
        /// <para>
        /// The state of NAT gateway support for the attachment.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentNatGatewaySupportState NatGatewaySupport
        {
            get { return this._natGatewaySupport; }
            set { this._natGatewaySupport = value; }
        }

        // Check to see if NatGatewaySupport property is set
        internal bool IsSetNatGatewaySupport()
        {
            return this._natGatewaySupport != null;
        }

        /// <summary>
        /// Gets and sets the property NatSystemRouteSupport. 
        /// <para>
        /// Specifies whether the transit gateway installs routes for the NAT CIDRs in the route
        /// tables to which the attachment propagates.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentNatSystemRouteSupportValue NatSystemRouteSupport
        {
            get { return this._natSystemRouteSupport; }
            set { this._natSystemRouteSupport = value; }
        }

        // Check to see if NatSystemRouteSupport property is set
        internal bool IsSetNatSystemRouteSupport()
        {
            return this._natSystemRouteSupport != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway attachment.
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

    }
}