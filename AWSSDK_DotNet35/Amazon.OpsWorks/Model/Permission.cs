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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes stack or user permissions.</para>
    /// </summary>
    public class Permission
    {
        
        private string stackId;
        private string iamUserArn;
        private bool? allowSsh;
        private bool? allowSudo;
        private string level;


        /// <summary>
        /// A stack ID.
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
        /// The Amazon Resource Name (ARN) for an AWS Identity and Access Management (IAM) role. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
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
        /// Whether the user can use SSH.
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
        /// Whether the user can use <b>sudo</b>.
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
        /// The user's permission level, which must be the following: <ul> <li><c>deny</c></li> <li><c>show</c></li> <li><c>deploy</c></li>
        /// <li><c>manage</c></li> <li><c>iam_only</c></li> </ul> For more information on the permissions associated with these levels, see <a
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
