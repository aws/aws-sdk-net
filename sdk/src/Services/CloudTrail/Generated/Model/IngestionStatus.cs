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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A table showing information about the most recent successful and failed attempts to
    /// ingest events.
    /// </summary>
    public partial class IngestionStatus
    {
        private string _latestIngestionAttemptEventID;
        private DateTime? _latestIngestionAttemptTime;
        private string _latestIngestionErrorCode;
        private string _latestIngestionSuccessEventID;
        private DateTime? _latestIngestionSuccessTime;

        /// <summary>
        /// Gets and sets the property LatestIngestionAttemptEventID. 
        /// <para>
        /// The event ID of the most recent attempt to ingest events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string LatestIngestionAttemptEventID
        {
            get { return this._latestIngestionAttemptEventID; }
            set { this._latestIngestionAttemptEventID = value; }
        }

        // Check to see if LatestIngestionAttemptEventID property is set
        internal bool IsSetLatestIngestionAttemptEventID()
        {
            return this._latestIngestionAttemptEventID != null;
        }

        /// <summary>
        /// Gets and sets the property LatestIngestionAttemptTime. 
        /// <para>
        /// The time stamp of the most recent attempt to ingest events on the channel.
        /// </para>
        /// </summary>
        public DateTime LatestIngestionAttemptTime
        {
            get { return this._latestIngestionAttemptTime.GetValueOrDefault(); }
            set { this._latestIngestionAttemptTime = value; }
        }

        // Check to see if LatestIngestionAttemptTime property is set
        internal bool IsSetLatestIngestionAttemptTime()
        {
            return this._latestIngestionAttemptTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestIngestionErrorCode. 
        /// <para>
        /// The error code for the most recent failure to ingest events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1000)]
        public string LatestIngestionErrorCode
        {
            get { return this._latestIngestionErrorCode; }
            set { this._latestIngestionErrorCode = value; }
        }

        // Check to see if LatestIngestionErrorCode property is set
        internal bool IsSetLatestIngestionErrorCode()
        {
            return this._latestIngestionErrorCode != null;
        }

        /// <summary>
        /// Gets and sets the property LatestIngestionSuccessEventID. 
        /// <para>
        /// The event ID of the most recent successful ingestion of events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string LatestIngestionSuccessEventID
        {
            get { return this._latestIngestionSuccessEventID; }
            set { this._latestIngestionSuccessEventID = value; }
        }

        // Check to see if LatestIngestionSuccessEventID property is set
        internal bool IsSetLatestIngestionSuccessEventID()
        {
            return this._latestIngestionSuccessEventID != null;
        }

        /// <summary>
        /// Gets and sets the property LatestIngestionSuccessTime. 
        /// <para>
        /// The time stamp of the most recent successful ingestion of events for the channel.
        /// </para>
        /// </summary>
        public DateTime LatestIngestionSuccessTime
        {
            get { return this._latestIngestionSuccessTime.GetValueOrDefault(); }
            set { this._latestIngestionSuccessTime = value; }
        }

        // Check to see if LatestIngestionSuccessTime property is set
        internal bool IsSetLatestIngestionSuccessTime()
        {
            return this._latestIngestionSuccessTime.HasValue; 
        }

    }
}