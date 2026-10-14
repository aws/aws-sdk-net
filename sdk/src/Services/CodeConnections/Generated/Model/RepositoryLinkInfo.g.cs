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

namespace Amazon.CodeConnections.Model
{
    /// <summary>
    /// Information about the repository link resource, such as the repository link ARN, the
    /// associated connection ARN, encryption key ARN, and owner ID.
    /// </summary>
    public partial class RepositoryLinkInfo
    {
        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection associated with the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionArn property is set.
        /// </summary>
        internal bool IsSetConnectionArn() => this.ConnectionArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the encryption key for the repository associated
        /// with the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner ID for the repository associated with the repository link, such as the owner
        /// ID in GitHub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The provider type for the connection, such as GitHub, associated with the repository
        /// link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property RepositoryLinkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RepositoryLinkArn { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryLinkArn property is set.
        /// </summary>
        internal bool IsSetRepositoryLinkArn() => this.RepositoryLinkArn != null;

        /// <summary>
        /// Gets and sets the property RepositoryLinkId. 
        /// <para>
        /// The ID of the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RepositoryLinkId { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryLinkId property is set.
        /// </summary>
        internal bool IsSetRepositoryLinkId() => this.RepositoryLinkId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository associated with the repository link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
