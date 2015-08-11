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
    /// Container for the parameters to the ListClosedWorkflowExecutions operation.
    /// Returns a list of closed workflow executions in the specified domain that meet the
    /// filtering criteria. The results may be split into multiple pages. To retrieve subsequent
    /// pages, make the call again using the nextPageToken returned by the initial call.
    /// 
    ///  <note>This operation is eventually consistent. The results are best effort and may
    /// not exactly reflect recent updates and changes.</note> 
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
    /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
    /// deny permission to call this action.</li> <li>Constrain the following parameters by
    /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>tagFilter.tag</code>:
    /// String constraint. The key is <code>swf:tagFilter.tag</code>.</li> <li><code>typeFilter.name</code>:
    /// String constraint. The key is <code>swf:typeFilter.name</code>.</li> <li><code>typeFilter.version</code>:
    /// String constraint. The key is <code>swf:typeFilter.version</code>.</li> </ul> </li>
    /// </ul> 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class ListClosedWorkflowExecutionsRequest : AmazonSimpleWorkflowRequest
    {
        private CloseStatusFilter _closeStatusFilter;
        private ExecutionTimeFilter _closeTimeFilter;
        private string _domain;
        private WorkflowExecutionFilter _executionFilter;
        private int? _maximumPageSize;
        private string _nextPageToken;
        private bool? _reverseOrder;
        private ExecutionTimeFilter _startTimeFilter;
        private TagFilter _tagFilter;
        private WorkflowTypeFilter _typeFilter;

        /// <summary>
        /// Gets and sets the property CloseStatusFilter. 
        /// <para>
        /// If specified, only workflow executions that match this <i>close status</i> are listed.
        /// For example, if TERMINATED is specified, then only TERMINATED workflow executions
        /// are listed.
        /// </para>
        ///  <note><code>closeStatusFilter</code>, <code>executionFilter</code>, <code>typeFilter</code>
        /// and <code>tagFilter</code> are mutually exclusive. You can specify at most one of
        /// these in a request.</note>
        /// </summary>
        public CloseStatusFilter CloseStatusFilter
        {
            get { return this._closeStatusFilter; }
            set { this._closeStatusFilter = value; }
        }

        // Check to see if CloseStatusFilter property is set
        internal bool IsSetCloseStatusFilter()
        {
            return this._closeStatusFilter != null;
        }

        /// <summary>
        /// Gets and sets the property CloseTimeFilter. 
        /// <para>
        /// If specified, the workflow executions are included in the returned results based on
        /// whether their close times are within the range specified by this filter. Also, if
        /// this parameter is specified, the returned results are ordered by their close times.
        /// </para>
        ///  <note><code>startTimeFilter</code> and <code>closeTimeFilter</code> are mutually
        /// exclusive. You must specify one of these in a request but not both.</note>
        /// </summary>
        public ExecutionTimeFilter CloseTimeFilter
        {
            get { return this._closeTimeFilter; }
            set { this._closeTimeFilter = value; }
        }

        // Check to see if CloseTimeFilter property is set
        internal bool IsSetCloseTimeFilter()
        {
            return this._closeTimeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain that contains the workflow executions to list.
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
        /// Gets and sets the property ExecutionFilter. 
        /// <para>
        /// If specified, only workflow executions matching the workflow ID specified in the filter
        /// are returned.
        /// </para>
        ///  <note><code>closeStatusFilter</code>, <code>executionFilter</code>, <code>typeFilter</code>
        /// and <code>tagFilter</code> are mutually exclusive. You can specify at most one of
        /// these in a request.</note>
        /// </summary>
        public WorkflowExecutionFilter ExecutionFilter
        {
            get { return this._executionFilter; }
            set { this._executionFilter = value; }
        }

        // Check to see if ExecutionFilter property is set
        internal bool IsSetExecutionFilter()
        {
            return this._executionFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPageSize. 
        /// <para>
        /// The maximum number of results that will be returned per call. <code>nextPageToken</code>
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
        /// When set to <code>true</code>, returns the results in reverse order. By default the
        /// results are returned in descending order of the start or the close time of the executions.
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
        /// Gets and sets the property StartTimeFilter. 
        /// <para>
        /// If specified, the workflow executions are included in the returned results based on
        /// whether their start times are within the range specified by this filter. Also, if
        /// this parameter is specified, the returned results are ordered by their start times.
        /// </para>
        ///  <note><code>startTimeFilter</code> and <code>closeTimeFilter</code> are mutually
        /// exclusive. You must specify one of these in a request but not both.</note>
        /// </summary>
        public ExecutionTimeFilter StartTimeFilter
        {
            get { return this._startTimeFilter; }
            set { this._startTimeFilter = value; }
        }

        // Check to see if StartTimeFilter property is set
        internal bool IsSetStartTimeFilter()
        {
            return this._startTimeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property TagFilter. 
        /// <para>
        /// If specified, only executions that have the matching tag are listed.
        /// </para>
        ///  <note><code>closeStatusFilter</code>, <code>executionFilter</code>, <code>typeFilter</code>
        /// and <code>tagFilter</code> are mutually exclusive. You can specify at most one of
        /// these in a request.</note>
        /// </summary>
        public TagFilter TagFilter
        {
            get { return this._tagFilter; }
            set { this._tagFilter = value; }
        }

        // Check to see if TagFilter property is set
        internal bool IsSetTagFilter()
        {
            return this._tagFilter != null;
        }

        /// <summary>
        /// Gets and sets the property TypeFilter. 
        /// <para>
        /// If specified, only executions of the type specified in the filter are returned.
        /// </para>
        ///  <note><code>closeStatusFilter</code>, <code>executionFilter</code>, <code>typeFilter</code>
        /// and <code>tagFilter</code> are mutually exclusive. You can specify at most one of
        /// these in a request.</note>
        /// </summary>
        public WorkflowTypeFilter TypeFilter
        {
            get { return this._typeFilter; }
            set { this._typeFilter = value; }
        }

        // Check to see if TypeFilter property is set
        internal bool IsSetTypeFilter()
        {
            return this._typeFilter != null;
        }

    }
}