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
    /// This is the response object from the ListBotAliases operation.
    /// </summary>
    public partial class ListBotAliasesResponse : AmazonWebServiceResponse
    {
        private List<BotAliasSummary> _botAliasSummaries = AWSConfigs.InitializeCollections ? new List<BotAliasSummary>() : null;
        private string _botId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BotAliasSummaries. 
        /// <para>
        /// Summary information for the bot aliases that meet the filter criteria specified in
        /// the request. The length of the list is specified in the <c>maxResults</c> parameter
        /// of the request. If there are more aliases available, the <c>nextToken</c> field contains
        /// a token to get the next page of results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BotAliasSummary> BotAliasSummaries
        {
            get { return this._botAliasSummaries; }
            set { this._botAliasSummaries = value; }
        }

        // Check to see if BotAliasSummaries property is set
        internal bool IsSetBotAliasSummaries()
        {
            return this._botAliasSummaries != null && (this._botAliasSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with the aliases.
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
        /// A token that indicates whether there are more results to return in a response to the
        /// <c>ListBotAliases</c> operation. If the <c>nextToken</c> field is present, you send
        /// the contents as the <c>nextToken</c> parameter of a <c>ListBotAliases</c> operation
        /// request to get the next page of results.
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