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
    /// Container for the parameters to the UpdateMyUserProfile operation.
    /// <para>Updates a user's SSH public key.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have self-management
    /// enabled or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateMyUserProfile"/>
    public class UpdateMyUserProfileRequest : AmazonWebServiceRequest
    {
        private string sshPublicKey;

        /// <summary>
        /// The user's SSH public key.
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
        public UpdateMyUserProfileRequest WithSshPublicKey(string sshPublicKey)
        {
            this.sshPublicKey = sshPublicKey;
            return this;
        }
            

        // Check to see if SshPublicKey property is set
        internal bool IsSetSshPublicKey()
        {
            return this.sshPublicKey != null;
        }
    }
}
    
