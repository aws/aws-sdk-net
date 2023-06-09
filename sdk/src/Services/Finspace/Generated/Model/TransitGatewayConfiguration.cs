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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The structure of the transit gateway and network configuration that is used to connect
    /// the kdb environment to an internal network.
    /// </summary>
    public partial class TransitGatewayConfiguration
    {
        private string _routablecidrSpace;
        private string _transitGatewayID;

        /// <summary>
        /// Gets and sets the property RoutableCIDRSpace. 
        /// <para>
        /// The routing CIDR on behalf of kdb environment. It could be any "/26 range in the 100.64.0.0
        /// CIDR space. After providing, it will be added to the customer's transit gateway routing
        /// table so that the traffics could be routed to kdb network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoutableCIDRSpace
        {
            get { return this._routablecidrSpace; }
            set { this._routablecidrSpace = value; }
        }

        // Check to see if RoutableCIDRSpace property is set
        internal bool IsSetRoutableCIDRSpace()
        {
            return this._routablecidrSpace != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayID. 
        /// <para>
        /// The identifier of the transit gateway created by the customer to connect outbound
        /// traffics from kdb network to your internal network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string TransitGatewayID
        {
            get { return this._transitGatewayID; }
            set { this._transitGatewayID = value; }
        }

        // Check to see if TransitGatewayID property is set
        internal bool IsSetTransitGatewayID()
        {
            return this._transitGatewayID != null;
        }

    }
}