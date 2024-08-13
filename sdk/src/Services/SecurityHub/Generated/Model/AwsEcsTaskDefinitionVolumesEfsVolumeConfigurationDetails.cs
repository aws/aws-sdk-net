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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationAuthorizationConfigDetails _authorizationConfig;
        private string _filesystemId;
        private string _rootDirectory;
        private string _transitEncryption;
        private int? _transitEncryptionPort;

        /// <summary>
        /// Gets and sets the property AuthorizationConfig. 
        /// <para>
        /// The authorization configuration details for the Amazon EFS file system.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationAuthorizationConfigDetails AuthorizationConfig
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
        /// Gets and sets the property FilesystemId. 
        /// <para>
        /// The Amazon EFS file system identifier to use.
        /// </para>
        /// </summary>
        public string FilesystemId
        {
            get { return this._filesystemId; }
            set { this._filesystemId = value; }
        }

        // Check to see if FilesystemId property is set
        internal bool IsSetFilesystemId()
        {
            return this._filesystemId != null;
        }

        /// <summary>
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The directory within the Amazon EFS file system to mount as the root directory inside
        /// the host.
        /// </para>
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
        /// Whether to enable encryption for Amazon EFS data in transit between the Amazon ECS
        /// host and the Amazon EFS server. 
        /// </para>
        /// </summary>
        public string TransitEncryption
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
        /// EFS server.
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