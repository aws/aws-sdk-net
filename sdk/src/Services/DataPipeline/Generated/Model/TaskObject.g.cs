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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains information about a pipeline task that is assigned to a task runner.
    /// </summary>
    public partial class TaskObject
    {
        /// <summary>
        /// Gets and sets the property AttemptId. 
        /// <para>
        /// The ID of the pipeline task attempt object. AWS Data Pipeline uses this value to track
        /// how many times a task is attempted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AttemptId { get; set; }

        /// <summary>
        /// Checks to see if the AttemptId property is set.
        /// </summary>
        internal bool IsSetAttemptId() => this.AttemptId != null;

        /// <summary>
        /// Gets and sets the property Objects. 
        /// <para>
        /// Connection information for the location where the task runner will publish the output
        /// of the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PipelineObject> Objects { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, PipelineObject>() : null;

        /// <summary>
        /// Checks to see if the Objects property is set.
        /// </summary>
        internal bool IsSetObjects() => this.Objects != null && (this.Objects.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The ID of the pipeline that provided the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PipelineId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineId property is set.
        /// </summary>
        internal bool IsSetPipelineId() => this.PipelineId != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// An internal identifier for the task. This ID is passed to the <a>SetTaskStatus</a>
        /// and <a>ReportTaskProgress</a> actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;
    }
}
