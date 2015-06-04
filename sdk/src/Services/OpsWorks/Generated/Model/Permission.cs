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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
    /// Describes stack or user permissions.
    /// </summary>
    public partial class Permission
    {
        private bool? _allowSsh;
        private bool? _allowSudo;
        private string _iamUserArn;
        private string _level;
        private string _stackId;

        /// <summary>
        /// Gets and sets the property AllowSsh. 
        /// <para>
        /// Whether the user can use SSH.
        /// </para>
        /// </summary>
        public bool AllowSsh
        {
            get { return this._allowSsh.GetValueOrDefault(); }
            set { this._allowSsh = value; }
        }

        // Check to see if AllowSsh property is set
        internal bool IsSetAllowSsh()
        {
            return this._allowSsh.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowSudo. 
        /// <para>
        /// Whether the user can use <b>sudo</b>.
        /// </para>
        /// </summary>
        public bool AllowSudo
        {
            get { return this._allowSudo.GetValueOrDefault(); }
            set { this._allowSudo = value; }
        }

        // Check to see if AllowSudo property is set
        internal bool IsSetAllowSudo()
        {
            return this._allowSudo.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamUserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for an AWS Identity and Access Management (IAM) role.
        /// For more information about IAM ARNs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using
        /// Identifiers</a>.
        /// </para>
        /// </summary>
        public string IamUserArn
        {
            get { return this._iamUserArn; }
            set { this._iamUserArn = value; }
        }

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this._iamUserArn != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The user's permission level, which must be the following:
        /// </para>
        ///  <ul> <li> <code>deny</code> </li> <li> <code>show</code> </li> <li> <code>deploy</code>
        /// </li> <li> <code>manage</code> </li> <li> <code>iam_only</code> </li> </ul> 
        /// <para>
        /// For more information on the permissions associated with these levels, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>
        /// </para>
        /// </summary>
        public string Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// A stack ID.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}