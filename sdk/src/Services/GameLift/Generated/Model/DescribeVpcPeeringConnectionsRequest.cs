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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
    /// To retrieve connection information, call this operation from the Amazon Web Services
    /// account that is used to manage the Amazon Web Services fleets. Specify a fleet ID
    /// or leave the parameter empty to retrieve all connection records. If successful, the
    /// retrieved information includes both active and pending connections. Active connections
    /// identify the IpV4 CIDR block that the VPC uses to connect. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a>CreateVpcPeeringAuthorization</a> | <a>DescribeVpcPeeringAuthorizations</a> |
    /// <a>DeleteVpcPeeringAuthorization</a> | <a>CreateVpcPeeringConnection</a> | <a>DescribeVpcPeeringConnections</a>
    /// | <a>DeleteVpcPeeringConnection</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class DescribeVpcPeeringConnectionsRequest : AmazonGameLiftRequest
    {
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet. You can use either the fleet ID or ARN value.
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