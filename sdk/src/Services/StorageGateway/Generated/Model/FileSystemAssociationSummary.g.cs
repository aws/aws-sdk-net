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
    /// Gets the summary returned by <c>ListFileSystemAssociation</c>, which is a summary
    /// of a created file system association.
    /// </summary>
    public partial class FileSystemAssociationSummary
    {
        /// <summary>
        /// Gets and sets the property FileSystemAssociationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file system association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string FileSystemAssociationARN { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemAssociationARN property is set.
        /// </summary>
        internal bool IsSetFileSystemAssociationARN() => this.FileSystemAssociationARN != null;

        /// <summary>
        /// Gets and sets the property FileSystemAssociationId. 
        /// <para>
        /// The ID of the file system association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 30)]
        public string FileSystemAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemAssociationId property is set.
        /// </summary>
        internal bool IsSetFileSystemAssociationId() => this.FileSystemAssociationId != null;

        /// <summary>
        /// Gets and sets the property FileSystemAssociationStatus. 
        /// <para>
        /// The status of the file share. Valid Values: <c>AVAILABLE</c> | <c>CREATING</c> | <c>DELETING</c>
        /// | <c>FORCE_DELETING</c> | <c>UPDATING</c> | <c>ERROR</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 50)]
        public string FileSystemAssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemAssociationStatus property is set.
        /// </summary>
        internal bool IsSetFileSystemAssociationStatus() => this.FileSystemAssociationStatus != null;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;
    }
}
