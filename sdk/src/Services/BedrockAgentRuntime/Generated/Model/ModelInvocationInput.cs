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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Trace Part which contains information used to call Invoke Model
    /// </summary>
    public partial class ModelInvocationInput
    {
        private InferenceConfiguration _inferenceConfiguration;
        private string _overrideLambda;
        private CreationMode _parserMode;
        private CreationMode _promptCreationMode;
        private string _text;
        private string _traceId;
        private PromptType _type;

        /// <summary>
        /// Gets and sets the property InferenceConfiguration.
        /// </summary>
        public InferenceConfiguration InferenceConfiguration
        {
            get { return this._inferenceConfiguration; }
            set { this._inferenceConfiguration = value; }
        }

        // Check to see if InferenceConfiguration property is set
        internal bool IsSetInferenceConfiguration()
        {
            return this._inferenceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideLambda.
        /// </summary>
        public string OverrideLambda
        {
            get { return this._overrideLambda; }
            set { this._overrideLambda = value; }
        }

        // Check to see if OverrideLambda property is set
        internal bool IsSetOverrideLambda()
        {
            return this._overrideLambda != null;
        }

        /// <summary>
        /// Gets and sets the property ParserMode.
        /// </summary>
        public CreationMode ParserMode
        {
            get { return this._parserMode; }
            set { this._parserMode = value; }
        }

        // Check to see if ParserMode property is set
        internal bool IsSetParserMode()
        {
            return this._parserMode != null;
        }

        /// <summary>
        /// Gets and sets the property PromptCreationMode.
        /// </summary>
        public CreationMode PromptCreationMode
        {
            get { return this._promptCreationMode; }
            set { this._promptCreationMode = value; }
        }

        // Check to see if PromptCreationMode property is set
        internal bool IsSetPromptCreationMode()
        {
            return this._promptCreationMode != null;
        }

        /// <summary>
        /// Gets and sets the property Text.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId.
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

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public PromptType Type
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