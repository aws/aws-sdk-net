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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRepository operation. Creates a repository.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Repositories.html">Amazon
    /// ECR repositories</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </summary>
    public partial class CreateRepositoryRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the repository. This determines how the contents
        /// of your repository are encrypted at rest.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. <important> 
        /// <para>
        /// The <c>imageScanningConfiguration</c> parameter is being deprecated, in favor of specifying
        /// the image scanning configuration at the registry level. For more information, see
        /// <c>PutRegistryScanningConfiguration</c>.
        /// </para>
        ///  </important> 
        /// <para>
        /// The image scanning configuration for the repository. This determines whether images
        /// are scanned for known vulnerabilities after being pushed to the repository.
        /// </para>
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageScanningConfiguration property is set.
        /// </summary>
        internal bool IsSetImageScanningConfiguration() => this.ImageScanningConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageTagMutability. 
        /// <para>
        /// The tag mutability setting for the repository. If this parameter is omitted, the default
        /// setting of <c>MUTABLE</c> will be used which will allow image tags to be overwritten.
        /// If <c>IMMUTABLE</c> is specified, all image tags within the repository will be immutable
        /// which will prevent them from being overwritten.
        /// </para>
        /// </summary>
        public ImageTagMutability ImageTagMutability { get; set; }

        /// <summary>
        /// Checks to see if the ImageTagMutability property is set.
        /// </summary>
        internal bool IsSetImageTagMutability() => this.ImageTagMutability != null;

        /// <summary>
        /// Gets and sets the property ImageTagMutabilityExclusionFilters. 
        /// <para>
        /// A list of filters that specify which image tags should be excluded from the repository's
        /// image tag mutability setting.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<ImageTagMutabilityExclusionFilter> ImageTagMutabilityExclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<ImageTagMutabilityExclusionFilter>() : null;

        /// <summary>
        /// Checks to see if the ImageTagMutabilityExclusionFilters property is set.
        /// </summary>
        internal bool IsSetImageTagMutabilityExclusionFilters() => this.ImageTagMutabilityExclusionFilters != null && (this.ImageTagMutabilityExclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry to create the repository.
        /// If you do not specify a registry, the default registry is assumed.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name to use for the repository. The repository name may be specified on its own
        /// (such as <c>nginx-web-app</c>) or it can be prepended with a namespace to group the
        /// repository into a category (such as <c>project-a/nginx-web-app</c>).
        /// </para>
        ///  
        /// <para>
        /// The repository name must start with a letter and can only contain lowercase letters,
        /// numbers, hyphens, underscores, and forward slashes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the repository to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.
        /// Tag keys can have a maximum character length of 128 characters, and tag values can
        /// have a maximum length of 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
