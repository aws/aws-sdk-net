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
    /// A Personally Identifiable Information (PII) entity configured in a guardrail.
    /// </summary>
    public partial class GuardrailPiiEntityFilter
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The PII entity filter action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailSensitiveInformationPolicyAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Detected. 
        /// <para>
        /// Indicates whether personally identifiable information (PII) that breaches the guardrail
        /// configuration is detected.
        /// </para>
        /// </summary>
        public bool? Detected { get; set; }

        /// <summary>
        /// Checks to see if the Detected property is set.
        /// </summary>
        internal bool IsSetDetected() => this.Detected.HasValue;

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// The PII entity filter match.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Match { get; set; }

        /// <summary>
        /// Checks to see if the Match property is set.
        /// </summary>
        internal bool IsSetMatch() => this.Match != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The PII entity filter type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailPiiEntityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
