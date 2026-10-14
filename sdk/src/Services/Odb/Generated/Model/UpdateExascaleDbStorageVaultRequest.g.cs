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
    /// Container for the parameters to the UpdateExascaleDbStorageVault operation. Updates
    /// the specified Exascale storage vault.
    /// </summary>
    public partial class UpdateExascaleDbStorageVaultRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalFlashCacheInPercent. 
        /// <para>
        /// The additional flash cache percentage for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AdditionalFlashCacheInPercent { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalFlashCacheInPercent property is set.
        /// </summary>
        internal bool IsSetAdditionalFlashCacheInPercent() => this.AdditionalFlashCacheInPercent.HasValue;

        /// <summary>
        /// Gets and sets the property AutoscaleLimitInGBs. 
        /// <para>
        /// The autoscale limit in gigabytes (GB) for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AutoscaleLimitInGBs { get; set; }

        /// <summary>
        /// Checks to see if the AutoscaleLimitInGBs property is set.
        /// </summary>
        internal bool IsSetAutoscaleLimitInGBs() => this.AutoscaleLimitInGBs.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 400)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A new user-friendly name for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ExascaleDbStorageVaultId. 
        /// <para>
        /// The unique identifier of the Exascale storage vault to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string ExascaleDbStorageVaultId { get; set; }

        /// <summary>
        /// Checks to see if the ExascaleDbStorageVaultId property is set.
        /// </summary>
        internal bool IsSetExascaleDbStorageVaultId() => this.ExascaleDbStorageVaultId != null;

        /// <summary>
        /// Gets and sets the property HighCapacityDatabaseStorageTotalSizeInGBs. 
        /// <para>
        /// The total size of the high-capacity database storage, in gigabytes (GB), for the Exascale
        /// storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? HighCapacityDatabaseStorageTotalSizeInGBs { get; set; }

        /// <summary>
        /// Checks to see if the HighCapacityDatabaseStorageTotalSizeInGBs property is set.
        /// </summary>
        internal bool IsSetHighCapacityDatabaseStorageTotalSizeInGBs() => this.HighCapacityDatabaseStorageTotalSizeInGBs.HasValue;

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
    }
}
