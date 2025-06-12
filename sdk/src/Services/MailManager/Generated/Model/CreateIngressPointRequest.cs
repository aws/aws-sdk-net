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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
    /// Container for the parameters to the CreateIngressPoint operation.
    /// Provision a new ingress endpoint resource.
    /// </summary>
    public partial class CreateIngressPointRequest : AmazonMailManagerRequest
    {
        private string _clientToken;
        private IngressPointConfiguration _ingressPointConfiguration;
        private string _ingressPointName;
        private NetworkConfiguration _networkConfiguration;
        private string _ruleSetId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trafficPolicyId;
        private IngressPointType _type;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that Amazon SES uses to recognize subsequent retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPointConfiguration. 
        /// <para>
        /// If you choose an Authenticated ingress endpoint, you must configure either an SMTP
        /// password or a secret ARN.
        /// </para>
        /// </summary>
        public IngressPointConfiguration IngressPointConfiguration
        {
            get { return this._ingressPointConfiguration; }
            set { this._ingressPointConfiguration = value; }
        }

        // Check to see if IngressPointConfiguration property is set
        internal bool IsSetIngressPointConfiguration()
        {
            return this._ingressPointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPointName. 
        /// <para>
        /// A user friendly name for an ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string IngressPointName
        {
            get { return this._ingressPointName; }
            set { this._ingressPointName = value; }
        }

        // Check to see if IngressPointName property is set
        internal bool IsSetIngressPointName()
        {
            return this._ingressPointName != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Specifies the network configuration for the ingress point. This allows you to create
        /// an IPv4-only, Dual-Stack, or PrivateLink type of ingress point. If not specified,
        /// the default network type is IPv4-only. 
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The identifier of an existing rule set that you attach to an ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RuleSetId
        {
            get { return this._ruleSetId; }
            set { this._ruleSetId = value; }
        }

        // Check to see if RuleSetId property is set
        internal bool IsSetRuleSetId()
        {
            return this._ruleSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for the resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The identifier of an existing traffic policy that you attach to an ingress endpoint
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TrafficPolicyId
        {
            get { return this._trafficPolicyId; }
            set { this._trafficPolicyId = value; }
        }

        // Check to see if TrafficPolicyId property is set
        internal bool IsSetTrafficPolicyId()
        {
            return this._trafficPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the ingress endpoint to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngressPointType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}