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
    /// Container for the parameters to the ListGatewayRoutes operation.
    /// Returns a list of existing gateway routes that are associated to a virtual gateway.
    /// </summary>
    public partial class ListGatewayRoutesRequest : AmazonAppMeshRequest
    {
        private int? _limit;
        private string _meshName;
        private string _meshOwner;
        private string _nextToken;
        private string _virtualGatewayName;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results returned by <code>ListGatewayRoutes</code> in paginated
        /// output. When you use this parameter, <code>ListGatewayRoutes</code> returns only <code>limit</code>
        /// results in a single page along with a <code>nextToken</code> response element. You
        /// can see the remaining results of the initial request by sending another <code>ListGatewayRoutes</code>
        /// request with the returned <code>nextToken</code> value. This value can be between
        /// 1 and 100. If you don't use this parameter, <code>ListGatewayRoutes</code> returns
        /// up to 100 results and a <code>nextToken</code> value if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MeshName. 
        /// <para>
        /// The name of the service mesh to list gateway routes in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MeshName
        {
            get { return this._meshName; }
            set { this._meshName = value; }
        }

        // Check to see if MeshName property is set
        internal bool IsSetMeshName()
        {
            return this._meshName != null;
        }

        /// <summary>
        /// Gets and sets the property MeshOwner. 
        /// <para>
        /// The AWS IAM account ID of the service mesh owner. If the account ID is not your own,
        /// then it's the ID of the account that shared the mesh with your account. For more information
        /// about mesh sharing, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/sharing.html">Working
        /// with shared meshes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string MeshOwner
        {
            get { return this._meshOwner; }
            set { this._meshOwner = value; }
        }

        // Check to see if MeshOwner property is set
        internal bool IsSetMeshOwner()
        {
            return this._meshOwner != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListGatewayRoutes</code>
        /// request where <code>limit</code> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <code>nextToken</code> value.
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
        /// Gets and sets the property VirtualGatewayName. 
        /// <para>
        /// The name of the virtual gateway to list gateway routes in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string VirtualGatewayName
        {
            get { return this._virtualGatewayName; }
            set { this._virtualGatewayName = value; }
        }

        // Check to see if VirtualGatewayName property is set
        internal bool IsSetVirtualGatewayName()
        {
            return this._virtualGatewayName != null;
        }

    }
}