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
    /// Information about when jobs are submitted, started, and finished is specified in Unix
    /// epoch format in seconds.
    /// </summary>
    public partial class Timing
    {
        /// <summary>
        /// Gets and sets the property FinishTime. The time, in Unix epoch format, that the transcoding
        /// job finished
        /// </summary>
        public DateTime? FinishTime { get; set; }

        /// <summary>
        /// Checks to see if the FinishTime property is set.
        /// </summary>
        internal bool IsSetFinishTime() => this.FinishTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. The time, in Unix epoch format, that transcoding
        /// for the job began.
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SubmitTime. The time, in Unix epoch format, that you submitted
        /// the job.
        /// </summary>
        public DateTime? SubmitTime { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTime property is set.
        /// </summary>
        internal bool IsSetSubmitTime() => this.SubmitTime.HasValue;
    }
}
