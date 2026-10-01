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
    /// The PII entity configured for the guardrail.
    /// </summary>
    public partial class GuardrailPiiEntity
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The configured guardrail action when PII entity is detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailSensitiveInformationAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property InputAction. 
        /// <para>
        /// The action to take when harmful content is detected in the input. Supported values
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BLOCK</c> – Block the content and replace it with blocked messaging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANONYMIZE</c> – Mask the content and replace it with identifier tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – Take no action but return detection information in the trace response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GuardrailSensitiveInformationAction InputAction { get; set; }

        /// <summary>
        /// Checks to see if the InputAction property is set.
        /// </summary>
        internal bool IsSetInputAction() => this.InputAction != null;

        /// <summary>
        /// Gets and sets the property InputEnabled. 
        /// <para>
        /// Indicates whether guardrail evaluation is enabled on the input. When disabled, you
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
        /// The action to take when harmful content is detected in the output. Supported values
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BLOCK</c> – Block the content and replace it with blocked messaging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANONYMIZE</c> – Mask the content and replace it with identifier tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – Take no action but return detection information in the trace response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GuardrailSensitiveInformationAction OutputAction { get; set; }

        /// <summary>
        /// Checks to see if the OutputAction property is set.
        /// </summary>
        internal bool IsSetOutputAction() => this.OutputAction != null;

        /// <summary>
        /// Gets and sets the property OutputEnabled. 
        /// <para>
        /// Indicates whether guardrail evaluation is enabled on the output. When disabled, you
        /// aren't charged for the evaluation. The evaluation doesn't appear in the response.
        /// </para>
        /// </summary>
        public bool? OutputEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OutputEnabled property is set.
        /// </summary>
        internal bool IsSetOutputEnabled() => this.OutputEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of PII entity. For example, Social Security Number.
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
