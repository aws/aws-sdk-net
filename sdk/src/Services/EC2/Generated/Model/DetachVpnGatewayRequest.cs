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
    /// Container for the parameters to the DetachVpnGateway operation.
    /// Detaches a virtual private gateway from a VPC. You do this if you're planning to turn
    /// off the VPC and not use it anymore. You can confirm a virtual private gateway has
    /// been completely detached from a VPC by describing the virtual private gateway (any
    /// attachments to the virtual private gateway are also described).
    /// 
    ///  
    /// <para>
    /// You must wait for the attachment's state to switch to <c>detached</c> before you can
    /// delete the VPC or attach a different VPC to the virtual private gateway.
    /// </para>
    /// </summary>
    public partial class DetachVpnGatewayRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _vpcId;
        private string _vpnGatewayId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DetachVpnGatewayRequest() { }

        /// <summary>
        /// Instantiates DetachVpnGatewayRequest with the parameterized properties
        /// </summary>
        /// <param name="vpnGatewayId">The ID of the virtual private gateway.</param>
        /// <param name="vpcId">The ID of the VPC.</param>
        public DetachVpnGatewayRequest(string vpnGatewayId, string vpcId)
        {
            _vpnGatewayId = vpnGatewayId;
            _vpcId = vpcId;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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

        /// <summary>
        /// Gets and sets the property VpnGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpnGatewayId
        {
            get { return this._vpnGatewayId; }
            set { this._vpnGatewayId = value; }
        }

        // Check to see if VpnGatewayId property is set
        internal bool IsSetVpnGatewayId()
        {
            return this._vpnGatewayId != null;
        }

    }
}