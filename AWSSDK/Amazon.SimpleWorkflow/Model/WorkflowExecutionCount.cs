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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Contains the count of workflow executions returned from CountOpenWorkflowExecutions or CountClosedWorkflowExecutions </para>
    /// </summary>
    public class WorkflowExecutionCount
    {
        
        private int? count;
        private bool? truncated;

        /// <summary>
        /// The number of workflow executions.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this.count ?? default(int); }
            set { this.count = value; }
        }

        /// <summary>
        /// Sets the Count property
        /// </summary>
        /// <param name="count">The value to set for the Count property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionCount WithCount(int count)
        {
            this.count = count;
            return this;
        }
            

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this.count.HasValue;
        }

        /// <summary>
        /// If set to true, indicates that the actual count was more than the maximum supported by this API and the count returned is the truncated
        /// value.
        ///  
        /// </summary>
        public bool Truncated
        {
            get { return this.truncated ?? default(bool); }
            set { this.truncated = value; }
        }

        /// <summary>
        /// Sets the Truncated property
        /// </summary>
        /// <param name="truncated">The value to set for the Truncated property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionCount WithTruncated(bool truncated)
        {
            this.truncated = truncated;
            return this;
        }
            

        // Check to see if Truncated property is set
        internal bool IsSetTruncated()
        {
            return this.truncated.HasValue;
        }
    }
}
