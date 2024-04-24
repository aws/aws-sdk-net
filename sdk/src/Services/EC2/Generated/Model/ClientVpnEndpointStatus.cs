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
    /// Describes the state of a Client VPN endpoint.
    /// </summary>
    public partial class ClientVpnEndpointStatus
    {
        private ClientVpnEndpointStatusCode _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The state of the Client VPN endpoint. Possible states include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>pending-associate</c> - The Client VPN endpoint has been created but no target
        /// networks have been associated. The Client VPN endpoint cannot accept connections.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c> - The Client VPN endpoint has been created and a target network
        /// has been associated. The Client VPN endpoint can accept connections.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c> - The Client VPN endpoint is being deleted. The Client VPN endpoint
        /// cannot accept connections.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c> - The Client VPN endpoint has been deleted. The Client VPN endpoint
        /// cannot accept connections.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClientVpnEndpointStatusCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the status of the Client VPN endpoint.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}