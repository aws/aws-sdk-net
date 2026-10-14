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
    /// Container for the parameters to the CreateCloudVmCluster operation. Creates a VM cluster
    /// on the specified Exadata infrastructure.
    /// </summary>
    public partial class CreateCloudVmClusterRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency. The client
        /// token is valid for up to 24 hours after it's first used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier of the Exadata infrastructure for this VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A name for the Grid Infrastructure cluster. The name isn't case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 11)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property CpuCoreCount. 
        /// <para>
        /// The number of CPU cores to enable on the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public int? CpuCoreCount { get; set; }

        /// <summary>
        /// Checks to see if the CpuCoreCount property is set.
        /// </summary>
        internal bool IsSetCpuCoreCount() => this.CpuCoreCount.HasValue;

        /// <summary>
        /// Gets and sets the property DataCollectionOptions. 
        /// <para>
        /// The set of preferences for the various diagnostic collection options for the VM cluster.
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
        /// The size of the data disk group, in terabytes (TBs), to allocate for the VM cluster.
        /// </para>
        /// </summary>
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
        public int? DbNodeStorageSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the DbNodeStorageSizeInGBs property is set.
        /// </summary>
        internal bool IsSetDbNodeStorageSizeInGBs() => this.DbNodeStorageSizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property DbServers. 
        /// <para>
        /// The list of database servers for the VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> DbServers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DbServers property is set.
        /// </summary>
        internal bool IsSetDbServers() => this.DbServers != null && (this.DbServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A user-friendly name for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property GiVersion. 
        /// <para>
        /// A valid software version of Oracle Grid Infrastructure (GI). To get the list of valid
        /// values, use the <c>ListGiVersions</c> operation and specify the shape of the Exadata
        /// infrastructure.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>19.0.0.0</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GiVersion { get; set; }

        /// <summary>
        /// Checks to see if the GiVersion property is set.
        /// </summary>
        internal bool IsSetGiVersion() => this.GiVersion != null;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name for the VM cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be "localhost" or "hostname".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't contain "-version".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of the combined hostname and domain is 63 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The hostname must be unique within the subnet.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 12)]
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property IsLocalBackupEnabled. 
        /// <para>
        /// Specifies whether to enable database backups to local Exadata storage for the VM cluster.
        /// </para>
        /// </summary>
        public bool? IsLocalBackupEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsLocalBackupEnabled property is set.
        /// </summary>
        internal bool IsSetIsLocalBackupEnabled() => this.IsLocalBackupEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsSparseDiskgroupEnabled. 
        /// <para>
        /// Specifies whether to create a sparse disk group for the VM cluster.
        /// </para>
        /// </summary>
        public bool? IsSparseDiskgroupEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsSparseDiskgroupEnabled property is set.
        /// </summary>
        internal bool IsSetIsSparseDiskgroupEnabled() => this.IsSparseDiskgroupEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the VM cluster.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>LICENSE_INCLUDED</c> 
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
        public int? MemorySizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the MemorySizeInGBs property is set.
        /// </summary>
        internal bool IsSetMemorySizeInGBs() => this.MemorySizeInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string OdbNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkId property is set.
        /// </summary>
        internal bool IsSetOdbNetworkId() => this.OdbNetworkId != null;

        /// <summary>
        /// Gets and sets the property ScanListenerPortTcp. 
        /// <para>
        /// The port number for TCP connections to the single client access name (SCAN) listener.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>1024–8999</c> with the following exceptions: <c>2484</c>, <c>6100</c>,
        /// <c>6200</c>, <c>7060</c>, <c>7070</c>, <c>7085</c>, and <c>7879</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1521</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024, Max = 8999)]
        public int? ScanListenerPortTcp { get; set; }

        /// <summary>
        /// Checks to see if the ScanListenerPortTcp property is set.
        /// </summary>
        internal bool IsSetScanListenerPortTcp() => this.ScanListenerPortTcp.HasValue;

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
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public List<string> SshPublicKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SshPublicKeys property is set.
        /// </summary>
        internal bool IsSetSshPublicKeys() => this.SshPublicKeys != null && (this.SshPublicKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SystemVersion. 
        /// <para>
        /// The version of the operating system of the image for the VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SystemVersion { get; set; }

        /// <summary>
        /// Checks to see if the SystemVersion property is set.
        /// </summary>
        internal bool IsSetSystemVersion() => this.SystemVersion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the VM cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone for the VM cluster. For a list of valid values for time zone, you can
        /// check the options in the console.
        /// </para>
        ///  
        /// <para>
        /// Default: UTC
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;
    }
}
