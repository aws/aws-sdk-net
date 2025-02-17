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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
    /// Container for the parameters to the ApplyGuardrail operation.
    /// The action to apply a guardrail.
    /// 
    ///  
    /// <para>
    /// For troubleshooting some of the common errors you might encounter when using the <c>ApplyGuardrail</c>
    /// API, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/troubleshooting-api-error-codes.html">Troubleshooting
    /// Amazon Bedrock API Error Codes</a> in the Amazon Bedrock User Guide
    /// </para>
    /// </summary>
    public partial class ApplyGuardrailRequest : AmazonBedrockRuntimeRequest
    {
        private List<GuardrailContentBlock> _content = AWSConfigs.InitializeCollections ? new List<GuardrailContentBlock>() : null;
        private string _guardrailIdentifier;
        private string _guardrailVersion;
        private GuardrailContentSource _source;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content details used in the request to apply the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GuardrailContentBlock> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && (this._content.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GuardrailIdentifier. 
        /// <para>
        /// The guardrail identifier used in the request to apply the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string GuardrailIdentifier
        {
            get { return this._guardrailIdentifier; }
            set { this._guardrailIdentifier = value; }
        }

        // Check to see if GuardrailIdentifier property is set
        internal bool IsSetGuardrailIdentifier()
        {
            return this._guardrailIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// The guardrail version used in the request to apply the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of data used in the request to apply the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailContentSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}