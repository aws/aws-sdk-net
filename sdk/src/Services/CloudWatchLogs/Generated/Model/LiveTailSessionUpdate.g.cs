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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This object contains the log events and metadata for a Live Tail session.
    /// </summary>
    public partial class LiveTailSessionUpdate : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property SessionMetadata. 
        /// <para>
        /// This object contains the session metadata for a Live Tail session.
        /// </para>
        /// </summary>
        public LiveTailSessionMetadata SessionMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SessionMetadata property is set.
        /// </summary>
        internal bool IsSetSessionMetadata() => this.SessionMetadata != null;

        /// <summary>
        /// Gets and sets the property SessionResults. 
        /// <para>
        /// An array, where each member of the array includes the information for one log event
        /// in the Live Tail session.
        /// </para>
        ///  
        /// <para>
        /// A <c>sessionResults</c> array can include as many as 500 log events. If the number
        /// of log events matching the request exceeds 500 per second, the log events are sampled
        /// down to 500 log events to be included in each <c>sessionUpdate</c> structure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LiveTailSessionLogEvent> SessionResults { get; set; } = AWSConfigs.InitializeCollections ? new List<LiveTailSessionLogEvent>() : null;

        /// <summary>
        /// Checks to see if the SessionResults property is set.
        /// </summary>
        internal bool IsSetSessionResults() => this.SessionResults != null && (this.SessionResults.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
