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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the StopBotAnalyzer operation.
    /// Cancels an ongoing bot analysis execution. Once stopped, the analysis cannot be resumed
    /// and no recommendations will be generated.
    /// </summary>
    public partial class StopBotAnalyzerRequest : AmazonLexModelsV2Request
    {
        private string _botAnalyzerRequestId;
        private string _botId;

        /// <summary>
        /// Gets and sets the property BotAnalyzerRequestId. 
        /// <para>
        /// The unique identifier of the analysis request to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string BotAnalyzerRequestId
        {
            get { return this._botAnalyzerRequestId; }
            set { this._botAnalyzerRequestId = value; }
        }

        // Check to see if BotAnalyzerRequestId property is set
        internal bool IsSetBotAnalyzerRequestId()
        {
            return this._botAnalyzerRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

    }
}