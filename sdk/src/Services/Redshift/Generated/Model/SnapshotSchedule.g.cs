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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a snapshot schedule. You can set a regular interval for creating snapshots
    /// of a cluster. You can also schedule snapshots for specific dates.
    /// </summary>
    public partial class SnapshotSchedule
    {
        /// <summary>
        /// Gets and sets the property AssociatedClusterCount. 
        /// <para>
        /// The number of clusters associated with the schedule.
        /// </para>
        /// </summary>
        public int? AssociatedClusterCount { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedClusterCount property is set.
        /// </summary>
        internal bool IsSetAssociatedClusterCount() => this.AssociatedClusterCount.HasValue;

        /// <summary>
        /// Gets and sets the property AssociatedClusters. 
        /// <para>
        /// A list of clusters associated with the schedule. A maximum of 100 clusters is returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterAssociatedToSchedule> AssociatedClusters { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterAssociatedToSchedule>() : null;

        /// <summary>
        /// Checks to see if the AssociatedClusters property is set.
        /// </summary>
        internal bool IsSetAssociatedClusters() => this.AssociatedClusters != null && (this.AssociatedClusters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextInvocations. 
        /// <para>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> NextInvocations { get; set; } = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Checks to see if the NextInvocations property is set.
        /// </summary>
        internal bool IsSetNextInvocations() => this.NextInvocations != null && (this.NextInvocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduleDefinitions. 
        /// <para>
        /// A list of ScheduleDefinitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ScheduleDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ScheduleDefinitions property is set.
        /// </summary>
        internal bool IsSetScheduleDefinitions() => this.ScheduleDefinitions != null && (this.ScheduleDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduleDescription. 
        /// <para>
        /// The description of the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ScheduleDescription { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleDescription property is set.
        /// </summary>
        internal bool IsSetScheduleDescription() => this.ScheduleDescription != null;

        /// <summary>
        /// Gets and sets the property ScheduleIdentifier. 
        /// <para>
        /// A unique identifier for the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ScheduleIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleIdentifier property is set.
        /// </summary>
        internal bool IsSetScheduleIdentifier() => this.ScheduleIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional set of tags describing the schedule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
