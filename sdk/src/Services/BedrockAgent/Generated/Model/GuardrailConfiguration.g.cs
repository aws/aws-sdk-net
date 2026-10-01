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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Details about a guardrail associated with a resource.
    /// </summary>
    public partial class GuardrailConfiguration
    {
        /// <summary>
        /// Gets and sets the property GuardrailIdentifier. 
        /// <para>
        /// The unique identifier of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string GuardrailIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailIdentifier property is set.
        /// </summary>
        internal bool IsSetGuardrailIdentifier() => this.GuardrailIdentifier != null;

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// The version of the guardrail.
        /// </para>
        /// </summary>
        public string GuardrailVersion { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailVersion property is set.
        /// </summary>
        internal bool IsSetGuardrailVersion() => this.GuardrailVersion != null;
    }
}
