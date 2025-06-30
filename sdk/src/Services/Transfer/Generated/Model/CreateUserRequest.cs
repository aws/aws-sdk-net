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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation.
    /// Creates a user and associates them with an existing file transfer protocol-enabled
    /// server. You can only create and associate users with servers that have the <c>IdentityProviderType</c>
    /// set to <c>SERVICE_MANAGED</c>. Using parameters for <c>CreateUser</c>, you can specify
    /// the user name, set the home directory, store the user's public key, and assign the
    /// user's Identity and Access Management (IAM) role. You can also optionally add a session
    /// policy, and assign metadata with tags that can be used to group and search for users.
    /// </summary>
    public partial class CreateUserRequest : AmazonTransferRequest
    {
        private string _homeDirectory;
        private List<HomeDirectoryMapEntry> _homeDirectoryMappings = AWSConfigs.InitializeCollections ? new List<HomeDirectoryMapEntry>() : null;
        private HomeDirectoryType _homeDirectoryType;
        private string _policy;
        private PosixProfile _posixProfile;
        private string _role;
        private string _serverId;
        private string _sshPublicKeyBody;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _userName;

        /// <summary>
        /// Gets and sets the property HomeDirectory. 
        /// <para>
        /// The landing directory (folder) for a user when they log in to the server using the
        /// client.
        /// </para>
        ///  
        /// <para>
        /// A <c>HomeDirectory</c> example is <c>/bucket_name/home/mydirectory</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use the <c>HomeDirectory</c> parameter for <c>HomeDirectoryType</c> when it
        /// is set to either <c>PATH</c> or <c>LOGICAL</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// the <c>Entry</c> and <c>Target</c> pair, where <c>Entry</c> shows how the path is
        /// made visible and <c>Target</c> is the actual Amazon S3 or Amazon EFS path. If you
        /// only specify a target, it is displayed as is. You also must ensure that your Identity
        /// and Access Management (IAM) role provides access to paths in <c>Target</c>. This value
        /// can be set only when <c>HomeDirectoryType</c> is set to <i>LOGICAL</i>.
        /// </para>
        ///  
        /// <para>
        /// The following is an <c>Entry</c> and <c>Target</c> pair example.
        /// </para>
        ///  
        /// <para>
        ///  <c>[ { "Entry": "/directory1", "Target": "/bucket_name/home/mydirectory" } ]</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// In most cases, you can use this value instead of the session policy to lock your user
        /// down to the designated home directory ("<c>chroot</c>"). To do this, you can set <c>Entry</c>
        /// to <c>/</c> and set <c>Target</c> to the value the user should see for their home
        /// directory when they log in.
        /// </para>
        ///  
        /// <para>
        /// The following is an <c>Entry</c> and <c>Target</c> pair example for <c>chroot</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>[ { "Entry": "/", "Target": "/bucket_name/home/mydirectory" } ]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50000)]
        public List<HomeDirectoryMapEntry> HomeDirectoryMappings
        {
            get { return this._homeDirectoryMappings; }
            set { this._homeDirectoryMappings = value; }
        }

        // Check to see if HomeDirectoryMappings property is set
        internal bool IsSetHomeDirectoryMappings()
        {
            return this._homeDirectoryMappings != null && (this._homeDirectoryMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HomeDirectoryType. 
        /// <para>
        /// The type of landing directory (folder) that you want your users' home directory to
        /// be when they log in to the server. If you set it to <c>PATH</c>, the user will see
        /// the absolute Amazon S3 bucket or Amazon EFS path as is in their file transfer protocol
        /// clients. If you set it to <c>LOGICAL</c>, you need to provide mappings in the <c>HomeDirectoryMappings</c>
        /// for how you want to make Amazon S3 or Amazon EFS paths visible to your users.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>HomeDirectoryType</c> is <c>LOGICAL</c>, you must provide mappings, using the
        /// <c>HomeDirectoryMappings</c> parameter. If, on the other hand, <c>HomeDirectoryType</c>
        /// is <c>PATH</c>, you provide an absolute path using the <c>HomeDirectory</c> parameter.
        /// You cannot have both <c>HomeDirectory</c> and <c>HomeDirectoryMappings</c> in your
        /// template.
        /// </para>
        ///  </note>
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
        /// A session policy for your user so that you can use the same Identity and Access Management
        /// (IAM) role across multiple users. This policy scopes down a user's access to portions
        /// of their Amazon S3 bucket. Variables that you can use inside this policy include <c>${Transfer:UserName}</c>,
        /// <c>${Transfer:HomeDirectory}</c>, and <c>${Transfer:HomeBucket}</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This policy applies only when the domain of <c>ServerId</c> is Amazon S3. Amazon EFS
        /// does not use session policies.
        /// </para>
        ///  
        /// <para>
        /// For session policies, Transfer Family stores the policy as a JSON blob, instead of
        /// the Amazon Resource Name (ARN) of the policy. You save the policy as a JSON blob and
        /// pass it in the <c>Policy</c> argument.
        /// </para>
        ///  
        /// <para>
        /// For an example of a session policy, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/session-policy.html">Example
        /// session policy</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRole.html">AssumeRole</a>
        /// in the <i>Amazon Web Services Security Token Service API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Specifies the full POSIX identity, including user ID (<c>Uid</c>), group ID (<c>Gid</c>),
        /// and any secondary groups IDs (<c>SecondaryGids</c>), that controls your users' access
        /// to your Amazon EFS file systems. The POSIX permissions that are set on files and directories
        /// in Amazon EFS determine the level of access your users get when transferring files
        /// into and out of your Amazon EFS file systems.
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
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// controls your users' access to your Amazon S3 bucket or Amazon EFS file system. The
        /// policies attached to this role determine the level of access that you want to provide
        /// your users when transferring files into and out of your Amazon S3 bucket or Amazon
        /// EFS file system. The IAM role should also contain a trust relationship that allows
        /// the server to access your resources when servicing your users' transfer requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server instance. This is the specific server
        /// that you added your user to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property SshPublicKeyBody. 
        /// <para>
        /// The public portion of the Secure Shell (SSH) key used to authenticate the user to
        /// the server.
        /// </para>
        ///  
        /// <para>
        /// The three standard SSH public key format elements are <c>&lt;key type&gt;</c>, <c>&lt;body
        /// base64&gt;</c>, and an optional <c>&lt;comment&gt;</c>, with spaces between each element.
        /// </para>
        ///  
        /// <para>
        /// Transfer Family accepts RSA, ECDSA, and ED25519 keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For RSA keys, the key type is <c>ssh-rsa</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ED25519 keys, the key type is <c>ssh-ed25519</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ECDSA keys, the key type is either <c>ecdsa-sha2-nistp256</c>, <c>ecdsa-sha2-nistp384</c>,
        /// or <c>ecdsa-sha2-nistp521</c>, depending on the size of the key you generated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SshPublicKeyBody
        {
            get { return this._sshPublicKeyBody; }
            set { this._sshPublicKeyBody = value; }
        }

        // Check to see if SshPublicKeyBody property is set
        internal bool IsSetSshPublicKeyBody()
        {
            return this._sshPublicKeyBody != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for users. Tags are metadata
        /// attached to users for any purpose.
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

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// A unique string that identifies a user and is associated with a <c>ServerId</c>. This
        /// user name must be a minimum of 3 and a maximum of 100 characters long. The following
        /// are valid characters: a-z, A-Z, 0-9, underscore '_', hyphen '-', period '.', and at
        /// sign '@'. The user name can't start with a hyphen, period, or at sign.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=100)]
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