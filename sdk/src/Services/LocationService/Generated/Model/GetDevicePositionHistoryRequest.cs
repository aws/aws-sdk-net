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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the GetDevicePositionHistory operation.
    /// Retrieves the device position history from a tracker resource within a specified range
    /// of time.
    /// 
    ///  <note> 
    /// <para>
    /// Device positions are deleted after 30 days.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDevicePositionHistoryRequest : AmazonLocationServiceRequest
    {
        private string _deviceId;
        private DateTime? _endTimeExclusive;
        private int? _maxResults;
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
        /// ISO 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. By default, the value will be
        /// the time that the request is made.
        /// </para>
        ///  
        /// <para>
        /// Requirement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The time specified for <c>EndTimeExclusive</c> must be after the time for <c>StartTimeInclusive</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional limit for the number of device positions returned in a single call.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>100</c> 
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
        /// The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>null</c> 
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
        /// ISO 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. By default, the value will be
        /// 24 hours prior to the time that the request is made.
        /// </para>
        ///  
        /// <para>
        /// Requirement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The time specified for <c>StartTimeInclusive</c> must be before <c>EndTimeExclusive</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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