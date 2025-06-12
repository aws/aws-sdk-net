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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This object contains the log events and metadata for a Live Tail session.
    /// </summary>
    public partial class LiveTailSessionUpdate
        : IEventStreamEvent
    {
        private LiveTailSessionMetadata _sessionMetadata;
        private List<LiveTailSessionLogEvent> _sessionResults = AWSConfigs.InitializeCollections ? new List<LiveTailSessionLogEvent>() : null;

        /// <summary>
        /// Gets and sets the property SessionMetadata. 
        /// <para>
        /// This object contains the session metadata for a Live Tail session.
        /// </para>
        /// </summary>
        public LiveTailSessionMetadata SessionMetadata
        {
            get { return this._sessionMetadata; }
            set { this._sessionMetadata = value; }
        }

        // Check to see if SessionMetadata property is set
        internal bool IsSetSessionMetadata()
        {
            return this._sessionMetadata != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LiveTailSessionLogEvent> SessionResults
        {
            get { return this._sessionResults; }
            set { this._sessionResults = value; }
        }

        // Check to see if SessionResults property is set
        internal bool IsSetSessionResults()
        {
            return this._sessionResults != null && (this._sessionResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}