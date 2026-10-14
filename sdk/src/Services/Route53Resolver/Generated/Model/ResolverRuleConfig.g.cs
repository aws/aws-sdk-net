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
    /// In an <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverRule.html">UpdateResolverRule</a>
    /// request, information about the changes that you want to make.
    /// </summary>
    public partial class ResolverRuleConfig
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the Resolver rule. The name that you specify appears in the Resolver
        /// dashboard in the Route 53 console. 
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
        /// The ID of the new outbound Resolver endpoint that you want to use to route DNS queries
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
        /// Gets and sets the property TargetIps. 
        /// <para>
        /// For DNS queries that originate in your VPC, the new IP addresses that you want to
        /// route outbound DNS queries to.
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
