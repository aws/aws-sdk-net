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
    /// This is the response object from the GetUtterancesView operation.
    /// </summary>
    public partial class GetUtterancesViewResponse : AmazonWebServiceResponse
    {
        private string _botName;
        private List<UtteranceList> _utterances = new List<UtteranceList>();

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot for which utterance information was returned.
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
        /// Gets and sets the property Utterances. 
        /// <para>
        /// An array of <a>UtteranceList</a> objects, each containing a list of <a>UtteranceData</a>
        /// objects describing the utterances that were processed by your bot. The response contains
        /// a maximum of 100 <code>UtteranceData</code> objects for each version.
        /// </para>
        /// </summary>
        public List<UtteranceList> Utterances
        {
            get { return this._utterances; }
            set { this._utterances = value; }
        }

        // Check to see if Utterances property is set
        internal bool IsSetUtterances()
        {
            return this._utterances != null && this._utterances.Count > 0; 
        }

    }
}