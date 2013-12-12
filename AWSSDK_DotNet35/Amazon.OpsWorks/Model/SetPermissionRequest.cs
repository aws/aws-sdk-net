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
    /// Container for the parameters to the SetPermission operation.
    /// <para>Specifies a stack's permissions. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingsecurity.html" >Security and Permissions</a> .</para> <para> <b>Required
    /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
    /// grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class SetPermissionRequest : AmazonOpsWorksRequest
    {
        private string stackId;
        private string iamUserArn;
        private bool? allowSsh;
        private bool? allowSudo;
        private string level;


        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

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
        /// The user is allowed to use SSH to communicate with the instance.
        ///  
        /// </summary>
        public bool AllowSsh
        {
            get { return this.allowSsh ?? default(bool); }
            set { this.allowSsh = value; }
        }

        // Check to see if AllowSsh property is set
        internal bool IsSetAllowSsh()
        {
            return this.allowSsh.HasValue;
        }

        /// <summary>
        /// The user is allowed to use <b>sudo</b> to elevate privileges.
        ///  
        /// </summary>
        public bool AllowSudo
        {
            get { return this.allowSudo ?? default(bool); }
            set { this.allowSudo = value; }
        }

        // Check to see if AllowSudo property is set
        internal bool IsSetAllowSudo()
        {
            return this.allowSudo.HasValue;
        }

        /// <summary>
        /// The user's permission level, which must be set to one of the following strings. You cannot set your own permissions level. <ul>
        /// <li><c>deny</c></li> <li><c>show</c></li> <li><c>deploy</c></li> <li><c>manage</c></li> <li><c>iam_only</c></li> </ul> For more information
        /// on the permissions associated with these levels, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing User Permissions</a>
        ///  
        /// </summary>
        public string Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this.level != null;
        }

    }
}
    
