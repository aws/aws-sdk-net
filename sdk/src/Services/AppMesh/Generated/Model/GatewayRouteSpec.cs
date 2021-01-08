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
    /// An object that represents a gateway route specification. Specify one gateway route
    /// type.
    /// </summary>
    public partial class GatewayRouteSpec
    {
        private GrpcGatewayRoute _grpcRoute;
        private HttpGatewayRoute _http2Route;
        private HttpGatewayRoute _httpRoute;

        /// <summary>
        /// Gets and sets the property GrpcRoute. 
        /// <para>
        /// An object that represents the specification of a gRPC gateway route.
        /// </para>
        /// </summary>
        public GrpcGatewayRoute GrpcRoute
        {
            get { return this._grpcRoute; }
            set { this._grpcRoute = value; }
        }

        // Check to see if GrpcRoute property is set
        internal bool IsSetGrpcRoute()
        {
            return this._grpcRoute != null;
        }

        /// <summary>
        /// Gets and sets the property Http2Route. 
        /// <para>
        /// An object that represents the specification of an HTTP/2 gateway route.
        /// </para>
        /// </summary>
        public HttpGatewayRoute Http2Route
        {
            get { return this._http2Route; }
            set { this._http2Route = value; }
        }

        // Check to see if Http2Route property is set
        internal bool IsSetHttp2Route()
        {
            return this._http2Route != null;
        }

        /// <summary>
        /// Gets and sets the property HttpRoute. 
        /// <para>
        /// An object that represents the specification of an HTTP gateway route.
        /// </para>
        /// </summary>
        public HttpGatewayRoute HttpRoute
        {
            get { return this._httpRoute; }
            set { this._httpRoute = value; }
        }

        // Check to see if HttpRoute property is set
        internal bool IsSetHttpRoute()
        {
            return this._httpRoute != null;
        }

    }
}