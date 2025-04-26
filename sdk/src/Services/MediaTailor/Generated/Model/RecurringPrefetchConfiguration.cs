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
    /// The configuration that defines how MediaTailor performs recurring prefetch.
    /// </summary>
    public partial class RecurringPrefetchConfiguration
    {
        private DateTime? _endTime;
        private RecurringConsumption _recurringConsumption;
        private RecurringRetrieval _recurringRetrieval;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time for the window that MediaTailor prefetches and inserts ads in a live
        /// event. 
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
        /// Gets and sets the property RecurringConsumption. 
        /// <para>
        /// The settings that determine how and when MediaTailor places prefetched ads into upcoming
        /// ad breaks for recurring prefetch scedules.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecurringConsumption RecurringConsumption
        {
            get { return this._recurringConsumption; }
            set { this._recurringConsumption = value; }
        }

        // Check to see if RecurringConsumption property is set
        internal bool IsSetRecurringConsumption()
        {
            return this._recurringConsumption != null;
        }

        /// <summary>
        /// Gets and sets the property RecurringRetrieval. 
        /// <para>
        /// The configuration for prefetch ad retrieval from the ADS.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecurringRetrieval RecurringRetrieval
        {
            get { return this._recurringRetrieval; }
            set { this._recurringRetrieval = value; }
        }

        // Check to see if RecurringRetrieval property is set
        internal bool IsSetRecurringRetrieval()
        {
            return this._recurringRetrieval != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time for the window that MediaTailor prefetches and inserts ads in a live
        /// event. 
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