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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// In response to the <c>DescribeOrderableReplicationInstances</c> operation, this object
    /// describes an available replication instance. This description includes the replication
    /// instance's type, engine version, and allocated storage.
    /// </summary>
    public partial class OrderableReplicationInstance
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _defaultAllocatedStorage;
        private string _engineVersion;
        private int? _includedAllocatedStorage;
        private int? _maxAllocatedStorage;
        private int? _minAllocatedStorage;
        private ReleaseStatusValues _releaseStatus;
        private string _replicationInstanceClass;
        private string _storageType;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// List of Availability Zones for this replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultAllocatedStorage. 
        /// <para>
        /// The default amount of storage (in gigabytes) that is allocated for the replication
        /// instance.
        /// </para>
        /// </summary>
        public int? DefaultAllocatedStorage
        {
            get { return this._defaultAllocatedStorage; }
            set { this._defaultAllocatedStorage = value; }
        }

        // Check to see if DefaultAllocatedStorage property is set
        internal bool IsSetDefaultAllocatedStorage()
        {
            return this._defaultAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the replication engine.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedAllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) that is allocated for the replication instance.
        /// </para>
        /// </summary>
        public int? IncludedAllocatedStorage
        {
            get { return this._includedAllocatedStorage; }
            set { this._includedAllocatedStorage = value; }
        }

        // Check to see if IncludedAllocatedStorage property is set
        internal bool IsSetIncludedAllocatedStorage()
        {
            return this._includedAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The minimum amount of storage (in gigabytes) that can be allocated for the replication
        /// instance.
        /// </para>
        /// </summary>
        public int? MaxAllocatedStorage
        {
            get { return this._maxAllocatedStorage; }
            set { this._maxAllocatedStorage = value; }
        }

        // Check to see if MaxAllocatedStorage property is set
        internal bool IsSetMaxAllocatedStorage()
        {
            return this._maxAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinAllocatedStorage. 
        /// <para>
        /// The minimum amount of storage (in gigabytes) that can be allocated for the replication
        /// instance.
        /// </para>
        /// </summary>
        public int? MinAllocatedStorage
        {
            get { return this._minAllocatedStorage; }
            set { this._minAllocatedStorage = value; }
        }

        // Check to see if MinAllocatedStorage property is set
        internal bool IsSetMinAllocatedStorage()
        {
            return this._minAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReleaseStatus. 
        /// <para>
        /// The value returned when the specified <c>EngineVersion</c> of the replication instance
        /// is in Beta or test mode. This indicates some features might not work as expected.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the <c>ReleaseStatus</c> parameter in versions 3.1.4 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public ReleaseStatusValues ReleaseStatus
        {
            get { return this._releaseStatus; }
            set { this._releaseStatus = value; }
        }

        // Check to see if ReleaseStatus property is set
        internal bool IsSetReleaseStatus()
        {
            return this._releaseStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the replication instance as defined for the specified
        /// replication instance class. For example to specify the instance class dms.c4.large,
        /// set this parameter to <c>"dms.c4.large"</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information on the settings and capacities for the available replication
        /// instance classes, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_ReplicationInstance.html#CHAP_ReplicationInstance.InDepth">
        /// Selecting the right DMS replication instance for your migration</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public string ReplicationInstanceClass
        {
            get { return this._replicationInstanceClass; }
            set { this._replicationInstanceClass = value; }
        }

        // Check to see if ReplicationInstanceClass property is set
        internal bool IsSetReplicationInstanceClass()
        {
            return this._replicationInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The type of storage used by the replication instance.
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}