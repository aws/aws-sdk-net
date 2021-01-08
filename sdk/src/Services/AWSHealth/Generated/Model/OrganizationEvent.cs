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

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Summary information about an event, returned by the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventsForOrganization.html">DescribeEventsForOrganization</a>
    /// operation.
    /// </summary>
    public partial class OrganizationEvent
    {
        private string _arn;
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
        /// The unique identifier for the event. Format: <code>arn:aws:health:<i>event-region</i>::event/<i>SERVICE</i>/<i>EVENT_TYPE_CODE</i>/<i>EVENT_TYPE_PLUS_ID</i>
        /// </code>. Example: <code>Example: arn:aws:health:us-east-1::event/EC2/EC2_INSTANCE_RETIREMENT_SCHEDULED/EC2_INSTANCE_RETIREMENT_SCHEDULED_ABC123-DEF456</code>
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
        /// Gets and sets the property EventScopeCode. 
        /// <para>
        /// This parameter specifies if the AWS Health event is a public AWS service event or
        /// an account-specific event.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the <code>eventScopeCode</code> value is <code>PUBLIC</code>, then the <code>affectedAccounts</code>
        /// value is always empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <code>eventScopeCode</code> value is <code>ACCOUNT_SPECIFIC</code>, then the
        /// <code>affectedAccounts</code> value lists the affected AWS accounts in your organization.
        /// For example, if an event affects a service such as Amazon Elastic Compute Cloud and
        /// you have AWS accounts that use that service, those account IDs appear in the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <code>eventScopeCode</code> value is <code>NONE</code>, then the <code>eventArn</code>
        /// that you specified in the request is invalid or doesn't exist.
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
        /// The category of the event type.
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
        /// The unique identifier for the event type. The format is <code>AWS_SERVICE_DESCRIPTION</code>.
        /// For example, <code>AWS_EC2_SYSTEM_MAINTENANCE_EVENT</code>.
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
        /// The AWS Region name of the event.
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
        /// The AWS service that is affected by the event. For example, EC2, RDS.
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