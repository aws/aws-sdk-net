/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteVpcPeeringAuthorization operation.
    /// Cancels a pending VPC peering authorization for the specified VPC. If the authorization
    /// has already been used to create a peering connection, call <a>DeleteVpcPeeringConnection</a>
    /// to remove the connection. 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateVpcPeeringAuthorization</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeVpcPeeringAuthorizations</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteVpcPeeringAuthorization</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateVpcPeeringConnection</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeVpcPeeringConnections</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteVpcPeeringConnection</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteVpcPeeringAuthorizationRequest : AmazonGameLiftRequest
    {
        private string _gameLiftAwsAccountId;
        private string _peerVpcId;

        /// <summary>
        /// Gets and sets the property GameLiftAwsAccountId. 
        /// <para>
        /// Unique identifier for the AWS account that you use to manage your Amazon GameLift
        /// fleet. You can find your Account ID in the AWS Management Console under account settings.
        /// </para>
        /// </summary>
        public string GameLiftAwsAccountId
        {
            get { return this._gameLiftAwsAccountId; }
            set { this._gameLiftAwsAccountId = value; }
        }

        // Check to see if GameLiftAwsAccountId property is set
        internal bool IsSetGameLiftAwsAccountId()
        {
            return this._gameLiftAwsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerVpcId. 
        /// <para>
        /// Unique identifier for a VPC with resources to be accessed by your Amazon GameLift
        /// fleet. The VPC must be in the same region where your fleet is deployed. Look up a
        /// VPC ID using the <a href="https://console.aws.amazon.com/vpc/">VPC Dashboard</a> in
        /// the AWS Management Console. Learn more about VPC peering in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Fleets</a>.
        /// </para>
        /// </summary>
        public string PeerVpcId
        {
            get { return this._peerVpcId; }
            set { this._peerVpcId = value; }
        }

        // Check to see if PeerVpcId property is set
        internal bool IsSetPeerVpcId()
        {
            return this._peerVpcId != null;
        }

    }
}