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
    /// the fleet it belongs to.
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
    /// </summary>
    public partial class GetComputeAccessRequest : AmazonGameLiftRequest
    {
        private string _computeName;
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// The name of the compute resource you are requesting credentials for.
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
        /// A unique identifier for the fleet that the compute resource is registered to.
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