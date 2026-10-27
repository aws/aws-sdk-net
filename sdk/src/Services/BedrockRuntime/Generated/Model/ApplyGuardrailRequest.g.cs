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
    /// Container for the parameters to the ApplyGuardrail operation. The action to apply
    /// a guardrail. <para> For troubleshooting some of the common errors you might encounter
    /// when using the <c>ApplyGuardrail</c> API, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html">Troubleshooting
    /// Amazon Bedrock API Error Codes</a> in the Amazon Bedrock User Guide </para>
    /// </summary>
    public partial class ApplyGuardrailRequest : AmazonBedrockRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content details used in the request to apply the guardrail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<GuardrailContentBlock> Content { get; set; } = AWSConfigs.InitializeCollections ? new List<GuardrailContentBlock>() : null;

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null && (this.Content.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GuardrailIdentifier. 
        /// <para>
        /// The guardrail identifier used in the request to apply the guardrail.
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
        /// The guardrail version used in the request to apply the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GuardrailVersion { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailVersion property is set.
        /// </summary>
        internal bool IsSetGuardrailVersion() => this.GuardrailVersion != null;

        /// <summary>
        /// Gets and sets the property OutputScope. 
        /// <para>
        /// Specifies the scope of the output that you get in the response. Set to <c>FULL</c>
        /// to return the entire output, including any detected and non-detected entries in the
        /// response for enhanced debugging.
        /// </para>
        ///  
        /// <para>
        /// Note that the full output scope doesn't apply to word filters or regex in sensitive
        /// information filters. It does apply to all other filtering policies, including sensitive
        /// information with filters that can detect personally identifiable information (PII).
        /// </para>
        /// </summary>
        public GuardrailOutputScope OutputScope { get; set; }

        /// <summary>
        /// Checks to see if the OutputScope property is set.
        /// </summary>
        internal bool IsSetOutputScope() => this.OutputScope != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of data used in the request to apply the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailContentSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
