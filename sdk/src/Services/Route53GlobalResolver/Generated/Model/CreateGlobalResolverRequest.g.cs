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
    /// Container for the parameters to the CreateGlobalResolver operation. Creates a new
    /// Route 53 Global Resolver instance. A Route 53 Global Resolver is a global, internet-accessible
    /// DNS resolver that provides secure DNS resolution for both public and private domains
    /// through global anycast IP addresses. <important> <para> Route 53 Global Resolver is
    /// a global service that supports resolvers in multiple Amazon Web Services Regions but
    /// you must specify the US East (Ohio) Region to create, update, or otherwise work with
    /// Route 53 Global Resolver resources. That is, for example, specify <c>--region us-east-2</c>
    /// on Amazon Web Services CLI commands. </para> </important>
    /// </summary>
    public partial class CreateGlobalResolverRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique string that identifies the request and ensures idempotency. If you make multiple
        /// requests with the same client token, only one Route 53 Global Resolver is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the Route 53 Global Resolver instance. Maximum length
        /// of 1024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the Route 53 Global Resolver. Valid values are IPV4 (default)
        /// or DUAL_STACK for both IPv4 and IPv6 support.
        /// </para>
        /// </summary>
        public GlobalResolverIpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the Route 53 Global Resolver instance. Maximum length of 64
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ObservabilityRegion. 
        /// <para>
        /// The Amazon Web Services Region where query resolution logs and metrics will be aggregated
        /// and delivered. If not specified, logging is not enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string ObservabilityRegion { get; set; }

        /// <summary>
        /// Checks to see if the ObservabilityRegion property is set.
        /// </summary>
        internal bool IsSetObservabilityRegion() => this.ObservabilityRegion != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// List of Amazon Web Services Regions where the Route 53 Global Resolver will operate.
        /// The resolver will be distributed across these Regions to provide global availability
        /// and low-latency DNS resolution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the Route 53 Global Resolver. Tags are key-value pairs that
        /// help you organize and identify your resources.
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
