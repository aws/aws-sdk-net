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

namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCoreNetworkEndpoint operation. Creates a
    /// core network endpoint, which enables DNS resolution for Amazon Web Services Cloud
    /// WAN core network segments. The endpoint connects a Route 53 Global Resolver to an
    /// Amazon Web Services Cloud WAN core network so that resources attached to the core
    /// network can send DNS queries to the resolver. <important> <para> Route 53 Global Resolver
    /// is a global service that supports resolvers in multiple Amazon Web Services Regions,
    /// but you must specify the US East (Ohio) Region to create, update, or otherwise work
    /// with Route 53 Global Resolver resources. That is, for example, specify <c>--region
    /// us-east-2</c> on Amazon Web Services CLI commands. </para> </important>
    /// </summary>
    public partial class CreateCoreNetworkEndpointRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that ensures the request is idempotent. Making
        /// the same request multiple times with the same <c>clientToken</c> produces the same
        /// result every time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Cloud WAN core network to
        /// connect to this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string CoreNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkArn property is set.
        /// </summary>
        internal bool IsSetCoreNetworkArn() => this.CoreNetworkArn != null;

        /// <summary>
        /// Gets and sets the property GlobalResolverId. 
        /// <para>
        /// The ID of the Route 53 Global Resolver to associate with this core network endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string GlobalResolverId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalResolverId property is set.
        /// </summary>
        internal bool IsSetGlobalResolverId() => this.GlobalResolverId != null;

        /// <summary>
        /// Gets and sets the property IpAddresses. 
        /// <para>
        /// The IP addresses that the core network endpoint uses to resolve DNS queries within
        /// the Amazon Web Services Cloud WAN core network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<CoreNetworkEndpointDnsIpInputItem> IpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<CoreNetworkEndpointDnsIpInputItem>() : null;

        /// <summary>
        /// Checks to see if the IpAddresses property is set.
        /// </summary>
        internal bool IsSetIpAddresses() => this.IpAddresses != null && (this.IpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the core network endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of user-defined keys and optional values that you can use to categorize and
        /// organize the core network endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
