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
    /// The details of the repository creation template associated with the request.
    /// </summary>
    public partial class RepositoryCreationTemplate
    {
        /// <summary>
        /// Gets and sets the property AppliedFor. 
        /// <para>
        /// A list of enumerable Strings representing the repository creation scenarios that this
        /// template will apply towards. The supported scenarios are PULL_THROUGH_CACHE, REPLICATION,
        /// and CREATE_ON_PUSH
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AppliedFor { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AppliedFor property is set.
        /// </summary>
        internal bool IsSetAppliedFor() => this.AppliedFor != null && (this.AppliedFor.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the repository creation template
        /// was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomRoleArn. 
        /// <para>
        /// The ARN of the role to be assumed by Amazon ECR. Amazon ECR will assume your supplied
        /// role when the customRoleArn is specified. When this field isn't specified, Amazon
        /// ECR will use the service-linked role for the repository creation template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string CustomRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomRoleArn property is set.
        /// </summary>
        internal bool IsSetCustomRoleArn() => this.CustomRoleArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description associated with the repository creation template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration associated with the repository creation template.
        /// </para>
        /// </summary>
        public EncryptionConfigurationForRepositoryCreationTemplate EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

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
        /// A list of filters that specify which image tags are excluded from the repository creation
        /// template's image tag mutability setting.
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
        /// Gets and sets the property LifecyclePolicy. 
        /// <para>
        /// The lifecycle policy to use for repositories created using the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 30720)]
        public string LifecyclePolicy { get; set; }

        /// <summary>
        /// Checks to see if the LifecyclePolicy property is set.
        /// </summary>
        internal bool IsSetLifecyclePolicy() => this.LifecyclePolicy != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The repository namespace prefix associated with the repository creation template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property RepositoryPolicy. 
        /// <para>
        /// The repository policy to apply to repositories created using the template. A repository
        /// policy is a permissions policy associated with a repository to control access permissions.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10240)]
        public string RepositoryPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryPolicy property is set.
        /// </summary>
        internal bool IsSetRepositoryPolicy() => this.RepositoryPolicy != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The metadata to apply to the repository to help you categorize and organize. Each
        /// tag consists of a key and an optional value, both of which you define. Tag keys can
        /// have a maximum character length of 128 characters, and tag values can have a maximum
        /// length of 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the repository creation template
        /// was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
