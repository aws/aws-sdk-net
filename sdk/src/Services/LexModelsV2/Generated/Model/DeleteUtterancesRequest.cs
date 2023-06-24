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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteUtterances operation.
    /// Deletes stored utterances.
    /// 
    ///  
    /// <para>
    /// Amazon Lex stores the utterances that users send to your bot. Utterances are stored
    /// for 15 days for use with the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListAggregatedUtterances.html">ListAggregatedUtterances</a>
    /// operation, and then stored indefinitely for use in improving the ability of your bot
    /// to respond to user input..
    /// </para>
    ///  
    /// <para>
    /// Use the <code>DeleteUtterances</code> operation to manually delete utterances for
    /// a specific session. When you use the <code>DeleteUtterances</code> operation, utterances
    /// stored for improving your bot's ability to respond to user input are deleted immediately.
    /// Utterances stored for use with the <code>ListAggregatedUtterances</code> operation
    /// are deleted after 15 days.
    /// </para>
    /// </summary>
    public partial class DeleteUtterancesRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _localeId;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot that contains the utterances.
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

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale where the utterances were collected. The
        /// string must match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session with the user. The ID is returned in the response
        /// from the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_runtime_RecognizeText.html">RecognizeText</a>
        /// and <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_runtime_RecognizeUtterance.html">RecognizeUtterance</a>
        /// operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}