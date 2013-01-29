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
    /// Container for the parameters to the PollForDecisionTask operation.
    /// <para> Used by deciders to get a DecisionTask from the specified decision <c>taskList</c> .
    /// A decision task may be returned for any open workflow execution that is using the specified task list. The task includes a paginated
    /// view of the history of the workflow execution. The decider should use the workflow type and the history to determine how to properly handle
    /// the task. </para> <para> This action initiates a long poll, where the service holds the HTTP connection open and responds as soon a task
    /// becomes available. If no decision task is available in the specified task list before the timeout of 60 seconds expires, an empty result is
    /// returned. An empty result, in this context, means that a DecisionTask is returned, but that the value of taskToken is an empty string.
    /// </para> <para><b>IMPORTANT:</b> Deciders should set their client side socket timeout to at least 70 seconds (10 seconds higher than the
    /// timeout). </para> <para><b>IMPORTANT:</b> Because the number of workflow history events for a single workflow execution might be very large,
    /// the result returned might be split up across a number of pages. To retrieve subsequent pages, make additional calls to PollForDecisionTask
    /// using the nextPageToken returned by the initial call. Note that you do not call GetWorkflowExecutionHistory with this nextPageToken.
    /// Instead, call PollForDecisionTask again. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this
    /// action's access to Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>Use a <b>Condition</b> element with the <c>swf:taskList.name</c> key to allow the action to access only certain task lists.</li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see Using IAM to Manage
    /// Access to Amazon SWF Workflows.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleWorkflow.AmazonSimpleWorkflow.PollForDecisionTask"/>
    public class PollForDecisionTaskRequest : AmazonWebServiceRequest
    {
        private string domain;
        private TaskList taskList;
        private string identity;
        private string nextPageToken;
        private int? maximumPageSize;
        private bool? reverseOrder;

        /// <summary>
        /// The name of the domain containing the task lists to poll.
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

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">The value to set for the Domain property </param>
        /// <returns>this instance</returns>
        public PollForDecisionTaskRequest WithDomain(string domain)
        {
            this.domain = domain;
            return this;
        }
            

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// Specifies the task list to poll for decision tasks. The specified string must not start or end with whitespace. It must not contain a
        /// <c>:</c> (colon), <c>/</c> (slash), <c>|</c> (vertical bar), or any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not
        /// contain the literal string "arn".
        ///  
        /// </summary>
        public TaskList TaskList
        {
            get { return this.taskList; }
            set { this.taskList = value; }
        }

        /// <summary>
        /// Sets the TaskList property
        /// </summary>
        /// <param name="taskList">The value to set for the TaskList property </param>
        /// <returns>this instance</returns>
        public PollForDecisionTaskRequest WithTaskList(TaskList taskList)
        {
            this.taskList = taskList;
            return this;
        }
            

        // Check to see if TaskList property is set
        internal bool IsSetTaskList()
        {
            return this.taskList != null;
        }

        /// <summary>
        /// Identity of the decider making the request, which is recorded in the DecisionTaskStarted event in the workflow history. This enables
        /// diagnostic tracing when problems arise. The form of this identity is user defined.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Identity
        {
            get { return this.identity; }
            set { this.identity = value; }
        }

        /// <summary>
        /// Sets the Identity property
        /// </summary>
        /// <param name="identity">The value to set for the Identity property </param>
        /// <returns>this instance</returns>
        public PollForDecisionTaskRequest WithIdentity(string identity)
        {
            this.identity = identity;
            return this;
        }
            

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this.identity != null;
        }

        /// <summary>
        /// If on a previous call to this method a <c>NextPageToken</c> was returned, the results are being paginated. To get the next page of results,
        /// repeat the call with the returned token and all other arguments unchanged. <note>The <c>nextPageToken</c> returned by this action cannot be
        /// used with <a>GetWorkflowExecutionHistory</a> to get the next page. You must call <a>PollForDecisionTask</a> again (with the
        /// <c>nextPageToken</c>) to retrieve the next page of history records. Calling <a>PollForDecisionTask</a> with a <c>nextPageToken</c> will not
        /// return a new decision task.</note>.
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
        public PollForDecisionTaskRequest WithNextPageToken(string nextPageToken)
        {
            this.nextPageToken = nextPageToken;
            return this;
        }
            

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }

        /// <summary>
        /// The maximum number of history events returned in each page. The default is 100, but the caller can override this value to a page size
        /// <i>smaller</i> than the default. You cannot specify a page size greater than 100. Note that the number of events may be less than the
        /// maxiumum page size, in which case, the returned page will have fewer results than the maximumPageSize specified.
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

        /// <summary>
        /// Sets the MaximumPageSize property
        /// </summary>
        /// <param name="maximumPageSize">The value to set for the MaximumPageSize property </param>
        /// <returns>this instance</returns>
        public PollForDecisionTaskRequest WithMaximumPageSize(int maximumPageSize)
        {
            this.maximumPageSize = maximumPageSize;
            return this;
        }
            

        // Check to see if MaximumPageSize property is set
        internal bool IsSetMaximumPageSize()
        {
            return this.maximumPageSize.HasValue;
        }

        /// <summary>
        /// When set to <c>true</c>, returns the events in reverse order. By default the results are returned in ascending order of the
        /// <c>eventTimestamp</c> of the events.
        ///  
        /// </summary>
        public bool ReverseOrder
        {
            get { return this.reverseOrder ?? default(bool); }
            set { this.reverseOrder = value; }
        }

        /// <summary>
        /// Sets the ReverseOrder property
        /// </summary>
        /// <param name="reverseOrder">The value to set for the ReverseOrder property </param>
        /// <returns>this instance</returns>
        public PollForDecisionTaskRequest WithReverseOrder(bool reverseOrder)
        {
            this.reverseOrder = reverseOrder;
            return this;
        }
            

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this.reverseOrder.HasValue;
        }
    }
}
    
