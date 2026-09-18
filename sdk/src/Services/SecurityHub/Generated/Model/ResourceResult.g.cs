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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides comprehensive details about an Amazon Web Services resource and its associated
    /// security findings.
    /// </summary>
    public partial class ResourceResult
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account that recorded the resource data in Security Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of the Amazon Web Services account that's associated with the resource.
        /// </para>
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property DiscoveryType. 
        /// <para>
        /// Specifies how the resource was discovered. If the value is <c>Managed</c>, the resource
        /// is natively provided by a cloud service provider. If the value is <c>SelfHosted</c>,
        /// the resource is hosted on customer-managed infrastructure, such as a compute instance
        /// or container image.
        /// </para>
        /// </summary>
        public DiscoveryType DiscoveryType { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryType property is set.
        /// </summary>
        internal bool IsSetDiscoveryType() => this.DiscoveryType != null;

        /// <summary>
        /// Gets and sets the property FindingsSummary. 
        /// <para>
        /// An aggregated view of security findings associated with a resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceFindingsSummary> FindingsSummary { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceFindingsSummary>() : null;

        /// <summary>
        /// Checks to see if the FindingsSummary property is set.
        /// </summary>
        internal bool IsSetFindingsSummary() => this.FindingsSummary != null && (this.FindingsSummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region that recorded the resource data in Security Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceCategory. 
        /// <para>
        /// The grouping where the resource belongs.
        /// </para>
        /// </summary>
        public ResourceCategory ResourceCategory { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCategory property is set.
        /// </summary>
        internal bool IsSetResourceCategory() => this.ResourceCategory != null;

        /// <summary>
        /// Gets and sets the property ResourceCloudPartition. 
        /// <para>
        /// The cloud partition where the resource exists. For Amazon Web Services, valid values
        /// include <c>aws</c>, <c>aws-cn</c>, and <c>aws-us-gov</c>. This field isn't returned
        /// for cloud providers that don't use partitions.
        /// </para>
        /// </summary>
        public string ResourceCloudPartition { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCloudPartition property is set.
        /// </summary>
        internal bool IsSetResourceCloudPartition() => this.ResourceCloudPartition != null;

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The configuration details of a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document ResourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfig property is set.
        /// </summary>
        internal bool IsSetResourceConfig() => !this.ResourceConfig.IsNull();

        /// <summary>
        /// Gets and sets the property ResourceCreationTimeDt. 
        /// <para>
        /// The time when the resource was created.
        /// </para>
        /// </summary>
        public string ResourceCreationTimeDt { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCreationTimeDt property is set.
        /// </summary>
        internal bool IsSetResourceCreationTimeDt() => this.ResourceCreationTimeDt != null;

        /// <summary>
        /// Gets and sets the property ResourceDetailCaptureTimeDt. 
        /// <para>
        /// The timestamp when information about the resource was captured.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceDetailCaptureTimeDt { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDetailCaptureTimeDt property is set.
        /// </summary>
        internal bool IsSetResourceDetailCaptureTimeDt() => this.ResourceDetailCaptureTimeDt != null;

        /// <summary>
        /// Gets and sets the property ResourceGuid. 
        /// <para>
        /// The global identifier used to identify a resource.
        /// </para>
        /// </summary>
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGuid property is set.
        /// </summary>
        internal bool IsSetResourceGuid() => this.ResourceGuid != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique identifier for a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceInfo. 
        /// <para>
        /// Additional resource-type-specific details. For self-hosted AI resources and their
        /// host resources, contains an <c>AIDetails</c> structure.
        /// </para>
        /// </summary>
        public ResourceInfo ResourceInfo { get; set; }

        /// <summary>
        /// Checks to see if the ResourceInfo property is set.
        /// </summary>
        internal bool IsSetResourceInfo() => this.ResourceInfo != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccountId. 
        /// <para>
        /// The identifier of the cloud account that owns the resource. For Amazon Web Services
        /// resources, this is the Amazon Web Services account ID. For Azure resources, this is
        /// the Azure subscription ID.
        /// </para>
        /// </summary>
        public string ResourceOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerAccountId() => this.ResourceOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerOrgId. 
        /// <para>
        /// The identifier of the cloud organization that owns the resource. For Amazon Web Services
        /// resources, this is the Organizations ID. For Azure resources, this is the Azure tenant
        /// ID.
        /// </para>
        /// </summary>
        public string ResourceOwnerOrgId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerOrgId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerOrgId() => this.ResourceOwnerOrgId != null;

        /// <summary>
        /// Gets and sets the property ResourceProvider. 
        /// <para>
        /// The cloud provider where the resource exists. Valid values are <c>AWS</c> and <c>Azure</c>.
        /// This field is always included.
        /// </para>
        /// </summary>
        public string ResourceProvider { get; set; }

        /// <summary>
        /// Checks to see if the ResourceProvider property is set.
        /// </summary>
        internal bool IsSetResourceProvider() => this.ResourceProvider != null;

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The native cloud region where the resource is located. For Amazon Web Services, this
        /// is an Amazon Web Services Region (for example, <c>us-east-1</c>). For Azure resources,
        /// this is the Azure region (for example, <c>westus2</c>). This field is always included.
        /// </para>
        /// </summary>
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;

        /// <summary>
        /// Gets and sets the property ResourceSubCategory. 
        /// <para>
        /// The AI/ML sub-grouping of the resource. Present only when <c>ResourceCategory</c>
        /// is <c>AI/ML</c>.
        /// </para>
        /// </summary>
        public ResourceSubCategory ResourceSubCategory { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSubCategory property is set.
        /// </summary>
        internal bool IsSetResourceSubCategory() => this.ResourceSubCategory != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The key-value pairs associated with a resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
