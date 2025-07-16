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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the ListWorkloadIdentities operation.
    /// </summary>
    public partial class ListWorkloadIdentitiesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WorkloadIdentityType> _workloadIdentities = AWSConfigs.InitializeCollections ? new List<WorkloadIdentityType>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token for the next page of results.
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
        /// Gets and sets the property WorkloadIdentities. 
        /// <para>
        /// The list of workload identities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WorkloadIdentityType> WorkloadIdentities
        {
            get { return this._workloadIdentities; }
            set { this._workloadIdentities = value; }
        }

        // Check to see if WorkloadIdentities property is set
        internal bool IsSetWorkloadIdentities()
        {
            return this._workloadIdentities != null && (this._workloadIdentities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}