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
    /// This is the response object from the ListImports operation.
    /// </summary>
    public partial class ListImportsResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private string _botVersion;
        private List<ImportSummary> _importSummaries = new List<ImportSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier assigned by Amazon Lex to the bot.
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
        /// The version of the bot that was imported. It will always be <code>DRAFT</code>.
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
        /// Gets and sets the property ImportSummaries. 
        /// <para>
        /// Summary information for the imports that meet the filter criteria specified in the
        /// request. The length of the list is specified in the <code>maxResults</code> parameter.
        /// If there are more imports available, the <code>nextToken</code> field contains a token
        /// to get the next page of results.
        /// </para>
        /// </summary>
        public List<ImportSummary> ImportSummaries
        {
            get { return this._importSummaries; }
            set { this._importSummaries = value; }
        }

        // Check to see if ImportSummaries property is set
        internal bool IsSetImportSummaries()
        {
            return this._importSummaries != null && this._importSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates whether there are more results to return in a response to the
        /// <code>ListImports</code> operation. If the <code>nextToken</code> field is present,
        /// you send the contents as the <code>nextToken</code> parameter of a <code>ListImports</code>
        /// operation request to get the next page of results.
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