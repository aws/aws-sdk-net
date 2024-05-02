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
    /// Provides the bot locale parameters required for importing a bot locale.
    /// </summary>
    public partial class BotLocaleImportSpecification
    {
        private string _botId;
        private string _botVersion;
        private string _localeId;
        private double? _nluIntentConfidenceThreshold;
        private VoiceSettings _voiceSettings;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot to import the locale to.
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot to import the locale to. This can only be the <c>DRAFT</c>
        /// version of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=5)]
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
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale that the bot will be used in. The string
        /// must match one of the supported locales. All of the intents, slot types, and slots
        /// used in the bot must have the same locale. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NluIntentConfidenceThreshold. 
        /// <para>
        /// Determines the threshold where Amazon Lex will insert the <c>AMAZON.FallbackIntent</c>,
        /// <c>AMAZON.KendraSearchIntent</c>, or both when returning alternative intents. <c>AMAZON.FallbackIntent</c>
        /// and <c>AMAZON.KendraSearchIntent</c> are only inserted if they are configured for
        /// the bot. 
        /// </para>
        ///  
        /// <para>
        /// For example, suppose a bot is configured with the confidence threshold of 0.80 and
        /// the <c>AMAZON.FallbackIntent</c>. Amazon Lex returns three alternative intents with
        /// the following confidence scores: IntentA (0.70), IntentB (0.60), IntentC (0.50). The
        /// response from the <c>PostText</c> operation would be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AMAZON.FallbackIntent</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IntentA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IntentB</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IntentC</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? NluIntentConfidenceThreshold
        {
            get { return this._nluIntentConfidenceThreshold; }
            set { this._nluIntentConfidenceThreshold = value; }
        }

        // Check to see if NluIntentConfidenceThreshold property is set
        internal bool IsSetNluIntentConfidenceThreshold()
        {
            return this._nluIntentConfidenceThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VoiceSettings.
        /// </summary>
        public VoiceSettings VoiceSettings
        {
            get { return this._voiceSettings; }
            set { this._voiceSettings = value; }
        }

        // Check to see if VoiceSettings property is set
        internal bool IsSetVoiceSettings()
        {
            return this._voiceSettings != null;
        }

    }
}