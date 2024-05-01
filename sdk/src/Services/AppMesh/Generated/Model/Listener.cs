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
    /// An object that represents a listener for a virtual node.
    /// </summary>
    public partial class Listener
    {
        private VirtualNodeConnectionPool _connectionPool;
        private HealthCheckPolicy _healthCheck;
        private OutlierDetection _outlierDetection;
        private PortMapping _portMapping;
        private ListenerTimeout _timeout;
        private ListenerTls _tls;

        /// <summary>
        /// Gets and sets the property ConnectionPool. 
        /// <para>
        /// The connection pool information for the listener.
        /// </para>
        /// </summary>
        public VirtualNodeConnectionPool ConnectionPool
        {
            get { return this._connectionPool; }
            set { this._connectionPool = value; }
        }

        // Check to see if ConnectionPool property is set
        internal bool IsSetConnectionPool()
        {
            return this._connectionPool != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The health check information for the listener.
        /// </para>
        /// </summary>
        public HealthCheckPolicy HealthCheck
        {
            get { return this._healthCheck; }
            set { this._healthCheck = value; }
        }

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this._healthCheck != null;
        }

        /// <summary>
        /// Gets and sets the property OutlierDetection. 
        /// <para>
        /// The outlier detection information for the listener.
        /// </para>
        /// </summary>
        public OutlierDetection OutlierDetection
        {
            get { return this._outlierDetection; }
            set { this._outlierDetection = value; }
        }

        // Check to see if OutlierDetection property is set
        internal bool IsSetOutlierDetection()
        {
            return this._outlierDetection != null;
        }

        /// <summary>
        /// Gets and sets the property PortMapping. 
        /// <para>
        /// The port mapping information for the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PortMapping PortMapping
        {
            get { return this._portMapping; }
            set { this._portMapping = value; }
        }

        // Check to see if PortMapping property is set
        internal bool IsSetPortMapping()
        {
            return this._portMapping != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// An object that represents timeouts for different protocols.
        /// </para>
        /// </summary>
        public ListenerTimeout Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout != null;
        }

        /// <summary>
        /// Gets and sets the property Tls. 
        /// <para>
        /// A reference to an object that represents the Transport Layer Security (TLS) properties
        /// for a listener.
        /// </para>
        /// </summary>
        public ListenerTls Tls
        {
            get { return this._tls; }
            set { this._tls = value; }
        }

        // Check to see if Tls property is set
        internal bool IsSetTls()
        {
            return this._tls != null;
        }

    }
}