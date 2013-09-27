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
    /// <para> Contains a paginated list of information about workflow executions. </para>
    /// </summary>
    public class WorkflowExecutionInfos
    {
        
        private List<WorkflowExecutionInfo> executionInfos = new List<WorkflowExecutionInfo>();
        private string nextPageToken;

        /// <summary>
        /// The list of workflow information structures.
        ///  
        /// </summary>
        public List<WorkflowExecutionInfo> ExecutionInfos
        {
            get { return this.executionInfos; }
            set { this.executionInfos = value; }
        }
        /// <summary>
        /// Adds elements to the ExecutionInfos collection
        /// </summary>
        /// <param name="executionInfos">The values to add to the ExecutionInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfos WithExecutionInfos(params WorkflowExecutionInfo[] executionInfos)
        {
            foreach (WorkflowExecutionInfo element in executionInfos)
            {
                this.executionInfos.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ExecutionInfos collection
        /// </summary>
        /// <param name="executionInfos">The values to add to the ExecutionInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfos WithExecutionInfos(IEnumerable<WorkflowExecutionInfo> executionInfos)
        {
            foreach (WorkflowExecutionInfo element in executionInfos)
            {
                this.executionInfos.Add(element);
            }

            return this;
        }

        // Check to see if ExecutionInfos property is set
        internal bool IsSetExecutionInfos()
        {
            return this.executionInfos.Count > 0;
        }

        /// <summary>
        /// The token of the next page in the result. If set, the results have more than one page. The next page can be retrieved by repeating the
        /// request with this token and all other arguments unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        /// <summary>
        /// Sets the NextPageToken property
        /// </summary>
        /// <param name="nextPageToken">The value to set for the NextPageToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfos WithNextPageToken(string nextPageToken)
        {
            this.nextPageToken = nextPageToken;
            return this;
        }
            

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }
    }
}
