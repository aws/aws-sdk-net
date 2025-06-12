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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a pool of WorkSpaces.
    /// </summary>
    public partial class WorkspacesPool
    {
        private ApplicationSettingsResponse _applicationSettings;
        private string _bundleId;
        private CapacityStatus _capacityStatus;
        private DateTime? _createdAt;
        private string _description;
        private string _directoryId;
        private List<WorkspacesPoolError> _errors = AWSConfigs.InitializeCollections ? new List<WorkspacesPoolError>() : null;
        private string _poolArn;
        private string _poolId;
        private string _poolName;
        private PoolsRunningMode _runningMode;
        private WorkspacesPoolState _state;
        private TimeoutSettings _timeoutSettings;

        /// <summary>
        /// Gets and sets the property ApplicationSettings. 
        /// <para>
        /// The persistent application settings for users of the pool.
        /// </para>
        /// </summary>
        public ApplicationSettingsResponse ApplicationSettings
        {
            get { return this._applicationSettings; }
            set { this._applicationSettings = value; }
        }

        // Check to see if ApplicationSettings property is set
        internal bool IsSetApplicationSettings()
        {
            return this._applicationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the bundle used by the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityStatus. 
        /// <para>
        /// The capacity status for the pool
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityStatus CapacityStatus
        {
            get { return this._capacityStatus; }
            set { this._capacityStatus = value; }
        }

        // Check to see if CapacityStatus property is set
        internal bool IsSetCapacityStatus()
        {
            return this._capacityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the pool was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory used by the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=65)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// The pool errors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WorkspacesPoolError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PoolArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PoolArn
        {
            get { return this._poolArn; }
            set { this._poolArn = value; }
        }

        // Check to see if PoolArn property is set
        internal bool IsSetPoolArn()
        {
            return this._poolArn != null;
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The identifier of a pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PoolName
        {
            get { return this._poolName; }
            set { this._poolName = value; }
        }

        // Check to see if PoolName property is set
        internal bool IsSetPoolName()
        {
            return this._poolName != null;
        }

        /// <summary>
        /// Gets and sets the property RunningMode. 
        /// <para>
        /// The running mode of the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PoolsRunningMode RunningMode
        {
            get { return this._runningMode; }
            set { this._runningMode = value; }
        }

        // Check to see if RunningMode property is set
        internal bool IsSetRunningMode()
        {
            return this._runningMode != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkspacesPoolState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutSettings. 
        /// <para>
        /// The amount of time that a pool session remains active after users disconnect. If they
        /// try to reconnect to the pool session after a disconnection or network interruption
        /// within this time interval, they are connected to their previous session. Otherwise,
        /// they are connected to a new session with a new pool instance.
        /// </para>
        /// </summary>
        public TimeoutSettings TimeoutSettings
        {
            get { return this._timeoutSettings; }
            set { this._timeoutSettings = value; }
        }

        // Check to see if TimeoutSettings property is set
        internal bool IsSetTimeoutSettings()
        {
            return this._timeoutSettings != null;
        }

    }
}