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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRole operation.
    /// Creates a new role for your AWS account. For more information about roles, go to <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">IAM Roles</a>.
    /// For information about limitations on role names and the number of roles you can create,
    /// go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
    /// on IAM Entities</a> in the <i>IAM User Guide</i>.
    /// </summary>
    public partial class CreateRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string _assumeRolePolicyDocument;
        private string _description;
        private int? _maxSessionDuration;
        private string _path;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property AssumeRolePolicyDocument. 
        /// <para>
        /// The trust relationship policy document that grants an entity permission to assume
        /// the role.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (\u0020) through the
        /// end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// \u00FF)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (\u0009), line feed (\u000A), and carriage return (\u000D)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string AssumeRolePolicyDocument
        {
            get { return this._assumeRolePolicyDocument; }
            set { this._assumeRolePolicyDocument = value; }
        }

        // Check to see if AssumeRolePolicyDocument property is set
        internal bool IsSetAssumeRolePolicyDocument()
        {
            return this._assumeRolePolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the role.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The maximum session duration (in seconds) that you want to set for the specified role.
        /// If you do not specify a value for this setting, the default maximum of one hour is
        /// applied. This setting can have a value from 1 hour to 12 hours.
        /// </para>
        ///  
        /// <para>
        /// Anyone who assumes the role from the AWS CLI or API can use the <code>DurationSeconds</code>
        /// API parameter or the <code>duration-seconds</code> CLI parameter to request a longer
        /// session. The <code>MaxSessionDuration</code> setting determines the maximum duration
        /// that can be requested using the <code>DurationSeconds</code> parameter. If users don't
        /// specify a value for the <code>DurationSeconds</code> parameter, their security credentials
        /// are valid for one hour by default. This applies when you use the <code>AssumeRole*</code>
        /// API operations or the <code>assume-role*</code> CLI operations but does not apply
        /// when you use those operations to create a console URL. For more information, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using IAM
        /// Roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public int MaxSessionDuration
        {
            get { return this._maxSessionDuration.GetValueOrDefault(); }
            set { this._maxSessionDuration = value; }
        }

        // Check to see if MaxSessionDuration property is set
        internal bool IsSetMaxSessionDuration()
        {
            return this._maxSessionDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path to the role. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/).
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of either a forward slash (/) by itself or a string
        /// that must begin and end with forward slashes. In addition, it can contain any ASCII
        /// character from the ! (\u0021) through the DEL character (\u007F), including most punctuation
        /// characters, digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role to create.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        ///  
        /// <para>
        /// Role names are not distinguished by case. For example, you cannot create roles named
        /// both "PRODROLE" and "prodrole".
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}