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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Represents the response structure containing a paginated list of prospecting task
    /// summaries matching the request filters. Indicates through <c>NextToken</c> when additional
    /// results are available.
    /// </summary>
    public partial class ListProspectingFromEngagementTasksResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProspectingTaskSummary> _taskSummaries = AWSConfigs.InitializeCollections ? new List<ProspectingTaskSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token used to retrieve the next page of results. If this field is present,
        /// pass its value as <c>NextToken</c> in the next call. If absent or empty, there are
        /// no further pages.
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
        /// Gets and sets the property TaskSummaries. 
        /// <para>
        /// Prospecting task summaries matching the specified filters. Each summary includes the
        /// task identifier, name, status counters, and timing information. If no tasks match
        /// the filter criteria, the list is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ProspectingTaskSummary> TaskSummaries
        {
            get { return this._taskSummaries; }
            set { this._taskSummaries = value; }
        }

        // Check to see if TaskSummaries property is set
        internal bool IsSetTaskSummaries()
        {
            return this._taskSummaries != null && (this._taskSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}