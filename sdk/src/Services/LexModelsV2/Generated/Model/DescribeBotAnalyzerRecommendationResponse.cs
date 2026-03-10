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
    /// This is the response object from the DescribeBotAnalyzerRecommendation operation.
    /// </summary>
    public partial class DescribeBotAnalyzerRecommendationResponse : AmazonWebServiceResponse
    {
        private List<BotAnalyzerRecommendation> _botAnalyzerRecommendationList = AWSConfigs.InitializeCollections ? new List<BotAnalyzerRecommendation>() : null;
        private BotAnalyzerStatus _botAnalyzerStatus;
        private string _botId;
        private string _botVersion;
        private DateTime? _creationDateTime;
        private string _localeId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BotAnalyzerRecommendationList. 
        /// <para>
        /// A list of recommendations for optimizing your bot configuration. Each recommendation
        /// includes the issue location, priority, description, and proposed fix.
        /// </para>
        /// </summary>
        public List<BotAnalyzerRecommendation> BotAnalyzerRecommendationList
        {
            get { return this._botAnalyzerRecommendationList; }
            set { this._botAnalyzerRecommendationList = value; }
        }

        // Check to see if BotAnalyzerRecommendationList property is set
        internal bool IsSetBotAnalyzerRecommendationList()
        {
            return this._botAnalyzerRecommendationList != null && (this._botAnalyzerRecommendationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BotAnalyzerStatus. 
        /// <para>
        /// The current status of the analysis.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>Processing | Available | Failed | Stopping | Stopped</c> 
        /// </para>
        /// </summary>
        public BotAnalyzerStatus BotAnalyzerStatus
        {
            get { return this._botAnalyzerStatus; }
            set { this._botAnalyzerStatus = value; }
        }

        // Check to see if BotAnalyzerStatus property is set
        internal bool IsSetBotAnalyzerStatus()
        {
            return this._botAnalyzerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot.
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that was analyzed.
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
        /// The date and time when the analysis was initiated.
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
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale identifier of the bot locale that was analyzed.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, this token can be used in a subsequent request to retrieve
        /// the next page of recommendations.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}