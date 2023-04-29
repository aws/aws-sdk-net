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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Gets the details of a network operation.
    /// 
    ///  
    /// <para>
    /// A network operation is any operation that is done to your network, such as network
    /// instance instantiation or termination.
    /// </para>
    /// </summary>
    public partial class GetSolNetworkOperationTaskDetails
    {
        private Dictionary<string, string> _taskContext = new Dictionary<string, string>();
        private DateTime? _taskEndTime;
        private ErrorInfo _taskErrorDetails;
        private string _taskName;
        private DateTime? _taskStartTime;
        private TaskStatus _taskStatus;

        /// <summary>
        /// Gets and sets the property TaskContext. 
        /// <para>
        /// Context for the network operation task.
        /// </para>
        /// </summary>
        public Dictionary<string, string> TaskContext
        {
            get { return this._taskContext; }
            set { this._taskContext = value; }
        }

        // Check to see if TaskContext property is set
        internal bool IsSetTaskContext()
        {
            return this._taskContext != null && this._taskContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskEndTime. 
        /// <para>
        /// Task end time.
        /// </para>
        /// </summary>
        public DateTime TaskEndTime
        {
            get { return this._taskEndTime.GetValueOrDefault(); }
            set { this._taskEndTime = value; }
        }

        // Check to see if TaskEndTime property is set
        internal bool IsSetTaskEndTime()
        {
            return this._taskEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskErrorDetails. 
        /// <para>
        /// Task error details.
        /// </para>
        /// </summary>
        public ErrorInfo TaskErrorDetails
        {
            get { return this._taskErrorDetails; }
            set { this._taskErrorDetails = value; }
        }

        // Check to see if TaskErrorDetails property is set
        internal bool IsSetTaskErrorDetails()
        {
            return this._taskErrorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// Task name.
        /// </para>
        /// </summary>
        public string TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }

        // Check to see if TaskName property is set
        internal bool IsSetTaskName()
        {
            return this._taskName != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        /// Task start time.
        /// </para>
        /// </summary>
        public DateTime TaskStartTime
        {
            get { return this._taskStartTime.GetValueOrDefault(); }
            set { this._taskStartTime = value; }
        }

        // Check to see if TaskStartTime property is set
        internal bool IsSetTaskStartTime()
        {
            return this._taskStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// Task status.
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

    }
}