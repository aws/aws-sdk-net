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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Summary information about an Health event.
    /// 
    ///  
    /// <para>
    /// Health events can be public or account-specific:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Public events</i> might be service events that are not specific to an Amazon Web
    /// Services account. For example, if there is an issue with an Amazon Web Services Region,
    /// Health provides information about the event, even if you don't use services or resources
    /// in that Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Account-specific</i> events are specific to either your Amazon Web Services account
    /// or an account in your organization. For example, if there's an issue with Amazon Elastic
    /// Compute Cloud in a Region that you use, Health provides information about the event
    /// and the affected resources in the account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can determine if an event is public or account-specific by using the <c>eventScopeCode</c>
    /// parameter. For more information, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html#AWSHealth-Type-Event-eventScopeCode">eventScopeCode</a>.
    /// </para>
    /// </summary>
    public partial class Event
    {
        private string _arn;
        private string _availabilityZone;
        private DateTime? _endTime;
        private EventScopeCode _eventScopeCode;
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
        /// The unique identifier for the event. The event ARN has the <c>arn:aws:health:<i>event-region</i>::event/<i>SERVICE</i>/<i>EVENT_TYPE_CODE</i>/<i>EVENT_TYPE_PLUS_ID</i>
        /// </c> format.
        /// </para>
        ///  
        /// <para>
        /// For example, an event ARN might look like the following:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:health:us-east-1::event/EC2/EC2_INSTANCE_RETIREMENT_SCHEDULED/EC2_INSTANCE_RETIREMENT_SCHEDULED_ABC123-DEF456</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1600)]
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
        /// The Amazon Web Services Availability Zone of the event. For example, us-east-1a.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=18)]
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
        /// Gets and sets the property EventScopeCode. 
        /// <para>
        /// This parameter specifies if the Health event is a public Amazon Web Services service
        /// event or an account-specific event.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the <c>eventScopeCode</c> value is <c>PUBLIC</c>, then the <c>affectedAccounts</c>
        /// value is always empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>eventScopeCode</c> value is <c>ACCOUNT_SPECIFIC</c>, then the <c>affectedAccounts</c>
        /// value lists the affected Amazon Web Services accounts in your organization. For example,
        /// if an event affects a service such as Amazon Elastic Compute Cloud and you have Amazon
        /// Web Services accounts that use that service, those account IDs appear in the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>eventScopeCode</c> value is <c>NONE</c>, then the <c>eventArn</c> that you
        /// specified in the request is invalid or doesn't exist.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EventScopeCode EventScopeCode
        {
            get { return this._eventScopeCode; }
            set { this._eventScopeCode = value; }
        }

        // Check to see if EventScopeCode property is set
        internal bool IsSetEventScopeCode()
        {
            return this._eventScopeCode != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeCategory. 
        /// <para>
        /// A list of event type category codes. Possible values are <c>issue</c>, <c>accountNotification</c>,
        /// or <c>scheduledChange</c>. Currently, the <c>investigation</c> value isn't supported
        /// at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
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
        /// The unique identifier for the event type. The format is <c>AWS_<i>SERVICE</i>_<i>DESCRIPTION</i>
        /// </c>; for example, <c>AWS_EC2_SYSTEM_MAINTENANCE_EVENT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
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
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
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
        /// The Amazon Web Services Region name of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=25)]
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
        /// The Amazon Web Services service that is affected by the event. For example, <c>EC2</c>,
        /// <c>RDS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=30)]
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
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The most recent status of the event. Possible values are <c>open</c>, <c>closed</c>,
        /// and <c>upcoming</c>.
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