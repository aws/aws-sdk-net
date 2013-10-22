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
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the GetWorkflowExecutionHistory operation.
    /// <para> Returns the history of the specified workflow execution. The results may be split into multiple pages. To retrieve subsequent pages,
    /// make the call again using the <c>nextPageToken</c> returned by the initial call. </para> <para><b>NOTE:</b> This operation is eventually
    /// consistent. The results are best effort and may not exactly reflect recent updates and changes. </para> <para> <b>Access Control</b> </para>
    /// <para>You can use IAM policies to control this action's access to Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
    /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
    /// .</para>
    /// </summary>
    public partial class GetWorkflowExecutionHistoryRequest : AmazonWebServiceRequest
    {
        private string domain;
        private WorkflowExecution execution;
        private string nextPageToken;
        private int? maximumPageSize;
        private bool? reverseOrder;

        /// <summary>
        /// The name of the domain containing the workflow execution.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// Specifies the workflow execution for which to return the history.
        ///  
        /// </summary>
        public WorkflowExecution Execution
        {
            get { return this.execution; }
            set { this.execution = value; }
        }

        // Check to see if Execution property is set
        internal bool IsSetExecution()
        {
            return this.execution != null;
        }

        /// <summary>
        /// If a <c>NextPageToken</c> is returned, the result has more than one pages. To get the next page, repeat the call and specify the
        /// nextPageToken with all other arguments unchanged.
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

        /// <summary>
        /// Specifies the maximum number of history events returned in one page. The next page in the result is identified by the <c>NextPageToken</c>
        /// returned. By default 100 history events are returned in a page but the caller can override this value to a page size <i>smaller</i> than the
        /// default. You cannot specify a page size larger than 100. Note that the number of events may be less than the maxiumum page size, in which
        /// case, the returned page will have fewer results than the maximumPageSize specified.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaximumPageSize
        {
            get { return this.maximumPageSize ?? default(int); }
            set { this.maximumPageSize = value; }
        }

        // Check to see if MaximumPageSize property is set
        internal bool IsSetMaximumPageSize()
        {
            return this.maximumPageSize.HasValue;
        }

        /// <summary>
        /// When set to <c>true</c>, returns the events in reverse order. By default the results are returned in ascending order of the
        /// <c>eventTimeStamp</c> of the events.
        ///  
        /// </summary>
        public bool ReverseOrder
        {
            get { return this.reverseOrder ?? default(bool); }
            set { this.reverseOrder = value; }
        }

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this.reverseOrder.HasValue;
        }

    }
}
    
