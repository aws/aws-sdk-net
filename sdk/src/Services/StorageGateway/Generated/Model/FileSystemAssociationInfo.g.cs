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
    /// Describes the object returned by <c>DescribeFileSystemAssociations</c> that describes
    /// a created file system association.
    /// </summary>
    public partial class FileSystemAssociationInfo
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
        /// Gets and sets the property EndpointNetworkConfiguration. 
        /// <para>
        /// Specifies network configuration information for the gateway associated with the Amazon
        /// FSx file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// If multiple file systems are associated with this gateway, this parameter's <c>IpAddresses</c>
        /// field is required.
        /// </para>
        ///  </note>
        /// </summary>
        public EndpointNetworkConfiguration EndpointNetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EndpointNetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetEndpointNetworkConfiguration() => this.EndpointNetworkConfiguration != null;

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
        /// Gets and sets the property FileSystemAssociationStatus. 
        /// <para>
        /// The status of the file system association. Valid Values: <c>AVAILABLE</c> | <c>CREATING</c>
        /// | <c>DELETING</c> | <c>FORCE_DELETING</c> | <c>UPDATING</c> | <c>ERROR</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 50)]
        public string FileSystemAssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemAssociationStatus property is set.
        /// </summary>
        internal bool IsSetFileSystemAssociationStatus() => this.FileSystemAssociationStatus != null;

        /// <summary>
        /// Gets and sets the property FileSystemAssociationStatusDetails. 
        /// <para>
        /// An array containing the FileSystemAssociationStatusDetail data type, which provides
        /// detailed information on file system association status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FileSystemAssociationStatusDetail> FileSystemAssociationStatusDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<FileSystemAssociationStatusDetail>() : null;

        /// <summary>
        /// Checks to see if the FileSystemAssociationStatusDetails property is set.
        /// </summary>
        internal bool IsSetFileSystemAssociationStatusDetails() => this.FileSystemAssociationStatusDetails != null && (this.FileSystemAssociationStatusDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;

        /// <summary>
        /// Gets and sets the property LocationARN. 
        /// <para>
        /// The ARN of the backend Amazon FSx file system used for storing file data. For information,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_FileSystem.html">FileSystem</a>
        /// in the <i>Amazon FSx API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 512)]
        public string LocationARN { get; set; }

        /// <summary>
        /// Checks to see if the LocationARN property is set.
        /// </summary>
        internal bool IsSetLocationARN() => this.LocationARN != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags assigned to the SMB file share, sorted alphabetically by key
        /// name. Each tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
