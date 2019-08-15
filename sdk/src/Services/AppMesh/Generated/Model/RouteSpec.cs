/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object representing the specification of a route.
    /// </summary>
    public partial class RouteSpec
    {
        private HttpRoute _httpRoute;
        private int? _priority;
        private TcpRoute _tcpRoute;

        /// <summary>
        /// Gets and sets the property HttpRoute. 
        /// <para>
        /// The HTTP routing information for the route.
        /// </para>
        /// </summary>
        public HttpRoute HttpRoute
        {
            get { return this._httpRoute; }
            set { this._httpRoute = value; }
        }

        // Check to see if HttpRoute property is set
        internal bool IsSetHttpRoute()
        {
            return this._httpRoute != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority for the route. Routes are matched based on the specified value, where
        /// 0 is         the highest priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TcpRoute. 
        /// <para>
        /// The TCP routing information for the route.
        /// </para>
        /// </summary>
        public TcpRoute TcpRoute
        {
            get { return this._tcpRoute; }
            set { this._tcpRoute = value; }
        }

        // Check to see if TcpRoute property is set
        internal bool IsSetTcpRoute()
        {
            return this._tcpRoute != null;
        }

    }
}