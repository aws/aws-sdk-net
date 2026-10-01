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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies details of an inbound connection.
    /// </summary>
    public partial class InboundCrossClusterSearchConnection
    {
        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// Specifies the <c><a>InboundCrossClusterSearchConnectionStatus</a></c> for the outbound
        /// connection.
        /// </para>
        /// </summary>
        public InboundCrossClusterSearchConnectionStatus ConnectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionStatus property is set.
        /// </summary>
        internal bool IsSetConnectionStatus() => this.ConnectionStatus != null;

        /// <summary>
        /// Gets and sets the property CrossClusterSearchConnectionId. 
        /// <para>
        /// Specifies the connection id for the inbound cross-cluster search connection.
        /// </para>
        /// </summary>
        public string CrossClusterSearchConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the CrossClusterSearchConnectionId property is set.
        /// </summary>
        internal bool IsSetCrossClusterSearchConnectionId() => this.CrossClusterSearchConnectionId != null;

        /// <summary>
        /// Gets and sets the property DestinationDomainInfo. 
        /// <para>
        /// Specifies the <c><a>DomainInformation</a></c> for the destination Elasticsearch domain.
        /// </para>
        /// </summary>
        public DomainInformation DestinationDomainInfo { get; set; }

        /// <summary>
        /// Checks to see if the DestinationDomainInfo property is set.
        /// </summary>
        internal bool IsSetDestinationDomainInfo() => this.DestinationDomainInfo != null;

        /// <summary>
        /// Gets and sets the property SourceDomainInfo. 
        /// <para>
        /// Specifies the <c><a>DomainInformation</a></c> for the source Elasticsearch domain.
        /// </para>
        /// </summary>
        public DomainInformation SourceDomainInfo { get; set; }

        /// <summary>
        /// Checks to see if the SourceDomainInfo property is set.
        /// </summary>
        internal bool IsSetSourceDomainInfo() => this.SourceDomainInfo != null;
    }
}
