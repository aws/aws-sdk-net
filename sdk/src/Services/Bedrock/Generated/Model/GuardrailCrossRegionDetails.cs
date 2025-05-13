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
    /// Contains details about the system-defined guardrail profile that you're using with
    /// your guardrail for cross-Region inference.
    /// 
    ///  
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-cross-region.html">Amazon
    /// Bedrock User Guide</a>.
    /// </para>
    /// </summary>
    public partial class GuardrailCrossRegionDetails
    {
        private string _guardrailProfileArn;
        private string _guardrailProfileId;

        /// <summary>
        /// Gets and sets the property GuardrailProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the guardrail profile that you're using with your
        /// guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string GuardrailProfileArn
        {
            get { return this._guardrailProfileArn; }
            set { this._guardrailProfileArn = value; }
        }

        // Check to see if GuardrailProfileArn property is set
        internal bool IsSetGuardrailProfileArn()
        {
            return this._guardrailProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailProfileId. 
        /// <para>
        /// The ID of the guardrail profile that your guardrail is using. Profile availability
        /// depends on your current Amazon Web Services Region. For more information, see the
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-cross-region-support.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=30)]
        public string GuardrailProfileId
        {
            get { return this._guardrailProfileId; }
            set { this._guardrailProfileId = value; }
        }

        // Check to see if GuardrailProfileId property is set
        internal bool IsSetGuardrailProfileId()
        {
            return this._guardrailProfileId != null;
        }

    }
}