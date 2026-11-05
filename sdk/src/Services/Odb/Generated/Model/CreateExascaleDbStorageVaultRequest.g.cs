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
    /// Container for the parameters to the CreateExascaleDbStorageVault operation. Creates
    /// an Exascale storage vault. <para> To create the Exascale storage vault on dedicated
    /// Exadata infrastructure, specify <c>cloudExadataInfrastructureId</c>. </para>
    /// </summary>
    public partial class CreateExascaleDbStorageVaultRequest : AmazonOdbRequest
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
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
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
        [AWSProperty(Min = 1, Max = 255)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

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
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier or Amazon Resource Name (ARN) of the Exadata infrastructure
        /// on which to create the Exascale storage vault. Specify this value to create the Exascale
        /// storage vault on dedicated Exadata infrastructure that has Exascale storage configured.
        /// If you specify <c>availabilityZone</c> or <c>availabilityZoneId</c>, the value must
        /// match the Availability Zone of the Exadata infrastructure. If you specify neither,
        /// the service uses the Availability Zone of the Exadata infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the Exascale storage vault.
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
        /// A user-friendly name for the Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property HighCapacityDatabaseStorageTotalSizeInGBs. 
        /// <para>
        /// The total size of the high-capacity database storage, in gigabytes (GB), for the Exascale
        /// storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the Exascale storage vault.
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
        /// The time zone for the Exascale storage vault.
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
