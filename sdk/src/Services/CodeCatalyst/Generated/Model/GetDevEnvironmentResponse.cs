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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// This is the response object from the GetDevEnvironment operation.
    /// </summary>
    public partial class GetDevEnvironmentResponse : AmazonWebServiceResponse
    {
        private string _alias;
        private string _creatorId;
        private string _id;
        private List<Ide> _ides = new List<Ide>();
        private int? _inactivityTimeoutMinutes;
        private InstanceType _instanceType;
        private DateTime? _lastUpdatedTime;
        private PersistentStorage _persistentStorage;
        private string _projectName;
        private List<DevEnvironmentRepositorySummary> _repositories = new List<DevEnvironmentRepositorySummary>();
        private string _spaceName;
        private DevEnvironmentStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The user-specified alias for the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorId. 
        /// <para>
        /// The system-generated unique ID of the user who created the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string CreatorId
        {
            get { return this._creatorId; }
            set { this._creatorId = value; }
        }

        // Check to see if CreatorId property is set
        internal bool IsSetCreatorId()
        {
            return this._creatorId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The system-generated unique ID of the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Ides. 
        /// <para>
        /// Information about the integrated development environment (IDE) configured for the
        /// Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Ide> Ides
        {
            get { return this._ides; }
            set { this._ides = value; }
        }

        // Check to see if Ides property is set
        internal bool IsSetIdes()
        {
            return this._ides != null && this._ides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InactivityTimeoutMinutes. 
        /// <para>
        /// The amount of time the Dev Environment will run without any activity detected before
        /// stopping, in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1200)]
        public int InactivityTimeoutMinutes
        {
            get { return this._inactivityTimeoutMinutes.GetValueOrDefault(); }
            set { this._inactivityTimeoutMinutes = value; }
        }

        // Check to see if InactivityTimeoutMinutes property is set
        internal bool IsSetInactivityTimeoutMinutes()
        {
            return this._inactivityTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instace type to use for the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the Dev Environment was last updated, in coordinated universal time
        /// (UTC) timestamp format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PersistentStorage. 
        /// <para>
        /// Information about the amount of storage allocated to the Dev Environment. By default,
        /// a Dev Environment is configured to have 16GB of persistent storage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PersistentStorage PersistentStorage
        {
            get { return this._persistentStorage; }
            set { this._persistentStorage = value; }
        }

        // Check to see if PersistentStorage property is set
        internal bool IsSetPersistentStorage()
        {
            return this._persistentStorage != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property Repositories. 
        /// <para>
        /// The source repository that contains the branch cloned into the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DevEnvironmentRepositorySummary> Repositories
        {
            get { return this._repositories; }
            set { this._repositories = value; }
        }

        // Check to see if Repositories property is set
        internal bool IsSetRepositories()
        {
            return this._repositories != null && this._repositories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Dev Environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DevEnvironmentStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}