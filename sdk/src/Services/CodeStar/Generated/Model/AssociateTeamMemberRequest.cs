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
    /// Container for the parameters to the AssociateTeamMember operation.
    /// Adds an IAM user to the team for an AWS CodeStar project.
    /// </summary>
    public partial class AssociateTeamMemberRequest : AmazonCodeStarRequest
    {
        private string _clientRequestToken;
        private string _projectId;
        private string _projectRole;
        private bool? _remoteAccessAllowed;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A user- or system-generated token that identifies the entity that requested the team
        /// member association to the project. This token can be used to repeat the request. 
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project to which you will add the IAM user.
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
        /// The AWS CodeStar project role that will apply to this user. This role determines what
        /// actions a user can take in an AWS CodeStar project.
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
        /// Whether the team member is allowed to use an SSH public/private key pair to remotely
        /// access project resources, for example Amazon EC2 instances.
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
        /// The Amazon Resource Name (ARN) for the IAM user you want to add to the DevHub project.
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