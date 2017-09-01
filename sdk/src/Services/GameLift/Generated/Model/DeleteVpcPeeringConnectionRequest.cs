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
    /// Container for the parameters to the DeleteVpcPeeringConnection operation.
    /// Removes a VPC peering connection. To delete the connection, you must have a valid
    /// authorization for the VPC peering connection that you want to delete. You can check
    /// for an authorization by calling <a>DescribeVpcPeeringAuthorizations</a> or request
    /// a new one using <a>CreateVpcPeeringAuthorization</a>. 
    /// 
    ///  
    /// <para>
    /// Once a valid authorization exists, call this operation from the AWS account that is
    /// used to manage the Amazon GameLift fleets. Identify the connection to delete by the
    /// connection ID and fleet ID. If successful, the connection is removed. 
    /// </para>
    ///  
    /// <para>
    /// VPC peering connection operations include:
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
    public partial class DeleteVpcPeeringConnectionRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet. This value must match the fleet ID referenced in the
        /// VPC peering connection record.
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

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// Unique identifier for a VPC peering connection. This value is included in the <a>VpcPeeringConnection</a>
        /// object, which can be retrieved by calling <a>DescribeVpcPeeringConnections</a>.
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId
        {
            get { return this._vpcPeeringConnectionId; }
            set { this._vpcPeeringConnectionId = value; }
        }

        // Check to see if VpcPeeringConnectionId property is set
        internal bool IsSetVpcPeeringConnectionId()
        {
            return this._vpcPeeringConnectionId != null;
        }

    }
}