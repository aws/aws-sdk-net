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
    /// An object that represents an HTTP gateway route.
    /// </summary>
    public partial class HttpGatewayRoute
    {
        private HttpGatewayRouteAction _action;
        private HttpGatewayRouteMatch _match;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// An object that represents the action to take if a match is determined.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HttpGatewayRouteAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// An object that represents the criteria for determining a request match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HttpGatewayRouteMatch Match
        {
            get { return this._match; }
            set { this._match = value; }
        }

        // Check to see if Match property is set
        internal bool IsSetMatch()
        {
            return this._match != null;
        }

    }
}