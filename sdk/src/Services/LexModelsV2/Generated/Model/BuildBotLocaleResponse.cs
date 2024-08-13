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
    /// This is the response object from the BuildBotLocale operation.
    /// </summary>
    public partial class BuildBotLocaleResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private BotLocaleStatus _botLocaleStatus;
        private string _botVersion;
        private DateTime? _lastBuildSubmittedDateTime;
        private string _localeId;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the specified bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
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
        /// Gets and sets the property BotLocaleStatus. 
        /// <para>
        /// The bot's build status. When the status is <c>ReadyExpressTesting</c> you can test
        /// the bot using the utterances defined for the intents and slot types. When the status
        /// is <c>Built</c>, the bot is ready for use and can be tested using any utterance.
        /// </para>
        /// </summary>
        public BotLocaleStatus BotLocaleStatus
        {
            get { return this._botLocaleStatus; }
            set { this._botLocaleStatus = value; }
        }

        // Check to see if BotLocaleStatus property is set
        internal bool IsSetBotLocaleStatus()
        {
            return this._botLocaleStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that was built. This is only the draft version of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=5)]
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
        /// Gets and sets the property LastBuildSubmittedDateTime. 
        /// <para>
        /// A timestamp indicating the date and time that the bot was last built for this locale.
        /// </para>
        /// </summary>
        public DateTime? LastBuildSubmittedDateTime
        {
            get { return this._lastBuildSubmittedDateTime; }
            set { this._lastBuildSubmittedDateTime = value; }
        }

        // Check to see if LastBuildSubmittedDateTime property is set
        internal bool IsSetLastBuildSubmittedDateTime()
        {
            return this._lastBuildSubmittedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The language and locale specified of where the bot can be used.
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

    }
}