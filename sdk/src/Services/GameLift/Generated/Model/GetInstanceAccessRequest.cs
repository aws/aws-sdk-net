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
    /// Container for the parameters to the GetInstanceAccess operation.
    /// Requests remote access to a fleet instance. Remote access is useful for debugging,
    /// gathering benchmarking data, or observing activity in real time. 
    /// 
    ///  
    /// <para>
    /// To remotely access an instance, you need credentials that match the operating system
    /// of the instance. For a Windows instance, GameLift returns a user name and password
    /// as strings for use with a Windows Remote Desktop client. For a Linux instance, GameLift
    /// returns a user name and RSA private key, also as strings, for use with an SSH client.
    /// The private key must be saved in the proper format to a <code>.pem</code> file before
    /// using. If you're making this request using the CLI, saving the secret can be handled
    /// as part of the <code>GetInstanceAccess</code> request, as shown in one of the examples
    /// for this operation. 
    /// </para>
    ///  
    /// <para>
    /// To request access to a specific instance, specify the IDs of both the instance and
    /// the fleet it belongs to. You can retrieve a fleet's instance IDs by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeInstances.html">DescribeInstances</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-remote-access.html">Remotely
    /// Access Fleet Instances</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html">Debug
    /// Fleet Issues</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class GetInstanceAccessRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that contains the instance you want access to. You
        /// can use either the fleet ID or ARN value. The fleet can be in any of the following
        /// statuses: <code>ACTIVATING</code>, <code>ACTIVE</code>, or <code>ERROR</code>. Fleets
        /// with an <code>ERROR</code> status may be accessible for a short time before they are
        /// deleted.
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

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// A unique identifier for the instance you want to get access to. You can access an
        /// instance in any status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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