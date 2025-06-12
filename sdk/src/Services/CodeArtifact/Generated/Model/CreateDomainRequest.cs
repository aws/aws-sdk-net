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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomain operation.
    /// Creates a domain. CodeArtifact <i>domains</i> make it easier to manage multiple repositories
    /// across an organization. You can use a domain to apply permissions across many repositories
    /// owned by different Amazon Web Services accounts. An asset is stored only once in a
    /// domain, even if it's in multiple repositories. 
    /// 
    ///  
    /// <para>
    /// Although you can have multiple domains, we recommend a single production domain that
    /// contains all published artifacts so that your development teams can find and share
    /// packages. You can use a second pre-production domain to test changes to the production
    /// domain configuration. 
    /// </para>
    /// </summary>
    public partial class CreateDomainRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _encryptionKey;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain to create. All domain names in an Amazon Web Services Region
        /// that are in the same Amazon Web Services account must be unique. The domain name is
        /// used as the prefix in DNS hostnames. Do not use sensitive information in a domain
        /// name because it is publicly discoverable. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        ///  The encryption key for the domain. This is used to encrypt content stored in a domain.
        /// An encryption key can be a key ID, a key Amazon Resource Name (ARN), a key alias,
        /// or a key alias ARN. To specify an <c>encryptionKey</c>, your IAM role must have <c>kms:DescribeKey</c>
        /// and <c>kms:CreateGrant</c> permissions on the encryption key that is used. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestSyntax">DescribeKey</a>
        /// in the <i>Key Management Service API Reference</i> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">Key
        /// Management Service API Permissions Reference</a> in the <i>Key Management Service
        /// Developer Guide</i>. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  CodeArtifact supports only symmetric CMKs. Do not associate an asymmetric CMK with
        /// your domain. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// symmetric and asymmetric keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tag key-value pairs for the domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}