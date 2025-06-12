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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the ListSimulationJobs operation.
    /// </summary>
    public partial class ListSimulationJobsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SimulationJobSummary> _simulationJobSummaries = AWSConfigs.InitializeCollections ? new List<SimulationJobSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous paginated request did not return all of the remaining results, the
        /// response object's <c>nextToken</c> parameter value is set to a token. To retrieve
        /// the next set of results, call <c>ListSimulationJobs</c> again and assign that token
        /// to the request object's <c>nextToken</c> parameter. If there are no remaining results,
        /// the previous response object's NextToken parameter is set to null. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property SimulationJobSummaries. 
        /// <para>
        /// A list of simulation job summaries that meet the criteria of the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<SimulationJobSummary> SimulationJobSummaries
        {
            get { return this._simulationJobSummaries; }
            set { this._simulationJobSummaries = value; }
        }

        // Check to see if SimulationJobSummaries property is set
        internal bool IsSetSimulationJobSummaries()
        {
            return this._simulationJobSummaries != null && (this._simulationJobSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}