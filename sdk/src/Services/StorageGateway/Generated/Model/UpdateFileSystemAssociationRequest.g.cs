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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFileSystemAssociation operation. Updates
    /// a file system association. This operation is only supported in the FSx File Gateways.
    /// </summary>
    public partial class UpdateFileSystemAssociationRequest : AmazonStorageGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property AuditDestinationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the storage used for the audit logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AuditDestinationARN { get; set; }

        /// <summary>
        /// Checks to see if the AuditDestinationARN property is set.
        /// </summary>
        internal bool IsSetAuditDestinationARN() => this.AuditDestinationARN != null;

        /// <summary>
        /// Gets and sets the property CacheAttributes.
        /// </summary>
        public CacheAttributes CacheAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CacheAttributes property is set.
        /// </summary>
        internal bool IsSetCacheAttributes() => this.CacheAttributes != null;

        /// <summary>
        /// Gets and sets the property FileSystemAssociationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file system association that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 500)]
        public string FileSystemAssociationARN { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemAssociationARN property is set.
        /// </summary>
        internal bool IsSetFileSystemAssociationARN() => this.FileSystemAssociationARN != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password of the user credential.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user name of the user credential that has permission to access the root share
        /// D$ of the Amazon FSx file system. The user account must belong to the Amazon FSx delegated
        /// admin user group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
