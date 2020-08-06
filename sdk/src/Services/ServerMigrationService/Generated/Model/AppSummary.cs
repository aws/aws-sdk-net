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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Information about the application.
    /// </summary>
    public partial class AppSummary
    {
        private string _appId;
        private DateTime? _creationTime;
        private string _description;
        private string _importedAppId;
        private DateTime? _lastModified;
        private DateTime? _latestReplicationTime;
        private AppLaunchConfigurationStatus _launchConfigurationStatus;
        private LaunchDetails _launchDetails;
        private AppLaunchStatus _launchStatus;
        private string _launchStatusMessage;
        private string _name;
        private AppReplicationConfigurationStatus _replicationConfigurationStatus;
        private AppReplicationStatus _replicationStatus;
        private string _replicationStatusMessage;
        private string _roleName;
        private AppStatus _status;
        private string _statusMessage;
        private int? _totalServerGroups;
        private int? _totalServers;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID of the application.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the application.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ImportedAppId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        public string ImportedAppId
        {
            get { return this._importedAppId; }
            set { this._importedAppId = value; }
        }

        // Check to see if ImportedAppId property is set
        internal bool IsSetImportedAppId()
        {
            return this._importedAppId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The last modified time of the application.
        /// </para>
        /// </summary>
        public DateTime LastModified
        {
            get { return this._lastModified.GetValueOrDefault(); }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestReplicationTime. 
        /// <para>
        /// The timestamp of the application's most recent successful replication.
        /// </para>
        /// </summary>
        public DateTime LatestReplicationTime
        {
            get { return this._latestReplicationTime.GetValueOrDefault(); }
            set { this._latestReplicationTime = value; }
        }

        // Check to see if LatestReplicationTime property is set
        internal bool IsSetLatestReplicationTime()
        {
            return this._latestReplicationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationStatus. 
        /// <para>
        /// Status of the launch configuration.
        /// </para>
        /// </summary>
        public AppLaunchConfigurationStatus LaunchConfigurationStatus
        {
            get { return this._launchConfigurationStatus; }
            set { this._launchConfigurationStatus = value; }
        }

        // Check to see if LaunchConfigurationStatus property is set
        internal bool IsSetLaunchConfigurationStatus()
        {
            return this._launchConfigurationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchDetails. 
        /// <para>
        /// Details about the latest launch of the application.
        /// </para>
        /// </summary>
        public LaunchDetails LaunchDetails
        {
            get { return this._launchDetails; }
            set { this._launchDetails = value; }
        }

        // Check to see if LaunchDetails property is set
        internal bool IsSetLaunchDetails()
        {
            return this._launchDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchStatus. 
        /// <para>
        /// The launch status of the application.
        /// </para>
        /// </summary>
        public AppLaunchStatus LaunchStatus
        {
            get { return this._launchStatus; }
            set { this._launchStatus = value; }
        }

        // Check to see if LaunchStatus property is set
        internal bool IsSetLaunchStatus()
        {
            return this._launchStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchStatusMessage. 
        /// <para>
        /// A message related to the launch status of the application.
        /// </para>
        /// </summary>
        public string LaunchStatusMessage
        {
            get { return this._launchStatusMessage; }
            set { this._launchStatusMessage = value; }
        }

        // Check to see if LaunchStatusMessage property is set
        internal bool IsSetLaunchStatusMessage()
        {
            return this._launchStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationConfigurationStatus. 
        /// <para>
        /// Status of the replication configuration.
        /// </para>
        /// </summary>
        public AppReplicationConfigurationStatus ReplicationConfigurationStatus
        {
            get { return this._replicationConfigurationStatus; }
            set { this._replicationConfigurationStatus = value; }
        }

        // Check to see if ReplicationConfigurationStatus property is set
        internal bool IsSetReplicationConfigurationStatus()
        {
            return this._replicationConfigurationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// The replication status of the application.
        /// </para>
        /// </summary>
        public AppReplicationStatus ReplicationStatus
        {
            get { return this._replicationStatus; }
            set { this._replicationStatus = value; }
        }

        // Check to see if ReplicationStatus property is set
        internal bool IsSetReplicationStatus()
        {
            return this._replicationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatusMessage. 
        /// <para>
        /// A message related to the replication status of the application.
        /// </para>
        /// </summary>
        public string ReplicationStatusMessage
        {
            get { return this._replicationStatusMessage; }
            set { this._replicationStatusMessage = value; }
        }

        // Check to see if ReplicationStatusMessage property is set
        internal bool IsSetReplicationStatusMessage()
        {
            return this._replicationStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the service role in the customer's account used by AWS SMS.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the application.
        /// </para>
        /// </summary>
        public AppStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message related to the status of the application
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TotalServerGroups. 
        /// <para>
        /// The number of server groups present in the application.
        /// </para>
        /// </summary>
        public int TotalServerGroups
        {
            get { return this._totalServerGroups.GetValueOrDefault(); }
            set { this._totalServerGroups = value; }
        }

        // Check to see if TotalServerGroups property is set
        internal bool IsSetTotalServerGroups()
        {
            return this._totalServerGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalServers. 
        /// <para>
        /// The number of servers present in the application.
        /// </para>
        /// </summary>
        public int TotalServers
        {
            get { return this._totalServers.GetValueOrDefault(); }
            set { this._totalServers = value; }
        }

        // Check to see if TotalServers property is set
        internal bool IsSetTotalServers()
        {
            return this._totalServers.HasValue; 
        }

    }
}