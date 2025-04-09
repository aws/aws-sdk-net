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
    /// Container for the parameters to the DeleteRouteServerPeer operation.
    /// Deletes the specified BGP peer from a route server.
    /// 
    ///  
    /// <para>
    /// A route server peer is a session between a route server endpoint and the device deployed
    /// in Amazon Web Services (such as a firewall appliance or other network security function
    /// running on an EC2 instance). The device must meet these requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Have an elastic network interface in the VPC
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Support BGP (Border Gateway Protocol)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Can initiate BGP sessions
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteRouteServerPeerRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _routeServerPeerId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
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
        /// Gets and sets the property RouteServerPeerId. 
        /// <para>
        /// The ID of the route server peer to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouteServerPeerId
        {
            get { return this._routeServerPeerId; }
            set { this._routeServerPeerId = value; }
        }

        // Check to see if RouteServerPeerId property is set
        internal bool IsSetRouteServerPeerId()
        {
            return this._routeServerPeerId != null;
        }

    }
}