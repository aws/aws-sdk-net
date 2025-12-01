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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The message data in text type.
    /// </summary>
    public partial class TextMessage
    {
        private AIGuardrailAssessment _aiGuardrailAssessment;
        private List<Citation> _citations = AWSConfigs.InitializeCollections ? new List<Citation>() : null;
        private string _value;

        /// <summary>
        /// Gets and sets the property AiGuardrailAssessment. 
        /// <para>
        /// The AI Guardrail assessment for the text message.
        /// </para>
        /// </summary>
        public AIGuardrailAssessment AiGuardrailAssessment
        {
            get { return this._aiGuardrailAssessment; }
            set { this._aiGuardrailAssessment = value; }
        }

        // Check to see if AiGuardrailAssessment property is set
        internal bool IsSetAiGuardrailAssessment()
        {
            return this._aiGuardrailAssessment != null;
        }

        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// The citations associated with the text message.
        /// </para>
        /// </summary>
        public List<Citation> Citations
        {
            get { return this._citations; }
            set { this._citations = value; }
        }

        // Check to see if Citations property is set
        internal bool IsSetCitations()
        {
            return this._citations != null && (this._citations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the message data in text type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}