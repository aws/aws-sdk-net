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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A table showing information about the most recent successful and failed attempts to
    /// ingest events.
    /// </summary>
    public partial class IngestionStatus
    {
        /// <summary>
        /// Gets and sets the property LatestIngestionAttemptEventID. 
        /// <para>
        /// The event ID of the most recent attempt to ingest events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string LatestIngestionAttemptEventID { get; set; }

        /// <summary>
        /// Checks to see if the LatestIngestionAttemptEventID property is set.
        /// </summary>
        internal bool IsSetLatestIngestionAttemptEventID() => this.LatestIngestionAttemptEventID != null;

        /// <summary>
        /// Gets and sets the property LatestIngestionAttemptTime. 
        /// <para>
        /// The time stamp of the most recent attempt to ingest events on the channel.
        /// </para>
        /// </summary>
        public DateTime? LatestIngestionAttemptTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestIngestionAttemptTime property is set.
        /// </summary>
        internal bool IsSetLatestIngestionAttemptTime() => this.LatestIngestionAttemptTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestIngestionErrorCode. 
        /// <para>
        /// The error code for the most recent failure to ingest events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1000)]
        public string LatestIngestionErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the LatestIngestionErrorCode property is set.
        /// </summary>
        internal bool IsSetLatestIngestionErrorCode() => this.LatestIngestionErrorCode != null;

        /// <summary>
        /// Gets and sets the property LatestIngestionSuccessEventID. 
        /// <para>
        /// The event ID of the most recent successful ingestion of events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string LatestIngestionSuccessEventID { get; set; }

        /// <summary>
        /// Checks to see if the LatestIngestionSuccessEventID property is set.
        /// </summary>
        internal bool IsSetLatestIngestionSuccessEventID() => this.LatestIngestionSuccessEventID != null;

        /// <summary>
        /// Gets and sets the property LatestIngestionSuccessTime. 
        /// <para>
        /// The time stamp of the most recent successful ingestion of events for the channel.
        /// </para>
        /// </summary>
        public DateTime? LatestIngestionSuccessTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestIngestionSuccessTime property is set.
        /// </summary>
        internal bool IsSetLatestIngestionSuccessTime() => this.LatestIngestionSuccessTime.HasValue;
    }
}
