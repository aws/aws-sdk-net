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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// This is the response object from the ListOperations operation.
    /// </summary>
    public partial class ListOperationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<OperationSummary> _operations = AWSConfigs.InitializeCollections ? new List<OperationSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response contains <c>NextToken</c>, submit another <c>ListOperations</c> request
        /// to get the next group of results. Specify the value of <c>NextToken</c> from the previous
        /// response in the next request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cloud Map gets <c>MaxResults</c> operations and then filters them based on the specified
        /// criteria. It's possible that no operations in the first <c>MaxResults</c> operations
        /// matched the specified criteria but that subsequent groups of <c>MaxResults</c> operations
        /// do contain operations that match the criteria.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=4096)]
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
        /// Gets and sets the property Operations. 
        /// <para>
        /// Summary information about the operations that match the specified criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OperationSummary> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && (this._operations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}