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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// The result of a <code><a>CreateOutboundCrossClusterSearchConnection</a></code> request.
    /// Contains the details of the newly created cross-cluster search connection.
    /// </summary>
    public partial class CreateOutboundCrossClusterSearchConnectionResponse : AmazonWebServiceResponse
    {
        private string _connectionAlias;
        private OutboundCrossClusterSearchConnectionStatus _connectionStatus;
        private string _crossClusterSearchConnectionId;
        private DomainInformation _destinationDomainInfo;
        private DomainInformation _sourceDomainInfo;

        /// <summary>
        /// Gets and sets the property ConnectionAlias. 
        /// <para>
        /// Specifies the connection alias provided during the create connection request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public string ConnectionAlias
        {
            get { return this._connectionAlias; }
            set { this._connectionAlias = value; }
        }

        // Check to see if ConnectionAlias property is set
        internal bool IsSetConnectionAlias()
        {
            return this._connectionAlias != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// Specifies the <code><a>OutboundCrossClusterSearchConnectionStatus</a></code> for the
        /// newly created connection.
        /// </para>
        /// </summary>
        public OutboundCrossClusterSearchConnectionStatus ConnectionStatus
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
        /// Gets and sets the property CrossClusterSearchConnectionId. 
        /// <para>
        /// Unique id for the created outbound connection, which is used for subsequent operations
        /// on connection.
        /// </para>
        /// </summary>
        public string CrossClusterSearchConnectionId
        {
            get { return this._crossClusterSearchConnectionId; }
            set { this._crossClusterSearchConnectionId = value; }
        }

        // Check to see if CrossClusterSearchConnectionId property is set
        internal bool IsSetCrossClusterSearchConnectionId()
        {
            return this._crossClusterSearchConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationDomainInfo. 
        /// <para>
        /// Specifies the <code><a>DomainInformation</a></code> for the destination Elasticsearch
        /// domain.
        /// </para>
        /// </summary>
        public DomainInformation DestinationDomainInfo
        {
            get { return this._destinationDomainInfo; }
            set { this._destinationDomainInfo = value; }
        }

        // Check to see if DestinationDomainInfo property is set
        internal bool IsSetDestinationDomainInfo()
        {
            return this._destinationDomainInfo != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDomainInfo. 
        /// <para>
        /// Specifies the <code><a>DomainInformation</a></code> for the source Elasticsearch domain.
        /// </para>
        /// </summary>
        public DomainInformation SourceDomainInfo
        {
            get { return this._sourceDomainInfo; }
            set { this._sourceDomainInfo = value; }
        }

        // Check to see if SourceDomainInfo property is set
        internal bool IsSetSourceDomainInfo()
        {
            return this._sourceDomainInfo != null;
        }

    }
}