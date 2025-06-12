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
    /// This is the response object from the SearchAssociatedTranscripts operation.
    /// </summary>
    public partial class SearchAssociatedTranscriptsResponse : AmazonWebServiceResponse
    {
        private List<AssociatedTranscript> _associatedTranscripts = AWSConfigs.InitializeCollections ? new List<AssociatedTranscript>() : null;
        private string _botId;
        private string _botRecommendationId;
        private string _botVersion;
        private string _localeId;
        private int? _nextIndex;
        private int? _totalResults;

        /// <summary>
        /// Gets and sets the property AssociatedTranscripts. 
        /// <para>
        /// The object that contains the associated transcript that meet the criteria you specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociatedTranscript> AssociatedTranscripts
        {
            get { return this._associatedTranscripts; }
            set { this._associatedTranscripts = value; }
        }

        // Check to see if AssociatedTranscripts property is set
        internal bool IsSetAssociatedTranscripts()
        {
            return this._associatedTranscripts != null && (this._associatedTranscripts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot associated with the transcripts that you are searching.
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
        /// Gets and sets the property BotRecommendationId. 
        /// <para>
        ///  The unique identifier of the bot recommendation associated with the transcripts to
        /// search.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotRecommendationId
        {
            get { return this._botRecommendationId; }
            set { this._botRecommendationId = value; }
        }

        // Check to see if BotRecommendationId property is set
        internal bool IsSetBotRecommendationId()
        {
            return this._botRecommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot containing the transcripts that you are searching.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
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
        /// The identifier of the language and locale of the transcripts to search. The string
        /// must match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a> 
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
        /// Gets and sets the property NextIndex. 
        /// <para>
        /// A index that indicates whether there are more results to return in a response to the
        /// SearchAssociatedTranscripts operation. If the nextIndex field is present, you send
        /// the contents as the nextIndex parameter of a SearchAssociatedTranscriptsRequest operation
        /// to get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000)]
        public int? NextIndex
        {
            get { return this._nextIndex; }
            set { this._nextIndex = value; }
        }

        // Check to see if NextIndex property is set
        internal bool IsSetNextIndex()
        {
            return this._nextIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResults. 
        /// <para>
        /// The total number of transcripts returned by the search.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? TotalResults
        {
            get { return this._totalResults; }
            set { this._totalResults = value; }
        }

        // Check to see if TotalResults property is set
        internal bool IsSetTotalResults()
        {
            return this._totalResults.HasValue; 
        }

    }
}