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
 * Do not modify this file. This file is generated from the codeconnections-2023-12-01.normal.json service model.
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
    /// Container for the parameters to the UpdateRepositoryLink operation.
    /// Updates the association between your connection and a specified external Git repository.
    /// A repository link allows Git sync to monitor and sync changes to files in a specified
    /// Git repository.
    /// </summary>
    public partial class UpdateRepositoryLinkRequest : AmazonCodeConnectionsRequest
    {
        private string _connectionArn;
        private string _encryptionKeyArn;
        private string _repositoryLinkId;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection for the repository link to be updated.
        /// The updated connection ARN must have the same providerType (such as GitHub) as the
        /// original connection ARN for the repo link.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// The Amazon Resource Name (ARN) of the encryption key for the repository link to be
        /// updated.
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
        /// Gets and sets the property RepositoryLinkId. 
        /// <para>
        /// The ID of the repository link to be updated.
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

    }
}