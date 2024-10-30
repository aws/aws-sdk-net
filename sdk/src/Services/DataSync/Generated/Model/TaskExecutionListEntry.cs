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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
    /// Represents a single entry in a list of DataSync task executions that's returned with
    /// the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_ListTaskExecutions.html">ListTaskExecutions</a>
    /// operation.
    /// </summary>
    public partial class TaskExecutionListEntry
    {
        private TaskExecutionStatus _status;
        private string _taskExecutionArn;
        private TaskMode _taskMode;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a task execution. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/understand-task-statuses.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        /// </summary>
        public TaskExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TaskExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a task execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string TaskExecutionArn
        {
            get { return this._taskExecutionArn; }
            set { this._taskExecutionArn = value; }
        }

        // Check to see if TaskExecutionArn property is set
        internal bool IsSetTaskExecutionArn()
        {
            return this._taskExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskMode. 
        /// <para>
        /// The task mode that you're using. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html">Choosing
        /// a task mode for your data transfer</a>.
        /// </para>
        /// </summary>
        public TaskMode TaskMode
        {
            get { return this._taskMode; }
            set { this._taskMode = value; }
        }

        // Check to see if TaskMode property is set
        internal bool IsSetTaskMode()
        {
            return this._taskMode != null;
        }

    }
}