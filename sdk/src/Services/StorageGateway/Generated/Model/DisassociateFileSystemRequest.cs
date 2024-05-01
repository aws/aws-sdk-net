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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateFileSystem operation.
    /// Disassociates an Amazon FSx file system from the specified gateway. After the disassociation
    /// process finishes, the gateway can no longer access the Amazon FSx file system. This
    /// operation is only supported in the FSx File Gateway type.
    /// </summary>
    public partial class DisassociateFileSystemRequest : AmazonStorageGatewayRequest
    {
        private string _fileSystemAssociationARN;
        private bool? _forceDelete;

        /// <summary>
        /// Gets and sets the property FileSystemAssociationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file system association to be deleted.
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
        /// Gets and sets the property ForceDelete. 
        /// <para>
        /// If this value is set to true, the operation disassociates an Amazon FSx file system
        /// immediately. It ends all data uploads to the file system, and the file system association
        /// enters the <c>FORCE_DELETING</c> status. If this value is set to false, the Amazon
        /// FSx file system does not disassociate until all data is uploaded.
        /// </para>
        /// </summary>
        public bool? ForceDelete
        {
            get { return this._forceDelete; }
            set { this._forceDelete = value; }
        }

        // Check to see if ForceDelete property is set
        internal bool IsSetForceDelete()
        {
            return this._forceDelete.HasValue; 
        }

    }
}