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
    /// A reference input containing ground truth data for evaluation, scoped to a specific
    /// context level (session or trace) through its span context.
    /// </summary>
    public partial class EvaluationReferenceInput
    {
        /// <summary>
        /// Gets and sets the property Assertions. 
        /// <para>
        ///  A list of assertion statements for session-level evaluation. Each assertion describes
        /// an expected behavior or outcome the agent should demonstrate during the session. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<EvaluationContent> Assertions { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationContent>() : null;

        /// <summary>
        /// Checks to see if the Assertions property is set.
        /// </summary>
        internal bool IsSetAssertions() => this.Assertions != null && (this.Assertions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        ///  The span context that identifies which session or trace this reference input applies
        /// to, used for correlating ground truth with agent output. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Context Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property ExpectedResponse. 
        /// <para>
        ///  The expected response for trace-level evaluation. Built-in evaluators that support
        /// this field compare the agent's actual response against this value for assessment.
        /// Custom evaluators can access it through the <c>{expected_response}</c> placeholder
        /// in their instructions. 
        /// </para>
        /// </summary>
        public EvaluationContent ExpectedResponse { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedResponse property is set.
        /// </summary>
        internal bool IsSetExpectedResponse() => this.ExpectedResponse != null;

        /// <summary>
        /// Gets and sets the property ExpectedTrajectory. 
        /// <para>
        ///  The expected tool call sequence for session-level trajectory evaluation. Contains
        /// a list of tool names representing the tools the agent is expected to invoke. 
        /// </para>
        /// </summary>
        public EvaluationExpectedTrajectory ExpectedTrajectory { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedTrajectory property is set.
        /// </summary>
        internal bool IsSetExpectedTrajectory() => this.ExpectedTrajectory != null;
    }
}
