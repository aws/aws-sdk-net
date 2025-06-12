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
    /// The values to use to filter results from the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEvents.html">DescribeEvents</a>
    /// and <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventAggregates.html">DescribeEventAggregates</a>
    /// operations.
    /// </summary>
    public partial class EventFilter
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DateTimeRange> _endTimes = AWSConfigs.InitializeCollections ? new List<DateTimeRange>() : null;
        private List<string> _entityArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _entityValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _eventArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _eventStatusCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _eventTypeCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _eventTypeCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DateTimeRange> _lastUpdatedTimes = AWSConfigs.InitializeCollections ? new List<DateTimeRange>() : null;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _services = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DateTimeRange> _startTimes = AWSConfigs.InitializeCollections ? new List<DateTimeRange>() : null;
        private List<Dictionary<string, string>> _tags = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Amazon Web Services Availability Zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTimes. 
        /// <para>
        /// A list of dates and times that the event ended.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<DateTimeRange> EndTimes
        {
            get { return this._endTimes; }
            set { this._endTimes = value; }
        }

        // Check to see if EndTimes property is set
        internal bool IsSetEndTimes()
        {
            return this._endTimes != null && (this._endTimes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntityArns. 
        /// <para>
        /// A list of entity ARNs (unique identifiers).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=99)]
        public List<string> EntityArns
        {
            get { return this._entityArns; }
            set { this._entityArns = value; }
        }

        // Check to see if EntityArns property is set
        internal bool IsSetEntityArns()
        {
            return this._entityArns != null && (this._entityArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntityValues. 
        /// <para>
        /// A list of entity identifiers, such as EC2 instance IDs (<c>i-34ab692e</c>) or EBS
        /// volumes (<c>vol-426ab23e</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=99)]
        public List<string> EntityValues
        {
            get { return this._entityValues; }
            set { this._entityValues = value; }
        }

        // Check to see if EntityValues property is set
        internal bool IsSetEntityValues()
        {
            return this._entityValues != null && (this._entityValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventArns. 
        /// <para>
        /// A list of event ARNs (unique identifiers). For example: <c>"arn:aws:health:us-east-1::event/EC2/EC2_INSTANCE_RETIREMENT_SCHEDULED/EC2_INSTANCE_RETIREMENT_SCHEDULED_ABC123-CDE456",
        /// "arn:aws:health:us-west-1::event/EBS/AWS_EBS_LOST_VOLUME/AWS_EBS_LOST_VOLUME_CHI789_JKL101"</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> EventArns
        {
            get { return this._eventArns; }
            set { this._eventArns = value; }
        }

        // Check to see if EventArns property is set
        internal bool IsSetEventArns()
        {
            return this._eventArns != null && (this._eventArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventStatusCodes. 
        /// <para>
        /// A list of event status codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._eventStatusCodes != null && (this._eventStatusCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventTypeCategories. 
        /// <para>
        /// A list of event type category codes. Possible values are <c>issue</c>, <c>accountNotification</c>,
        /// or <c>scheduledChange</c>. Currently, the <c>investigation</c> value isn't supported
        /// at this time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._eventTypeCategories != null && (this._eventTypeCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventTypeCodes. 
        /// <para>
        /// A list of unique identifiers for event types. For example, <c>"AWS_EC2_SYSTEM_MAINTENANCE_EVENT","AWS_RDS_MAINTENANCE_SCHEDULED".</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._eventTypeCodes != null && (this._eventTypeCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimes. 
        /// <para>
        /// A list of dates and times that the event was last updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<DateTimeRange> LastUpdatedTimes
        {
            get { return this._lastUpdatedTimes; }
            set { this._lastUpdatedTimes = value; }
        }

        // Check to see if LastUpdatedTimes property is set
        internal bool IsSetLastUpdatedTimes()
        {
            return this._lastUpdatedTimes != null && (this._lastUpdatedTimes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// A list of Amazon Web Services Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The Amazon Web Services services associated with the event. For example, <c>EC2</c>,
        /// <c>RDS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._services != null && (this._services.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTimes. 
        /// <para>
        /// A list of dates and times that the event began.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<DateTimeRange> StartTimes
        {
            get { return this._startTimes; }
            set { this._startTimes = value; }
        }

        // Check to see if StartTimes property is set
        internal bool IsSetStartTimes()
        {
            return this._startTimes != null && (this._startTimes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of entity tags attached to the affected entity.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, the <c>tags</c> property isn't supported.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Dictionary<string, string>> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}