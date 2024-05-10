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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// This is the response object from the ListBatchLoadTasks operation.
    /// </summary>
    public partial class ListBatchLoadTasksResponse : AmazonWebServiceResponse
    {
        private List<BatchLoadTask> _batchLoadTasks = AWSConfigs.InitializeCollections ? new List<BatchLoadTask>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BatchLoadTasks. 
        /// <para>
        /// A list of batch load task details.
        /// </para>
        /// </summary>
        public List<BatchLoadTask> BatchLoadTasks
        {
            get { return this._batchLoadTasks; }
            set { this._batchLoadTasks = value; }
        }

        // Check to see if BatchLoadTasks property is set
        internal bool IsSetBatchLoadTasks()
        {
            return this._batchLoadTasks != null && (this._batchLoadTasks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. Provide the next ListBatchLoadTasksRequest.
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

    }
}