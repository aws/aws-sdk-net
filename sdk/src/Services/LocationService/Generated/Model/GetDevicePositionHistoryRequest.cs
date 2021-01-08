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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the GetDevicePositionHistory operation.
    /// Retrieves the device position history from a tracker resource within a specified range
    /// of time.
    /// 
    ///  <note> 
    /// <para>
    /// Limitation — Device positions are deleted after one year.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDevicePositionHistoryRequest : AmazonLocationServiceRequest
    {
        private string _deviceId;
        private DateTime? _endTimeExclusive;
        private string _nextToken;
        private DateTime? _startTimeInclusive;
        private string _trackerName;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device whose position history you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimeExclusive. 
        /// <para>
        /// Specify the end time for the position history in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The given time for <code>EndTimeExclusive</code> must be after the time for <code>StartTimeInclusive</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime EndTimeExclusive
        {
            get { return this._endTimeExclusive.GetValueOrDefault(); }
            set { this._endTimeExclusive = value; }
        }

        // Check to see if EndTimeExclusive property is set
        internal bool IsSetEndTimeExclusive()
        {
            return this._endTimeExclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>null</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Specify the start time for the position history in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The given time for <code>EndTimeExclusive</code> must be after the time for <code>StartTimeInclusive</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime StartTimeInclusive
        {
            get { return this._startTimeInclusive.GetValueOrDefault(); }
            set { this._startTimeInclusive = value; }
        }

        // Check to see if StartTimeInclusive property is set
        internal bool IsSetStartTimeInclusive()
        {
            return this._startTimeInclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The tracker resource receiving the request for the device position history.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TrackerName
        {
            get { return this._trackerName; }
            set { this._trackerName = value; }
        }

        // Check to see if TrackerName property is set
        internal bool IsSetTrackerName()
        {
            return this._trackerName != null;
        }

    }
}