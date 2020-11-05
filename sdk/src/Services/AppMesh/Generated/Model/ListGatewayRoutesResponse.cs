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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// This is the response object from the ListGatewayRoutes operation.
    /// </summary>
    public partial class ListGatewayRoutesResponse : AmazonWebServiceResponse
    {
        private List<GatewayRouteRef> _gatewayRoutes = new List<GatewayRouteRef>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GatewayRoutes. 
        /// <para>
        /// The list of existing gateway routes for the specified service mesh and virtual gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GatewayRouteRef> GatewayRoutes
        {
            get { return this._gatewayRoutes; }
            set { this._gatewayRoutes = value; }
        }

        // Check to see if GatewayRoutes property is set
        internal bool IsSetGatewayRoutes()
        {
            return this._gatewayRoutes != null && this._gatewayRoutes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>ListGatewayRoutes</code>
        /// request. When the results of a <code>ListGatewayRoutes</code> request exceed <code>limit</code>,
        /// you can use this value to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
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