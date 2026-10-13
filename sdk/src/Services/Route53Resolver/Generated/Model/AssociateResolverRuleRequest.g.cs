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
    /// Container for the parameters to the AssociateResolverRule operation. Associates a
    /// Resolver rule with a VPC. When you associate a rule with a VPC, Resolver forwards
    /// all DNS queries for the domain name that is specified in the rule and that originate
    /// in the VPC. The queries are forwarded to the IP addresses for the DNS resolvers that
    /// are specified in the rule. For more information about rules, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverRule.html">CreateResolverRule</a>.
    /// </summary>
    public partial class AssociateResolverRuleRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the association that you're creating between a Resolver rule and a VPC.
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
        /// Gets and sets the property ResolverRuleId. 
        /// <para>
        /// The ID of the Resolver rule that you want to associate with the VPC. To list the existing
        /// Resolver rules, use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRules.html">ListResolverRules</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ResolverRuleId { get; set; }

        /// <summary>
        /// Checks to see if the ResolverRuleId property is set.
        /// </summary>
        internal bool IsSetResolverRuleId() => this.ResolverRuleId != null;

        /// <summary>
        /// Gets and sets the property VPCId. 
        /// <para>
        /// The ID of the VPC that you want to associate the Resolver rule with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string VPCId { get; set; }

        /// <summary>
        /// Checks to see if the VPCId property is set.
        /// </summary>
        internal bool IsSetVPCId() => this.VPCId != null;
    }
}
