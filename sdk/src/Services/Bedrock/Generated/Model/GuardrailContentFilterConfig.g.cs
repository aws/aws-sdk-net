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
    /// Contains filter strengths for harmful content. Guardrails support the following content
    /// filters to detect and filter harmful user inputs and FM-generated outputs.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Hate</b> – Describes language or a statement that discriminates, criticizes, insults,
    /// denounces, or dehumanizes a person or group on the basis of an identity (such as race,
    /// ethnicity, gender, religion, sexual orientation, ability, and national origin).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Insults</b> – Describes language or a statement that includes demeaning, humiliating,
    /// mocking, insulting, or belittling language. This type of language is also labeled
    /// as bullying.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Sexual</b> – Describes language or a statement that indicates sexual interest,
    /// activity, or arousal using direct or indirect references to body parts, physical traits,
    /// or sex.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Violence</b> – Describes language or a statement that includes glorification of
    /// or threats to inflict physical pain, hurt, or injury toward a person, group or thing.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Content filtering depends on the confidence classification of user inputs and FM responses
    /// across each of the four harmful categories. All input and output statements are classified
    /// into one of four confidence levels (NONE, LOW, MEDIUM, HIGH) for each harmful category.
    /// For example, if a statement is classified as <i>Hate</i> with HIGH confidence, the
    /// likelihood of the statement representing hateful content is high. A single statement
    /// can be classified across multiple categories with varying confidence levels. For example,
    /// a single statement can be classified as <i>Hate</i> with HIGH confidence, <i>Insults</i>
    /// with LOW confidence, <i>Sexual</i> with NONE confidence, and <i>Violence</i> with
    /// MEDIUM confidence.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-filters.html">Guardrails
    /// content filters</a>.
    /// </para>
    /// </summary>
    public partial class GuardrailContentFilterConfig
    {
        /// <summary>
        /// Gets and sets the property InputAction. 
        /// <para>
        /// Specifies the action to take when harmful content is detected. Supported values include:
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
        public GuardrailContentFilterAction InputAction { get; set; }

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
        /// Gets and sets the property InputModalities. 
        /// <para>
        /// The input modalities selected for the guardrail content filter configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> InputModalities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InputModalities property is set.
        /// </summary>
        internal bool IsSetInputModalities() => this.InputModalities != null && (this.InputModalities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputStrength. 
        /// <para>
        /// The strength of the content filter to apply to prompts. As you increase the filter
        /// strength, the likelihood of filtering harmful content increases and the probability
        /// of seeing harmful content in your application reduces.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailFilterStrength InputStrength { get; set; }

        /// <summary>
        /// Checks to see if the InputStrength property is set.
        /// </summary>
        internal bool IsSetInputStrength() => this.InputStrength != null;

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
        public GuardrailContentFilterAction OutputAction { get; set; }

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
        /// Gets and sets the property OutputModalities. 
        /// <para>
        /// The output modalities selected for the guardrail content filter configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> OutputModalities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OutputModalities property is set.
        /// </summary>
        internal bool IsSetOutputModalities() => this.OutputModalities != null && (this.OutputModalities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputStrength. 
        /// <para>
        /// The strength of the content filter to apply to model responses. As you increase the
        /// filter strength, the likelihood of filtering harmful content increases and the probability
        /// of seeing harmful content in your application reduces.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailFilterStrength OutputStrength { get; set; }

        /// <summary>
        /// Checks to see if the OutputStrength property is set.
        /// </summary>
        internal bool IsSetOutputStrength() => this.OutputStrength != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The harmful category that the content filter is applied to.
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
