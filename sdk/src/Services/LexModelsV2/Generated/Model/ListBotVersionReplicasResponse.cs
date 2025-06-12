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
    /// This is the response object from the ListBotVersionReplicas operation.
    /// </summary>
    public partial class ListBotVersionReplicasResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private List<BotVersionReplicaSummary> _botVersionReplicaSummaries = AWSConfigs.InitializeCollections ? new List<BotVersionReplicaSummary>() : null;
        private string _nextToken;
        private string _replicaRegion;
        private string _sourceRegion;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique ID of the bots in the list of replicated bots.
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
        /// Gets and sets the property BotVersionReplicaSummaries. 
        /// <para>
        /// The information summary used for the replicated bots in the list of replicated bots.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BotVersionReplicaSummary> BotVersionReplicaSummaries
        {
            get { return this._botVersionReplicaSummaries; }
            set { this._botVersionReplicaSummaries = value; }
        }

        // Check to see if BotVersionReplicaSummaries property is set
        internal bool IsSetBotVersionReplicaSummaries()
        {
            return this._botVersionReplicaSummaries != null && (this._botVersionReplicaSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token used for the replicated bots in the list of replicated bots.
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
        /// The region used for the replicated bots in the list of replicated bots.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=25)]
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
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The source region used for the bots in the list of replicated bots.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=25)]
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

    }
}