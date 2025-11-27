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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the ListAutomationEvents operation.
    /// Lists automation events based on specified filters. You can retrieve events that were
    /// created within the past year.
    /// </summary>
    public partial class ListAutomationEventsRequest : AmazonComputeOptimizerAutomationRequest
    {
        private DateTime? _endTimeExclusive;
        private List<AutomationEventFilter> _filters = AWSConfigs.InitializeCollections ? new List<AutomationEventFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTimeInclusive;

        /// <summary>
        /// Gets and sets the property EndTimeExclusive. 
        /// <para>
        ///  The end of the time range to query for events. 
        /// </para>
        /// </summary>
        public DateTime? EndTimeExclusive
        {
            get { return this._endTimeExclusive; }
            set { this._endTimeExclusive = value; }
        }

        // Check to see if EndTimeExclusive property is set
        internal bool IsSetEndTimeExclusive()
        {
            return this._endTimeExclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  The filters to apply to the list of automation events. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutomationEventFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return in a single call. 
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
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next page of results. 
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
        /// Gets and sets the property StartTimeInclusive. 
        /// <para>
        ///  The start of the time range to query for events. 
        /// </para>
        /// </summary>
        public DateTime? StartTimeInclusive
        {
            get { return this._startTimeInclusive; }
            set { this._startTimeInclusive = value; }
        }

        // Check to see if StartTimeInclusive property is set
        internal bool IsSetStartTimeInclusive()
        {
            return this._startTimeInclusive.HasValue; 
        }

    }
}