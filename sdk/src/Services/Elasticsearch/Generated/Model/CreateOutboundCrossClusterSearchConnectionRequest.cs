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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOutboundCrossClusterSearchConnection operation.
    /// Creates a new cross-cluster search connection from a source domain to a destination
    /// domain.
    /// </summary>
    public partial class CreateOutboundCrossClusterSearchConnectionRequest : AmazonElasticsearchRequest
    {
        private string _connectionAlias;
        private DomainInformation _destinationDomainInfo;
        private DomainInformation _sourceDomainInfo;

        /// <summary>
        /// Gets and sets the property ConnectionAlias. 
        /// <para>
        /// Specifies the connection alias that will be used by the customer for this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=20)]
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
        /// Gets and sets the property DestinationDomainInfo. 
        /// <para>
        /// Specifies the <c><a>DomainInformation</a></c> for the destination Elasticsearch domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Specifies the <c><a>DomainInformation</a></c> for the source Elasticsearch domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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