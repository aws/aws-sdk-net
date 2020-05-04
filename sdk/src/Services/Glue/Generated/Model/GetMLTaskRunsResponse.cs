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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetMLTaskRuns operation.
    /// </summary>
    public partial class GetMLTaskRunsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TaskRun> _taskRuns = new List<TaskRun>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token, if more results are available.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TaskRuns. 
        /// <para>
        /// A list of task runs that are associated with the transform.
        /// </para>
        /// </summary>
        public List<TaskRun> TaskRuns
        {
            get { return this._taskRuns; }
            set { this._taskRuns = value; }
        }

        // Check to see if TaskRuns property is set
        internal bool IsSetTaskRuns()
        {
            return this._taskRuns != null && this._taskRuns.Count > 0; 
        }

    }
}