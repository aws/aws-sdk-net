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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTeamMember operation.
    /// Updates a team member's attributes in an AWS CodeStar project. For example, you can
    /// change a team member's role in the project, or change whether they have remote access
    /// to project resources.
    /// </summary>
    public partial class UpdateTeamMemberRequest : AmazonCodeStarRequest
    {
        private string _projectId;
        private string _projectRole;
        private bool? _remoteAccessAllowed;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project.
        /// </para>
        /// </summary>
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectRole. 
        /// <para>
        /// The role assigned to the user in the project. Project roles have different levels
        /// of access. For more information, see <a href="http://docs.aws.amazon.com/codestar/latest/userguide/working-with-teams.html">Working
        /// with Teams</a> in the AWS CodeStar User Guide.
        /// </para>
        /// </summary>
        public string ProjectRole
        {
            get { return this._projectRole; }
            set { this._projectRole = value; }
        }

        // Check to see if ProjectRole property is set
        internal bool IsSetProjectRole()
        {
            return this._projectRole != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteAccessAllowed. 
        /// <para>
        /// Whether a team member is allowed to remotely access project resources using the SSH
        /// public key associated with the user's profile. Even if this is set to True, the user
        /// must associate a public key with their profile before the user can access resources.
        /// </para>
        /// </summary>
        public bool RemoteAccessAllowed
        {
            get { return this._remoteAccessAllowed.GetValueOrDefault(); }
            set { this._remoteAccessAllowed = value; }
        }

        // Check to see if RemoteAccessAllowed property is set
        internal bool IsSetRemoteAccessAllowed()
        {
            return this._remoteAccessAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user for whom you want to change team membership
        /// attributes.
        /// </para>
        /// </summary>
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

    }
}