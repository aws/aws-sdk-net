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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A storage lake of event data against which you can run complex SQL-based queries.
    /// An event data store can include events that you have logged on your account. To select
    /// events for an event data store, use <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-concepts.html#adv-event-selectors">advanced
    /// event selectors</a>.
    /// </summary>
    public partial class EventDataStore
    {
        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        /// The advanced event selectors that were used to select events for the data store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("AdvancedEventSelectors is no longer returned by ListEventDataStores")]
        public List<AdvancedEventSelector> AdvancedEventSelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<AdvancedEventSelector>() : null;

        /// <summary>
        /// Checks to see if the AdvancedEventSelectors property is set.
        /// </summary>
        internal bool IsSetAdvancedEventSelectors() => this.AdvancedEventSelectors != null && (this.AdvancedEventSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of the event data store's creation.
        /// </para>
        /// </summary>
        [Obsolete("CreatedTimestamp is no longer returned by ListEventDataStores")]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        /// The ARN of the event data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string EventDataStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStoreArn property is set.
        /// </summary>
        internal bool IsSetEventDataStoreArn() => this.EventDataStoreArn != null;

        /// <summary>
        /// Gets and sets the property MultiRegionEnabled. 
        /// <para>
        /// Indicates whether the event data store includes events from all Regions, or only from
        /// the Region in which it was created.
        /// </para>
        /// </summary>
        [Obsolete("MultiRegionEnabled is no longer returned by ListEventDataStores")]
        public bool? MultiRegionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionEnabled property is set.
        /// </summary>
        internal bool IsSetMultiRegionEnabled() => this.MultiRegionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OrganizationEnabled. 
        /// <para>
        /// Indicates that an event data store is collecting logged events for an organization.
        /// </para>
        /// </summary>
        [Obsolete("OrganizationEnabled is no longer returned by ListEventDataStores")]
        public bool? OrganizationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationEnabled property is set.
        /// </summary>
        internal bool IsSetOrganizationEnabled() => this.OrganizationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The retention period, in days.
        /// </para>
        /// </summary>
        [Obsolete("RetentionPeriod is no longer returned by ListEventDataStores")]
        [AWSProperty(Min = 7, Max = 3653)]
        public int? RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of an event data store.
        /// </para>
        /// </summary>
        [Obsolete("Status is no longer returned by ListEventDataStores")]
        public EventDataStoreStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// Indicates whether the event data store is protected from termination.
        /// </para>
        /// </summary>
        [Obsolete("TerminationProtectionEnabled is no longer returned by ListEventDataStores")]
        public bool? TerminationProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TerminationProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetTerminationProtectionEnabled() => this.TerminationProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The timestamp showing when an event data store was updated, if applicable. <c>UpdatedTimestamp</c>
        /// is always either the same or newer than the time shown in <c>CreatedTimestamp</c>.
        /// </para>
        /// </summary>
        [Obsolete("UpdatedTimestamp is no longer returned by ListEventDataStores")]
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
