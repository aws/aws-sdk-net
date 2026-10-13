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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Data about the stored events.
    /// </summary>
    public partial class IngestedEventStatistics
    {
        /// <summary>
        /// Gets and sets the property EventDataSizeInBytes. 
        /// <para>
        /// The total size of the stored events.
        /// </para>
        /// </summary>
        public long? EventDataSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the EventDataSizeInBytes property is set.
        /// </summary>
        internal bool IsSetEventDataSizeInBytes() => this.EventDataSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Timestamp of when the stored event was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property LeastRecentEvent. 
        /// <para>
        /// The oldest stored event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string LeastRecentEvent { get; set; }

        /// <summary>
        /// Checks to see if the LeastRecentEvent property is set.
        /// </summary>
        internal bool IsSetLeastRecentEvent() => this.LeastRecentEvent != null;

        /// <summary>
        /// Gets and sets the property MostRecentEvent. 
        /// <para>
        /// The newest stored event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string MostRecentEvent { get; set; }

        /// <summary>
        /// Checks to see if the MostRecentEvent property is set.
        /// </summary>
        internal bool IsSetMostRecentEvent() => this.MostRecentEvent != null;

        /// <summary>
        /// Gets and sets the property NumberOfEvents. 
        /// <para>
        /// The number of stored events.
        /// </para>
        /// </summary>
        public long? NumberOfEvents { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfEvents property is set.
        /// </summary>
        internal bool IsSetNumberOfEvents() => this.NumberOfEvents.HasValue;
    }
}
