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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Describes an inbound cross-cluster connection for Amazon OpenSearch Service. For more
    /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
    /// search for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class InboundConnection
    {
        private string _connectionId;
        private ConnectionMode _connectionMode;
        private InboundConnectionStatus _connectionStatus;
        private DomainInformationContainer _localDomainInfo;
        private DomainInformationContainer _remoteDomainInfo;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The unique identifier of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=256)]
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionMode. 
        /// <para>
        /// The connection mode.
        /// </para>
        /// </summary>
        public ConnectionMode ConnectionMode
        {
            get { return this._connectionMode; }
            set { this._connectionMode = value; }
        }

        // Check to see if ConnectionMode property is set
        internal bool IsSetConnectionMode()
        {
            return this._connectionMode != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// The current status of the connection.
        /// </para>
        /// </summary>
        public InboundConnectionStatus ConnectionStatus
        {
            get { return this._connectionStatus; }
            set { this._connectionStatus = value; }
        }

        // Check to see if ConnectionStatus property is set
        internal bool IsSetConnectionStatus()
        {
            return this._connectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LocalDomainInfo. 
        /// <para>
        /// Information about the source (local) domain.
        /// </para>
        /// </summary>
        public DomainInformationContainer LocalDomainInfo
        {
            get { return this._localDomainInfo; }
            set { this._localDomainInfo = value; }
        }

        // Check to see if LocalDomainInfo property is set
        internal bool IsSetLocalDomainInfo()
        {
            return this._localDomainInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteDomainInfo. 
        /// <para>
        /// Information about the destination (remote) domain.
        /// </para>
        /// </summary>
        public DomainInformationContainer RemoteDomainInfo
        {
            get { return this._remoteDomainInfo; }
            set { this._remoteDomainInfo = value; }
        }

        // Check to see if RemoteDomainInfo property is set
        internal bool IsSetRemoteDomainInfo()
        {
            return this._remoteDomainInfo != null;
        }

    }
}