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
    /// In the response to an <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_AssociateResolverRule.html">AssociateResolverRule</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverRule.html">DisassociateResolverRule</a>,
    /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRuleAssociations.html">ListResolverRuleAssociations</a>
    /// request, provides information about an association between a Resolver rule and a VPC.
    /// The association determines which DNS queries that originate in the VPC are forwarded
    /// to your network.
    /// </summary>
    public partial class ResolverRuleAssociation
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the association between a Resolver rule and a VPC. Resolver assigns this
        /// value when you submit an <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_AssociateResolverRule.html">AssociateResolverRule</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of an association between a Resolver rule and a VPC.
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
        /// The ID of the Resolver rule that you associated with the VPC that is specified by
        /// <c>VPCId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ResolverRuleId { get; set; }

        /// <summary>
        /// Checks to see if the ResolverRuleId property is set.
        /// </summary>
        internal bool IsSetResolverRuleId() => this.ResolverRuleId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A code that specifies the current status of the association between a Resolver rule
        /// and a VPC.
        /// </para>
        /// </summary>
        public ResolverRuleAssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed description of the status of the association between a Resolver rule and
        /// a VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property VPCId. 
        /// <para>
        /// The ID of the VPC that you associated the Resolver rule with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string VPCId { get; set; }

        /// <summary>
        /// Checks to see if the VPCId property is set.
        /// </summary>
        internal bool IsSetVPCId() => this.VPCId != null;
    }
}
