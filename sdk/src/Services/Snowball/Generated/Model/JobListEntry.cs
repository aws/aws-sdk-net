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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Each <code>JobListEntry</code> object contains a job's state, a job's ID, and a value
    /// that indicates whether the job is a job part, in the case of an export job.
    /// </summary>
    public partial class JobListEntry
    {
        private bool? _isMaster;
        private string _jobId;
        private JobState _jobState;

        /// <summary>
        /// Gets and sets the property IsMaster. 
        /// <para>
        /// A value that indicates that this job is a master job. A master job represents a successful
        /// request to create an export job. Master jobs aren't associated with any Snowballs.
        /// Instead, each master job will have at least one job part, and each job part is associated
        /// with a Snowball. It might take some time before the job parts associated with a particular
        /// master job are listed, because they are created after the master job is created.
        /// </para>
        /// </summary>
        public bool IsMaster
        {
            get { return this._isMaster.GetValueOrDefault(); }
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
        /// The automatically generated ID for a job, for example <code>JID123e4567-e89b-12d3-a456-426655440000</code>.
        /// </para>
        /// </summary>
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

    }
}