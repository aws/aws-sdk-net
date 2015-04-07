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
    /// Contains the output of PollForTask.
    /// </summary>
    public partial class PollForTaskResult : AmazonWebServiceResponse
    {
        private TaskObject _taskObject;

        /// <summary>
        /// Gets and sets the property TaskObject. 
        /// <para>
        /// The information needed to complete the task that is being assigned to the task runner.
        /// One of the fields returned in this object is <code>taskId</code>, which contains an
        /// identifier for the task being assigned. The calling task runner uses <code>taskId</code>
        /// in subsequent calls to <a>ReportTaskProgress</a> and <a>SetTaskStatus</a>.
        /// </para>
        /// </summary>
        public TaskObject TaskObject
        {
            get { return this._taskObject; }
            set { this._taskObject = value; }
        }

        // Check to see if TaskObject property is set
        internal bool IsSetTaskObject()
        {
            return this._taskObject != null;
        }

    }
}