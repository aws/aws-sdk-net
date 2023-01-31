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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A storage lake of event data against which you can run complex SQL-based queries.
    /// An event data store can include events that you have logged on your account from the
    /// last 90 to 2557 days (about three months to up to seven years). To select events for
    /// an event data store, use <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html#creating-data-event-selectors-advanced">advanced
    /// event selectors</a>.
    /// </summary>
    public partial class EventDataStore
    {
        private List<AdvancedEventSelector> _advancedEventSelectors = new List<AdvancedEventSelector>();
        private DateTime? _createdTimestamp;
        private string _eventDataStoreArn;
        private bool? _multiRegionEnabled;
        private string _name;
        private bool? _organizationEnabled;
        private int? _retentionPeriod;
        private EventDataStoreStatus _status;
        private bool? _terminationProtectionEnabled;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        /// The advanced event selectors that were used to select events for the data store.
        /// </para>
        /// </summary>
        [Obsolete("AdvancedEventSelectors is no longer returned by ListEventDataStores")]
        public List<AdvancedEventSelector> AdvancedEventSelectors
        {
            get { return this._advancedEventSelectors; }
            set { this._advancedEventSelectors = value; }
        }

        // Check to see if AdvancedEventSelectors property is set
        internal bool IsSetAdvancedEventSelectors()
        {
            return this._advancedEventSelectors != null && this._advancedEventSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of the event data store's creation.
        /// </para>
        /// </summary>
        [Obsolete("CreatedTimestamp is no longer returned by ListEventDataStores")]
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        /// The ARN of the event data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string EventDataStoreArn
        {
            get { return this._eventDataStoreArn; }
            set { this._eventDataStoreArn = value; }
        }

        // Check to see if EventDataStoreArn property is set
        internal bool IsSetEventDataStoreArn()
        {
            return this._eventDataStoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionEnabled. 
        /// <para>
        /// Indicates whether the event data store includes events from all regions, or only from
        /// the region in which it was created.
        /// </para>
        /// </summary>
        [Obsolete("MultiRegionEnabled is no longer returned by ListEventDataStores")]
        public bool MultiRegionEnabled
        {
            get { return this._multiRegionEnabled.GetValueOrDefault(); }
            set { this._multiRegionEnabled = value; }
        }

        // Check to see if MultiRegionEnabled property is set
        internal bool IsSetMultiRegionEnabled()
        {
            return this._multiRegionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationEnabled. 
        /// <para>
        /// Indicates that an event data store is collecting logged events for an organization.
        /// </para>
        /// </summary>
        [Obsolete("OrganizationEnabled is no longer returned by ListEventDataStores")]
        public bool OrganizationEnabled
        {
            get { return this._organizationEnabled.GetValueOrDefault(); }
            set { this._organizationEnabled = value; }
        }

        // Check to see if OrganizationEnabled property is set
        internal bool IsSetOrganizationEnabled()
        {
            return this._organizationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The retention period, in days.
        /// </para>
        /// </summary>
        [Obsolete("RetentionPeriod is no longer returned by ListEventDataStores")]
        [AWSProperty(Min=7, Max=2557)]
        public int RetentionPeriod
        {
            get { return this._retentionPeriod.GetValueOrDefault(); }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of an event data store. Values are <code>ENABLED</code> and <code>PENDING_DELETION</code>.
        /// </para>
        /// </summary>
        [Obsolete("Status is no longer returned by ListEventDataStores")]
        public EventDataStoreStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// Indicates whether the event data store is protected from termination.
        /// </para>
        /// </summary>
        [Obsolete("TerminationProtectionEnabled is no longer returned by ListEventDataStores")]
        public bool TerminationProtectionEnabled
        {
            get { return this._terminationProtectionEnabled.GetValueOrDefault(); }
            set { this._terminationProtectionEnabled = value; }
        }

        // Check to see if TerminationProtectionEnabled property is set
        internal bool IsSetTerminationProtectionEnabled()
        {
            return this._terminationProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The timestamp showing when an event data store was updated, if applicable. <code>UpdatedTimestamp</code>
        /// is always either the same or newer than the time shown in <code>CreatedTimestamp</code>.
        /// </para>
        /// </summary>
        [Obsolete("UpdatedTimestamp is no longer returned by ListEventDataStores")]
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}