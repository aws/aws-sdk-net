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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing a repository.
    /// </summary>
    public partial class Repository
    {
        private DateTime? _createdAt;
        private EncryptionConfiguration _encryptionConfiguration;
        private ImageScanningConfiguration _imageScanningConfiguration;
        private ImageTagMutability _imageTagMutability;
        private string _registryId;
        private string _repositoryArn;
        private string _repositoryName;
        private string _repositoryUri;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the repository was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the repository. This determines how the contents
        /// of your repository are encrypted at rest.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
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
        /// Gets and sets the property ImageScanningConfiguration.
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration
        {
            get { return this._imageScanningConfiguration; }
            set { this._imageScanningConfiguration = value; }
        }

        // Check to see if ImageScanningConfiguration property is set
        internal bool IsSetImageScanningConfiguration()
        {
            return this._imageScanningConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTagMutability. 
        /// <para>
        /// The tag mutability setting for the repository.
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
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The AWS account ID associated with the registry that contains the repository.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the repository. The ARN contains the
        /// <code>arn:aws:ecr</code> namespace, followed by the region of the repository, AWS
        /// account ID of the repository owner, repository namespace, and repository name. For
        /// example, <code>arn:aws:ecr:region:012345678910:repository/test</code>.
        /// </para>
        /// </summary>
        public string RepositoryArn
        {
            get { return this._repositoryArn; }
            set { this._repositoryArn = value; }
        }

        // Check to see if RepositoryArn property is set
        internal bool IsSetRepositoryArn()
        {
            return this._repositoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryUri. 
        /// <para>
        /// The URI for the repository. You can use this URI for container image <code>push</code>
        /// and <code>pull</code> operations.
        /// </para>
        /// </summary>
        public string RepositoryUri
        {
            get { return this._repositoryUri; }
            set { this._repositoryUri = value; }
        }

        // Check to see if RepositoryUri property is set
        internal bool IsSetRepositoryUri()
        {
            return this._repositoryUri != null;
        }

    }
}