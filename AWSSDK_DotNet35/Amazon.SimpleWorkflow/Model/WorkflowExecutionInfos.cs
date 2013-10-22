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
using Amazon.Runtime;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Contains a paginated list of information about workflow executions. </para>
    /// </summary>
    public partial class WorkflowExecutionInfos : AmazonWebServiceResponse
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

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }
    }
}
