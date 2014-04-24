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
    /// Container for the parameters to the UpdateUserProfile operation.
    /// <para>Updates a specified user profile.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have an attached
    /// policy that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateUserProfile"/>
    public class UpdateUserProfileRequest : AmazonWebServiceRequest
    {
        private string iamUserArn;
        private string sshUsername;
        private string sshPublicKey;
        private bool? allowSelfManagement;

        /// <summary>
        /// The user IAM ARN.
        ///  
        /// </summary>
        public string IamUserArn
        {
            get { return this.iamUserArn; }
            set { this.iamUserArn = value; }
        }

        /// <summary>
        /// Sets the IamUserArn property
        /// </summary>
        /// <param name="iamUserArn">The value to set for the IamUserArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateUserProfileRequest WithIamUserArn(string iamUserArn)
        {
            this.iamUserArn = iamUserArn;
            return this;
        }
            

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this.iamUserArn != null;
        }

        /// <summary>
        /// The user's SSH user name. The allowable characters are [a-z], [A-Z], [0-9], '-', and '_'. If the specified name includes other punctuation
        /// marks, AWS OpsWorks removes them. For example, <c>my.name</c> will be changed to <c>myname</c>. If you do not specify an SSH user name, AWS
        /// OpsWorks generates one from the IAM user name.
        ///  
        /// </summary>
        public string SshUsername
        {
            get { return this.sshUsername; }
            set { this.sshUsername = value; }
        }

        /// <summary>
        /// Sets the SshUsername property
        /// </summary>
        /// <param name="sshUsername">The value to set for the SshUsername property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateUserProfileRequest WithSshUsername(string sshUsername)
        {
            this.sshUsername = sshUsername;
            return this;
        }
            

        // Check to see if SshUsername property is set
        internal bool IsSetSshUsername()
        {
            return this.sshUsername != null;
        }

        /// <summary>
        /// The user's new SSH public key.
        ///  
        /// </summary>
        public string SshPublicKey
        {
            get { return this.sshPublicKey; }
            set { this.sshPublicKey = value; }
        }

        /// <summary>
        /// Sets the SshPublicKey property
        /// </summary>
        /// <param name="sshPublicKey">The value to set for the SshPublicKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateUserProfileRequest WithSshPublicKey(string sshPublicKey)
        {
            this.sshPublicKey = sshPublicKey;
            return this;
        }
            

        // Check to see if SshPublicKey property is set
        internal bool IsSetSshPublicKey()
        {
            return this.sshPublicKey != null;
        }

        /// <summary>
        /// Whether users can specify their own SSH public key through the My Settings page. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/security-settingsshkey.html">Managing User Permissions</a>.
        ///  
        /// </summary>
        public bool AllowSelfManagement
        {
            get { return this.allowSelfManagement ?? default(bool); }
            set { this.allowSelfManagement = value; }
        }

        /// <summary>
        /// Sets the AllowSelfManagement property
        /// </summary>
        /// <param name="allowSelfManagement">The value to set for the AllowSelfManagement property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateUserProfileRequest WithAllowSelfManagement(bool allowSelfManagement)
        {
            this.allowSelfManagement = allowSelfManagement;
            return this;
        }
            

        // Check to see if AllowSelfManagement property is set
        internal bool IsSetAllowSelfManagement()
        {
            return this.allowSelfManagement.HasValue;
        }
    }
}
    
