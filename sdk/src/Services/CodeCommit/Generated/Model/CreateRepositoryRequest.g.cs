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
    /// Container for the parameters to the CreateRepository operation. Creates a new, empty
    /// repository.
    /// </summary>
    public partial class CreateRepositoryRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the encryption key. You can view the ID of an encryption key in the KMS
        /// console, or use the KMS APIs to programmatically retrieve a key ID. For more information
        /// about acceptable values for kmsKeyID, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Decrypt.html#KMS-Decrypt-request-KeyId">KeyId</a>
        /// in the Decrypt API description in the <i> Key Management Service API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// If no key is specified, the default <c>aws/codecommit</c> Amazon Web Services managed
        /// key is used.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property RepositoryDescription. 
        /// <para>
        /// A comment or description about the new repository.
        /// </para>
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string RepositoryDescription { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryDescription property is set.
        /// </summary>
        internal bool IsSetRepositoryDescription() => this.RepositoryDescription != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the new repository to be created.
        /// </para>
        ///  <note> 
        /// <para>
        /// The repository name must be unique across the calling Amazon Web Services account.
        /// Repository names are limited to 100 alphanumeric, dash, and underscore characters,
        /// and cannot include certain characters. For more information about the limits on repository
        /// names, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i> CodeCommit User Guide</i>. The suffix .git is prohibited.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tag key-value pairs to use when tagging this repository.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
