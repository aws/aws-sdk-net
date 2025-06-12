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
    /// This is the response object from the GetUtterancesView operation.
    /// </summary>
    public partial class GetUtterancesViewResponse : AmazonWebServiceResponse
    {
        private string _botName;
        private List<UtteranceList> _utterances = AWSConfigs.InitializeCollections ? new List<UtteranceList>() : null;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot for which utterance information was returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
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
        /// a maximum of 100 <c>UtteranceData</c> objects for each version. Amazon Lex returns
        /// the most frequent utterances received by the bot in the last 15 days.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UtteranceList> Utterances
        {
            get { return this._utterances; }
            set { this._utterances = value; }
        }

        // Check to see if Utterances property is set
        internal bool IsSetUtterances()
        {
            return this._utterances != null && (this._utterances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}