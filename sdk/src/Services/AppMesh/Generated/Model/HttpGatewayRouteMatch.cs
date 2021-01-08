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
        private string _prefix;

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

    }
}