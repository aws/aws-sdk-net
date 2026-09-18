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
    /// Details about topics for the guardrail to identify and deny.
    /// </summary>
    public partial class GuardrailTopicConfig
    {
        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// A definition of the topic to deny.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 200)]
        public string Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Examples. 
        /// <para>
        /// A list of prompts, each of which is an example of a prompt that can be categorized
        /// as belonging to the topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> Examples { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Examples property is set.
        /// </summary>
        internal bool IsSetExamples() => this.Examples != null && (this.Examples.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public GuardrailTopicAction InputAction { get; set; }

        /// <summary>
        /// Checks to see if the InputAction property is set.
        /// </summary>
        internal bool IsSetInputAction() => this.InputAction != null;

        /// <summary>
        /// Gets and sets the property InputEnabled. 
        /// <para>
        /// Specifies whether to enable guardrail evaluation on the input. When disabled, you
        /// aren't charged for the evaluation. The evaluation doesn't appear in the response.
        /// </para>
        /// </summary>
        public bool? InputEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InputEnabled property is set.
        /// </summary>
        internal bool IsSetInputEnabled() => this.InputEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the topic to deny.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public GuardrailTopicAction OutputAction { get; set; }

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
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies to deny the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailTopicType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
