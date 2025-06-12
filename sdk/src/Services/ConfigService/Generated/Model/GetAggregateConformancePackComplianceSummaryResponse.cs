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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the GetAggregateConformancePackComplianceSummary operation.
    /// </summary>
    public partial class GetAggregateConformancePackComplianceSummaryResponse : AmazonWebServiceResponse
    {
        private List<AggregateConformancePackComplianceSummary> _aggregateConformancePackComplianceSummaries = AWSConfigs.InitializeCollections ? new List<AggregateConformancePackComplianceSummary>() : null;
        private string _groupByKey;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AggregateConformancePackComplianceSummaries. 
        /// <para>
        /// Returns a list of <c>AggregateConformancePackComplianceSummary</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AggregateConformancePackComplianceSummary> AggregateConformancePackComplianceSummaries
        {
            get { return this._aggregateConformancePackComplianceSummaries; }
            set { this._aggregateConformancePackComplianceSummaries = value; }
        }

        // Check to see if AggregateConformancePackComplianceSummaries property is set
        internal bool IsSetAggregateConformancePackComplianceSummaries()
        {
            return this._aggregateConformancePackComplianceSummaries != null && (this._aggregateConformancePackComplianceSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupByKey. 
        /// <para>
        /// Groups the result based on Amazon Web Services account ID or Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GroupByKey
        {
            get { return this._groupByKey; }
            set { this._groupByKey = value; }
        }

        // Check to see if GroupByKey property is set
        internal bool IsSetGroupByKey()
        {
            return this._groupByKey != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response.
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