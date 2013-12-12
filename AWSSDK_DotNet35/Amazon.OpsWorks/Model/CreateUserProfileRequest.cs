/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUserProfile operation.
    /// <para>Creates a new user profile.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached policy
    /// that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class CreateUserProfileRequest : AmazonOpsWorksRequest
    {
        private string iamUserArn;
        private string sshUsername;
        private string sshPublicKey;
        private bool? allowSelfManagement;


        /// <summary>
        /// The user's IAM ARN.
        ///  
        /// </summary>
        public string IamUserArn
        {
            get { return this.iamUserArn; }
            set { this.iamUserArn = value; }
        }

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this.iamUserArn != null;
        }

        /// <summary>
        /// The user's SSH user name.
        ///  
        /// </summary>
        public string SshUsername
        {
            get { return this.sshUsername; }
            set { this.sshUsername = value; }
        }

        // Check to see if SshUsername property is set
        internal bool IsSetSshUsername()
        {
            return this.sshUsername != null;
        }

        /// <summary>
        /// The user's public SSH key.
        ///  
        /// </summary>
        public string SshPublicKey
        {
            get { return this.sshPublicKey; }
            set { this.sshPublicKey = value; }
        }

        // Check to see if SshPublicKey property is set
        internal bool IsSetSshPublicKey()
        {
            return this.sshPublicKey != null;
        }

        /// <summary>
        /// Whether users can specify their own SSH public key through the My Settings page. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/security-settingsshkey.html"></a>.
        ///  
        /// </summary>
        public bool AllowSelfManagement
        {
            get { return this.allowSelfManagement ?? default(bool); }
            set { this.allowSelfManagement = value; }
        }

        // Check to see if AllowSelfManagement property is set
        internal bool IsSetAllowSelfManagement()
        {
            return this.allowSelfManagement.HasValue;
        }

    }
}
    
