/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetUtterancesView operation.
    /// Use the <code>GetUtterancesView</code> operation to get information about the utterances
    /// that your users have made to your bot. You can use this list to tune the utterances
    /// that your bot responds to.
    /// 
    ///  
    /// <para>
    /// For example, say that you have created a bot to order flowers. After your users have
    /// used your bot for a while, use the <code>GetUtterancesView</code> operation to see
    /// the requests that they have made and whether they have been successful. You might
    /// find that the utterance "I want flowers" is not being recognized. You could add this
    /// utterance to the <code>OrderFlowers</code> intent so that your bot recognizes that
    /// utterance.
    /// </para>
    ///  
    /// <para>
    /// After you publish a new version of a bot, you can get information about the old version
    /// and the new so that you can compare the performance across the two versions. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Utterance statistics are generated once a day. Data is available for the last 15 days.
    /// You can request information for up to 5 versions in each request. The response contains
    /// information about a maximum of 100 utterances for each version.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permissions for the <code>lex:GetUtterancesView</code> action.
    /// </para>
    /// </summary>
    public partial class GetUtterancesViewRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _botName;
        private List<string> _botVersions = new List<string>();
        private StatusType _statusType;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot for which utterance information should be returned.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property BotVersions. 
        /// <para>
        /// An array of bot versions for which utterance information should be returned. The limit
        /// is 5 versions per request.
        /// </para>
        /// </summary>
        public List<string> BotVersions
        {
            get { return this._botVersions; }
            set { this._botVersions = value; }
        }

        // Check to see if BotVersions property is set
        internal bool IsSetBotVersions()
        {
            return this._botVersions != null && this._botVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatusType. 
        /// <para>
        /// To return utterances that were recognized and handled, use<code>Detected</code>. To
        /// return utterances that were not recognized, use <code>Missed</code>.
        /// </para>
        /// </summary>
        public StatusType StatusType
        {
            get { return this._statusType; }
            set { this._statusType = value; }
        }

        // Check to see if StatusType property is set
        internal bool IsSetStatusType()
        {
            return this._statusType != null;
        }

    }
}