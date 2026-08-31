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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is used when you're using an Amazon Elastic File System file system for job storage.
    /// For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/efs-volumes.html">Amazon
    /// EFS Volumes</a> in the <i>Batch User Guide</i>.
    /// </summary>
    public partial class EFSVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthorizationConfig. 
        /// <para>
        /// The authorization configuration details for the Amazon EFS file system.
        /// </para>
        /// </summary>
        public EFSAuthorizationConfig AuthorizationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationConfig property is set.
        /// </summary>
        internal bool IsSetAuthorizationConfig() => this.AuthorizationConfig != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The Amazon EFS file system ID to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The directory within the Amazon EFS file system to mount as the root directory inside
        /// the host. If this parameter is omitted, the root of the Amazon EFS volume is used
        /// instead. Specifying <c>/</c> has the same effect as omitting this parameter. The maximum
        /// length is 4,096 characters.
        /// </para>
        ///  <important> 
        /// <para>
        /// If an EFS access point is specified in the <c>authorizationConfig</c>, the root directory
        /// parameter must either be omitted or set to <c>/</c>, which enforces the path set on
        /// the Amazon EFS access point.
        /// </para>
        ///  </important>
        /// </summary>
        public string RootDirectory { get; set; }

        /// <summary>
        /// Checks to see if the RootDirectory property is set.
        /// </summary>
        internal bool IsSetRootDirectory() => this.RootDirectory != null;

        /// <summary>
        /// Gets and sets the property TransitEncryption. 
        /// <para>
        /// Determines whether to enable encryption for Amazon EFS data in transit between the
        /// Amazon ECS host and the Amazon EFS server. Transit encryption must be enabled if Amazon
        /// EFS IAM authorization is used. If this parameter is omitted, the default value of
        /// <c>DISABLED</c> is used. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/encryption-in-transit.html">Encrypting
        /// data in transit</a> in the <i>Amazon Elastic File System User Guide</i>.
        /// </para>
        /// </summary>
        public EFSTransitEncryption TransitEncryption { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryption property is set.
        /// </summary>
        internal bool IsSetTransitEncryption() => this.TransitEncryption != null;

        /// <summary>
        /// Gets and sets the property TransitEncryptionPort. 
        /// <para>
        /// The port to use when sending encrypted data between the Amazon ECS host and the Amazon
        /// EFS server. If you don't specify a transit encryption port, it uses the port selection
        /// strategy that the Amazon EFS mount helper uses. The value must be between 0 and 65,535.
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-mount-helper.html">EFS
        /// mount helper</a> in the <i>Amazon Elastic File System User Guide</i>.
        /// </para>
        /// </summary>
        public int? TransitEncryptionPort { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionPort property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionPort() => this.TransitEncryptionPort.HasValue;
    }
}
