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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The trace details used in the Guardrail.
    /// </summary>
    public partial class GuardrailTrace
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The trace action details used with the Guardrail.
        /// </para>
        /// </summary>
        public GuardrailAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property InputAssessments. 
        /// <para>
        /// The details of the input assessments used in the Guardrail Trace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GuardrailAssessment> InputAssessments { get; set; } = AWSConfigs.InitializeCollections ? new List<GuardrailAssessment>() : null;

        /// <summary>
        /// Checks to see if the InputAssessments property is set.
        /// </summary>
        internal bool IsSetInputAssessments() => this.InputAssessments != null && (this.InputAssessments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Contains information about the Guardrail output.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property OutputAssessments. 
        /// <para>
        /// The details of the output assessments used in the Guardrail Trace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GuardrailAssessment> OutputAssessments { get; set; } = AWSConfigs.InitializeCollections ? new List<GuardrailAssessment>() : null;

        /// <summary>
        /// Checks to see if the OutputAssessments property is set.
        /// </summary>
        internal bool IsSetOutputAssessments() => this.OutputAssessments != null && (this.OutputAssessments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The details of the trace Id used in the Guardrail Trace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 16)]
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;
    }
}
