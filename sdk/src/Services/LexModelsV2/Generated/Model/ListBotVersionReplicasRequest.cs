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
    /// Container for the parameters to the ListBotVersionReplicas operation.
    /// Contains information about all the versions replication statuses applicable for Global
    /// Resiliency.
    /// </summary>
    public partial class ListBotVersionReplicasRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private int? _maxResults;
        private string _nextToken;
        private string _replicaRegion;
        private BotVersionReplicaSortBy _sortBy;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The request for the unique ID in the list of replicated bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum results given in the list of replicated bots.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token given in the list of replicated bots.
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
        /// Gets and sets the property ReplicaRegion. 
        /// <para>
        /// The request for the region used in the list of replicated bots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=25)]
        public string ReplicaRegion
        {
            get { return this._replicaRegion; }
            set { this._replicaRegion = value; }
        }

        // Check to see if ReplicaRegion property is set
        internal bool IsSetReplicaRegion()
        {
            return this._replicaRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The requested sort category for the list of replicated bots.
        /// </para>
        /// </summary>
        public BotVersionReplicaSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

    }
}