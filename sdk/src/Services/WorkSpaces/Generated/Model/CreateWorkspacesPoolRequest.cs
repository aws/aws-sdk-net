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
    /// Container for the parameters to the CreateWorkspacesPool operation.
    /// Creates a pool of WorkSpaces.
    /// </summary>
    public partial class CreateWorkspacesPoolRequest : AmazonWorkSpacesRequest
    {
        private ApplicationSettingsRequest _applicationSettings;
        private string _bundleId;
        private Capacity _capacity;
        private string _description;
        private string _directoryId;
        private string _poolName;
        private PoolsRunningMode _runningMode;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TimeoutSettings _timeoutSettings;

        /// <summary>
        /// Gets and sets the property ApplicationSettings. 
        /// <para>
        /// Indicates the application settings of the pool.
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
        /// The identifier of the bundle for the pool.
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
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The user capacity of the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The pool description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The identifier of the directory for the pool.
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
        /// The running mode for the pool.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the pool.
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

        /// <summary>
        /// Gets and sets the property TimeoutSettings. 
        /// <para>
        /// Indicates the timeout settings of the pool.
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