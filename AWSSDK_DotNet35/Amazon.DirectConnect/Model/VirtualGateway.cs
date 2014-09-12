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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// You can create one or more AWS Direct Connect private virtual interfaces linking to
    /// your virtual private gateway.
    /// 
    ///  
    /// <para>
    /// Virtual private gateways can be managed using the Amazon Virtual Private Cloud (Amazon
    /// VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">Amazon
    /// EC2 CreateVpnGateway action</a>.
    /// </para>
    /// </summary>
    public partial class VirtualGateway
    {
        private string _virtualGatewayId;
        private string _virtualGatewayState;

        /// <summary>
        /// Gets and sets the property VirtualGatewayId.
        /// </summary>
        public string VirtualGatewayId
        {
            get { return this._virtualGatewayId; }
            set { this._virtualGatewayId = value; }
        }

        // Check to see if VirtualGatewayId property is set
        internal bool IsSetVirtualGatewayId()
        {
            return this._virtualGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualGatewayState.
        /// </summary>
        public string VirtualGatewayState
        {
            get { return this._virtualGatewayState; }
            set { this._virtualGatewayState = value; }
        }

        // Check to see if VirtualGatewayState property is set
        internal bool IsSetVirtualGatewayState()
        {
            return this._virtualGatewayState != null;
        }

    }
}