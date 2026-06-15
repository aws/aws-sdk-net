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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
    /// The configuration for inline guardrail checks. Specify one or more check types to
    /// run against the messages.
    /// </summary>
    public partial class GuardrailChecksConfig
    {
        private GuardrailChecksContentFilterConfig _contentFilter;
        private GuardrailChecksPromptAttackConfig _promptAttack;
        private GuardrailChecksSensitiveInformationConfig _sensitiveInformation;

        /// <summary>
        /// Gets and sets the property ContentFilter. 
        /// <para>
        /// The content filter check configuration.
        /// </para>
        /// </summary>
        public GuardrailChecksContentFilterConfig ContentFilter
        {
            get { return this._contentFilter; }
            set { this._contentFilter = value; }
        }

        // Check to see if ContentFilter property is set
        internal bool IsSetContentFilter()
        {
            return this._contentFilter != null;
        }

        /// <summary>
        /// Gets and sets the property PromptAttack. 
        /// <para>
        /// The prompt attack check configuration.
        /// </para>
        /// </summary>
        public GuardrailChecksPromptAttackConfig PromptAttack
        {
            get { return this._promptAttack; }
            set { this._promptAttack = value; }
        }

        // Check to see if PromptAttack property is set
        internal bool IsSetPromptAttack()
        {
            return this._promptAttack != null;
        }

        /// <summary>
        /// Gets and sets the property SensitiveInformation. 
        /// <para>
        /// The sensitive information check configuration.
        /// </para>
        /// </summary>
        public GuardrailChecksSensitiveInformationConfig SensitiveInformation
        {
            get { return this._sensitiveInformation; }
            set { this._sensitiveInformation = value; }
        }

        // Check to see if SensitiveInformation property is set
        internal bool IsSetSensitiveInformation()
        {
            return this._sensitiveInformation != null;
        }

    }
}