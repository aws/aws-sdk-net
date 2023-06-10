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
    /// Container for the parameters to the CreateOutboundConnection operation.
    /// Creates a new cross-cluster search connection from a source Amazon OpenSearch Service
    /// domain to a destination domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
    /// search for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class CreateOutboundConnectionRequest : AmazonOpenSearchServiceRequest
    {
        private string _connectionAlias;
        private ConnectionMode _connectionMode;
        private DomainInformationContainer _localDomainInfo;
        private DomainInformationContainer _remoteDomainInfo;

        /// <summary>
        /// Gets and sets the property ConnectionAlias. 
        /// <para>
        /// Name of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
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
        /// Gets and sets the property LocalDomainInfo. 
        /// <para>
        /// Name and Region of the source (local) domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Name and Region of the destination (remote) domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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