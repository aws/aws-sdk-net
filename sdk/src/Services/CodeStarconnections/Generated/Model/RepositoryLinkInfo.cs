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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
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
namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// Information about the repository link resource, such as the repository link ARN, the
    /// associated connection ARN, encryption key ARN, and owner ID.
    /// </summary>
    public partial class RepositoryLinkInfo
    {
        private string _connectionArn;
        private string _encryptionKeyArn;
        private string _ownerId;
        private ProviderType _providerType;
        private string _repositoryLinkArn;
        private string _repositoryLinkId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection associated with the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the encryption key for the repository associated
        /// with the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner ID for the repository associated with the repository link, such as the owner
        /// ID in GitHub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The provider type for the connection, such as GitHub, associated with the repository
        /// link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProviderType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryLinkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RepositoryLinkArn
        {
            get { return this._repositoryLinkArn; }
            set { this._repositoryLinkArn = value; }
        }

        // Check to see if RepositoryLinkArn property is set
        internal bool IsSetRepositoryLinkArn()
        {
            return this._repositoryLinkArn != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryLinkId. 
        /// <para>
        /// The ID of the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RepositoryLinkId
        {
            get { return this._repositoryLinkId; }
            set { this._repositoryLinkId = value; }
        }

        // Check to see if RepositoryLinkId property is set
        internal bool IsSetRepositoryLinkId()
        {
            return this._repositoryLinkId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository associated with the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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