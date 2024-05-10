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
    /// An object that represents the action to take if a match is determined.
    /// </summary>
    public partial class HttpGatewayRouteAction
    {
        private HttpGatewayRouteRewrite _rewrite;
        private GatewayRouteTarget _target;

        /// <summary>
        /// Gets and sets the property Rewrite. 
        /// <para>
        /// The gateway route action to rewrite.
        /// </para>
        /// </summary>
        public HttpGatewayRouteRewrite Rewrite
        {
            get { return this._rewrite; }
            set { this._rewrite = value; }
        }

        // Check to see if Rewrite property is set
        internal bool IsSetRewrite()
        {
            return this._rewrite != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// An object that represents the target that traffic is routed to when a request matches
        /// the gateway route.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayRouteTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}