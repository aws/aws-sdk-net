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
    /// Container for the parameters to the CreateGroup operation.
    /// Creates a new group.
    /// 
    ///  
    /// <para>
    ///  For information about the number of groups you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
    /// on IAM Entities</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateGroupRequest : AmazonIdentityManagementServiceRequest
    {
        private string _groupName;
        private string _path;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateGroupRequest() { }

        /// <summary>
        /// Instantiates CreateGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">The name of the group to create. Do not include the path in this value. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for this parameter is a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: =,.@-. The group name must be unique within the account. Group names are not distinguished by case. For example, you cannot create groups named both "ADMINS" and "admins".</param>
        public CreateGroupRequest(string groupName)
        {
            _groupName = groupName;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group to create. Do not include the path in this value.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for this parameter
        /// is a string of characters consisting of upper and lowercase alphanumeric characters
        /// with no spaces. You can also include any of the following characters: =,.@-. The group
        /// name must be unique within the account. Group names are not distinguished by case.
        /// For example, you cannot create groups named both "ADMINS" and "admins".
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path to the group. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/).
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for this parameter
        /// is a string of characters consisting of either a forward slash (/) by itself or a
        /// string that must begin and end with forward slashes, containing any ASCII character
        /// from the ! (\u0021) thru the DEL character (\u007F), including most punctuation characters,
        /// digits, and upper and lowercased letters.
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

    }
}