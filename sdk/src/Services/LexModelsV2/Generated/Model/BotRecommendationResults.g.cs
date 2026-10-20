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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AssociatedTranscriptsUrl. 
        /// <para>
        /// The presigned url link of the associated transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AssociatedTranscriptsUrl { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedTranscriptsUrl property is set.
        /// </summary>
        internal bool IsSetAssociatedTranscriptsUrl() => this.AssociatedTranscriptsUrl != null;

        /// <summary>
        /// Gets and sets the property BotLocaleExportUrl. 
        /// <para>
        /// The presigned URL link of the recommended bot definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string BotLocaleExportUrl { get; set; }

        /// <summary>
        /// Checks to see if the BotLocaleExportUrl property is set.
        /// </summary>
        internal bool IsSetBotLocaleExportUrl() => this.BotLocaleExportUrl != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistical summary of the bot recommendation results.
        /// </para>
        /// </summary>
        public BotRecommendationResultStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;
    }
}
