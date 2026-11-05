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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the ListServerNeighbors operation. Retrieves a list
    /// of servers that are one network hop away from a specified server.
    /// </summary>
    public partial class ListServerNeighborsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationId. 
        /// <para>
        /// Configuration ID of the server for which neighbors are being listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationId property is set.
        /// </summary>
        internal bool IsSetConfigurationId() => this.ConfigurationId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in a single page of output.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NeighborConfigurationIds. 
        /// <para>
        /// List of configuration IDs to test for one-hop-away.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NeighborConfigurationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NeighborConfigurationIds property is set.
        /// </summary>
        internal bool IsSetNeighborConfigurationIds() => this.NeighborConfigurationIds != null && (this.NeighborConfigurationIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token to retrieve the next set of results. For example, if you previously specified
        /// 100 IDs for <c>ListServerNeighborsRequest$neighborConfigurationIds</c> but set <c>ListServerNeighborsRequest$maxResults</c>
        /// to 10, you received a set of 10 results along with a token. Use that token in this
        /// query to get the next set of 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PortInformationNeeded. 
        /// <para>
        /// Flag to indicate if port and protocol information is needed as part of the response.
        /// </para>
        /// </summary>
        public bool? PortInformationNeeded { get; set; }

        /// <summary>
        /// Checks to see if the PortInformationNeeded property is set.
        /// </summary>
        internal bool IsSetPortInformationNeeded() => this.PortInformationNeeded.HasValue;
    }
}
