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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the CountOpenWorkflowExecutions operation.
    /// Returns the number of open workflow executions within the given domain that meet the
    /// specified filtering criteria.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is eventually consistent. The results are best effort and may not exactly
    /// reflect recent updates and changes.
    /// </para>
    ///  </note> 
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
    /// Constrain the following parameters by using a <code>Condition</code> element with
    /// the appropriate keys.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
    /// For details and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CountOpenWorkflowExecutionsRequest : AmazonSimpleWorkflowRequest
    {
        private string _domain;
        private WorkflowExecutionFilter _executionFilter;
        private ExecutionTimeFilter _startTimeFilter;
        private TagFilter _tagFilter;
        private WorkflowTypeFilter _typeFilter;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain containing the workflow executions to count.
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
        /// Gets and sets the property ExecutionFilter. 
        /// <para>
        /// If specified, only workflow executions matching the <code>WorkflowId</code> in the
        /// filter are counted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>executionFilter</code>, <code>typeFilter</code> and <code>tagFilter</code>
        /// are mutually exclusive. You can specify at most one of these in a request.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property StartTimeFilter. 
        /// <para>
        /// Specifies the start time criteria that workflow executions must meet in order to be
        /// counted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// If specified, only executions that have a tag that matches the filter are counted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>executionFilter</code>, <code>typeFilter</code> and <code>tagFilter</code>
        /// are mutually exclusive. You can specify at most one of these in a request.
        /// </para>
        ///  </note>
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
        /// Specifies the type of the workflow executions to be counted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>executionFilter</code>, <code>typeFilter</code> and <code>tagFilter</code>
        /// are mutually exclusive. You can specify at most one of these in a request.
        /// </para>
        ///  </note>
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