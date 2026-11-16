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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourcesInContextStore operation. Lists the
    /// resources that a context store records. The context store must be associated with
    /// a transit gateway that your firewall is attached to. You can filter the results by
    /// Region, resource type, or both. <para> When using a small page size, a single call
    /// might not return the full list. A response can contain fewer than <c>MaxResults</c>
    /// results, or none, and still include a <c>NextToken</c>. Keep making requests until
    /// the response does not include a <c>NextToken</c>. </para>
    /// </summary>
    public partial class ListResourcesInContextStoreRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property ContextStoreId. 
        /// <para>
        /// The unique identifier of the context store. To get the identifiers of the context
        /// stores that are associated with your firewalls, call <c>ListContextStores</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContextStoreId { get; set; }

        /// <summary>
        /// Checks to see if the ContextStoreId property is set.
        /// </summary>
        internal bool IsSetContextStoreId() => this.ContextStoreId != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Optional filters that limit the results to resources in a specific Region, of a specific
        /// resource type, or both. If you specify both filters, Network Firewall returns only
        /// the resources that match both.
        /// </para>
        /// </summary>
        public ContextFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you want Network Firewall to return for this request.
        /// If more objects are available, in the response, Network Firewall provides a <c>NextToken</c>
        /// value that you can use in a subsequent call to get the next batch of objects.
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
        /// When you request a list of objects with a <c>MaxResults</c> setting, if the number
        /// of objects that are still available for retrieval exceeds the maximum you requested,
        /// Network Firewall returns a <c>NextToken</c> value in the response. To retrieve the
        /// next batch of objects, use the token returned from the prior request in your next
        /// request.
        /// </para>
        ///  
        /// <para>
        /// A token is valid only for the same <c>ContextStoreId</c> and filters as the request
        /// that returned it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
