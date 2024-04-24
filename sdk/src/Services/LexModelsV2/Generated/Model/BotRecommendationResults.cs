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
    /// The object representing the URL of the bot definition, the URL of the associated transcript,
    /// and a statistical summary of the bot recommendation results.
    /// </summary>
    public partial class BotRecommendationResults
    {
        private string _associatedTranscriptsUrl;
        private string _botLocaleExportUrl;
        private BotRecommendationResultStatistics _statistics;

        /// <summary>
        /// Gets and sets the property AssociatedTranscriptsUrl. 
        /// <para>
        /// The presigned url link of the associated transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string AssociatedTranscriptsUrl
        {
            get { return this._associatedTranscriptsUrl; }
            set { this._associatedTranscriptsUrl = value; }
        }

        // Check to see if AssociatedTranscriptsUrl property is set
        internal bool IsSetAssociatedTranscriptsUrl()
        {
            return this._associatedTranscriptsUrl != null;
        }

        /// <summary>
        /// Gets and sets the property BotLocaleExportUrl. 
        /// <para>
        /// The presigned URL link of the recommended bot definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string BotLocaleExportUrl
        {
            get { return this._botLocaleExportUrl; }
            set { this._botLocaleExportUrl = value; }
        }

        // Check to see if BotLocaleExportUrl property is set
        internal bool IsSetBotLocaleExportUrl()
        {
            return this._botLocaleExportUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistical summary of the bot recommendation results.
        /// </para>
        /// </summary>
        public BotRecommendationResultStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

    }
}