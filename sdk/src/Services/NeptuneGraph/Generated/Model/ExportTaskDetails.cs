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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Contains details about the specified export task.
    /// </summary>
    public partial class ExportTaskDetails
    {
        private long? _numEdgesWritten;
        private long? _numVerticesWritten;
        private int? _progressPercentage;
        private DateTime? _startTime;
        private long? _timeElapsedSeconds;

        /// <summary>
        /// Gets and sets the property NumEdgesWritten. 
        /// <para>
        /// The number of exported edges.
        /// </para>
        /// </summary>
        public long? NumEdgesWritten
        {
            get { return this._numEdgesWritten; }
            set { this._numEdgesWritten = value; }
        }

        // Check to see if NumEdgesWritten property is set
        internal bool IsSetNumEdgesWritten()
        {
            return this._numEdgesWritten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumVerticesWritten. 
        /// <para>
        /// The number of exported vertices.
        /// </para>
        /// </summary>
        public long? NumVerticesWritten
        {
            get { return this._numVerticesWritten; }
            set { this._numVerticesWritten = value; }
        }

        // Check to see if NumVerticesWritten property is set
        internal bool IsSetNumVerticesWritten()
        {
            return this._numVerticesWritten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// The number of progress percentage of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ProgressPercentage
        {
            get { return this._progressPercentage; }
            set { this._progressPercentage = value; }
        }

        // Check to see if ProgressPercentage property is set
        internal bool IsSetProgressPercentage()
        {
            return this._progressPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property TimeElapsedSeconds. 
        /// <para>
        /// The time elapsed, in seconds, since the start time of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TimeElapsedSeconds
        {
            get { return this._timeElapsedSeconds; }
            set { this._timeElapsedSeconds = value; }
        }

        // Check to see if TimeElapsedSeconds property is set
        internal bool IsSetTimeElapsedSeconds()
        {
            return this._timeElapsedSeconds.HasValue; 
        }

    }
}