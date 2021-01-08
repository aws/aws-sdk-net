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
    /// Container for the parameters to the CreateTransitGateway operation.
    /// Creates a transit gateway.
    /// 
    ///  
    /// <para>
    /// You can use a transit gateway to interconnect your virtual private clouds (VPC) and
    /// on-premises networks. After the transit gateway enters the <code>available</code>
    /// state, you can attach your VPCs and VPN connections to the transit gateway.
    /// </para>
    ///  
    /// <para>
    /// To attach your VPCs, use <a>CreateTransitGatewayVpcAttachment</a>.
    /// </para>
    ///  
    /// <para>
    /// To attach a VPN connection, use <a>CreateCustomerGateway</a> to create a customer
    /// gateway and specify the ID of the customer gateway and the ID of the transit gateway
    /// in a call to <a>CreateVpnConnection</a>.
    /// </para>
    ///  
    /// <para>
    /// When you create a transit gateway, we create a default transit gateway route table
    /// and use it as the default association route table and the default propagation route
    /// table. You can use <a>CreateTransitGatewayRouteTable</a> to create additional transit
    /// gateway route tables. If you disable automatic route propagation, we do not create
    /// a default transit gateway route table. You can use <a>EnableTransitGatewayRouteTablePropagation</a>
    /// to propagate routes from a resource attachment to a transit gateway route table. If
    /// you disable automatic associations, you can use <a>AssociateTransitGatewayRouteTable</a>
    /// to associate a resource attachment with a transit gateway route table.
    /// </para>
    /// </summary>
    public partial class CreateTransitGatewayRequest : AmazonEC2Request
    {
        private string _description;
        private TransitGatewayRequestOptions _options;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the transit gateway.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The transit gateway options.
        /// </para>
        /// </summary>
        public TransitGatewayRequestOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the transit gateway.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}