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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The content filter for a guardrail.
    /// </summary>
    public partial class GuardrailContentFilter
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The guardrail action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailContentPolicyAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The guardrail confidence.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailContentFilterConfidence Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence != null;

        /// <summary>
        /// Gets and sets the property Detected. 
        /// <para>
        /// Indicates whether content that breaches the guardrail configuration is detected.
        /// </para>
        /// </summary>
        public bool? Detected { get; set; }

        /// <summary>
        /// Checks to see if the Detected property is set.
        /// </summary>
        internal bool IsSetDetected() => this.Detected.HasValue;

        /// <summary>
        /// Gets and sets the property FilterStrength. 
        /// <para>
        /// The filter strength setting for the guardrail content filter.
        /// </para>
        /// </summary>
        public GuardrailContentFilterStrength FilterStrength { get; set; }

        /// <summary>
        /// Checks to see if the FilterStrength property is set.
        /// </summary>
        internal bool IsSetFilterStrength() => this.FilterStrength != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The guardrail type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailContentFilterType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
