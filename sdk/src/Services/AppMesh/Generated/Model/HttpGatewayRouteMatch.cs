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
    /// An object that represents the criteria for determining a request match.
    /// </summary>
    public partial class HttpGatewayRouteMatch
    {
        private List<HttpGatewayRouteHeader> _headers = new List<HttpGatewayRouteHeader>();
        private GatewayRouteHostnameMatch _hostname;
        private HttpMethod _method;
        private HttpPathMatch _path;
        private string _prefix;
        private List<HttpQueryParameter> _queryParameters = new List<HttpQueryParameter>();

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// The client request headers to match on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<HttpGatewayRouteHeader> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && this._headers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name to match on.
        /// </para>
        /// </summary>
        public GatewayRouteHostnameMatch Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The method to match on.
        /// </para>
        /// </summary>
        public HttpMethod Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        // Check to see if Method property is set
        internal bool IsSetMethod()
        {
            return this._method != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to match on.
        /// </para>
        /// </summary>
        public HttpPathMatch Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Specifies the path to match requests with. This parameter must always start with <code>/</code>,
        /// which by itself matches all requests to the virtual service name. You can also match
        /// for path-based routing of requests. For example, if your virtual service name is <code>my-service.local</code>
        /// and you want the route to match requests to <code>my-service.local/metrics</code>,
        /// your prefix should be <code>/metrics</code>.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// The query parameter to match on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<HttpQueryParameter> QueryParameters
        {
            get { return this._queryParameters; }
            set { this._queryParameters = value; }
        }

        // Check to see if QueryParameters property is set
        internal bool IsSetQueryParameters()
        {
            return this._queryParameters != null && this._queryParameters.Count > 0; 
        }

    }
}