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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the ListConnectors operation. Returns a list of all
    /// the connectors in this account and Region. The list is limited to connectors whose
    /// name starts with the specified prefix. The response also includes a description of
    /// each of the listed connectors.
    /// </summary>
    public partial class ListConnectorsRequest : AmazonKafkaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectorNamePrefix. 
        /// <para>
        /// The name prefix that you want to use to search for and list connectors.
        /// </para>
        /// </summary>
        public string ConnectorNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorNamePrefix property is set.
        /// </summary>
        internal bool IsSetConnectorNamePrefix() => this.ConnectorNamePrefix != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of connectors to list in one response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response of a ListConnectors operation is truncated, it will include a NextToken.
        /// Send this NextToken in a subsequent request to continue listing from where the previous
        /// operation left off.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
