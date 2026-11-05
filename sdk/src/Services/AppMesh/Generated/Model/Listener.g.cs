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
    /// An object that represents a listener for a virtual node.
    /// </summary>
    public partial class Listener
    {
        /// <summary>
        /// Gets and sets the property ConnectionPool. 
        /// <para>
        /// The connection pool information for the listener.
        /// </para>
        /// </summary>
        public VirtualNodeConnectionPool ConnectionPool { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionPool property is set.
        /// </summary>
        internal bool IsSetConnectionPool() => this.ConnectionPool != null;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The health check information for the listener.
        /// </para>
        /// </summary>
        public HealthCheckPolicy HealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheck property is set.
        /// </summary>
        internal bool IsSetHealthCheck() => this.HealthCheck != null;

        /// <summary>
        /// Gets and sets the property OutlierDetection. 
        /// <para>
        /// The outlier detection information for the listener.
        /// </para>
        /// </summary>
        public OutlierDetection OutlierDetection { get; set; }

        /// <summary>
        /// Checks to see if the OutlierDetection property is set.
        /// </summary>
        internal bool IsSetOutlierDetection() => this.OutlierDetection != null;

        /// <summary>
        /// Gets and sets the property PortMapping. 
        /// <para>
        /// The port mapping information for the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PortMapping PortMapping { get; set; }

        /// <summary>
        /// Checks to see if the PortMapping property is set.
        /// </summary>
        internal bool IsSetPortMapping() => this.PortMapping != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// An object that represents timeouts for different protocols.
        /// </para>
        /// </summary>
        public ListenerTimeout Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout != null;

        /// <summary>
        /// Gets and sets the property Tls. 
        /// <para>
        /// A reference to an object that represents the Transport Layer Security (TLS) properties
        /// for a listener.
        /// </para>
        /// </summary>
        public ListenerTls Tls { get; set; }

        /// <summary>
        /// Checks to see if the Tls property is set.
        /// </summary>
        internal bool IsSetTls() => this.Tls != null;
    }
}
