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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
        private long? _eventDataSizeInBytes;
        private string _lastUpdatedTime;
        private string _leastRecentEvent;
        private string _mostRecentEvent;
        private long? _numberOfEvents;

        /// <summary>
        /// Gets and sets the property EventDataSizeInBytes. 
        /// <para>
        /// The total size of the stored events.
        /// </para>
        /// </summary>
        public long? EventDataSizeInBytes
        {
            get { return this._eventDataSizeInBytes; }
            set { this._eventDataSizeInBytes = value; }
        }

        // Check to see if EventDataSizeInBytes property is set
        internal bool IsSetEventDataSizeInBytes()
        {
            return this._eventDataSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Timestamp of when the stored event was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property LeastRecentEvent. 
        /// <para>
        /// The oldest stored event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string LeastRecentEvent
        {
            get { return this._leastRecentEvent; }
            set { this._leastRecentEvent = value; }
        }

        // Check to see if LeastRecentEvent property is set
        internal bool IsSetLeastRecentEvent()
        {
            return this._leastRecentEvent != null;
        }

        /// <summary>
        /// Gets and sets the property MostRecentEvent. 
        /// <para>
        /// The newest stored event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string MostRecentEvent
        {
            get { return this._mostRecentEvent; }
            set { this._mostRecentEvent = value; }
        }

        // Check to see if MostRecentEvent property is set
        internal bool IsSetMostRecentEvent()
        {
            return this._mostRecentEvent != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfEvents. 
        /// <para>
        /// The number of stored events.
        /// </para>
        /// </summary>
        public long? NumberOfEvents
        {
            get { return this._numberOfEvents; }
            set { this._numberOfEvents = value; }
        }

        // Check to see if NumberOfEvents property is set
        internal bool IsSetNumberOfEvents()
        {
            return this._numberOfEvents.HasValue; 
        }

    }
}