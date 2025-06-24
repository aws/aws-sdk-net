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
    /// Container for the parameters to the GetInstanceAccess operation.
    /// Requests authorization to remotely connect to an instance in an Amazon GameLift Servers
    /// managed fleet. Use this operation to connect to instances with game servers that use
    /// Amazon GameLift Servers server SDK 4.x or earlier. To connect to instances with game
    /// servers that use server SDK 5.x or later, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetComputeAccess">https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetComputeAccess</a>.
    /// 
    ///  
    /// <para>
    /// To request access to an instance, specify IDs for the instance and the fleet it belongs
    /// to. You can retrieve instance IDs for a fleet by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeInstances.html">DescribeInstances</a>
    /// with the fleet ID. 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns an IP address and credentials. The returned
    /// credentials match the operating system of the instance, as follows: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For a Windows instance: returns a user name and secret (password) for use with a Windows
    /// Remote Desktop client. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a Linux instance: returns a user name and secret (RSA private key) for use with
    /// an SSH client. You must save the secret to a <c>.pem</c> file. If you're using the
    /// CLI, see the example <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetInstanceAccess.html#API_GetInstanceAccess_Examples">
    /// Get credentials for a Linux instance</a> for tips on automatically saving the secret
    /// to a <c>.pem</c> file. 
    /// </para>
    ///  </li> </ul> 
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
        /// A unique identifier for the fleet that contains the instance you want to access. You
        /// can request access to instances in EC2 fleets with the following statuses: <c>ACTIVATING</c>,
        /// <c>ACTIVE</c>, or <c>ERROR</c>. Use either a fleet ID or an ARN value. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can access fleets in <c>ERROR</c> status for a short period of time before Amazon
        /// GameLift Servers deletes them.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// A unique identifier for the instance you want to access. You can access an instance
        /// in any status.
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