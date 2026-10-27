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
    /// Container for the parameters to the ListRuleGroups operation. Retrieves the metadata
    /// for the rule groups that you have defined. Depending on your setting for max results
    /// and the number of rule groups, a single call might not return the full list.
    /// </summary>
    public partial class ListRuleGroupsRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property ManagedType. 
        /// <para>
        /// Indicates the general category of the Amazon Web Services managed rule group.
        /// </para>
        /// </summary>
        public ResourceManagedType ManagedType { get; set; }

        /// <summary>
        /// Checks to see if the ManagedType property is set.
        /// </summary>
        internal bool IsSetManagedType() => this.ManagedType != null;

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
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the request. The default setting of <c>ACCOUNT</c> or a setting of <c>NULL</c>
        /// returns all of the rule groups in your account. A setting of <c>MANAGED</c> returns
        /// all available managed rule groups.
        /// </para>
        /// </summary>
        public ResourceManagedStatus Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property SubscriptionStatus. 
        /// <para>
        /// Filters the results to show only rule groups with the specified subscription status.
        /// Use this to find subscribed or unsubscribed rule groups.
        /// </para>
        /// </summary>
        public SubscriptionStatus SubscriptionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionStatus property is set.
        /// </summary>
        internal bool IsSetSubscriptionStatus() => this.SubscriptionStatus != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the rule group is stateless or stateful. If the rule group is stateless,
        /// it contains stateless rules. If it is stateful, it contains stateful rules.
        /// </para>
        /// </summary>
        public RuleGroupType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
