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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private int? _additionalFlashCacheInPercent;
        private List<string> _attachedShapeAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _autoscaleLimitInGBs;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private DateTime? _createdAt;
        private string _description;
        private string _displayName;
        private string _exascaleDbStorageVaultArn;
        private string _exascaleDbStorageVaultId;
        private ExascaleDbStorageDetails _highCapacityDatabaseStorage;
        private bool? _isAutoscaleEnabled;
        private string _ocid;
        private string _ociResourceAnchorName;
        private string _ociUrl;
        private float? _percentProgress;
        private ResourceStatus _status;
        private string _statusReason;
        private string _timeZone;
        private List<string> _vmClusterArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _vmClusterCount;
        private List<string> _vmClusterIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalFlashCacheInPercent. 
        /// <para>
        /// The additional flash cache percentage for the Exascale storage vault.
        /// </para>
        /// </summary>
        public int? AdditionalFlashCacheInPercent
        {
            get { return this._additionalFlashCacheInPercent; }
            set { this._additionalFlashCacheInPercent = value; }
        }

        // Check to see if AdditionalFlashCacheInPercent property is set
        internal bool IsSetAdditionalFlashCacheInPercent()
        {
            return this._additionalFlashCacheInPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AttachedShapeAttributes. 
        /// <para>
        /// The list of shape attributes attached to the Exascale storage vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttachedShapeAttributes
        {
            get { return this._attachedShapeAttributes; }
            set { this._attachedShapeAttributes = value; }
        }

        // Check to see if AttachedShapeAttributes property is set
        internal bool IsSetAttachedShapeAttributes()
        {
            return this._attachedShapeAttributes != null && (this._attachedShapeAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoscaleLimitInGBs. 
        /// <para>
        /// The autoscale limit in gigabytes (GB) for the Exascale storage vault.
        /// </para>
        /// </summary>
        public int? AutoscaleLimitInGBs
        {
            get { return this._autoscaleLimitInGBs; }
            set { this._autoscaleLimitInGBs = value; }
        }

        // Check to see if AutoscaleLimitInGBs property is set
        internal bool IsSetAutoscaleLimitInGBs()
        {
            return this._autoscaleLimitInGBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the Exascale storage vault.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID for the Exascale storage vault.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Exascale storage vault was created.
        /// </para>
        /// </summary>
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
        /// The description of the Exascale storage vault.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name for the Exascale storage vault.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property ExascaleDbStorageVaultArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExascaleDbStorageVaultArn
        {
            get { return this._exascaleDbStorageVaultArn; }
            set { this._exascaleDbStorageVaultArn = value; }
        }

        // Check to see if ExascaleDbStorageVaultArn property is set
        internal bool IsSetExascaleDbStorageVaultArn()
        {
            return this._exascaleDbStorageVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExascaleDbStorageVaultId. 
        /// <para>
        /// The unique identifier of the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string ExascaleDbStorageVaultId
        {
            get { return this._exascaleDbStorageVaultId; }
            set { this._exascaleDbStorageVaultId = value; }
        }

        // Check to see if ExascaleDbStorageVaultId property is set
        internal bool IsSetExascaleDbStorageVaultId()
        {
            return this._exascaleDbStorageVaultId != null;
        }

        /// <summary>
        /// Gets and sets the property HighCapacityDatabaseStorage. 
        /// <para>
        /// The high-capacity database storage details for the Exascale storage vault.
        /// </para>
        /// </summary>
        public ExascaleDbStorageDetails HighCapacityDatabaseStorage
        {
            get { return this._highCapacityDatabaseStorage; }
            set { this._highCapacityDatabaseStorage = value; }
        }

        // Check to see if HighCapacityDatabaseStorage property is set
        internal bool IsSetHighCapacityDatabaseStorage()
        {
            return this._highCapacityDatabaseStorage != null;
        }

        /// <summary>
        /// Gets and sets the property IsAutoscaleEnabled. 
        /// <para>
        /// Specifies whether autoscaling is enabled for the Exascale storage vault.
        /// </para>
        /// </summary>
        public bool? IsAutoscaleEnabled
        {
            get { return this._isAutoscaleEnabled; }
            set { this._isAutoscaleEnabled = value; }
        }

        // Check to see if IsAutoscaleEnabled property is set
        internal bool IsSetIsAutoscaleEnabled()
        {
            return this._isAutoscaleEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The OCID of the Exascale storage vault.
        /// </para>
        /// </summary>
        public string Ocid
        {
            get { return this._ocid; }
            set { this._ocid = value; }
        }

        // Check to see if Ocid property is set
        internal bool IsSetOcid()
        {
            return this._ocid != null;
        }

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor for the Exascale storage vault.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName
        {
            get { return this._ociResourceAnchorName; }
            set { this._ociResourceAnchorName = value; }
        }

        // Check to see if OciResourceAnchorName property is set
        internal bool IsSetOciResourceAnchorName()
        {
            return this._ociResourceAnchorName != null;
        }

        /// <summary>
        /// Gets and sets the property OciUrl. 
        /// <para>
        /// The HTTPS link to the Exascale storage vault in Oracle Cloud Infrastructure (OCI).
        /// </para>
        /// </summary>
        public string OciUrl
        {
            get { return this._ociUrl; }
            set { this._ociUrl = value; }
        }

        // Check to see if OciUrl property is set
        internal bool IsSetOciUrl()
        {
            return this._ociUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The amount of progress made on the current operation on the Exascale storage vault,
        /// expressed as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress
        {
            get { return this._percentProgress; }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Exascale storage vault.
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the status of the Exascale storage vault.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone of the Exascale storage vault.
        /// </para>
        /// </summary>
        public string TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

        /// <summary>
        /// Gets and sets the property VmClusterArns. 
        /// <para>
        /// The list of Amazon Resource Names (ARNs) of the VM clusters associated with this Exascale
        /// storage vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VmClusterArns
        {
            get { return this._vmClusterArns; }
            set { this._vmClusterArns = value; }
        }

        // Check to see if VmClusterArns property is set
        internal bool IsSetVmClusterArns()
        {
            return this._vmClusterArns != null && (this._vmClusterArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VmClusterCount. 
        /// <para>
        /// The number of VM clusters associated with this Exascale storage vault.
        /// </para>
        /// </summary>
        public int? VmClusterCount
        {
            get { return this._vmClusterCount; }
            set { this._vmClusterCount = value; }
        }

        // Check to see if VmClusterCount property is set
        internal bool IsSetVmClusterCount()
        {
            return this._vmClusterCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VmClusterIds. 
        /// <para>
        /// The list of unique identifiers of the VM clusters associated with this Exascale storage
        /// vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VmClusterIds
        {
            get { return this._vmClusterIds; }
            set { this._vmClusterIds = value; }
        }

        // Check to see if VmClusterIds property is set
        internal bool IsSetVmClusterIds()
        {
            return this._vmClusterIds != null && (this._vmClusterIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}