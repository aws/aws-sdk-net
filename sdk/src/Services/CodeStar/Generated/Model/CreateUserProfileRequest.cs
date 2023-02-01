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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUserProfile operation.
    /// Creates a profile for a user that includes user preferences, such as the display name
    /// and email address assocciated with the user, in AWS CodeStar. The user profile is
    /// not project-specific. Information in the user profile is displayed wherever the user's
    /// information appears to other users in AWS CodeStar.
    /// </summary>
    public partial class CreateUserProfileRequest : AmazonCodeStarRequest
    {
        private string _displayName;
        private string _emailAddress;
        private string _sshPublicKey;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name that will be displayed as the friendly name for the user in AWS CodeStar.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address that will be displayed as part of the user's profile in AWS CodeStar.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=3, Max=128)]
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SshPublicKey. 
        /// <para>
        /// The SSH public key associated with the user in AWS CodeStar. If a project owner allows
        /// the user remote access to project resources, this public key will be used along with
        /// the user's private key for SSH access.
        /// </para>
        /// </summary>
        [AWSProperty(Max=16384)]
        public string SshPublicKey
        {
            get { return this._sshPublicKey; }
            set { this._sshPublicKey = value; }
        }

        // Check to see if SshPublicKey property is set
        internal bool IsSetSshPublicKey()
        {
            return this._sshPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user in IAM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=95)]
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