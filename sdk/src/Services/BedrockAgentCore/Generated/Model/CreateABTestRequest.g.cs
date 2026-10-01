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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the CreateABTest operation. Creates an A/B test for
    /// comparing agent configurations. A/B tests split traffic between a control variant
    /// and a treatment variant through a gateway, then evaluate performance using online
    /// evaluation configurations to determine which variant performs better.
    /// </summary>
    public partial class CreateABTestRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, the service ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnableOnCreate. 
        /// <para>
        /// Whether to enable the A/B test immediately upon creation. If true, traffic splitting
        /// begins automatically.
        /// </para>
        /// </summary>
        public bool? EnableOnCreate { get; set; }

        /// <summary>
        /// Checks to see if the EnableOnCreate property is set.
        /// </summary>
        internal bool IsSetEnableOnCreate() => this.EnableOnCreate.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationConfig. 
        /// <para>
        /// The evaluation configuration specifying which online evaluation configurations to
        /// use for measuring variant performance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ABTestEvaluationConfig EvaluationConfig { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationConfig property is set.
        /// </summary>
        internal bool IsSetEvaluationConfig() => this.EvaluationConfig != null;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway to use for traffic splitting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property GatewayFilter. 
        /// <para>
        /// Optional filter to restrict which gateway target paths are included in the A/B test.
        /// </para>
        /// </summary>
        public GatewayFilter GatewayFilter { get; set; }

        /// <summary>
        /// Checks to see if the GatewayFilter property is set.
        /// </summary>
        internal bool IsSetGatewayFilter() => this.GatewayFilter != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the A/B test. Must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN that grants permissions for the A/B test to access gateway and evaluation
        /// resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to associate with the A/B test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Variants. 
        /// <para>
        /// The list of variants for the A/B test. Must contain exactly two variants: a control
        /// (C) and a treatment (T1), each with a configuration bundle or target reference and
        /// a traffic weight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public List<Variant> Variants { get; set; } = AWSConfigs.InitializeCollections ? new List<Variant>() : null;

        /// <summary>
        /// Checks to see if the Variants property is set.
        /// </summary>
        internal bool IsSetVariants() => this.Variants != null && (this.Variants.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
