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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Braket.Model
{
    /// <summary>
    /// This is the response object from the SearchQuantumTasks operation.
    /// </summary>
    public partial class SearchQuantumTasksResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<QuantumTaskSummary> _quantumTasks = new List<QuantumTaskSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used for pagination of results, or null if there are no additional results.
        /// Use the token value in a subsequent request to continue results where the previous
        /// request ended.
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
        /// Gets and sets the property QuantumTasks. 
        /// <para>
        /// An array of <code>QuantumTaskSummary</code> objects for tasks that match the specified
        /// filters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<QuantumTaskSummary> QuantumTasks
        {
            get { return this._quantumTasks; }
            set { this._quantumTasks = value; }
        }

        // Check to see if QuantumTasks property is set
        internal bool IsSetQuantumTasks()
        {
            return this._quantumTasks != null && this._quantumTasks.Count > 0; 
        }

    }
}