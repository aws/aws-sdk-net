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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time for the window that MediaTailor prefetches and inserts ads in a live
        /// event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property RecurringConsumption. 
        /// <para>
        /// The settings that determine how and when MediaTailor places prefetched ads into upcoming
        /// ad breaks for recurring prefetch scedules.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecurringConsumption RecurringConsumption { get; set; }

        /// <summary>
        /// Checks to see if the RecurringConsumption property is set.
        /// </summary>
        internal bool IsSetRecurringConsumption() => this.RecurringConsumption != null;

        /// <summary>
        /// Gets and sets the property RecurringRetrieval. 
        /// <para>
        /// The configuration for prefetch ad retrieval from the ADS.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecurringRetrieval RecurringRetrieval { get; set; }

        /// <summary>
        /// Checks to see if the RecurringRetrieval property is set.
        /// </summary>
        internal bool IsSetRecurringRetrieval() => this.RecurringRetrieval != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time for the window that MediaTailor prefetches and inserts ads in a live
        /// event. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
