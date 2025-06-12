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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the StartSessionsStatisticsAggregation operation.
    /// Starts an asynchronous request for getting aggregated statistics about queues and
    /// farms. Get the statistics using the <c>GetSessionsStatisticsAggregation</c> operation.
    /// You can only have one running aggregation for your Deadline Cloud farm. Call the <c>GetSessionsStatisticsAggregation</c>
    /// operation and check the <c>status</c> field to see if an aggregation is running. Statistics
    /// are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
    /// operation.
    /// </summary>
    public partial class StartSessionsStatisticsAggregationRequest : AmazonDeadlineRequest
    {
        private DateTime? _endTime;
        private string _farmId;
        private List<string> _groupBy = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Period _period;
        private SessionsStatisticsResources _resourceIds;
        private DateTime? _startTime;
        private List<string> _statistics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The Linux timestamp of the date and time that the statistics end.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The identifier of the farm that contains queues or fleets to return statistics for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The field to use to group the statistics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<string> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && (this._groupBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period to aggregate the statistics.
        /// </para>
        /// </summary>
        public Period Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// A list of fleet IDs or queue IDs to gather statistics for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionsStatisticsResources ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The Linux timestamp of the date and time that the statistics start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// One to four statistics to return.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && (this._statistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The timezone to use for the statistics. Use UTC notation such as "UTC+8."
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=9)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}