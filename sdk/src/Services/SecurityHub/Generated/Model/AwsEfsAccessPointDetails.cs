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
    /// Provides information about an Amazon EFS access point.
    /// </summary>
    public partial class AwsEfsAccessPointDetails
    {
        private string _accessPointId;
        private string _arn;
        private string _clientToken;
        private string _fileSystemId;
        private AwsEfsAccessPointPosixUserDetails _posixUser;
        private AwsEfsAccessPointRootDirectoryDetails _rootDirectory;

        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// The ID of the Amazon EFS access point. 
        /// </para>
        /// </summary>
        public string AccessPointId
        {
            get { return this._accessPointId; }
            set { this._accessPointId = value; }
        }

        // Check to see if AccessPointId property is set
        internal bool IsSetAccessPointId()
        {
            return this._accessPointId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EFS access point. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The opaque string specified in the request to ensure idempotent creation. 
        /// </para>
        /// </summary>
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
        /// The ID of the Amazon EFS file system that the access point applies to. 
        /// </para>
        /// </summary>
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
        /// The full POSIX identity, including the user ID, group ID, and secondary group IDs
        /// on the access point, that is used for all file operations by NFS clients using the
        /// access point. 
        /// </para>
        /// </summary>
        public AwsEfsAccessPointPosixUserDetails PosixUser
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
        /// The directory on the Amazon EFS file system that the access point exposes as the root
        /// directory to NFS clients using the access point. 
        /// </para>
        /// </summary>
        public AwsEfsAccessPointRootDirectoryDetails RootDirectory
        {
            get { return this._rootDirectory; }
            set { this._rootDirectory = value; }
        }

        // Check to see if RootDirectory property is set
        internal bool IsSetRootDirectory()
        {
            return this._rootDirectory != null;
        }

    }
}