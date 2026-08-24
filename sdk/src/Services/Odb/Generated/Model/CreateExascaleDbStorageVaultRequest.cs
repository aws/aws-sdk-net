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
    /// Container for the parameters to the CreateExascaleDbStorageVault operation.
    /// Creates an Exascale storage vault.
    /// </summary>
    public partial class CreateExascaleDbStorageVaultRequest : AmazonOdbRequest
    {
        private int? _additionalFlashCacheInPercent;
        private int? _autoscaleLimitInGBs;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _clientToken;
        private string _description;
        private string _displayName;
        private int? _highCapacityDatabaseStorageTotalSizeInGBs;
        private bool? _isAutoscaleEnabled;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _timeZone;

        /// <summary>
        /// Gets and sets the property AdditionalFlashCacheInPercent. 
        /// <para>
        /// The additional flash cache percentage for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property AutoscaleLimitInGBs. 
        /// <para>
        /// The autoscale limit in gigabytes (GB) for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        [AWSProperty(Min=1, Max=255)]
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
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the Amazon Web Services SDK automatically
        /// generates one and uses it for the request to ensure idempotency. The client token
        /// is valid for up to 24 hours after it's first used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=400)]
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
        /// A user-friendly name for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property HighCapacityDatabaseStorageTotalSizeInGBs. 
        /// <para>
        /// The total size of the high-capacity database storage, in gigabytes (GB), for the Exascale
        /// storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? HighCapacityDatabaseStorageTotalSizeInGBs
        {
            get { return this._highCapacityDatabaseStorageTotalSizeInGBs; }
            set { this._highCapacityDatabaseStorageTotalSizeInGBs = value; }
        }

        // Check to see if HighCapacityDatabaseStorageTotalSizeInGBs property is set
        internal bool IsSetHighCapacityDatabaseStorageTotalSizeInGBs()
        {
            return this._highCapacityDatabaseStorageTotalSizeInGBs.HasValue; 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the Exascale storage vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

    }
}