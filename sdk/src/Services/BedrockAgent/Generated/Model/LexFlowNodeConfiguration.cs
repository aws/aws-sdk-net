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
    /// Contains configurations for a Lex node in the flow. You specify a Amazon Lex bot to
    /// invoke. This node takes an utterance as the input and returns as the output the intent
    /// identified by the Amazon Lex bot. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-nodes.html">Node
    /// types in a flow</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class LexFlowNodeConfiguration
    {
        private string _botAliasArn;
        private string _localeId;

        /// <summary>
        /// Gets and sets the property BotAliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Lex bot alias to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=78)]
        public string BotAliasArn
        {
            get { return this._botAliasArn; }
            set { this._botAliasArn = value; }
        }

        // Check to see if BotAliasArn property is set
        internal bool IsSetBotAliasArn()
        {
            return this._botAliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The Region to invoke the Amazon Lex bot in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

    }
}