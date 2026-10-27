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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListDaemons operation. Returns a list of daemons.
    /// You can filter the results by cluster or capacity provider.
    /// </summary>
    public partial class ListDaemonsRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the capacity providers to filter daemons by. Only
        /// daemons associated with the specified capacity providers are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CapacityProviderArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CapacityProviderArns property is set.
        /// </summary>
        internal bool IsSetCapacityProviderArns() => this.CapacityProviderArns != null && (this.CapacityProviderArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster to filter daemons by. If you do not
        /// specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of daemon results that <c>ListDaemons</c> returned in paginated
        /// output. When this parameter is used, <c>ListDaemons</c> only returns <c>maxResults</c>
        /// results in a single page along with a <c>nextToken</c> response element. The remaining
        /// results of the initial request can be seen by sending another <c>ListDaemons</c> request
        /// with the returned <c>nextToken</c> value. This value can be between 1 and 100. If
        /// this parameter isn't used, then <c>ListDaemons</c> returns up to 100 results and a
        /// <c>nextToken</c> value if applicable.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a <c>ListDaemons</c> request indicating that
        /// more results are available to fulfill the request and further calls will be needed.
        /// If <c>maxResults</c> was provided, it's possible for the number of results to be fewer
        /// than <c>maxResults</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
