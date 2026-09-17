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
    /// Contains details about an Amazon Bedrock guardrail evaluated during a model invocation.
    /// </summary>
    public partial class BedrockGuardrailResource
    {
        private GuardrailAction _guardrailAction;
        private GuardrailSource _guardrailSource;
        private string _version;

        /// <summary>
        /// Gets and sets the property GuardrailAction. 
        /// <para>
        /// Indicates whether the guardrail intervened during the model invocation.
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the Amazon Bedrock guardrail. Valid values are a numeric version, <c>DRAFT</c>,
        /// or <c>ENFORCED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}