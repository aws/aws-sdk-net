/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Returns properties of the user that you specify.
    /// </summary>
    public partial class ListedUser
    {
        private string _arn;
        private string _homeDirectory;
        private HomeDirectoryType _homeDirectoryType;
        private string _role;
        private int? _sshPublicKeyCount;
        private string _userName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Provides the unique Amazon Resource Name (ARN) for the user that you want to learn
        /// about.
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
        /// Specifies the location that files are written to or read from an Amazon S3 bucket
        /// for the user you specify by their ARN.
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
        /// Gets and sets the property HomeDirectoryType. 
        /// <para>
        /// Specifies the type of landing directory (folder) you mapped for your users' home directory.
        /// If you set it to <code>PATH</code>, the user will see the absolute Amazon S3 bucket
        /// paths as is in their file transfer protocol clients. If you set it <code>LOGICAL</code>,
        /// you will need to provide mappings in the <code>HomeDirectoryMappings</code> for how
        /// you want to make Amazon S3 paths visible to your users.
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
        /// Gets and sets the property Role. 
        /// <para>
        /// Specifies the role that is in use by this user. A <i>role</i> is an AWS Identity and
        /// Access Management (IAM) entity that, in this case, allows a file transfer protocol-enabled
        /// server to act on a user's behalf. It allows the server to inherit the trust relationship
        /// that enables that user to perform file operations to their Amazon S3 bucket.
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
        /// Gets and sets the property SshPublicKeyCount. 
        /// <para>
        /// Specifies the number of SSH public keys stored for the user you specified.
        /// </para>
        /// </summary>
        public int SshPublicKeyCount
        {
            get { return this._sshPublicKeyCount.GetValueOrDefault(); }
            set { this._sshPublicKeyCount = value; }
        }

        // Check to see if SshPublicKeyCount property is set
        internal bool IsSetSshPublicKeyCount()
        {
            return this._sshPublicKeyCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Specifies the name of the user whose ARN was specified. User names are used for authentication
        /// purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=32)]
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