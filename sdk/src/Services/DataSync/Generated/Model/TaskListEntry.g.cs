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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Represents a single entry in a list of tasks. <c>TaskListEntry</c> returns an array
    /// that contains a list of tasks when the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_ListTasks.html">ListTasks</a>
    /// operation is called. A task includes the source and destination file systems to sync
    /// and the options to use for the tasks.
    /// </summary>
    public partial class TaskListEntry
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task.
        /// </para>
        /// </summary>
        public TaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;

        /// <summary>
        /// Gets and sets the property TaskMode. 
        /// <para>
        /// The task mode that you're using. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Choosing
        /// a task mode for your data transfer</a>.
        /// </para>
        /// </summary>
        public TaskMode TaskMode { get; set; }

        /// <summary>
        /// Checks to see if the TaskMode property is set.
        /// </summary>
        internal bool IsSetTaskMode() => this.TaskMode != null;
    }
}
