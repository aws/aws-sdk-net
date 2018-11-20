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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSnapshotSchedule operation.
    /// Creates a new snapshot schedule.
    /// </summary>
    public partial class CreateSnapshotScheduleRequest : AmazonRedshiftRequest
    {
        private bool? _dryRun;
        private int? _nextInvocations;
        private List<string> _scheduleDefinitions = new List<string>();
        private string _scheduleDescription;
        private string _scheduleIdentifier;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DryRun.
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
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
        public int NextInvocations
        {
            get { return this._nextInvocations.GetValueOrDefault(); }
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
        /// </summary>
        public List<string> ScheduleDefinitions
        {
            get { return this._scheduleDefinitions; }
            set { this._scheduleDefinitions = value; }
        }

        // Check to see if ScheduleDefinitions property is set
        internal bool IsSetScheduleDefinitions()
        {
            return this._scheduleDefinitions != null && this._scheduleDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleDescription. 
        /// <para>
        /// The description of the snapshot schedule.
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<Tag> Tags
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