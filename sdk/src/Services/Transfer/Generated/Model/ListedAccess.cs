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
    /// Lists the properties for one or more specified associated accesses.
    /// </summary>
    public partial class ListedAccess
    {
        private string _externalId;
        private string _homeDirectory;
        private HomeDirectoryType _homeDirectoryType;
        private string _role;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// A unique identifier that might be required when you assume a role in another account.
        /// Think of the <code>ExternalID</code> as a group membership mechanism that uses a unique
        /// identifier (often a SID, but could be a group name or something else) as a basis.
        /// If the administrator of the account to which the role belongs provided you with an
        /// external ID, then provide that value in the <code>ExternalId</code> parameter. A cross-account
        /// role is usually set up to trust everyone in an account. Therefore, the administrator
        /// of the trusting account might send an external ID to the administrator of the trusted
        /// account. That way, only someone with the ID can assume the role, rather than everyone
        /// in the account.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// uppercase and lowercase alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@:/-
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property HomeDirectory. 
        /// <para>
        /// Specifies the landing directory (or folder), which is the location that files are
        /// written to or read from in an Amazon S3 bucket, for the described access.
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
        /// The type of landing directory (folder) that you want your users' home directory to
        /// be when they log in to the server. If you set it to <code>PATH</code>, the user will
        /// see the absolute Amazon S3 bucket paths as is in their file transfer protocol clients.
        /// If you set it to <code>LOGICAL</code>, you must provide mappings in the <code>HomeDirectoryMappings</code>
        /// for how you want to make Amazon S3 paths visible to your users.
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
        /// The AWS Identity and Access Management (IAM) role that controls access to your Amazon
        /// S3 bucket from the specified associated access. The policies attached to this role
        /// will determine the level of access that you want to provide the associated access
        /// when transferring files into and out of your Amazon S3 bucket or buckets. The IAM
        /// role should also contain a trust relationship that allows a server to access your
        /// resources when servicing transfer requests for the associated access.
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

    }
}