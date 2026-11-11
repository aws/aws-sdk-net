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
    /// An object that represents a route specification. Specify one route type.
    /// </summary>
    public partial class RouteSpec
    {
        /// <summary>
        /// Gets and sets the property GrpcRoute. 
        /// <para>
        /// An object that represents the specification of a gRPC route.
        /// </para>
        /// </summary>
        public GrpcRoute GrpcRoute { get; set; }

        /// <summary>
        /// Checks to see if the GrpcRoute property is set.
        /// </summary>
        internal bool IsSetGrpcRoute() => this.GrpcRoute != null;

        /// <summary>
        /// Gets and sets the property Http2Route. 
        /// <para>
        /// An object that represents the specification of an HTTP/2 route.
        /// </para>
        /// </summary>
        public HttpRoute Http2Route { get; set; }

        /// <summary>
        /// Checks to see if the Http2Route property is set.
        /// </summary>
        internal bool IsSetHttp2Route() => this.Http2Route != null;

        /// <summary>
        /// Gets and sets the property HttpRoute. 
        /// <para>
        /// An object that represents the specification of an HTTP route.
        /// </para>
        /// </summary>
        public HttpRoute HttpRoute { get; set; }

        /// <summary>
        /// Checks to see if the HttpRoute property is set.
        /// </summary>
        internal bool IsSetHttpRoute() => this.HttpRoute != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority for the route. Routes are matched based on the specified value, where
        /// 0 is the highest priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property TcpRoute. 
        /// <para>
        /// An object that represents the specification of a TCP route.
        /// </para>
        /// </summary>
        public TcpRoute TcpRoute { get; set; }

        /// <summary>
        /// Checks to see if the TcpRoute property is set.
        /// </summary>
        internal bool IsSetTcpRoute() => this.TcpRoute != null;
    }
}
