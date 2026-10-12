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
    /// Information about an Exascale storage vault.
    /// </summary>
    public partial class ExascaleDbStorageVault
    {
        /// <summary>
        /// Gets and sets the property AdditionalFlashCacheInPercent. 
        /// <para>
        /// The additional flash cache percentage for the Exascale storage vault.
        /// </para>
        /// </summary>
        public int? AdditionalFlashCacheInPercent { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalFlashCacheInPercent property is set.
        /// </summary>
        internal bool IsSetAdditionalFlashCacheInPercent() => this.AdditionalFlashCacheInPercent.HasValue;

        /// <summary>
        /// Gets and sets the property AttachedShapeAttributes. 
        /// <para>
        /// The list of shape attributes attached to the Exascale storage vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttachedShapeAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttachedShapeAttributes property is set.
        /// </summary>
        internal bool IsSetAttachedShapeAttributes() => this.AttachedShapeAttributes != null && (this.AttachedShapeAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoscaleLimitInGBs. 
        /// <para>
        /// The autoscale limit in gigabytes (GB) for the Exascale storage vault.
        /// </para>
        /// </summary>
        public int? AutoscaleLimitInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AutoscaleLimitInGBs property is set.
        /// </summary>
        internal bool IsSetAutoscaleLimitInGBs() => this.AutoscaleLimitInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the Exascale storage vault.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID for the Exascale storage vault.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Exascale storage vault was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Exascale storage vault.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name for the Exascale storage vault.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ExascaleDbStorageVaultArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExascaleDbStorageVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the ExascaleDbStorageVaultArn property is set.
        /// </summary>
        internal bool IsSetExascaleDbStorageVaultArn() => this.ExascaleDbStorageVaultArn != null;

        /// <summary>
        /// Gets and sets the property ExascaleDbStorageVaultId. 
        /// <para>
        /// The unique identifier of the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string ExascaleDbStorageVaultId { get; set; }

        /// <summary>
        /// Checks to see if the ExascaleDbStorageVaultId property is set.
        /// </summary>
        internal bool IsSetExascaleDbStorageVaultId() => this.ExascaleDbStorageVaultId != null;

        /// <summary>
        /// Gets and sets the property HighCapacityDatabaseStorage. 
        /// <para>
        /// The high-capacity database storage details for the Exascale storage vault.
        /// </para>
        /// </summary>
        public ExascaleDbStorageDetails HighCapacityDatabaseStorage { get; set; }

        /// <summary>
        /// Checks to see if the HighCapacityDatabaseStorage property is set.
        /// </summary>
        internal bool IsSetHighCapacityDatabaseStorage() => this.HighCapacityDatabaseStorage != null;

        /// <summary>
        /// Gets and sets the property IsAutoscaleEnabled. 
        /// <para>
        /// Specifies whether autoscaling is enabled for the Exascale storage vault.
        /// </para>
        /// </summary>
        public bool? IsAutoscaleEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsAutoscaleEnabled property is set.
        /// </summary>
        internal bool IsSetIsAutoscaleEnabled() => this.IsAutoscaleEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor for the Exascale storage vault.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName { get; set; }

        /// <summary>
        /// Checks to see if the OciResourceAnchorName property is set.
        /// </summary>
        internal bool IsSetOciResourceAnchorName() => this.OciResourceAnchorName != null;

        /// <summary>
        /// Gets and sets the property OciUrl. 
        /// <para>
        /// The HTTPS link to the Exascale storage vault in Oracle Cloud Infrastructure (OCI).
        /// </para>
        /// </summary>
        public string OciUrl { get; set; }

        /// <summary>
        /// Checks to see if the OciUrl property is set.
        /// </summary>
        internal bool IsSetOciUrl() => this.OciUrl != null;

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The OCID of the Exascale storage vault.
        /// </para>
        /// </summary>
        public string Ocid { get; set; }

        /// <summary>
        /// Checks to see if the Ocid property is set.
        /// </summary>
        internal bool IsSetOcid() => this.Ocid != null;

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The amount of progress made on the current operation on the Exascale storage vault,
        /// expressed as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Exascale storage vault.
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the status of the Exascale storage vault.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone of the Exascale storage vault.
        /// </para>
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;

        /// <summary>
        /// Gets and sets the property VmClusterArns. 
        /// <para>
        /// The list of Amazon Resource Names (ARNs) of the VM clusters associated with this Exascale
        /// storage vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VmClusterArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VmClusterArns property is set.
        /// </summary>
        internal bool IsSetVmClusterArns() => this.VmClusterArns != null && (this.VmClusterArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VmClusterCount. 
        /// <para>
        /// The number of VM clusters associated with this Exascale storage vault.
        /// </para>
        /// </summary>
        public int? VmClusterCount { get; set; }

        /// <summary>
        /// Checks to see if the VmClusterCount property is set.
        /// </summary>
        internal bool IsSetVmClusterCount() => this.VmClusterCount.HasValue;

        /// <summary>
        /// Gets and sets the property VmClusterIds. 
        /// <para>
        /// The list of unique identifiers of the VM clusters associated with this Exascale storage
        /// vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VmClusterIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VmClusterIds property is set.
        /// </summary>
        internal bool IsSetVmClusterIds() => this.VmClusterIds != null && (this.VmClusterIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
