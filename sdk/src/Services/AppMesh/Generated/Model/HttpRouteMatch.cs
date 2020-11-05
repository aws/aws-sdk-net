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
    /// An object that represents the requirements for a route to match HTTP requests for
    /// a virtual router.
    /// </summary>
    public partial class HttpRouteMatch
    {
        private List<HttpRouteHeader> _headers = new List<HttpRouteHeader>();
        private HttpMethod _method;
        private string _prefix;
        private HttpScheme _scheme;

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// An object that represents the client request headers to match on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<HttpRouteHeader> Headers
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
        /// Gets and sets the property Method. 
        /// <para>
        /// The client request method to match on. Specify only one.
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
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Specifies the path to match requests with. This parameter must always start with <code>/</code>,
        /// which by itself matches all requests to the virtual service name. You can also match
        /// for path-based routing of requests. For example, if your virtual service name is <code>my-service.local</code>
        /// and you want the route to match requests to <code>my-service.local/metrics</code>,
        /// your prefix should be <code>/metrics</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Scheme. 
        /// <para>
        /// The client request scheme to match on. Specify only one.
        /// </para>
        /// </summary>
        public HttpScheme Scheme
        {
            get { return this._scheme; }
            set { this._scheme = value; }
        }

        // Check to see if Scheme property is set
        internal bool IsSetScheme()
        {
            return this._scheme != null;
        }

    }
}