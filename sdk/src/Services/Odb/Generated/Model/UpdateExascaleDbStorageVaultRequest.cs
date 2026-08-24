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
    /// Container for the parameters to the UpdateExascaleDbStorageVault operation.
    /// Updates the specified Exascale storage vault.
    /// </summary>
    public partial class UpdateExascaleDbStorageVaultRequest : AmazonOdbRequest
    {
        private int? _additionalFlashCacheInPercent;
        private int? _autoscaleLimitInGBs;
        private string _description;
        private string _displayName;
        private string _exascaleDbStorageVaultId;
        private int? _highCapacityDatabaseStorageTotalSizeInGBs;
        private bool? _isAutoscaleEnabled;

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
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the Exascale storage vault.
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
        /// A new user-friendly name for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ExascaleDbStorageVaultId. 
        /// <para>
        /// The unique identifier of the Exascale storage vault to update.
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
        /// Gets and sets the property HighCapacityDatabaseStorageTotalSizeInGBs. 
        /// <para>
        /// The total size of the high-capacity database storage, in gigabytes (GB), for the Exascale
        /// storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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

    }
}