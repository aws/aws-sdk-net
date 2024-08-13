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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Each <c>JobListEntry</c> object contains a job's state, a job's ID, and a value that
    /// indicates whether the job is a job part, in the case of an export job.
    /// </summary>
    public partial class JobListEntry
    {
        private DateTime? _creationDate;
        private string _description;
        private bool? _isMaster;
        private string _jobId;
        private JobState _jobState;
        private JobType _jobType;
        private SnowballType _snowballType;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date for this job.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description of this specific job, for example <c>Important Photos 2016-08-11</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property IsMaster. 
        /// <para>
        /// A value that indicates that this job is a main job. A main job represents a successful
        /// request to create an export job. Main jobs aren't associated with any Snowballs. Instead,
        /// each main job will have at least one job part, and each job part is associated with
        /// a Snowball. It might take some time before the job parts associated with a particular
        /// main job are listed, because they are created after the main job is created.
        /// </para>
        /// </summary>
        public bool? IsMaster
        {
            get { return this._isMaster; }
            set { this._isMaster = value; }
        }

        // Check to see if IsMaster property is set
        internal bool IsSetIsMaster()
        {
            return this._isMaster.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The automatically generated ID for a job, for example <c>JID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobState. 
        /// <para>
        /// The current state of this job.
        /// </para>
        /// </summary>
        public JobState JobState
        {
            get { return this._jobState; }
            set { this._jobState = value; }
        }

        // Check to see if JobState property is set
        internal bool IsSetJobState()
        {
            return this._jobState != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of job.
        /// </para>
        /// </summary>
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of device used with this job.
        /// </para>
        /// </summary>
        public SnowballType SnowballType
        {
            get { return this._snowballType; }
            set { this._snowballType = value; }
        }

        // Check to see if SnowballType property is set
        internal bool IsSetSnowballType()
        {
            return this._snowballType != null;
        }

    }
}