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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
        private string _arn;
        private string _creationTime;
        private string _creatorRequestId;
        private string _delegationRecord;
        private string _domainName;
        private string _id;
        private string _modificationTime;
        private string _name;
        private string _ownerId;
        private string _resolverEndpointId;
        private RuleTypeOption _ruleType;
        private ShareStatus _shareStatus;
        private ResolverRuleStatus _status;
        private string _statusMessage;
        private List<TargetAddress> _targetIps = AWSConfigs.InitializeCollections ? new List<TargetAddress>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Resolver rule specified by <c>Id</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the Resolver rule was created, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that you specified when you created the Resolver rule. <c>CreatorRequestId</c>
        /// identifies the request and allows failed requests to be retried without the risk of
        /// running the operation twice. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property DelegationRecord. 
        /// <para>
        ///  DNS queries with delegation records that point to this domain name are forwarded
        /// to resolvers on your network. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DelegationRecord
        {
            get { return this._delegationRecord; }
            set { this._delegationRecord = value; }
        }

        // Check to see if DelegationRecord property is set
        internal bool IsSetDelegationRecord()
        {
            return this._delegationRecord != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// DNS queries for this domain name are forwarded to the IP addresses that are specified
        /// in <c>TargetIps</c>. If a query matches multiple Resolver rules (example.com and www.example.com),
        /// the query is routed using the Resolver rule that contains the most specific domain
        /// name (www.example.com).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID that Resolver assigned to the Resolver rule when you created it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the Resolver rule was last updated, in Unix time format and
        /// Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string ModificationTime
        {
            get { return this._modificationTime; }
            set { this._modificationTime = value; }
        }

        // Check to see if ModificationTime property is set
        internal bool IsSetModificationTime()
        {
            return this._modificationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the Resolver rule, which you specified when you created the Resolver
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// When a rule is shared with another Amazon Web Services account, the account ID of
        /// the account that the rule is shared with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=32)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the endpoint that the rule is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ResolverEndpointId
        {
            get { return this._resolverEndpointId; }
            set { this._resolverEndpointId = value; }
        }

        // Check to see if ResolverEndpointId property is set
        internal bool IsSetResolverEndpointId()
        {
            return this._resolverEndpointId != null;
        }

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
        public RuleTypeOption RuleType
        {
            get { return this._ruleType; }
            set { this._ruleType = value; }
        }

        // Check to see if RuleType property is set
        internal bool IsSetRuleType()
        {
            return this._ruleType != null;
        }

        /// <summary>
        /// Gets and sets the property ShareStatus. 
        /// <para>
        /// Whether the rule is shared and, if so, whether the current account is sharing the
        /// rule with another account, or another account is sharing the rule with the current
        /// account.
        /// </para>
        /// </summary>
        public ShareStatus ShareStatus
        {
            get { return this._shareStatus; }
            set { this._shareStatus = value; }
        }

        // Check to see if ShareStatus property is set
        internal bool IsSetShareStatus()
        {
            return this._shareStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A code that specifies the current status of the Resolver rule.
        /// </para>
        /// </summary>
        public ResolverRuleStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed description of the status of a Resolver rule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetIps. 
        /// <para>
        /// An array that contains the IP addresses and ports that an outbound endpoint forwards
        /// DNS queries to. Typically, these are the IP addresses of DNS resolvers on your network.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<TargetAddress> TargetIps
        {
            get { return this._targetIps; }
            set { this._targetIps = value; }
        }

        // Check to see if TargetIps property is set
        internal bool IsSetTargetIps()
        {
            return this._targetIps != null && (this._targetIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}