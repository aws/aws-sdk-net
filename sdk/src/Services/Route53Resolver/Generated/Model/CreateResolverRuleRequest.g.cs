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
    /// Container for the parameters to the CreateResolverRule operation. For DNS queries
    /// that originate in your VPCs, specifies which Resolver endpoint the queries pass through,
    /// one domain name that you want to forward to your network, and the IP addresses of
    /// the DNS resolvers in your network.
    /// </summary>
    public partial class CreateResolverRuleRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed requests to be
        /// retried without the risk of running the operation twice. <c>CreatorRequestId</c> can
        /// be any unique string, for example, a date/time stamp. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property DelegationRecord. 
        /// <para>
        ///  DNS queries with the delegation records that match this domain name are forwarded
        /// to the resolvers on your network. 
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
        /// DNS queries for this domain name are forwarded to the IP addresses that you specify
        /// in <c>TargetIps</c>. If a query matches multiple Resolver rules (example.com and www.example.com),
        /// outbound DNS queries are routed using the Resolver rule that contains the most specific
        /// domain name (www.example.com).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name that lets you easily find a rule in the Resolver dashboard in the
        /// Route 53 console.
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
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the outbound Resolver endpoint that you want to use to route DNS queries
        /// to the IP addresses that you specify in <c>TargetIps</c>.
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
        /// network, specify <c>FORWARD</c> or <c>DELEGATE</c>.
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
        [AWSProperty(Required = true)]
        public RuleTypeOption RuleType { get; set; }

        /// <summary>
        /// Checks to see if the RuleType property is set.
        /// </summary>
        internal bool IsSetRuleType() => this.RuleType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tag keys and values that you want to associate with the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetIps. 
        /// <para>
        /// The IPs that you want Resolver to forward DNS queries to. You can specify either Ipv4
        /// or Ipv6 addresses but not both in the same rule. Separate IP addresses with a space.
        /// </para>
        ///  
        /// <para>
        ///  <c>TargetIps</c> is available only when the value of <c>Rule type</c> is <c>FORWARD</c>.
        /// You should not provide TargetIps when the Rule type is <c>DELEGATE</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// when creating a DELEGATE rule, you must not provide the <c>TargetIps</c> parameter.
        /// If you provide the <c>TargetIps</c>, you may receive an ERROR message similar to "Delegate
        /// resolver rules need to specify a nameserver name". This error means you should not
        /// provide <c>TargetIps</c>.
        /// </para>
        ///  </note>
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
