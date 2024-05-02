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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
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
namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CancelTask operation.
    /// Sends a cancel request for a specified task. You can cancel a task only if it's still
    /// in a <c>QUEUED</c> state. Tasks that are already running can't be cancelled.
    /// 
    ///  <note> 
    /// <para>
    /// A task might still run if it's processed from the queue before the <c>CancelTask</c>
    /// operation changes the task's state.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CancelTaskRequest : AmazonSnowDeviceManagementRequest
    {
        private string _taskId;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the task that you are attempting to cancel. You can retrieve a task ID by
        /// using the <c>ListTasks</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}