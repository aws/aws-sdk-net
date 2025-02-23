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
    /// Container for the parameters to the ModifyVpcBlockPublicAccessOptions operation.
    /// Modify VPC Block Public Access (BPA) options. VPC Block Public Access (BPA) enables
    /// you to block resources in VPCs and subnets that you own in a Region from reaching
    /// or being reached from the internet through internet gateways and egress-only internet
    /// gateways. To learn more about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
    /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
    /// </summary>
    public partial class ModifyVpcBlockPublicAccessOptionsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private InternetGatewayBlockMode _internetGatewayBlockMode;

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
        /// Gets and sets the property InternetGatewayBlockMode. 
        /// <para>
        /// The mode of VPC BPA.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>off</c>: VPC BPA is not enabled and traffic is allowed to and from internet gateways
        /// and egress-only internet gateways in this Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-bidirectional</c>: Block all traffic to and from internet gateways and egress-only
        /// internet gateways in this Region (except for excluded VPCs and subnets).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-ingress</c>: Block all internet traffic to the VPCs in this Region (except
        /// for VPCs or subnets which are excluded). Only traffic to and from NAT gateways and
        /// egress-only internet gateways is allowed because these gateways only allow outbound
        /// connections to be established.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public InternetGatewayBlockMode InternetGatewayBlockMode
        {
            get { return this._internetGatewayBlockMode; }
            set { this._internetGatewayBlockMode = value; }
        }

        // Check to see if InternetGatewayBlockMode property is set
        internal bool IsSetInternetGatewayBlockMode()
        {
            return this._internetGatewayBlockMode != null;
        }

    }
}