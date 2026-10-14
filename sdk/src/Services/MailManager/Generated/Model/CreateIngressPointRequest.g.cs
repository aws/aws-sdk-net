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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIngressPoint operation. Provision a new
    /// ingress endpoint resource.
    /// </summary>
    public partial class CreateIngressPointRequest : AmazonMailManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that Amazon SES uses to recognize subsequent retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property IngressPointConfiguration. 
        /// <para>
        /// If you choose an Authenticated ingress endpoint, you must configure either an SMTP
        /// password or a secret ARN.
        /// </para>
        /// </summary>
        public IngressPointConfiguration IngressPointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointConfiguration property is set.
        /// </summary>
        internal bool IsSetIngressPointConfiguration() => this.IngressPointConfiguration != null;

        /// <summary>
        /// Gets and sets the property IngressPointName. 
        /// <para>
        /// A user friendly name for an ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string IngressPointName { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointName property is set.
        /// </summary>
        internal bool IsSetIngressPointName() => this.IngressPointName != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Specifies the network configuration for the ingress point. This allows you to create
        /// an IPv4-only, Dual-Stack, or PrivateLink type of ingress point. If not specified,
        /// the default network type is IPv4-only. 
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The identifier of an existing rule set that you attach to an ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RuleSetId { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetId property is set.
        /// </summary>
        internal bool IsSetRuleSetId() => this.RuleSetId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for the resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
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
        /// Gets and sets the property TlsPolicy. 
        /// <para>
        /// The Transport Layer Security (TLS) policy for the ingress point. The FIPS value is
        /// only valid in US and Canada regions.
        /// </para>
        /// </summary>
        public TlsPolicy TlsPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TlsPolicy property is set.
        /// </summary>
        internal bool IsSetTlsPolicy() => this.TlsPolicy != null;

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The identifier of an existing traffic policy that you attach to an ingress endpoint
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TrafficPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyId property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyId() => this.TrafficPolicyId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the ingress endpoint to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngressPointType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
