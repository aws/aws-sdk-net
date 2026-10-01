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
    /// Account-level enforced guardrail input configuration.
    /// </summary>
    public partial class AccountEnforcedGuardrailInferenceInputConfiguration
    {
        /// <summary>
        /// Gets and sets the property GuardrailIdentifier. 
        /// <para>
        /// Identifier for the guardrail, could be the ID or the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string GuardrailIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailIdentifier property is set.
        /// </summary>
        internal bool IsSetGuardrailIdentifier() => this.GuardrailIdentifier != null;

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// Numerical guardrail version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GuardrailVersion { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailVersion property is set.
        /// </summary>
        internal bool IsSetGuardrailVersion() => this.GuardrailVersion != null;

        /// <summary>
        /// Gets and sets the property ModelEnforcement. 
        /// <para>
        /// Model-specific information for the enforced guardrail configuration. If not present,
        /// the configuration is enforced on all models
        /// </para>
        /// </summary>
        public ModelEnforcement ModelEnforcement { get; set; }

        /// <summary>
        /// Checks to see if the ModelEnforcement property is set.
        /// </summary>
        internal bool IsSetModelEnforcement() => this.ModelEnforcement != null;

        /// <summary>
        /// Gets and sets the property SelectiveContentGuarding. 
        /// <para>
        /// Selective content guarding controls for enforced guardrails.
        /// </para>
        /// </summary>
        public SelectiveContentGuarding SelectiveContentGuarding { get; set; }

        /// <summary>
        /// Checks to see if the SelectiveContentGuarding property is set.
        /// </summary>
        internal bool IsSetSelectiveContentGuarding() => this.SelectiveContentGuarding != null;
    }
}
