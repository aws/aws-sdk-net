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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
    /// Used by deciders to get a <a>DecisionTask</a> from the specified decision <code>taskList</code>.
    /// A decision task may be returned for any open workflow execution that is using the
    /// specified task list. The task includes a paginated view of the history of the workflow
    /// execution. The decider should use the workflow type and the history to determine how
    /// to properly handle the task.
    /// 
    ///  
    /// <para>
    /// This action initiates a long poll, where the service holds the HTTP connection open
    /// and responds as soon a task becomes available. If no decision task is available in
    /// the specified task list before the timeout of 60 seconds expires, an empty result
    /// is returned. An empty result, in this context, means that a DecisionTask is returned,
    /// but that the value of taskToken is an empty string.
    /// </para>
    ///  <important> 
    /// <para>
    /// Deciders should set their client side socket timeout to at least 70 seconds (10 seconds
    /// higher than the timeout).
    /// </para>
    ///  </important> <important> 
    /// <para>
    /// Because the number of workflow history events for a single workflow execution might
    /// be very large, the result returned might be split up across a number of pages. To
    /// retrieve subsequent pages, make additional calls to <code>PollForDecisionTask</code>
    /// using the <code>nextPageToken</code> returned by the initial call. Note that you do
    /// <i>not</i> call <code>GetWorkflowExecutionHistory</code> with this <code>nextPageToken</code>.
    /// Instead, call <code>PollForDecisionTask</code> again.
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Access Control</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a <code>Resource</code> element with the domain name to limit the action to only
    /// specified domains.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <code>Action</code> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Constrain the <code>taskList.name</code> parameter by using a <code>Condition</code>
    /// element with the <code>swf:taskList.name</code> key to allow the action to access
    /// only certain task lists.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
    /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PollForDecisionTaskRequest : AmazonSimpleWorkflowRequest
    {
        private string _domain;
        private string _identity;
        private int? _maximumPageSize;
        private string _nextPageToken;
        private bool? _reverseOrder;
        private TaskList _taskList;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain containing the task lists to poll.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// Identity of the decider making the request, which is recorded in the DecisionTaskStarted
        /// event in the workflow history. This enables diagnostic tracing when problems arise.
        /// The form of this identity is user defined.
        /// </para>
        /// </summary>
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPageSize. 
        /// <para>
        /// The maximum number of results that are returned per call. <code>nextPageToken</code>
        /// can be used to obtain futher pages of results. The default is 1000, which is the maximum
        /// allowed page size. You can, however, specify a page size <i>smaller</i> than the maximum.
        /// </para>
        ///  
        /// <para>
        /// This is an upper limit only; the actual number of results returned per call may be
        /// fewer than the specified maximum.
        /// </para>
        /// </summary>
        public int MaximumPageSize
        {
            get { return this._maximumPageSize.GetValueOrDefault(); }
            set { this._maximumPageSize = value; }
        }

        // Check to see if MaximumPageSize property is set
        internal bool IsSetMaximumPageSize()
        {
            return this._maximumPageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// If a <code>NextPageToken</code> was returned by a previous call, there are more results
        /// available. To retrieve the next page of results, make the call again using the returned
        /// token in <code>nextPageToken</code>. Keep all other arguments unchanged.
        /// </para>
        ///  
        /// <para>
        /// The configured <code>maximumPageSize</code> determines how many results can be returned
        /// in a single call.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>nextPageToken</code> returned by this action cannot be used with <a>GetWorkflowExecutionHistory</a>
        /// to get the next page. You must call <a>PollForDecisionTask</a> again (with the <code>nextPageToken</code>)
        /// to retrieve the next page of history records. Calling <a>PollForDecisionTask</a> with
        /// a <code>nextPageToken</code> doesn't return a new decision task.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReverseOrder. 
        /// <para>
        /// When set to <code>true</code>, returns the events in reverse order. By default the
        /// results are returned in ascending order of the <code>eventTimestamp</code> of the
        /// events.
        /// </para>
        /// </summary>
        public bool ReverseOrder
        {
            get { return this._reverseOrder.GetValueOrDefault(); }
            set { this._reverseOrder = value; }
        }

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this._reverseOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// Specifies the task list to poll for decision tasks.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (<code>\u0000-\u001f</code> | <code>\u007f-\u009f</code>).
        /// Also, it must not contain the literal string <code>arn</code>.
        /// </para>
        /// </summary>
        public TaskList TaskList
        {
            get { return this._taskList; }
            set { this._taskList = value; }
        }

        // Check to see if TaskList property is set
        internal bool IsSetTaskList()
        {
            return this._taskList != null;
        }

    }
}