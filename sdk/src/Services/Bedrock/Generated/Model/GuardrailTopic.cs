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
    /// Details about topics for the guardrail to identify and deny.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetGuardrail.html#API_GetGuardrail_ResponseSyntax">GetGuardrail
    /// response body</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GuardrailTopic
    {
        private string _definition;
        private List<string> _examples = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GuardrailTopicAction _inputAction;
        private bool? _inputEnabled;
        private string _name;
        private GuardrailTopicAction _outputAction;
        private bool? _outputEnabled;
        private GuardrailTopicType _type;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// A definition of the topic to deny.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=200)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Examples. 
        /// <para>
        /// A list of prompts, each of which is an example of a prompt that can be categorized
        /// as belonging to the topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> Examples
        {
            get { return this._examples; }
            set { this._examples = value; }
        }

        // Check to see if Examples property is set
        internal bool IsSetExamples()
        {
            return this._examples != null && (this._examples.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        ///  <c>NONE</c> – Take no action but return detection information in the trace response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public GuardrailTopicAction InputAction
        {
            get { return this._inputAction; }
            set { this._inputAction = value; }
        }

        // Check to see if InputAction property is set
        internal bool IsSetInputAction()
        {
            return this._inputAction != null;
        }

        /// <summary>
        /// Gets and sets the property InputEnabled. 
        /// <para>
        /// Indicates whether guardrail evaluation is enabled on the input. When disabled, you
        /// aren't charged for the evaluation. The evaluation doesn't appear in the response.
        /// </para>
        /// </summary>
        public bool? InputEnabled
        {
            get { return this._inputEnabled; }
            set { this._inputEnabled = value; }
        }

        // Check to see if InputEnabled property is set
        internal bool IsSetInputEnabled()
        {
            return this._inputEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the topic to deny.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        ///  <c>NONE</c> – Take no action but return detection information in the trace response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public GuardrailTopicAction OutputAction
        {
            get { return this._outputAction; }
            set { this._outputAction = value; }
        }

        // Check to see if OutputAction property is set
        internal bool IsSetOutputAction()
        {
            return this._outputAction != null;
        }

        /// <summary>
        /// Gets and sets the property OutputEnabled. 
        /// <para>
        /// Indicates whether guardrail evaluation is enabled on the output. When disabled, you
        /// aren't charged for the evaluation. The evaluation doesn't appear in the response.
        /// </para>
        /// </summary>
        public bool? OutputEnabled
        {
            get { return this._outputEnabled; }
            set { this._outputEnabled = value; }
        }

        // Check to see if OutputEnabled property is set
        internal bool IsSetOutputEnabled()
        {
            return this._outputEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies to deny the topic.
        /// </para>
        /// </summary>
        public GuardrailTopicType Type
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