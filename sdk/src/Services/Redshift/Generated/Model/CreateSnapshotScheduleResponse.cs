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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a snapshot schedule. You can set a regular interval for creating snapshots
    /// of a cluster. You can also schedule snapshots for specific dates.
    /// </summary>
    public partial class CreateSnapshotScheduleResponse : AmazonWebServiceResponse
    {
        private int? _associatedClusterCount;
        private List<ClusterAssociatedToSchedule> _associatedClusters = new List<ClusterAssociatedToSchedule>();
        private List<DateTime> _nextInvocations = new List<DateTime>();
        private List<string> _scheduleDefinitions = new List<string>();
        private string _scheduleDescription;
        private string _scheduleIdentifier;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AssociatedClusterCount. 
        /// <para>
        /// The number of clusters associated with the schedule.
        /// </para>
        /// </summary>
        public int AssociatedClusterCount
        {
            get { return this._associatedClusterCount.GetValueOrDefault(); }
            set { this._associatedClusterCount = value; }
        }

        // Check to see if AssociatedClusterCount property is set
        internal bool IsSetAssociatedClusterCount()
        {
            return this._associatedClusterCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssociatedClusters. 
        /// <para>
        /// A list of clusters associated with the schedule. A maximum of 100 clusters is returned.
        /// </para>
        /// </summary>
        public List<ClusterAssociatedToSchedule> AssociatedClusters
        {
            get { return this._associatedClusters; }
            set { this._associatedClusters = value; }
        }

        // Check to see if AssociatedClusters property is set
        internal bool IsSetAssociatedClusters()
        {
            return this._associatedClusters != null && this._associatedClusters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextInvocations.
        /// </summary>
        public List<DateTime> NextInvocations
        {
            get { return this._nextInvocations; }
            set { this._nextInvocations = value; }
        }

        // Check to see if NextInvocations property is set
        internal bool IsSetNextInvocations()
        {
            return this._nextInvocations != null && this._nextInvocations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleDefinitions. 
        /// <para>
        /// A list of ScheduleDefinitions.
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
        /// The description of the schedule.
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
        /// A unique identifier for the schedule.
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
        /// An optional set of tags describing the schedule.
        /// </para>
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