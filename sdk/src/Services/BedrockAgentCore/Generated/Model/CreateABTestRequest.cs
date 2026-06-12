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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the CreateABTest operation.
    /// Creates an A/B test for comparing agent configurations. A/B tests split traffic between
    /// a control variant and a treatment variant through a gateway, then evaluate performance
    /// using online evaluation configurations to determine which variant performs better.
    /// </summary>
    public partial class CreateABTestRequest : AmazonBedrockAgentCoreRequest
    {
        private string _clientToken;
        private string _description;
        private bool? _enableOnCreate;
        private ABTestEvaluationConfig _evaluationConfig;
        private string _gatewayArn;
        private GatewayFilter _gatewayFilter;
        private string _name;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Variant> _variants = AWSConfigs.InitializeCollections ? new List<Variant>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, the service ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnableOnCreate. 
        /// <para>
        /// Whether to enable the A/B test immediately upon creation. If true, traffic splitting
        /// begins automatically.
        /// </para>
        /// </summary>
        public bool? EnableOnCreate
        {
            get { return this._enableOnCreate; }
            set { this._enableOnCreate = value; }
        }

        // Check to see if EnableOnCreate property is set
        internal bool IsSetEnableOnCreate()
        {
            return this._enableOnCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationConfig. 
        /// <para>
        /// The evaluation configuration specifying which online evaluation configurations to
        /// use for measuring variant performance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ABTestEvaluationConfig EvaluationConfig
        {
            get { return this._evaluationConfig; }
            set { this._evaluationConfig = value; }
        }

        // Check to see if EvaluationConfig property is set
        internal bool IsSetEvaluationConfig()
        {
            return this._evaluationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway to use for traffic splitting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayFilter. 
        /// <para>
        /// Optional filter to restrict which gateway target paths are included in the A/B test.
        /// </para>
        /// </summary>
        public GatewayFilter GatewayFilter
        {
            get { return this._gatewayFilter; }
            set { this._gatewayFilter = value; }
        }

        // Check to see if GatewayFilter property is set
        internal bool IsSetGatewayFilter()
        {
            return this._gatewayFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the A/B test. Must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN that grants permissions for the A/B test to access gateway and evaluation
        /// resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to associate with the A/B test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property Variants. 
        /// <para>
        /// The list of variants for the A/B test. Must contain exactly two variants: a control
        /// (C) and a treatment (T1), each with a configuration bundle or target reference and
        /// a traffic weight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<Variant> Variants
        {
            get { return this._variants; }
            set { this._variants = value; }
        }

        // Check to see if Variants property is set
        internal bool IsSetVariants()
        {
            return this._variants != null && (this._variants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}