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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
        private GuardrailAction _action;
        private List<GuardrailAssessment> _inputAssessments = AWSConfigs.InitializeCollections ? new List<GuardrailAssessment>() : null;
        private Metadata _metadata;
        private List<GuardrailAssessment> _outputAssessments = AWSConfigs.InitializeCollections ? new List<GuardrailAssessment>() : null;
        private string _traceId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The trace action details used with the Guardrail.
        /// </para>
        /// </summary>
        public GuardrailAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property InputAssessments. 
        /// <para>
        /// The details of the input assessments used in the Guardrail Trace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GuardrailAssessment> InputAssessments
        {
            get { return this._inputAssessments; }
            set { this._inputAssessments = value; }
        }

        // Check to see if InputAssessments property is set
        internal bool IsSetInputAssessments()
        {
            return this._inputAssessments != null && (this._inputAssessments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Contains information about the Guardrail output.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Metadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property OutputAssessments. 
        /// <para>
        /// The details of the output assessments used in the Guardrail Trace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GuardrailAssessment> OutputAssessments
        {
            get { return this._outputAssessments; }
            set { this._outputAssessments = value; }
        }

        // Check to see if OutputAssessments property is set
        internal bool IsSetOutputAssessments()
        {
            return this._outputAssessments != null && (this._outputAssessments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The details of the trace Id used in the Guardrail Trace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=16)]
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

    }
}