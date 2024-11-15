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
    /// Container for the parameters to the DescribeTaskExecution operation.
    /// Provides information about an execution of your DataSync task. You can use this operation
    /// to help monitor the progress of an ongoing data transfer or check the results of the
    /// transfer.
    /// 
    ///  <note> 
    /// <para>
    /// Some <c>DescribeTaskExecution</c> response elements are only relevant to a specific
    /// task mode. For information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html#task-mode-differences">Understanding
    /// task mode differences</a> and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transfer-performance-counters.html">Understanding
    /// data transfer performance counters</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeTaskExecutionRequest : AmazonDataSyncRequest
    {
        private string _taskExecutionArn;

        /// <summary>
        /// Gets and sets the property TaskExecutionArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the task execution that you want information
        /// about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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