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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Job.
    /// </summary>
    public partial class Job
    {
        private string _arn;
        private string _creationDateTime;
        private string _endDateTime;
        private InitiatedBy _initiatedBy;
        private string _jobid;
        private List<ParticipatingServer> _participatingServers = new List<ParticipatingServer>();
        private JobStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private JobType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// the ARN of the specific Job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// Job creation time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// Job end time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string EndDateTime
        {
            get { return this._endDateTime; }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        /// Job initiated by field.
        /// </para>
        /// </summary>
        public InitiatedBy InitiatedBy
        {
            get { return this._initiatedBy; }
            set { this._initiatedBy = value; }
        }

        // Check to see if InitiatedBy property is set
        internal bool IsSetInitiatedBy()
        {
            return this._initiatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// Job ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=24)]
        public string JobID
        {
            get { return this._jobid; }
            set { this._jobid = value; }
        }

        // Check to see if JobID property is set
        internal bool IsSetJobID()
        {
            return this._jobid != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipatingServers. 
        /// <para>
        /// Servers participating in a specific Job.
        /// </para>
        /// </summary>
        public List<ParticipatingServer> ParticipatingServers
        {
            get { return this._participatingServers; }
            set { this._participatingServers = value; }
        }

        // Check to see if ParticipatingServers property is set
        internal bool IsSetParticipatingServers()
        {
            return this._participatingServers != null && this._participatingServers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Job status.
        /// </para>
        /// </summary>
        public JobStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with specific Job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Job type.
        /// </para>
        /// </summary>
        public JobType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}