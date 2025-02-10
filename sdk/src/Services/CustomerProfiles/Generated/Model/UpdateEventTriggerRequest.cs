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
    /// Container for the parameters to the UpdateEventTrigger operation.
    /// Update the properties of an Event Trigger.
    /// </summary>
    public partial class UpdateEventTriggerRequest : AmazonCustomerProfilesRequest
    {
        private string _description;
        private string _domainName;
        private List<EventTriggerCondition> _eventTriggerConditions = AWSConfigs.InitializeCollections ? new List<EventTriggerCondition>() : null;
        private EventTriggerLimits _eventTriggerLimits;
        private string _eventTriggerName;
        private string _objectTypeName;
        private string _segmentFilter;

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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property EventTriggerConditions. 
        /// <para>
        /// A list of conditions that determine when an event should trigger the destination.
        /// </para>
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
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}