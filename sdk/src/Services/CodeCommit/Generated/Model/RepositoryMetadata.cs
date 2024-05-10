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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Information about a repository.
    /// </summary>
    public partial class RepositoryMetadata
    {
        private string _accountId;
        private string _arn;
        private string _cloneUrlHttp;
        private string _cloneUrlSsh;
        private DateTime? _creationDate;
        private string _defaultBranch;
        private string _kmsKeyId;
        private DateTime? _lastModifiedDate;
        private string _repositoryDescription;
        private string _repositoryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account associated with the repository.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the repository.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CloneUrlHttp. 
        /// <para>
        /// The URL to use for cloning the repository over HTTPS.
        /// </para>
        /// </summary>
        public string CloneUrlHttp
        {
            get { return this._cloneUrlHttp; }
            set { this._cloneUrlHttp = value; }
        }

        // Check to see if CloneUrlHttp property is set
        internal bool IsSetCloneUrlHttp()
        {
            return this._cloneUrlHttp != null;
        }

        /// <summary>
        /// Gets and sets the property CloneUrlSsh. 
        /// <para>
        /// The URL to use for cloning the repository over SSH.
        /// </para>
        /// </summary>
        public string CloneUrlSsh
        {
            get { return this._cloneUrlSsh; }
            set { this._cloneUrlSsh = value; }
        }

        // Check to see if CloneUrlSsh property is set
        internal bool IsSetCloneUrlSsh()
        {
            return this._cloneUrlSsh != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the repository was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultBranch. 
        /// <para>
        /// The repository's default branch name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DefaultBranch
        {
            get { return this._defaultBranch; }
            set { this._defaultBranch = value; }
        }

        // Check to see if DefaultBranch property is set
        internal bool IsSetDefaultBranch()
        {
            return this._defaultBranch != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service encryption key used to encrypt and decrypt the
        /// repository.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time the repository was last modified, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RepositoryDescription. 
        /// <para>
        /// A comment or description about the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string RepositoryDescription
        {
            get { return this._repositoryDescription; }
            set { this._repositoryDescription = value; }
        }

        // Check to see if RepositoryDescription property is set
        internal bool IsSetRepositoryDescription()
        {
            return this._repositoryDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryId. 
        /// <para>
        /// The ID of the repository.
        /// </para>
        /// </summary>
        public string RepositoryId
        {
            get { return this._repositoryId; }
            set { this._repositoryId = value; }
        }

        // Check to see if RepositoryId property is set
        internal bool IsSetRepositoryId()
        {
            return this._repositoryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

    }
}