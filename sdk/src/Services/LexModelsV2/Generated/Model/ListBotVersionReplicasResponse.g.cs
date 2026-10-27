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
    /// This is the response object from the ListBotVersionReplicas operation.
    /// </summary>
    public partial class ListBotVersionReplicasResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique ID of the bots in the list of replicated bots.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersionReplicaSummaries. 
        /// <para>
        /// The information summary used for the replicated bots in the list of replicated bots.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BotVersionReplicaSummary> BotVersionReplicaSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<BotVersionReplicaSummary>() : null;

        /// <summary>
        /// Checks to see if the BotVersionReplicaSummaries property is set.
        /// </summary>
        internal bool IsSetBotVersionReplicaSummaries() => this.BotVersionReplicaSummaries != null && (this.BotVersionReplicaSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token used for the replicated bots in the list of replicated bots.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ReplicaRegion. 
        /// <para>
        /// The region used for the replicated bots in the list of replicated bots.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 25)]
        public string ReplicaRegion { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaRegion property is set.
        /// </summary>
        internal bool IsSetReplicaRegion() => this.ReplicaRegion != null;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The source region used for the bots in the list of replicated bots.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 25)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceRegion property is set.
        /// </summary>
        internal bool IsSetSourceRegion() => this.SourceRegion != null;
    }
}
