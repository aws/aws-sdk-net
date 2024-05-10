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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateGuardrail.html#API_CreateGuardrail_RequestSyntax">CreateGuardrail
    /// request body</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_UpdateGuardrail.html#API_UpdateGuardrail_RequestSyntax">UpdateGuardrail
    /// request body</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GuardrailContentFilterConfig
    {
        private GuardrailFilterStrength _inputStrength;
        private GuardrailFilterStrength _outputStrength;
        private GuardrailContentFilterType _type;

        /// <summary>
        /// Gets and sets the property InputStrength. 
        /// <para>
        /// The strength of the content filter to apply to prompts. As you increase the filter
        /// strength, the likelihood of filtering harmful content increases and the probability
        /// of seeing harmful content in your application reduces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailFilterStrength InputStrength
        {
            get { return this._inputStrength; }
            set { this._inputStrength = value; }
        }

        // Check to see if InputStrength property is set
        internal bool IsSetInputStrength()
        {
            return this._inputStrength != null;
        }

        /// <summary>
        /// Gets and sets the property OutputStrength. 
        /// <para>
        /// The strength of the content filter to apply to model responses. As you increase the
        /// filter strength, the likelihood of filtering harmful content increases and the probability
        /// of seeing harmful content in your application reduces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailFilterStrength OutputStrength
        {
            get { return this._outputStrength; }
            set { this._outputStrength = value; }
        }

        // Check to see if OutputStrength property is set
        internal bool IsSetOutputStrength()
        {
            return this._outputStrength != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The harmful category that the content filter is applied to.
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