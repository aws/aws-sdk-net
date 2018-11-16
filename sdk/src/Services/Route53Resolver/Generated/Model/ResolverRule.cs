/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// For queries that originate in your VPC, detailed information about a resolver rule,
    /// which specifies how to route DNS queries out of the VPC. The <code>ResolverRule</code>
    /// parameter appears in the response to a <a>CreateResolverRule</a>, <a>DeleteResolverRule</a>,
    /// <a>GetResolverRule</a>, <a>ListResolverRules</a>, or <a>UpdateResolverRule</a> request.
    /// </summary>
    public partial class ResolverRule
    {
        private string _arn;
        private string _creatorRequestId;
        private string _domainName;
        private string _id;
        private string _name;
        private string _ownerId;
        private string _resolverEndpointId;
        private RuleTypeOption _ruleType;
        private ShareStatus _shareStatus;
        private ResolverRuleStatus _status;
        private string _statusMessage;
        private List<TargetAddress> _targetIps = new List<TargetAddress>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the resolver rule specified by <code>Id</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that you specified when you created the resolver rule. <code>CreatorRequestId</code>identifies
        /// the request and allows failed requests to be retried without the risk of executing
        /// the operation twice. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// DNS queries for this domain name are forwarded to the IP addresses that are specified
        /// in <code>TargetIps</code>. If a query matches multiple resolver rules (example.com
        /// and www.example.com), the query is routed using the resolver rule that contains the
        /// most specific domain name (www.example.com).
        /// </para>
        /// </summary>
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
        /// The ID that Resolver assigned to the resolver rule when you created it.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the resolver rule, which you specified when you created the resolver
        /// rule.
        /// </para>
        /// </summary>
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
        /// When a rule is shared with another AWS account, the account ID of the account that
        /// the rule is shared with.
        /// </para>
        /// </summary>
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
        /// This value is always <code>FORWARD</code>. Other resolver rule types aren't supported.
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
        /// Whether the rules is shared and, if so, whether the current account is sharing the
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
        /// A code that specifies the current status of the resolver rule.
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
        /// A detailed description of the status of a resolver rule.
        /// </para>
        /// </summary>
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
        /// An array that contains the IP addresses and ports that you want to forward 
        /// </para>
        /// </summary>
        public List<TargetAddress> TargetIps
        {
            get { return this._targetIps; }
            set { this._targetIps = value; }
        }

        // Check to see if TargetIps property is set
        internal bool IsSetTargetIps()
        {
            return this._targetIps != null && this._targetIps.Count > 0; 
        }

    }
}