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
    /// The values to use to filter results from the <a>DescribeEvents</a> and <a>DescribeEventAggregates</a>
    /// operations.
    /// </summary>
    public partial class EventFilter
    {
        private List<string> _availabilityZones = new List<string>();
        private List<DateTimeRange> _endTimes = new List<DateTimeRange>();
        private List<string> _entityArns = new List<string>();
        private List<string> _entityValues = new List<string>();
        private List<string> _eventArns = new List<string>();
        private List<string> _eventStatusCodes = new List<string>();
        private List<string> _eventTypeCategories = new List<string>();
        private List<string> _eventTypeCodes = new List<string>();
        private List<DateTimeRange> _lastUpdatedTimes = new List<DateTimeRange>();
        private List<string> _regions = new List<string>();
        private List<string> _services = new List<string>();
        private List<DateTimeRange> _startTimes = new List<DateTimeRange>();
        private List<Dictionary<string, string>> _tags = new List<Dictionary<string, string>>();

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of AWS availability zones.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndTimes. 
        /// <para>
        /// A list of dates and times that the event ended.
        /// </para>
        /// </summary>
        public List<DateTimeRange> EndTimes
        {
            get { return this._endTimes; }
            set { this._endTimes = value; }
        }

        // Check to see if EndTimes property is set
        internal bool IsSetEndTimes()
        {
            return this._endTimes != null && this._endTimes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EntityArns. 
        /// <para>
        /// A list of entity ARNs (unique identifiers).
        /// </para>
        /// </summary>
        public List<string> EntityArns
        {
            get { return this._entityArns; }
            set { this._entityArns = value; }
        }

        // Check to see if EntityArns property is set
        internal bool IsSetEntityArns()
        {
            return this._entityArns != null && this._entityArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EntityValues. 
        /// <para>
        /// A list of entity identifiers, such as EC2 instance IDs (<code>i-34ab692e</code>) or
        /// EBS volumes (<code>vol-426ab23e</code>).
        /// </para>
        /// </summary>
        public List<string> EntityValues
        {
            get { return this._entityValues; }
            set { this._entityValues = value; }
        }

        // Check to see if EntityValues property is set
        internal bool IsSetEntityValues()
        {
            return this._entityValues != null && this._entityValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventArns. 
        /// <para>
        /// A list of event ARNs (unique identifiers). For example: <code>"arn:aws:health:us-east-1::event/AWS_EC2_MAINTENANCE_5331",
        /// "arn:aws:health:us-west-1::event/AWS_EBS_LOST_VOLUME_xyz"</code> 
        /// </para>
        /// </summary>
        public List<string> EventArns
        {
            get { return this._eventArns; }
            set { this._eventArns = value; }
        }

        // Check to see if EventArns property is set
        internal bool IsSetEventArns()
        {
            return this._eventArns != null && this._eventArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventStatusCodes. 
        /// <para>
        /// A list of event status codes.
        /// </para>
        /// </summary>
        public List<string> EventStatusCodes
        {
            get { return this._eventStatusCodes; }
            set { this._eventStatusCodes = value; }
        }

        // Check to see if EventStatusCodes property is set
        internal bool IsSetEventStatusCodes()
        {
            return this._eventStatusCodes != null && this._eventStatusCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventTypeCategories. 
        /// <para>
        /// A list of event type category codes (<code>issue</code>, <code>scheduledChange</code>,
        /// or <code>accountNotification</code>).
        /// </para>
        /// </summary>
        public List<string> EventTypeCategories
        {
            get { return this._eventTypeCategories; }
            set { this._eventTypeCategories = value; }
        }

        // Check to see if EventTypeCategories property is set
        internal bool IsSetEventTypeCategories()
        {
            return this._eventTypeCategories != null && this._eventTypeCategories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventTypeCodes. 
        /// <para>
        /// A list of unique identifiers for event types. For example, <code>"AWS_EC2_SYSTEM_MAINTENANCE_EVENT","AWS_RDS_MAINTENANCE_SCHEDULED"</code>
        /// 
        /// </para>
        /// </summary>
        public List<string> EventTypeCodes
        {
            get { return this._eventTypeCodes; }
            set { this._eventTypeCodes = value; }
        }

        // Check to see if EventTypeCodes property is set
        internal bool IsSetEventTypeCodes()
        {
            return this._eventTypeCodes != null && this._eventTypeCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimes. 
        /// <para>
        /// A list of dates and times that the event was last updated.
        /// </para>
        /// </summary>
        public List<DateTimeRange> LastUpdatedTimes
        {
            get { return this._lastUpdatedTimes; }
            set { this._lastUpdatedTimes = value; }
        }

        // Check to see if LastUpdatedTimes property is set
        internal bool IsSetLastUpdatedTimes()
        {
            return this._lastUpdatedTimes != null && this._lastUpdatedTimes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// A list of AWS regions.
        /// </para>
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && this._regions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The AWS services associated with the event. For example, <code>EC2</code>, <code>RDS</code>.
        /// </para>
        /// </summary>
        public List<string> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && this._services.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTimes. 
        /// <para>
        /// A list of dates and times that the event began.
        /// </para>
        /// </summary>
        public List<DateTimeRange> StartTimes
        {
            get { return this._startTimes; }
            set { this._startTimes = value; }
        }

        // Check to see if StartTimes property is set
        internal bool IsSetStartTimes()
        {
            return this._startTimes != null && this._startTimes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of entity tags attached to the affected entity.
        /// </para>
        /// </summary>
        public List<Dictionary<string, string>> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}