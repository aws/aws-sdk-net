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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Contains details about the modification of an additional storage volume.
    /// </summary>
    public partial class ModifyAdditionalStorageVolume
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage allocated for the additional storage volume, in gibibytes (GiB).
        /// The minimum is 20 GiB. The maximum is 65,536 GiB (64 TiB).
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property IOPS. 
        /// <para>
        /// The number of I/O operations per second (IOPS) provisioned for the additional storage
        /// volume. This setting is only supported for Provisioned IOPS SSD (<c>io1</c> and <c>io2</c>)
        /// storage types.
        /// </para>
        /// </summary>
        public int? IOPS { get; set; }

        /// <summary>
        /// Checks to see if the IOPS property is set.
        /// </summary>
        internal bool IsSetIOPS() => this.IOPS.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit in gibibytes (GiB) to which RDS can automatically scale the storage
        /// of the additional storage volume. You must provide a value greater than or equal to
        /// <c>AllocatedStorage</c>.
        /// </para>
        /// </summary>
        public int? MaxAllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllocatedStorage property is set.
        /// </summary>
        internal bool IsSetMaxAllocatedStorage() => this.MaxAllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property SetForDelete. 
        /// <para>
        /// Indicates whether to delete the additional storage volume. The value <c>true</c> schedules
        /// the volume for deletion. You can delete an additional storage volume only when it
        /// doesn't contain database files or other data.
        /// </para>
        /// </summary>
        public bool? SetForDelete { get; set; }

        /// <summary>
        /// Checks to see if the SetForDelete property is set.
        /// </summary>
        internal bool IsSetSetForDelete() => this.SetForDelete.HasValue;

        /// <summary>
        /// Gets and sets the property StorageThroughput. 
        /// <para>
        /// The storage throughput value for the additional storage volume, in mebibytes per second
        /// (MiBps). This setting applies only to the General Purpose SSD (<c>gp3</c>) storage
        /// type.
        /// </para>
        /// </summary>
        public int? StorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the StorageThroughput property is set.
        /// </summary>
        internal bool IsSetStorageThroughput() => this.StorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The new storage type for the additional storage volume.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>GP3 | IO2</c> 
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property VolumeName. 
        /// <para>
        /// The name of the additional storage volume that you want to modify.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>RDSDBDATA2 | RDSDBDATA3 | RDSDBDATA4</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VolumeName { get; set; }

        /// <summary>
        /// Checks to see if the VolumeName property is set.
        /// </summary>
        internal bool IsSetVolumeName() => this.VolumeName != null;
    }
}
