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
    /// An object that represents the type of virtual node connection pool.
    /// 
    ///  
    /// <para>
    /// Only one protocol is used at a time and should be the same protocol as the one chosen
    /// under port mapping.
    /// </para>
    ///  
    /// <para>
    /// If not present the default value for <c>maxPendingRequests</c> is <c>2147483647</c>.
    /// </para>
    /// </summary>
    public partial class VirtualNodeConnectionPool
    {
        /// <summary>
        /// Gets and sets the property Grpc. 
        /// <para>
        /// An object that represents a type of connection pool.
        /// </para>
        /// </summary>
        public VirtualNodeGrpcConnectionPool Grpc { get; set; }

        /// <summary>
        /// Checks to see if the Grpc property is set.
        /// </summary>
        internal bool IsSetGrpc() => this.Grpc != null;

        /// <summary>
        /// Gets and sets the property Http. 
        /// <para>
        /// An object that represents a type of connection pool.
        /// </para>
        /// </summary>
        public VirtualNodeHttpConnectionPool Http { get; set; }

        /// <summary>
        /// Checks to see if the Http property is set.
        /// </summary>
        internal bool IsSetHttp() => this.Http != null;

        /// <summary>
        /// Gets and sets the property Http2. 
        /// <para>
        /// An object that represents a type of connection pool.
        /// </para>
        /// </summary>
        public VirtualNodeHttp2ConnectionPool Http2 { get; set; }

        /// <summary>
        /// Checks to see if the Http2 property is set.
        /// </summary>
        internal bool IsSetHttp2() => this.Http2 != null;

        /// <summary>
        /// Gets and sets the property Tcp. 
        /// <para>
        /// An object that represents a type of connection pool.
        /// </para>
        /// </summary>
        public VirtualNodeTcpConnectionPool Tcp { get; set; }

        /// <summary>
        /// Checks to see if the Tcp property is set.
        /// </summary>
        internal bool IsSetTcp() => this.Tcp != null;
    }
}
