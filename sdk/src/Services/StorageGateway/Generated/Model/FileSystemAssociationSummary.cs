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
    /// Gets the summary returned by <c>ListFileSystemAssociation</c>, which is a summary
    /// of a created file system association.
    /// </summary>
    public partial class FileSystemAssociationSummary
    {
        private string _fileSystemAssociationARN;
        private string _fileSystemAssociationId;
        private string _fileSystemAssociationStatus;
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property FileSystemAssociationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file system association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
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
        /// Gets and sets the property FileSystemAssociationId. 
        /// <para>
        /// The ID of the file system association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=30)]
        public string FileSystemAssociationId
        {
            get { return this._fileSystemAssociationId; }
            set { this._fileSystemAssociationId = value; }
        }

        // Check to see if FileSystemAssociationId property is set
        internal bool IsSetFileSystemAssociationId()
        {
            return this._fileSystemAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemAssociationStatus. 
        /// <para>
        /// The status of the file share. Valid Values: <c>AVAILABLE</c> | <c>CREATING</c> | <c>DELETING</c>
        /// | <c>FORCE_DELETING</c> | <c>UPDATING</c> | <c>ERROR</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=50)]
        public string FileSystemAssociationStatus
        {
            get { return this._fileSystemAssociationStatus; }
            set { this._fileSystemAssociationStatus = value; }
        }

        // Check to see if FileSystemAssociationStatus property is set
        internal bool IsSetFileSystemAssociationStatus()
        {
            return this._fileSystemAssociationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

    }
}