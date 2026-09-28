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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Result of a single guardrail assessment, covering either the input (customer/user
    /// message) or the output (LLM response) of a Bedrock Converse call.
    /// </summary>
    public partial class SpanGuardrailAssessment
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Outcome of the guardrail assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// Unique AI Guardrail identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string GuardrailId { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailId property is set.
        /// </summary>
        internal bool IsSetGuardrailId() => this.GuardrailId != null;

        /// <summary>
        /// Gets and sets the property GuardrailName. 
        /// <para>
        /// Customer-defined display name of the AI Guardrail resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string GuardrailName { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailName property is set.
        /// </summary>
        internal bool IsSetGuardrailName() => this.GuardrailName != null;

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// Per-policy assessment results. Absent or empty when action is NONE.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<GuardrailPolicyResult> Policies { get; set; } = AWSConfigs.InitializeCollections ? new List<GuardrailPolicyResult>() : null;

        /// <summary>
        /// Checks to see if the Policies property is set.
        /// </summary>
        internal bool IsSetPolicies() => this.Policies != null && (this.Policies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Content source the guardrail was evaluated against.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
