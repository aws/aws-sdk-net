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
    /// An object that represents a type of connection pool.
    /// </summary>
    public partial class VirtualNodeHttpConnectionPool
    {
        private int? _maxConnections;
        private int? _maxPendingRequests;

        /// <summary>
        /// Gets and sets the property MaxConnections. 
        /// <para>
        /// Maximum number of outbound TCP connections Envoy can establish concurrently with all
        /// hosts in upstream cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MaxConnections
        {
            get { return this._maxConnections; }
            set { this._maxConnections = value; }
        }

        // Check to see if MaxConnections property is set
        internal bool IsSetMaxConnections()
        {
            return this._maxConnections.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxPendingRequests. 
        /// <para>
        /// Number of overflowing requests after <c>max_connections</c> Envoy will queue to upstream
        /// cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxPendingRequests
        {
            get { return this._maxPendingRequests; }
            set { this._maxPendingRequests = value; }
        }

        // Check to see if MaxPendingRequests property is set
        internal bool IsSetMaxPendingRequests()
        {
            return this._maxPendingRequests.HasValue; 
        }

    }
}