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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
    /// Contains configurations for an inline code node in your flow. Inline code nodes let
    /// you write and execute code directly within your flow, enabling data transformations,
    /// custom logic, and integrations without needing an external Lambda function.
    /// </summary>
    public partial class InlineCodeFlowNodeConfiguration
    {
        private string _code;
        private SupportedLanguages _language;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code that's executed in your inline code node. The code can access input data
        /// from previous nodes in the flow, perform operations on that data, and produce output
        /// that can be used by other nodes in your flow.
        /// </para>
        ///  
        /// <para>
        /// The code must be valid in the programming <c>language</c> that you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=5000000)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The programming language used by your inline code node.
        /// </para>
        ///  
        /// <para>
        /// The code must be valid in the programming <c>language</c> that you specify. Currently,
        /// only Python 3 (<c>Python_3</c>) is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupportedLanguages Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

    }
}