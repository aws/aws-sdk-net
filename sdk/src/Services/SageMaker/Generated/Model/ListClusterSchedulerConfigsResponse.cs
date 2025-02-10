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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListClusterSchedulerConfigs operation.
    /// </summary>
    public partial class ListClusterSchedulerConfigsResponse : AmazonWebServiceResponse
    {
        private List<ClusterSchedulerConfigSummary> _clusterSchedulerConfigSummaries = AWSConfigs.InitializeCollections ? new List<ClusterSchedulerConfigSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ClusterSchedulerConfigSummaries. 
        /// <para>
        /// Summaries of the cluster policies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ClusterSchedulerConfigSummary> ClusterSchedulerConfigSummaries
        {
            get { return this._clusterSchedulerConfigSummaries; }
            set { this._clusterSchedulerConfigSummaries = value; }
        }

        // Check to see if ClusterSchedulerConfigSummaries property is set
        internal bool IsSetClusterSchedulerConfigSummaries()
        {
            return this._clusterSchedulerConfigSummaries != null && (this._clusterSchedulerConfigSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was truncated, you will receive this token. Use it in your
        /// next request to receive the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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