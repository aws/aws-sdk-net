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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The Guardrail filter to identify and remove personally identifiable information (PII).
    /// </summary>
    public partial class GuardrailPiiEntityFilter
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action of the Guardrail filter to identify and remove PII.
        /// </para>
        /// </summary>
        public GuardrailSensitiveInformationPolicyAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// The match to settings in the Guardrail filter to identify and remove PII.
        /// </para>
        /// </summary>
        public string Match { get; set; }

        /// <summary>
        /// Checks to see if the Match property is set.
        /// </summary>
        internal bool IsSetMatch() => this.Match != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of PII the Guardrail filter has identified and removed.
        /// </para>
        /// </summary>
        public GuardrailPiiEntityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
