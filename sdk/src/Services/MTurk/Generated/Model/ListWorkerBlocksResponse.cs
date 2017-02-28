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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// This is the response object from the ListWorkerBlocks operation.
    /// </summary>
    public partial class ListWorkerBlocksResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private int? _numResults;
        private List<WorkerBlock> _workerBlocks = new List<WorkerBlock>();

        /// <summary>
        /// Gets and sets the property NextToken.
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
        /// Gets and sets the property NumResults. 
        /// <para>
        ///  The number of assignments on the page in the filtered results list, equivalent to
        /// the number of assignments returned by this call.
        /// </para>
        /// </summary>
        public int NumResults
        {
            get { return this._numResults.GetValueOrDefault(); }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkerBlocks. 
        /// <para>
        ///  The list of WorkerBlocks, containing the collection of Worker IDs and reasons for
        /// blocking.
        /// </para>
        /// </summary>
        public List<WorkerBlock> WorkerBlocks
        {
            get { return this._workerBlocks; }
            set { this._workerBlocks = value; }
        }

        // Check to see if WorkerBlocks property is set
        internal bool IsSetWorkerBlocks()
        {
            return this._workerBlocks != null && this._workerBlocks.Count > 0; 
        }

    }
}