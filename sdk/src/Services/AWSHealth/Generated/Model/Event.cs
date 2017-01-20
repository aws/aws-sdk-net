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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Summary information about an event, returned by the <a>DescribeEvents</a> operation.
    /// The <a>DescribeEventDetails</a> operation also returns this information, as well as
    /// the <a>EventDescription</a> and additional event metadata.
    /// </summary>
    public partial class Event
    {
        private string _arn;
        private string _availabilityZone;
        private DateTime? _endTime;
        private EventTypeCategory _eventTypeCategory;
        private string _eventTypeCode;
        private DateTime? _lastUpdatedTime;
        private string _region;
        private string _service;
        private DateTime? _startTime;
        private EventStatusCode _statusCode;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique identifier for the event. Format: <code>arn:aws:health:<i>event-region</i>::event/<i>EVENT_TYPE_PLUS_ID</i>
        /// </code>. Example: <code>arn:aws:health:us-east-1::event/AWS_EC2_MAINTENANCE_5331</code>
        /// 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The AWS Availability Zone of the event. For example, us-east-1a.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time that the event ended.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventTypeCategory. 
        /// <para>
        /// The 
        /// </para>
        /// </summary>
        public EventTypeCategory EventTypeCategory
        {
            get { return this._eventTypeCategory; }
            set { this._eventTypeCategory = value; }
        }

        // Check to see if EventTypeCategory property is set
        internal bool IsSetEventTypeCategory()
        {
            return this._eventTypeCategory != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeCode. 
        /// <para>
        /// The unique identifier for the event type. The format is <code>AWS_<i>SERVICE</i>_<i>DESCRIPTION</i>
        /// </code>; for example, <code>AWS_EC2_SYSTEM_MAINTENANCE_EVENT</code>.
        /// </para>
        /// </summary>
        public string EventTypeCode
        {
            get { return this._eventTypeCode; }
            set { this._eventTypeCode = value; }
        }

        // Check to see if EventTypeCode property is set
        internal bool IsSetEventTypeCode()
        {
            return this._eventTypeCode != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The most recent date and time that the event was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS region name of the event.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The AWS service that is affected by the event. For example, <code>EC2</code>, <code>RDS</code>.
        /// </para>
        /// </summary>
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time that the event began.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The most recent status of the event. Possible values are <code>open</code>, <code>closed</code>,
        /// and <code>upcoming</code>.
        /// </para>
        /// </summary>
        public EventStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}