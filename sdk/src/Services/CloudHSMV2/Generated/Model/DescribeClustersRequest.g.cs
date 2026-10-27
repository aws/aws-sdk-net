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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusters operation. Gets information about
    /// CloudHSM clusters. <para> This is a paginated operation, which means that each response
    /// might contain only a subset of all the clusters. When the response contains only a
    /// subset of clusters, it includes a <c>NextToken</c> value. Use this value in a subsequent
    /// <c>DescribeClusters</c> request to get more clusters. When you receive a response
    /// with no <c>NextToken</c> (or an empty or null value), that means there are no more
    /// clusters to get. </para> <para> <b>Cross-account use:</b> No. You cannot perform this
    /// operation on CloudHSM clusters in a different Amazon Web Services account. </para>
    /// </summary>
    public partial class DescribeClustersRequest : AmazonCloudHSMV2Request
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters to limit the items returned in the response.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>clusterIds</c> filter to return only the specified clusters. Specify clusters
        /// by their cluster identifier (ID).
        /// </para>
        ///  
        /// <para>
        /// Use the <c>vpcIds</c> filter to return only the clusters in the specified virtual
        /// private clouds (VPCs). Specify VPCs by their VPC identifier (ID).
        /// </para>
        ///  
        /// <para>
        /// Use the <c>states</c> filter to return only clusters that match the specified state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public Dictionary<string, List<string>> Filters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of clusters to return in the response. When there are more clusters
        /// than the number you specify, the response contains a <c>NextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>NextToken</c> value that you received in the previous response. Use this value
        /// to get more clusters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
