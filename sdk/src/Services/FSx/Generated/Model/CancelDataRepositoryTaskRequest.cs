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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the CancelDataRepositoryTask operation.
    /// Cancels an existing Amazon FSx for Lustre data repository task if that task is in
    /// either the <c>PENDING</c> or <c>EXECUTING</c> state. When you cancel an export task,
    /// Amazon FSx does the following.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Any files that FSx has already exported are not reverted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// FSx continues to export any files that are in-flight when the cancel operation is
    /// received.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// FSx does not export any files that have not yet been exported.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For a release task, Amazon FSx will stop releasing files upon cancellation. Any files
    /// that have already been released will remain in the released state.
    /// </para>
    /// </summary>
    public partial class CancelDataRepositoryTaskRequest : AmazonFSxRequest
    {
        private string _taskId;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// Specifies the data repository task to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=128)]
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