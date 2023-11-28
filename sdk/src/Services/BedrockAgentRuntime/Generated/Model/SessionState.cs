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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Session state provided
    /// </summary>
    public partial class SessionState
    {
        private Dictionary<string, string> _promptSessionAttributes = new Dictionary<string, string>();
        private Dictionary<string, string> _sessionAttributes = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property PromptSessionAttributes. 
        /// <para>
        /// Prompt Session Attributes
        /// </para>
        /// </summary>
        public Dictionary<string, string> PromptSessionAttributes
        {
            get { return this._promptSessionAttributes; }
            set { this._promptSessionAttributes = value; }
        }

        // Check to see if PromptSessionAttributes property is set
        internal bool IsSetPromptSessionAttributes()
        {
            return this._promptSessionAttributes != null && this._promptSessionAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Session Attributes
        /// </para>
        /// </summary>
        public Dictionary<string, string> SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null && this._sessionAttributes.Count > 0; 
        }

    }
}