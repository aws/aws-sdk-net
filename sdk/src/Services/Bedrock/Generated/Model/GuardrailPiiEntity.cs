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
    /// The PII entity configured for the guardrail.
    /// </summary>
    public partial class GuardrailPiiEntity
    {
        private GuardrailSensitiveInformationAction _action;
        private GuardrailSensitiveInformationAction _inputAction;
        private bool? _inputEnabled;
        private GuardrailSensitiveInformationAction _outputAction;
        private bool? _outputEnabled;
        private GuardrailPiiEntityType _type;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The configured guardrail action when PII entity is detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailSensitiveInformationAction Action
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
        public GuardrailSensitiveInformationAction InputAction
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
        public GuardrailSensitiveInformationAction OutputAction
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
        /// The type of PII entity. For example, Social Security Number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailPiiEntityType Type
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