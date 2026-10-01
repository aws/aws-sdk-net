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
    /// Container for the parameters to the UpdateABTest operation. Updates an A/B test's
    /// configuration, including variants, traffic allocation, evaluation settings, or execution
    /// status.
    /// </summary>
    public partial class UpdateABTestRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property AbTestId. 
        /// <para>
        /// The unique identifier of the A/B test to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AbTestId { get; set; }

        /// <summary>
        /// Checks to see if the AbTestId property is set.
        /// </summary>
        internal bool IsSetAbTestId() => this.AbTestId != null;

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
        /// The updated description of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EvaluationConfig. 
        /// <para>
        /// The updated evaluation configuration.
        /// </para>
        /// </summary>
        public ABTestEvaluationConfig EvaluationConfig { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationConfig property is set.
        /// </summary>
        internal bool IsSetEvaluationConfig() => this.EvaluationConfig != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The updated execution status to enable or disable the A/B test.
        /// </para>
        /// </summary>
        public ABTestExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property GatewayFilter. 
        /// <para>
        /// The updated gateway filter.
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
        /// The updated name of the A/B test.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The updated IAM role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Variants. 
        /// <para>
        /// The updated list of variants.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public List<Variant> Variants { get; set; } = AWSConfigs.InitializeCollections ? new List<Variant>() : null;

        /// <summary>
        /// Checks to see if the Variants property is set.
        /// </summary>
        internal bool IsSetVariants() => this.Variants != null && (this.Variants.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
