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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Rewrite. 
        /// <para>
        /// The gateway route action to rewrite.
        /// </para>
        /// </summary>
        public HttpGatewayRouteRewrite Rewrite { get; set; }

        /// <summary>
        /// Checks to see if the Rewrite property is set.
        /// </summary>
        internal bool IsSetRewrite() => this.Rewrite != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// An object that represents the target that traffic is routed to when a request matches
        /// the gateway route.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GatewayRouteTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
