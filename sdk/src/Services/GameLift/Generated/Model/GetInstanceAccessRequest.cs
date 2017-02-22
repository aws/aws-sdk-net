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
    /// Container for the parameters to the GetInstanceAccess operation.
    /// Requests remote access to a fleet instance. Remote access is useful for debugging,
    /// gathering benchmarking data, or watching activity in real time. 
    /// 
    ///  
    /// <para>
    /// Access requires credentials that match the operating system of the instance. For a
    /// Windows instance, Amazon GameLift returns a user name and password as strings for
    /// use with a Windows Remote Desktop client. For a Linux instance, Amazon GameLift returns
    /// a user name and RSA private key, also as strings, for use with an SSH client. The
    /// private key must be saved in the proper format to a <code>.pem</code> file before
    /// using. If you're making this request using the AWS CLI, saving the secret can be handled
    /// as part of the GetInstanceAccess request. (See the example later in this topic). For
    /// more information on remote access, see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
    /// Accessing an Instance</a>.
    /// </para>
    ///  
    /// <para>
    /// To request access to a specific instance, specify the IDs of the instance and the
    /// fleet it belongs to. If successful, an <a>InstanceAccess</a> object is returned containing
    /// the instance's IP address and a set of credentials.
    /// </para>
    /// </summary>
    public partial class GetInstanceAccessRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet that contains the instance you want access to. The fleet
        /// can be in any of the following statuses: <code>ACTIVATING</code>, <code>ACTIVE</code>,
        /// or <code>ERROR</code>. Fleets with an <code>ERROR</code> status may be accessible
        /// for a short time before they are deleted.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// Unique identifier for an instance you want to get access to. You can access an instance
        /// in any status.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}