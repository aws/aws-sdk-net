/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the CancelTaskExecution operation.
    /// Cancels execution of a task. 
    /// 
    ///  
    /// <para>
    /// When you cancel a task execution, the transfer of some files are abruptly interrupted.
    /// The contents of files that are transferred to the destination might be incomplete
    /// or inconsistent with the source files. However, if you start a new task execution
    /// on the same task and you allow the task execution to complete, file content on the
    /// destination is complete and consistent. This applies to other unexpected failures
    /// that interrupt a task execution. In all of these cases, AWS DataSync successfully
    /// complete the transfer when you start the next task execution. 
    /// </para>
    /// </summary>
    public partial class CancelTaskExecutionRequest : AmazonDataSyncRequest
    {
        private string _taskExecutionArn;

        /// <summary>
        /// Gets and sets the property TaskExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task execution to cancel.
        /// </para>
        /// </summary>
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

    }
}