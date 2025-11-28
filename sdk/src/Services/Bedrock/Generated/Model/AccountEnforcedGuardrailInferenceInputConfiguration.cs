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
    /// Account-level enforced guardrail input configuration.
    /// </summary>
    public partial class AccountEnforcedGuardrailInferenceInputConfiguration
    {
        private string _guardrailIdentifier;
        private string _guardrailVersion;
        private InputTags _inputTags;

        /// <summary>
        /// Gets and sets the property GuardrailIdentifier. 
        /// <para>
        /// Identifier for the guardrail, could be the ID or the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string GuardrailIdentifier
        {
            get { return this._guardrailIdentifier; }
            set { this._guardrailIdentifier = value; }
        }

        // Check to see if GuardrailIdentifier property is set
        internal bool IsSetGuardrailIdentifier()
        {
            return this._guardrailIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// Numerical guardrail version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GuardrailVersion
        {
            get { return this._guardrailVersion; }
            set { this._guardrailVersion = value; }
        }

        // Check to see if GuardrailVersion property is set
        internal bool IsSetGuardrailVersion()
        {
            return this._guardrailVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InputTags. 
        /// <para>
        /// Whether to honor or ignore input tags at runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputTags InputTags
        {
            get { return this._inputTags; }
            set { this._inputTags = value; }
        }

        // Check to see if InputTags property is set
        internal bool IsSetInputTags()
        {
            return this._inputTags != null;
        }

    }
}