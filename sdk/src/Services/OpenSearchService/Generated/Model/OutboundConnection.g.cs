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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Specifies details about an outbound cross-cluster connection.
    /// </summary>
    public partial class OutboundConnection
    {
        /// <summary>
        /// Gets and sets the property ConnectionAlias. 
        /// <para>
        /// Name of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string ConnectionAlias { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionAlias property is set.
        /// </summary>
        internal bool IsSetConnectionAlias() => this.ConnectionAlias != null;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// Unique identifier of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 256)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property ConnectionMode. 
        /// <para>
        /// The connection mode.
        /// </para>
        /// </summary>
        public ConnectionMode ConnectionMode { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionMode property is set.
        /// </summary>
        internal bool IsSetConnectionMode() => this.ConnectionMode != null;

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// Properties for the outbound connection.
        /// </para>
        /// </summary>
        public ConnectionProperties ConnectionProperties { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionProperties property is set.
        /// </summary>
        internal bool IsSetConnectionProperties() => this.ConnectionProperties != null;

        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// Status of the connection.
        /// </para>
        /// </summary>
        public OutboundConnectionStatus ConnectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionStatus property is set.
        /// </summary>
        internal bool IsSetConnectionStatus() => this.ConnectionStatus != null;

        /// <summary>
        /// Gets and sets the property LocalDomainInfo. 
        /// <para>
        /// Information about the source (local) domain.
        /// </para>
        /// </summary>
        public DomainInformationContainer LocalDomainInfo { get; set; }

        /// <summary>
        /// Checks to see if the LocalDomainInfo property is set.
        /// </summary>
        internal bool IsSetLocalDomainInfo() => this.LocalDomainInfo != null;

        /// <summary>
        /// Gets and sets the property RemoteDomainInfo. 
        /// <para>
        /// Information about the destination (remote) domain.
        /// </para>
        /// </summary>
        public DomainInformationContainer RemoteDomainInfo { get; set; }

        /// <summary>
        /// Checks to see if the RemoteDomainInfo property is set.
        /// </summary>
        internal bool IsSetRemoteDomainInfo() => this.RemoteDomainInfo != null;
    }
}
