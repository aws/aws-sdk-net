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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the Amazon Elastic File System file system that is used for task
    /// storage.
    /// </summary>
    public partial class AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property AuthorizationConfig. 
        /// <para>
        /// The authorization configuration details for the Amazon EFS file system.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationAuthorizationConfigDetails AuthorizationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationConfig property is set.
        /// </summary>
        internal bool IsSetAuthorizationConfig() => this.AuthorizationConfig != null;

        /// <summary>
        /// Gets and sets the property FilesystemId. 
        /// <para>
        /// The Amazon EFS file system identifier to use.
        /// </para>
        /// </summary>
        public string FilesystemId { get; set; }

        /// <summary>
        /// Checks to see if the FilesystemId property is set.
        /// </summary>
        internal bool IsSetFilesystemId() => this.FilesystemId != null;

        /// <summary>
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The directory within the Amazon EFS file system to mount as the root directory inside
        /// the host.
        /// </para>
        /// </summary>
        public string RootDirectory { get; set; }

        /// <summary>
        /// Checks to see if the RootDirectory property is set.
        /// </summary>
        internal bool IsSetRootDirectory() => this.RootDirectory != null;

        /// <summary>
        /// Gets and sets the property TransitEncryption. 
        /// <para>
        /// Whether to enable encryption for Amazon EFS data in transit between the Amazon ECS
        /// host and the Amazon EFS server. 
        /// </para>
        /// </summary>
        public string TransitEncryption { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryption property is set.
        /// </summary>
        internal bool IsSetTransitEncryption() => this.TransitEncryption != null;

        /// <summary>
        /// Gets and sets the property TransitEncryptionPort. 
        /// <para>
        /// The port to use when sending encrypted data between the Amazon ECS host and the Amazon
        /// EFS server.
        /// </para>
        /// </summary>
        public int? TransitEncryptionPort { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionPort property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionPort() => this.TransitEncryptionPort.HasValue;
    }
}
