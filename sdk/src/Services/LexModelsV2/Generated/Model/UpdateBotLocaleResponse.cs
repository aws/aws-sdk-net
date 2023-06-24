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
    /// This is the response object from the UpdateBotLocale operation.
    /// </summary>
    public partial class UpdateBotLocaleResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private BotLocaleStatus _botLocaleStatus;
        private string _botVersion;
        private DateTime? _creationDateTime;
        private string _description;
        private List<string> _failureReasons = new List<string>();
        private DateTime? _lastUpdatedDateTime;
        private string _localeId;
        private string _localeName;
        private double? _nluIntentConfidenceThreshold;
        private List<string> _recommendedActions = new List<string>();
        private VoiceSettings _voiceSettings;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the updated locale.
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
        /// The current status of the locale. When the bot status is <code>Built</code> the locale
        /// is ready for use.
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
        /// The version of the bot that contains the updated locale.
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the locale was created.
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the <code>botLocaleStatus</code> is <code>Failed</code>, the <code>failureReasons</code>
        /// field lists the errors that occurred while building the bot.
        /// </para>
        /// </summary>
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && this._failureReasons.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the locale was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime.GetValueOrDefault(); }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The language and locale of the updated bot locale.
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
        /// Gets and sets the property LocaleName. 
        /// <para>
        /// The updated locale name for the locale.
        /// </para>
        /// </summary>
        public string LocaleName
        {
            get { return this._localeName; }
            set { this._localeName = value; }
        }

        // Check to see if LocaleName property is set
        internal bool IsSetLocaleName()
        {
            return this._localeName != null;
        }

        /// <summary>
        /// Gets and sets the property NluIntentConfidenceThreshold. 
        /// <para>
        /// The updated confidence threshold for inserting the <code>AMAZON.FallbackIntent</code>
        /// and <code>AMAZON.KendraSearchIntent</code> intents in the list of possible intents
        /// for an utterance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double NluIntentConfidenceThreshold
        {
            get { return this._nluIntentConfidenceThreshold.GetValueOrDefault(); }
            set { this._nluIntentConfidenceThreshold = value; }
        }

        // Check to see if NluIntentConfidenceThreshold property is set
        internal bool IsSetNluIntentConfidenceThreshold()
        {
            return this._nluIntentConfidenceThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendedActions. 
        /// <para>
        /// Recommended actions to take to resolve an error in the <code>failureReasons</code>
        /// field.
        /// </para>
        /// </summary>
        public List<string> RecommendedActions
        {
            get { return this._recommendedActions; }
            set { this._recommendedActions = value; }
        }

        // Check to see if RecommendedActions property is set
        internal bool IsSetRecommendedActions()
        {
            return this._recommendedActions != null && this._recommendedActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VoiceSettings. 
        /// <para>
        /// The updated Amazon Polly voice to use for voice interaction with the user.
        /// </para>
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