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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object representing the gateway route to rewrite.
    /// </summary>
    public partial class HttpGatewayRouteRewrite
    {
        private GatewayRouteHostnameRewrite _hostname;
        private HttpGatewayRoutePathRewrite _path;
        private HttpGatewayRoutePrefixRewrite _prefix;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name to rewrite.
        /// </para>
        /// </summary>
        public GatewayRouteHostnameRewrite Hostname
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to rewrite.
        /// </para>
        /// </summary>
        public HttpGatewayRoutePathRewrite Path
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
        /// The specified beginning characters to rewrite.
        /// </para>
        /// </summary>
        public HttpGatewayRoutePrefixRewrite Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}