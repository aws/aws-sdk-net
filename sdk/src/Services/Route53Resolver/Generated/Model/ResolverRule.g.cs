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
    /// For queries that originate in your VPC, detailed information about a Resolver rule,
    /// which specifies how to route DNS queries out of the VPC. The <c>ResolverRule</c> parameter
    /// appears in the response to a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverRule.html">CreateResolverRule</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverRule.html">DeleteResolverRule</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverRule.html">GetResolverRule</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRules.html">ListResolverRules</a>,
    /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverRule.html">UpdateResolverRule</a>
    /// request.
    /// </summary>
    public partial class ResolverRule
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Resolver rule specified by <c>Id</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the Resolver rule was created, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that you specified when you created the Resolver rule. <c>CreatorRequestId</c>
        /// identifies the request and allows failed requests to be retried without the risk of
        /// running the operation twice. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property DelegationRecord. 
        /// <para>
        ///  DNS queries with delegation records that point to this domain name are forwarded
        /// to resolvers on your network. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DelegationRecord { get; set; }

        /// <summary>
        /// Checks to see if the DelegationRecord property is set.
        /// </summary>
        internal bool IsSetDelegationRecord() => this.DelegationRecord != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// DNS queries for this domain name are forwarded to the IP addresses that are specified
        /// in <c>TargetIps</c>. If a query matches multiple Resolver rules (example.com and www.example.com),
        /// the query is routed using the Resolver rule that contains the most specific domain
        /// name (www.example.com).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID that Resolver assigned to the Resolver rule when you created it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the Resolver rule was last updated, in Unix time format and
        /// Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the ModificationTime property is set.
        /// </summary>
        internal bool IsSetModificationTime() => this.ModificationTime != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the Resolver rule, which you specified when you created the Resolver
        /// rule.
        /// </para>
        ///  
        /// <para>
        /// The name can be up to 64 characters long and can contain letters (a-z, A-Z), numbers
        /// (0-9), hyphens (-), underscores (_), and spaces. The name cannot consist of only numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// When a rule is shared with another Amazon Web Services account, the account ID of
        /// the account that the rule is shared with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 32)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the endpoint that the rule is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ResolverEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ResolverEndpointId property is set.
        /// </summary>
        internal bool IsSetResolverEndpointId() => this.ResolverEndpointId != null;

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// When you want to forward DNS queries for specified domain name to resolvers on your
        /// network, specify <c>FORWARD</c> or <c>DELEGATE</c>. If a query matches multiple Resolver
        /// rules (example.com and www.example.com), outbound DNS queries are routed using the
        /// Resolver rule that contains the most specific domain name (www.example.com).
        /// </para>
        ///  
        /// <para>
        /// When you have a forwarding rule to forward DNS queries for a domain to your network
        /// and you want Resolver to process queries for a subdomain of that domain, specify <c>SYSTEM</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, to forward DNS queries for example.com to resolvers on your network,
        /// you create a rule and specify <c>FORWARD</c> for <c>RuleType</c>. To then have Resolver
        /// process queries for apex.example.com, you create a rule and specify <c>SYSTEM</c>
        /// for <c>RuleType</c>.
        /// </para>
        ///  
        /// <para>
        /// Currently, only Resolver can create rules that have a value of <c>RECURSIVE</c> for
        /// <c>RuleType</c>.
        /// </para>
        /// </summary>
        public RuleTypeOption RuleType { get; set; }

        /// <summary>
        /// Checks to see if the RuleType property is set.
        /// </summary>
        internal bool IsSetRuleType() => this.RuleType != null;

        /// <summary>
        /// Gets and sets the property ShareStatus. 
        /// <para>
        /// Whether the rule is shared and, if so, whether the current account is sharing the
        /// rule with another account, or another account is sharing the rule with the current
        /// account.
        /// </para>
        /// </summary>
        public ShareStatus ShareStatus { get; set; }

        /// <summary>
        /// Checks to see if the ShareStatus property is set.
        /// </summary>
        internal bool IsSetShareStatus() => this.ShareStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A code that specifies the current status of the Resolver rule.
        /// </para>
        /// </summary>
        public ResolverRuleStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed description of the status of a Resolver rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TargetIps. 
        /// <para>
        /// An array that contains the IP addresses and ports that an outbound endpoint forwards
        /// DNS queries to. Typically, these are the IP addresses of DNS resolvers on your network.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<TargetAddress> TargetIps { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetAddress>() : null;

        /// <summary>
        /// Checks to see if the TargetIps property is set.
        /// </summary>
        internal bool IsSetTargetIps() => this.TargetIps != null && (this.TargetIps.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
