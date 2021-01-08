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
    /// Container for the parameters to the CreateTransitGatewayVpcAttachment operation.
    /// Attaches the specified VPC to the specified transit gateway.
    /// 
    ///  
    /// <para>
    /// If you attach a VPC with a CIDR range that overlaps the CIDR range of a VPC that is
    /// already attached, the new VPC CIDR range is not propagated to the default propagation
    /// route table.
    /// </para>
    ///  
    /// <para>
    /// To send VPC traffic to an attached transit gateway, add a route to the VPC route table
    /// using <a>CreateRoute</a>.
    /// </para>
    /// </summary>
    public partial class CreateTransitGatewayVpcAttachmentRequest : AmazonEC2Request
    {
        private CreateTransitGatewayVpcAttachmentRequestOptions _options;
        private List<string> _subnetIds = new List<string>();
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private string _transitGatewayId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The VPC attachment options.
        /// </para>
        /// </summary>
        public CreateTransitGatewayVpcAttachmentRequestOptions Options
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The IDs of one or more subnets. You can specify only one subnet per Availability Zone.
        /// You must specify at least one subnet, but we recommend that you specify two subnets
        /// for better availability. The transit gateway uses one IP address from each specified
        /// subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the VPC attachment.
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

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayId
        {
            get { return this._transitGatewayId; }
            set { this._transitGatewayId = value; }
        }

        // Check to see if TransitGatewayId property is set
        internal bool IsSetTransitGatewayId()
        {
            return this._transitGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}