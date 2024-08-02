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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains information about the Amazon Bedrock model used to interpret the prompt used
    /// in descriptive bot building.
    /// </summary>
    public partial class BedrockModelSpecification
    {
        private string _customPrompt;
        private BedrockGuardrailConfiguration _guardrail;
        private string _modelArn;
        private BedrockTraceStatus _traceStatus;

        /// <summary>
        /// Gets and sets the property CustomPrompt. 
        /// <para>
        /// The custom prompt used in the Bedrock model specification details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4000)]
        public string CustomPrompt
        {
            get { return this._customPrompt; }
            set { this._customPrompt = value; }
        }

        // Check to see if CustomPrompt property is set
        internal bool IsSetCustomPrompt()
        {
            return this._customPrompt != null;
        }

        /// <summary>
        /// Gets and sets the property Guardrail. 
        /// <para>
        /// The guardrail configuration in the Bedrock model specification details.
        /// </para>
        /// </summary>
        public BedrockGuardrailConfiguration Guardrail
        {
            get { return this._guardrail; }
            set { this._guardrail = value; }
        }

        // Check to see if Guardrail property is set
        internal bool IsSetGuardrail()
        {
            return this._guardrail != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The ARN of the foundation model used in descriptive bot building.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TraceStatus. 
        /// <para>
        /// The Bedrock trace status in the Bedrock model specification details.
        /// </para>
        /// </summary>
        public BedrockTraceStatus TraceStatus
        {
            get { return this._traceStatus; }
            set { this._traceStatus = value; }
        }

        // Check to see if TraceStatus property is set
        internal bool IsSetTraceStatus()
        {
            return this._traceStatus != null;
        }

    }
}