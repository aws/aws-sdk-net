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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccessPoint operation.
    /// Creates an EFS access point. An access point is an application-specific view into
    /// an EFS file system that applies an operating system user and group, and a file system
    /// path, to any file system request made through the access point. The operating system
    /// user and group override any identity information provided by the NFS client. The file
    /// system path is exposed as the access point's root directory. Applications using the
    /// access point can only access data in the application's own directory and any subdirectories.
    /// To learn more, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-access-points.html">Mounting
    /// a file system using EFS access points</a>.
    /// 
    ///  <note> 
    /// <para>
    /// If multiple requests to create access points on the same file system are sent in quick
    /// succession, and the file system is near the limit of 1000 access points, you may experience
    /// a throttling response for these requests. This is to ensure that the file system does
    /// not exceed the stated access point limit.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permissions for the <code>elasticfilesystem:CreateAccessPoint</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateAccessPointRequest : AmazonElasticFileSystemRequest
    {
        private string _clientToken;
        private string _fileSystemId;
        private PosixUser _posixUser;
        private RootDirectory _rootDirectory;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A string of up to 64 ASCII characters that Amazon EFS uses to ensure idempotent creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the EFS file system that the access point provides access to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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
        /// Gets and sets the property PosixUser. 
        /// <para>
        /// The operating system user and group applied to all file system requests made using
        /// the access point.
        /// </para>
        /// </summary>
        public PosixUser PosixUser
        {
            get { return this._posixUser; }
            set { this._posixUser = value; }
        }

        // Check to see if PosixUser property is set
        internal bool IsSetPosixUser()
        {
            return this._posixUser != null;
        }

        /// <summary>
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// Specifies the directory on the Amazon EFS file system that the access point exposes
        /// as the root directory of your file system to NFS clients using the access point. The
        /// clients using the access point can only access the root directory and below. If the
        /// <code>RootDirectory</code> &gt; <code>Path</code> specified does not exist, EFS creates
        /// it and applies the <code>CreationInfo</code> settings when a client connects to an
        /// access point. When specifying a <code>RootDirectory</code>, you must provide the <code>Path</code>,
        /// and the <code>CreationInfo</code>.
        /// </para>
        ///  
        /// <para>
        /// Amazon EFS creates a root directory only if you have provided the CreationInfo: OwnUid,
        /// OwnGID, and permissions for the directory. If you do not provide this information,
        /// Amazon EFS does not create the root directory. If the root directory does not exist,
        /// attempts to mount using the access point will fail.
        /// </para>
        /// </summary>
        public RootDirectory RootDirectory
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Creates tags associated with the access point. Each tag is a key-value pair, each
        /// key must be unique. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference
        /// Guide</i>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}