/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT1ClickDevicesService.Model
{
    /// <summary>
    /// Container for the parameters to the ListDeviceEvents operation.
    /// Using a device ID, returns a DeviceEventsResponse object containing an array of events
    /// for the device.
    /// </summary>
    public partial class ListDeviceEventsRequest : AmazonIoT1ClickDevicesServiceRequest
    {
        private string _deviceId;
        private DateTime? _fromTimeStampUtc;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _toTimeStampUtc;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The unique identifier of the device.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FromTimeStampUtc. 
        /// <para>
        /// The start date for the device event query, in ISO8061 format. For example, 2018-03-28T15:45:12.880Z
        /// 
        /// </para>
        /// </summary>
        public DateTime FromTimeStampUtc
        {
            get { return this._fromTimeStampUtc.GetValueOrDefault(); }
            set { this._fromTimeStamp = this._fromTimeStampUtc = value; }
        }

        // Check to see if FromTimeStampUtc property is set
        internal bool IsSetFromTimeStampUtc()
        {
            return this._fromTimeStampUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per request. If not set, a default value of
        /// 100 is used.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token to retrieve the next set of results.
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
        /// Gets and sets the property ToTimeStampUtc. 
        /// <para>
        /// The end date for the device event query, in ISO8061 format. For example, 2018-03-28T15:45:12.880Z
        /// 
        /// </para>
        /// </summary>
        public DateTime ToTimeStampUtc
        {
            get { return this._toTimeStampUtc.GetValueOrDefault(); }
            set { this._toTimeStamp = this._toTimeStampUtc = value; }
        }

        // Check to see if ToTimeStampUtc property is set
        internal bool IsSetToTimeStampUtc()
        {
            return this._toTimeStampUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _fromTimeStamp;
        private DateTime? _toTimeStamp;

        /// <summary>
        /// Gets and sets the property FromTimeStampUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use FromTimeStampUtc instead. Setting either FromTimeStamp
        /// or FromTimeStampUtc results in both FromTimeStamp and FromTimeStampUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value
        /// of both. FromTimeStamp is provided for backwards compatibility only and assigning
        /// a non-Utc DateTime to it results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The start date for the device event query, in ISO8061 format. For example, 2018-03-28T15:45:12.880Z
        /// 
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use FromTimeStampUtc instead. Setting either FromTimeStamp or FromTimeStampUtc results in both FromTimeStamp and " +
            "FromTimeStampUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. FromTimeStamp is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime FromTimeStamp
        {
            get { return this._fromTimeStamp.GetValueOrDefault(); }
            set
            {
                this._fromTimeStamp = value;
                this._fromTimeStampUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property ToTimeStampUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ToTimeStampUtc instead. Setting either ToTimeStamp
        /// or ToTimeStampUtc results in both ToTimeStamp and ToTimeStampUtc being assigned, the
        /// latest assignment to either one of the two property is reflected in the value of both.
        /// ToTimeStamp is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The end date for the device event query, in ISO8061 format. For example, 2018-03-28T15:45:12.880Z
        /// 
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ToTimeStampUtc instead. Setting either ToTimeStamp or ToTimeStampUtc results in both ToTimeStamp and " +
            "ToTimeStampUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. ToTimeStamp is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ToTimeStamp
        {
            get { return this._toTimeStamp.GetValueOrDefault(); }
            set
            {
                this._toTimeStamp = value;
                this._toTimeStampUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}