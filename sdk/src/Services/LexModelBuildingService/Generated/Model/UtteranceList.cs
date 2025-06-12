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
    /// Provides a list of utterances that have been made to a specific version of your bot.
    /// The list contains a maximum of 100 utterances.
    /// </summary>
    public partial class UtteranceList
    {
        private string _botVersion;
        private List<UtteranceData> _utterances = AWSConfigs.InitializeCollections ? new List<UtteranceData>() : null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that processed the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Utterances. 
        /// <para>
        /// One or more <a>UtteranceData</a> objects that contain information about the utterances
        /// that have been made to a bot. The maximum number of object is 100.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UtteranceData> Utterances
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