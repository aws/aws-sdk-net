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
    /// Summary information about bot locales returned by the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListBotLocales.html">ListBotLocales</a>
    /// operation.
    /// </summary>
    public partial class BotLocaleSummary
    {
        private BotLocaleStatus _botLocaleStatus;
        private string _description;
        private DateTime? _lastBuildSubmittedDateTime;
        private DateTime? _lastUpdatedDateTime;
        private string _localeId;
        private string _localeName;

        /// <summary>
        /// Gets and sets the property BotLocaleStatus. 
        /// <para>
        /// The current status of the bot locale. When the status is <code>Built</code> the locale
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the bot locale.
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
        /// Gets and sets the property LastBuildSubmittedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot locale was last built.
        /// </para>
        /// </summary>
        public DateTime LastBuildSubmittedDateTime
        {
            get { return this._lastBuildSubmittedDateTime.GetValueOrDefault(); }
            set { this._lastBuildSubmittedDateTime = value; }
        }

        // Check to see if LastBuildSubmittedDateTime property is set
        internal bool IsSetLastBuildSubmittedDateTime()
        {
            return this._lastBuildSubmittedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the bot locale was last updated.
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
        /// The language and locale of the bot locale.
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
        /// The name of the bot locale.
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

    }
}