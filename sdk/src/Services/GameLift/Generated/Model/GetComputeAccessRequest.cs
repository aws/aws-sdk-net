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
    /// <b>This operation has been expanded to use with the Amazon GameLift containers feature,
    /// which is currently in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// Requests authorization to remotely connect to a hosting resource in a Amazon GameLift
    /// managed fleet. This operation is not used with Amazon GameLift Anywhere fleets
    /// </para>
    ///  
    /// <para>
    /// To request access, specify the compute name and the fleet ID. If successful, this
    /// operation returns a set of temporary Amazon Web Services credentials, including a
    /// two-part access key and a session token.
    /// </para>
    ///  
    /// <para>
    ///  <b>EC2 fleets</b> 
    /// </para>
    ///  
    /// <para>
    /// With an EC2 fleet (where compute type is <c>EC2</c>), use these credentials with Amazon
    /// EC2 Systems Manager (SSM) to start a session with the compute. For more details, see
    /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-sessions-start.html#sessions-start-cli">
    /// Starting a session (CLI)</a> in the <i>Amazon EC2 Systems Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Container fleets</b> 
    /// </para>
    ///  
    /// <para>
    /// With a container fleet (where compute type is <c>CONTAINER</c>), use these credentials
    /// and the target value with SSM to connect to the fleet instance where the container
    /// is running. After you're connected to the instance, use Docker commands to interact
    /// with the container.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
    /// connect to fleet instances</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
    /// fleet issues</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-remote-access.html">
    /// Remotely connect to a container fleet</a> 
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
        /// fleet compute, use the instance ID. For a container fleet, use the compute name (for
        /// example, <c>a123b456c789012d3e4567f8a901b23c/1a234b56-7cd8-9e0f-a1b2-c34d567ef8a9</c>)
        /// or the compute ARN. 
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
        [AWSProperty(Required=true)]
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