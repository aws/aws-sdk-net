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
    /// Container for the parameters to the UpdateWorkspacesPool operation.
    /// Updates the specified pool.
    /// </summary>
    public partial class UpdateWorkspacesPoolRequest : AmazonWorkSpacesRequest
    {
        private ApplicationSettingsRequest _applicationSettings;
        private string _bundleId;
        private Capacity _capacity;
        private string _description;
        private string _directoryId;
        private string _poolId;
        private PoolsRunningMode _runningMode;
        private TimeoutSettings _timeoutSettings;

        /// <summary>
        /// Gets and sets the property ApplicationSettings. 
        /// <para>
        /// The persistent application settings for users in the pool.
        /// </para>
        /// </summary>
        public ApplicationSettingsRequest ApplicationSettings
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
        /// The identifier of the bundle.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The desired capacity for the pool.
        /// </para>
        /// </summary>
        public Capacity Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the specified pool to update.
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
        /// The identifier of the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=65)]
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
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The identifier of the specified pool to update.
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
        /// Gets and sets the property RunningMode. 
        /// <para>
        /// The desired running mode for the pool. The running mode can only be updated when the
        /// pool is in a stopped state.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TimeoutSettings. 
        /// <para>
        /// Indicates the timeout settings of the specified pool.
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