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
    /// Container for the parameters to the GetComputeAccess operation.
    /// Requests authorization to remotely connect to a compute resource in an Amazon GameLift
    /// fleet. Call this action to connect to an instance in a managed EC2 fleet if the fleet's
    /// game build uses Amazon GameLift server SDK 5.x or later. To connect to instances with
    /// game builds that use server SDK 4.x or earlier, call <a>GetInstanceAccess</a>.
    /// 
    ///  
    /// <para>
    /// To request access to a compute, identify the specific EC2 instance and the fleet it
    /// belongs to. You can retrieve instances for a managed EC2 fleet by calling <a>ListCompute</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns a set of temporary Amazon Web Services credentials,
    /// including a two-part access key and a session token. Use these credentials with Amazon
    /// EC2 Systems Manager (SSM) to start a session with the compute. For more details, see
    /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-sessions-start.html#sessions-start-cli">
    /// Starting a session (CLI)</a> in the <i>Amazon EC2 Systems Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
    /// connect to fleet instances</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
    /// fleet issues</a> 
    /// </para>
    /// </summary>
    public partial class GetComputeAccessRequest : AmazonGameLiftRequest
    {
        private string _computeName;
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// A unique identifier for the compute resource that you want to connect to. You can
        /// use either a registered compute name or an instance ID.
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
        /// A unique identifier for the fleet that contains the compute resource you want to connect
        /// to. You can use either the fleet ID or ARN value.
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