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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the UpdateEventTrigger operation.
    /// </summary>
    public partial class UpdateEventTriggerResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _description;
        private List<EventTriggerCondition> _eventTriggerConditions = AWSConfigs.InitializeCollections ? new List<EventTriggerCondition>() : null;
        private EventTriggerLimits _eventTriggerLimits;
        private string _eventTriggerName;
        private DateTime? _lastUpdatedAt;
        private string _objectTypeName;
        private string _segmentFilter;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the event trigger was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the event trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventTriggerConditions. 
        /// <para>
        /// A list of conditions that determine when an event should trigger the destination.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=5)]
        public List<EventTriggerCondition> EventTriggerConditions
        {
            get { return this._eventTriggerConditions; }
            set { this._eventTriggerConditions = value; }
        }

        // Check to see if EventTriggerConditions property is set
        internal bool IsSetEventTriggerConditions()
        {
            return this._eventTriggerConditions != null && (this._eventTriggerConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventTriggerLimits. 
        /// <para>
        /// Defines limits controlling whether an event triggers the destination, based on ingestion
        /// latency and the number of invocations per profile over specific time periods.
        /// </para>
        /// </summary>
        public EventTriggerLimits EventTriggerLimits
        {
            get { return this._eventTriggerLimits; }
            set { this._eventTriggerLimits = value; }
        }

        // Check to see if EventTriggerLimits property is set
        internal bool IsSetEventTriggerLimits()
        {
            return this._eventTriggerLimits != null;
        }

        /// <summary>
        /// Gets and sets the property EventTriggerName. 
        /// <para>
        /// The unique name of the event trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EventTriggerName
        {
            get { return this._eventTriggerName; }
            set { this._eventTriggerName = value; }
        }

        // Check to see if EventTriggerName property is set
        internal bool IsSetEventTriggerName()
        {
            return this._eventTriggerName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp of when the event trigger was most recently updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectTypeName. 
        /// <para>
        /// The unique name of the object type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ObjectTypeName
        {
            get { return this._objectTypeName; }
            set { this._objectTypeName = value; }
        }

        // Check to see if ObjectTypeName property is set
        internal bool IsSetObjectTypeName()
        {
            return this._objectTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentFilter. 
        /// <para>
        /// The destination is triggered only for profiles that meet the criteria of a segment
        /// definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SegmentFilter
        {
            get { return this._segmentFilter; }
            set { this._segmentFilter = value; }
        }

        // Check to see if SegmentFilter property is set
        internal bool IsSetSegmentFilter()
        {
            return this._segmentFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs to apply to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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