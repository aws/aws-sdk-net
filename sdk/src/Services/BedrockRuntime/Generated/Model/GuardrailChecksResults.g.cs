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
    /// The results from the guardrail checks evaluation, organized by check type.
    /// </summary>
    public partial class GuardrailChecksResults
    {
        /// <summary>
        /// Gets and sets the property ContentFilter. 
        /// <para>
        /// The content filter check results.
        /// </para>
        /// </summary>
        public GuardrailChecksContentFilterResult ContentFilter { get; set; }

        /// <summary>
        /// Checks to see if the ContentFilter property is set.
        /// </summary>
        internal bool IsSetContentFilter() => this.ContentFilter != null;

        /// <summary>
        /// Gets and sets the property PromptAttack. 
        /// <para>
        /// The prompt attack check results.
        /// </para>
        /// </summary>
        public GuardrailChecksPromptAttackResult PromptAttack { get; set; }

        /// <summary>
        /// Checks to see if the PromptAttack property is set.
        /// </summary>
        internal bool IsSetPromptAttack() => this.PromptAttack != null;

        /// <summary>
        /// Gets and sets the property SensitiveInformation. 
        /// <para>
        /// The sensitive information check results.
        /// </para>
        /// </summary>
        public GuardrailChecksSensitiveInformationResult SensitiveInformation { get; set; }

        /// <summary>
        /// Checks to see if the SensitiveInformation property is set.
        /// </summary>
        internal bool IsSetSensitiveInformation() => this.SensitiveInformation != null;
    }
}
