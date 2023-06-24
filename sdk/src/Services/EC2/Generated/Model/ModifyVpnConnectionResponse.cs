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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ModifyVpnConnection operation.
    /// </summary>
    public partial class ModifyVpnConnectionResponse : AmazonWebServiceResponse
    {
        private VpnConnection _vpnConnection;

        /// <summary>
        /// Gets and sets the property VpnConnection. 
        /// <para>
        /// Information about the VPN connection.
        /// </para>
        /// </summary>
        public VpnConnection VpnConnection
        {
            get { return this._vpnConnection; }
            set { this._vpnConnection = value; }
        }

        // Check to see if VpnConnection property is set
        internal bool IsSetVpnConnection()
        {
            return this._vpnConnection != null;
        }

    }
}