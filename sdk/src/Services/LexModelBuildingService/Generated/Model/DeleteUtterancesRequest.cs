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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteUtterances operation.
    /// Deletes stored utterances.
    /// 
    ///  
    /// <para>
    /// Amazon Lex stores the utterances that users send to your bot. Utterances are stored
    /// for 15 days for use with the <a>GetUtterancesView</a> operation, and then stored indefinitely
    /// for use in improving the ability of your bot to respond to user input.
    /// </para>
    ///  
    /// <para>
    /// Use the <c>DeleteUtterances</c> operation to manually delete stored utterances for
    /// a specific user. When you use the <c>DeleteUtterances</c> operation, utterances stored
    /// for improving your bot's ability to respond to user input are deleted immediately.
    /// Utterances stored for use with the <c>GetUtterancesView</c> operation are deleted
    /// after 15 days.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <c>lex:DeleteUtterances</c> action.
    /// </para>
    /// </summary>
    public partial class DeleteUtterancesRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _botName;
        private string _userId;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot that stored the utterances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        ///  The unique identifier for the user that made the utterances. This is the user ID
        /// that was sent in the <a href="http://docs.aws.amazon.com/lex/latest/dg/API_runtime_PostContent.html">PostContent</a>
        /// or <a href="http://docs.aws.amazon.com/lex/latest/dg/API_runtime_PostText.html">PostText</a>
        /// operation request that contained the utterance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}