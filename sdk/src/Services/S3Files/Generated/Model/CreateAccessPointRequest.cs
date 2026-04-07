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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
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
namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccessPoint operation.
    /// Creates an S3 File System Access Point for application-specific access with POSIX
    /// user identity and root directory enforcement. Access points provide a way to manage
    /// access to shared datasets in multi-tenant scenarios.
    /// </summary>
    public partial class CreateAccessPointRequest : AmazonS3FilesRequest
    {
        private string _clientToken;
        private string _fileSystemId;
        private PosixUser _posixUser;
        private RootDirectory _rootDirectory;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon Web Services ignores
        /// the request, but does not return an error.
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
        /// The ID or Amazon Resource Name (ARN) of the S3 File System.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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
        /// The POSIX identity with uid, gid, and secondary group IDs for user enforcement when
        /// accessing the file system through this access point.
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
        /// The root directory path for the access point, with optional creation permissions for
        /// newly created directories.
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
        /// An array of key-value pairs to apply to the access point for resource tagging.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}