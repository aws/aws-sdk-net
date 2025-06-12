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
    /// This is the response object from the ListSessionAnalyticsData operation.
    /// </summary>
    public partial class ListSessionAnalyticsDataResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private string _nextToken;
        private List<SessionSpecification> _sessions = AWSConfigs.InitializeCollections ? new List<SessionSpecification>() : null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot that the sessions belong to.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response from the ListSessionAnalyticsData operation contains more results
        /// than specified in the maxResults parameter, a token is returned in the response.
        /// </para>
        ///  
        /// <para>
        /// Use the returned token in the nextToken parameter of a ListSessionAnalyticsData request
        /// to return the next page of results. For a complete set of results, call the ListSessionAnalyticsData
        /// operation until the nextToken returned in the response is null.
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

        /// <summary>
        /// Gets and sets the property Sessions. 
        /// <para>
        /// A list of objects, each of which contains information about a session with the bot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SessionSpecification> Sessions
        {
            get { return this._sessions; }
            set { this._sessions = value; }
        }

        // Check to see if Sessions property is set
        internal bool IsSetSessions()
        {
            return this._sessions != null && (this._sessions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}