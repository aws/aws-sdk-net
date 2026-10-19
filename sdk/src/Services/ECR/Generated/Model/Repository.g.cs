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
    /// An object representing a repository.
    /// </summary>
    public partial class Repository
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the repository was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

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
        /// Gets and sets the property ImageScanningConfiguration.
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageScanningConfiguration property is set.
        /// </summary>
        internal bool IsSetImageScanningConfiguration() => this.ImageScanningConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageTagMutability. 
        /// <para>
        /// The tag mutability setting for the repository.
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
        /// A list of filters that specify which image tags are excluded from the repository's
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
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// repository.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the repository. The ARN contains the
        /// <c>arn:aws:ecr</c> namespace, followed by the region of the repository, Amazon Web
        /// Services account ID of the repository owner, repository namespace, and repository
        /// name. For example, <c>arn:aws:ecr:region:012345678910:repository-namespace/repository-name</c>.
        /// </para>
        /// </summary>
        public string RepositoryArn { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryArn property is set.
        /// </summary>
        internal bool IsSetRepositoryArn() => this.RepositoryArn != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property RepositoryUri. 
        /// <para>
        /// The URI for the repository. You can use this URI for container image <c>push</c> and
        /// <c>pull</c> operations.
        /// </para>
        /// </summary>
        public string RepositoryUri { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryUri property is set.
        /// </summary>
        internal bool IsSetRepositoryUri() => this.RepositoryUri != null;
    }
}
