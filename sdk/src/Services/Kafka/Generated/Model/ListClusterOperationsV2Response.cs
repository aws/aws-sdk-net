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
    /// This is the response object from the ListClusterOperationsV2 operation.
    /// </summary>
    public partial class ListClusterOperationsV2Response : AmazonWebServiceResponse
    {
        private List<ClusterOperationV2Summary> _clusterOperationInfoList = AWSConfigs.InitializeCollections ? new List<ClusterOperationV2Summary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ClusterOperationInfoList.             
        /// <para>
        /// An array of cluster operation information objects.
        /// </para>
        /// </summary>
        public List<ClusterOperationV2Summary> ClusterOperationInfoList
        {
            get { return this._clusterOperationInfoList; }
            set { this._clusterOperationInfoList = value; }
        }

        // Check to see if ClusterOperationInfoList property is set
        internal bool IsSetClusterOperationInfoList()
        {
            return this._clusterOperationInfoList != null && (this._clusterOperationInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken.             
        /// <para>
        /// If the response of ListClusterOperationsV2 is truncated, it returns a NextToken in
        /// the response. This NextToken should be sent in the subsequent request to ListClusterOperationsV2.
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