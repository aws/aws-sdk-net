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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a route table.
    /// </summary>
    public partial class RouteTableIdentifier
    {
        private string _transitGatewayRouteTableArn;

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableArn. 
        /// <para>
        /// The ARN of the transit gateway route table.
        /// </para>
        /// </summary>
        public string TransitGatewayRouteTableArn
        {
            get { return this._transitGatewayRouteTableArn; }
            set { this._transitGatewayRouteTableArn = value; }
        }

        // Check to see if TransitGatewayRouteTableArn property is set
        internal bool IsSetTransitGatewayRouteTableArn()
        {
            return this._transitGatewayRouteTableArn != null;
        }

    }
}