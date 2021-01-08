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
    /// Contains the output of DescribeVpnGateways.
    /// </summary>
    public partial class DescribeVpnGatewaysResponse : AmazonWebServiceResponse
    {
        private List<VpnGateway> _vpnGateways = new List<VpnGateway>();

        /// <summary>
        /// Gets and sets the property VpnGateways. 
        /// <para>
        /// Information about one or more virtual private gateways.
        /// </para>
        /// </summary>
        public List<VpnGateway> VpnGateways
        {
            get { return this._vpnGateways; }
            set { this._vpnGateways = value; }
        }

        // Check to see if VpnGateways property is set
        internal bool IsSetVpnGateways()
        {
            return this._vpnGateways != null && this._vpnGateways.Count > 0; 
        }

    }
}