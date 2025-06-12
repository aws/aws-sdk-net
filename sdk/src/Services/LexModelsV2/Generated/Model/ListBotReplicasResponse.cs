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
    /// This is the response object from the ListBotReplicas operation.
    /// </summary>
    public partial class ListBotReplicasResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private List<BotReplicaSummary> _botReplicaSummaries = AWSConfigs.InitializeCollections ? new List<BotReplicaSummary>() : null;
        private string _sourceRegion;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// the unique bot IDs in the list of replicated bots.
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
        /// Gets and sets the property BotReplicaSummaries. 
        /// <para>
        /// The summary details for the replicated bots.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BotReplicaSummary> BotReplicaSummaries
        {
            get { return this._botReplicaSummaries; }
            set { this._botReplicaSummaries = value; }
        }

        // Check to see if BotReplicaSummaries property is set
        internal bool IsSetBotReplicaSummaries()
        {
            return this._botReplicaSummaries != null && (this._botReplicaSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The source region of the source bots in the list of replicated bots.
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