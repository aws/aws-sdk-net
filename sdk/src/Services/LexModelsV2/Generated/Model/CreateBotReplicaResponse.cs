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
    /// This is the response object from the CreateBotReplica operation.
    /// </summary>
    public partial class CreateBotReplicaResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private BotReplicaStatus _botReplicaStatus;
        private DateTime? _creationDateTime;
        private string _replicaRegion;
        private string _sourceRegion;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique bot ID of the replicated bot generated.
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
        /// Gets and sets the property BotReplicaStatus. 
        /// <para>
        /// The operational status of the replicated bot generated.
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
        /// The creation date and time of the replicated bot generated.
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
        /// Gets and sets the property ReplicaRegion. 
        /// <para>
        /// The region of the replicated bot generated.
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
        /// The source region for the source bot used for the replicated bot generated.
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