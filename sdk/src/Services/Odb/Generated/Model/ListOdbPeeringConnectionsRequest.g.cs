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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the ListOdbPeeringConnections operation. Lists all
    /// ODB peering connections or those associated with a specific ODB network.
    /// </summary>
    public partial class ListOdbPeeringConnectionsRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of ODB peering connections to return in the response.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>20</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be between 1 and 100.
        /// </para>
        ///  </li> </ul>
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
        /// The pagination token for the next page of ODB peering connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The identifier of the ODB network to list peering connections for.
        /// </para>
        ///  
        /// <para>
        /// If not specified, lists all ODB peering connections in the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
        public string OdbNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkId property is set.
        /// </summary>
        internal bool IsSetOdbNetworkId() => this.OdbNetworkId != null;
    }
}
