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
    /// Container for the parameters to the DescribeVpcPeeringConnections operation.
    /// Retrieves information on VPC peering connections. Use this operation to get peering
    /// information for all fleets or for one specific fleet ID. 
    /// 
    ///  
    /// <para>
    /// To retrieve connection information, call this operation from the AWS account that
    /// is used to manage the Amazon GameLift fleets. Specify a fleet ID or leave the parameter
    /// empty to retrieve all connection records. If successful, the retrieved information
    /// includes both active and pending connections. Active connections identify the IpV4
    /// CIDR block that the VPC uses to connect. 
    /// </para>
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
    public partial class DescribeVpcPeeringConnectionsRequest : AmazonGameLiftRequest
    {
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

    }
}