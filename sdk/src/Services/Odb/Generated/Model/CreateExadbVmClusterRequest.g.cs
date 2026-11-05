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
    /// Container for the parameters to the CreateExadbVmCluster operation. Creates an Exascale
    /// VM cluster.
    /// </summary>
    public partial class CreateExadbVmClusterRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If you submit the same request twice with the same
        /// client token, the service ignores the second request and returns the result of the
        /// first. If you don't specify a client token, the AWS SDK automatically generates one.
        /// The client token is valid for up to 24 hours after it's first used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        /// Gets and sets the property DataCollectionOptions. 
        /// <para>
        /// The set of preferences for the various diagnostic collection options for the Exascale
        /// VM cluster.
        /// </para>
        /// </summary>
        public DataCollectionOptions DataCollectionOptions { get; set; }

        /// <summary>
        /// Checks to see if the DataCollectionOptions property is set.
        /// </summary>
        internal bool IsSetDataCollectionOptions() => this.DataCollectionOptions != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A user-friendly name for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EnabledEcpuCount. 
        /// <para>
        /// The number of ECPUs to enable for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? EnabledEcpuCount { get; set; }

        /// <summary>
        /// Checks to see if the EnabledEcpuCount property is set.
        /// </summary>
        internal bool IsSetEnabledEcpuCount() => this.EnabledEcpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property ExascaleDbStorageVaultId. 
        /// <para>
        /// The unique identifier of the Exascale storage vault for this Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string ExascaleDbStorageVaultId { get; set; }

        /// <summary>
        /// Checks to see if the ExascaleDbStorageVaultId property is set.
        /// </summary>
        internal bool IsSetExascaleDbStorageVaultId() => this.ExascaleDbStorageVaultId != null;

        /// <summary>
        /// Gets and sets the property GridImageId. 
        /// <para>
        /// The Grid Infrastructure software image ID for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GridImageId { get; set; }

        /// <summary>
        /// Checks to see if the GridImageId property is set.
        /// </summary>
        internal bool IsSetGridImageId() => this.GridImageId != null;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 12)]
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The Oracle license model to apply to the Exascale VM cluster.
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property NodeCount. 
        /// <para>
        /// The number of nodes in the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// Checks to see if the NodeCount property is set.
        /// </summary>
        internal bool IsSetNodeCount() => this.NodeCount.HasValue;

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network for the Exascale VM cluster.
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
        /// The port number for TCP connections to the Single Client Access Name (SCAN) listener.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024, Max = 8999)]
        public int? ScanListenerPortTcp { get; set; }

        /// <summary>
        /// Checks to see if the ScanListenerPortTcp property is set.
        /// </summary>
        internal bool IsSetScanListenerPortTcp() => this.ScanListenerPortTcp.HasValue;

        /// <summary>
        /// Gets and sets the property ScanListenerPortTcpSsl. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024, Max = 8999)]
        public int? ScanListenerPortTcpSsl { get; set; }

        /// <summary>
        /// Checks to see if the ScanListenerPortTcpSsl property is set.
        /// </summary>
        internal bool IsSetScanListenerPortTcpSsl() => this.ScanListenerPortTcpSsl.HasValue;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The shape of the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Shape { get; set; }

        /// <summary>
        /// Checks to see if the Shape property is set.
        /// </summary>
        internal bool IsSetShape() => this.Shape != null;

        /// <summary>
        /// Gets and sets the property ShapeAttribute. 
        /// <para>
        /// The shape attribute for the Exascale VM cluster.
        /// </para>
        /// </summary>
        public ShapeAttribute ShapeAttribute { get; set; }

        /// <summary>
        /// Checks to see if the ShapeAttribute property is set.
        /// </summary>
        internal bool IsSetShapeAttribute() => this.ShapeAttribute != null;

        /// <summary>
        /// Gets and sets the property SshPublicKeys. 
        /// <para>
        /// The public key portion of one or more key pairs used for SSH access to the Exascale
        /// VM cluster.
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
        /// The version of the operating system of the image for the Exascale VM cluster.
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
        /// The list of resource tags to apply to the Exascale VM cluster.
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
        /// The time zone for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;

        /// <summary>
        /// Gets and sets the property TotalEcpuCount. 
        /// <para>
        /// The total number of ECPUs for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2)]
        public int? TotalEcpuCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalEcpuCount property is set.
        /// </summary>
        internal bool IsSetTotalEcpuCount() => this.TotalEcpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property VmFileSystemStorageTotalSizeInGBs. 
        /// <para>
        /// The total amount of file system storage, in gigabytes (GB), for the Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? VmFileSystemStorageTotalSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the VmFileSystemStorageTotalSizeInGBs property is set.
        /// </summary>
        internal bool IsSetVmFileSystemStorageTotalSizeInGBs() => this.VmFileSystemStorageTotalSizeInGBs.HasValue;
    }
}
