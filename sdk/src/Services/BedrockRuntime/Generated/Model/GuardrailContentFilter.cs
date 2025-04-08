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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The content filter for a guardrail.
    /// </summary>
    public partial class GuardrailContentFilter
    {
        private GuardrailContentPolicyAction _action;
        private GuardrailContentFilterConfidence _confidence;
        private bool? _detected;
        private GuardrailContentFilterStrength _filterStrength;
        private GuardrailContentFilterType _type;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The guardrail action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailContentPolicyAction Action
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
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The guardrail confidence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailContentFilterConfidence Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence != null;
        }

        /// <summary>
        /// Gets and sets the property Detected. 
        /// <para>
        /// Indicates whether content that breaches the guardrail configuration is detected.
        /// </para>
        /// </summary>
        public bool? Detected
        {
            get { return this._detected; }
            set { this._detected = value; }
        }

        // Check to see if Detected property is set
        internal bool IsSetDetected()
        {
            return this._detected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilterStrength. 
        /// <para>
        /// The filter strength setting for the guardrail content filter.
        /// </para>
        /// </summary>
        public GuardrailContentFilterStrength FilterStrength
        {
            get { return this._filterStrength; }
            set { this._filterStrength = value; }
        }

        // Check to see if FilterStrength property is set
        internal bool IsSetFilterStrength()
        {
            return this._filterStrength != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The guardrail type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailContentFilterType Type
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