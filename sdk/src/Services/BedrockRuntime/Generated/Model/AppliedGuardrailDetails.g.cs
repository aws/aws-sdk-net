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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Details about the specific guardrail that was applied during this assessment, including
    /// its identifier, version, ARN, origin, and ownership information.
    /// </summary>
    public partial class AppliedGuardrailDetails
    {
        /// <summary>
        /// Gets and sets the property GuardrailArn. 
        /// <para>
        /// The ARN of the guardrail that was applied.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string GuardrailArn { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailArn property is set.
        /// </summary>
        internal bool IsSetGuardrailArn() => this.GuardrailArn != null;

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// The unique ID of the guardrail that was applied.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string GuardrailId { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailId property is set.
        /// </summary>
        internal bool IsSetGuardrailId() => this.GuardrailId != null;

        /// <summary>
        /// Gets and sets the property GuardrailOrigin. 
        /// <para>
        /// The origin of how the guardrail was applied. This can be either requested at the API
        /// level or enforced at the account or organization level as a default guardrail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GuardrailOrigin { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GuardrailOrigin property is set.
        /// </summary>
        internal bool IsSetGuardrailOrigin() => this.GuardrailOrigin != null && (this.GuardrailOrigin.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GuardrailOwnership. 
        /// <para>
        /// The ownership type of the guardrail, indicating whether it is owned by the requesting
        /// account or is a cross-account guardrail shared from another AWS account.
        /// </para>
        /// </summary>
        public GuardrailOwnership GuardrailOwnership { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailOwnership property is set.
        /// </summary>
        internal bool IsSetGuardrailOwnership() => this.GuardrailOwnership != null;

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// The version of the guardrail that was applied.
        /// </para>
        /// </summary>
        public string GuardrailVersion { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailVersion property is set.
        /// </summary>
        internal bool IsSetGuardrailVersion() => this.GuardrailVersion != null;
    }
}
