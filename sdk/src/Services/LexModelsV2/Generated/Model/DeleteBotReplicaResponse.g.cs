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
    /// This is the response object from the DeleteBotReplica operation.
    /// </summary>
    public partial class DeleteBotReplicaResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique bot ID of the replicated bot generated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotReplicaStatus. 
        /// <para>
        /// The operational status of the replicated bot generated.
        /// </para>
        /// </summary>
        public BotReplicaStatus BotReplicaStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotReplicaStatus property is set.
        /// </summary>
        internal bool IsSetBotReplicaStatus() => this.BotReplicaStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicaRegion. 
        /// <para>
        /// The region of the replicated bot generated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 25)]
        public string ReplicaRegion { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaRegion property is set.
        /// </summary>
        internal bool IsSetReplicaRegion() => this.ReplicaRegion != null;
    }
}
