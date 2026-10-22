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
    /// A structure that identifies filter criteria for <c>GetCoverageStatistics</c>.
    /// </summary>
    public partial class CoverageFilterCriteria
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// An array of Amazon Web Services account IDs to return coverage statistics for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> AccountId { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null && (this.AccountId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudContainerImageTags. 
        /// <para>
        /// The cloud container image tags to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CloudContainerImageTags { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudContainerImageTags property is set.
        /// </summary>
        internal bool IsSetCloudContainerImageTags() => this.CloudContainerImageTags != null && (this.CloudContainerImageTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudContainerRegistryName. 
        /// <para>
        /// The cloud container registry name to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CloudContainerRegistryName { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudContainerRegistryName property is set.
        /// </summary>
        internal bool IsSetCloudContainerRegistryName() => this.CloudContainerRegistryName != null && (this.CloudContainerRegistryName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudContainerRepositoryName. 
        /// <para>
        /// The cloud container repository name to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CloudContainerRepositoryName { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudContainerRepositoryName property is set.
        /// </summary>
        internal bool IsSetCloudContainerRepositoryName() => this.CloudContainerRepositoryName != null && (this.CloudContainerRepositoryName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud provider to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CloudProvider { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudProvider property is set.
        /// </summary>
        internal bool IsSetCloudProvider() => this.CloudProvider != null && (this.CloudProvider.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudProviderAccountId. 
        /// <para>
        /// The cloud provider account ID to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CloudProviderAccountId { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudProviderAccountId property is set.
        /// </summary>
        internal bool IsSetCloudProviderAccountId() => this.CloudProviderAccountId != null && (this.CloudProviderAccountId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudProviderOrgId. 
        /// <para>
        /// The cloud provider organization ID to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CloudProviderOrgId { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudProviderOrgId property is set.
        /// </summary>
        internal bool IsSetCloudProviderOrgId() => this.CloudProviderOrgId != null && (this.CloudProviderOrgId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudProviderRegion. 
        /// <para>
        /// The cloud provider region to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CloudProviderRegion { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudProviderRegion property is set.
        /// </summary>
        internal bool IsSetCloudProviderRegion() => this.CloudProviderRegion != null && (this.CloudProviderRegion.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudServerlessFunctionName. 
        /// <para>
        /// The cloud serverless function name to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CloudServerlessFunctionName { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudServerlessFunctionName property is set.
        /// </summary>
        internal bool IsSetCloudServerlessFunctionName() => this.CloudServerlessFunctionName != null && (this.CloudServerlessFunctionName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudServerlessFunctionRuntime. 
        /// <para>
        /// The cloud serverless function runtime to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CloudServerlessFunctionRuntime { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudServerlessFunctionRuntime property is set.
        /// </summary>
        internal bool IsSetCloudServerlessFunctionRuntime() => this.CloudServerlessFunctionRuntime != null && (this.CloudServerlessFunctionRuntime.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudServerlessFunctionTags. 
        /// <para>
        /// The cloud serverless function tags to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageMapFilter> CloudServerlessFunctionTags { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageMapFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudServerlessFunctionTags property is set.
        /// </summary>
        internal bool IsSetCloudServerlessFunctionTags() => this.CloudServerlessFunctionTags != null && (this.CloudServerlessFunctionTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudVmInstanceTags. 
        /// <para>
        /// The cloud VM instance tags to filter coverage results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageMapFilter> CloudVmInstanceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageMapFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudVmInstanceTags property is set.
        /// </summary>
        internal bool IsSetCloudVmInstanceTags() => this.CloudVmInstanceTags != null && (this.CloudVmInstanceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CodeRepositoryProjectName. 
        /// <para>
        /// Filter criteria for code repositories based on project name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CodeRepositoryProjectName { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CodeRepositoryProjectName property is set.
        /// </summary>
        internal bool IsSetCodeRepositoryProjectName() => this.CodeRepositoryProjectName != null && (this.CodeRepositoryProjectName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CodeRepositoryProviderType. 
        /// <para>
        /// Filter criteria for code repositories based on provider type (such as GitHub, GitLab,
        /// etc.).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CodeRepositoryProviderType { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CodeRepositoryProviderType property is set.
        /// </summary>
        internal bool IsSetCodeRepositoryProviderType() => this.CodeRepositoryProviderType != null && (this.CodeRepositoryProviderType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CodeRepositoryProviderTypeVisibility. 
        /// <para>
        /// Filter criteria for code repositories based on visibility setting (public or private).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> CodeRepositoryProviderTypeVisibility { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the CodeRepositoryProviderTypeVisibility property is set.
        /// </summary>
        internal bool IsSetCodeRepositoryProviderTypeVisibility() => this.CodeRepositoryProviderTypeVisibility != null && (this.CodeRepositoryProviderTypeVisibility.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ec2InstanceTags. 
        /// <para>
        /// The Amazon EC2 instance tags to filter on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageMapFilter> Ec2InstanceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageMapFilter>() : null;

        /// <summary>
        /// Checks to see if the Ec2InstanceTags property is set.
        /// </summary>
        internal bool IsSetEc2InstanceTags() => this.Ec2InstanceTags != null && (this.Ec2InstanceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EcrImageInUseCount. 
        /// <para>
        /// The number of Amazon ECR images in use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageNumberFilter> EcrImageInUseCount { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageNumberFilter>() : null;

        /// <summary>
        /// Checks to see if the EcrImageInUseCount property is set.
        /// </summary>
        internal bool IsSetEcrImageInUseCount() => this.EcrImageInUseCount != null && (this.EcrImageInUseCount.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EcrImageLastInUseAt. 
        /// <para>
        /// The Amazon ECR image that was last in use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageDateFilter> EcrImageLastInUseAt { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageDateFilter>() : null;

        /// <summary>
        /// Checks to see if the EcrImageLastInUseAt property is set.
        /// </summary>
        internal bool IsSetEcrImageLastInUseAt() => this.EcrImageLastInUseAt != null && (this.EcrImageLastInUseAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EcrImageTags. 
        /// <para>
        /// The Amazon ECR image tags to filter on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> EcrImageTags { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the EcrImageTags property is set.
        /// </summary>
        internal bool IsSetEcrImageTags() => this.EcrImageTags != null && (this.EcrImageTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EcrRepositoryName. 
        /// <para>
        /// The Amazon ECR repository name to filter on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> EcrRepositoryName { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the EcrRepositoryName property is set.
        /// </summary>
        internal bool IsSetEcrRepositoryName() => this.EcrRepositoryName != null && (this.EcrRepositoryName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImagePulledAt. 
        /// <para>
        /// The date an image was last pulled at.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageDateFilter> ImagePulledAt { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageDateFilter>() : null;

        /// <summary>
        /// Checks to see if the ImagePulledAt property is set.
        /// </summary>
        internal bool IsSetImagePulledAt() => this.ImagePulledAt != null && (this.ImagePulledAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LambdaFunctionName. 
        /// <para>
        /// Returns coverage statistics for Amazon Web Services Lambda functions filtered by function
        /// names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> LambdaFunctionName { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the LambdaFunctionName property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionName() => this.LambdaFunctionName != null && (this.LambdaFunctionName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LambdaFunctionRuntime. 
        /// <para>
        /// Returns coverage statistics for Amazon Web Services Lambda functions filtered by runtime.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> LambdaFunctionRuntime { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the LambdaFunctionRuntime property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionRuntime() => this.LambdaFunctionRuntime != null && (this.LambdaFunctionRuntime.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LambdaFunctionTags. 
        /// <para>
        /// Returns coverage statistics for Amazon Web Services Lambda functions filtered by tag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageMapFilter> LambdaFunctionTags { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageMapFilter>() : null;

        /// <summary>
        /// Checks to see if the LambdaFunctionTags property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionTags() => this.LambdaFunctionTags != null && (this.LambdaFunctionTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastScannedAt. 
        /// <para>
        /// Filters Amazon Web Services resources based on whether Amazon Inspector has checked
        /// them for vulnerabilities within the specified time range.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageDateFilter> LastScannedAt { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageDateFilter>() : null;

        /// <summary>
        /// Checks to see if the LastScannedAt property is set.
        /// </summary>
        internal bool IsSetLastScannedAt() => this.LastScannedAt != null && (this.LastScannedAt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastScannedCommitId. 
        /// <para>
        /// Filter criteria for code repositories based on the ID of the last scanned commit.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> LastScannedCommitId { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the LastScannedCommitId property is set.
        /// </summary>
        internal bool IsSetLastScannedCommitId() => this.LastScannedCommitId != null && (this.LastScannedCommitId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// An array of Amazon Web Services resource IDs to return coverage statistics for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> ResourceId { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null && (this.ResourceId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// An array of Amazon Web Services resource types to return coverage statistics for.
        /// The values can be <c>AWS_EC2_INSTANCE</c>, <c>AWS_LAMBDA_FUNCTION</c>, <c>AWS_ECR_CONTAINER_IMAGE</c>,
        /// <c>AWS_ECR_REPOSITORY</c> or <c>AWS_ACCOUNT</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> ResourceType { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null && (this.ResourceType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The filter to search for Amazon EC2 instance coverage by scan mode. Valid values are
        /// <c>EC2_SSM_AGENT_BASED</c>, <c>EC2_AGENTLESS</c>, and <c>EC2_INSPECTOR_AGENT_BASED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> ScanMode { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanMode property is set.
        /// </summary>
        internal bool IsSetScanMode() => this.ScanMode != null && (this.ScanMode.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanStatusCode. 
        /// <para>
        /// The scan status code to filter on. Valid values are: <c>ValidationException</c>, <c>InternalServerException</c>,
        /// <c>ResourceNotFoundException</c>, <c>BadRequestException</c>, and <c>ThrottlingException</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> ScanStatusCode { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanStatusCode property is set.
        /// </summary>
        internal bool IsSetScanStatusCode() => this.ScanStatusCode != null && (this.ScanStatusCode.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanStatusReason. 
        /// <para>
        /// The scan status reason to filter on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> ScanStatusReason { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanStatusReason property is set.
        /// </summary>
        internal bool IsSetScanStatusReason() => this.ScanStatusReason != null && (this.ScanStatusReason.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// An array of Amazon Inspector scan types to return coverage statistics for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CoverageStringFilter> ScanType { get; set; } = AWSConfigs.InitializeCollections ? new List<CoverageStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null && (this.ScanType.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
