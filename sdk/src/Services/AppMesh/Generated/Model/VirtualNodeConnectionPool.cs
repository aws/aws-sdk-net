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
        private VirtualNodeGrpcConnectionPool _grpc;
        private VirtualNodeHttpConnectionPool _http;
        private VirtualNodeHttp2ConnectionPool _http2;
        private VirtualNodeTcpConnectionPool _tcp;

        /// <summary>
        /// Gets and sets the property Grpc. 
        /// <para>
        /// An object that represents a type of connection pool.
        /// </para>
        /// </summary>
        public VirtualNodeGrpcConnectionPool Grpc
        {
            get { return this._grpc; }
            set { this._grpc = value; }
        }

        // Check to see if Grpc property is set
        internal bool IsSetGrpc()
        {
            return this._grpc != null;
        }

        /// <summary>
        /// Gets and sets the property Http. 
        /// <para>
        /// An object that represents a type of connection pool.
        /// </para>
        /// </summary>
        public VirtualNodeHttpConnectionPool Http
        {
            get { return this._http; }
            set { this._http = value; }
        }

        // Check to see if Http property is set
        internal bool IsSetHttp()
        {
            return this._http != null;
        }

        /// <summary>
        /// Gets and sets the property Http2. 
        /// <para>
        /// An object that represents a type of connection pool.
        /// </para>
        /// </summary>
        public VirtualNodeHttp2ConnectionPool Http2
        {
            get { return this._http2; }
            set { this._http2 = value; }
        }

        // Check to see if Http2 property is set
        internal bool IsSetHttp2()
        {
            return this._http2 != null;
        }

        /// <summary>
        /// Gets and sets the property Tcp. 
        /// <para>
        /// An object that represents a type of connection pool.
        /// </para>
        /// </summary>
        public VirtualNodeTcpConnectionPool Tcp
        {
            get { return this._tcp; }
            set { this._tcp = value; }
        }

        // Check to see if Tcp property is set
        internal bool IsSetTcp()
        {
            return this._tcp != null;
        }

    }
}