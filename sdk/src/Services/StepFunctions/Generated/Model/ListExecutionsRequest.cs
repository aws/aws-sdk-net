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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the ListExecutions operation.
    /// Lists all executions of a state machine or a Map Run. You can list all executions
    /// related to a state machine by specifying a state machine Amazon Resource Name (ARN),
    /// or those related to a Map Run by specifying a Map Run ARN.
    /// 
    ///  
    /// <para>
    /// Results are sorted by time, with the most recent execution first.
    /// </para>
    ///  
    /// <para>
    /// If <code>nextToken</code> is returned, there are more results available. The value
    /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
    /// again using the returned token to retrieve the next page. Keep all other arguments
    /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
    /// token will return an <i>HTTP 400 InvalidToken</i> error.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is eventually consistent. The results are best effort and may not reflect
    /// very recent updates and changes.
    /// </para>
    ///  </note> 
    /// <para>
    /// This API action is not supported by <code>EXPRESS</code> state machines.
    /// </para>
    /// </summary>
    public partial class ListExecutionsRequest : AmazonStepFunctionsRequest
    {
        private string _mapRunArn;
        private int? _maxResults;
        private string _nextToken;
        private string _stateMachineArn;
        private ExecutionStatus _statusFilter;

        /// <summary>
        /// Gets and sets the property MapRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Map Run that started the child workflow executions.
        /// If the <code>mapRunArn</code> field is specified, a list of all of the child workflow
        /// executions started by a Map Run is returned. For more information, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-examine-map-run.html">Examining
        /// Map Run</a> in the <i>Step Functions Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify either a <code>mapRunArn</code> or a <code>stateMachineArn</code>,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string MapRunArn
        {
            get { return this._mapRunArn; }
            set { this._mapRunArn = value; }
        }

        // Check to see if MapRunArn property is set
        internal bool IsSetMapRunArn()
        {
            return this._mapRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned per call. You can use <code>nextToken</code>
        /// to obtain further pages of results. The default is 100 and the maximum allowed page
        /// size is 1000. A value of 0 uses the default.
        /// </para>
        ///  
        /// <para>
        /// This is only an upper limit. The actual number of results returned per call might
        /// be fewer than the specified maximum.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine whose executions is listed.
        /// </para>
        ///  
        /// <para>
        /// You can specify either a <code>mapRunArn</code> or a <code>stateMachineArn</code>,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StateMachineArn
        {
            get { return this._stateMachineArn; }
            set { this._stateMachineArn = value; }
        }

        // Check to see if StateMachineArn property is set
        internal bool IsSetStateMachineArn()
        {
            return this._stateMachineArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// If specified, only list the executions whose current execution status matches the
        /// given filter.
        /// </para>
        /// </summary>
        public ExecutionStatus StatusFilter
        {
            get { return this._statusFilter; }
            set { this._statusFilter = value; }
        }

        // Check to see if StatusFilter property is set
        internal bool IsSetStatusFilter()
        {
            return this._statusFilter != null;
        }

    }
}