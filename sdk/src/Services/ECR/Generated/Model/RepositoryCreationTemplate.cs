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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
        private List<string> _appliedFor = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private string _customRoleArn;
        private string _description;
        private EncryptionConfigurationForRepositoryCreationTemplate _encryptionConfiguration;
        private ImageTagMutability _imageTagMutability;
        private string _lifecyclePolicy;
        private string _prefix;
        private string _repositoryPolicy;
        private List<Tag> _resourceTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AppliedFor. 
        /// <para>
        /// A list of enumerable Strings representing the repository creation scenarios that this
        /// template will apply towards. The two supported scenarios are PULL_THROUGH_CACHE and
        /// REPLICATION
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AppliedFor
        {
            get { return this._appliedFor; }
            set { this._appliedFor = value; }
        }

        // Check to see if AppliedFor property is set
        internal bool IsSetAppliedFor()
        {
            return this._appliedFor != null && (this._appliedFor.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the repository creation template
        /// was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomRoleArn. 
        /// <para>
        /// The ARN of the role to be assumed by Amazon ECR. Amazon ECR will assume your supplied
        /// role when the customRoleArn is specified. When this field isn't specified, Amazon
        /// ECR will use the service-linked role for the repository creation template.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string CustomRoleArn
        {
            get { return this._customRoleArn; }
            set { this._customRoleArn = value; }
        }

        // Check to see if CustomRoleArn property is set
        internal bool IsSetCustomRoleArn()
        {
            return this._customRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description associated with the repository creation template.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration associated with the repository creation template.
        /// </para>
        /// </summary>
        public EncryptionConfigurationForRepositoryCreationTemplate EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTagMutability. 
        /// <para>
        /// The tag mutability setting for the repository. If this parameter is omitted, the default
        /// setting of <c>MUTABLE</c> will be used which will allow image tags to be overwritten.
        /// If <c>IMMUTABLE</c> is specified, all image tags within the repository will be immutable
        /// which will prevent them from being overwritten.
        /// </para>
        /// </summary>
        public ImageTagMutability ImageTagMutability
        {
            get { return this._imageTagMutability; }
            set { this._imageTagMutability = value; }
        }

        // Check to see if ImageTagMutability property is set
        internal bool IsSetImageTagMutability()
        {
            return this._imageTagMutability != null;
        }

        /// <summary>
        /// Gets and sets the property LifecyclePolicy. 
        /// <para>
        /// The lifecycle policy to use for repositories created using the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30720)]
        public string LifecyclePolicy
        {
            get { return this._lifecyclePolicy; }
            set { this._lifecyclePolicy = value; }
        }

        // Check to see if LifecyclePolicy property is set
        internal bool IsSetLifecyclePolicy()
        {
            return this._lifecyclePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The repository namespace prefix associated with the repository creation template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryPolicy. 
        /// <para>
        /// The repository policy to apply to repositories created using the template. A repository
        /// policy is a permissions policy associated with a repository to control access permissions.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10240)]
        public string RepositoryPolicy
        {
            get { return this._repositoryPolicy; }
            set { this._repositoryPolicy = value; }
        }

        // Check to see if RepositoryPolicy property is set
        internal bool IsSetRepositoryPolicy()
        {
            return this._repositoryPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The metadata to apply to the repository to help you categorize and organize. Each
        /// tag consists of a key and an optional value, both of which you define. Tag keys can
        /// have a maximum character length of 128 characters, and tag values can have a maximum
        /// length of 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the repository creation template
        /// was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}