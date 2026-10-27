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
    /// Container for the parameters to the StartBotAnalyzer operation. Initiates an asynchronous
    /// analysis of your bot configuration using AI-powered analysis to identify potential
    /// issues and recommend improvements based on AWS best practices. <para> The analysis
    /// examines your bot's configuration, including intents, utterances, slots, and conversation
    /// flows, to provide actionable recommendations for optimization. </para>
    /// </summary>
    public partial class StartBotAnalyzerRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property AnalysisScope. 
        /// <para>
        /// The scope of analysis to perform. Currently only <c>BotLocale</c> scope is supported.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>BotLocale</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisScope AnalysisScope { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisScope property is set.
        /// </summary>
        internal bool IsSetAnalysisScope() => this.AnalysisScope != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot to analyze.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot to analyze. Defaults to <c>DRAFT</c> if not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale identifier for the bot locale to analyze. Required when <c>analysisScope</c>
        /// is <c>BotLocale</c>.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;
    }
}
