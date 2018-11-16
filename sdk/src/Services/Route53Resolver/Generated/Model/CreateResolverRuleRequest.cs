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
    /// Container for the parameters to the CreateResolverRule operation.
    /// For DNS queries that originate in your VPCs, specifies which resolver endpoint the
    /// queries pass through, one domain name that you want to forward to your network, and
    /// the IP addresses of the DNS resolvers in your network.
    /// </summary>
    public partial class CreateResolverRuleRequest : AmazonRoute53ResolverRequest
    {
        private string _creatorRequestId;
        private string _domainName;
        private string _name;
        private string _resolverEndpointId;
        private RuleTypeOption _ruleType;
        private List<Tag> _tags = new List<Tag>();
        private List<TargetAddress> _targetIps = new List<TargetAddress>();

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed requests to be
        /// retried without the risk of executing the operation twice. <code>CreatorRequestId</code>
        /// can be any unique string, for example, a date/time stamp. 
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
        /// DNS queries for this domain name are forwarded to the IP addresses that you specify
        /// in <code>TargetIps</code>. If a query matches multiple resolver rules (example.com
        /// and www.example.com), outbound DNS queries are routed using the resolver rule that
        /// contains the most specific domain name (www.example.com).
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name that lets you easily find a rule in the Resolver dashboard in the
        /// Route 53 console.
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
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the outbound resolver endpoint that you want to use to route DNS queries
        /// to the IP addresses that you specify in <code>TargetIps</code>.
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
        /// Specify <code>FORWARD</code>. Other resolver rule types aren't supported.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tag keys and values that you want to associate with the endpoint.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetIps. 
        /// <para>
        /// The IPs that you want Resolver to forward DNS queries to. You can specify only IPv4
        /// addresses. Separate IP addresses with a comma.
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