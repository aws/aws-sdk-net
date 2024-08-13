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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the PollForDecisionTask operation.
    /// Used by deciders to get a <a>DecisionTask</a> from the specified decision <c>taskList</c>.
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
    /// retrieve subsequent pages, make additional calls to <c>PollForDecisionTask</c> using
    /// the <c>nextPageToken</c> returned by the initial call. Note that you do <i>not</i>
    /// call <c>GetWorkflowExecutionHistory</c> with this <c>nextPageToken</c>. Instead, call
    /// <c>PollForDecisionTask</c> again.
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
    /// Use a <c>Resource</c> element with the domain name to limit the action to only specified
    /// domains.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <c>Action</c> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Constrain the <c>taskList.name</c> parameter by using a <c>Condition</c> element with
    /// the <c>swf:taskList.name</c> key to allow the action to access only certain task lists.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <c>cause</c> parameter is set to <c>OPERATION_NOT_PERMITTED</c>. For details
    /// and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
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
        private bool? _startAtPreviousStartedEvent;
        private TaskList _taskList;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain containing the task lists to poll.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        [AWSProperty(Max=256)]
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
        /// The maximum number of results that are returned per call. Use <c>nextPageToken</c>
        /// to obtain further pages of results. 
        /// </para>
        ///  
        /// <para>
        /// This is an upper limit only; the actual number of results returned per call may be
        /// fewer than the specified maximum.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? MaximumPageSize
        {
            get { return this._maximumPageSize; }
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
        /// If <c>NextPageToken</c> is returned there are more results available. The value of
        /// <c>NextPageToken</c> is a unique pagination token for each page. Make the call again
        /// using the returned token to retrieve the next page. Keep all other arguments unchanged.
        /// Each pagination token expires after 24 hours. Using an expired pagination token will
        /// return a <c>400</c> error: "<c>Specified token has exceeded its maximum lifetime</c>".
        /// 
        /// </para>
        ///  
        /// <para>
        /// The configured <c>maximumPageSize</c> determines how many results can be returned
        /// in a single call. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>nextPageToken</c> returned by this action cannot be used with <a>GetWorkflowExecutionHistory</a>
        /// to get the next page. You must call <a>PollForDecisionTask</a> again (with the <c>nextPageToken</c>)
        /// to retrieve the next page of history records. Calling <a>PollForDecisionTask</a> with
        /// a <c>nextPageToken</c> doesn't return a new decision task.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// When set to <c>true</c>, returns the events in reverse order. By default the results
        /// are returned in ascending order of the <c>eventTimestamp</c> of the events.
        /// </para>
        /// </summary>
        public bool? ReverseOrder
        {
            get { return this._reverseOrder; }
            set { this._reverseOrder = value; }
        }

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this._reverseOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartAtPreviousStartedEvent. 
        /// <para>
        /// When set to <c>true</c>, returns the events with <c>eventTimestamp</c> greater than
        /// or equal to <c>eventTimestamp</c> of the most recent <c>DecisionTaskStarted</c> event.
        /// By default, this parameter is set to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? StartAtPreviousStartedEvent
        {
            get { return this._startAtPreviousStartedEvent; }
            set { this._startAtPreviousStartedEvent = value; }
        }

        // Check to see if StartAtPreviousStartedEvent property is set
        internal bool IsSetStartAtPreviousStartedEvent()
        {
            return this._startAtPreviousStartedEvent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskList. 
        /// <para>
        /// Specifies the task list to poll for decision tasks.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not contain a <c>:</c> (colon), <c>/</c> (slash), <c>|</c>
        /// (vertical bar), or any control characters (<c>\u0000-\u001f</c> | <c>\u007f-\u009f</c>).
        /// Also, it must <i>not</i> be the literal string <c>arn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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