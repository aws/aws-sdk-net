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
    /// Provides a description of an EFS file system access point.
    /// </summary>
    public partial class AccessPointDescription
    {
        private string _accessPointArn;
        private string _accessPointId;
        private string _clientToken;
        private string _fileSystemId;
        private LifeCycleState _lifeCycleState;
        private string _name;
        private string _ownerId;
        private PosixUser _posixUser;
        private RootDirectory _rootDirectory;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) associated with the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// The ID of the access point, assigned by Amazon EFS.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The opaque string specified in the request to ensure idempotent creation.
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
        /// The ID of the EFS file system that the access point applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property LifeCycleState. 
        /// <para>
        /// Identifies the lifecycle phase of the access point.
        /// </para>
        /// </summary>
        public LifeCycleState LifeCycleState
        {
            get { return this._lifeCycleState; }
            set { this._lifeCycleState = value; }
        }

        // Check to see if LifeCycleState property is set
        internal bool IsSetLifeCycleState()
        {
            return this._lifeCycleState != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the access point. This is the value of the <code>Name</code> tag.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// Identifies the Amazon Web Services account that owns the access point resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=14)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PosixUser. 
        /// <para>
        /// The full POSIX identity, including the user ID, group ID, and secondary group IDs
        /// on the access point that is used for all file operations by NFS clients using the
        /// access point.
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
        /// The directory on the Amazon EFS file system that the access point exposes as the root
        /// directory to NFS clients using the access point.
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
        /// The tags associated with the access point, presented as an array of Tag objects.
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