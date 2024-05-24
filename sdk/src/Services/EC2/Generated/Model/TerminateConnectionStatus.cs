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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about a terminated Client VPN endpoint client connection.
    /// </summary>
    public partial class TerminateConnectionStatus
    {
        private string _connectionId;
        private ClientVpnConnectionStatus _currentStatus;
        private ClientVpnConnectionStatus _previousStatus;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the client connection.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentStatus. 
        /// <para>
        /// A message about the status of the client connection, if applicable.
        /// </para>
        /// </summary>
        public ClientVpnConnectionStatus CurrentStatus
        {
            get { return this._currentStatus; }
            set { this._currentStatus = value; }
        }

        // Check to see if CurrentStatus property is set
        internal bool IsSetCurrentStatus()
        {
            return this._currentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousStatus. 
        /// <para>
        /// The state of the client connection.
        /// </para>
        /// </summary>
        public ClientVpnConnectionStatus PreviousStatus
        {
            get { return this._previousStatus; }
            set { this._previousStatus = value; }
        }

        // Check to see if PreviousStatus property is set
        internal bool IsSetPreviousStatus()
        {
            return this._previousStatus != null;
        }

    }
}