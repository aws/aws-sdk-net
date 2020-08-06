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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// This is the response object from the DescribeFlowExecutionRecords operation.
    /// </summary>
    public partial class DescribeFlowExecutionRecordsResponse : AmazonWebServiceResponse
    {
        private List<ExecutionRecord> _flowExecutions = new List<ExecutionRecord>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FlowExecutions. 
        /// <para>
        ///  Returns a list of all instances when this flow was run. 
        /// </para>
        /// </summary>
        public List<ExecutionRecord> FlowExecutions
        {
            get { return this._flowExecutions; }
            set { this._flowExecutions = value; }
        }

        // Check to see if FlowExecutions property is set
        internal bool IsSetFlowExecutions()
        {
            return this._flowExecutions != null && this._flowExecutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token for the next page of data. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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

    }
}