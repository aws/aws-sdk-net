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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the ReportTaskProgress operation.
    /// Task runners call <code>ReportTaskProgress</code> when assigned a task to acknowledge
    /// that it has the task. If the web service does not receive this acknowledgement within
    /// 2 minutes, it assigns the task in a subsequent <a>PollForTask</a> call. After this
    /// initial acknowledgement, the task runner only needs to report progress every 15 minutes
    /// to maintain its ownership of the task. You can change this reporting time from 15
    /// minutes by specifying a <code>reportProgressTimeout</code> field in your pipeline.
    /// 
    ///  
    /// <para>
    /// If a task runner does not report its status after 5 minutes, AWS Data Pipeline assumes
    /// that the task runner is unable to process the task and reassigns the task in a subsequent
    /// response to <a>PollForTask</a>. Task runners should call <code>ReportTaskProgress</code>
    /// every 60 seconds.
    /// </para>
    /// </summary>
    public partial class ReportTaskProgressRequest : AmazonDataPipelineRequest
    {
        private List<Field> _fields = new List<Field>();
        private string _taskId;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// Key-value pairs that define the properties of the ReportTaskProgressInput object.
        /// </para>
        /// </summary>
        public List<Field> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && this._fields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the task assigned to the task runner. This value is provided in the response
        /// for <a>PollForTask</a>.
        /// </para>
        /// </summary>
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