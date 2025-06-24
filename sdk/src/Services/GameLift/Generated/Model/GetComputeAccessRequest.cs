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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the GetComputeAccess operation.
    /// Requests authorization to remotely connect to a hosting resource in a Amazon GameLift
    /// Servers managed fleet. This operation is not used with Amazon GameLift Servers Anywhere
    /// fleets.
    /// 
    ///  
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  
    /// <para>
    /// Provide the fleet ID and compute name. The compute name varies depending on the type
    /// of fleet.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For a compute in a managed EC2 fleet, provide an instance ID. Each instance in the
    /// fleet is a compute.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a compute in a managed container fleet, provide a compute name. In a container
    /// fleet, each game server container group on a fleet instance is assigned a compute
    /// name. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Results</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns a set of temporary Amazon Web Services credentials,
    /// including a two-part access key and a session token.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// With a managed EC2 fleet (where compute type is <c>EC2</c>), use these credentials
    /// with Amazon EC2 Systems Manager (SSM) to start a session with the compute. For more
    /// details, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-sessions-start.html#sessions-start-cli">
    /// Starting a session (CLI)</a> in the <i>Amazon EC2 Systems Manager User Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetComputeAccessRequest : AmazonGameLiftRequest
    {
        private string _computeName;
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// A unique identifier for the compute resource that you want to connect to. For an EC2
        /// fleet, use an instance ID. For a managed container fleet, use a compute name. You
        /// can retrieve a fleet's compute names by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListCompute.html">ListCompute</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string ComputeName
        {
            get { return this._computeName; }
            set { this._computeName = value; }
        }

        // Check to see if ComputeName property is set
        internal bool IsSetComputeName()
        {
            return this._computeName != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that holds the compute resource that you want to
        /// connect to. You can use either the fleet ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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