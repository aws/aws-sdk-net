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
    /// This is the response object from the GetTransitGatewayRegistrations operation.
    /// </summary>
    public partial class GetTransitGatewayRegistrationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TransitGatewayRegistration> _transitGatewayRegistrations = new List<TransitGatewayRegistration>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRegistrations. 
        /// <para>
        /// The transit gateway registrations.
        /// </para>
        /// </summary>
        public List<TransitGatewayRegistration> TransitGatewayRegistrations
        {
            get { return this._transitGatewayRegistrations; }
            set { this._transitGatewayRegistrations = value; }
        }

        // Check to see if TransitGatewayRegistrations property is set
        internal bool IsSetTransitGatewayRegistrations()
        {
            return this._transitGatewayRegistrations != null && this._transitGatewayRegistrations.Count > 0; 
        }

    }
}