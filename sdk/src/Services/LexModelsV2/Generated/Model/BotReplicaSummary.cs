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
    /// Contains summary information about all the replication statuses applicable for global
    /// resiliency.
    /// </summary>
    public partial class BotReplicaSummary
    {
        private BotReplicaStatus _botReplicaStatus;
        private DateTime? _creationDateTime;
        private List<string> _failureReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _replicaRegion;

        /// <summary>
        /// Gets and sets the property BotReplicaStatus. 
        /// <para>
        /// The operation status for the replicated bot applicable.
        /// </para>
        /// </summary>
        public BotReplicaStatus BotReplicaStatus
        {
            get { return this._botReplicaStatus; }
            set { this._botReplicaStatus = value; }
        }

        // Check to see if BotReplicaStatus property is set
        internal bool IsSetBotReplicaStatus()
        {
            return this._botReplicaStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation time and date for the replicated bots.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// The reasons for the failure for the replicated bot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && (this._failureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicaRegion. 
        /// <para>
        /// The replica region used in the replication statuses summary.
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

    }
}