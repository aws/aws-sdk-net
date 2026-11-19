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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourcesByConnector operation. Lists resources
    /// in your cloud provider that the connector can access, such as management groups, subscriptions,
    /// resource types, Regions, resources, and Event Hubs. Use the results to build a telemetry
    /// manifest. This operation returns results in pages. To get the next page, pass the
    /// returned <c>NextToken</c> in the next call. We recommend that you use pagination to
    /// ensure that the operation returns quickly and successfully.
    /// </summary>
    public partial class ListResourcesByConnectorRequest : AmazonObservabilityAdminRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectorIdentifier. 
        /// <para>
        /// The connector to use for the query. Specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ID of the connector
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ConnectorIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorIdentifier property is set.
        /// </summary>
        internal bool IsSetConnectorIdentifier() => this.ConnectorIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in one call. For an <c>EventHubs</c> query,
        /// a page can contain more results than this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results, returned by a previous call.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Selector. 
        /// <para>
        /// What to list: one cloud provider, and one type of resource in that provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectorQuery Selector { get; set; }

        /// <summary>
        /// Checks to see if the Selector property is set.
        /// </summary>
        internal bool IsSetSelector() => this.Selector != null;
    }
}
