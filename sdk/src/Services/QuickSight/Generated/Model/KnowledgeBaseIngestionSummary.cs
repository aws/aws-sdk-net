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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A summary of an ingestion job for a knowledge base.
    /// </summary>
    public partial class KnowledgeBaseIngestionSummary
    {
        private DateTime? _endTime;
        private string _ingestionId;
        private KbIngestionStatus _ingestionStatus;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the ingestion job.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngestionId. 
        /// <para>
        /// The unique identifier for the ingestion job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string IngestionId
        {
            get { return this._ingestionId; }
            set { this._ingestionId = value; }
        }

        // Check to see if IngestionId property is set
        internal bool IsSetIngestionId()
        {
            return this._ingestionId != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionStatus. 
        /// <para>
        /// The status of the ingestion job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KbIngestionStatus IngestionStatus
        {
            get { return this._ingestionStatus; }
            set { this._ingestionStatus = value; }
        }

        // Check to see if IngestionStatus property is set
        internal bool IsSetIngestionStatus()
        {
            return this._ingestionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the ingestion job.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}