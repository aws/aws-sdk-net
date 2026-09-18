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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// A word to configure for the guardrail.
    /// </summary>
    public partial class GuardrailWordConfig
    {
        /// <summary>
        /// Gets and sets the property InputAction. 
        /// <para>
        /// Specifies the action to take when harmful content is detected in the input. Supported
        /// values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BLOCK</c> – Block the content and replace it with blocked messaging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – Take no action but return detection information in the trace response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public GuardrailWordAction InputAction { get; set; }

        /// <summary>
        /// Checks to see if the InputAction property is set.
        /// </summary>
        internal bool IsSetInputAction() => this.InputAction != null;

        /// <summary>
        /// Gets and sets the property InputEnabled. 
        /// <para>
        /// Specifies whether to enable guardrail evaluation on the intput. When disabled, you
        /// aren't charged for the evaluation. The evaluation doesn't appear in the response.
        /// </para>
        /// </summary>
        public bool? InputEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InputEnabled property is set.
        /// </summary>
        internal bool IsSetInputEnabled() => this.InputEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OutputAction. 
        /// <para>
        /// Specifies the action to take when harmful content is detected in the output. Supported
        /// values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BLOCK</c> – Block the content and replace it with blocked messaging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – Take no action but return detection information in the trace response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public GuardrailWordAction OutputAction { get; set; }

        /// <summary>
        /// Checks to see if the OutputAction property is set.
        /// </summary>
        internal bool IsSetOutputAction() => this.OutputAction != null;

        /// <summary>
        /// Gets and sets the property OutputEnabled. 
        /// <para>
        /// Specifies whether to enable guardrail evaluation on the output. When disabled, you
        /// aren't charged for the evaluation. The evaluation doesn't appear in the response.
        /// </para>
        /// </summary>
        public bool? OutputEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OutputEnabled property is set.
        /// </summary>
        internal bool IsSetOutputEnabled() => this.OutputEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Text of the word configured for the guardrail to block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
