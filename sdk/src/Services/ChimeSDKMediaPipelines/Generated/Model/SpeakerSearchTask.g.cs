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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A representation of an asynchronous request to perform speaker search analysis on
    /// a media insights pipeline.
    /// </summary>
    public partial class SpeakerSearchTask
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which a speaker search task was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SpeakerSearchTaskId. 
        /// <para>
        /// The speaker search task ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SpeakerSearchTaskId { get; set; }

        /// <summary>
        /// Checks to see if the SpeakerSearchTaskId property is set.
        /// </summary>
        internal bool IsSetSpeakerSearchTaskId() => this.SpeakerSearchTaskId != null;

        /// <summary>
        /// Gets and sets the property SpeakerSearchTaskStatus. 
        /// <para>
        /// The status of the speaker search task.
        /// </para>
        /// </summary>
        public MediaPipelineTaskStatus SpeakerSearchTaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the SpeakerSearchTaskStatus property is set.
        /// </summary>
        internal bool IsSetSpeakerSearchTaskStatus() => this.SpeakerSearchTaskStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which a speaker search task was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
