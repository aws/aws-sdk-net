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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Contains details about the specified export task.
    /// </summary>
    public partial class ExportTaskDetails
    {
        /// <summary>
        /// Gets and sets the property NumEdgesWritten. 
        /// <para>
        /// The number of exported edges.
        /// </para>
        /// </summary>
        public long? NumEdgesWritten { get; set; }

        /// <summary>
        /// Checks to see if the NumEdgesWritten property is set.
        /// </summary>
        internal bool IsSetNumEdgesWritten() => this.NumEdgesWritten.HasValue;

        /// <summary>
        /// Gets and sets the property NumVerticesWritten. 
        /// <para>
        /// The number of exported vertices.
        /// </para>
        /// </summary>
        public long? NumVerticesWritten { get; set; }

        /// <summary>
        /// Checks to see if the NumVerticesWritten property is set.
        /// </summary>
        internal bool IsSetNumVerticesWritten() => this.NumVerticesWritten.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// The number of progress percentage of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProgressPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercentage property is set.
        /// </summary>
        internal bool IsSetProgressPercentage() => this.ProgressPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TimeElapsedSeconds. 
        /// <para>
        /// The time elapsed, in seconds, since the start time of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TimeElapsedSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeElapsedSeconds property is set.
        /// </summary>
        internal bool IsSetTimeElapsedSeconds() => this.TimeElapsedSeconds.HasValue;
    }
}
