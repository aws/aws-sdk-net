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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Container for the parameters to the CreateSnapshotSchedule operation.
    /// Create a snapshot schedule that can be associated to a cluster and which overrides
    /// the default system backup schedule.
    /// </summary>
    public partial class CreateSnapshotScheduleRequest : AmazonRedshiftRequest
    {
        private bool? _dryRun;
        private int? _nextInvocations;
        private List<string> _scheduleDefinitions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _scheduleDescription;
        private string _scheduleIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DryRun.
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextInvocations.
        /// </summary>
        public int? NextInvocations
        {
            get { return this._nextInvocations; }
            set { this._nextInvocations = value; }
        }

        // Check to see if NextInvocations property is set
        internal bool IsSetNextInvocations()
        {
            return this._nextInvocations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleDefinitions. 
        /// <para>
        /// The definition of the snapshot schedule. The definition is made up of schedule expressions,
        /// for example "cron(30 12 *)" or "rate(12 hours)". 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ScheduleDefinitions
        {
            get { return this._scheduleDefinitions; }
            set { this._scheduleDefinitions = value; }
        }

        // Check to see if ScheduleDefinitions property is set
        internal bool IsSetScheduleDefinitions()
        {
            return this._scheduleDefinitions != null && (this._scheduleDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduleDescription. 
        /// <para>
        /// The description of the snapshot schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ScheduleDescription
        {
            get { return this._scheduleDescription; }
            set { this._scheduleDescription = value; }
        }

        // Check to see if ScheduleDescription property is set
        internal bool IsSetScheduleDescription()
        {
            return this._scheduleDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleIdentifier. 
        /// <para>
        /// A unique identifier for a snapshot schedule. Only alphanumeric characters are allowed
        /// for the identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ScheduleIdentifier
        {
            get { return this._scheduleIdentifier; }
            set { this._scheduleIdentifier = value; }
        }

        // Check to see if ScheduleIdentifier property is set
        internal bool IsSetScheduleIdentifier()
        {
            return this._scheduleIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional set of tags you can use to search for the schedule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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