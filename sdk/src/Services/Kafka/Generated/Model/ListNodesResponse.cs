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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the ListNodes operation.
    /// </summary>
    public partial class ListNodesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<NodeInfo> _nodeInfoList = AWSConfigs.InitializeCollections ? new List<NodeInfo>() : null;

        /// <summary>
        /// Gets and sets the property NextToken.             
        /// <para>
        /// The paginated results marker. When the result of a ListNodes operation is truncated,
        /// the call returns NextToken in the response.                To get another batch of
        /// nodes, provide this token in your next request.
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
        /// Gets and sets the property NodeInfoList.             
        /// <para>
        /// List containing a NodeInfo object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeInfo> NodeInfoList
        {
            get { return this._nodeInfoList; }
            set { this._nodeInfoList = value; }
        }

        // Check to see if NodeInfoList property is set
        internal bool IsSetNodeInfoList()
        {
            return this._nodeInfoList != null && (this._nodeInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}