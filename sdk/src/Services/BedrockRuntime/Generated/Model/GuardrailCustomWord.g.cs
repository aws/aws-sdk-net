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
    /// A custom word configured in a guardrail.
    /// </summary>
    public partial class GuardrailCustomWord
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action for the custom word.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailWordPolicyAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Detected. 
        /// <para>
        /// Indicates whether custom word content that breaches the guardrail configuration is
        /// detected.
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
        /// The match for the custom word.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Match { get; set; }

        /// <summary>
        /// Checks to see if the Match property is set.
        /// </summary>
        internal bool IsSetMatch() => this.Match != null;
    }
}
