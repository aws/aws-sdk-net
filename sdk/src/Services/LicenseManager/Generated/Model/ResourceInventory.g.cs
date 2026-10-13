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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Details about a resource.
    /// </summary>
    public partial class ResourceInventory
    {
        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// Amazon Machine Image (AMI) ID associated with the resource.
        /// </para>
        /// </summary>
        public string AmiId { get; set; }

        /// <summary>
        /// Checks to see if the AmiId property is set.
        /// </summary>
        internal bool IsSetAmiId() => this.AmiId != null;

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        /// Dedicated Host ID where the resource is running.
        /// </para>
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// Checks to see if the HostId property is set.
        /// </summary>
        internal bool IsSetHostId() => this.HostId != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// EC2 instance type of the resource.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MarketplaceProductCodes. 
        /// <para>
        /// List of Marketplace product codes associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MarketplaceProductCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MarketplaceProductCodes property is set.
        /// </summary>
        internal bool IsSetMarketplaceProductCodes() => this.MarketplaceProductCodes != null && (this.MarketplaceProductCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// Platform of the resource.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// Platform version of the resource in the inventory.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Region where the resource is located.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// ID of the resource.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceOwningAccountId. 
        /// <para>
        /// ID of the account that owns the resource.
        /// </para>
        /// </summary>
        public string ResourceOwningAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwningAccountId property is set.
        /// </summary>
        internal bool IsSetResourceOwningAccountId() => this.ResourceOwningAccountId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Type of resource.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// Usage operation value that corresponds to the license type for billing purposes.
        /// </para>
        /// </summary>
        public string UsageOperation { get; set; }

        /// <summary>
        /// Checks to see if the UsageOperation property is set.
        /// </summary>
        internal bool IsSetUsageOperation() => this.UsageOperation != null;
    }
}
