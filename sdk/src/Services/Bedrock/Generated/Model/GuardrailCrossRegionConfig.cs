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
    /// The system-defined guardrail profile that you're using with your guardrail. Guardrail
    /// profiles define the destination Amazon Web Services Regions where guardrail inference
    /// requests can be automatically routed. Using guardrail profiles helps maintain guardrail
    /// performance and reliability when demand increases.
    /// 
    ///  
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-cross-region.html">Amazon
    /// Bedrock User Guide</a>.
    /// </para>
    /// </summary>
    public partial class GuardrailCrossRegionConfig
    {
        private string _guardrailProfileIdentifier;

        /// <summary>
        /// Gets and sets the property GuardrailProfileIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the guardrail profile that your guardrail
        /// is using. Guardrail profile availability depends on your current Amazon Web Services
        /// Region. For more information, see the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-cross-region-support.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=2048)]
        public string GuardrailProfileIdentifier
        {
            get { return this._guardrailProfileIdentifier; }
            set { this._guardrailProfileIdentifier = value; }
        }

        // Check to see if GuardrailProfileIdentifier property is set
        internal bool IsSetGuardrailProfileIdentifier()
        {
            return this._guardrailProfileIdentifier != null;
        }

    }
}