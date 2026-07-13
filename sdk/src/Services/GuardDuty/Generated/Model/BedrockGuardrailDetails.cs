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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the Bedrock guardrail that was involved in a finding.
    /// </summary>
    public partial class BedrockGuardrailDetails
    {
        private List<ContentPolicyFilter> _contentPolicyFilters = AWSConfigs.InitializeCollections ? new List<ContentPolicyFilter>() : null;
        private GuardrailAction _guardrailAction;
        private string _guardrailArn;
        private List<BedrockGuardrail> _guardrails = AWSConfigs.InitializeCollections ? new List<BedrockGuardrail>() : null;
        private GuardrailSource _guardrailSource;
        private string _guardrailVersion;

        /// <summary>
        /// Gets and sets the property ContentPolicyFilters. 
        /// <para>
        /// The list of content policy filters that matched during the guardrail evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ContentPolicyFilter> ContentPolicyFilters
        {
            get { return this._contentPolicyFilters; }
            set { this._contentPolicyFilters = value; }
        }

        // Check to see if ContentPolicyFilters property is set
        internal bool IsSetContentPolicyFilters()
        {
            return this._contentPolicyFilters != null && (this._contentPolicyFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GuardrailAction. 
        /// <para>
        /// Indicates whether the guardrail intervened or not.
        /// </para>
        /// </summary>
        public GuardrailAction GuardrailAction
        {
            get { return this._guardrailAction; }
            set { this._guardrailAction = value; }
        }

        // Check to see if GuardrailAction property is set
        internal bool IsSetGuardrailAction()
        {
            return this._guardrailAction != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailArn. 
        /// <para>
        /// The ARN of the Bedrock guardrail. This field is deprecated. Use the <c>guardrails</c>
        /// list instead.
        /// </para>
        /// </summary>
        [Obsolete("Use guardrails list instead")]
        [AWSProperty(Min=0, Max=2048)]
        public string GuardrailArn
        {
            get { return this._guardrailArn; }
            set { this._guardrailArn = value; }
        }

        // Check to see if GuardrailArn property is set
        internal bool IsSetGuardrailArn()
        {
            return this._guardrailArn != null;
        }

        /// <summary>
        /// Gets and sets the property Guardrails. 
        /// <para>
        /// The list of Bedrock guardrails associated with the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<BedrockGuardrail> Guardrails
        {
            get { return this._guardrails; }
            set { this._guardrails = value; }
        }

        // Check to see if Guardrails property is set
        internal bool IsSetGuardrails()
        {
            return this._guardrails != null && (this._guardrails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GuardrailSource. 
        /// <para>
        /// Indicates whether the guardrail was applied on the input or output of the model invocation.
        /// </para>
        /// </summary>
        public GuardrailSource GuardrailSource
        {
            get { return this._guardrailSource; }
            set { this._guardrailSource = value; }
        }

        // Check to see if GuardrailSource property is set
        internal bool IsSetGuardrailSource()
        {
            return this._guardrailSource != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// The version of the Bedrock guardrail. This field is deprecated. Use the <c>guardrails</c>
        /// list instead.
        /// </para>
        /// </summary>
        [Obsolete("Use guardrails list instead")]
        [AWSProperty(Min=1, Max=8)]
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

    }
}