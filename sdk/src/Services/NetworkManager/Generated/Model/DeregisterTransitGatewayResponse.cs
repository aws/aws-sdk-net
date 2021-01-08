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
    /// This is the response object from the DeregisterTransitGateway operation.
    /// </summary>
    public partial class DeregisterTransitGatewayResponse : AmazonWebServiceResponse
    {
        private TransitGatewayRegistration _transitGatewayRegistration;

        /// <summary>
        /// Gets and sets the property TransitGatewayRegistration. 
        /// <para>
        /// The transit gateway registration information.
        /// </para>
        /// </summary>
        public TransitGatewayRegistration TransitGatewayRegistration
        {
            get { return this._transitGatewayRegistration; }
            set { this._transitGatewayRegistration = value; }
        }

        // Check to see if TransitGatewayRegistration property is set
        internal bool IsSetTransitGatewayRegistration()
        {
            return this._transitGatewayRegistration != null;
        }

    }
}