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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Output for the ListThreatModelJobs operation.
    /// </summary>
    public partial class ListThreatModelJobsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ThreatModelJobSummary> _threatModelJobSummaries = AWSConfigs.InitializeCollections ? new List<ThreatModelJobSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to use for paginating results that are returned in the response.
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
        /// Gets and sets the property ThreatModelJobSummaries. 
        /// <para>
        /// The list of threat model job summaries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThreatModelJobSummary> ThreatModelJobSummaries
        {
            get { return this._threatModelJobSummaries; }
            set { this._threatModelJobSummaries = value; }
        }

        // Check to see if ThreatModelJobSummaries property is set
        internal bool IsSetThreatModelJobSummaries()
        {
            return this._threatModelJobSummaries != null && (this._threatModelJobSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}