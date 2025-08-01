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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the ListMemoryRecords operation.
    /// Lists memory records in a memory store based on specified criteria. We recommend using
    /// pagination to ensure that the operation returns quickly and successfully.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the <c>genesismemory:ListMemoryRecords</c> permission.
    /// </para>
    /// </summary>
    public partial class ListMemoryRecordsRequest : AmazonBedrockAgentCoreRequest
    {
        private int? _maxResults;
        private string _memoryId;
        private string _memoryStrategyId;
        private string _awsNamespace;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Minimum value of 1, maximum
        /// value of 100. Default is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the memory store for which to list memory records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12)]
        public string MemoryId
        {
            get { return this._memoryId; }
            set { this._memoryId = value; }
        }

        // Check to see if MemoryId property is set
        internal bool IsSetMemoryId()
        {
            return this._memoryId != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryStrategyId. 
        /// <para>
        /// The memory strategy identifier to filter memory records by. If specified, only memory
        /// records with this strategy ID are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string MemoryStrategyId
        {
            get { return this._memoryStrategyId; }
            set { this._memoryStrategyId = value; }
        }

        // Check to see if MemoryStrategyId property is set
        internal bool IsSetMemoryStrategyId()
        {
            return this._memoryStrategyId != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace to filter memory records by. If specified, only memory records in this
        /// namespace are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
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