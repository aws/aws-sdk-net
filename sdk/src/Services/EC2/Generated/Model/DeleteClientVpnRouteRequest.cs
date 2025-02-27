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
    /// Container for the parameters to the DeleteClientVpnRoute operation.
    /// Deletes a route from a Client VPN endpoint. You can only delete routes that you manually
    /// added using the <b>CreateClientVpnRoute</b> action. You cannot delete routes that
    /// were automatically added when associating a subnet. To remove routes that have been
    /// automatically added, disassociate the target subnet from the Client VPN endpoint.
    /// </summary>
    public partial class DeleteClientVpnRouteRequest : AmazonEC2Request
    {
        private string _clientVpnEndpointId;
        private string _destinationCidrBlock;
        private bool? _dryRun;
        private string _targetVpcSubnetId;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint from which the route is to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientVpnEndpointId
        {
            get { return this._clientVpnEndpointId; }
            set { this._clientVpnEndpointId = value; }
        }

        // Check to see if ClientVpnEndpointId property is set
        internal bool IsSetClientVpnEndpointId()
        {
            return this._clientVpnEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the route to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationCidrBlock
        {
            get { return this._destinationCidrBlock; }
            set { this._destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this._destinationCidrBlock != null;
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
        /// Gets and sets the property TargetVpcSubnetId. 
        /// <para>
        /// The ID of the target subnet used by the route.
        /// </para>
        /// </summary>
        public string TargetVpcSubnetId
        {
            get { return this._targetVpcSubnetId; }
            set { this._targetVpcSubnetId = value; }
        }

        // Check to see if TargetVpcSubnetId property is set
        internal bool IsSetTargetVpcSubnetId()
        {
            return this._targetVpcSubnetId != null;
        }

    }
}