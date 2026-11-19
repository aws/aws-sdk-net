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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the client connection.
        /// </para>
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property CurrentStatus. 
        /// <para>
        /// A message about the status of the client connection, if applicable.
        /// </para>
        /// </summary>
        public ClientVpnConnectionStatus CurrentStatus { get; set; }

        /// <summary>
        /// Checks to see if the CurrentStatus property is set.
        /// </summary>
        internal bool IsSetCurrentStatus() => this.CurrentStatus != null;

        /// <summary>
        /// Gets and sets the property PreviousStatus. 
        /// <para>
        /// The state of the client connection.
        /// </para>
        /// </summary>
        public ClientVpnConnectionStatus PreviousStatus { get; set; }

        /// <summary>
        /// Checks to see if the PreviousStatus property is set.
        /// </summary>
        internal bool IsSetPreviousStatus() => this.PreviousStatus != null;
    }
}
