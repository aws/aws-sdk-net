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
    /// Container for the parameters to the CreateSnapshotSchedule operation. Create a snapshot
    /// schedule that can be associated to a cluster and which overrides the default system
    /// backup schedule.
    /// </summary>
    public partial class CreateSnapshotScheduleRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property NextInvocations. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? NextInvocations { get; set; }

        /// <summary>
        /// Checks to see if the NextInvocations property is set.
        /// </summary>
        internal bool IsSetNextInvocations() => this.NextInvocations.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleDefinitions. 
        /// <para>
        /// The definition of the snapshot schedule. The definition is made up of schedule expressions,
        /// for example "cron(30 12 *)" or "rate(12 hours)". 
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
        /// The description of the snapshot schedule.
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
        /// A unique identifier for a snapshot schedule. Only alphanumeric characters are allowed
        /// for the identifier.
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
        /// An optional set of tags you can use to search for the schedule.
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
