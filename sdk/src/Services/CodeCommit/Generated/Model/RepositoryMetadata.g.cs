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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Information about a repository.
    /// </summary>
    public partial class RepositoryMetadata
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account associated with the repository.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the repository.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CloneUrlHttp. 
        /// <para>
        /// The URL to use for cloning the repository over HTTPS.
        /// </para>
        /// </summary>
        public string CloneUrlHttp { get; set; }

        /// <summary>
        /// Checks to see if the CloneUrlHttp property is set.
        /// </summary>
        internal bool IsSetCloneUrlHttp() => this.CloneUrlHttp != null;

        /// <summary>
        /// Gets and sets the property CloneUrlSsh. 
        /// <para>
        /// The URL to use for cloning the repository over SSH.
        /// </para>
        /// </summary>
        public string CloneUrlSsh { get; set; }

        /// <summary>
        /// Checks to see if the CloneUrlSsh property is set.
        /// </summary>
        internal bool IsSetCloneUrlSsh() => this.CloneUrlSsh != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the repository was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultBranch. 
        /// <para>
        /// The repository's default branch name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// Checks to see if the DefaultBranch property is set.
        /// </summary>
        internal bool IsSetDefaultBranch() => this.DefaultBranch != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service encryption key used to encrypt and decrypt the
        /// repository.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time the repository was last modified, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property RepositoryDescription. 
        /// <para>
        /// A comment or description about the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string RepositoryDescription { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryDescription property is set.
        /// </summary>
        internal bool IsSetRepositoryDescription() => this.RepositoryDescription != null;

        /// <summary>
        /// Gets and sets the property RepositoryId. 
        /// <para>
        /// The ID of the repository.
        /// </para>
        /// </summary>
        public string RepositoryId { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryId property is set.
        /// </summary>
        internal bool IsSetRepositoryId() => this.RepositoryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
