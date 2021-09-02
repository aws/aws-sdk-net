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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describes the properties of a user that was specified.
    /// </summary>
    public partial class DescribedUser
    {
        private string _arn;
        private string _homeDirectory;
        private List<HomeDirectoryMapEntry> _homeDirectoryMappings = new List<HomeDirectoryMapEntry>();
        private HomeDirectoryType _homeDirectoryType;
        private string _policy;
        private PosixProfile _posixProfile;
        private string _role;
        private List<SshPublicKey> _sshPublicKeys = new List<SshPublicKey>();
        private List<Tag> _tags = new List<Tag>();
        private string _userName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) for the user that was requested to
        /// be described.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
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
        /// Gets and sets the property HomeDirectory. 
        /// <para>
        /// The landing directory (folder) for a user when they log in to the server using the
        /// client.
        /// </para>
        ///  
        /// <para>
        /// A <code>HomeDirectory</code> example is <code>/bucket_name/home/mydirectory</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string HomeDirectory
        {
            get { return this._homeDirectory; }
            set { this._homeDirectory = value; }
        }

        // Check to see if HomeDirectory property is set
        internal bool IsSetHomeDirectory()
        {
            return this._homeDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property HomeDirectoryMappings. 
        /// <para>
        /// Logical directory mappings that specify what Amazon S3 or Amazon EFS paths and keys
        /// should be visible to your user and how you want to make them visible. You must specify
        /// the <code>Entry</code> and <code>Target</code> pair, where <code>Entry</code> shows
        /// how the path is made visible and <code>Target</code> is the actual Amazon S3 or Amazon
        /// EFS path. If you only specify a target, it is displayed as is. You also must ensure
        /// that your Amazon Web Services Identity and Access Management (IAM) role provides access
        /// to paths in <code>Target</code>. This value can only be set when <code>HomeDirectoryType</code>
        /// is set to <i>LOGICAL</i>.
        /// </para>
        ///  
        /// <para>
        /// In most cases, you can use this value instead of the session policy to lock your user
        /// down to the designated home directory ("<code>chroot</code>"). To do this, you can
        /// set <code>Entry</code> to '/' and set <code>Target</code> to the HomeDirectory parameter
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<HomeDirectoryMapEntry> HomeDirectoryMappings
        {
            get { return this._homeDirectoryMappings; }
            set { this._homeDirectoryMappings = value; }
        }

        // Check to see if HomeDirectoryMappings property is set
        internal bool IsSetHomeDirectoryMappings()
        {
            return this._homeDirectoryMappings != null && this._homeDirectoryMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HomeDirectoryType. 
        /// <para>
        /// The type of landing directory (folder) you want your users' home directory to be when
        /// they log into the server. If you set it to <code>PATH</code>, the user will see the
        /// absolute Amazon S3 bucket or EFS paths as is in their file transfer protocol clients.
        /// If you set it <code>LOGICAL</code>, you need to provide mappings in the <code>HomeDirectoryMappings</code>
        /// for how you want to make Amazon S3 or EFS paths visible to your users.
        /// </para>
        /// </summary>
        public HomeDirectoryType HomeDirectoryType
        {
            get { return this._homeDirectoryType; }
            set { this._homeDirectoryType = value; }
        }

        // Check to see if HomeDirectoryType property is set
        internal bool IsSetHomeDirectoryType()
        {
            return this._homeDirectoryType != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A session policy for your user so that you can use the same IAM role across multiple
        /// users. This policy scopes down user access to portions of their Amazon S3 bucket.
        /// Variables that you can use inside this policy include <code>${Transfer:UserName}</code>,
        /// <code>${Transfer:HomeDirectory}</code>, and <code>${Transfer:HomeBucket}</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property PosixProfile. 
        /// <para>
        /// Specifies the full POSIX identity, including user ID (<code>Uid</code>), group ID
        /// (<code>Gid</code>), and any secondary groups IDs (<code>SecondaryGids</code>), that
        /// controls your users' access to your Amazon Elastic File System (Amazon EFS) file systems.
        /// The POSIX permissions that are set on files and directories in your file system determine
        /// the level of access your users get when transferring files into and out of your Amazon
        /// EFS file systems.
        /// </para>
        /// </summary>
        public PosixProfile PosixProfile
        {
            get { return this._posixProfile; }
            set { this._posixProfile = value; }
        }

        // Check to see if PosixProfile property is set
        internal bool IsSetPosixProfile()
        {
            return this._posixProfile != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the IAM role that controls your users'
        /// access to your Amazon S3 bucket or EFS file system. The policies attached to this
        /// role determine the level of access that you want to provide your users when transferring
        /// files into and out of your Amazon S3 bucket or EFS file system. The IAM role should
        /// also contain a trust relationship that allows the server to access your resources
        /// when servicing your users' transfer requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SshPublicKeys. 
        /// <para>
        /// Specifies the public key portion of the Secure Shell (SSH) keys stored for the described
        /// user.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<SshPublicKey> SshPublicKeys
        {
            get { return this._sshPublicKeys; }
            set { this._sshPublicKeys = value; }
        }

        // Check to see if SshPublicKeys property is set
        internal bool IsSetSshPublicKeys()
        {
            return this._sshPublicKeys != null && this._sshPublicKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the key-value pairs for the user requested. Tag can be used to search for
        /// and group users for a variety of purposes.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Specifies the name of the user that was requested to be described. User names are
        /// used for authentication purposes. This is the string that will be used by your user
        /// when they log in to your server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}