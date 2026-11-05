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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The resource filter criteria for a Software bill of materials (SBOM) report.
    /// </summary>
    public partial class ResourceFilterCriteria
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account IDs used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> AccountId { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null && (this.AccountId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudContainerImageTags. 
        /// <para>
        /// The cloud container image tags used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> CloudContainerImageTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudContainerImageTags property is set.
        /// </summary>
        internal bool IsSetCloudContainerImageTags() => this.CloudContainerImageTags != null && (this.CloudContainerImageTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudContainerRegistryName. 
        /// <para>
        /// The cloud container registry names used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> CloudContainerRegistryName { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudContainerRegistryName property is set.
        /// </summary>
        internal bool IsSetCloudContainerRegistryName() => this.CloudContainerRegistryName != null && (this.CloudContainerRegistryName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudContainerRepositoryName. 
        /// <para>
        /// The cloud container repository names used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> CloudContainerRepositoryName { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudContainerRepositoryName property is set.
        /// </summary>
        internal bool IsSetCloudContainerRepositoryName() => this.CloudContainerRepositoryName != null && (this.CloudContainerRepositoryName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud providers used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> CloudProvider { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudProvider property is set.
        /// </summary>
        internal bool IsSetCloudProvider() => this.CloudProvider != null && (this.CloudProvider.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudProviderAccountId. 
        /// <para>
        /// The cloud provider account IDs used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> CloudProviderAccountId { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudProviderAccountId property is set.
        /// </summary>
        internal bool IsSetCloudProviderAccountId() => this.CloudProviderAccountId != null && (this.CloudProviderAccountId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudProviderOrgId. 
        /// <para>
        /// The cloud provider organization IDs used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> CloudProviderOrgId { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudProviderOrgId property is set.
        /// </summary>
        internal bool IsSetCloudProviderOrgId() => this.CloudProviderOrgId != null && (this.CloudProviderOrgId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudProviderRegion. 
        /// <para>
        /// The cloud provider regions used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> CloudProviderRegion { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudProviderRegion property is set.
        /// </summary>
        internal bool IsSetCloudProviderRegion() => this.CloudProviderRegion != null && (this.CloudProviderRegion.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudServerlessFunctionName. 
        /// <para>
        /// The cloud serverless function names used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> CloudServerlessFunctionName { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudServerlessFunctionName property is set.
        /// </summary>
        internal bool IsSetCloudServerlessFunctionName() => this.CloudServerlessFunctionName != null && (this.CloudServerlessFunctionName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudServerlessFunctionRuntime. 
        /// <para>
        /// The cloud serverless function runtimes used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> CloudServerlessFunctionRuntime { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudServerlessFunctionRuntime property is set.
        /// </summary>
        internal bool IsSetCloudServerlessFunctionRuntime() => this.CloudServerlessFunctionRuntime != null && (this.CloudServerlessFunctionRuntime.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudServerlessFunctionTags. 
        /// <para>
        /// The cloud serverless function tags used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceMapFilter> CloudServerlessFunctionTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceMapFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudServerlessFunctionTags property is set.
        /// </summary>
        internal bool IsSetCloudServerlessFunctionTags() => this.CloudServerlessFunctionTags != null && (this.CloudServerlessFunctionTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudVmInstanceTags. 
        /// <para>
        /// The cloud VM instance tags used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceMapFilter> CloudVmInstanceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceMapFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudVmInstanceTags property is set.
        /// </summary>
        internal bool IsSetCloudVmInstanceTags() => this.CloudVmInstanceTags != null && (this.CloudVmInstanceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ec2InstanceTags. 
        /// <para>
        /// The EC2 instance tags used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceMapFilter> Ec2InstanceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceMapFilter>() : null;

        /// <summary>
        /// Checks to see if the Ec2InstanceTags property is set.
        /// </summary>
        internal bool IsSetEc2InstanceTags() => this.Ec2InstanceTags != null && (this.Ec2InstanceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EcrImageTags. 
        /// <para>
        /// The ECR image tags used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> EcrImageTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the EcrImageTags property is set.
        /// </summary>
        internal bool IsSetEcrImageTags() => this.EcrImageTags != null && (this.EcrImageTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EcrRepositoryName. 
        /// <para>
        /// The ECR repository names used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> EcrRepositoryName { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the EcrRepositoryName property is set.
        /// </summary>
        internal bool IsSetEcrRepositoryName() => this.EcrRepositoryName != null && (this.EcrRepositoryName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LambdaFunctionName. 
        /// <para>
        /// The Amazon Web Services Lambda function name used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> LambdaFunctionName { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the LambdaFunctionName property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionName() => this.LambdaFunctionName != null && (this.LambdaFunctionName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LambdaFunctionTags. 
        /// <para>
        /// The Amazon Web Services Lambda function tags used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceMapFilter> LambdaFunctionTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceMapFilter>() : null;

        /// <summary>
        /// Checks to see if the LambdaFunctionTags property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionTags() => this.LambdaFunctionTags != null && (this.LambdaFunctionTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource IDs used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> ResourceId { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null && (this.ResourceId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource types used as resource filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceStringFilter> ResourceType { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null && (this.ResourceType.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
