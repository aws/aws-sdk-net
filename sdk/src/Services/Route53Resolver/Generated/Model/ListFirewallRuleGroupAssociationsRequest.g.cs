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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the ListFirewallRuleGroupAssociations operation. Retrieves
    /// the firewall rule group associations that you have defined. Each association enables
    /// DNS filtering for a VPC with one rule group. <para> A single call might return only
    /// a partial list of the associations. For information, see <c>MaxResults</c>. </para>
    /// </summary>
    public partial class ListFirewallRuleGroupAssociationsRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group that you want to retrieve the associations
        /// for. Leave this blank to retrieve associations for any rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirewallRuleGroupId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRuleGroupId property is set.
        /// </summary>
        internal bool IsSetFirewallRuleGroupId() => this.FirewallRuleGroupId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you want Resolver to return for this request. If
        /// more objects are available, in the response, Resolver provides a <c>NextToken</c>
        /// value that you can use in a subsequent call to get the next batch of objects.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <c>MaxResults</c>, Resolver returns up to 100 objects.
        /// 
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
        /// For the first call to this list request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// When you request a list of objects, Resolver returns at most the number of objects
        /// specified in <c>MaxResults</c>. If more objects are available for retrieval, Resolver
        /// returns a <c>NextToken</c> value in the response. To retrieve the next batch of objects,
        /// use the token that was returned for the prior request in your next request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The setting that determines the processing order of the rule group among the rule
        /// groups that are associated with a single VPC. DNS Firewall filters VPC traffic starting
        /// from the rule group with the lowest numeric priority setting. 
        /// </para>
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The association <c>Status</c> setting that you want DNS Firewall to filter on for
        /// the list. If you don't specify this, then DNS Firewall returns all associations, regardless
        /// of status.
        /// </para>
        /// </summary>
        public FirewallRuleGroupAssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the VPC that you want to retrieve the associations for. Leave
        /// this blank to retrieve associations for any VPC. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
