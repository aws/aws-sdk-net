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
    /// The values to filter results from the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventsForOrganization.html">DescribeEventsForOrganization</a>
    /// operation.
    /// </summary>
    public partial class OrganizationEventFilter
    {
        private List<string> _awsAccountIds = new List<string>();
        private DateTimeRange _endTime;
        private List<string> _entityArns = new List<string>();
        private List<string> _entityValues = new List<string>();
        private List<string> _eventStatusCodes = new List<string>();
        private List<string> _eventTypeCategories = new List<string>();
        private List<string> _eventTypeCodes = new List<string>();
        private DateTimeRange _lastUpdatedTime;
        private List<string> _regions = new List<string>();
        private List<string> _services = new List<string>();
        private DateTimeRange _startTime;

        /// <summary>
        /// Gets and sets the property AwsAccountIds. 
        /// <para>
        /// A list of 12-digit AWS account numbers that contains the affected entities.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> AwsAccountIds
        {
            get { return this._awsAccountIds; }
            set { this._awsAccountIds = value; }
        }

        // Check to see if AwsAccountIds property is set
        internal bool IsSetAwsAccountIds()
        {
            return this._awsAccountIds != null && this._awsAccountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndTime.
        /// </summary>
        public DateTimeRange EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property EntityArns. 
        /// <para>
        /// A list of entity ARNs (unique identifiers).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A list of entity identifiers, such as EC2 instance IDs (i-34ab692e) or EBS volumes
        /// (vol-426ab23e).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property EventStatusCodes. 
        /// <para>
        /// A list of event status codes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
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
        /// A list of event type category codes (issue, scheduledChange, or accountNotification).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// A list of unique identifiers for event types. For example, <code>"AWS_EC2_SYSTEM_MAINTENANCE_EVENT","AWS_RDS_MAINTENANCE_SCHEDULED".</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property LastUpdatedTime.
        /// </summary>
        public DateTimeRange LastUpdatedTime
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
        /// Gets and sets the property Regions. 
        /// <para>
        /// A list of AWS Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property StartTime.
        /// </summary>
        public DateTimeRange StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}