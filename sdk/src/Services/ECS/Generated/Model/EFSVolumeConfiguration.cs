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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// This parameter is specified when you're using an Amazon Elastic File System file system
    /// for task storage. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/efs-volumes.html">Amazon
    /// EFS volumes</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class EFSVolumeConfiguration
    {
        private EFSAuthorizationConfig _authorizationConfig;
        private string _fileSystemId;
        private string _rootDirectory;
        private EFSTransitEncryption _transitEncryption;
        private int? _transitEncryptionPort;

        /// <summary>
        /// Gets and sets the property AuthorizationConfig. 
        /// <para>
        /// The authorization configuration details for the Amazon EFS file system.
        /// </para>
        /// </summary>
        public EFSAuthorizationConfig AuthorizationConfig
        {
            get { return this._authorizationConfig; }
            set { this._authorizationConfig = value; }
        }

        // Check to see if AuthorizationConfig property is set
        internal bool IsSetAuthorizationConfig()
        {
            return this._authorizationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The Amazon EFS file system ID to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The directory within the Amazon EFS file system to mount as the root directory inside
        /// the host. If this parameter is omitted, the root of the Amazon EFS volume will be
        /// used. Specifying <c>/</c> will have the same effect as omitting this parameter.
        /// </para>
        ///  <important> 
        /// <para>
        /// If an EFS access point is specified in the <c>authorizationConfig</c>, the root directory
        /// parameter must either be omitted or set to <c>/</c> which will enforce the path set
        /// on the EFS access point.
        /// </para>
        ///  </important>
        /// </summary>
        public string RootDirectory
        {
            get { return this._rootDirectory; }
            set { this._rootDirectory = value; }
        }

        // Check to see if RootDirectory property is set
        internal bool IsSetRootDirectory()
        {
            return this._rootDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property TransitEncryption. 
        /// <para>
        /// Determines whether to use encryption for Amazon EFS data in transit between the Amazon
        /// ECS host and the Amazon EFS server. Transit encryption must be turned on if Amazon
        /// EFS IAM authorization is used. If this parameter is omitted, the default value of
        /// <c>DISABLED</c> is used. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/encryption-in-transit.html">Encrypting
        /// data in transit</a> in the <i>Amazon Elastic File System User Guide</i>.
        /// </para>
        /// </summary>
        public EFSTransitEncryption TransitEncryption
        {
            get { return this._transitEncryption; }
            set { this._transitEncryption = value; }
        }

        // Check to see if TransitEncryption property is set
        internal bool IsSetTransitEncryption()
        {
            return this._transitEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property TransitEncryptionPort. 
        /// <para>
        /// The port to use when sending encrypted data between the Amazon ECS host and the Amazon
        /// EFS server. If you do not specify a transit encryption port, it will use the port
        /// selection strategy that the Amazon EFS mount helper uses. For more information, see
        /// <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-mount-helper.html">EFS mount
        /// helper</a> in the <i>Amazon Elastic File System User Guide</i>.
        /// </para>
        /// </summary>
        public int? TransitEncryptionPort
        {
            get { return this._transitEncryptionPort; }
            set { this._transitEncryptionPort = value; }
        }

        // Check to see if TransitEncryptionPort property is set
        internal bool IsSetTransitEncryptionPort()
        {
            return this._transitEncryptionPort.HasValue; 
        }

    }
}