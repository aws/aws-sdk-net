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
    /// This is the response object from the CancelDataRepositoryTask operation.
    /// </summary>
    public partial class CancelDataRepositoryTaskResponse : AmazonWebServiceResponse
    {
        private DataRepositoryTaskLifecycle _lifecycle;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the data repository task, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - Amazon FSx has not started the task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXECUTING</c> - Amazon FSx is processing the task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - Amazon FSx was not able to complete the task. For example, there
        /// may be files the task failed to process. The <a>DataRepositoryTaskFailureDetails</a>
        /// property provides more information about task failures.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> - FSx completed the task successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c> - Amazon FSx canceled the task and it did not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELING</c> - FSx is in process of canceling the task.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataRepositoryTaskLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the task being canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=128)]
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