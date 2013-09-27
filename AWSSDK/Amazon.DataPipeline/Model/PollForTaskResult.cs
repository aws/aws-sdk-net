/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains the output from the PollForTask action.</para>
    /// </summary>
    public class PollForTaskResult
    {
        
        private TaskObject taskObject;

        /// <summary>
        /// An instance of <a>PollForTaskResult</a>, which contains an instance of <a>TaskObject</a>. The returned object contains all the information
        /// needed to complete the task that is being assigned to the task runner. One of the fields returned in this object is taskId, which contains
        /// an identifier for the task being assigned. The calling task runner uses taskId in subsequent calls to <a>ReportTaskProgress</a> and
        /// <a>SetTaskStatus</a>.
        ///  
        /// </summary>
        public TaskObject TaskObject
        {
            get { return this.taskObject; }
            set { this.taskObject = value; }
        }

        /// <summary>
        /// Sets the TaskObject property
        /// </summary>
        /// <param name="taskObject">The value to set for the TaskObject property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PollForTaskResult WithTaskObject(TaskObject taskObject)
        {
            this.taskObject = taskObject;
            return this;
        }
            

        // Check to see if TaskObject property is set
        internal bool IsSetTaskObject()
        {
            return this.taskObject != null;
        }
    }
}
