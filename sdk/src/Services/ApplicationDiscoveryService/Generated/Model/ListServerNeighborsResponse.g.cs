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
    /// This is the response object from the ListServerNeighbors operation.
    /// </summary>
    public partial class ListServerNeighborsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KnownDependencyCount. 
        /// <para>
        /// Count of distinct servers that are one hop away from the given server.
        /// </para>
        /// </summary>
        public long? KnownDependencyCount { get; set; }

        /// <summary>
        /// Checks to see if the KnownDependencyCount property is set.
        /// </summary>
        internal bool IsSetKnownDependencyCount() => this.KnownDependencyCount.HasValue;

        /// <summary>
        /// Gets and sets the property Neighbors. 
        /// <para>
        /// List of distinct servers that are one hop away from the given server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<NeighborConnectionDetail> Neighbors { get; set; } = AWSConfigs.InitializeCollections ? new List<NeighborConnectionDetail>() : null;

        /// <summary>
        /// Checks to see if the Neighbors property is set.
        /// </summary>
        internal bool IsSetNeighbors() => this.Neighbors != null && (this.Neighbors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token to retrieve the next set of results. For example, if you specified 100 IDs for
        /// <c>ListServerNeighborsRequest$neighborConfigurationIds</c> but set <c>ListServerNeighborsRequest$maxResults</c>
        /// to 10, you received a set of 10 results along with this token. Use this token in the
        /// next query to retrieve the next set of 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
