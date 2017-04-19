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
    /// Container for the parameters to the DisassociateTeamMember operation.
    /// Removes a user from a project. Removing a user from a project also removes the IAM
    /// policies from that user that allowed access to the project and its resources. Disassociating
    /// a team member does not remove that user's profile from AWS CodeStar. It does not remove
    /// the user from IAM.
    /// </summary>
    public partial class DisassociateTeamMemberRequest : AmazonCodeStarRequest
    {
        private string _projectId;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the AWS CodeStar project from which you want to remove a team member.
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
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM user or group whom you want to remove from
        /// the project.
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