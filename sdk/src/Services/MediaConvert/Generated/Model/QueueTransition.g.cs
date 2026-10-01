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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Description of the source and destination queues between which the job has moved,
    /// along with the timestamp of the move
    /// </summary>
    public partial class QueueTransition
    {
        /// <summary>
        /// Gets and sets the property DestinationQueue. The queue that the job was on after the
        /// transition.
        /// </summary>
        public string DestinationQueue { get; set; }

        /// <summary>
        /// Checks to see if the DestinationQueue property is set.
        /// </summary>
        internal bool IsSetDestinationQueue() => this.DestinationQueue != null;

        /// <summary>
        /// Gets and sets the property SourceQueue. The queue that the job was on before the transition.
        /// </summary>
        public string SourceQueue { get; set; }

        /// <summary>
        /// Checks to see if the SourceQueue property is set.
        /// </summary>
        internal bool IsSetSourceQueue() => this.SourceQueue != null;

        /// <summary>
        /// Gets and sets the property Timestamp. The time, in Unix epoch format, that the job
        /// moved from the source queue to the destination queue.
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
