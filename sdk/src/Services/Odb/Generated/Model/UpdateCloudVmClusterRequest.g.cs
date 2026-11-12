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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCloudVmCluster operation. Updates the properties
    /// of the specified VM cluster.
    /// </summary>
    public partial class UpdateCloudVmClusterRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property CloudVmClusterId. 
        /// <para>
        /// The unique identifier of the VM cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 64)]
        public string CloudVmClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CloudVmClusterId property is set.
        /// </summary>
        internal bool IsSetCloudVmClusterId() => this.CloudVmClusterId != null;

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores to enable on the VM cluster. If you don't specify a value,
        /// the existing number of CPU cores is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CpuCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCount property is set.
        /// </summary>
        internal bool IsSetCpuCoreCount() => this.CpuCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property DataCollectionOptions. 
        /// <para>
        /// The set of preferences for the diagnostic collection options for the VM cluster.
        /// </para>
        /// </summary>
        public DataCollectionOptions DataCollectionOptions { get; set; }

        /// <summary>
        /// Checks to see if the DataCollectionOptions property is set.
        /// </summary>
        internal bool IsSetDataCollectionOptions() => this.DataCollectionOptions != null;

        /// <summary>
        /// Gets and sets the property DataStorageSizeInTBs. 
        /// <para>
        /// The size of the data disk group, in terabytes (TB), to allocate for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? DataStorageSizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the DataStorageSizeInTBs property is set.
        /// </summary>
        internal bool IsSetDataStorageSizeInTBs() => this.DataStorageSizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property DbNodeStorageSizeInGBs. 
        /// <para>
        /// The amount of local node storage, in gigabytes (GB), to allocate for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DbNodeStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DbNodeStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDbNodeStorageSizeInGBs() => this.DbNodeStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A new user-friendly name for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the VM cluster.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property MemorySizeInGBs. 
        /// <para>
        /// The amount of memory, in gigabytes (GB), to allocate for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MemorySizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeInGBs property is set.
        /// </summary>
        internal bool IsSetMemorySizeInGBs() => this.MemorySizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property SshPublicKeys. 
        /// <para>
        /// The public key portion of one or more key pairs used for SSH access to the VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> SshPublicKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SshPublicKeys property is set.
        /// </summary>
        internal bool IsSetSshPublicKeys() => this.SshPublicKeys != null && (this.SshPublicKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageSizeInGBs. 
        /// <para>
        /// The amount of local node storage, in gigabytes (GB), to allocate to the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? StorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the StorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetStorageSizeInGBs() => this.StorageSizeInGBs.HasValue;
    }
}
