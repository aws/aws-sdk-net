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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains details about an additional storage volume for a DB instance. RDS support
    /// additional storage volumes for RDS for Oracle and RDS for SQL Server.
    /// </summary>
    public partial class AdditionalStorageVolume
    {
        private int? _allocatedStorage;
        private int? _iops;
        private int? _maxAllocatedStorage;
        private int? _storageThroughput;
        private string _storageType;
        private string _volumeName;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage allocated for the additional storage volume, in gibibytes (GiB).
        /// The minimum is 20 GiB. The maximum is 65,536 GiB (64 TiB).
        /// </para>
        /// </summary>
        public int? AllocatedStorage
        {
            get { return this._allocatedStorage; }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IOPS. 
        /// <para>
        /// The number of I/O operations per second (IOPS) provisioned for the additional storage
        /// volume.
        /// </para>
        /// </summary>
        public int? IOPS
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if IOPS property is set
        internal bool IsSetIOPS()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit in gibibytes (GiB) to which RDS can automatically scale the storage
        /// of the additional storage volume.
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
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput value for the additional storage volume, in mebibytes per second
        /// (MiBps). This setting applies only to the General Purpose SSD (<c>gp3</c>) storage
        /// type.
        /// </para>
        /// </summary>
        public int? StorageThroughput
        {
            get { return this._storageThroughput; }
            set { this._storageThroughput = value; }
        }

        // Check to see if StorageThroughput property is set
        internal bool IsSetStorageThroughput()
        {
            return this._storageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type for the additional storage volume.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>GP3 | IO2</c> 
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

        /// <summary>
        /// Gets and sets the property VolumeName. 
        /// <para>
        /// The name of the additional storage volume.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>RDSDBDATA2 | RDSDBDATA3 | RDSDBDATA4</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VolumeName
        {
            get { return this._volumeName; }
            set { this._volumeName = value; }
        }

        // Check to see if VolumeName property is set
        internal bool IsSetVolumeName()
        {
            return this._volumeName != null;
        }

    }
}