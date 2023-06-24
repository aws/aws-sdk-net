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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFileSystemAssociation operation.
    /// Updates a file system association. This operation is only supported in the FSx File
    /// Gateways.
    /// </summary>
    public partial class UpdateFileSystemAssociationRequest : AmazonStorageGatewayRequest
    {
        private string _auditDestinationARN;
        private CacheAttributes _cacheAttributes;
        private string _fileSystemAssociationARN;
        private string _password;
        private string _userName;

        /// <summary>
        /// Gets and sets the property AuditDestinationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the storage used for the audit logs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string AuditDestinationARN
        {
            get { return this._auditDestinationARN; }
            set { this._auditDestinationARN = value; }
        }

        // Check to see if AuditDestinationARN property is set
        internal bool IsSetAuditDestinationARN()
        {
            return this._auditDestinationARN != null;
        }

        /// <summary>
        /// Gets and sets the property CacheAttributes.
        /// </summary>
        public CacheAttributes CacheAttributes
        {
            get { return this._cacheAttributes; }
            set { this._cacheAttributes = value; }
        }

        // Check to see if CacheAttributes property is set
        internal bool IsSetCacheAttributes()
        {
            return this._cacheAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemAssociationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file system association that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string FileSystemAssociationARN
        {
            get { return this._fileSystemAssociationARN; }
            set { this._fileSystemAssociationARN = value; }
        }

        // Check to see if FileSystemAssociationARN property is set
        internal bool IsSetFileSystemAssociationARN()
        {
            return this._fileSystemAssociationARN != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password of the user credential.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user name of the user credential that has permission to access the root share
        /// D$ of the Amazon FSx file system. The user account must belong to the Amazon FSx delegated
        /// admin user group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}