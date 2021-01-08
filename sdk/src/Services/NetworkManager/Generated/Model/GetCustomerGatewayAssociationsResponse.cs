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
    /// This is the response object from the GetCustomerGatewayAssociations operation.
    /// </summary>
    public partial class GetCustomerGatewayAssociationsResponse : AmazonWebServiceResponse
    {
        private List<CustomerGatewayAssociation> _customerGatewayAssociations = new List<CustomerGatewayAssociation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CustomerGatewayAssociations. 
        /// <para>
        /// The customer gateway associations.
        /// </para>
        /// </summary>
        public List<CustomerGatewayAssociation> CustomerGatewayAssociations
        {
            get { return this._customerGatewayAssociations; }
            set { this._customerGatewayAssociations = value; }
        }

        // Check to see if CustomerGatewayAssociations property is set
        internal bool IsSetCustomerGatewayAssociations()
        {
            return this._customerGatewayAssociations != null && this._customerGatewayAssociations.Count > 0; 
        }

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

    }
}