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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// For single prefetch, describes how and when that MediaTailor places prefetched ads
    /// into upcoming ad breaks.
    /// </summary>
    public partial class PrefetchConsumption
    {
        private List<AvailMatchingCriteria> _availMatchingCriteria = AWSConfigs.InitializeCollections ? new List<AvailMatchingCriteria>() : null;
        private DateTime? _endTime;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AvailMatchingCriteria. 
        /// <para>
        /// If you only want MediaTailor to insert prefetched ads into avails (ad breaks) that
        /// match specific dynamic variables, such as <c>scte.event_id</c>, set the avail matching
        /// criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailMatchingCriteria> AvailMatchingCriteria
        {
            get { return this._availMatchingCriteria; }
            set { this._availMatchingCriteria = value; }
        }

        // Check to see if AvailMatchingCriteria property is set
        internal bool IsSetAvailMatchingCriteria()
        {
            return this._availMatchingCriteria != null && (this._availMatchingCriteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when MediaTailor no longer considers the prefetched ads for use in an ad
        /// break. MediaTailor automatically deletes prefetch schedules no less than seven days
        /// after the end time. If you'd like to manually delete the prefetch schedule, you can
        /// call <c>DeletePrefetchSchedule</c>.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when prefetched ads are considered for use in an ad break. If you don't specify
        /// <c>StartTime</c>, the prefetched ads are available after MediaTailor retrieves them
        /// from the ad decision server.
        /// </para>
        /// </summary>
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

    }
}